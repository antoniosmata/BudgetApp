namespace BudgetApp.Forms
{
    partial class BudgetCalculatorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetCalculatorPage));
            headerPanel = new Panel();
            userDashboardName = new Label();
            profileIcon = new PictureBox();
            headingDashboard = new Label();
            budgetIcon = new PictureBox();
            budgetPageLink = new LinkLabel();
            dashboardIcon = new PictureBox();
            dashboardPageLink = new LinkLabel();
            brandNameLabel = new Label();
            menuPanel = new Panel();
            incomePanel = new Panel();
            paycheckTextbox2 = new TextBox();
            paycheckTextbox1 = new TextBox();
            paycheckLabel2 = new Label();
            paycheckLabel1 = new Label();
            label12 = new Label();
            pictureBox5 = new PictureBox();
            incomeLabel = new Label();
            housingPanel = new Panel();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            cableTextBox = new TextBox();
            cableLabel = new Label();
            electricityTextBox = new TextBox();
            electricityLabel = new Label();
            naturalGasTextbox = new TextBox();
            natualGasLabel = new Label();
            waterTextBox = new TextBox();
            rentTextBox = new TextBox();
            waterLabel = new Label();
            mortgageLabel = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            savingsPanel = new Panel();
            emergencyFundTextBox = new TextBox();
            emergencyFundLabel = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            savingsLabel = new Label();
            transporatationLabel = new Panel();
            maintenanceTextBox = new TextBox();
            gasTextBox = new TextBox();
            maintenanceLabel = new Label();
            gasLabel = new Label();
            label22 = new Label();
            pictureBox3 = new PictureBox();
            transportationLabel = new Label();
            foodPanel = new Panel();
            restaurantTextBox = new TextBox();
            groceriesTextBox = new TextBox();
            restaurantLabel = new Label();
            groceriesLabel = new Label();
            label18 = new Label();
            pictureBox4 = new PictureBox();
            foodLabel = new Label();
            insurancePanel = new Panel();
            autoTextBox = new TextBox();
            healthTextBox = new TextBox();
            autoLabel = new Label();
            healthLabel = new Label();
            label26 = new Label();
            pictureBox6 = new PictureBox();
            insuranceLabel = new Label();
            miscellaneousPanel = new Panel();
            otherTextBox = new TextBox();
            otherLabel = new Label();
            label30 = new Label();
            pictureBox7 = new PictureBox();
            miscellaneousLabel = new Label();
            leftToBudgetLabel = new Label();
            leftToSpend = new Label();
            loginButton = new Button();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)budgetIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardIcon).BeginInit();
            menuPanel.SuspendLayout();
            incomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            housingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            savingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            transporatationLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            insurancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            miscellaneousPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(userDashboardName);
            headerPanel.Controls.Add(profileIcon);
            headerPanel.Controls.Add(headingDashboard);
            headerPanel.Location = new Point(177, 0);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(680, 59);
            headerPanel.TabIndex = 11;
            // 
            // userDashboardName
            // 
            userDashboardName.AutoSize = true;
            userDashboardName.Font = new Font("Segoe UI", 9.75F);
            userDashboardName.Location = new Point(553, 25);
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
            // 
            // headingDashboard
            // 
            headingDashboard.AutoSize = true;
            headingDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            headingDashboard.Location = new Point(19, 18);
            headingDashboard.Name = "headingDashboard";
            headingDashboard.Size = new Size(114, 21);
            headingDashboard.TabIndex = 0;
            headingDashboard.Text = "Budget Maker";
            // 
            // budgetIcon
            // 
            budgetIcon.Image = (Image)resources.GetObject("budgetIcon.Image");
            budgetIcon.Location = new Point(15, 177);
            budgetIcon.Name = "budgetIcon";
            budgetIcon.Size = new Size(25, 25);
            budgetIcon.TabIndex = 4;
            budgetIcon.TabStop = false;
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
            budgetPageLink.LinkClicked += budgetPageLink_LinkClicked;
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
            // menuPanel
            // 
            menuPanel.BackColor = Color.White;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(budgetIcon);
            menuPanel.Controls.Add(budgetPageLink);
            menuPanel.Controls.Add(dashboardIcon);
            menuPanel.Controls.Add(dashboardPageLink);
            menuPanel.Controls.Add(brandNameLabel);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(1, 1, 0, 1);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(175, 755);
            menuPanel.TabIndex = 10;
            // 
            // incomePanel
            // 
            incomePanel.BackColor = Color.White;
            incomePanel.BorderStyle = BorderStyle.FixedSingle;
            incomePanel.Controls.Add(paycheckTextbox2);
            incomePanel.Controls.Add(paycheckTextbox1);
            incomePanel.Controls.Add(paycheckLabel2);
            incomePanel.Controls.Add(paycheckLabel1);
            incomePanel.Controls.Add(label12);
            incomePanel.Controls.Add(pictureBox5);
            incomePanel.Controls.Add(incomeLabel);
            incomePanel.Location = new Point(197, 144);
            incomePanel.Margin = new Padding(0, 2, 0, 0);
            incomePanel.Name = "incomePanel";
            incomePanel.Size = new Size(283, 141);
            incomePanel.TabIndex = 11;
            incomePanel.Paint += incomePanel_Paint;
            // 
            // paycheckTextbox2
            // 
            paycheckTextbox2.Location = new Point(112, 85);
            paycheckTextbox2.Name = "paycheckTextbox2";
            paycheckTextbox2.Size = new Size(131, 29);
            paycheckTextbox2.TabIndex = 10;
            paycheckTextbox2.TextChanged += paycheckTextbox2_TextChanged;
            // 
            // paycheckTextbox1
            // 
            paycheckTextbox1.Location = new Point(112, 50);
            paycheckTextbox1.Name = "paycheckTextbox1";
            paycheckTextbox1.Size = new Size(131, 29);
            paycheckTextbox1.TabIndex = 9;
            paycheckTextbox1.TextChanged += paycheckTextbox1_TextChanged;
            // 
            // paycheckLabel2
            // 
            paycheckLabel2.AutoSize = true;
            paycheckLabel2.Font = new Font("Segoe UI", 8.25F);
            paycheckLabel2.Location = new Point(36, 94);
            paycheckLabel2.Margin = new Padding(0);
            paycheckLabel2.Name = "paycheckLabel2";
            paycheckLabel2.Size = new Size(65, 13);
            paycheckLabel2.TabIndex = 8;
            paycheckLabel2.Text = "Paycheck 2:";
            // 
            // paycheckLabel1
            // 
            paycheckLabel1.AutoSize = true;
            paycheckLabel1.Font = new Font("Segoe UI", 8.25F);
            paycheckLabel1.Location = new Point(36, 59);
            paycheckLabel1.Margin = new Padding(0);
            paycheckLabel1.Name = "paycheckLabel1";
            paycheckLabel1.Size = new Size(65, 13);
            paycheckLabel1.TabIndex = 7;
            paycheckLabel1.Text = "Paycheck 1:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(497, 17);
            label12.Name = "label12";
            label12.Size = new Size(104, 21);
            label12.TabIndex = 6;
            label12.Text = "Antonio Mata";
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
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            incomeLabel.Location = new Point(14, 14);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new Size(65, 20);
            incomeLabel.TabIndex = 0;
            incomeLabel.Text = "Income:";
            // 
            // housingPanel
            // 
            housingPanel.BackColor = Color.White;
            housingPanel.BorderStyle = BorderStyle.FixedSingle;
            housingPanel.Controls.Add(phoneTextBox);
            housingPanel.Controls.Add(phoneLabel);
            housingPanel.Controls.Add(cableTextBox);
            housingPanel.Controls.Add(cableLabel);
            housingPanel.Controls.Add(electricityTextBox);
            housingPanel.Controls.Add(electricityLabel);
            housingPanel.Controls.Add(naturalGasTextbox);
            housingPanel.Controls.Add(natualGasLabel);
            housingPanel.Controls.Add(waterTextBox);
            housingPanel.Controls.Add(rentTextBox);
            housingPanel.Controls.Add(waterLabel);
            housingPanel.Controls.Add(mortgageLabel);
            housingPanel.Controls.Add(label3);
            housingPanel.Controls.Add(pictureBox1);
            housingPanel.Controls.Add(label4);
            housingPanel.Location = new Point(197, 304);
            housingPanel.Margin = new Padding(0, 2, 0, 0);
            housingPanel.Name = "housingPanel";
            housingPanel.Size = new Size(283, 279);
            housingPanel.TabIndex = 12;
            housingPanel.Paint += panel2_Paint;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(112, 223);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(131, 29);
            phoneTextBox.TabIndex = 15;
            phoneTextBox.TextChanged += phoneTextBox_TextChanged;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 8.25F);
            phoneLabel.Location = new Point(62, 232);
            phoneLabel.Margin = new Padding(0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(43, 13);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Phone:";
            // 
            // cableTextBox
            // 
            cableTextBox.Location = new Point(112, 188);
            cableTextBox.Name = "cableTextBox";
            cableTextBox.Size = new Size(131, 29);
            cableTextBox.TabIndex = 15;
            cableTextBox.TextChanged += cableTextBox_TextChanged;
            // 
            // cableLabel
            // 
            cableLabel.AutoSize = true;
            cableLabel.Font = new Font("Segoe UI", 8.25F);
            cableLabel.Location = new Point(62, 197);
            cableLabel.Margin = new Padding(0);
            cableLabel.Name = "cableLabel";
            cableLabel.Size = new Size(39, 13);
            cableLabel.TabIndex = 14;
            cableLabel.Text = "Cable:";
            // 
            // electricityTextBox
            // 
            electricityTextBox.Location = new Point(112, 153);
            electricityTextBox.Name = "electricityTextBox";
            electricityTextBox.Size = new Size(131, 29);
            electricityTextBox.TabIndex = 14;
            electricityTextBox.TextChanged += electricityTextBox_TextChanged;
            // 
            // electricityLabel
            // 
            electricityLabel.AutoSize = true;
            electricityLabel.Font = new Font("Segoe UI", 8.25F);
            electricityLabel.Location = new Point(45, 162);
            electricityLabel.Margin = new Padding(0);
            electricityLabel.Name = "electricityLabel";
            electricityLabel.Size = new Size(58, 13);
            electricityLabel.TabIndex = 13;
            electricityLabel.Text = "Electricity:";
            // 
            // naturalGasTextbox
            // 
            naturalGasTextbox.Location = new Point(112, 118);
            naturalGasTextbox.Name = "naturalGasTextbox";
            naturalGasTextbox.Size = new Size(131, 29);
            naturalGasTextbox.TabIndex = 12;
            naturalGasTextbox.TextChanged += naturalGasTextbox_TextChanged;
            // 
            // natualGasLabel
            // 
            natualGasLabel.AutoSize = true;
            natualGasLabel.Font = new Font("Segoe UI", 8.25F);
            natualGasLabel.Location = new Point(31, 127);
            natualGasLabel.Margin = new Padding(0);
            natualGasLabel.Name = "natualGasLabel";
            natualGasLabel.Size = new Size(72, 13);
            natualGasLabel.TabIndex = 11;
            natualGasLabel.Text = "Naturas Gas:";
            // 
            // waterTextBox
            // 
            waterTextBox.Location = new Point(112, 83);
            waterTextBox.Name = "waterTextBox";
            waterTextBox.Size = new Size(131, 29);
            waterTextBox.TabIndex = 10;
            waterTextBox.TextChanged += waterTextBox_TextChanged;
            // 
            // rentTextBox
            // 
            rentTextBox.Location = new Point(112, 48);
            rentTextBox.Name = "rentTextBox";
            rentTextBox.Size = new Size(131, 29);
            rentTextBox.TabIndex = 9;
            rentTextBox.TextChanged += rentTextBox_TextChanged;
            // 
            // waterLabel
            // 
            waterLabel.AutoSize = true;
            waterLabel.Font = new Font("Segoe UI", 8.25F);
            waterLabel.Location = new Point(62, 92);
            waterLabel.Margin = new Padding(0);
            waterLabel.Name = "waterLabel";
            waterLabel.Size = new Size(41, 13);
            waterLabel.TabIndex = 8;
            waterLabel.Text = "Water:";
            // 
            // mortgageLabel
            // 
            mortgageLabel.AutoSize = true;
            mortgageLabel.Font = new Font("Segoe UI", 8.25F);
            mortgageLabel.Location = new Point(14, 57);
            mortgageLabel.Margin = new Padding(0);
            mortgageLabel.Name = "mortgageLabel";
            mortgageLabel.Size = new Size(89, 13);
            mortgageLabel.TabIndex = 7;
            mortgageLabel.Text = "Mortgage/Rent:";
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(461, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(14, 14);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Utilities:";
            // 
            // savingsPanel
            // 
            savingsPanel.BackColor = Color.White;
            savingsPanel.BorderStyle = BorderStyle.FixedSingle;
            savingsPanel.Controls.Add(emergencyFundTextBox);
            savingsPanel.Controls.Add(emergencyFundLabel);
            savingsPanel.Controls.Add(label7);
            savingsPanel.Controls.Add(pictureBox2);
            savingsPanel.Controls.Add(savingsLabel);
            savingsPanel.Location = new Point(197, 600);
            savingsPanel.Margin = new Padding(0, 2, 0, 0);
            savingsPanel.Name = "savingsPanel";
            savingsPanel.Size = new Size(283, 95);
            savingsPanel.TabIndex = 13;
            // 
            // emergencyFundTextBox
            // 
            emergencyFundTextBox.Location = new Point(112, 45);
            emergencyFundTextBox.Name = "emergencyFundTextBox";
            emergencyFundTextBox.Size = new Size(131, 29);
            emergencyFundTextBox.TabIndex = 9;
            emergencyFundTextBox.TextChanged += emergencyFundTextBox_TextChanged;
            // 
            // emergencyFundLabel
            // 
            emergencyFundLabel.AutoSize = true;
            emergencyFundLabel.Font = new Font("Segoe UI", 8.25F);
            emergencyFundLabel.Location = new Point(14, 54);
            emergencyFundLabel.Margin = new Padding(0);
            emergencyFundLabel.Name = "emergencyFundLabel";
            emergencyFundLabel.Size = new Size(95, 13);
            emergencyFundLabel.TabIndex = 7;
            emergencyFundLabel.Text = "Emergency Fund:";
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(461, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // savingsLabel
            // 
            savingsLabel.AutoSize = true;
            savingsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            savingsLabel.Location = new Point(14, 14);
            savingsLabel.Name = "savingsLabel";
            savingsLabel.Size = new Size(66, 20);
            savingsLabel.TabIndex = 0;
            savingsLabel.Text = "Savings:";
            // 
            // transporatationLabel
            // 
            transporatationLabel.BackColor = Color.White;
            transporatationLabel.BorderStyle = BorderStyle.FixedSingle;
            transporatationLabel.Controls.Add(maintenanceTextBox);
            transporatationLabel.Controls.Add(gasTextBox);
            transporatationLabel.Controls.Add(maintenanceLabel);
            transporatationLabel.Controls.Add(gasLabel);
            transporatationLabel.Controls.Add(label22);
            transporatationLabel.Controls.Add(pictureBox3);
            transporatationLabel.Controls.Add(transportationLabel);
            transporatationLabel.Location = new Point(535, 144);
            transporatationLabel.Margin = new Padding(0, 2, 0, 0);
            transporatationLabel.Name = "transporatationLabel";
            transporatationLabel.Size = new Size(283, 141);
            transporatationLabel.TabIndex = 16;
            // 
            // maintenanceTextBox
            // 
            maintenanceTextBox.Location = new Point(106, 83);
            maintenanceTextBox.Name = "maintenanceTextBox";
            maintenanceTextBox.Size = new Size(131, 29);
            maintenanceTextBox.TabIndex = 10;
            maintenanceTextBox.TextChanged += maintenanceTextBox_TextChanged;
            // 
            // gasTextBox
            // 
            gasTextBox.Location = new Point(106, 48);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(131, 29);
            gasTextBox.TabIndex = 9;
            gasTextBox.TextChanged += gasTextBox_TextChanged;
            // 
            // maintenanceLabel
            // 
            maintenanceLabel.AutoSize = true;
            maintenanceLabel.Font = new Font("Segoe UI", 8.25F);
            maintenanceLabel.Location = new Point(26, 92);
            maintenanceLabel.Margin = new Padding(0);
            maintenanceLabel.Name = "maintenanceLabel";
            maintenanceLabel.Size = new Size(77, 13);
            maintenanceLabel.TabIndex = 8;
            maintenanceLabel.Text = "Maintenance:";
            // 
            // gasLabel
            // 
            gasLabel.AutoSize = true;
            gasLabel.Font = new Font("Segoe UI", 8.25F);
            gasLabel.Location = new Point(72, 57);
            gasLabel.Margin = new Padding(0);
            gasLabel.Name = "gasLabel";
            gasLabel.Size = new Size(29, 13);
            gasLabel.TabIndex = 7;
            gasLabel.Text = "Gas:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(497, 17);
            label22.Name = "label22";
            label22.Size = new Size(104, 21);
            label22.TabIndex = 6;
            label22.Text = "Antonio Mata";
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
            // transportationLabel
            // 
            transportationLabel.AutoSize = true;
            transportationLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            transportationLabel.Location = new Point(14, 14);
            transportationLabel.Name = "transportationLabel";
            transportationLabel.Size = new Size(117, 20);
            transportationLabel.TabIndex = 0;
            transportationLabel.Text = "Transportation:";
            // 
            // foodPanel
            // 
            foodPanel.BackColor = Color.White;
            foodPanel.BorderStyle = BorderStyle.FixedSingle;
            foodPanel.Controls.Add(restaurantTextBox);
            foodPanel.Controls.Add(groceriesTextBox);
            foodPanel.Controls.Add(restaurantLabel);
            foodPanel.Controls.Add(groceriesLabel);
            foodPanel.Controls.Add(label18);
            foodPanel.Controls.Add(pictureBox4);
            foodPanel.Controls.Add(foodLabel);
            foodPanel.Location = new Point(535, 304);
            foodPanel.Margin = new Padding(0, 2, 0, 0);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(283, 131);
            foodPanel.TabIndex = 17;
            // 
            // restaurantTextBox
            // 
            restaurantTextBox.Location = new Point(106, 83);
            restaurantTextBox.Name = "restaurantTextBox";
            restaurantTextBox.Size = new Size(131, 29);
            restaurantTextBox.TabIndex = 10;
            restaurantTextBox.TextChanged += restaurantTextBox_TextChanged;
            // 
            // groceriesTextBox
            // 
            groceriesTextBox.Location = new Point(106, 48);
            groceriesTextBox.Name = "groceriesTextBox";
            groceriesTextBox.Size = new Size(131, 29);
            groceriesTextBox.TabIndex = 9;
            groceriesTextBox.TextChanged += groceriesTextBox_TextChanged;
            // 
            // restaurantLabel
            // 
            restaurantLabel.AutoSize = true;
            restaurantLabel.Font = new Font("Segoe UI", 8.25F);
            restaurantLabel.Location = new Point(32, 92);
            restaurantLabel.Margin = new Padding(0);
            restaurantLabel.Name = "restaurantLabel";
            restaurantLabel.Size = new Size(71, 13);
            restaurantLabel.TabIndex = 8;
            restaurantLabel.Text = "Restaurants:";
            // 
            // groceriesLabel
            // 
            groceriesLabel.AutoSize = true;
            groceriesLabel.Font = new Font("Segoe UI", 8.25F);
            groceriesLabel.Location = new Point(43, 57);
            groceriesLabel.Margin = new Padding(0);
            groceriesLabel.Name = "groceriesLabel";
            groceriesLabel.Size = new Size(58, 13);
            groceriesLabel.TabIndex = 7;
            groceriesLabel.Text = "Groceries:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(497, 17);
            label18.Name = "label18";
            label18.Size = new Size(104, 21);
            label18.TabIndex = 6;
            label18.Text = "Antonio Mata";
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
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            foodLabel.Location = new Point(14, 14);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(48, 20);
            foodLabel.TabIndex = 0;
            foodLabel.Text = "Food:";
            // 
            // insurancePanel
            // 
            insurancePanel.BackColor = Color.White;
            insurancePanel.BorderStyle = BorderStyle.FixedSingle;
            insurancePanel.Controls.Add(autoTextBox);
            insurancePanel.Controls.Add(healthTextBox);
            insurancePanel.Controls.Add(autoLabel);
            insurancePanel.Controls.Add(healthLabel);
            insurancePanel.Controls.Add(label26);
            insurancePanel.Controls.Add(pictureBox6);
            insurancePanel.Controls.Add(insuranceLabel);
            insurancePanel.Location = new Point(535, 458);
            insurancePanel.Margin = new Padding(0, 2, 0, 0);
            insurancePanel.Name = "insurancePanel";
            insurancePanel.Size = new Size(283, 125);
            insurancePanel.TabIndex = 18;
            // 
            // autoTextBox
            // 
            autoTextBox.Location = new Point(106, 76);
            autoTextBox.Name = "autoTextBox";
            autoTextBox.Size = new Size(131, 29);
            autoTextBox.TabIndex = 10;
            autoTextBox.TextChanged += autoTextBox_TextChanged;
            // 
            // healthTextBox
            // 
            healthTextBox.Location = new Point(106, 41);
            healthTextBox.Name = "healthTextBox";
            healthTextBox.Size = new Size(131, 29);
            healthTextBox.TabIndex = 9;
            healthTextBox.TextChanged += healthTextBox_TextChanged;
            // 
            // autoLabel
            // 
            autoLabel.AutoSize = true;
            autoLabel.Font = new Font("Segoe UI", 8.25F);
            autoLabel.Location = new Point(66, 85);
            autoLabel.Margin = new Padding(0);
            autoLabel.Name = "autoLabel";
            autoLabel.Size = new Size(35, 13);
            autoLabel.TabIndex = 8;
            autoLabel.Text = "Auto:";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Font = new Font("Segoe UI", 8.25F);
            healthLabel.Location = new Point(57, 50);
            healthLabel.Margin = new Padding(0);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(44, 13);
            healthLabel.TabIndex = 7;
            healthLabel.Text = "Health:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F);
            label26.Location = new Point(497, 17);
            label26.Name = "label26";
            label26.Size = new Size(104, 21);
            label26.TabIndex = 6;
            label26.Text = "Antonio Mata";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(461, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // insuranceLabel
            // 
            insuranceLabel.AutoSize = true;
            insuranceLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            insuranceLabel.Location = new Point(14, 14);
            insuranceLabel.Name = "insuranceLabel";
            insuranceLabel.Size = new Size(81, 20);
            insuranceLabel.TabIndex = 0;
            insuranceLabel.Text = "Insurance:";
            // 
            // miscellaneousPanel
            // 
            miscellaneousPanel.BackColor = Color.White;
            miscellaneousPanel.BorderStyle = BorderStyle.FixedSingle;
            miscellaneousPanel.Controls.Add(otherTextBox);
            miscellaneousPanel.Controls.Add(otherLabel);
            miscellaneousPanel.Controls.Add(label30);
            miscellaneousPanel.Controls.Add(pictureBox7);
            miscellaneousPanel.Controls.Add(miscellaneousLabel);
            miscellaneousPanel.Location = new Point(535, 600);
            miscellaneousPanel.Margin = new Padding(0, 2, 0, 0);
            miscellaneousPanel.Name = "miscellaneousPanel";
            miscellaneousPanel.Size = new Size(283, 95);
            miscellaneousPanel.TabIndex = 19;
            // 
            // otherTextBox
            // 
            otherTextBox.Location = new Point(106, 41);
            otherTextBox.Name = "otherTextBox";
            otherTextBox.Size = new Size(131, 29);
            otherTextBox.TabIndex = 9;
            otherTextBox.TextChanged += otherTextBox_TextChanged;
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.Font = new Font("Segoe UI", 8.25F);
            otherLabel.Location = new Point(57, 50);
            otherLabel.Margin = new Padding(0);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new Size(40, 13);
            otherLabel.TabIndex = 7;
            otherLabel.Text = "Other:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F);
            label30.Location = new Point(497, 17);
            label30.Name = "label30";
            label30.Size = new Size(104, 21);
            label30.TabIndex = 6;
            label30.Text = "Antonio Mata";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(461, 14);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            // 
            // miscellaneousLabel
            // 
            miscellaneousLabel.AutoSize = true;
            miscellaneousLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            miscellaneousLabel.Location = new Point(14, 14);
            miscellaneousLabel.Name = "miscellaneousLabel";
            miscellaneousLabel.Size = new Size(111, 20);
            miscellaneousLabel.TabIndex = 0;
            miscellaneousLabel.Text = "Miscellaneous:";
            // 
            // leftToBudgetLabel
            // 
            leftToBudgetLabel.AutoSize = true;
            leftToBudgetLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftToBudgetLabel.Location = new Point(511, 91);
            leftToBudgetLabel.Margin = new Padding(0);
            leftToBudgetLabel.Name = "leftToBudgetLabel";
            leftToBudgetLabel.Size = new Size(113, 21);
            leftToBudgetLabel.TabIndex = 21;
            leftToBudgetLabel.Text = "left to budget";
            leftToBudgetLabel.Click += leftToBudgetLabel_Click;
            // 
            // leftToSpend
            // 
            leftToSpend.AutoSize = true;
            leftToSpend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            leftToSpend.Location = new Point(432, 91);
            leftToSpend.Margin = new Padding(0);
            leftToSpend.Name = "leftToSpend";
            leftToSpend.Size = new Size(46, 21);
            leftToSpend.TabIndex = 20;
            leftToSpend.Text = "$400";
            leftToSpend.Click += leftToSpend_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Font = new Font("Segoe UI", 9.75F);
            loginButton.Location = new Point(744, 713);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(74, 29);
            loginButton.TabIndex = 22;
            loginButton.Text = "Submit";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // BudgetCalculatorPage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 756);
            Controls.Add(loginButton);
            Controls.Add(leftToBudgetLabel);
            Controls.Add(leftToSpend);
            Controls.Add(miscellaneousPanel);
            Controls.Add(insurancePanel);
            Controls.Add(foodPanel);
            Controls.Add(transporatationLabel);
            Controls.Add(savingsPanel);
            Controls.Add(housingPanel);
            Controls.Add(incomePanel);
            Controls.Add(headerPanel);
            Controls.Add(menuPanel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "BudgetCalculatorPage";
            Text = "Budget Maker";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)budgetIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardIcon).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            incomePanel.ResumeLayout(false);
            incomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            housingPanel.ResumeLayout(false);
            housingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            savingsPanel.ResumeLayout(false);
            savingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            transporatationLabel.ResumeLayout(false);
            transporatationLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            foodPanel.ResumeLayout(false);
            foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            insurancePanel.ResumeLayout(false);
            insurancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            miscellaneousPanel.ResumeLayout(false);
            miscellaneousPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel headerPanel;
        private Label userDashboardName;
        private PictureBox profileIcon;
        private Label headingDashboard;
        private PictureBox budgetIcon;
        private LinkLabel budgetPageLink;
        private PictureBox dashboardIcon;
        private LinkLabel dashboardPageLink;
        private Label brandNameLabel;
        private Panel menuPanel;
        private Panel incomePanel;
        private TextBox paycheckTextbox2;
        private TextBox paycheckTextbox1;
        private Label paycheckLabel2;
        private Label paycheckLabel1;
        private Label label12;
        private PictureBox pictureBox5;
        private Label incomeLabel;
        private Panel housingPanel;
        private TextBox waterTextBox;
        private TextBox rentTextBox;
        private Label waterLabel;
        private Label mortgageLabel;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel savingsPanel;
        private TextBox emergencyFundTextBox;
        private Label emergencyFundLabel;
        private Label label7;
        private PictureBox pictureBox2;
        private Label savingsLabel;
        private TextBox cableTextBox;
        private Label cableLabel;
        private TextBox electricityTextBox;
        private Label electricityLabel;
        private TextBox naturalGasTextbox;
        private Label natualGasLabel;
        private Panel transporatationLabel;
        private TextBox maintenanceTextBox;
        private TextBox gasTextBox;
        private Label maintenanceLabel;
        private Label gasLabel;
        private Label label22;
        private PictureBox pictureBox3;
        private Label transportationLabel;
        private Panel foodPanel;
        private TextBox restaurantTextBox;
        private TextBox groceriesTextBox;
        private Label restaurantLabel;
        private Label groceriesLabel;
        private Label label18;
        private PictureBox pictureBox4;
        private Label foodLabel;
        private Panel insurancePanel;
        private TextBox autoTextBox;
        private TextBox healthTextBox;
        private Label autoLabel;
        private Label healthLabel;
        private Label label26;
        private PictureBox pictureBox6;
        private Label insuranceLabel;
        private Panel miscellaneousPanel;
        private TextBox otherTextBox;
        private Label otherLabel;
        private Label label30;
        private PictureBox pictureBox7;
        private Label miscellaneousLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private Label leftToBudgetLabel;
        private Label leftToSpend;
        private Button loginButton;
    }
}