namespace TravelExpenses
{
    partial class SelectItemsEdit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTravelDetails = new System.Windows.Forms.TabPage();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.txtOtherPurpose = new System.Windows.Forms.TextBox();
            this.lblOtherPurpose = new System.Windows.Forms.Label();
            this.cbTravelPurpose = new System.Windows.Forms.ComboBox();
            this.lblTravelPurpose = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.lblTravelEvent = new System.Windows.Forms.Label();
            this.lblOtherEvent = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            this.cbTravelEvent = new System.Windows.Forms.ComboBox();
            this.txtOtherEvent = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblTravelState = new System.Windows.Forms.Label();
            this.cbTravelState = new System.Windows.Forms.ComboBox();
            this.lblTravelReimb = new System.Windows.Forms.Label();
            this.lblTravelReimbAmount = new System.Windows.Forms.Label();
            this.lblTravelTotal = new System.Windows.Forms.Label();
            this.lblTravelTotalAmount = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.tabTravelItems = new System.Windows.Forms.TabPage();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblColorExplanation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnEditMeals = new System.Windows.Forms.Button();
            this.btnDeleteMeals = new System.Windows.Forms.Button();
            this.lblMeals = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.btnEditRegistration = new System.Windows.Forms.Button();
            this.btnDeleteRegistration = new System.Windows.Forms.Button();
            this.lblCarRental = new System.Windows.Forms.Label();
            this.btnEditCarRental = new System.Windows.Forms.Button();
            this.btnDeleteCarRental = new System.Windows.Forms.Button();
            this.lblAirFare = new System.Windows.Forms.Label();
            this.btnEditAirFare = new System.Windows.Forms.Button();
            this.btnDeleteAirFare = new System.Windows.Forms.Button();
            this.lblLodgings = new System.Windows.Forms.Label();
            this.btnEditLodging = new System.Windows.Forms.Button();
            this.btnDeleteLodging = new System.Windows.Forms.Button();
            this.lblMileage = new System.Windows.Forms.Label();
            this.btnEditMileage = new System.Windows.Forms.Button();
            this.btnDeleteMileage = new System.Windows.Forms.Button();
            this.lblOtherExpenses = new System.Windows.Forms.Label();
            this.btnEditOtherExpenses = new System.Windows.Forms.Button();
            this.btnDeleteOtherExpenses = new System.Windows.Forms.Button();
            this.btnCloseEdit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTravelDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabTravelItems.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTravelDetails);
            this.tabControl1.Controls.Add(this.tabTravelItems);
            this.tabControl1.Location = new System.Drawing.Point(22, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 473);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTravelDetails
            // 
            this.tabTravelDetails.Controls.Add(this.btnSaveDetails);
            this.tabTravelDetails.Controls.Add(this.panel1);
            this.tabTravelDetails.Location = new System.Drawing.Point(4, 22);
            this.tabTravelDetails.Name = "tabTravelDetails";
            this.tabTravelDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabTravelDetails.Size = new System.Drawing.Size(729, 447);
            this.tabTravelDetails.TabIndex = 0;
            this.tabTravelDetails.Text = "Travel Details";
            this.tabTravelDetails.UseVisualStyleBackColor = true;
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.FlatAppearance.BorderSize = 0;
            this.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetails.Image = global::TravelExpenses.Properties.Resources._1495047519_Save;
            this.btnSaveDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDetails.Location = new System.Drawing.Point(593, 401);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(120, 40);
            this.btnSaveDetails.TabIndex = 1;
            this.btnSaveDetails.Text = "Save Details";
            this.btnSaveDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDetails.UseVisualStyleBackColor = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(21, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 382);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.2614F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.7386F));
            this.tableLayoutPanel2.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 276);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(658, 101);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(110, 3);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(545, 95);
            this.txtNotes.TabIndex = 1;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(3, 5);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(101, 91);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Specific skills or strategies obtained as a result of participating in this trave" +
    "l event:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.41337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.85106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.03647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.00304F));
            this.tableLayoutPanel1.Controls.Add(this.lblDepartureDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDepartureTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOtherPurpose, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblOtherPurpose, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbTravelPurpose, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTravelPurpose, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblReturnDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReturnTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTravelEvent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOtherEvent, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblOrigin, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDepartureDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpReturnDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpReturnTime, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbTravelEvent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOtherEvent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtOrigin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDepartureTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTravelState, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbTravelState, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTravelReimb, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTravelReimbAmount, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTravelTotal, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTravelTotalAmount, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDestination, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDestination, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04008F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 253);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(3, 10);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(101, 13);
            this.lblDepartureDate.TabIndex = 0;
            this.lblDepartureDate.Text = "Departure Date:";
            this.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(312, 10);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(138, 13);
            this.lblDepartureTime.TabIndex = 1;
            this.lblDepartureTime.Text = "Departure Time:";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOtherPurpose
            // 
            this.txtOtherPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherPurpose.Enabled = false;
            this.txtOtherPurpose.Location = new System.Drawing.Point(456, 168);
            this.txtOtherPurpose.Multiline = true;
            this.txtOtherPurpose.Name = "txtOtherPurpose";
            this.txtOtherPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOtherPurpose.Size = new System.Drawing.Size(199, 27);
            this.txtOtherPurpose.TabIndex = 19;
            this.txtOtherPurpose.Visible = false;
            // 
            // lblOtherPurpose
            // 
            this.lblOtherPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherPurpose.AutoSize = true;
            this.lblOtherPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherPurpose.Location = new System.Drawing.Point(312, 175);
            this.lblOtherPurpose.Name = "lblOtherPurpose";
            this.lblOtherPurpose.Size = new System.Drawing.Size(138, 13);
            this.lblOtherPurpose.TabIndex = 7;
            this.lblOtherPurpose.Text = "Other Purpose:";
            this.lblOtherPurpose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblOtherPurpose.Visible = false;
            // 
            // cbTravelPurpose
            // 
            this.cbTravelPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTravelPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelPurpose.FormattingEnabled = true;
            this.cbTravelPurpose.Items.AddRange(new object[] {
            "Training",
            "Professional",
            "Industry-related",
            "Work outside district",
            "Seminar",
            "Workshops",
            "Other"});
            this.cbTravelPurpose.Location = new System.Drawing.Point(456, 138);
            this.cbTravelPurpose.Name = "cbTravelPurpose";
            this.cbTravelPurpose.Size = new System.Drawing.Size(199, 21);
            this.cbTravelPurpose.TabIndex = 17;
            this.cbTravelPurpose.Visible = false;
            this.cbTravelPurpose.SelectedIndexChanged += new System.EventHandler(this.cbTravelPurpose_SelectedIndexChanged);
            // 
            // lblTravelPurpose
            // 
            this.lblTravelPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelPurpose.AutoSize = true;
            this.lblTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelPurpose.Location = new System.Drawing.Point(312, 142);
            this.lblTravelPurpose.Name = "lblTravelPurpose";
            this.lblTravelPurpose.Size = new System.Drawing.Size(138, 13);
            this.lblTravelPurpose.TabIndex = 5;
            this.lblTravelPurpose.Text = "Travel Purpose:";
            this.lblTravelPurpose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTravelPurpose.Visible = false;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(3, 43);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(101, 13);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date:";
            this.lblReturnDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnTime.Location = new System.Drawing.Point(312, 43);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(138, 13);
            this.lblReturnTime.TabIndex = 3;
            this.lblReturnTime.Text = "Return Time:";
            this.lblReturnTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTravelEvent
            // 
            this.lblTravelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelEvent.AutoSize = true;
            this.lblTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelEvent.Location = new System.Drawing.Point(3, 76);
            this.lblTravelEvent.Name = "lblTravelEvent";
            this.lblTravelEvent.Size = new System.Drawing.Size(101, 13);
            this.lblTravelEvent.TabIndex = 4;
            this.lblTravelEvent.Text = "Travel Event:";
            this.lblTravelEvent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOtherEvent
            // 
            this.lblOtherEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherEvent.AutoSize = true;
            this.lblOtherEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherEvent.Location = new System.Drawing.Point(3, 109);
            this.lblOtherEvent.Name = "lblOtherEvent";
            this.lblOtherEvent.Size = new System.Drawing.Size(101, 13);
            this.lblOtherEvent.TabIndex = 6;
            this.lblOtherEvent.Text = "Other Event:";
            this.lblOtherEvent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrigin
            // 
            this.lblOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(3, 142);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(101, 13);
            this.lblOrigin.TabIndex = 8;
            this.lblOrigin.Text = "Origin:";
            this.lblOrigin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(110, 6);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(196, 20);
            this.dtpDepartureDate.TabIndex = 12;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(110, 39);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(196, 20);
            this.dtpReturnDate.TabIndex = 14;
            // 
            // dtpReturnTime
            // 
            this.dtpReturnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReturnTime.CustomFormat = "hh:mm tt";
            this.dtpReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnTime.Location = new System.Drawing.Point(456, 39);
            this.dtpReturnTime.Name = "dtpReturnTime";
            this.dtpReturnTime.Size = new System.Drawing.Size(199, 20);
            this.dtpReturnTime.TabIndex = 15;
            // 
            // cbTravelEvent
            // 
            this.cbTravelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTravelEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "Other"});
            this.cbTravelEvent.Location = new System.Drawing.Point(110, 72);
            this.cbTravelEvent.Name = "cbTravelEvent";
            this.cbTravelEvent.Size = new System.Drawing.Size(196, 21);
            this.cbTravelEvent.TabIndex = 16;
            this.cbTravelEvent.SelectedIndexChanged += new System.EventHandler(this.cbTravelEvent_SelectedIndexChanged);
            // 
            // txtOtherEvent
            // 
            this.txtOtherEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherEvent.Enabled = false;
            this.txtOtherEvent.Location = new System.Drawing.Point(110, 102);
            this.txtOtherEvent.Multiline = true;
            this.txtOtherEvent.Name = "txtOtherEvent";
            this.txtOtherEvent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOtherEvent.Size = new System.Drawing.Size(196, 27);
            this.txtOtherEvent.TabIndex = 18;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigin.Location = new System.Drawing.Point(110, 135);
            this.txtOrigin.Multiline = true;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrigin.Size = new System.Drawing.Size(196, 27);
            this.txtOrigin.TabIndex = 20;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureTime.CustomFormat = "hh:mm tt";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(456, 6);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(199, 20);
            this.dtpDepartureTime.TabIndex = 13;
            // 
            // lblTravelState
            // 
            this.lblTravelState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelState.AutoSize = true;
            this.lblTravelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelState.Location = new System.Drawing.Point(3, 219);
            this.lblTravelState.Name = "lblTravelState";
            this.lblTravelState.Size = new System.Drawing.Size(101, 13);
            this.lblTravelState.TabIndex = 10;
            this.lblTravelState.Text = "Travel State:";
            this.lblTravelState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbTravelState
            // 
            this.cbTravelState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTravelState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelState.FormattingEnabled = true;
            this.cbTravelState.Items.AddRange(new object[] {
            "Alabama,AL",
            "Alaska,AK",
            "Arizona,AZ",
            "Arkansas,AR",
            "California,CA",
            "Colorado,CO",
            "Connecticut,CT",
            "Delaware,DE",
            "Florida,FL",
            "Georgia,GA",
            "Hawaii,HI",
            "Idaho,ID",
            "Illinois,IL",
            "Indiana,IN",
            "Iowa,IA",
            "Kansas,KS",
            "Kentucky,KY",
            "Louisiana,LA",
            "Maine,ME",
            "Maryland,MD",
            "Massachusetts,MA",
            "Michigan,MI",
            "Minnesota,MN",
            "Mississippi,MS",
            "Missouri,MO",
            "Montana,MT",
            "Nebraska,NE",
            "Nevada,NV",
            "New Hampshire,NH",
            "New Jersey,NJ",
            "New Mexico,NM",
            "New York,NY",
            "North Carolina,NC",
            "North Dakota,ND",
            "Ohio,OH",
            "Oklahoma,OK",
            "Oregon,OR",
            "Pennsylvania,PA",
            "Rhode Island,RI",
            "South Carolina,SC",
            "South Dakota,SD",
            "Tennessee,TN",
            "Texas,TX",
            "Utah,UT",
            "Vermont,VT",
            "Virginia,VA",
            "Washington,WA",
            "West Virginia,WV",
            "Wisconsin,WI",
            "Wyoming,WY",
            "Other"});
            this.cbTravelState.Location = new System.Drawing.Point(110, 215);
            this.cbTravelState.Name = "cbTravelState";
            this.cbTravelState.Size = new System.Drawing.Size(196, 21);
            this.cbTravelState.TabIndex = 22;
            // 
            // lblTravelReimb
            // 
            this.lblTravelReimb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelReimb.AutoSize = true;
            this.lblTravelReimb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelReimb.Location = new System.Drawing.Point(312, 109);
            this.lblTravelReimb.Name = "lblTravelReimb";
            this.lblTravelReimb.Size = new System.Drawing.Size(138, 13);
            this.lblTravelReimb.TabIndex = 24;
            this.lblTravelReimb.Text = "Travel Reimbursement:";
            this.lblTravelReimb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTravelReimbAmount
            // 
            this.lblTravelReimbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelReimbAmount.AutoSize = true;
            this.lblTravelReimbAmount.Location = new System.Drawing.Point(456, 109);
            this.lblTravelReimbAmount.Name = "lblTravelReimbAmount";
            this.lblTravelReimbAmount.Size = new System.Drawing.Size(199, 13);
            this.lblTravelReimbAmount.TabIndex = 26;
            // 
            // lblTravelTotal
            // 
            this.lblTravelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelTotal.AutoSize = true;
            this.lblTravelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelTotal.Location = new System.Drawing.Point(312, 76);
            this.lblTravelTotal.Name = "lblTravelTotal";
            this.lblTravelTotal.Size = new System.Drawing.Size(138, 13);
            this.lblTravelTotal.TabIndex = 23;
            this.lblTravelTotal.Text = "Travel Total:";
            this.lblTravelTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTravelTotalAmount
            // 
            this.lblTravelTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelTotalAmount.AutoSize = true;
            this.lblTravelTotalAmount.Location = new System.Drawing.Point(456, 76);
            this.lblTravelTotalAmount.Name = "lblTravelTotalAmount";
            this.lblTravelTotalAmount.Size = new System.Drawing.Size(199, 13);
            this.lblTravelTotalAmount.TabIndex = 25;
            // 
            // lblDestination
            // 
            this.lblDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(3, 175);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(101, 13);
            this.lblDestination.TabIndex = 9;
            this.lblDestination.Text = "Destination:";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Location = new System.Drawing.Point(110, 168);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDestination.Size = new System.Drawing.Size(196, 27);
            this.txtDestination.TabIndex = 21;
            // 
            // tabTravelItems
            // 
            this.tabTravelItems.Controls.Add(this.btnAddNewItem);
            this.tabTravelItems.Controls.Add(this.panel3);
            this.tabTravelItems.Controls.Add(this.panel2);
            this.tabTravelItems.Location = new System.Drawing.Point(4, 22);
            this.tabTravelItems.Name = "tabTravelItems";
            this.tabTravelItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabTravelItems.Size = new System.Drawing.Size(729, 447);
            this.tabTravelItems.TabIndex = 1;
            this.tabTravelItems.Text = "Travel Items";
            this.tabTravelItems.UseVisualStyleBackColor = true;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Enabled = false;
            this.btnAddNewItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewItem.FlatAppearance.BorderSize = 0;
            this.btnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.ForeColor = System.Drawing.Color.Green;
            this.btnAddNewItem.Image = global::TravelExpenses.Properties.Resources.iconfinder_add_3855641;
            this.btnAddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewItem.Location = new System.Drawing.Point(595, 4);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(131, 48);
            this.btnAddNewItem.TabIndex = 2;
            this.btnAddNewItem.Text = "Add New Item";
            this.btnAddNewItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblColorExplanation);
            this.panel3.Location = new System.Drawing.Point(63, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 31);
            this.panel3.TabIndex = 1;
            // 
            // lblColorExplanation
            // 
            this.lblColorExplanation.AutoSize = true;
            this.lblColorExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorExplanation.Location = new System.Drawing.Point(13, 7);
            this.lblColorExplanation.Name = "lblColorExplanation";
            this.lblColorExplanation.Size = new System.Drawing.Size(556, 15);
            this.lblColorExplanation.TabIndex = 0;
            this.lblColorExplanation.Text = "* Red item means you don\'t have that item in your travel and green means you have" +
    " it.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(122, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 324);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.lblItemName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblEdit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEditMeals, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteMeals, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblMeals, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblRegistration, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnEditRegistration, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteRegistration, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCarRental, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnEditCarRental, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteCarRental, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblAirFare, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnEditAirFare, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteAirFare, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblLodgings, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnEditLodging, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteLodging, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblMileage, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.btnEditMileage, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteMileage, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblOtherExpenses, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.btnEditOtherExpenses, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteOtherExpenses, 2, 7);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(417, 292);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(3, 9);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(160, 17);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item *";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(169, 9);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(119, 17);
            this.lblEdit.TabIndex = 1;
            this.lblEdit.Text = "Edit";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDelete
            // 
            this.lblDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(294, 9);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(120, 17);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "Delete";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditMeals
            // 
            this.btnEditMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditMeals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditMeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditMeals.Enabled = false;
            this.btnEditMeals.FlatAppearance.BorderSize = 0;
            this.btnEditMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMeals.Image = global::TravelExpenses.Properties.Resources._1493081488_pen;
            this.btnEditMeals.Location = new System.Drawing.Point(202, 39);
            this.btnEditMeals.Name = "btnEditMeals";
            this.btnEditMeals.Size = new System.Drawing.Size(52, 30);
            this.btnEditMeals.TabIndex = 3;
            this.btnEditMeals.UseVisualStyleBackColor = false;
            this.btnEditMeals.Click += new System.EventHandler(this.btnEditMeals_Click);
            // 
            // btnDeleteMeals
            // 
            this.btnDeleteMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteMeals.Enabled = false;
            this.btnDeleteMeals.FlatAppearance.BorderSize = 0;
            this.btnDeleteMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMeals.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.btnDeleteMeals.Location = new System.Drawing.Point(328, 39);
            this.btnDeleteMeals.Name = "btnDeleteMeals";
            this.btnDeleteMeals.Size = new System.Drawing.Size(52, 30);
            this.btnDeleteMeals.TabIndex = 4;
            this.btnDeleteMeals.UseVisualStyleBackColor = true;
            this.btnDeleteMeals.Click += new System.EventHandler(this.btnDeleteMeals_Click);
            // 
            // lblMeals
            // 
            this.lblMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMeals.AutoSize = true;
            this.lblMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeals.Location = new System.Drawing.Point(3, 46);
            this.lblMeals.Name = "lblMeals";
            this.lblMeals.Size = new System.Drawing.Size(160, 15);
            this.lblMeals.TabIndex = 5;
            this.lblMeals.Text = "Meals";
            this.lblMeals.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(3, 82);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(160, 15);
            this.lblRegistration.TabIndex = 6;
            this.lblRegistration.Text = "Registration";
            this.lblRegistration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditRegistration
            // 
            this.btnEditRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditRegistration.Enabled = false;
            this.btnEditRegistration.FlatAppearance.BorderSize = 0;
            this.btnEditRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRegistration.Image = global::TravelExpenses.Properties.Resources._1493081488_pen;
            this.btnEditRegistration.Location = new System.Drawing.Point(202, 75);
            this.btnEditRegistration.Name = "btnEditRegistration";
            this.btnEditRegistration.Size = new System.Drawing.Size(52, 30);
            this.btnEditRegistration.TabIndex = 7;
            this.btnEditRegistration.UseVisualStyleBackColor = true;
            this.btnEditRegistration.Click += new System.EventHandler(this.btnEditRegistration_Click);
            // 
            // btnDeleteRegistration
            // 
            this.btnDeleteRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteRegistration.Enabled = false;
            this.btnDeleteRegistration.FlatAppearance.BorderSize = 0;
            this.btnDeleteRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRegistration.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.btnDeleteRegistration.Location = new System.Drawing.Point(328, 75);
            this.btnDeleteRegistration.Name = "btnDeleteRegistration";
            this.btnDeleteRegistration.Size = new System.Drawing.Size(52, 30);
            this.btnDeleteRegistration.TabIndex = 8;
            this.btnDeleteRegistration.UseVisualStyleBackColor = true;
            this.btnDeleteRegistration.Click += new System.EventHandler(this.btnDeleteRegistration_Click);
            // 
            // lblCarRental
            // 
            this.lblCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarRental.AutoSize = true;
            this.lblCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRental.Location = new System.Drawing.Point(3, 118);
            this.lblCarRental.Name = "lblCarRental";
            this.lblCarRental.Size = new System.Drawing.Size(160, 15);
            this.lblCarRental.TabIndex = 9;
            this.lblCarRental.Text = "Car Rental";
            this.lblCarRental.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditCarRental
            // 
            this.btnEditCarRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCarRental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCarRental.Enabled = false;
            this.btnEditCarRental.FlatAppearance.BorderSize = 0;
            this.btnEditCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCarRental.Image = global::TravelExpenses.Properties.Resources._1493081488_pen;
            this.btnEditCarRental.Location = new System.Drawing.Point(202, 111);
            this.btnEditCarRental.Name = "btnEditCarRental";
            this.btnEditCarRental.Size = new System.Drawing.Size(52, 30);
            this.btnEditCarRental.TabIndex = 10;
            this.btnEditCarRental.UseVisualStyleBackColor = true;
            this.btnEditCarRental.Click += new System.EventHandler(this.btnEditCarRental_Click);
            // 
            // btnDeleteCarRental
            // 
            this.btnDeleteCarRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCarRental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteCarRental.Enabled = false;
            this.btnDeleteCarRental.FlatAppearance.BorderSize = 0;
            this.btnDeleteCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCarRental.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.btnDeleteCarRental.Location = new System.Drawing.Point(328, 111);
            this.btnDeleteCarRental.Name = "btnDeleteCarRental";
            this.btnDeleteCarRental.Size = new System.Drawing.Size(52, 30);
            this.btnDeleteCarRental.TabIndex = 11;
            this.btnDeleteCarRental.UseVisualStyleBackColor = true;
            this.btnDeleteCarRental.Click += new System.EventHandler(this.btnDeleteCarRental_Click);
            // 
            // lblAirFare
            // 
            this.lblAirFare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAirFare.AutoSize = true;
            this.lblAirFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirFare.Location = new System.Drawing.Point(3, 154);
            this.lblAirFare.Name = "lblAirFare";
            this.lblAirFare.Size = new System.Drawing.Size(160, 15);
            this.lblAirFare.TabIndex = 12;
            this.lblAirFare.Text = "Air Fare";
            this.lblAirFare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditAirFare
            // 
            this.btnEditAirFare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAirFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditAirFare.Enabled = false;
            this.btnEditAirFare.FlatAppearance.BorderSize = 0;
            this.btnEditAirFare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAirFare.Image = global::TravelExpenses.Properties.Resources._1493081488_pen;
            this.btnEditAirFare.Location = new System.Drawing.Point(202, 147);
            this.btnEditAirFare.Name = "btnEditAirFare";
            this.btnEditAirFare.Size = new System.Drawing.Size(52, 30);
            this.btnEditAirFare.TabIndex = 13;
            this.btnEditAirFare.UseVisualStyleBackColor = true;
            this.btnEditAirFare.Click += new System.EventHandler(this.btnEditAirFare_Click);
            // 
            // btnDeleteAirFare
            // 
            this.btnDeleteAirFare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAirFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteAirFare.Enabled = false;
            this.btnDeleteAirFare.FlatAppearance.BorderSize = 0;
            this.btnDeleteAirFare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAirFare.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.btnDeleteAirFare.Location = new System.Drawing.Point(328, 147);
            this.btnDeleteAirFare.Name = "btnDeleteAirFare";
            this.btnDeleteAirFare.Size = new System.Drawing.Size(52, 30);
            this.btnDeleteAirFare.TabIndex = 14;
            this.btnDeleteAirFare.UseVisualStyleBackColor = true;
            this.btnDeleteAirFare.Click += new System.EventHandler(this.btnDeleteAirFare_Click);
            // 
            // lblLodgings
            // 
            this.lblLodgings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLodgings.AutoSize = true;
            this.lblLodgings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLodgings.Location = new System.Drawing.Point(3, 190);
            this.lblLodgings.Name = "lblLodgings";
            this.lblLodgings.Size = new System.Drawing.Size(160, 15);
            this.lblLodgings.TabIndex = 15;
            this.lblLodgings.Text = "Lodging";
            this.lblLodgings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditLodging
            // 
            this.btnEditLodging.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditLodging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditLodging.Enabled = false;
            this.btnEditLodging.FlatAppearance.BorderSize = 0;
            this.btnEditLodging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLodging.Image = global::TravelExpenses.Properties.Resources._1493081488_pen;
            this.btnEditLodging.Location = new System.Drawing.Point(202, 183);
            this.btnEditLodging.Name = "btnEditLodging";
            this.btnEditLodging.Size = new System.Drawing.Size(52, 30);
            this.btnEditLodging.TabIndex = 16;
            this.btnEditLodging.UseVisualStyleBackColor = true;
            this.btnEditLodging.Click += new System.EventHandler(this.btnEditLodging_Click);
            // 
            // btnDeleteLodging
            // 
            this.btnDeleteLodging.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteLodging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteLodging.Enabled = false;
            this.btnDeleteLodging.FlatAppearance.BorderSize = 0;
            this.btnDeleteLodging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLodging.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.btnDeleteLodging.Location = new System.Drawing.Point(328, 183);
            this.btnDeleteLodging.Name = "btnDeleteLodging";
            this.btnDeleteLodging.Size = new System.Drawing.Size(52, 30);
            this.btnDeleteLodging.TabIndex = 17;
            this.btnDeleteLodging.UseVisualStyleBackColor = true;
            this.btnDeleteLodging.Click += new System.EventHandler(this.btnDeleteLodging_Click);
            // 
            // lblMileage
            // 
            this.lblMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.Location = new System.Drawing.Point(3, 226);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(160, 15);
            this.lblMileage.TabIndex = 18;
            this.lblMileage.Text = "Mileage";
            this.lblMileage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditMileage
            // 
            this.btnEditMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditMileage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditMileage.Enabled = false;
            this.btnEditMileage.FlatAppearance.BorderSize = 0;
            this.btnEditMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMileage.Image = global::TravelExpenses.Properties.Resources._1493081488_pen;
            this.btnEditMileage.Location = new System.Drawing.Point(202, 219);
            this.btnEditMileage.Name = "btnEditMileage";
            this.btnEditMileage.Size = new System.Drawing.Size(52, 30);
            this.btnEditMileage.TabIndex = 19;
            this.btnEditMileage.UseVisualStyleBackColor = true;
            this.btnEditMileage.Click += new System.EventHandler(this.btnEditMileage_Click);
            // 
            // btnDeleteMileage
            // 
            this.btnDeleteMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteMileage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteMileage.Enabled = false;
            this.btnDeleteMileage.FlatAppearance.BorderSize = 0;
            this.btnDeleteMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMileage.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.btnDeleteMileage.Location = new System.Drawing.Point(328, 219);
            this.btnDeleteMileage.Name = "btnDeleteMileage";
            this.btnDeleteMileage.Size = new System.Drawing.Size(52, 30);
            this.btnDeleteMileage.TabIndex = 20;
            this.btnDeleteMileage.UseVisualStyleBackColor = true;
            this.btnDeleteMileage.Click += new System.EventHandler(this.btnDeleteMileage_Click);
            // 
            // lblOtherExpenses
            // 
            this.lblOtherExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherExpenses.AutoSize = true;
            this.lblOtherExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherExpenses.Location = new System.Drawing.Point(3, 264);
            this.lblOtherExpenses.Name = "lblOtherExpenses";
            this.lblOtherExpenses.Size = new System.Drawing.Size(160, 15);
            this.lblOtherExpenses.TabIndex = 21;
            this.lblOtherExpenses.Text = "Other Expenses";
            this.lblOtherExpenses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditOtherExpenses
            // 
            this.btnEditOtherExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditOtherExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditOtherExpenses.Enabled = false;
            this.btnEditOtherExpenses.FlatAppearance.BorderSize = 0;
            this.btnEditOtherExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOtherExpenses.Image = global::TravelExpenses.Properties.Resources._1493081488_pen;
            this.btnEditOtherExpenses.Location = new System.Drawing.Point(202, 257);
            this.btnEditOtherExpenses.Name = "btnEditOtherExpenses";
            this.btnEditOtherExpenses.Size = new System.Drawing.Size(52, 30);
            this.btnEditOtherExpenses.TabIndex = 22;
            this.btnEditOtherExpenses.UseVisualStyleBackColor = true;
            this.btnEditOtherExpenses.Click += new System.EventHandler(this.btnEditOtherExpenses_Click);
            // 
            // btnDeleteOtherExpenses
            // 
            this.btnDeleteOtherExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOtherExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteOtherExpenses.Enabled = false;
            this.btnDeleteOtherExpenses.FlatAppearance.BorderSize = 0;
            this.btnDeleteOtherExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOtherExpenses.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.btnDeleteOtherExpenses.Location = new System.Drawing.Point(328, 257);
            this.btnDeleteOtherExpenses.Name = "btnDeleteOtherExpenses";
            this.btnDeleteOtherExpenses.Size = new System.Drawing.Size(52, 30);
            this.btnDeleteOtherExpenses.TabIndex = 23;
            this.btnDeleteOtherExpenses.UseVisualStyleBackColor = true;
            this.btnDeleteOtherExpenses.Click += new System.EventHandler(this.btnDeleteOtherExpenses_Click);
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseEdit.FlatAppearance.BorderSize = 0;
            this.btnCloseEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseEdit.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCloseEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseEdit.Location = new System.Drawing.Point(26, 509);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(81, 43);
            this.btnCloseEdit.TabIndex = 1;
            this.btnCloseEdit.Text = "Close";
            this.btnCloseEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseEdit.UseVisualStyleBackColor = true;
            this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
            // 
            // SelectItemsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 559);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseEdit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectItemsEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing Travel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectItemsEdit_FormClosed);
            this.Load += new System.EventHandler(this.SelectItemsEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTravelDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabTravelItems.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTravelDetails;
        private System.Windows.Forms.TabPage tabTravelItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.Label lblTravelEvent;
        private System.Windows.Forms.Label lblTravelPurpose;
        private System.Windows.Forms.Label lblOtherEvent;
        private System.Windows.Forms.Label lblOtherPurpose;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTravelState;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnTime;
        private System.Windows.Forms.ComboBox cbTravelEvent;
        private System.Windows.Forms.ComboBox cbTravelPurpose;
        private System.Windows.Forms.TextBox txtOtherEvent;
        private System.Windows.Forms.TextBox txtOtherPurpose;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.ComboBox cbTravelState;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnEditMeals;
        private System.Windows.Forms.Button btnDeleteMeals;
        private System.Windows.Forms.Label lblMeals;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Button btnEditRegistration;
        private System.Windows.Forms.Button btnDeleteRegistration;
        private System.Windows.Forms.Label lblCarRental;
        private System.Windows.Forms.Button btnEditCarRental;
        private System.Windows.Forms.Button btnDeleteCarRental;
        private System.Windows.Forms.Label lblAirFare;
        private System.Windows.Forms.Button btnEditAirFare;
        private System.Windows.Forms.Button btnDeleteAirFare;
        private System.Windows.Forms.Label lblLodgings;
        private System.Windows.Forms.Button btnEditLodging;
        private System.Windows.Forms.Button btnDeleteLodging;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Button btnEditMileage;
        private System.Windows.Forms.Button btnDeleteMileage;
        private System.Windows.Forms.Label lblOtherExpenses;
        private System.Windows.Forms.Button btnEditOtherExpenses;
        private System.Windows.Forms.Button btnDeleteOtherExpenses;
        private System.Windows.Forms.Button btnSaveDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblColorExplanation;
        private System.Windows.Forms.Label lblTravelTotal;
        private System.Windows.Forms.Label lblTravelReimb;
        private System.Windows.Forms.Label lblTravelTotalAmount;
        private System.Windows.Forms.Label lblTravelReimbAmount;
        private System.Windows.Forms.Button btnCloseEdit;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}