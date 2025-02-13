using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetApp.DataAccess;
using BudgetApp.Models;

namespace BudgetApp.Forms
{
    public partial class BudgetCalculatorPage : Form
    {
        private decimal totalIncome = 0; // store total income value
        private decimal totalExpenses = 0; // store total expenses value
        private readonly DatabaseConnection db; 
        private User currentUser; // holds the current user data

        public BudgetCalculatorPage(User user)
        {
            InitializeComponent(); // initializes form components
            db = new DatabaseConnection(); 
            currentUser = user; 
            SetupForm(); 
        }

        private void LoadExistingData()
        {
            // retrieves and loads current month's expenses for the current user from the database
            var expenses = db.GetCurrentMonthExpenses(currentUser.UserID);
            if (expenses != null)
            {
                // if expenses exist, populate the TextBoxes with existing values or "0" if null
                rentTextBox.Text = expenses.Rent?.ToString() ?? "0";
                waterTextBox.Text = expenses.WaterBill?.ToString() ?? "0";
                naturalGasTextbox.Text = expenses.NaturalGas?.ToString() ?? "0";
                electricityTextBox.Text = expenses.Electricity?.ToString() ?? "0";
                cableTextBox.Text = expenses.Cable?.ToString() ?? "0";
                phoneTextBox.Text = expenses.Phone?.ToString() ?? "0";
                gasTextBox.Text = expenses.Gas?.ToString() ?? "0";
                maintenanceTextBox.Text = expenses.Maintenance?.ToString() ?? "0";
                groceriesTextBox.Text = expenses.Groceries?.ToString() ?? "0";
                restaurantTextBox.Text = expenses.Restaurants?.ToString() ?? "0";
                healthTextBox.Text = expenses.HealthInsurance?.ToString() ?? "0";
                autoTextBox.Text = expenses.AutoInsurance?.ToString() ?? "0";
                otherTextBox.Text = expenses.OtherExpenses?.ToString() ?? "0";
            }

            // load savings data
            var savings = db.GetCurrentSavings(currentUser.UserID);
            if (savings != null)
            {
                emergencyFundTextBox.Text = savings.EmergencyFund?.ToString() ?? "0";
            }

            // retrieves and loads latest income data for the user
            var income = db.GetLatestIncome(currentUser.UserID);
            if (income != null)
            {
                // if income exists, populate the TextBoxes with the income values or "0" if null
                paycheckTextbox1.Text = income.Paycheck1?.ToString() ?? "0";
                paycheckTextbox2.Text = income.Paycheck2?.ToString() ?? "0";
            }

            UpdateCalculations();
        }

        private void SetupForm()
        {
            // add numeric validation to all TextBoxes
            foreach (Control panel in Controls)
            {
                if (panel is Panel)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is TextBox textBox)
                        {
                            textBox.KeyPress += ValidateDecimalInput; // add validation to allow only digits and decimals
                            if (string.IsNullOrEmpty(textBox.Text))
                                textBox.Text = "0"; // set default value to "0" if the TextBox is empty
                        }
                    }
                }
            }

            // initialize the left-to-spend amount and load data
            UpdateCalculations();
            LoadExistingData(); 
            userDashboardName.Text = $"{currentUser.FirstName} {currentUser.LastName}"; // display the user's name
        }

        /// <summary>
        /// Method of validating user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateDecimalInput(object sender, KeyPressEventArgs e)
        {
            // allow only digits, decimal point, and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // prevent invalid input
                return;
            }

            // allow only one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true; // prevens entering more than one decimal point
            }
        }

        private decimal ParseTextBoxValue(TextBox textBox)
        {
            // try parsing the TextBox value to decimal, if unsuccessful return 0
            return decimal.TryParse(textBox.Text, out decimal value) ? value : 0;
        }


        private void UpdateCalculations()
        {
            // update total income, total expenses, and remaining balance
            CalculateTotalIncome();
            CalculateTotalExpenses();
            UpdateLeftToSpend();
        }

        private void CalculateTotalIncome()
        {
            // calculate total income by adding the two paycheck values
            totalIncome = ParseTextBoxValue(paycheckTextbox1) + ParseTextBoxValue(paycheckTextbox2);
        }

        private void CalculateTotalExpenses()
        {
            // reset total expenses to 0 before recalculating
            totalExpenses = 0;

            // add utility expenses
            totalExpenses += ParseTextBoxValue(rentTextBox);
            totalExpenses += ParseTextBoxValue(waterTextBox);
            totalExpenses += ParseTextBoxValue(naturalGasTextbox);
            totalExpenses += ParseTextBoxValue(electricityTextBox);
            totalExpenses += ParseTextBoxValue(cableTextBox);
            totalExpenses += ParseTextBoxValue(phoneTextBox);

            // add transportation expenses
            totalExpenses += ParseTextBoxValue(gasTextBox);
            totalExpenses += ParseTextBoxValue(maintenanceTextBox);

            // add food-related expenses
            totalExpenses += ParseTextBoxValue(groceriesTextBox);
            totalExpenses += ParseTextBoxValue(restaurantTextBox);

            // add insurance expenses
            totalExpenses += ParseTextBoxValue(healthTextBox);
            totalExpenses += ParseTextBoxValue(autoTextBox);

            // add savings (emergency fund)
            totalExpenses += ParseTextBoxValue(emergencyFundTextBox);

            // add miscellaneous expenses
            totalExpenses += ParseTextBoxValue(otherTextBox);
        }

        private void UpdateLeftToSpend()
        {
            // calculate remaining balance (income - expenses)
            decimal remaining = totalIncome - totalExpenses;

            // display the remaining amount in the "left to spend" label
            leftToSpend.Text = $"${remaining:N2}";
            // change label color based on whether the remaining amount is positive or negative
            leftToSpend.ForeColor = remaining >= 0 ? Color.Green : Color.Red;
        }
        // submit button to enter all inputted information
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = db.SaveExpenses(
                    currentUser.UserID,
                    ParseTextBoxValue(paycheckTextbox1),
                    ParseTextBoxValue(paycheckTextbox2),
                    ParseTextBoxValue(rentTextBox),
                    ParseTextBoxValue(waterTextBox),
                    ParseTextBoxValue(naturalGasTextbox),
                    ParseTextBoxValue(electricityTextBox),
                    ParseTextBoxValue(cableTextBox),
                    ParseTextBoxValue(phoneTextBox),
                    ParseTextBoxValue(gasTextBox),
                    ParseTextBoxValue(maintenanceTextBox),
                    ParseTextBoxValue(groceriesTextBox),
                    ParseTextBoxValue(restaurantTextBox),
                    ParseTextBoxValue(healthTextBox),
                    ParseTextBoxValue(autoTextBox),
                    ParseTextBoxValue(otherTextBox),
                    ParseTextBoxValue(emergencyFundTextBox)
                );

                if (success)
                {
                    MessageBox.Show(
                        $"Budget saved successfully!\n\n" +
                        $"Total Income: ${totalIncome:N2}\n" +
                        $"Total Expenses: ${totalExpenses:N2}\n" +
                        $"Remaining: ${totalIncome - totalExpenses:N2}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to save budget. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // event handlers for navigation
        private void dashboardPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // navigates to the DashboardPage
            DashboardPage dashboardPage = new DashboardPage(currentUser);
            dashboardPage.Show();
            this.Hide();
        }

        private void budgetPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // no logic needed
        }

        private void userDashboardName_Click(object sender, EventArgs e)
        {
            // display the user's full name when clicked
            userDashboardName.Text = $"{currentUser.FirstName} {currentUser.LastName}";
        }

        // TextChanged event handlers - trigger recalculation when any TextBox changes
        private void paycheckTextbox1_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void paycheckTextbox2_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void rentTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void waterTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void naturalGasTextbox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void electricityTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void cableTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void phoneTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void gasTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void maintenanceTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void groceriesTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void restaurantTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void healthTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void autoTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void emergencyFundTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();
        private void otherTextBox_TextChanged(object sender, EventArgs e) => UpdateCalculations();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // no logic needed
        }

        private void leftToSpend_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void incomePanel_Paint(object sender, PaintEventArgs e)
        {
            // no logic needed
        }

        private void leftToBudgetLabel_Click(object sender, EventArgs e)
        {
            // no logic needed
        }
    }
}
