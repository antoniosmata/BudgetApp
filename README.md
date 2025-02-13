# Budgeting Solutions App

## About
This project was made as the final project for my Rapid Application Development (RAD) class. I made this application within a week. In brief, the Budgeting Solutions App is a Windows Forms application made to help user's manage their personal finances effectively. With the average American household debt at $66,772 and national debt reaching $17.5 trillion as of 2024, increasing debt has become a major problem. This app aims to be a first step solution to the personal debt crisis. 


## Features

### Dashboard
![Picture1](https://github.com/user-attachments/assets/ea92c1d4-bbb4-492c-8362-c1b63068ead5)

- Monthly income overview
- Personalized greeting with user's name
- Current month's spending categories
- Previous month's expenses comparison
- Dynamic financial information updates
- Real-time date display
  
### Budget Calculator
![Picture2](https://github.com/user-attachments/assets/67e1b02e-2d73-46a8-ac7a-8718d9e3dfd4)

- Dual income inputs
- Real-time budget calculations
- Comprehensive expense category tracking
- Color-coded balance display (green for positive, red for negative)
- Automatic saving of financial data to a database

### User Authentication & Security
![picture3](https://github.com/user-attachments/assets/3b6da4a7-f1b1-4aa7-a0ac-6c19cc5016ae)

- Secure user registration and login system
- Password recovery functionality with security questions
- Password masking and validation
- Protection against duplicate usernames
  
## Tech Stack
- **Framework**: .NET Framework 8.0
- **Language**: C#
- **Database**: SQL Server
- **ORM**: Dapper (version 2.1.35)

### Dependencies
- Microsoft.Data.SqlClient (version 5.2.2)
- System.Configuration.ConfigurationManager (version 9.0.0)
- System.Data.SqlClient (version 4.9.0)
- SQL Server Management Studio 2020

## Installation

1. Ensure you have Visual Studio 2022 installed
2. Clone this repository
3. Open the solution file in Visual Studio 2022
4. Build the solution to restore NuGet packages
5. Set up SQL Server database using the provided schema
6. Update the connection string in `DatabaseConnections.cs`
7. Run the application

## Database Schema
<img width="552" alt="Relational Database" src="https://github.com/user-attachments/assets/028b44a6-0ea1-4270-b645-3da7cbdbb37f" />

The application uses five main tables:
- **Users**: Stores authentication info (username, password, email, name, security details)
- **Income**: Tracks user income, including multiple paychecks
- **Expenses**: Records various expense categories
- **Budget**: Maintains monthly income, planned expenses, and remaining budget
- **Savings**: Tracks emergency fund balance

## Usage

1. Launch the application
2. New users: Click "Register" to create an account
3. Existing users: Log in with credentials
4. Navigate to the dashboard for financial overview
5. Use the budget calculator to:
   - Enter monthly income
   - Allocate expenses across categories
   - View real-time remaining budget
   - Save budget plans

## Core Components

- `LoginPage.cs`: User authentication
- `Register.cs`: New account creation
- `PasswordRecPage.cs`: Password recovery
- `BudgetCalculatorPage.cs`: Budget planning interface
- `DashboardPage.cs`: Financial overview and insights
- `DatabaseConnection.cs`: Database operations handler

## Contact

For questions or feedback, please contact me at:
- Antonio Mata (antoniosmata4@gmail.com)

## License

MIT License

Copyright (c) 2024 Antonio Mata

---
*Happy Budgeting!*

## References

Ramsey Solutions. "Average American Debt." *Ramsey Solutions*, Lampo Licensing, LLC, www.ramseysolutions.com/debt/average-american-debt. Accessed 1 Oct. 2024.
