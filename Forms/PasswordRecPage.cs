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
using BudgetApp.Models;

namespace BudgetApp.Forms
{
    public partial class PasswordRecPage : Form
    {
        private readonly DatabaseConnection db;
        private User currentUser;

        /// <summary>
        /// Constructor
        /// </summary>
        public PasswordRecPage()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            SetupForm();
        }

        /// <summary>
        /// Password Reset Form
        /// </summary>
        private void SetupForm()
        {
            // sets character to hide password as its being entered
            newPasswordTextBox.PasswordChar = '•';
            reenterPasswordTextBox.PasswordChar = '•';

            // sets security question in the textbox as read-only
            securityQuestionTextBox.ReadOnly = true;

            // disables all text boxes until the username is verified within the database
            securityQuestionTextBox.Enabled = false;
            answerTextBox.Enabled = false;
            newPasswordTextBox.Enabled = false;
            reenterPasswordTextBox.Enabled = false;
            resetPasswordButton.Enabled = false;
        }

        /// <summary>
        /// Handles inputted username events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string username = userNameTextBox.Text.Trim();

                // clears security question and disables fields if username textbox is emopty
                if (string.IsNullOrEmpty(username))
                {
                    securityQuestionTextBox.Clear();
                    return;
                }

                // gets the corresponding secuirty question for the username in the database
                currentUser = db.GetUserByUsername(username);
                if (currentUser != null)
                {
                    securityQuestionTextBox.Text = currentUser.SecurityQuestion;
                    answerTextBox.Enabled = true; // enables subsequent field
                    securityQuestionTextBox.Enabled = true;
                }
                else
                {
                    // if username is not found, fields are cleared and disabled
                    securityQuestionTextBox.Clear();
                    answerTextBox.Clear();
                    answerTextBox.Enabled = false;
                    securityQuestionTextBox.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // handles errors while connecting to the database
                MessageBox.Show($"Error retrieving user information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Correct answer to security question event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            // compares database security answer to inputted answer
            if (currentUser != null &&
                answerTextBox.Text.Trim().Equals(currentUser.SecurityAnswer, StringComparison.OrdinalIgnoreCase))
            {
                // enables password reset boxes answers match
                newPasswordTextBox.Enabled = true;
                reenterPasswordTextBox.Enabled = true;
                resetPasswordButton.Enabled = true;
            }
            else
            {
                // disbales boxes for an incorrect answer
                newPasswordTextBox.Enabled = false;
                reenterPasswordTextBox.Enabled = false;
                resetPasswordButton.Enabled = false;
            }
        }

        // placeholders for boxes
        private void regisPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void reenterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void securityQuestionTextBox_TextChanged(object sender, EventArgs e)
        {
            // no logic needed
        }

        /// <summary>
        /// Checks if new entered password is the same (enter password & re-enter password)
        /// </summary>
        /// <returns></returns>
        private bool ValidatePasswords()
        {
            // sets rule for password length
            if (newPasswordTextBox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // checks if passwords match
            if (newPasswordTextBox.Text != reenterPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Reset Password button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentUser == null)
                {
                    MessageBox.Show("Please enter a valid username.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (string.IsNullOrEmpty(newPasswordTextBox.Text))
                {
                    MessageBox.Show("Please enter a new password.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // starts validating passwords only when button is clicked
                if (!ValidatePasswords())
                {
                    return;
                }

                // updates stored password in database
                if (db.UpdatePassword(currentUser.Username, newPasswordTextBox.Text))
                {
                    MessageBox.Show("Password successfully reset! Please login with your new password.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // redirects to login page
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    this.Hide();
                }
                else
                {
                    // throws error if passowrd reset failed
                    MessageBox.Show("Failed to reset password. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // error message for any unforseen errors
                MessageBox.Show($"Error resetting password: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Back button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            // creates new login page instance and redirects to it
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide(); 
        }

    }
}