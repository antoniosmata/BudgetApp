using System;
using System.Windows.Forms;
using BudgetApp.DataAccess;
using BudgetApp.Models;
using System.Text.RegularExpressions;

namespace BudgetApp.Forms
{
    public partial class Register : Form
    {
        private readonly DatabaseConnection db;

        /// <summary>
        /// Constructor
        /// </summary>
        public Register()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            SetupForm();
        }

        private void SetupForm()
        {
            // fills in security question options for drop down menu
            regisSecurityQuestions.Items.AddRange(new string[]
            {
                "What was your first pet's name?",
                "What city were you born in?",
                "What is your mother's maiden name?",
                "What was the name of your first school?",
                "What was your childhood nickname?"
            });

            // hides password characters with designated character
            regisPasswordTextBox.PasswordChar = '•';

            // creates combobox drop down menu
            regisSecurityQuestions.SelectedIndex = 0;
        }

        // missing event handler
        private void dontHaveMessageLabel_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void regisUsernameLabel_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        /// <summary>
        /// Loads form event previously initialized in contrusctor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Load(object sender, EventArgs e)
        {
          
        }

        private void regisAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void regisSecurityQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void regisUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void regisPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void regisEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void regisFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void regisLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        /// <summary>
        /// Validiation for inputted fields
        /// </summary>
        /// <returns></returns>
        private bool ValidateInputs()
        {
            // checks that no inputted fields are empty
            if (string.IsNullOrWhiteSpace(regisUserNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(regisPasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(regisEmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(regisFirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(regisLastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(regisAnswerTextBox.Text))
            {
                // if a field is empty, notifies user that all fields must be entered
                MessageBox.Show("All fields are required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // uses reglar expressions to get correct email format
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(regisEmailTextBox.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // makes passwords have a 6 character length requirement
            if (regisPasswordTextBox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // checks to see if a user with the same username already exists in the database
            if (db.UsernameExists(regisUserNameTextBox.Text))
            {
                MessageBox.Show("Username already exists. Please choose another.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Registration button events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regisRegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // tests the database connection
                if (!db.TestConnection())
                {
                    MessageBox.Show("Cannot connect to database. Please check your connection.", "Database Error");
                    return;
                }

                if (!ValidateInputs())
                    return;

                // creates new User object with user information
                User user = new User
                {
                    Username = regisUserNameTextBox.Text.Trim(),
                    Password = regisPasswordTextBox.Text,
                    Email = regisEmailTextBox.Text.Trim(),
                    FirstName = regisFirstNameTextBox.Text.Trim(),
                    LastName = regisLastNameTextBox.Text.Trim(),
                    SecurityQuestion = regisSecurityQuestions.SelectedItem.ToString(),
                    SecurityAnswer = regisAnswerTextBox.Text.Trim()
                };

                // feedback ui
                MessageBox.Show($"Attempting to register user:\nUsername: {user.Username}\nEmail: {user.Email}", "Loading...");

                // attempt to enter user information into the database
                if (db.RegisterUser(user))
                {
                    MessageBox.Show("Registration successful! Please login with your credentials.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // redirects to the login page
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Registration failed. Please check the error messages.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // displays any unexpected errors
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            // clears input fields from the registration form
            regisUserNameTextBox.Clear();
            regisPasswordTextBox.Clear();
            regisEmailTextBox.Clear();
            regisFirstNameTextBox.Clear();
            regisLastNameTextBox.Clear();
            regisAnswerTextBox.Clear();
            regisSecurityQuestions.SelectedIndex = 0; // resets drop down value baseline
        }

        /// <summary>
        /// Back button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            // redirects to login page
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide(); 
        }
    }
}