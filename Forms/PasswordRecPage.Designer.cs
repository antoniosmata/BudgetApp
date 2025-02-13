namespace BudgetApp.Forms
{
    partial class PasswordRecPage
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
            resetPasswordButton = new Button();
            answerTextBox = new TextBox();
            answerLabel = new Label();
            securityQuesLabel = new Label();
            userNameTextBox = new TextBox();
            usernameLabel = new Label();
            forgotPasswordLabel = new Label();
            instructionsLabel1 = new Label();
            instructionsLabel2 = new Label();
            securityQuestionTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            reenterPasswordTextBox = new TextBox();
            reenterPasswordLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // resetPasswordButton
            // 
            resetPasswordButton.BackColor = Color.Gainsboro;
            resetPasswordButton.Font = new Font("Segoe UI", 9.75F);
            resetPasswordButton.Location = new Point(401, 386);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new Size(75, 29);
            resetPasswordButton.TabIndex = 22;
            resetPasswordButton.Text = "Reset";
            resetPasswordButton.UseVisualStyleBackColor = false;
            resetPasswordButton.Click += resetPasswordButton_Click;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(246, 237);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(230, 29);
            answerTextBox.TabIndex = 21;
            answerTextBox.TextChanged += answerTextBox_TextChanged;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(153, 240);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(65, 21);
            answerLabel.TabIndex = 20;
            answerLabel.Text = "Answer:";
            // 
            // securityQuesLabel
            // 
            securityQuesLabel.AutoSize = true;
            securityQuesLabel.Location = new Point(82, 203);
            securityQuesLabel.Name = "securityQuesLabel";
            securityQuesLabel.Size = new Size(136, 21);
            securityQuesLabel.TabIndex = 19;
            securityQuesLabel.Text = "Security Question:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(246, 164);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(230, 29);
            userNameTextBox.TabIndex = 24;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(134, 167);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(84, 21);
            usernameLabel.TabIndex = 23;
            usernameLabel.Text = "Username:";
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            forgotPasswordLabel.Location = new Point(199, 72);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(184, 30);
            forgotPasswordLabel.TabIndex = 25;
            forgotPasswordLabel.Text = "Forgot Password?";
            // 
            // instructionsLabel1
            // 
            instructionsLabel1.AutoSize = true;
            instructionsLabel1.Font = new Font("Segoe UI", 9.75F);
            instructionsLabel1.Location = new Point(97, 113);
            instructionsLabel1.Margin = new Padding(4, 0, 4, 0);
            instructionsLabel1.Name = "instructionsLabel1";
            instructionsLabel1.Size = new Size(402, 17);
            instructionsLabel1.TabIndex = 26;
            instructionsLabel1.Text = "Please enter your username and response to your security question";
            // 
            // instructionsLabel2
            // 
            instructionsLabel2.AutoSize = true;
            instructionsLabel2.Font = new Font("Segoe UI", 9.75F);
            instructionsLabel2.Location = new Point(218, 130);
            instructionsLabel2.Margin = new Padding(4, 0, 4, 0);
            instructionsLabel2.Name = "instructionsLabel2";
            instructionsLabel2.Size = new Size(147, 17);
            instructionsLabel2.TabIndex = 27;
            instructionsLabel2.Text = "to reset your password.";
            // 
            // securityQuestionTextBox
            // 
            securityQuestionTextBox.Location = new Point(246, 200);
            securityQuestionTextBox.Name = "securityQuestionTextBox";
            securityQuestionTextBox.Size = new Size(230, 29);
            securityQuestionTextBox.TabIndex = 28;
            securityQuestionTextBox.TextChanged += securityQuestionTextBox_TextChanged;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(246, 301);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(230, 29);
            newPasswordTextBox.TabIndex = 30;
            newPasswordTextBox.TextChanged += regisPasswordTextBox_TextChanged;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(103, 304);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(115, 21);
            newPasswordLabel.TabIndex = 29;
            newPasswordLabel.Text = "New Password:";
            // 
            // reenterPasswordTextBox
            // 
            reenterPasswordTextBox.Location = new Point(246, 336);
            reenterPasswordTextBox.Name = "reenterPasswordTextBox";
            reenterPasswordTextBox.Size = new Size(230, 29);
            reenterPasswordTextBox.TabIndex = 32;
            reenterPasswordTextBox.TextChanged += reenterPasswordTextBox_TextChanged;
            // 
            // reenterPasswordLabel
            // 
            reenterPasswordLabel.AutoSize = true;
            reenterPasswordLabel.Location = new Point(75, 339);
            reenterPasswordLabel.Name = "reenterPasswordLabel";
            reenterPasswordLabel.Size = new Size(143, 21);
            reenterPasswordLabel.TabIndex = 31;
            reenterPasswordLabel.Text = "Re-enter Password:";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Gainsboro;
            backButton.Font = new Font("Segoe UI", 9.75F);
            backButton.Location = new Point(246, 386);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 29);
            backButton.TabIndex = 33;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // PasswordRecPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 457);
            Controls.Add(backButton);
            Controls.Add(reenterPasswordTextBox);
            Controls.Add(reenterPasswordLabel);
            Controls.Add(newPasswordTextBox);
            Controls.Add(newPasswordLabel);
            Controls.Add(securityQuestionTextBox);
            Controls.Add(instructionsLabel2);
            Controls.Add(instructionsLabel1);
            Controls.Add(forgotPasswordLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(resetPasswordButton);
            Controls.Add(answerTextBox);
            Controls.Add(answerLabel);
            Controls.Add(securityQuesLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "PasswordRecPage";
            Text = "PasswordRecPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetPasswordButton;
        private TextBox answerTextBox;
        private Label answerLabel;
        private Label securityQuesLabel;
        private TextBox userNameTextBox;
        private Label usernameLabel;
        private Label forgotPasswordLabel;
        private Label instructionsLabel1;
        private Label instructionsLabel2;
        private TextBox securityQuestionTextBox;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private TextBox reenterPasswordTextBox;
        private Label reenterPasswordLabel;
        private Button backButton;
    }
}