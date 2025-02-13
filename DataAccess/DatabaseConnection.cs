using System;
using Microsoft.Data.SqlClient;
using Dapper;
using BudgetApp.Models;
using System.Windows.Forms;

namespace BudgetApp.DataAccess
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        // initializes database connection string
        public DatabaseConnection()
        {
            _connectionString = @"Server=WIN11-VM\SQLEXPRESS;Database=BudgetApp;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        // tests if database connection can be established
        public bool TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Connection Error");
                return false;
            }
        }

        // registers a new user in the database
        public bool RegisterUser(User user)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    INSERT INTO Users 
                    (Username, Password, Email, FirstName, LastName, SecurityQuestion, SecurityAnswer) 
                    VALUES 
                    (@Username, @Password, @Email, @FirstName, @LastName, @SecurityQuestion, @SecurityAnswer)";

                    int rowsAffected = connection.Execute(query, user);
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}", "Database Error");
                return false;
            }
        }

        // checks if a username already exists in the database
        public bool UsernameExists(string username)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    int count = connection.ExecuteScalar<int>(query, new { Username = username });
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Username check failed: {ex.Message}", "Database Error");
                return true; // assume username exists for safety
            }
        }

        // validates user login credentials and returns user information
        public User ValidateUser(string username, string password)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    SELECT UserID, Username, Email, FirstName, LastName 
                    FROM Users 
                    WHERE Username = @Username AND Password = @Password";

                    return connection.QueryFirstOrDefault<User>(query, new { Username = username, Password = password });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login validation failed: {ex.Message}", "Database Error");
                return null;
            }
        }

        // retrieves user information by username
        public User GetUserByUsername(string username)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    SELECT UserID, Username, Password, Email, FirstName, LastName, SecurityQuestion, SecurityAnswer 
                    FROM Users 
                    WHERE Username = @Username";

                    return connection.QueryFirstOrDefault<User>(query, new { Username = username });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error");
                return null;
            }
        }

        // updates user's password in the database
        public bool UpdatePassword(string username, string newPassword)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    UPDATE Users 
                    SET Password = @Password 
                    WHERE Username = @Username";

                    int rowsAffected = connection.Execute(query, new { Username = username, Password = newPassword });
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update password: {ex.Message}", "Error");
                return false;
            }
        }

        // gets the current savings information for a user
        public Saving GetCurrentSavings(int userId)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    SELECT TOP 1 * FROM Savings 
                    WHERE UserID = @UserID 
                    ORDER BY LastUpdated DESC";

                    return connection.QueryFirstOrDefault<Saving>(query, new { UserID = userId });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving savings data: {ex.Message}");
                return null;
            }
        }

        // saves or updates user's expenses, income, and savings data
        public bool SaveExpenses(int userId, decimal paycheck1, decimal paycheck2,
    decimal rent, decimal water, decimal naturalGas, decimal electricity,
    decimal cable, decimal phone, decimal gas, decimal maintenance,
    decimal groceries, decimal restaurants, decimal healthInsurance,
    decimal autoInsurance, decimal otherExpenses, decimal emergencyFund)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // calculates total expenses 
                            decimal totalExpenses = rent + water + naturalGas + electricity + cable +
                                                  phone + gas + maintenance + groceries + restaurants +
                                                  healthInsurance + autoInsurance + otherExpenses + emergencyFund;

                   
                            string expenseQuery = @"
                        MERGE INTO Expenses AS target
                        USING (VALUES (@UserID, @Rent, @Water, @NaturalGas, @Electricity,
                                     @Cable, @Phone, @Gas, @Maintenance, @Groceries,
                                     @Restaurants, @HealthInsurance, @AutoInsurance,
                                     @OtherExpenses, @TotalExpenses, @EntryDate))
                            AS source (UserID, Rent, WaterBill, NaturalGas, Electricity,
                                     Cable, Phone, Gas, Maintenance, Groceries,
                                     Restaurants, HealthInsurance, AutoInsurance,
                                     OtherExpenses, TotalExpenses, EntryDate)
                        ON target.UserID = source.UserID 
                           AND MONTH(target.EntryDate) = MONTH(GETDATE())
                           AND YEAR(target.EntryDate) = YEAR(GETDATE())
                        WHEN MATCHED THEN
                            UPDATE SET 
                                Rent = source.Rent,
                                WaterBill = source.WaterBill,
                                NaturalGas = source.NaturalGas,
                                Electricity = source.Electricity,
                                Cable = source.Cable,
                                Phone = source.Phone,
                                Gas = source.Gas,
                                Maintenance = source.Maintenance,
                                Groceries = source.Groceries,
                                Restaurants = source.Restaurants,
                                HealthInsurance = source.HealthInsurance,
                                AutoInsurance = source.AutoInsurance,
                                OtherExpenses = source.OtherExpenses,
                                TotalExpenses = source.TotalExpenses,
                                EntryDate = source.EntryDate
                        WHEN NOT MATCHED THEN
                            INSERT (UserID, Rent, WaterBill, NaturalGas, Electricity,
                                   Cable, Phone, Gas, Maintenance, Groceries,
                                   Restaurants, HealthInsurance, AutoInsurance,
                                   OtherExpenses, TotalExpenses, EntryDate)
                            VALUES (source.UserID, source.Rent, source.WaterBill,
                                   source.NaturalGas, source.Electricity, source.Cable,
                                   source.Phone, source.Gas, source.Maintenance,
                                   source.Groceries, source.Restaurants,
                                   source.HealthInsurance, source.AutoInsurance,
                                   source.OtherExpenses, source.TotalExpenses,
                                   source.EntryDate);";

                            var expenseParams = new
                            {
                                UserID = userId,
                                Rent = rent,
                                Water = water,
                                NaturalGas = naturalGas,
                                Electricity = electricity,
                                Cable = cable,
                                Phone = phone,
                                Gas = gas,
                                Maintenance = maintenance,
                                Groceries = groceries,
                                Restaurants = restaurants,
                                HealthInsurance = healthInsurance,
                                AutoInsurance = autoInsurance,
                                OtherExpenses = otherExpenses,
                                TotalExpenses = totalExpenses,
                                EntryDate = DateTime.Now
                            };

                            connection.Execute(expenseQuery, expenseParams, transaction);

                            string savingsQuery = @"
                        MERGE INTO Savings AS target
                        USING (VALUES (@UserID, @EmergencyFund, @LastUpdated))
                            AS source (UserID, EmergencyFund, LastUpdated)
                        ON target.UserID = source.UserID
                        WHEN MATCHED THEN
                            UPDATE SET 
                                EmergencyFund = source.EmergencyFund,
                                LastUpdated = source.LastUpdated
                        WHEN NOT MATCHED THEN
                            INSERT (UserID, EmergencyFund, LastUpdated)
                            VALUES (source.UserID, source.EmergencyFund, source.LastUpdated);";

                            var savingsParams = new
                            {
                                UserID = userId,
                                EmergencyFund = emergencyFund,
                                LastUpdated = DateTime.Now
                            };

                            connection.Execute(savingsQuery, savingsParams, transaction);

                            string incomeQuery = @"
                        MERGE INTO Income AS target
                        USING (VALUES (@UserID, @Paycheck1, @Paycheck2, @TotalIncome, @EntryDate))
                            AS source (UserID, Paycheck1, Paycheck2, TotalIncome, EntryDate)
                        ON target.UserID = source.UserID 
                           AND MONTH(target.EntryDate) = MONTH(GETDATE())
                           AND YEAR(target.EntryDate) = YEAR(GETDATE())
                        WHEN MATCHED THEN
                            UPDATE SET 
                                Paycheck1 = source.Paycheck1,
                                Paycheck2 = source.Paycheck2,
                                TotalIncome = source.TotalIncome,
                                EntryDate = source.EntryDate
                        WHEN NOT MATCHED THEN
                            INSERT (UserID, Paycheck1, Paycheck2, TotalIncome, EntryDate)
                            VALUES (source.UserID, source.Paycheck1, source.Paycheck2,
                                   source.TotalIncome, source.EntryDate);";

                            var incomeParams = new
                            {
                                UserID = userId,
                                Paycheck1 = paycheck1,
                                Paycheck2 = paycheck2,
                                TotalIncome = paycheck1 + paycheck2,
                                EntryDate = DateTime.Now
                            };

                            connection.Execute(incomeQuery, incomeParams, transaction);

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save data: {ex.Message}", "Database Error");
                return false;
            }
        }

        // retrieves the most recent income record for a user
        public Income GetLatestIncome(int userId)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    SELECT TOP 1 * FROM Income 
                    WHERE UserID = @UserID 
                    ORDER BY EntryDate DESC";

                    return connection.QueryFirstOrDefault<Income>(query, new { UserID = userId });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving income: {ex.Message}");
                return null;
            }
        }

        // gets the current month's expenses for a user
        public Expense GetCurrentMonthExpenses(int userId)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    SELECT TOP 1 * FROM Expenses 
                    WHERE UserID = @UserID 
                    AND MONTH(EntryDate) = MONTH(GETDATE())
                    AND YEAR(EntryDate) = YEAR(GETDATE())
                    ORDER BY EntryDate DESC";

                    return connection.QueryFirstOrDefault<Expense>(query, new { UserID = userId });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving expenses: {ex.Message}");
                return null;
            }
        }

        // gets the previous month's expenses for a user
        public Expense GetLastMonthExpenses(int userId)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    SELECT TOP 1 * FROM Expenses 
                    WHERE UserID = @UserID 
                    AND MONTH(EntryDate) = MONTH(DATEADD(MONTH, -1, GETDATE()))
                    AND YEAR(EntryDate) = YEAR(DATEADD(MONTH, -1, GETDATE()))
                    ORDER BY EntryDate DESC";

                    return connection.QueryFirstOrDefault<Expense>(query, new { UserID = userId });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving last month's expenses: {ex.Message}");
                return null;
            }
        }
    }
}
