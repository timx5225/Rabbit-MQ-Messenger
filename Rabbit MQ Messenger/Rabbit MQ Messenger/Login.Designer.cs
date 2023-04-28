namespace Rabbit_MQ_Messenger
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            usernameText = new MaterialSkin.Controls.MaterialTextBox();
            passwordText = new MaterialSkin.Controls.MaterialTextBox();
            passwordLabel = new Label();
            signInButton = new Button();
            registerButton = new Button();
            registerLabel = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(223, 208);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(201, 47);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // usernameText
            // 
            usernameText.AnimateReadOnly = false;
            usernameText.BorderStyle = BorderStyle.None;
            usernameText.Depth = 0;
            usernameText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameText.LeadingIcon = null;
            usernameText.Location = new Point(459, 205);
            usernameText.MaxLength = 50;
            usernameText.MouseState = MaterialSkin.MouseState.OUT;
            usernameText.Multiline = false;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(450, 50);
            usernameText.TabIndex = 2;
            usernameText.Text = "";
            usernameText.TrailingIcon = null;
            // 
            // passwordText
            // 
            passwordText.AnimateReadOnly = false;
            passwordText.BorderStyle = BorderStyle.None;
            passwordText.Depth = 0;
            passwordText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordText.LeadingIcon = null;
            passwordText.Location = new Point(459, 323);
            passwordText.MaxLength = 50;
            passwordText.MouseState = MaterialSkin.MouseState.OUT;
            passwordText.Multiline = false;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(450, 50);
            passwordText.TabIndex = 4;
            passwordText.Text = "";
            passwordText.TrailingIcon = null;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(223, 326);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(191, 47);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.DeepSkyBlue;
            signInButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            signInButton.Location = new Point(478, 505);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(117, 62);
            signInButton.TabIndex = 5;
            signInButton.Text = "Sign in";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.LightSalmon;
            registerButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.Location = new Point(760, 505);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(117, 62);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.DodgerBlue;
            registerLabel.Location = new Point(642, 443);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(317, 30);
            registerLabel.TabIndex = 7;
            registerLabel.Text = "No account? Register here";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            Controls.Add(registerLabel);
            Controls.Add(registerButton);
            Controls.Add(signInButton);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Controls.Add(usernameText);
            Controls.Add(usernameLabel);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Login";
            Padding = new Padding(5, 102, 5, 5);
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label usernameLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameText;
        private MaterialSkin.Controls.MaterialTextBox passwordText;
        private Label passwordLabel;
        private Button signInButton;
        private Button registerButton;
        private Label registerLabel;
    }
}