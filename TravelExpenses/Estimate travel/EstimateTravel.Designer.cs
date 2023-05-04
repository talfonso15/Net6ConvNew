namespace TravelExpenses
{
    partial class EstimateTravel
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
            this.components = new System.ComponentModel.Container();
            this.gbTravelDetails = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblPerDiemInfo = new System.Windows.Forms.Label();
            this.txtMealsPerDiem = new System.Windows.Forms.TextBox();
            this.lblPerDiem = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoBudgetedTravel = new System.Windows.Forms.RadioButton();
            this.rbYesBudgetedTravel = new System.Windows.Forms.RadioButton();
            this.lblBudgetedTravel = new System.Windows.Forms.Label();
            this.lblOtherPurpose = new System.Windows.Forms.Label();
            this.txtOtherPurpose = new System.Windows.Forms.TextBox();
            this.txtOtherEvent = new System.Windows.Forms.TextBox();
            this.lblOtherEvent = new System.Windows.Forms.Label();
            this.cbTravelPurpose = new System.Windows.Forms.ComboBox();
            this.lblTravelPurpose = new System.Windows.Forms.Label();
            this.cbTravelEvent = new System.Windows.Forms.ComboBox();
            this.lblTravelEvent = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.gbTravelItems = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.chxMeals = new System.Windows.Forms.CheckBox();
            this.chxRegistration = new System.Windows.Forms.CheckBox();
            this.chxLodgings = new System.Windows.Forms.CheckBox();
            this.chxCarRental = new System.Windows.Forms.CheckBox();
            this.chxAirFare = new System.Windows.Forms.CheckBox();
            this.chxMileage = new System.Windows.Forms.CheckBox();
            this.chxOtherExpenses = new System.Windows.Forms.CheckBox();
            this.txtMealsCost = new System.Windows.Forms.TextBox();
            this.txtMealsNotes = new System.Windows.Forms.TextBox();
            this.txtRegistrationCost = new System.Windows.Forms.TextBox();
            this.txtRegistrationNotes = new System.Windows.Forms.TextBox();
            this.txtLodgingsCost = new System.Windows.Forms.TextBox();
            this.txtLodgingNotes = new System.Windows.Forms.TextBox();
            this.txtCarRentalCost = new System.Windows.Forms.TextBox();
            this.txtCarRentalNotes = new System.Windows.Forms.TextBox();
            this.txtAirFareCost = new System.Windows.Forms.TextBox();
            this.txtAirFareNotes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMileageCost = new System.Windows.Forms.TextBox();
            this.btnMileageCalculator = new System.Windows.Forms.Button();
            this.txtMileageNotes = new System.Windows.Forms.TextBox();
            this.txtOtherExpensesCost = new System.Windows.Forms.TextBox();
            this.txtOtherExpensesNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveEstimatedTravel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMealsPerHelp = new System.Windows.Forms.Button();
            this.gbTravelDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTravelItems.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTravelDetails
            // 
            this.gbTravelDetails.Controls.Add(this.btnMealsPerHelp);
            this.gbTravelDetails.Controls.Add(this.linkLabel1);
            this.gbTravelDetails.Controls.Add(this.lblPerDiemInfo);
            this.gbTravelDetails.Controls.Add(this.txtMealsPerDiem);
            this.gbTravelDetails.Controls.Add(this.lblPerDiem);
            this.gbTravelDetails.Controls.Add(this.txtDestination);
            this.gbTravelDetails.Controls.Add(this.lblDestination);
            this.gbTravelDetails.Controls.Add(this.panel2);
            this.gbTravelDetails.Controls.Add(this.lblOtherPurpose);
            this.gbTravelDetails.Controls.Add(this.txtOtherPurpose);
            this.gbTravelDetails.Controls.Add(this.txtOtherEvent);
            this.gbTravelDetails.Controls.Add(this.lblOtherEvent);
            this.gbTravelDetails.Controls.Add(this.cbTravelPurpose);
            this.gbTravelDetails.Controls.Add(this.lblTravelPurpose);
            this.gbTravelDetails.Controls.Add(this.cbTravelEvent);
            this.gbTravelDetails.Controls.Add(this.lblTravelEvent);
            this.gbTravelDetails.Controls.Add(this.dtpReturnDate);
            this.gbTravelDetails.Controls.Add(this.lblReturnDate);
            this.gbTravelDetails.Controls.Add(this.dtpDepartureDate);
            this.gbTravelDetails.Controls.Add(this.lblDepartureDate);
            this.gbTravelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTravelDetails.Location = new System.Drawing.Point(23, 41);
            this.gbTravelDetails.Name = "gbTravelDetails";
            this.gbTravelDetails.Size = new System.Drawing.Size(612, 249);
            this.gbTravelDetails.TabIndex = 0;
            this.gbTravelDetails.TabStop = false;
            this.gbTravelDetails.Text = "Travel Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(230, 218);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(313, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPerDiemInfo
            // 
            this.lblPerDiemInfo.AutoSize = true;
            this.lblPerDiemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerDiemInfo.Location = new System.Drawing.Point(230, 197);
            this.lblPerDiemInfo.Name = "lblPerDiemInfo";
            this.lblPerDiemInfo.Size = new System.Drawing.Size(296, 15);
            this.lblPerDiemInfo.TabIndex = 17;
            this.lblPerDiemInfo.Text = "Check the Meals Per Diem Rate on the following link:";
            // 
            // txtMealsPerDiem
            // 
            this.txtMealsPerDiem.Location = new System.Drawing.Point(130, 211);
            this.txtMealsPerDiem.Name = "txtMealsPerDiem";
            this.txtMealsPerDiem.Size = new System.Drawing.Size(85, 20);
            this.txtMealsPerDiem.TabIndex = 16;
            this.txtMealsPerDiem.TextChanged += new System.EventHandler(this.txtMealsPerDiem_TextChanged);
            this.txtMealsPerDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealsPerDiem_KeyPress);
            // 
            // lblPerDiem
            // 
            this.lblPerDiem.AutoSize = true;
            this.lblPerDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerDiem.Location = new System.Drawing.Point(14, 214);
            this.lblPerDiem.Name = "lblPerDiem";
            this.lblPerDiem.Size = new System.Drawing.Size(110, 13);
            this.lblPerDiem.TabIndex = 15;
            this.lblPerDiem.Text = "Meals Per Diem Rate:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(412, 158);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(183, 20);
            this.txtDestination.TabIndex = 14;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(309, 161);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 13;
            this.lblDestination.Text = "City / State:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNoBudgetedTravel);
            this.panel2.Controls.Add(this.rbYesBudgetedTravel);
            this.panel2.Controls.Add(this.lblBudgetedTravel);
            this.panel2.Location = new System.Drawing.Point(6, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 34);
            this.panel2.TabIndex = 12;
            // 
            // rbNoBudgetedTravel
            // 
            this.rbNoBudgetedTravel.AutoSize = true;
            this.rbNoBudgetedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoBudgetedTravel.Location = new System.Drawing.Point(228, 7);
            this.rbNoBudgetedTravel.Name = "rbNoBudgetedTravel";
            this.rbNoBudgetedTravel.Size = new System.Drawing.Size(39, 17);
            this.rbNoBudgetedTravel.TabIndex = 2;
            this.rbNoBudgetedTravel.TabStop = true;
            this.rbNoBudgetedTravel.Text = "No";
            this.rbNoBudgetedTravel.UseVisualStyleBackColor = true;
            // 
            // rbYesBudgetedTravel
            // 
            this.rbYesBudgetedTravel.AutoSize = true;
            this.rbYesBudgetedTravel.Checked = true;
            this.rbYesBudgetedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYesBudgetedTravel.Location = new System.Drawing.Point(180, 7);
            this.rbYesBudgetedTravel.Name = "rbYesBudgetedTravel";
            this.rbYesBudgetedTravel.Size = new System.Drawing.Size(43, 17);
            this.rbYesBudgetedTravel.TabIndex = 1;
            this.rbYesBudgetedTravel.TabStop = true;
            this.rbYesBudgetedTravel.Text = "Yes";
            this.rbYesBudgetedTravel.UseVisualStyleBackColor = true;
            // 
            // lblBudgetedTravel
            // 
            this.lblBudgetedTravel.AutoSize = true;
            this.lblBudgetedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetedTravel.Location = new System.Drawing.Point(8, 11);
            this.lblBudgetedTravel.Name = "lblBudgetedTravel";
            this.lblBudgetedTravel.Size = new System.Drawing.Size(163, 13);
            this.lblBudgetedTravel.TabIndex = 0;
            this.lblBudgetedTravel.Text = "Was the travel event budgeted ?";
            // 
            // lblOtherPurpose
            // 
            this.lblOtherPurpose.AutoSize = true;
            this.lblOtherPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherPurpose.Location = new System.Drawing.Point(309, 122);
            this.lblOtherPurpose.Name = "lblOtherPurpose";
            this.lblOtherPurpose.Size = new System.Drawing.Size(78, 13);
            this.lblOtherPurpose.TabIndex = 11;
            this.lblOtherPurpose.Text = "Other Purpose:";
            // 
            // txtOtherPurpose
            // 
            this.txtOtherPurpose.Enabled = false;
            this.txtOtherPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherPurpose.Location = new System.Drawing.Point(412, 115);
            this.txtOtherPurpose.Multiline = true;
            this.txtOtherPurpose.Name = "txtOtherPurpose";
            this.txtOtherPurpose.Size = new System.Drawing.Size(183, 20);
            this.txtOtherPurpose.TabIndex = 10;
            // 
            // txtOtherEvent
            // 
            this.txtOtherEvent.Enabled = false;
            this.txtOtherEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherEvent.Location = new System.Drawing.Point(103, 115);
            this.txtOtherEvent.Multiline = true;
            this.txtOtherEvent.Name = "txtOtherEvent";
            this.txtOtherEvent.Size = new System.Drawing.Size(183, 20);
            this.txtOtherEvent.TabIndex = 9;
            // 
            // lblOtherEvent
            // 
            this.lblOtherEvent.AutoSize = true;
            this.lblOtherEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherEvent.Location = new System.Drawing.Point(14, 122);
            this.lblOtherEvent.Name = "lblOtherEvent";
            this.lblOtherEvent.Size = new System.Drawing.Size(67, 13);
            this.lblOtherEvent.TabIndex = 8;
            this.lblOtherEvent.Text = "Other Event:";
            // 
            // cbTravelPurpose
            // 
            this.cbTravelPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTravelPurpose.FormattingEnabled = true;
            this.cbTravelPurpose.Items.AddRange(new object[] {
            "Training",
            "Professional",
            "Industry-related",
            "Work outside district",
            "Seminar",
            "Workshops",
            "Other"});
            this.cbTravelPurpose.Location = new System.Drawing.Point(412, 70);
            this.cbTravelPurpose.Name = "cbTravelPurpose";
            this.cbTravelPurpose.Size = new System.Drawing.Size(183, 21);
            this.cbTravelPurpose.TabIndex = 7;
            this.cbTravelPurpose.SelectedIndexChanged += new System.EventHandler(this.cbTravelPurpose_SelectedIndexChanged);
            // 
            // lblTravelPurpose
            // 
            this.lblTravelPurpose.AutoSize = true;
            this.lblTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelPurpose.Location = new System.Drawing.Point(309, 78);
            this.lblTravelPurpose.Name = "lblTravelPurpose";
            this.lblTravelPurpose.Size = new System.Drawing.Size(82, 13);
            this.lblTravelPurpose.TabIndex = 6;
            this.lblTravelPurpose.Text = "Travel Purpose:";
            // 
            // cbTravelEvent
            // 
            this.cbTravelEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTravelEvent.FormattingEnabled = true;
            this.cbTravelEvent.Items.AddRange(new object[] {
            "FMCA Aerial Fly In",
            "AMCA Annual Meeting",
            "FMCA Annual Meeting",
            "FASD Annual Meeting",
            "Chemical Response Training",
            "FMCA Legislative",
            "AMCA Legislative",
            "FGFOA Accounting",
            "FMCA Dodd Short Course",
            "FASD Legislative",
            "FRS Training",
            "Aquatic Weed Shortcourse",
            "FAPMS",
            "APMS",
            "SFAPMS",
            "FLMS",
            "CHNEP",
            "Other"});
            this.cbTravelEvent.Location = new System.Drawing.Point(103, 70);
            this.cbTravelEvent.Name = "cbTravelEvent";
            this.cbTravelEvent.Size = new System.Drawing.Size(183, 21);
            this.cbTravelEvent.TabIndex = 5;
            this.cbTravelEvent.SelectedIndexChanged += new System.EventHandler(this.cbTravelEvent_SelectedIndexChanged);
            // 
            // lblTravelEvent
            // 
            this.lblTravelEvent.AutoSize = true;
            this.lblTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelEvent.Location = new System.Drawing.Point(14, 78);
            this.lblTravelEvent.Name = "lblTravelEvent";
            this.lblTravelEvent.Size = new System.Drawing.Size(71, 13);
            this.lblTravelEvent.TabIndex = 4;
            this.lblTravelEvent.Text = "Travel Event:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(412, 30);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(124, 20);
            this.dtpReturnDate.TabIndex = 3;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(309, 36);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(68, 13);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(103, 30);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(117, 20);
            this.dtpDepartureDate.TabIndex = 1;
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpDepartureDate_ValueChanged);
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(14, 36);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(83, 13);
            this.lblDepartureDate.TabIndex = 0;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // gbTravelItems
            // 
            this.gbTravelItems.Controls.Add(this.tableLayoutPanel1);
            this.gbTravelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTravelItems.Location = new System.Drawing.Point(23, 313);
            this.gbTravelItems.Name = "gbTravelItems";
            this.gbTravelItems.Size = new System.Drawing.Size(612, 313);
            this.gbTravelItems.TabIndex = 1;
            this.gbTravelItems.TabStop = false;
            this.gbTravelItems.Text = "Travel Items";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNotes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chxMeals, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chxRegistration, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chxLodgings, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chxCarRental, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chxAirFare, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.chxMileage, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.chxOtherExpenses, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtMealsCost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMealsNotes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationCost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationNotes, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLodgingsCost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLodgingNotes, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCarRentalCost, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCarRentalNotes, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAirFareCost, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtAirFareNotes, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMileageNotes, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtOtherExpensesCost, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtOtherExpensesNotes, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 277);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item";
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(109, 10);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(108, 13);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Cost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(223, 10);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(352, 13);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "Notes";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chxMeals
            // 
            this.chxMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxMeals.AutoSize = true;
            this.chxMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxMeals.Location = new System.Drawing.Point(3, 42);
            this.chxMeals.Name = "chxMeals";
            this.chxMeals.Size = new System.Drawing.Size(100, 17);
            this.chxMeals.TabIndex = 3;
            this.chxMeals.Text = "Meals";
            this.chxMeals.UseVisualStyleBackColor = true;
            this.chxMeals.CheckedChanged += new System.EventHandler(this.chxMeals_CheckedChanged);
            // 
            // chxRegistration
            // 
            this.chxRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxRegistration.AutoSize = true;
            this.chxRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxRegistration.Location = new System.Drawing.Point(3, 76);
            this.chxRegistration.Name = "chxRegistration";
            this.chxRegistration.Size = new System.Drawing.Size(100, 17);
            this.chxRegistration.TabIndex = 4;
            this.chxRegistration.Text = "Registration";
            this.chxRegistration.UseVisualStyleBackColor = true;
            this.chxRegistration.CheckedChanged += new System.EventHandler(this.chxRegistration_CheckedChanged);
            // 
            // chxLodgings
            // 
            this.chxLodgings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxLodgings.AutoSize = true;
            this.chxLodgings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxLodgings.Location = new System.Drawing.Point(3, 110);
            this.chxLodgings.Name = "chxLodgings";
            this.chxLodgings.Size = new System.Drawing.Size(100, 17);
            this.chxLodgings.TabIndex = 5;
            this.chxLodgings.Text = "Lodging";
            this.chxLodgings.UseVisualStyleBackColor = true;
            this.chxLodgings.CheckedChanged += new System.EventHandler(this.chxLodgings_CheckedChanged);
            // 
            // chxCarRental
            // 
            this.chxCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxCarRental.AutoSize = true;
            this.chxCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxCarRental.Location = new System.Drawing.Point(3, 144);
            this.chxCarRental.Name = "chxCarRental";
            this.chxCarRental.Size = new System.Drawing.Size(100, 17);
            this.chxCarRental.TabIndex = 6;
            this.chxCarRental.Text = "Car Rental";
            this.chxCarRental.UseVisualStyleBackColor = true;
            this.chxCarRental.CheckedChanged += new System.EventHandler(this.chxCarRental_CheckedChanged);
            // 
            // chxAirFare
            // 
            this.chxAirFare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxAirFare.AutoSize = true;
            this.chxAirFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxAirFare.Location = new System.Drawing.Point(3, 178);
            this.chxAirFare.Name = "chxAirFare";
            this.chxAirFare.Size = new System.Drawing.Size(100, 17);
            this.chxAirFare.TabIndex = 7;
            this.chxAirFare.Text = "Airfare";
            this.chxAirFare.UseVisualStyleBackColor = true;
            this.chxAirFare.CheckedChanged += new System.EventHandler(this.chxAirFare_CheckedChanged);
            // 
            // chxMileage
            // 
            this.chxMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxMileage.AutoSize = true;
            this.chxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxMileage.Location = new System.Drawing.Point(3, 212);
            this.chxMileage.Name = "chxMileage";
            this.chxMileage.Size = new System.Drawing.Size(100, 17);
            this.chxMileage.TabIndex = 8;
            this.chxMileage.Text = "Mileage";
            this.chxMileage.UseVisualStyleBackColor = true;
            this.chxMileage.CheckedChanged += new System.EventHandler(this.chxMileage_CheckedChanged);
            // 
            // chxOtherExpenses
            // 
            this.chxOtherExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chxOtherExpenses.AutoSize = true;
            this.chxOtherExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxOtherExpenses.Location = new System.Drawing.Point(3, 249);
            this.chxOtherExpenses.Name = "chxOtherExpenses";
            this.chxOtherExpenses.Size = new System.Drawing.Size(100, 17);
            this.chxOtherExpenses.TabIndex = 9;
            this.chxOtherExpenses.Text = "Other Expenses";
            this.chxOtherExpenses.UseVisualStyleBackColor = true;
            this.chxOtherExpenses.CheckedChanged += new System.EventHandler(this.chxOtherExpenses_CheckedChanged);
            // 
            // txtMealsCost
            // 
            this.txtMealsCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsCost.Enabled = false;
            this.txtMealsCost.Location = new System.Drawing.Point(109, 41);
            this.txtMealsCost.Name = "txtMealsCost";
            this.txtMealsCost.Size = new System.Drawing.Size(108, 20);
            this.txtMealsCost.TabIndex = 10;
            this.txtMealsCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealsCost_KeyPress);
            // 
            // txtMealsNotes
            // 
            this.txtMealsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsNotes.Enabled = false;
            this.txtMealsNotes.Location = new System.Drawing.Point(223, 37);
            this.txtMealsNotes.Multiline = true;
            this.txtMealsNotes.Name = "txtMealsNotes";
            this.txtMealsNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMealsNotes.Size = new System.Drawing.Size(352, 28);
            this.txtMealsNotes.TabIndex = 11;
            // 
            // txtRegistrationCost
            // 
            this.txtRegistrationCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistrationCost.Enabled = false;
            this.txtRegistrationCost.Location = new System.Drawing.Point(109, 75);
            this.txtRegistrationCost.Name = "txtRegistrationCost";
            this.txtRegistrationCost.Size = new System.Drawing.Size(108, 20);
            this.txtRegistrationCost.TabIndex = 12;
            this.txtRegistrationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistrationCost_KeyPress);
            // 
            // txtRegistrationNotes
            // 
            this.txtRegistrationNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistrationNotes.Enabled = false;
            this.txtRegistrationNotes.Location = new System.Drawing.Point(223, 71);
            this.txtRegistrationNotes.Multiline = true;
            this.txtRegistrationNotes.Name = "txtRegistrationNotes";
            this.txtRegistrationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegistrationNotes.Size = new System.Drawing.Size(352, 28);
            this.txtRegistrationNotes.TabIndex = 13;
            // 
            // txtLodgingsCost
            // 
            this.txtLodgingsCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLodgingsCost.Enabled = false;
            this.txtLodgingsCost.Location = new System.Drawing.Point(109, 109);
            this.txtLodgingsCost.Name = "txtLodgingsCost";
            this.txtLodgingsCost.Size = new System.Drawing.Size(108, 20);
            this.txtLodgingsCost.TabIndex = 14;
            this.txtLodgingsCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLodgingsCost_KeyPress);
            // 
            // txtLodgingNotes
            // 
            this.txtLodgingNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLodgingNotes.Enabled = false;
            this.txtLodgingNotes.Location = new System.Drawing.Point(223, 105);
            this.txtLodgingNotes.Multiline = true;
            this.txtLodgingNotes.Name = "txtLodgingNotes";
            this.txtLodgingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLodgingNotes.Size = new System.Drawing.Size(352, 28);
            this.txtLodgingNotes.TabIndex = 15;
            // 
            // txtCarRentalCost
            // 
            this.txtCarRentalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarRentalCost.Enabled = false;
            this.txtCarRentalCost.Location = new System.Drawing.Point(109, 143);
            this.txtCarRentalCost.Name = "txtCarRentalCost";
            this.txtCarRentalCost.Size = new System.Drawing.Size(108, 20);
            this.txtCarRentalCost.TabIndex = 16;
            this.txtCarRentalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarRentalCost_KeyPress);
            // 
            // txtCarRentalNotes
            // 
            this.txtCarRentalNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarRentalNotes.Enabled = false;
            this.txtCarRentalNotes.Location = new System.Drawing.Point(223, 139);
            this.txtCarRentalNotes.Multiline = true;
            this.txtCarRentalNotes.Name = "txtCarRentalNotes";
            this.txtCarRentalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCarRentalNotes.Size = new System.Drawing.Size(352, 28);
            this.txtCarRentalNotes.TabIndex = 17;
            // 
            // txtAirFareCost
            // 
            this.txtAirFareCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirFareCost.Enabled = false;
            this.txtAirFareCost.Location = new System.Drawing.Point(109, 177);
            this.txtAirFareCost.Name = "txtAirFareCost";
            this.txtAirFareCost.Size = new System.Drawing.Size(108, 20);
            this.txtAirFareCost.TabIndex = 18;
            this.txtAirFareCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAirFareCost_KeyPress);
            // 
            // txtAirFareNotes
            // 
            this.txtAirFareNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirFareNotes.Enabled = false;
            this.txtAirFareNotes.Location = new System.Drawing.Point(223, 173);
            this.txtAirFareNotes.Multiline = true;
            this.txtAirFareNotes.Name = "txtAirFareNotes";
            this.txtAirFareNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAirFareNotes.Size = new System.Drawing.Size(352, 28);
            this.txtAirFareNotes.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtMileageCost);
            this.panel1.Controls.Add(this.btnMileageCalculator);
            this.panel1.Location = new System.Drawing.Point(106, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 34);
            this.panel1.TabIndex = 21;
            // 
            // txtMileageCost
            // 
            this.txtMileageCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMileageCost.Enabled = false;
            this.txtMileageCost.Location = new System.Drawing.Point(23, 5);
            this.txtMileageCost.Name = "txtMileageCost";
            this.txtMileageCost.ReadOnly = true;
            this.txtMileageCost.Size = new System.Drawing.Size(88, 20);
            this.txtMileageCost.TabIndex = 21;
            // 
            // btnMileageCalculator
            // 
            this.btnMileageCalculator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMileageCalculator.Enabled = false;
            this.btnMileageCalculator.Location = new System.Drawing.Point(3, 3);
            this.btnMileageCalculator.Margin = new System.Windows.Forms.Padding(0);
            this.btnMileageCalculator.Name = "btnMileageCalculator";
            this.btnMileageCalculator.Size = new System.Drawing.Size(30, 25);
            this.btnMileageCalculator.TabIndex = 20;
            this.btnMileageCalculator.Text = "+";
            this.btnMileageCalculator.UseVisualStyleBackColor = true;
            this.btnMileageCalculator.Click += new System.EventHandler(this.btnMileageCalculator_Click);
            // 
            // txtMileageNotes
            // 
            this.txtMileageNotes.Enabled = false;
            this.txtMileageNotes.Location = new System.Drawing.Point(223, 207);
            this.txtMileageNotes.Multiline = true;
            this.txtMileageNotes.Name = "txtMileageNotes";
            this.txtMileageNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMileageNotes.Size = new System.Drawing.Size(338, 28);
            this.txtMileageNotes.TabIndex = 22;
            // 
            // txtOtherExpensesCost
            // 
            this.txtOtherExpensesCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherExpensesCost.Enabled = false;
            this.txtOtherExpensesCost.Location = new System.Drawing.Point(109, 247);
            this.txtOtherExpensesCost.Name = "txtOtherExpensesCost";
            this.txtOtherExpensesCost.Size = new System.Drawing.Size(108, 20);
            this.txtOtherExpensesCost.TabIndex = 23;
            this.txtOtherExpensesCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherExpensesCost_KeyPress);
            // 
            // txtOtherExpensesNotes
            // 
            this.txtOtherExpensesNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherExpensesNotes.Enabled = false;
            this.txtOtherExpensesNotes.Location = new System.Drawing.Point(223, 243);
            this.txtOtherExpensesNotes.Multiline = true;
            this.txtOtherExpensesNotes.Name = "txtOtherExpensesNotes";
            this.txtOtherExpensesNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOtherExpensesNotes.Size = new System.Drawing.Size(352, 28);
            this.txtOtherExpensesNotes.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSaveEstimatedTravel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(546, 636);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(92, 51);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // btnSaveEstimatedTravel
            // 
            this.btnSaveEstimatedTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveEstimatedTravel.FlatAppearance.BorderSize = 0;
            this.btnSaveEstimatedTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEstimatedTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEstimatedTravel.Image = global::TravelExpenses.Properties.Resources._1495047519_Save;
            this.btnSaveEstimatedTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveEstimatedTravel.Location = new System.Drawing.Point(5, 7);
            this.btnSaveEstimatedTravel.Name = "btnSaveEstimatedTravel";
            this.btnSaveEstimatedTravel.Size = new System.Drawing.Size(82, 37);
            this.btnSaveEstimatedTravel.TabIndex = 0;
            this.btnSaveEstimatedTravel.Text = "Save";
            this.btnSaveEstimatedTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveEstimatedTravel.UseVisualStyleBackColor = true;
            this.btnSaveEstimatedTravel.Click += new System.EventHandler(this.btnSaveEstimatedTravel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(23, 645);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Close";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMealsPerHelp
            // 
            this.btnMealsPerHelp.FlatAppearance.BorderSize = 0;
            this.btnMealsPerHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealsPerHelp.Image = global::TravelExpenses.Properties.Resources.Help2;
            this.btnMealsPerHelp.Location = new System.Drawing.Point(525, 190);
            this.btnMealsPerHelp.Name = "btnMealsPerHelp";
            this.btnMealsPerHelp.Size = new System.Drawing.Size(36, 27);
            this.btnMealsPerHelp.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnMealsPerHelp, "Click here to see what you have to look for on the GSA page");
            this.btnMealsPerHelp.UseVisualStyleBackColor = true;
            this.btnMealsPerHelp.Click += new System.EventHandler(this.btnMealsPerHelp_Click);
            // 
            // EstimateTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 698);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbTravelItems);
            this.Controls.Add(this.gbTravelDetails);
            this.Name = "EstimateTravel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Authorization";
            this.Load += new System.EventHandler(this.EstimateTravel_Load);
            this.gbTravelDetails.ResumeLayout(false);
            this.gbTravelDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbTravelItems.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTravelDetails;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label lblTravelEvent;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.ComboBox cbTravelEvent;
        private System.Windows.Forms.Label lblTravelPurpose;
        private System.Windows.Forms.ComboBox cbTravelPurpose;
        private System.Windows.Forms.Label lblOtherEvent;
        private System.Windows.Forms.TextBox txtOtherEvent;
        private System.Windows.Forms.TextBox txtOtherPurpose;
        private System.Windows.Forms.Label lblOtherPurpose;
        private System.Windows.Forms.GroupBox gbTravelItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.CheckBox chxMeals;
        private System.Windows.Forms.CheckBox chxRegistration;
        private System.Windows.Forms.CheckBox chxLodgings;
        private System.Windows.Forms.CheckBox chxCarRental;
        private System.Windows.Forms.CheckBox chxAirFare;
        private System.Windows.Forms.CheckBox chxMileage;
        private System.Windows.Forms.CheckBox chxOtherExpenses;
        private System.Windows.Forms.TextBox txtMealsCost;
        private System.Windows.Forms.TextBox txtMealsNotes;
        private System.Windows.Forms.TextBox txtRegistrationCost;
        private System.Windows.Forms.TextBox txtRegistrationNotes;
        private System.Windows.Forms.TextBox txtLodgingsCost;
        private System.Windows.Forms.TextBox txtLodgingNotes;
        private System.Windows.Forms.TextBox txtCarRentalCost;
        private System.Windows.Forms.TextBox txtCarRentalNotes;
        private System.Windows.Forms.TextBox txtAirFareCost;
        private System.Windows.Forms.TextBox txtAirFareNotes;
        private System.Windows.Forms.Button btnMileageCalculator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMileageCost;
        private System.Windows.Forms.TextBox txtMileageNotes;
        private System.Windows.Forms.TextBox txtOtherExpensesCost;
        private System.Windows.Forms.TextBox txtOtherExpensesNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSaveEstimatedTravel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNoBudgetedTravel;
        private System.Windows.Forms.RadioButton rbYesBudgetedTravel;
        private System.Windows.Forms.Label lblBudgetedTravel;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblPerDiemInfo;
        private System.Windows.Forms.TextBox txtMealsPerDiem;
        private System.Windows.Forms.Label lblPerDiem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMealsPerHelp;
    }
}