USE [master]
GO
/****** Object:  Database [BudgetApp]    Script Date: 11/26/2024 1:05:22 PM ******/
CREATE DATABASE [BudgetApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BudgetApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BudgetApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BudgetApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BudgetApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BudgetApp] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BudgetApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BudgetApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BudgetApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BudgetApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BudgetApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BudgetApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [BudgetApp] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BudgetApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BudgetApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BudgetApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BudgetApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BudgetApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BudgetApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BudgetApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BudgetApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BudgetApp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BudgetApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BudgetApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BudgetApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BudgetApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BudgetApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BudgetApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BudgetApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BudgetApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BudgetApp] SET  MULTI_USER 
GO
ALTER DATABASE [BudgetApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BudgetApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BudgetApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BudgetApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BudgetApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BudgetApp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BudgetApp] SET QUERY_STORE = ON
GO
ALTER DATABASE [BudgetApp] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BudgetApp]
GO
/****** Object:  Table [dbo].[Budget]    Script Date: 11/26/2024 1:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Budget](
	[BudgetID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[MonthlyIncome] [decimal](18, 2) NULL,
	[PlannedExpenses] [decimal](18, 2) NULL,
	[RemainingBudget] [decimal](18, 2) NULL,
	[EntryDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[BudgetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 11/26/2024 1:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Rent] [decimal](18, 2) NULL,
	[WaterBill] [decimal](18, 2) NULL,
	[NaturalGas] [decimal](18, 2) NULL,
	[Electricity] [decimal](18, 2) NULL,
	[Cable] [decimal](18, 2) NULL,
	[Phone] [decimal](18, 2) NULL,
	[Gas] [decimal](18, 2) NULL,
	[Maintenance] [decimal](18, 2) NULL,
	[Groceries] [decimal](18, 2) NULL,
	[Restaurants] [decimal](18, 2) NULL,
	[HealthInsurance] [decimal](18, 2) NULL,
	[AutoInsurance] [decimal](18, 2) NULL,
	[OtherExpenses] [decimal](18, 2) NULL,
	[TotalExpenses] [decimal](18, 2) NULL,
	[EntryDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Income]    Script Date: 11/26/2024 1:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Income](
	[IncomeID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Paycheck1] [decimal](18, 2) NULL,
	[Paycheck2] [decimal](18, 2) NULL,
	[TotalIncome] [decimal](18, 2) NULL,
	[EntryDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IncomeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Savings]    Script Date: 11/26/2024 1:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Savings](
	[SavingsID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[EmergencyFund] [decimal](18, 2) NULL,
	[LastUpdated] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SavingsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/26/2024 1:05:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[SecurityQuestion] [nvarchar](255) NOT NULL,
	[SecurityAnswer] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Expenses] ON 

INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (1, 7, CAST(1500.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(2930.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (4, 8, CAST(500.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(770.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (5, 9, CAST(2000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(3670.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (6, 10, CAST(1650.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(75.00 AS Decimal(18, 2)), CAST(900.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(900.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(75.00 AS Decimal(18, 2)), CAST(4210.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (7, 11, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), CAST(4500.00 AS Decimal(18, 2)), CAST(5960.00 AS Decimal(18, 2)), CAST(N'2024-11-22' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (8, 12, CAST(500.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(0.01 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(2870.01 AS Decimal(18, 2)), CAST(N'2024-11-22' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (9, 13, CAST(388888.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(389608.00 AS Decimal(18, 2)), CAST(N'2024-11-22' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (10, 1, CAST(100.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), CAST(900.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(190.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), CAST(3500.00 AS Decimal(18, 2)), CAST(N'2024-11-26' AS Date))
INSERT [dbo].[Expenses] ([ExpenseID], [UserID], [Rent], [WaterBill], [NaturalGas], [Electricity], [Cable], [Phone], [Gas], [Maintenance], [Groceries], [Restaurants], [HealthInsurance], [AutoInsurance], [OtherExpenses], [TotalExpenses], [EntryDate]) VALUES (11, 14, CAST(800.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)), CAST(2609.00 AS Decimal(18, 2)), CAST(N'2024-11-26' AS Date))
SET IDENTITY_INSERT [dbo].[Expenses] OFF
GO
SET IDENTITY_INSERT [dbo].[Income] ON 

INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (1, 7, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (2, 7, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (3, 7, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (4, 8, CAST(1000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (5, 9, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (6, 10, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(N'2024-11-21' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (7, 11, CAST(5000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(N'2024-11-22' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (8, 12, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(N'2024-11-22' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (9, 13, CAST(100.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), CAST(N'2024-11-22' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (10, 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(N'2024-11-26' AS Date))
INSERT [dbo].[Income] ([IncomeID], [UserID], [Paycheck1], [Paycheck2], [TotalIncome], [EntryDate]) VALUES (11, 14, CAST(1000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), CAST(N'2024-11-26' AS Date))
SET IDENTITY_INSERT [dbo].[Income] OFF
GO
SET IDENTITY_INSERT [dbo].[Savings] ON 

INSERT [dbo].[Savings] ([SavingsID], [UserID], [EmergencyFund], [LastUpdated]) VALUES (1, 1, CAST(1000.00 AS Decimal(18, 2)), CAST(N'2024-11-26' AS Date))
INSERT [dbo].[Savings] ([SavingsID], [UserID], [EmergencyFund], [LastUpdated]) VALUES (2, 14, CAST(500.00 AS Decimal(18, 2)), CAST(N'2024-11-26' AS Date))
SET IDENTITY_INSERT [dbo].[Savings] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (1, N'bayonetta', N'iforgotagain', N'crain@lsus.edu', N'Luke', N'Crain', N'What was your first pet''s name?', N'charlie')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (2, N'jamesbond', N'youllneverguess1', N'jbond@lsus.edu', N'James', N'Bond', N'What city were you born in?', N'none')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (3, N'daisy', N'noneofya', N'ilovedaisy@gmail.com', N'Jane', N'Doe', N'What is your mother''s maiden name?', N'Rose')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (4, N'janetborda', N'seasideshell', N'janetbo@hotmail.com', N'Janet', N'Bordeau', N'What city were you born in?', N'Dallas')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (5, N'joshypeepoo', N'higuyslol', N'francisj@lsus.edu', N'Josh', N'Francis', N'What was your first pet''s name?', N'woody')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (6, N'arianagrande', N'yuhyuh', N'ariana@gmail.com', N'Ariana', N'Grande-Butera', N'What was your childhood nickname?', N'star')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (7, N'hellokitty', N'hellokitty', N'imhellokitty@gmail.com', N'Kitty', N'White', N'What was your first pet''s name?', N'kitty')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (8, N'antoniomata', N'helloguysok', N'antonio@gmail.com', N'Antonio', N'Mata', N'What was your first pet''s name?', N'charlie')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (9, N'jamesbond2', N'okokok', N'jamesbond@jamesbond.com', N'James', N'Bond', N'What city were you born in?', N'None')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (10, N'johndoe', N'byebyebye', N'johndow@gmail.com', N'John', N'Doe', N'What was your first pet''s name?', N'charlie')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (11, N'elliegafford', N'okokok', N'ellie@gmail.com', N'Eliana', N'Gafford', N'What was your first pet''s name?', N'Ollie')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (12, N'madalyn', N'okokok', N'madalyn@gmail.com', N'Madalyn', N'English', N'What was your first pet''s name?', N'bella')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (13, N'isaiahyo', N'yo1234', N'yoyo@gmail.com', N'Isaiah', N'Hensleyu', N'What was your childhood nickname?', N'izzy')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [FirstName], [LastName], [SecurityQuestion], [SecurityAnswer]) VALUES (14, N'jondestroyer', N'mynameisjon', N'jon@hotmail.com', N'Jon', N'Destroyet', N'What was the name of your first school?', N'None')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__536C85E42C9CCA84]    Script Date: 11/26/2024 1:05:22 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__A9D10534CDF50518]    Script Date: 11/26/2024 1:05:22 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Budget] ADD  DEFAULT (getdate()) FOR [EntryDate]
GO
ALTER TABLE [dbo].[Expenses] ADD  DEFAULT (getdate()) FOR [EntryDate]
GO
ALTER TABLE [dbo].[Income] ADD  DEFAULT (getdate()) FOR [EntryDate]
GO
ALTER TABLE [dbo].[Savings] ADD  DEFAULT (getdate()) FOR [LastUpdated]
GO
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Income]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Savings]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
USE [master]
GO
ALTER DATABASE [BudgetApp] SET  READ_WRITE 
GO
