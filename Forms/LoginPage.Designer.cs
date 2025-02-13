namespace BudgetApp.Forms
{
    partial class LoginPage
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
            loginButton = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            forgotPasswordLink = new LinkLabel();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Gainsboro;
            loginButton.Font = new Font("Segoe UI", 9.75F);
            loginButton.Location = new Point(227, 233);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(74, 29);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(137, 140);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(84, 21);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(142, 186);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(79, 21);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += label1_Click_1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(227, 137);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(166, 29);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(318, 233);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 29);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label1.Location = new Point(227, 76);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 7;
            label1.Text = "Welcome!";
            label1.Click += label1_Click_2;
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.Font = new Font("Segoe UI", 9F);
            forgotPasswordLink.Location = new Point(227, 278);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(100, 15);
            forgotPasswordLink.TabIndex = 8;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot Password?";
            forgotPasswordLink.LinkClicked += forgotPasswordLink_LinkClicked;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 376);
            Controls.Add(forgotPasswordLink);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(loginButton);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "LoginPage";
            Text = "Login";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private LinkLabel forgotPasswordLink;
    }
}