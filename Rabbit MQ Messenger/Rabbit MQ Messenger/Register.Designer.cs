namespace Rabbit_MQ_Messenger
{
    partial class Register
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
            registerButton = new Button();
            passwordText = new MaterialSkin.Controls.MaterialTextBox();
            passwordLabel = new Label();
            usernameText = new MaterialSkin.Controls.MaterialTextBox();
            usernameLabel = new Label();
            confirmPasswordText = new MaterialSkin.Controls.MaterialTextBox();
            confirmLabel = new Label();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.LightSalmon;
            registerButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.Location = new Point(629, 512);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(117, 62);
            registerButton.TabIndex = 15;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // passwordText
            // 
            passwordText.AnimateReadOnly = false;
            passwordText.BorderStyle = BorderStyle.None;
            passwordText.Depth = 0;
            passwordText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordText.LeadingIcon = null;
            passwordText.Location = new Point(464, 271);
            passwordText.MaxLength = 50;
            passwordText.MouseState = MaterialSkin.MouseState.OUT;
            passwordText.Multiline = false;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(450, 50);
            passwordText.TabIndex = 11;
            passwordText.Text = "";
            passwordText.TrailingIcon = null;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(228, 274);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(191, 47);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // usernameText
            // 
            usernameText.AnimateReadOnly = false;
            usernameText.BorderStyle = BorderStyle.None;
            usernameText.Depth = 0;
            usernameText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameText.LeadingIcon = null;
            usernameText.Location = new Point(464, 153);
            usernameText.MaxLength = 50;
            usernameText.MouseState = MaterialSkin.MouseState.OUT;
            usernameText.Multiline = false;
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(450, 50);
            usernameText.TabIndex = 9;
            usernameText.Text = "";
            usernameText.TrailingIcon = null;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(228, 156);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(201, 47);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username";
            // 
            // confirmPasswordText
            // 
            confirmPasswordText.AnimateReadOnly = false;
            confirmPasswordText.BorderStyle = BorderStyle.None;
            confirmPasswordText.Depth = 0;
            confirmPasswordText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            confirmPasswordText.LeadingIcon = null;
            confirmPasswordText.Location = new Point(464, 381);
            confirmPasswordText.MaxLength = 50;
            confirmPasswordText.MouseState = MaterialSkin.MouseState.OUT;
            confirmPasswordText.Multiline = false;
            confirmPasswordText.Name = "confirmPasswordText";
            confirmPasswordText.Size = new Size(450, 50);
            confirmPasswordText.TabIndex = 13;
            confirmPasswordText.Text = "";
            confirmPasswordText.TrailingIcon = null;
            // 
            // confirmLabel
            // 
            confirmLabel.AutoSize = true;
            confirmLabel.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            confirmLabel.Location = new Point(73, 384);
            confirmLabel.Name = "confirmLabel";
            confirmLabel.Size = new Size(346, 47);
            confirmLabel.TabIndex = 14;
            confirmLabel.Text = "Confirm Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            Controls.Add(confirmPasswordText);
            Controls.Add(confirmLabel);
            Controls.Add(registerButton);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Controls.Add(usernameText);
            Controls.Add(usernameLabel);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button registerButton;
        private MaterialSkin.Controls.MaterialTextBox passwordText;
        private Label passwordLabel;
        private MaterialSkin.Controls.MaterialTextBox usernameText;
        private Label usernameLabel;
        private MaterialSkin.Controls.MaterialTextBox confirmPasswordText;
        private Label confirmLabel;
    }
}