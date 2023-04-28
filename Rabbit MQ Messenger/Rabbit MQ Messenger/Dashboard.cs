using MaterialSkin.Controls;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Rabbit_MQ_Messenger
{
    public partial class Dashboard : MaterialForm
    {
        private string currentUsername;
        private IConnection connection;
        private IModel channel;
        public Dashboard(string username)
        {
            InitializeComponent();
            currentUsername = username;
            PopulateFriendList();

            // create connection factory
            var factory = new ConnectionFactory { HostName = "localhost" };

            // create connection and channel
            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            // create exchange and queue
            channel.ExchangeDeclare("line-exchange", ExchangeType.Direct);
            channel.QueueDeclare(currentUsername, false, false, false, null);
            channel.QueueBind(currentUsername, "line-exchange", currentUsername);

            // create consumer
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var message = Encoding.UTF8.GetString(ea.Body.ToArray());
                consoleText.Invoke(new Action(() =>
                {
                    consoleText.AppendText($"Received message: {message}\r\n");
                }));

            };
            channel.BasicConsume(currentUsername, true, consumer);
        }


        private void PopulateFriendList()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Friendname FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable friendListTable = new DataTable();
                        adapter.Fill(friendListTable);

                        friendListDataGridView.DataSource = friendListTable;
                    }
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string friendUsername = usernameText.Text.Trim();
            string message = messageText.Text;

            // Check if the user is trying to send a message to themselves
            if (friendUsername == currentUsername)
            {
                MessageBox.Show("You cannot send a message to yourself.");
                return;
            }

            // Check if the friend is in the user's friend list
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS AND Friendname COLLATE Latin1_General_CS_AS = @Friendname COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("User is not in your friend list.");
                        return;
                    }
                }
            }

            // written to disk and stored even if the broker or server crashes
            var properties = channel.CreateBasicProperties();
            properties.Persistent = true;

            // publish message to exchange
            channel.BasicPublish("line-exchange", friendUsername, properties, Encoding.UTF8.GetBytes(message));

            consoleText.AppendText($"Sent message to {friendUsername}: {message}\r\n");

            messageText.Clear();
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            string friendUsername = usernameText.Text.Trim();

            // Check if the user is trying to add themselves as a friend
            if (friendUsername == currentUsername)
            {
                MessageBox.Show("You cannot add yourself as a friend.");
                return;
            }

            // Establish connection with SQL Server
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                // Check if the username exists in the Users table
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", friendUsername);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("User does not exist in the database");
                        return;
                    }
                }

                // Check if the two users are already friends
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS AND Friendname COLLATE Latin1_General_CS_AS = @Friendname COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Users are already friends");
                        return;
                    }
                }

                // Insert data into the Friendlist table
                using (SqlCommand command = new SqlCommand("INSERT INTO Friendlist (Username, Friendname) VALUES (@Username, @Friendname)", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Friend added successfully");
                        PopulateFriendList(); // Refresh the friend list
                    }
                    else
                    {
                        MessageBox.Show("User does not exist in the database");
                    }
                }
            }
        }

        private void deleteFriendButton_Click(object sender, EventArgs e)
        {
            string friendUsername = usernameText.Text.Trim();

            // Establish connection with SQL Server
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J8FC3U1\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;Pooling=False"))
            {
                connection.Open();

                // Delete the friend from the Friendlist table
                using (SqlCommand command = new SqlCommand("DELETE FROM Friendlist WHERE Username COLLATE Latin1_General_CS_AS = @Username COLLATE Latin1_General_CS_AS AND Friendname COLLATE Latin1_General_CS_AS = @Friendname COLLATE Latin1_General_CS_AS", connection))
                {
                    command.Parameters.AddWithValue("@Username", currentUsername);
                    command.Parameters.AddWithValue("@Friendname", friendUsername);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Friend deleted successfully");
                        PopulateFriendList(); // Refresh the friend list
                    }
                    else
                    {
                        MessageBox.Show("Friend does not exist in the database");
                    }
                }
            }
        }
    }
}