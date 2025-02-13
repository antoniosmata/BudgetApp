using System;
using System.Windows.Forms;
using BudgetApp.DataAccess;
using BudgetApp.Models;

namespace BudgetApp.Forms
{
    public partial class DashboardPage : Form
    {
        private readonly DatabaseConnection db;
        private readonly User currentUser;

        /// <summary>
        /// Constructor that initializes the dashboard page with the user information
        /// </summary>
        /// <param name="user"></param>
        public DashboardPage(User user)
        {
            InitializeComponent();
            db = new DatabaseConnection();
            currentUser = user;
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            SetUserInfo(); // sets the user's full name and greeting
            SetDateDisplay(); // sets the current date and day of the week
            LoadFinancialData();
        }

        /// <summary>
        /// Sets the user's name on the dashboard
        /// </summary>
        private void SetUserInfo()
        {
            userDashboardName.Text = $"{currentUser.FirstName} {currentUser.LastName}"; // full name
            greetingNameLabel.Text = currentUser.FirstName; // personalized greeting with first name
        }

        /// <summary>
        /// Sets the current date and the day of the week on the dashboard
        /// </summary>
        private void SetDateDisplay()
        {
            DateTime now = DateTime.Now; // gets the current date and time
            calendarDay.Text = $"{now.DayOfWeek}, {now:MMMM}"; // displays the day of the week and full month name
            calendarDate.Text = now.Day.ToString(); // displays the numeric day of the month
        }

        private void LoadFinancialData()
        {
            LoadIncome(); // loads income details
            LoadCurrentMonthExpenses(); // loads expenses for the current month
            LoadLastMonthExpenses(); // loads expenses for the last month
        }

        /// <summary>
        /// Loads and displays the user's income
        /// </summary>
        private void LoadIncome()
        {
            Income income = db.GetLatestIncome(currentUser.UserID); // retrieves the latest income record for the user
            incomeLabel.Text = income?.TotalIncome.HasValue == true
                ? $"${income.TotalIncome:N2}" // formats and displays income as currency
                : "N/A"; // if no income data, displays "N/A"
        }

        /// <summary>
        /// Loads and displays the user's expenses for the current month
        /// </summary>
        private void LoadCurrentMonthExpenses()
        {
            Expense expenses = db.GetCurrentMonthExpenses(currentUser.UserID); // retrieves current month expenses
            if (expenses != null)
            {
                // display the total expenses or "n/a" if no data available
                totalSpentThisMonth.Text = expenses.TotalExpenses.HasValue
                    ? $"${expenses.TotalExpenses:N2}"
                    : "N/A";

                // display individual expense categories, or "n/a" if no data
                spentListItemEntry1.Text = expenses.Rent.HasValue ? $"${expenses.Rent:N2}" : "N/A";
                spentListItemEntry2.Text = expenses.Groceries.HasValue ? $"${expenses.Groceries:N2}" : "N/A";
                spentListItemEntry3.Text = expenses.Restaurants.HasValue ? $"${expenses.Restaurants:N2}" : "N/A";
                spentListItemEntry4.Text = expenses.Gas.HasValue ? $"${expenses.Gas:N2}" : "N/A";
                spentListItemEntry5.Text = expenses.OtherExpenses.HasValue ? $"${expenses.OtherExpenses:N2}" : "N/A";
            }
            else
            {
                SetExpensesNA(true); // if no current month expenses, set all to "n/a"
            }
        }

        /// <summary>
        /// Loads and displays the user's expenses for the last month
        /// </summary>
        private void LoadLastMonthExpenses()
        {
            Expense expenses = db.GetLastMonthExpenses(currentUser.UserID); // retrieves last month expenses
            if (expenses != null)
            {
                // display the total expenses or "n/a" if no data available
                totalSpentLastMonth.Text = expenses.TotalExpenses.HasValue
                    ? $"${expenses.TotalExpenses:N2}"
                    : "N/A";

                // display individual expense categories, or "n/a" if no data
                spentListLastItemEntry1.Text = expenses.Rent.HasValue ? $"${expenses.Rent:N2}" : "N/A";
                spentListLastItemEntry2.Text = expenses.Groceries.HasValue ? $"${expenses.Groceries:N2}" : "N/A";
                spentListLastItemEntry3.Text = expenses.Restaurants.HasValue ? $"${expenses.Restaurants:N2}" : "N/A";
                spentListLastItemEntry4.Text = expenses.Gas.HasValue ? $"${expenses.Gas:N2}" : "N/A";
                spentListLastItemEntry5.Text = expenses.OtherExpenses.HasValue ? $"${expenses.OtherExpenses:N2}" : "N/A";
            }
            else
            {
                SetExpensesNA(false); // if no last month expenses, set all to "n/a"
            }
        }

        // helper function to set all expense fields to "n/a" for either current or last month
        private void SetExpensesNA(bool currentMonth)
        {
            if (currentMonth)
            {
                // sets all expense fields for the current month to "n/a"
                totalSpentThisMonth.Text = "N/A";
                spentListItemEntry1.Text = "N/A";
                spentListItemEntry2.Text = "N/A";
                spentListItemEntry3.Text = "N/A";
                spentListItemEntry4.Text = "N/A";
                spentListItemEntry5.Text = "N/A";
            }
            else
            {
                // sets all expense fields for last month to "n/a"
                totalSpentLastMonth.Text = "N/A";
                spentListLastItemEntry1.Text = "N/A";
                spentListLastItemEntry2.Text = "N/A";
                spentListLastItemEntry3.Text = "N/A";
                spentListLastItemEntry4.Text = "N/A";
                spentListLastItemEntry5.Text = "N/A";
            }
        }

        // event handlers (placeholders) for displaying data when user interacts with labels
        private void incomeLabel_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void userDashboardName_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void greetingNameLabel_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void calendarDate_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void calendarDay_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void spentListItem5_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void spentListItem4_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void spentListItem3_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void spentListItem2_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void spentListItem1_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void totalSpentThisMonth_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void totalSpentLastMonth_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        /// <summary>
        /// Redirects to open budgetcalculatorpage for the user to calculate a new budget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BudgetCalculatorPage budget = new BudgetCalculatorPage(currentUser);  // pass the current user
            budget.Show();
            this.Hide();
        }

        // event handlers that are placeholders 
        private void dashboardPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void DashboardPage_Load(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void headingDashboard_Click(object sender, EventArgs e) { }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) { }
        private void profileIcon_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // no logic needed
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // confirm if user wants to logout
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // create and show new login page
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
              
                this.Close();
            }
        }
    }
}
