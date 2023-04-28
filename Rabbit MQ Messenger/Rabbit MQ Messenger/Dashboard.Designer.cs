namespace Rabbit_MQ_Messenger
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            friendList = new Panel();
            friendListDataGridView = new DataGridView();
            friendListLabel = new Label();
            consoleText = new TextBox();
            messageText = new MaterialSkin.Controls.MaterialTextBox();
            messageLabel = new Label();
            usernameText = new MaterialSkin.Controls.MaterialTextBox();
            usernameLabel = new Label();
            sendButton = new Button();
            addFriendButton = new Button();
            deleteFriendButton = new Button();
            friendList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)friendListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // friendList
            // 
            friendList.Controls.Add(friendListDataGridView);
            friendList.Controls.Add(friendListLabel);
            friendList.Dock = DockStyle.Left;
            friendList.Location = new Point(3, 64);
            friendList.Name = "friendList";
            friendList.Size = new Size(274, 653);
            friendList.TabIndex = 2;
            // 
            // friendListDataGridView
            // 
            friendListDataGridView.AllowUserToAddRows = false;
            friendListDataGridView.AllowUserToDeleteRows = false;
            friendListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            friendListDataGridView.Dock = DockStyle.Bottom;
            friendListDataGridView.Location = new Point(0, 44);
            friendListDataGridView.Name = "friendListDataGridView";
            friendListDataGridView.ReadOnly = true;
            friendListDataGridView.RowTemplate.Height = 25;
            friendListDataGridView.Size = new Size(274, 609);
            friendListDataGridView.TabIndex = 11;
            friendListDataGridView.TabStop = false;
            // 
            // friendListLabel
            // 
            friendListLabel.AutoSize = true;
            friendListLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            friendListLabel.Location = new Point(0, 0);
            friendListLabel.Name = "friendListLabel";
            friendListLabel.Size = new Size(202, 47);
            friendListLabel.TabIndex = 10;
            friendListLabel.Text = "Friend List";
            // 
            // consoleText
            // 
            consoleText.Location = new Point(377, 386);
            consoleText.Multiline = true;
            consoleText.Name = "consoleText";
            consoleText.ReadOnly = true;
            consoleText.Size = new Size(686, 294);
            consoleText.TabIndex = 20;
            // 
            // messageText
            // 
            messageText.AnimateReadOnly = false;
            messageText.BorderStyle = BorderStyle.None;
            messageText.Depth = 0;
            messageText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            messageText.LeadingIcon = null;
            messageText.Location = new Point(613, 223);
            messageText.MaxLength = 50;
            messageText.MouseState = MaterialSkin.MouseState.OUT;
            messageText.Multiline = false;
            messageText.Name = "messageText";
            messageText.Size = new Size(450, 50);
            messageText.TabIndex = 8;
            messageText.Text = "";
            messageText.TrailingIcon = null;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            messageLabel.Location = new Point(377, 226);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(178, 47);
            messageLabel.TabIndex = 7;
            messageLabel.Text = "Message";
            // 
            // usernameText
            // 
            usernameText.AnimateReadOnly = false;
            usernameText.BorderStyle = BorderStyle.None;
            usernameText.Depth = 0;
            usernameText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameText.LeadingIcon = null;
            usernameText.Location = new Point(613, 105);
            usernameText.MaxLength = 50;
            usernameText.MouseState = MaterialSkin.MouseState.OUT;
            usernameText.Multiline = false;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(450, 50);
            usernameText.TabIndex = 6;
            usernameText.Text = "";
            usernameText.TrailingIcon = null;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(377, 108);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(201, 47);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username";
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.CornflowerBlue;
            sendButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sendButton.Location = new Point(957, 307);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(106, 62);
            sendButton.TabIndex = 11;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_Click;
            // 
            // addFriendButton
            // 
            addFriendButton.BackColor = Color.MediumSpringGreen;
            addFriendButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addFriendButton.Location = new Point(613, 307);
            addFriendButton.Name = "addFriendButton";
            addFriendButton.Size = new Size(153, 62);
            addFriendButton.TabIndex = 9;
            addFriendButton.Text = "Add Friend";
            addFriendButton.UseVisualStyleBackColor = false;
            addFriendButton.Click += addFriendButton_Click;
            // 
            // deleteFriendButton
            // 
            deleteFriendButton.BackColor = Color.Tomato;
            deleteFriendButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            deleteFriendButton.Location = new Point(772, 307);
            deleteFriendButton.Name = "deleteFriendButton";
            deleteFriendButton.Size = new Size(179, 62);
            deleteFriendButton.TabIndex = 10;
            deleteFriendButton.Text = "Delete Friend";
            deleteFriendButton.UseVisualStyleBackColor = false;
            deleteFriendButton.Click += deleteFriendButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            Controls.Add(deleteFriendButton);
            Controls.Add(addFriendButton);
            Controls.Add(sendButton);
            Controls.Add(messageText);
            Controls.Add(messageLabel);
            Controls.Add(usernameText);
            Controls.Add(usernameLabel);
            Controls.Add(consoleText);
            Controls.Add(friendList);
            Name = "Dashboard";
            Text = "Rabbit MQ Messenger";
            friendList.ResumeLayout(false);
            friendList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)friendListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel friendList;
        private TextBox consoleText;
        private MaterialSkin.Controls.MaterialTextBox messageText;
        private Label messageLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameText;
        private Label usernameLabel;
        private Button sendButton;
        private Label friendListLabel;
        private Button addFriendButton;
        private DataGridView friendListDataGridView;
        private Button deleteFriendButton;
    }
}