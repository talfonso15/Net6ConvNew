namespace TravelExpenses
{
    partial class AllEstimates
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEstimates));
            dgvAllEstimates = new System.Windows.Forms.DataGridView();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BudgetedTravel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            EstimatedTravelCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelEstomatedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tlOptionButtons = new System.Windows.Forms.TableLayoutPanel();
            btnCancel = new System.Windows.Forms.Button();
            btnEstimatePDF = new System.Windows.Forms.Button();
            btnApproval = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnViewEstimate = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            pEstimateDetails = new System.Windows.Forms.Panel();
            gbTravelDetails = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblDepartureDate = new System.Windows.Forms.Label();
            lblReturnDate = new System.Windows.Forms.Label();
            lblTravelEvent = new System.Windows.Forms.Label();
            txtTravelEvent = new System.Windows.Forms.TextBox();
            lblTravelPurpose = new System.Windows.Forms.Label();
            txtTravelPurpose = new System.Windows.Forms.TextBox();
            lblTravelBudgeted = new System.Windows.Forms.Label();
            lblTravelEstTotal = new System.Windows.Forms.Label();
            lblEstimatedTotalValue = new System.Windows.Forms.Label();
            dtpDepartureDateValue = new System.Windows.Forms.DateTimePicker();
            dtpReturnDateValue = new System.Windows.Forms.DateTimePicker();
            pTravelBudget = new System.Windows.Forms.Panel();
            rbNo = new System.Windows.Forms.RadioButton();
            rbYes = new System.Windows.Forms.RadioButton();
            lblDestination = new System.Windows.Forms.Label();
            txtDestination = new System.Windows.Forms.TextBox();
            lblMealsPerDiemRate = new System.Windows.Forms.Label();
            txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            gbTravelItems = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            txtMileageCost = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            lblCost = new System.Windows.Forms.Label();
            lblNotes = new System.Windows.Forms.Label();
            lblMeals = new System.Windows.Forms.Label();
            lblRegistration = new System.Windows.Forms.Label();
            lblLodging = new System.Windows.Forms.Label();
            lblCarRental = new System.Windows.Forms.Label();
            lblAirfare = new System.Windows.Forms.Label();
            lblMileage = new System.Windows.Forms.Label();
            lblOtherExpenses = new System.Windows.Forms.Label();
            txtMealsNotes = new System.Windows.Forms.TextBox();
            txtRegistrationNotes = new System.Windows.Forms.TextBox();
            txtLodgingNotes = new System.Windows.Forms.TextBox();
            txtCarRentalNotes = new System.Windows.Forms.TextBox();
            txtAirfareNotes = new System.Windows.Forms.TextBox();
            txtMileageNotes = new System.Windows.Forms.TextBox();
            txtOtherExpNotes = new System.Windows.Forms.TextBox();
            txtMealsCost = new System.Windows.Forms.TextBox();
            txtRegistrationCost = new System.Windows.Forms.TextBox();
            txtLodgingCost = new System.Windows.Forms.TextBox();
            txtCarRentalCost = new System.Windows.Forms.TextBox();
            txtAirfareCost = new System.Windows.Forms.TextBox();
            txtOtherExpensesCost = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            lblNotifications = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnInfo = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnUpdate = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvAllEstimates).BeginInit();
            tlOptionButtons.SuspendLayout();
            pEstimateDetails.SuspendLayout();
            gbTravelDetails.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pTravelBudget.SuspendLayout();
            gbTravelItems.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAllEstimates
            // 
            dgvAllEstimates.AllowUserToAddRows = false;
            dgvAllEstimates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllEstimates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DepartureDate, ReturnDate, TravelEvent, TravelPurpose, BudgetedTravel, EstimatedTravelCost, TravelEstomatedID, Approved });
            dgvAllEstimates.Location = new System.Drawing.Point(15, 52);
            dgvAllEstimates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dgvAllEstimates.MultiSelect = false;
            dgvAllEstimates.Name = "dgvAllEstimates";
            dgvAllEstimates.RowHeadersWidth = 62;
            dgvAllEstimates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAllEstimates.Size = new System.Drawing.Size(792, 165);
            dgvAllEstimates.TabIndex = 1;
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "Departure";
            DepartureDate.MinimumWidth = 8;
            DepartureDate.Name = "DepartureDate";
            DepartureDate.ReadOnly = true;
            DepartureDate.Width = 150;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Return";
            ReturnDate.MinimumWidth = 8;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            ReturnDate.Width = 150;
            // 
            // TravelEvent
            // 
            TravelEvent.HeaderText = "Event";
            TravelEvent.MinimumWidth = 8;
            TravelEvent.Name = "TravelEvent";
            TravelEvent.ReadOnly = true;
            TravelEvent.Width = 200;
            // 
            // TravelPurpose
            // 
            TravelPurpose.HeaderText = "Purpose";
            TravelPurpose.MinimumWidth = 8;
            TravelPurpose.Name = "TravelPurpose";
            TravelPurpose.ReadOnly = true;
            TravelPurpose.Visible = false;
            TravelPurpose.Width = 170;
            // 
            // BudgetedTravel
            // 
            BudgetedTravel.HeaderText = "Budgeted";
            BudgetedTravel.MinimumWidth = 8;
            BudgetedTravel.Name = "BudgetedTravel";
            BudgetedTravel.ReadOnly = true;
            BudgetedTravel.Width = 150;
            // 
            // EstimatedTravelCost
            // 
            EstimatedTravelCost.HeaderText = "Total";
            EstimatedTravelCost.MinimumWidth = 8;
            EstimatedTravelCost.Name = "EstimatedTravelCost";
            EstimatedTravelCost.ReadOnly = true;
            EstimatedTravelCost.Width = 80;
            // 
            // TravelEstomatedID
            // 
            TravelEstomatedID.HeaderText = "TravelEstomatedID";
            TravelEstomatedID.MinimumWidth = 8;
            TravelEstomatedID.Name = "TravelEstomatedID";
            TravelEstomatedID.Visible = false;
            TravelEstomatedID.Width = 150;
            // 
            // Approved
            // 
            Approved.HeaderText = "Approved";
            Approved.MinimumWidth = 8;
            Approved.Name = "Approved";
            Approved.Width = 150;
            // 
            // tlOptionButtons
            // 
            tlOptionButtons.ColumnCount = 9;
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.8421059F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0451126F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.11278F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tlOptionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tlOptionButtons.Controls.Add(btnCancel, 0, 0);
            tlOptionButtons.Controls.Add(btnEstimatePDF, 2, 0);
            tlOptionButtons.Controls.Add(btnApproval, 4, 0);
            tlOptionButtons.Controls.Add(label3, 5, 0);
            tlOptionButtons.Controls.Add(label2, 3, 0);
            tlOptionButtons.Controls.Add(label1, 1, 0);
            tlOptionButtons.Controls.Add(btnViewEstimate, 8, 0);
            tlOptionButtons.Controls.Add(btnEdit, 6, 0);
            tlOptionButtons.Controls.Add(label4, 7, 0);
            tlOptionButtons.Location = new System.Drawing.Point(490, 1);
            tlOptionButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tlOptionButtons.Name = "tlOptionButtons";
            tlOptionButtons.RowCount = 1;
            tlOptionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlOptionButtons.Size = new System.Drawing.Size(329, 49);
            tlOptionButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new System.Drawing.Point(4, 4);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(36, 41);
            btnCancel.TabIndex = 2;
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCancel, "Close Window");
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEstimatePDF
            // 
            btnEstimatePDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEstimatePDF.FlatAppearance.BorderSize = 0;
            btnEstimatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEstimatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEstimatePDF.Image = (System.Drawing.Image)resources.GetObject("btnEstimatePDF.Image");
            btnEstimatePDF.Location = new System.Drawing.Point(76, 4);
            btnEstimatePDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnEstimatePDF.Name = "btnEstimatePDF";
            btnEstimatePDF.Size = new System.Drawing.Size(31, 41);
            btnEstimatePDF.TabIndex = 1;
            btnEstimatePDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnEstimatePDF, "Create PDF");
            btnEstimatePDF.UseVisualStyleBackColor = true;
            btnEstimatePDF.Click += btnEstimatePDF_Click;
            // 
            // btnApproval
            // 
            btnApproval.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnApproval.FlatAppearance.BorderSize = 0;
            btnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnApproval.Image = (System.Drawing.Image)resources.GetObject("btnApproval.Image");
            btnApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnApproval.Location = new System.Drawing.Point(149, 4);
            btnApproval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnApproval.Name = "btnApproval";
            btnApproval.Size = new System.Drawing.Size(38, 41);
            btnApproval.TabIndex = 5;
            btnApproval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnApproval, "Approve & Sign");
            btnApproval.UseVisualStyleBackColor = true;
            btnApproval.Click += btnApproval_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(195, 12);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(13, 25);
            label3.TabIndex = 6;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(123, 12);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(18, 25);
            label2.TabIndex = 4;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(48, 12);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(13, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewEstimate
            // 
            btnViewEstimate.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnViewEstimate.FlatAppearance.BorderSize = 0;
            btnViewEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnViewEstimate.Image = (System.Drawing.Image)resources.GetObject("btnViewEstimate.Image");
            btnViewEstimate.Location = new System.Drawing.Point(284, 4);
            btnViewEstimate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnViewEstimate.Name = "btnViewEstimate";
            btnViewEstimate.Size = new System.Drawing.Size(40, 41);
            btnViewEstimate.TabIndex = 0;
            btnViewEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnViewEstimate, "View Details");
            btnViewEstimate.UseVisualStyleBackColor = true;
            btnViewEstimate.Click += btnViewEstimate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Image = (System.Drawing.Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new System.Drawing.Point(217, 4);
            btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(33, 41);
            btnEdit.TabIndex = 7;
            toolTip1.SetToolTip(btnEdit, "Edit Authorization");
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(259, 12);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(16, 25);
            label4.TabIndex = 8;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEstimateDetails
            // 
            pEstimateDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pEstimateDetails.Controls.Add(gbTravelDetails);
            pEstimateDetails.Controls.Add(gbTravelItems);
            pEstimateDetails.Location = new System.Drawing.Point(40, 269);
            pEstimateDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pEstimateDetails.Name = "pEstimateDetails";
            pEstimateDetails.Size = new System.Drawing.Size(823, 556);
            pEstimateDetails.TabIndex = 3;
            // 
            // gbTravelDetails
            // 
            gbTravelDetails.Controls.Add(tableLayoutPanel2);
            gbTravelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbTravelDetails.Location = new System.Drawing.Point(28, 13);
            gbTravelDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbTravelDetails.Name = "gbTravelDetails";
            gbTravelDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbTravelDetails.Size = new System.Drawing.Size(766, 194);
            gbTravelDetails.TabIndex = 3;
            gbTravelDetails.TabStop = false;
            gbTravelDetails.Text = "Travel Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54397F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31126F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.68212F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.80132F));
            tableLayoutPanel2.Controls.Add(lblDepartureDate, 0, 0);
            tableLayoutPanel2.Controls.Add(lblReturnDate, 2, 0);
            tableLayoutPanel2.Controls.Add(lblTravelEvent, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTravelEvent, 1, 1);
            tableLayoutPanel2.Controls.Add(lblTravelPurpose, 2, 1);
            tableLayoutPanel2.Controls.Add(txtTravelPurpose, 3, 1);
            tableLayoutPanel2.Controls.Add(lblTravelBudgeted, 0, 2);
            tableLayoutPanel2.Controls.Add(lblTravelEstTotal, 2, 2);
            tableLayoutPanel2.Controls.Add(lblEstimatedTotalValue, 3, 2);
            tableLayoutPanel2.Controls.Add(dtpDepartureDateValue, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpReturnDateValue, 3, 0);
            tableLayoutPanel2.Controls.Add(pTravelBudget, 1, 2);
            tableLayoutPanel2.Controls.Add(lblDestination, 0, 3);
            tableLayoutPanel2.Controls.Add(txtDestination, 1, 3);
            tableLayoutPanel2.Controls.Add(lblMealsPerDiemRate, 2, 3);
            tableLayoutPanel2.Controls.Add(txtMealsPerDiemRate, 3, 3);
            tableLayoutPanel2.Location = new System.Drawing.Point(14, 22);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new System.Drawing.Size(705, 165);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartureDate.AutoSize = true;
            lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDepartureDate.Location = new System.Drawing.Point(4, 14);
            lblDepartureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new System.Drawing.Size(129, 13);
            lblDepartureDate.TabIndex = 0;
            lblDepartureDate.Text = "Departure Date:";
            // 
            // lblReturnDate
            // 
            lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblReturnDate.Location = new System.Drawing.Point(339, 14);
            lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new System.Drawing.Size(151, 13);
            lblReturnDate.TabIndex = 1;
            lblReturnDate.Text = "Return Date:";
            // 
            // lblTravelEvent
            // 
            lblTravelEvent.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTravelEvent.AutoSize = true;
            lblTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTravelEvent.Location = new System.Drawing.Point(4, 55);
            lblTravelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTravelEvent.Name = "lblTravelEvent";
            lblTravelEvent.Size = new System.Drawing.Size(129, 13);
            lblTravelEvent.TabIndex = 4;
            lblTravelEvent.Text = "Travel Event:";
            // 
            // txtTravelEvent
            // 
            txtTravelEvent.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTravelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTravelEvent.Location = new System.Drawing.Point(141, 45);
            txtTravelEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtTravelEvent.Multiline = true;
            txtTravelEvent.Name = "txtTravelEvent";
            txtTravelEvent.ReadOnly = true;
            txtTravelEvent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtTravelEvent.Size = new System.Drawing.Size(190, 33);
            txtTravelEvent.TabIndex = 5;
            // 
            // lblTravelPurpose
            // 
            lblTravelPurpose.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTravelPurpose.AutoSize = true;
            lblTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTravelPurpose.Location = new System.Drawing.Point(339, 55);
            lblTravelPurpose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTravelPurpose.Name = "lblTravelPurpose";
            lblTravelPurpose.Size = new System.Drawing.Size(151, 13);
            lblTravelPurpose.TabIndex = 6;
            lblTravelPurpose.Text = "Travel Purpose:";
            // 
            // txtTravelPurpose
            // 
            txtTravelPurpose.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTravelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTravelPurpose.Location = new System.Drawing.Point(498, 45);
            txtTravelPurpose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtTravelPurpose.Multiline = true;
            txtTravelPurpose.Name = "txtTravelPurpose";
            txtTravelPurpose.ReadOnly = true;
            txtTravelPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtTravelPurpose.Size = new System.Drawing.Size(203, 33);
            txtTravelPurpose.TabIndex = 7;
            // 
            // lblTravelBudgeted
            // 
            lblTravelBudgeted.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTravelBudgeted.AutoSize = true;
            lblTravelBudgeted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTravelBudgeted.Location = new System.Drawing.Point(4, 96);
            lblTravelBudgeted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTravelBudgeted.Name = "lblTravelBudgeted";
            lblTravelBudgeted.Size = new System.Drawing.Size(129, 13);
            lblTravelBudgeted.TabIndex = 8;
            lblTravelBudgeted.Text = "Travel Budgeted:";
            // 
            // lblTravelEstTotal
            // 
            lblTravelEstTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTravelEstTotal.AutoSize = true;
            lblTravelEstTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTravelEstTotal.Location = new System.Drawing.Point(339, 96);
            lblTravelEstTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTravelEstTotal.Name = "lblTravelEstTotal";
            lblTravelEstTotal.Size = new System.Drawing.Size(151, 13);
            lblTravelEstTotal.TabIndex = 10;
            lblTravelEstTotal.Text = "Estimated Total:";
            // 
            // lblEstimatedTotalValue
            // 
            lblEstimatedTotalValue.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEstimatedTotalValue.AutoSize = true;
            lblEstimatedTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEstimatedTotalValue.Location = new System.Drawing.Point(498, 96);
            lblEstimatedTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEstimatedTotalValue.Name = "lblEstimatedTotalValue";
            lblEstimatedTotalValue.Size = new System.Drawing.Size(203, 13);
            lblEstimatedTotalValue.TabIndex = 11;
            // 
            // dtpDepartureDateValue
            // 
            dtpDepartureDateValue.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpDepartureDateValue.Enabled = false;
            dtpDepartureDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDepartureDateValue.Location = new System.Drawing.Point(141, 10);
            dtpDepartureDateValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dtpDepartureDateValue.Name = "dtpDepartureDateValue";
            dtpDepartureDateValue.Size = new System.Drawing.Size(190, 20);
            dtpDepartureDateValue.TabIndex = 12;
            dtpDepartureDateValue.ValueChanged += dtpDepartureDateValue_ValueChanged;
            // 
            // dtpReturnDateValue
            // 
            dtpReturnDateValue.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpReturnDateValue.Enabled = false;
            dtpReturnDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReturnDateValue.Location = new System.Drawing.Point(498, 10);
            dtpReturnDateValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dtpReturnDateValue.Name = "dtpReturnDateValue";
            dtpReturnDateValue.Size = new System.Drawing.Size(203, 20);
            dtpReturnDateValue.TabIndex = 13;
            dtpReturnDateValue.ValueChanged += dtpReturnDateValue_ValueChanged;
            // 
            // pTravelBudget
            // 
            pTravelBudget.Controls.Add(rbNo);
            pTravelBudget.Controls.Add(rbYes);
            pTravelBudget.Enabled = false;
            pTravelBudget.Location = new System.Drawing.Point(141, 86);
            pTravelBudget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pTravelBudget.Name = "pTravelBudget";
            pTravelBudget.Size = new System.Drawing.Size(190, 32);
            pTravelBudget.TabIndex = 14;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new System.Drawing.Point(118, 8);
            rbNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            rbNo.Name = "rbNo";
            rbNo.Size = new System.Drawing.Size(41, 17);
            rbNo.TabIndex = 1;
            rbNo.TabStop = true;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Location = new System.Drawing.Point(42, 8);
            rbYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            rbYes.Name = "rbYes";
            rbYes.Size = new System.Drawing.Size(46, 17);
            rbYes.TabIndex = 0;
            rbYes.TabStop = true;
            rbYes.Text = "Yes";
            rbYes.UseVisualStyleBackColor = true;
            // 
            // lblDestination
            // 
            lblDestination.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDestination.AutoSize = true;
            lblDestination.Location = new System.Drawing.Point(4, 137);
            lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new System.Drawing.Size(129, 13);
            lblDestination.TabIndex = 15;
            lblDestination.Text = "City / State:";
            // 
            // txtDestination
            // 
            txtDestination.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDestination.Location = new System.Drawing.Point(141, 127);
            txtDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtDestination.Multiline = true;
            txtDestination.Name = "txtDestination";
            txtDestination.ReadOnly = true;
            txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtDestination.Size = new System.Drawing.Size(190, 34);
            txtDestination.TabIndex = 16;
            // 
            // lblMealsPerDiemRate
            // 
            lblMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMealsPerDiemRate.AutoSize = true;
            lblMealsPerDiemRate.Location = new System.Drawing.Point(339, 137);
            lblMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            lblMealsPerDiemRate.Size = new System.Drawing.Size(151, 13);
            lblMealsPerDiemRate.TabIndex = 17;
            lblMealsPerDiemRate.Text = "Meals Per Diem Rate:";
            // 
            // txtMealsPerDiemRate
            // 
            txtMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsPerDiemRate.Location = new System.Drawing.Point(498, 134);
            txtMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            txtMealsPerDiemRate.ReadOnly = true;
            txtMealsPerDiemRate.Size = new System.Drawing.Size(203, 20);
            txtMealsPerDiemRate.TabIndex = 18;
            txtMealsPerDiemRate.TextChanged += txtMealsPerDiemRate_TextChanged;
            txtMealsPerDiemRate.KeyPress += txtMealsPerDiemRate_KeyPress;
            // 
            // gbTravelItems
            // 
            gbTravelItems.Controls.Add(tableLayoutPanel3);
            gbTravelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbTravelItems.Location = new System.Drawing.Point(28, 217);
            gbTravelItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbTravelItems.Name = "gbTravelItems";
            gbTravelItems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gbTravelItems.Size = new System.Drawing.Size(734, 325);
            gbTravelItems.TabIndex = 2;
            gbTravelItems.TabStop = false;
            gbTravelItems.Text = "Travel Items";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19217F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.72598F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.08185F));
            tableLayoutPanel3.Controls.Add(panel2, 1, 6);
            tableLayoutPanel3.Controls.Add(lblName, 0, 0);
            tableLayoutPanel3.Controls.Add(lblCost, 1, 0);
            tableLayoutPanel3.Controls.Add(lblNotes, 2, 0);
            tableLayoutPanel3.Controls.Add(lblMeals, 0, 1);
            tableLayoutPanel3.Controls.Add(lblRegistration, 0, 2);
            tableLayoutPanel3.Controls.Add(lblLodging, 0, 3);
            tableLayoutPanel3.Controls.Add(lblCarRental, 0, 4);
            tableLayoutPanel3.Controls.Add(lblAirfare, 0, 5);
            tableLayoutPanel3.Controls.Add(lblMileage, 0, 6);
            tableLayoutPanel3.Controls.Add(lblOtherExpenses, 0, 7);
            tableLayoutPanel3.Controls.Add(txtMealsNotes, 2, 1);
            tableLayoutPanel3.Controls.Add(txtRegistrationNotes, 2, 2);
            tableLayoutPanel3.Controls.Add(txtLodgingNotes, 2, 3);
            tableLayoutPanel3.Controls.Add(txtCarRentalNotes, 2, 4);
            tableLayoutPanel3.Controls.Add(txtAirfareNotes, 2, 5);
            tableLayoutPanel3.Controls.Add(txtMileageNotes, 2, 6);
            tableLayoutPanel3.Controls.Add(txtOtherExpNotes, 2, 7);
            tableLayoutPanel3.Controls.Add(txtMealsCost, 1, 1);
            tableLayoutPanel3.Controls.Add(txtRegistrationCost, 1, 2);
            tableLayoutPanel3.Controls.Add(txtLodgingCost, 1, 3);
            tableLayoutPanel3.Controls.Add(txtCarRentalCost, 1, 4);
            tableLayoutPanel3.Controls.Add(txtAirfareCost, 1, 5);
            tableLayoutPanel3.Controls.Add(txtOtherExpensesCost, 1, 7);
            tableLayoutPanel3.Location = new System.Drawing.Point(14, 24);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.Size = new System.Drawing.Size(705, 290);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtMileageCost);
            panel2.Location = new System.Drawing.Point(118, 220);
            panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(109, 28);
            panel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(4, 2);
            button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(35, 24);
            button1.TabIndex = 30;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMileageCost
            // 
            txtMileageCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMileageCost.Location = new System.Drawing.Point(40, 4);
            txtMileageCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtMileageCost.Name = "txtMileageCost";
            txtMileageCost.ReadOnly = true;
            txtMileageCost.Size = new System.Drawing.Size(65, 20);
            txtMileageCost.TabIndex = 29;
            txtMileageCost.KeyPress += txtMileageCost_KeyPress;
            // 
            // lblName
            // 
            lblName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(4, 11);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(106, 13);
            lblName.TabIndex = 0;
            lblName.Text = "Item";
            // 
            // lblCost
            // 
            lblCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCost.AutoSize = true;
            lblCost.Location = new System.Drawing.Point(118, 11);
            lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCost.Name = "lblCost";
            lblCost.Size = new System.Drawing.Size(109, 13);
            lblCost.TabIndex = 1;
            lblCost.Text = "Cost";
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Location = new System.Drawing.Point(235, 11);
            lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(466, 13);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "Notes";
            // 
            // lblMeals
            // 
            lblMeals.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMeals.AutoSize = true;
            lblMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMeals.Location = new System.Drawing.Point(4, 47);
            lblMeals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new System.Drawing.Size(106, 13);
            lblMeals.TabIndex = 3;
            lblMeals.Text = "Meals";
            // 
            // lblRegistration
            // 
            lblRegistration.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRegistration.Location = new System.Drawing.Point(4, 83);
            lblRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new System.Drawing.Size(106, 13);
            lblRegistration.TabIndex = 4;
            lblRegistration.Text = "Registration";
            // 
            // lblLodging
            // 
            lblLodging.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLodging.AutoSize = true;
            lblLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLodging.Location = new System.Drawing.Point(4, 119);
            lblLodging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLodging.Name = "lblLodging";
            lblLodging.Size = new System.Drawing.Size(106, 13);
            lblLodging.TabIndex = 5;
            lblLodging.Text = "Lodging";
            // 
            // lblCarRental
            // 
            lblCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCarRental.AutoSize = true;
            lblCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCarRental.Location = new System.Drawing.Point(4, 155);
            lblCarRental.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarRental.Name = "lblCarRental";
            lblCarRental.Size = new System.Drawing.Size(106, 13);
            lblCarRental.TabIndex = 6;
            lblCarRental.Text = "Car Rental";
            // 
            // lblAirfare
            // 
            lblAirfare.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAirfare.AutoSize = true;
            lblAirfare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAirfare.Location = new System.Drawing.Point(4, 191);
            lblAirfare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAirfare.Name = "lblAirfare";
            lblAirfare.Size = new System.Drawing.Size(106, 13);
            lblAirfare.TabIndex = 7;
            lblAirfare.Text = "Airfare";
            // 
            // lblMileage
            // 
            lblMileage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMileage.AutoSize = true;
            lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMileage.Location = new System.Drawing.Point(4, 227);
            lblMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new System.Drawing.Size(106, 13);
            lblMileage.TabIndex = 8;
            lblMileage.Text = "Mileage";
            // 
            // lblOtherExpenses
            // 
            lblOtherExpenses.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOtherExpenses.AutoSize = true;
            lblOtherExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOtherExpenses.Location = new System.Drawing.Point(4, 264);
            lblOtherExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOtherExpenses.Name = "lblOtherExpenses";
            lblOtherExpenses.Size = new System.Drawing.Size(106, 13);
            lblOtherExpenses.TabIndex = 9;
            lblOtherExpenses.Text = "Other Expenses";
            // 
            // txtMealsNotes
            // 
            txtMealsNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsNotes.Location = new System.Drawing.Point(235, 40);
            txtMealsNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtMealsNotes.Multiline = true;
            txtMealsNotes.Name = "txtMealsNotes";
            txtMealsNotes.ReadOnly = true;
            txtMealsNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtMealsNotes.Size = new System.Drawing.Size(466, 28);
            txtMealsNotes.TabIndex = 17;
            // 
            // txtRegistrationNotes
            // 
            txtRegistrationNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtRegistrationNotes.Location = new System.Drawing.Point(235, 76);
            txtRegistrationNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtRegistrationNotes.Multiline = true;
            txtRegistrationNotes.Name = "txtRegistrationNotes";
            txtRegistrationNotes.ReadOnly = true;
            txtRegistrationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtRegistrationNotes.Size = new System.Drawing.Size(466, 28);
            txtRegistrationNotes.TabIndex = 18;
            // 
            // txtLodgingNotes
            // 
            txtLodgingNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLodgingNotes.Location = new System.Drawing.Point(235, 112);
            txtLodgingNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtLodgingNotes.Multiline = true;
            txtLodgingNotes.Name = "txtLodgingNotes";
            txtLodgingNotes.ReadOnly = true;
            txtLodgingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtLodgingNotes.Size = new System.Drawing.Size(466, 28);
            txtLodgingNotes.TabIndex = 19;
            // 
            // txtCarRentalNotes
            // 
            txtCarRentalNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCarRentalNotes.Location = new System.Drawing.Point(235, 148);
            txtCarRentalNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtCarRentalNotes.Multiline = true;
            txtCarRentalNotes.Name = "txtCarRentalNotes";
            txtCarRentalNotes.ReadOnly = true;
            txtCarRentalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtCarRentalNotes.Size = new System.Drawing.Size(466, 28);
            txtCarRentalNotes.TabIndex = 20;
            // 
            // txtAirfareNotes
            // 
            txtAirfareNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAirfareNotes.Location = new System.Drawing.Point(235, 184);
            txtAirfareNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtAirfareNotes.Multiline = true;
            txtAirfareNotes.Name = "txtAirfareNotes";
            txtAirfareNotes.ReadOnly = true;
            txtAirfareNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtAirfareNotes.Size = new System.Drawing.Size(466, 28);
            txtAirfareNotes.TabIndex = 21;
            // 
            // txtMileageNotes
            // 
            txtMileageNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMileageNotes.Location = new System.Drawing.Point(235, 220);
            txtMileageNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtMileageNotes.Multiline = true;
            txtMileageNotes.Name = "txtMileageNotes";
            txtMileageNotes.ReadOnly = true;
            txtMileageNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtMileageNotes.Size = new System.Drawing.Size(466, 28);
            txtMileageNotes.TabIndex = 22;
            // 
            // txtOtherExpNotes
            // 
            txtOtherExpNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOtherExpNotes.Location = new System.Drawing.Point(235, 256);
            txtOtherExpNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtOtherExpNotes.Multiline = true;
            txtOtherExpNotes.Name = "txtOtherExpNotes";
            txtOtherExpNotes.ReadOnly = true;
            txtOtherExpNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtOtherExpNotes.Size = new System.Drawing.Size(466, 30);
            txtOtherExpNotes.TabIndex = 23;
            // 
            // txtMealsCost
            // 
            txtMealsCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsCost.Location = new System.Drawing.Point(118, 44);
            txtMealsCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtMealsCost.Name = "txtMealsCost";
            txtMealsCost.ReadOnly = true;
            txtMealsCost.Size = new System.Drawing.Size(109, 20);
            txtMealsCost.TabIndex = 24;
            txtMealsCost.KeyPress += txtMealsCost_KeyPress;
            // 
            // txtRegistrationCost
            // 
            txtRegistrationCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtRegistrationCost.Location = new System.Drawing.Point(118, 80);
            txtRegistrationCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtRegistrationCost.Name = "txtRegistrationCost";
            txtRegistrationCost.ReadOnly = true;
            txtRegistrationCost.Size = new System.Drawing.Size(109, 20);
            txtRegistrationCost.TabIndex = 25;
            txtRegistrationCost.KeyPress += txtRegistrationCost_KeyPress;
            // 
            // txtLodgingCost
            // 
            txtLodgingCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLodgingCost.Location = new System.Drawing.Point(118, 116);
            txtLodgingCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtLodgingCost.Name = "txtLodgingCost";
            txtLodgingCost.ReadOnly = true;
            txtLodgingCost.Size = new System.Drawing.Size(109, 20);
            txtLodgingCost.TabIndex = 26;
            txtLodgingCost.KeyPress += txtLodgingCost_KeyPress;
            // 
            // txtCarRentalCost
            // 
            txtCarRentalCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCarRentalCost.Location = new System.Drawing.Point(118, 152);
            txtCarRentalCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtCarRentalCost.Name = "txtCarRentalCost";
            txtCarRentalCost.ReadOnly = true;
            txtCarRentalCost.Size = new System.Drawing.Size(109, 20);
            txtCarRentalCost.TabIndex = 27;
            txtCarRentalCost.KeyPress += txtCarRentalCost_KeyPress;
            // 
            // txtAirfareCost
            // 
            txtAirfareCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAirfareCost.Location = new System.Drawing.Point(118, 188);
            txtAirfareCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtAirfareCost.Name = "txtAirfareCost";
            txtAirfareCost.ReadOnly = true;
            txtAirfareCost.Size = new System.Drawing.Size(109, 20);
            txtAirfareCost.TabIndex = 28;
            txtAirfareCost.KeyPress += txtAirfareCost_KeyPress;
            // 
            // txtOtherExpensesCost
            // 
            txtOtherExpensesCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOtherExpensesCost.Location = new System.Drawing.Point(118, 261);
            txtOtherExpensesCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtOtherExpensesCost.Name = "txtOtherExpensesCost";
            txtOtherExpensesCost.ReadOnly = true;
            txtOtherExpensesCost.Size = new System.Drawing.Size(109, 20);
            txtOtherExpensesCost.TabIndex = 30;
            txtOtherExpensesCost.KeyPress += txtOtherExpensesCost_KeyPress;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNotifications);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnInfo);
            panel1.Controls.Add(tlOptionButtons);
            panel1.Controls.Add(dgvAllEstimates);
            panel1.Location = new System.Drawing.Point(40, 14);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(823, 222);
            panel1.TabIndex = 5;
            // 
            // lblNotifications
            // 
            lblNotifications.AutoSize = true;
            lblNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotifications.Location = new System.Drawing.Point(94, 29);
            lblNotifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new System.Drawing.Size(178, 13);
            lblNotifications.TabIndex = 5;
            lblNotifications.Text = "Sending Notification Emails....";
            lblNotifications.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(55, 5);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(39, 43);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new System.Drawing.Point(13, 25);
            btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(23, 25);
            btnInfo.TabIndex = 3;
            toolTip1.SetToolTip(btnInfo, "Select one travel authorization and then make a click on one of the options:");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Image = (System.Drawing.Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUpdate.Location = new System.Drawing.Point(753, 854);
            btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(110, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(56, 846);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(108, 62);
            btnClose.TabIndex = 4;
            btnClose.Text = "Cancel";
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // AllEstimates
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(902, 929);
            ControlBox = false;
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(pEstimateDetails);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "AllEstimates";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "All Authorizations";
            Load += AllEstimates_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllEstimates).EndInit();
            tlOptionButtons.ResumeLayout(false);
            tlOptionButtons.PerformLayout();
            pEstimateDetails.ResumeLayout(false);
            gbTravelDetails.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pTravelBudget.ResumeLayout(false);
            pTravelBudget.PerformLayout();
            gbTravelItems.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllEstimates;
        private System.Windows.Forms.TableLayoutPanel tlOptionButtons;
        private System.Windows.Forms.Button btnViewEstimate;
        private System.Windows.Forms.Button btnEstimatePDF;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pEstimateDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblTravelEvent;
        private System.Windows.Forms.TextBox txtTravelEvent;
        private System.Windows.Forms.Label lblTravelPurpose;
        private System.Windows.Forms.TextBox txtTravelPurpose;
        private System.Windows.Forms.Label lblTravelBudgeted;
        private System.Windows.Forms.GroupBox gbTravelItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblMeals;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblLodging;
        private System.Windows.Forms.Label lblCarRental;
        private System.Windows.Forms.Label lblAirfare;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblOtherExpenses;
        private System.Windows.Forms.TextBox txtMealsNotes;
        private System.Windows.Forms.TextBox txtRegistrationNotes;
        private System.Windows.Forms.TextBox txtLodgingNotes;
        private System.Windows.Forms.TextBox txtCarRentalNotes;
        private System.Windows.Forms.TextBox txtAirfareNotes;
        private System.Windows.Forms.TextBox txtMileageNotes;
        private System.Windows.Forms.TextBox txtOtherExpNotes;
        private System.Windows.Forms.Label lblTravelEstTotal;
        private System.Windows.Forms.Label lblEstimatedTotalValue;
        private System.Windows.Forms.GroupBox gbTravelDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDepartureDateValue;
        private System.Windows.Forms.DateTimePicker dtpReturnDateValue;
        private System.Windows.Forms.Panel pTravelBudget;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TextBox txtMealsCost;
        private System.Windows.Forms.TextBox txtRegistrationCost;
        private System.Windows.Forms.TextBox txtLodgingCost;
        private System.Windows.Forms.TextBox txtCarRentalCost;
        private System.Windows.Forms.TextBox txtAirfareCost;
        private System.Windows.Forms.TextBox txtMileageCost;
        private System.Windows.Forms.TextBox txtOtherExpensesCost;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMealsPerDiemRate;
        private System.Windows.Forms.TextBox txtMealsPerDiemRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BudgetedTravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTravelCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEstomatedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approved;
    }
}