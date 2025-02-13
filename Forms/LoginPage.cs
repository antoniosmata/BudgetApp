using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetApp.DataAccess;


namespace BudgetApp.Forms
{
    public partial class LoginPage : Form
    {
        // manages database connections
        private readonly DatabaseConnection db;

        /// <summary>
        /// Constructor
        /// </summary>
        public LoginPage()
        {
            InitializeComponent(); // initializes UI components
            db = new DatabaseConnection();
            SetupForm();
        }

        private void SetupForm()
        {
            // hides password with designated character
            textBox1.PasswordChar = '•';

            // sets focus to the username textbox
            usernameTextBox.Focus();
        }

        /// <summary>
        /// Boolean method checks to make sure the user inputs are entered correctly
        /// </summary>
        /// <returns></returns>
        private bool ValidateInputs() 
        {
            // checks if the username space is empty or only has whitespace
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", // displays popup warning
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus(); 
                return false; // returns false, indicating validation input failed
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // checks if all conditions are met for a successful submission
            try
            {
                if (!ValidateInputs())
                    return;

                // gets trimmed (removed whitespace) username and plaintext password from text boxes
                string username = usernameTextBox.Text.Trim();
                string password = textBox1.Text;

                // validates user information against database
                var user = db.ValidateUser(username, password);

                if (user != null)
                {
                    // displays success message if valid credentials are submitted
                    MessageBox.Show("Login successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // creates new dashboard instance and displays it; hides current Login form
                    DashboardPage dashboardPage = new DashboardPage(user);  // Pass the user object 
                    dashboardPage.Show();
                    this.Hide();
                }
                else
                {
                    // if credentials are wrong, displays error message
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // handles any unexpected errors 
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Register Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            // creates new registerPage instance and hides current view
            Register registerPage = new Register();
            registerPage.Show();
            this.Hide();
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // redirects to password recovery page
            PasswordRecPage passwordRecPage = new PasswordRecPage();
            passwordRecPage.Show();
            this.Hide();
        }

        // allows for ENTER key to be used instead of clicked login button
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                button1_Click(this, EventArgs.Empty); // creates a login button click event
                return true; // returns true meaning ENTER key process was handled
            }
            return base.ProcessCmdKey(ref msg, keyData); // sets all other keys to their normal functions 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        // no logic needed
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void usernameLabel_Click(object sender, EventArgs e) { }
        private void LoginPage_Load(object sender, EventArgs e) { }
    }
}