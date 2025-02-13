namespace BudgetApp.Forms
{
    partial class DashboardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
            menuPanel = new Panel();
            budgetIcon = new PictureBox();
            budgetPageLink = new LinkLabel();
            dashboardIcon = new PictureBox();
            dashboardPageLink = new LinkLabel();
            brandNameLabel = new Label();
            dashboardPanel = new Panel();
            userDashboardName = new Label();
            profileIcon = new PictureBox();
            headingDashboard = new Label();
            c = new Label();
            greetingNameLabel = new Label();
            calendarBox = new Panel();
            calendarDate = new Label();
            calendarDay = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            calenderLabel = new Label();
            spentThisMonthBox = new Panel();
            spentListItemEntry5 = new Label();
            spentListItem5 = new Label();
            spentListItemEntry4 = new Label();
            spentListItem4 = new Label();
            spentListItemEntry3 = new Label();
            spentListItem3 = new Label();
            spentListItemEntry2 = new Label();
            spentListItem2 = new Label();
            spentListItemEntry1 = new Label();
            spentListItem1 = new Label();
            totalSpentThisMonth = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            spentThisMonthBoxHeading = new Label();
            spentLastMonthBox = new Panel();
            spentListLastItemEntry5 = new Label();
            spentLastMonthListItem5 = new Label();
            spentListLastItemEntry4 = new Label();
            spentLastMonthListItem4 = new Label();
            spentListLastItemEntry3 = new Label();
            spentLastMonthListItem3 = new Label();
            spentListLastItemEntry2 = new Label();
            spentLastMonthListItem2 = new Label();
            spentListLastItemEntry1 = new Label();
            spentLastMonthListItem1 = new Label();
            totalSpentLastMonth = new Label();
            spentLastMonthBoxHeading = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            monthlyIncomeBoxHeading = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            incomeLabel = new Label();
            monthlyIncomeBox = new Panel();
            pictureBox1 = new PictureBox();
            logoutLink = new LinkLabel();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)budgetIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardIcon).BeginInit();
            dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIcon).BeginInit();
            calendarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            spentThisMonthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            spentLastMonthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            monthlyIncomeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.White;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(logoutLink);
            menuPanel.Controls.Add(pictureBox1);
            menuPanel.Controls.Add(budgetIcon);
            menuPanel.Controls.Add(budgetPageLink);
            menuPanel.Controls.Add(dashboardIcon);
            menuPanel.Controls.Add(dashboardPageLink);
            menuPanel.Controls.Add(brandNameLabel);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(1, 1, 0, 1);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(175, 631);
            menuPanel.TabIndex = 0;
            // 
            // budgetIcon
            // 
            budgetIcon.Image = (Image)resources.GetObject("budgetIcon.Image");
            budgetIcon.Location = new Point(15, 177);
            budgetIcon.Name = "budgetIcon";
            budgetIcon.Size = new Size(25, 25);
            budgetIcon.TabIndex = 4;
            budgetIcon.TabStop = false;
            budgetIcon.Click += pictureBox2_Click;
            // 
            // budgetPageLink
            // 
            budgetPageLink.AutoSize = true;
            budgetPageLink.Font = new Font("Segoe UI", 11.25F);
            budgetPageLink.LinkBehavior = LinkBehavior.NeverUnderline;
            budgetPageLink.LinkColor = Color.DimGray;
            budgetPageLink.Location = new Point(45, 177);
            budgetPageLink.Name = "budgetPageLink";
            budgetPageLink.Size = new Size(57, 20);
            budgetPageLink.TabIndex = 3;
            budgetPageLink.TabStop = true;
            budgetPageLink.Text = "Budget";
            budgetPageLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dashboardIcon
            // 
            dashboardIcon.Image = (Image)resources.GetObject("dashboardIcon.Image");
            dashboardIcon.Location = new Point(15, 128);
            dashboardIcon.Name = "dashboardIcon";
            dashboardIcon.Size = new Size(25, 25);
            dashboardIcon.TabIndex = 2;
            dashboardIcon.TabStop = false;
            // 
            // dashboardPageLink
            // 
            dashboardPageLink.AutoSize = true;
            dashboardPageLink.Font = new Font("Segoe UI", 11.25F);
            dashboardPageLink.LinkBehavior = LinkBehavior.NeverUnderline;
            dashboardPageLink.LinkColor = Color.DimGray;
            dashboardPageLink.Location = new Point(45, 128);
            dashboardPageLink.Name = "dashboardPageLink";
            dashboardPageLink.Size = new Size(82, 20);
            dashboardPageLink.TabIndex = 1;
            dashboardPageLink.TabStop = true;
            dashboardPageLink.Text = "Dashboard";
            dashboardPageLink.LinkClicked += dashboardPageLink_LinkClicked;
            // 
            // brandNameLabel
            // 
            brandNameLabel.AutoSize = true;
            brandNameLabel.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic);
            brandNameLabel.Location = new Point(11, 17);
            brandNameLabel.Name = "brandNameLabel";
            brandNameLabel.Size = new Size(154, 27);
            brandNameLabel.TabIndex = 0;
            brandNameLabel.Text = "Budget Solutions";
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.White;
            dashboardPanel.BorderStyle = BorderStyle.FixedSingle;
            dashboardPanel.Controls.Add(userDashboardName);
            dashboardPanel.Controls.Add(profileIcon);
            dashboardPanel.Controls.Add(headingDashboard);
            dashboardPanel.Location = new Point(177, 0);
            dashboardPanel.Margin = new Padding(0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(680, 59);
            dashboardPanel.TabIndex = 1;
            // 
            // userDashboardName
            // 
            userDashboardName.AutoSize = true;
            userDashboardName.Font = new Font("Segoe UI", 9.75F);
            userDashboardName.Location = new Point(557, 22);
            userDashboardName.Name = "userDashboardName";
            userDashboardName.Size = new Size(87, 17);
            userDashboardName.TabIndex = 6;
            userDashboardName.Text = "Antonio Mata";
            userDashboardName.Click += userDashboardName_Click;
            // 
            // profileIcon
            // 
            profileIcon.Image = (Image)resources.GetObject("profileIcon.Image");
            profileIcon.Location = new Point(517, 17);
            profileIcon.Name = "profileIcon";
            profileIcon.Size = new Size(30, 30);
            profileIcon.TabIndex = 5;
            profileIcon.TabStop = false;
            profileIcon.Click += profileIcon_Click;
            // 
            // headingDashboard
            // 
            headingDashboard.AutoSize = true;
            headingDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            headingDashboard.Location = new Point(19, 18);
            headingDashboard.Name = "headingDashboard";
            headingDashboard.Size = new Size(89, 21);
            headingDashboard.TabIndex = 0;
            headingDashboard.Text = "Dashboard";
            headingDashboard.Click += headingDashboard_Click;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Location = new Point(197, 86);
            c.Name = "c";
            c.Size = new Size(80, 21);
            c.TabIndex = 8;
            c.Text = "Greetings,";
            // 
            // greetingNameLabel
            // 
            greetingNameLabel.AutoSize = true;
            greetingNameLabel.Location = new Point(273, 86);
            greetingNameLabel.Name = "greetingNameLabel";
            greetingNameLabel.Size = new Size(65, 21);
            greetingNameLabel.TabIndex = 9;
            greetingNameLabel.Text = "Antonio";
            greetingNameLabel.Click += greetingNameLabel_Click;
            // 
            // calendarBox
            // 
            calendarBox.BackColor = Color.White;
            calendarBox.BorderStyle = BorderStyle.FixedSingle;
            calendarBox.Controls.Add(calendarDate);
            calendarBox.Controls.Add(calendarDay);
            calendarBox.Controls.Add(label3);
            calendarBox.Controls.Add(pictureBox3);
            calendarBox.Controls.Add(calenderLabel);
            calendarBox.Location = new Point(522, 129);
            calendarBox.Margin = new Padding(0, 2, 0, 0);
            calendarBox.Name = "calendarBox";
            calendarBox.Size = new Size(300, 172);
            calendarBox.TabIndex = 8;
            // 
            // calendarDate
            // 
            calendarDate.AutoSize = true;
            calendarDate.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            calendarDate.Location = new Point(14, 58);
            calendarDate.Name = "calendarDate";
            calendarDate.Size = new Size(60, 47);
            calendarDate.TabIndex = 8;
            calendarDate.Text = "20";
            calendarDate.Click += calendarDate_Click;
            // 
            // calendarDay
            // 
            calendarDay.AutoSize = true;
            calendarDay.Font = new Font("Segoe UI", 11.25F);
            calendarDay.Location = new Point(14, 38);
            calendarDay.Margin = new Padding(0);
            calendarDay.Name = "calendarDay";
            calendarDay.Size = new Size(162, 20);
            calendarDay.TabIndex = 7;
            calendarDay.Text = "Wednesday, November";
            calendarDay.Click += calendarDay_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(497, 17);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 6;
            label3.Text = "Antonio Mata";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(461, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // calenderLabel
            // 
            calenderLabel.AutoSize = true;
            calenderLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            calenderLabel.Location = new Point(14, 14);
            calenderLabel.Name = "calenderLabel";
            calenderLabel.Size = new Size(62, 17);
            calenderLabel.TabIndex = 0;
            calenderLabel.Text = "Calendar";
            // 
            // spentThisMonthBox
            // 
            spentThisMonthBox.BackColor = Color.White;
            spentThisMonthBox.BorderStyle = BorderStyle.FixedSingle;
            spentThisMonthBox.Controls.Add(spentListItemEntry5);
            spentThisMonthBox.Controls.Add(spentListItem5);
            spentThisMonthBox.Controls.Add(spentListItemEntry4);
            spentThisMonthBox.Controls.Add(spentListItem4);
            spentThisMonthBox.Controls.Add(spentListItemEntry3);
            spentThisMonthBox.Controls.Add(spentListItem3);
            spentThisMonthBox.Controls.Add(spentListItemEntry2);
            spentThisMonthBox.Controls.Add(spentListItem2);
            spentThisMonthBox.Controls.Add(spentListItemEntry1);
            spentThisMonthBox.Controls.Add(spentListItem1);
            spentThisMonthBox.Controls.Add(totalSpentThisMonth);
            spentThisMonthBox.Controls.Add(label5);
            spentThisMonthBox.Controls.Add(pictureBox4);
            spentThisMonthBox.Controls.Add(spentThisMonthBoxHeading);
            spentThisMonthBox.Location = new Point(197, 325);
            spentThisMonthBox.Margin = new Padding(0, 2, 0, 0);
            spentThisMonthBox.Name = "spentThisMonthBox";
            spentThisMonthBox.Size = new Size(300, 172);
            spentThisMonthBox.TabIndex = 8;
            // 
            // spentListItemEntry5
            // 
            spentListItemEntry5.AutoSize = true;
            spentListItemEntry5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListItemEntry5.Location = new Point(85, 113);
            spentListItemEntry5.Margin = new Padding(0);
            spentListItemEntry5.Name = "spentListItemEntry5";
            spentListItemEntry5.Size = new Size(35, 15);
            spentListItemEntry5.TabIndex = 18;
            spentListItemEntry5.Text = "$200";
            // 
            // spentListItem5
            // 
            spentListItem5.AutoSize = true;
            spentListItem5.Font = new Font("Segoe UI", 9F);
            spentListItem5.Location = new Point(45, 113);
            spentListItem5.Margin = new Padding(0);
            spentListItem5.Name = "spentListItem5";
            spentListItem5.Size = new Size(40, 15);
            spentListItem5.TabIndex = 17;
            spentListItem5.Text = "Other:";
            spentListItem5.Click += spentListItem5_Click;
            // 
            // spentListItemEntry4
            // 
            spentListItemEntry4.AutoSize = true;
            spentListItemEntry4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListItemEntry4.Location = new Point(85, 98);
            spentListItemEntry4.Margin = new Padding(0);
            spentListItemEntry4.Name = "spentListItemEntry4";
            spentListItemEntry4.Size = new Size(35, 15);
            spentListItemEntry4.TabIndex = 16;
            spentListItemEntry4.Text = "$200";
            // 
            // spentListItem4
            // 
            spentListItem4.AutoSize = true;
            spentListItem4.Font = new Font("Segoe UI", 9F);
            spentListItem4.Location = new Point(56, 98);
            spentListItem4.Margin = new Padding(0);
            spentListItem4.Name = "spentListItem4";
            spentListItem4.Size = new Size(29, 15);
            spentListItem4.TabIndex = 15;
            spentListItem4.Text = "Gas:";
            spentListItem4.Click += spentListItem4_Click;
            // 
            // spentListItemEntry3
            // 
            spentListItemEntry3.AutoSize = true;
            spentListItemEntry3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListItemEntry3.Location = new Point(85, 83);
            spentListItemEntry3.Margin = new Padding(0);
            spentListItemEntry3.Name = "spentListItemEntry3";
            spentListItemEntry3.Size = new Size(35, 15);
            spentListItemEntry3.TabIndex = 14;
            spentListItemEntry3.Text = "$200";
            // 
            // spentListItem3
            // 
            spentListItem3.AutoSize = true;
            spentListItem3.Font = new Font("Segoe UI", 9F);
            spentListItem3.Location = new Point(14, 83);
            spentListItem3.Margin = new Padding(0);
            spentListItem3.Name = "spentListItem3";
            spentListItem3.Size = new Size(71, 15);
            spentListItem3.TabIndex = 13;
            spentListItem3.Text = "Restaurants:";
            spentListItem3.Click += spentListItem3_Click;
            // 
            // spentListItemEntry2
            // 
            spentListItemEntry2.AutoSize = true;
            spentListItemEntry2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListItemEntry2.Location = new Point(85, 68);
            spentListItemEntry2.Margin = new Padding(0);
            spentListItemEntry2.Name = "spentListItemEntry2";
            spentListItemEntry2.Size = new Size(35, 15);
            spentListItemEntry2.TabIndex = 12;
            spentListItemEntry2.Text = "$200";
            // 
            // spentListItem2
            // 
            spentListItem2.AutoSize = true;
            spentListItem2.Font = new Font("Segoe UI", 9F);
            spentListItem2.Location = new Point(26, 68);
            spentListItem2.Margin = new Padding(0);
            spentListItem2.Name = "spentListItem2";
            spentListItem2.Size = new Size(59, 15);
            spentListItem2.TabIndex = 11;
            spentListItem2.Text = "Groceries:";
            spentListItem2.Click += spentListItem2_Click;
            // 
            // spentListItemEntry1
            // 
            spentListItemEntry1.AutoSize = true;
            spentListItemEntry1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListItemEntry1.Location = new Point(85, 53);
            spentListItemEntry1.Margin = new Padding(0);
            spentListItemEntry1.Name = "spentListItemEntry1";
            spentListItemEntry1.Size = new Size(35, 15);
            spentListItemEntry1.TabIndex = 10;
            spentListItemEntry1.Text = "$200";
            // 
            // spentListItem1
            // 
            spentListItem1.AutoSize = true;
            spentListItem1.Font = new Font("Segoe UI", 9F);
            spentListItem1.Location = new Point(51, 53);
            spentListItem1.Margin = new Padding(0);
            spentListItem1.Name = "spentListItem1";
            spentListItem1.Size = new Size(34, 15);
            spentListItem1.TabIndex = 9;
            spentListItem1.Text = "Rent:";
            spentListItem1.Click += spentListItem1_Click;
            // 
            // totalSpentThisMonth
            // 
            totalSpentThisMonth.AutoSize = true;
            totalSpentThisMonth.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSpentThisMonth.Location = new Point(133, 63);
            totalSpentThisMonth.Margin = new Padding(0);
            totalSpentThisMonth.Name = "totalSpentThisMonth";
            totalSpentThisMonth.Size = new Size(119, 45);
            totalSpentThisMonth.TabIndex = 8;
            totalSpentThisMonth.Text = "$2,200";
            totalSpentThisMonth.Click += totalSpentThisMonth_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(497, 17);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 6;
            label5.Text = "Antonio Mata";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(461, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // spentThisMonthBoxHeading
            // 
            spentThisMonthBoxHeading.AutoSize = true;
            spentThisMonthBoxHeading.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            spentThisMonthBoxHeading.Location = new Point(14, 14);
            spentThisMonthBoxHeading.Name = "spentThisMonthBoxHeading";
            spentThisMonthBoxHeading.Size = new Size(150, 17);
            spentThisMonthBoxHeading.TabIndex = 0;
            spentThisMonthBoxHeading.Text = "Total Spent this Month";
            // 
            // spentLastMonthBox
            // 
            spentLastMonthBox.BackColor = Color.White;
            spentLastMonthBox.BorderStyle = BorderStyle.FixedSingle;
            spentLastMonthBox.Controls.Add(spentListLastItemEntry5);
            spentLastMonthBox.Controls.Add(spentLastMonthListItem5);
            spentLastMonthBox.Controls.Add(spentListLastItemEntry4);
            spentLastMonthBox.Controls.Add(spentLastMonthListItem4);
            spentLastMonthBox.Controls.Add(spentListLastItemEntry3);
            spentLastMonthBox.Controls.Add(spentLastMonthListItem3);
            spentLastMonthBox.Controls.Add(spentListLastItemEntry2);
            spentLastMonthBox.Controls.Add(spentLastMonthListItem2);
            spentLastMonthBox.Controls.Add(spentListLastItemEntry1);
            spentLastMonthBox.Controls.Add(spentLastMonthListItem1);
            spentLastMonthBox.Controls.Add(totalSpentLastMonth);
            spentLastMonthBox.Controls.Add(spentLastMonthBoxHeading);
            spentLastMonthBox.Controls.Add(label7);
            spentLastMonthBox.Controls.Add(pictureBox5);
            spentLastMonthBox.Controls.Add(label8);
            spentLastMonthBox.Location = new Point(522, 325);
            spentLastMonthBox.Margin = new Padding(0, 2, 0, 0);
            spentLastMonthBox.Name = "spentLastMonthBox";
            spentLastMonthBox.Size = new Size(300, 172);
            spentLastMonthBox.TabIndex = 8;
            // 
            // spentListLastItemEntry5
            // 
            spentListLastItemEntry5.AutoSize = true;
            spentListLastItemEntry5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListLastItemEntry5.Location = new Point(99, 113);
            spentListLastItemEntry5.Margin = new Padding(0);
            spentListLastItemEntry5.Name = "spentListLastItemEntry5";
            spentListLastItemEntry5.Size = new Size(35, 15);
            spentListLastItemEntry5.TabIndex = 30;
            spentListLastItemEntry5.Text = "$200";
            // 
            // spentLastMonthListItem5
            // 
            spentLastMonthListItem5.AutoSize = true;
            spentLastMonthListItem5.Font = new Font("Segoe UI", 9F);
            spentLastMonthListItem5.Location = new Point(54, 113);
            spentLastMonthListItem5.Margin = new Padding(0);
            spentLastMonthListItem5.Name = "spentLastMonthListItem5";
            spentLastMonthListItem5.Size = new Size(45, 15);
            spentLastMonthListItem5.TabIndex = 29;
            spentLastMonthListItem5.Text = "Others:";
            // 
            // spentListLastItemEntry4
            // 
            spentListLastItemEntry4.AutoSize = true;
            spentListLastItemEntry4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListLastItemEntry4.Location = new Point(99, 98);
            spentListLastItemEntry4.Margin = new Padding(0);
            spentListLastItemEntry4.Name = "spentListLastItemEntry4";
            spentListLastItemEntry4.Size = new Size(35, 15);
            spentListLastItemEntry4.TabIndex = 28;
            spentListLastItemEntry4.Text = "$200";
            // 
            // spentLastMonthListItem4
            // 
            spentLastMonthListItem4.AutoSize = true;
            spentLastMonthListItem4.Font = new Font("Segoe UI", 9F);
            spentLastMonthListItem4.Location = new Point(65, 98);
            spentLastMonthListItem4.Margin = new Padding(0);
            spentLastMonthListItem4.Name = "spentLastMonthListItem4";
            spentLastMonthListItem4.Size = new Size(34, 15);
            spentLastMonthListItem4.TabIndex = 27;
            spentLastMonthListItem4.Text = "Rent:";
            // 
            // spentListLastItemEntry3
            // 
            spentListLastItemEntry3.AutoSize = true;
            spentListLastItemEntry3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListLastItemEntry3.Location = new Point(99, 83);
            spentListLastItemEntry3.Margin = new Padding(0);
            spentListLastItemEntry3.Name = "spentListLastItemEntry3";
            spentListLastItemEntry3.Size = new Size(35, 15);
            spentListLastItemEntry3.TabIndex = 26;
            spentListLastItemEntry3.Text = "$200";
            // 
            // spentLastMonthListItem3
            // 
            spentLastMonthListItem3.AutoSize = true;
            spentLastMonthListItem3.Font = new Font("Segoe UI", 9F);
            spentLastMonthListItem3.Location = new Point(14, 83);
            spentLastMonthListItem3.Margin = new Padding(0);
            spentLastMonthListItem3.Name = "spentLastMonthListItem3";
            spentLastMonthListItem3.Size = new Size(85, 15);
            spentLastMonthListItem3.TabIndex = 25;
            spentLastMonthListItem3.Text = "Entertainment:";
            // 
            // spentListLastItemEntry2
            // 
            spentListLastItemEntry2.AutoSize = true;
            spentListLastItemEntry2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListLastItemEntry2.Location = new Point(99, 68);
            spentListLastItemEntry2.Margin = new Padding(0);
            spentListLastItemEntry2.Name = "spentListLastItemEntry2";
            spentListLastItemEntry2.Size = new Size(35, 15);
            spentListLastItemEntry2.TabIndex = 24;
            spentListLastItemEntry2.Text = "$200";
            // 
            // spentLastMonthListItem2
            // 
            spentLastMonthListItem2.AutoSize = true;
            spentLastMonthListItem2.Font = new Font("Segoe UI", 9F);
            spentLastMonthListItem2.Location = new Point(40, 68);
            spentLastMonthListItem2.Margin = new Padding(0);
            spentLastMonthListItem2.Name = "spentLastMonthListItem2";
            spentLastMonthListItem2.Size = new Size(59, 15);
            spentLastMonthListItem2.TabIndex = 23;
            spentLastMonthListItem2.Text = "Groceries:";
            // 
            // spentListLastItemEntry1
            // 
            spentListLastItemEntry1.AutoSize = true;
            spentListLastItemEntry1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            spentListLastItemEntry1.Location = new Point(99, 53);
            spentListLastItemEntry1.Margin = new Padding(0);
            spentListLastItemEntry1.Name = "spentListLastItemEntry1";
            spentListLastItemEntry1.Size = new Size(35, 15);
            spentListLastItemEntry1.TabIndex = 22;
            spentListLastItemEntry1.Text = "$200";
            // 
            // spentLastMonthListItem1
            // 
            spentLastMonthListItem1.AutoSize = true;
            spentLastMonthListItem1.Font = new Font("Segoe UI", 9F);
            spentLastMonthListItem1.Location = new Point(50, 53);
            spentLastMonthListItem1.Margin = new Padding(0);
            spentLastMonthListItem1.Name = "spentLastMonthListItem1";
            spentLastMonthListItem1.Size = new Size(49, 15);
            spentLastMonthListItem1.TabIndex = 21;
            spentLastMonthListItem1.Text = "Utilities:";
            // 
            // totalSpentLastMonth
            // 
            totalSpentLastMonth.AutoSize = true;
            totalSpentLastMonth.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            totalSpentLastMonth.Location = new Point(136, 57);
            totalSpentLastMonth.Margin = new Padding(0);
            totalSpentLastMonth.Name = "totalSpentLastMonth";
            totalSpentLastMonth.Size = new Size(129, 47);
            totalSpentLastMonth.TabIndex = 20;
            totalSpentLastMonth.Text = "$3,460";
            totalSpentLastMonth.Click += totalSpentLastMonth_Click;
            // 
            // spentLastMonthBoxHeading
            // 
            spentLastMonthBoxHeading.AutoSize = true;
            spentLastMonthBoxHeading.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            spentLastMonthBoxHeading.Location = new Point(14, 14);
            spentLastMonthBoxHeading.Name = "spentLastMonthBoxHeading";
            spentLastMonthBoxHeading.Size = new Size(149, 17);
            spentLastMonthBoxHeading.TabIndex = 19;
            spentLastMonthBoxHeading.Text = "Total Spent last Month";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(497, 17);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 6;
            label7.Text = "Antonio Mata";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(461, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(14, 14);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 0;
            // 
            // monthlyIncomeBoxHeading
            // 
            monthlyIncomeBoxHeading.AutoSize = true;
            monthlyIncomeBoxHeading.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            monthlyIncomeBoxHeading.Location = new Point(14, 14);
            monthlyIncomeBoxHeading.Name = "monthlyIncomeBoxHeading";
            monthlyIncomeBoxHeading.Size = new Size(144, 17);
            monthlyIncomeBoxHeading.TabIndex = 0;
            monthlyIncomeBoxHeading.Text = "Total Monthly Income";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(461, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(497, 17);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 6;
            label1.Text = "Antonio Mata";
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incomeLabel.Location = new Point(65, 58);
            incomeLabel.Margin = new Padding(0);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new Size(137, 50);
            incomeLabel.TabIndex = 7;
            incomeLabel.Text = "$4,660";
            incomeLabel.Click += incomeLabel_Click;
            // 
            // monthlyIncomeBox
            // 
            monthlyIncomeBox.BackColor = Color.White;
            monthlyIncomeBox.BorderStyle = BorderStyle.FixedSingle;
            monthlyIncomeBox.Controls.Add(incomeLabel);
            monthlyIncomeBox.Controls.Add(label1);
            monthlyIncomeBox.Controls.Add(pictureBox2);
            monthlyIncomeBox.Controls.Add(monthlyIncomeBoxHeading);
            monthlyIncomeBox.Location = new Point(197, 129);
            monthlyIncomeBox.Margin = new Padding(0, 2, 0, 0);
            monthlyIncomeBox.Name = "monthlyIncomeBox";
            monthlyIncomeBox.Size = new Size(300, 172);
            monthlyIncomeBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 569);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // logoutLink
            // 
            logoutLink.AutoSize = true;
            logoutLink.Font = new Font("Segoe UI", 11.25F);
            logoutLink.LinkBehavior = LinkBehavior.NeverUnderline;
            logoutLink.LinkColor = Color.DimGray;
            logoutLink.Location = new Point(46, 569);
            logoutLink.Name = "logoutLink";
            logoutLink.Size = new Size(56, 20);
            logoutLink.TabIndex = 10;
            logoutLink.TabStop = true;
            logoutLink.Text = "Logout";
            logoutLink.LinkClicked += linkLabel1_LinkClicked_2;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(856, 628);
            Controls.Add(spentLastMonthBox);
            Controls.Add(spentThisMonthBox);
            Controls.Add(calendarBox);
            Controls.Add(greetingNameLabel);
            Controls.Add(c);
            Controls.Add(monthlyIncomeBox);
            Controls.Add(dashboardPanel);
            Controls.Add(menuPanel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "DashboardPage";
            Text = "Dashboard";
            Load += DashboardPage_Load;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)budgetIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardIcon).EndInit();
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileIcon).EndInit();
            calendarBox.ResumeLayout(false);
            calendarBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            spentThisMonthBox.ResumeLayout(false);
            spentThisMonthBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            spentLastMonthBox.ResumeLayout(false);
            spentLastMonthBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            monthlyIncomeBox.ResumeLayout(false);
            monthlyIncomeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel menuPanel;
        private Panel dashboardPanel;
        private Label brandNameLabel;
        private PictureBox dashboardIcon;
        private LinkLabel dashboardPageLink;
        private PictureBox budgetIcon;
        private LinkLabel budgetPageLink;
        private PictureBox profileIcon;
        private Label headingDashboard;
        private Label userDashboardName;
        private Label c;
        private Label greetingNameLabel;
        private Panel calendarBox;
        private Label label3;
        private PictureBox pictureBox3;
        private Label calenderLabel;
        private Panel spentThisMonthBox;
        private Label label5;
        private PictureBox pictureBox4;
        private Label spentThisMonthBoxHeading;
        private Panel spentLastMonthBox;
        private Label label7;
        private PictureBox pictureBox5;
        private Label label8;
        private MonthCalendar monthCalendar1;
        private Label calendarDay;
        private Label calendarDate;
        private Label spentListItem1;
        private Label totalSpentThisMonth;
        private Label spentListItemEntry1;
        private Label spentListItemEntry5;
        private Label spentListItem5;
        private Label spentListItemEntry4;
        private Label spentListItem4;
        private Label spentListItemEntry3;
        private Label spentListItem3;
        private Label spentListItemEntry2;
        private Label spentListItem2;
        private Label spentListLastItemEntry5;
        private Label spentLastMonthListItem5;
        private Label spentListLastItemEntry4;
        private Label spentLastMonthListItem4;
        private Label spentListLastItemEntry3;
        private Label spentLastMonthListItem3;
        private Label spentListLastItemEntry2;
        private Label spentLastMonthListItem2;
        private Label spentListLastItemEntry1;
        private Label spentLastMonthListItem1;
        private Label totalSpentLastMonth;
        private Label spentLastMonthBoxHeading;
        private Label monthlyIncomeBoxHeading;
        private PictureBox pictureBox2;
        private Label label1;
        private Label incomeLabel;
        private Panel monthlyIncomeBox;
        private PictureBox pictureBox1;
        private LinkLabel logoutLink;
    }
}