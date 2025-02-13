namespace BudgetApp.Forms
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
            dontHaveMessageLabel = new Label();
            regisUsernameLabel = new Label();
            regisPasswordLabel = new Label();
            regisEmailLabel = new Label();
            regisFirstNameLabel = new Label();
            regisLastNameLabel = new Label();
            regisSecurityQuestions = new ComboBox();
            regisSecurityQues = new Label();
            regisSecQuesAnswer = new Label();
            regisAnswerTextBox = new TextBox();
            regisFirstNameTextBox = new TextBox();
            regisEmailTextBox = new TextBox();
            regisPasswordTextBox = new TextBox();
            regisUserNameTextBox = new TextBox();
            regisLastNameTextBox = new TextBox();
            registerBelowLabel = new Label();
            regisRegisterButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // dontHaveMessageLabel
            // 
            dontHaveMessageLabel.AutoSize = true;
            dontHaveMessageLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            dontHaveMessageLabel.Location = new Point(109, 36);
            dontHaveMessageLabel.Margin = new Padding(4, 0, 4, 0);
            dontHaveMessageLabel.Name = "dontHaveMessageLabel";
            dontHaveMessageLabel.Size = new Size(216, 25);
            dontHaveMessageLabel.TabIndex = 1;
            dontHaveMessageLabel.Text = "Don't have an account? ";
            dontHaveMessageLabel.Click += dontHaveMessageLabel_Click;
            // 
            // regisUsernameLabel
            // 
            regisUsernameLabel.AutoSize = true;
            regisUsernameLabel.Location = new Point(114, 95);
            regisUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            regisUsernameLabel.Name = "regisUsernameLabel";
            regisUsernameLabel.Size = new Size(84, 21);
            regisUsernameLabel.TabIndex = 2;
            regisUsernameLabel.Text = "Username:";
            regisUsernameLabel.Click += regisUsernameLabel_Click;
            // 
            // regisPasswordLabel
            // 
            regisPasswordLabel.AutoSize = true;
            regisPasswordLabel.Location = new Point(119, 130);
            regisPasswordLabel.Name = "regisPasswordLabel";
            regisPasswordLabel.Size = new Size(79, 21);
            regisPasswordLabel.TabIndex = 3;
            regisPasswordLabel.Text = "Password:";
            // 
            // regisEmailLabel
            // 
            regisEmailLabel.AutoSize = true;
            regisEmailLabel.Location = new Point(147, 165);
            regisEmailLabel.Name = "regisEmailLabel";
            regisEmailLabel.Size = new Size(51, 21);
            regisEmailLabel.TabIndex = 4;
            regisEmailLabel.Text = "Email:";
            // 
            // regisFirstNameLabel
            // 
            regisFirstNameLabel.AutoSize = true;
            regisFirstNameLabel.Location = new Point(109, 218);
            regisFirstNameLabel.Name = "regisFirstNameLabel";
            regisFirstNameLabel.Size = new Size(89, 21);
            regisFirstNameLabel.TabIndex = 5;
            regisFirstNameLabel.Text = "First Name:";
            regisFirstNameLabel.Click += label1_Click_2;
            // 
            // regisLastNameLabel
            // 
            regisLastNameLabel.AutoSize = true;
            regisLastNameLabel.Location = new Point(111, 253);
            regisLastNameLabel.Name = "regisLastNameLabel";
            regisLastNameLabel.Size = new Size(87, 21);
            regisLastNameLabel.TabIndex = 6;
            regisLastNameLabel.Text = "Last Name:";
            // 
            // regisSecurityQuestions
            // 
            regisSecurityQuestions.FormattingEnabled = true;
            regisSecurityQuestions.Location = new Point(226, 303);
            regisSecurityQuestions.Name = "regisSecurityQuestions";
            regisSecurityQuestions.Size = new Size(230, 29);
            regisSecurityQuestions.TabIndex = 7;
            regisSecurityQuestions.SelectedIndexChanged += regisSecurityQuestions_SelectedIndexChanged;
            // 
            // regisSecurityQues
            // 
            regisSecurityQues.AutoSize = true;
            regisSecurityQues.Location = new Point(62, 306);
            regisSecurityQues.Name = "regisSecurityQues";
            regisSecurityQues.Size = new Size(136, 21);
            regisSecurityQues.TabIndex = 8;
            regisSecurityQues.Text = "Security Question:";
            // 
            // regisSecQuesAnswer
            // 
            regisSecQuesAnswer.AutoSize = true;
            regisSecQuesAnswer.Location = new Point(133, 343);
            regisSecQuesAnswer.Name = "regisSecQuesAnswer";
            regisSecQuesAnswer.Size = new Size(65, 21);
            regisSecQuesAnswer.TabIndex = 9;
            regisSecQuesAnswer.Text = "Answer:";
            // 
            // regisAnswerTextBox
            // 
            regisAnswerTextBox.Location = new Point(226, 343);
            regisAnswerTextBox.Name = "regisAnswerTextBox";
            regisAnswerTextBox.Size = new Size(230, 29);
            regisAnswerTextBox.TabIndex = 10;
            regisAnswerTextBox.TextChanged += regisAnswerTextBox_TextChanged;
            // 
            // regisFirstNameTextBox
            // 
            regisFirstNameTextBox.Location = new Point(226, 215);
            regisFirstNameTextBox.Name = "regisFirstNameTextBox";
            regisFirstNameTextBox.Size = new Size(230, 29);
            regisFirstNameTextBox.TabIndex = 11;
            regisFirstNameTextBox.TextChanged += regisFirstNameTextBox_TextChanged;
            // 
            // regisEmailTextBox
            // 
            regisEmailTextBox.Location = new Point(226, 162);
            regisEmailTextBox.Name = "regisEmailTextBox";
            regisEmailTextBox.Size = new Size(230, 29);
            regisEmailTextBox.TabIndex = 12;
            regisEmailTextBox.TextChanged += regisEmailTextBox_TextChanged;
            // 
            // regisPasswordTextBox
            // 
            regisPasswordTextBox.Location = new Point(226, 127);
            regisPasswordTextBox.Name = "regisPasswordTextBox";
            regisPasswordTextBox.Size = new Size(230, 29);
            regisPasswordTextBox.TabIndex = 13;
            regisPasswordTextBox.TextChanged += regisPasswordTextBox_TextChanged;
            // 
            // regisUserNameTextBox
            // 
            regisUserNameTextBox.Location = new Point(226, 92);
            regisUserNameTextBox.Name = "regisUserNameTextBox";
            regisUserNameTextBox.Size = new Size(230, 29);
            regisUserNameTextBox.TabIndex = 14;
            regisUserNameTextBox.TextChanged += regisUserNameTextBox_TextChanged;
            // 
            // regisLastNameTextBox
            // 
            regisLastNameTextBox.Location = new Point(226, 250);
            regisLastNameTextBox.Name = "regisLastNameTextBox";
            regisLastNameTextBox.Size = new Size(230, 29);
            regisLastNameTextBox.TabIndex = 15;
            regisLastNameTextBox.TextChanged += regisLastNameTextBox_TextChanged;
            // 
            // registerBelowLabel
            // 
            registerBelowLabel.AutoSize = true;
            registerBelowLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            registerBelowLabel.Location = new Point(316, 36);
            registerBelowLabel.Margin = new Padding(0);
            registerBelowLabel.Name = "registerBelowLabel";
            registerBelowLabel.Size = new Size(150, 25);
            registerBelowLabel.TabIndex = 16;
            registerBelowLabel.Text = "Register Below!";
            // 
            // regisRegisterButton
            // 
            regisRegisterButton.BackColor = Color.Gainsboro;
            regisRegisterButton.Font = new Font("Segoe UI", 9.75F);
            regisRegisterButton.Location = new Point(381, 393);
            regisRegisterButton.Name = "regisRegisterButton";
            regisRegisterButton.Size = new Size(75, 29);
            regisRegisterButton.TabIndex = 17;
            regisRegisterButton.Text = "Register";
            regisRegisterButton.UseVisualStyleBackColor = false;
            regisRegisterButton.Click += regisRegisterButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Gainsboro;
            backButton.Font = new Font("Segoe UI", 9.75F);
            backButton.Location = new Point(226, 393);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 29);
            backButton.TabIndex = 18;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 457);
            Controls.Add(backButton);
            Controls.Add(regisRegisterButton);
            Controls.Add(registerBelowLabel);
            Controls.Add(regisLastNameTextBox);
            Controls.Add(regisUserNameTextBox);
            Controls.Add(regisPasswordTextBox);
            Controls.Add(regisEmailTextBox);
            Controls.Add(regisFirstNameTextBox);
            Controls.Add(regisAnswerTextBox);
            Controls.Add(regisSecQuesAnswer);
            Controls.Add(regisSecurityQues);
            Controls.Add(regisSecurityQuestions);
            Controls.Add(regisLastNameLabel);
            Controls.Add(regisFirstNameLabel);
            Controls.Add(regisEmailLabel);
            Controls.Add(regisPasswordLabel);
            Controls.Add(regisUsernameLabel);
            Controls.Add(dontHaveMessageLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Register";
            Text = "Registration";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dontHaveMessageLabel;
        private Label regisUsernameLabel;
        private Label regisPasswordLabel;
        private Label regisEmailLabel;
        private Label regisFirstNameLabel;
        private Label regisLastNameLabel;
        private ComboBox regisSecurityQuestions;
        private Label regisSecurityQues;
        private Label regisSecQuesAnswer;
        private TextBox regisAnswerTextBox;
        private TextBox regisFirstNameTextBox;
        private TextBox regisEmailTextBox;
        private TextBox regisPasswordTextBox;
        private TextBox regisUserNameTextBox;
        private TextBox regisLastNameTextBox;
        private Label registerBelowLabel;
        private Button regisRegisterButton;
        private Button backButton;
    }
}