namespace TravelExpenses
{
    partial class EditAirFare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAirFare));
            dgvEditAirfare = new System.Windows.Forms.DataGridView();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FlightCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            TotalAirfare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AirfareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonalUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            PersonalUseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tlEditFlightButtons = new System.Windows.Forms.TableLayoutPanel();
            btnEditFlight = new System.Windows.Forms.Button();
            btnAddFlight = new System.Windows.Forms.Button();
            btnDeleteFlight = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            pPesonalUseAmount = new System.Windows.Forms.Panel();
            txtPersonalUseAmount = new System.Windows.Forms.TextBox();
            lblPersonalUseAmount = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            rbNoPersonalUse = new System.Windows.Forms.RadioButton();
            rbYesPesonalUse = new System.Windows.Forms.RadioButton();
            lblPersonalUse = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            rbYesDistrictPay = new System.Windows.Forms.RadioButton();
            lblDistricPay = new System.Windows.Forms.Label();
            lblTotalFlight = new System.Windows.Forms.Label();
            lblTaxesAndFees = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblRoundTrip = new System.Windows.Forms.Label();
            lblDepartureDate = new System.Windows.Forms.Label();
            lblReturnDate = new System.Windows.Forms.Label();
            lblFlightCost = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            rbNoRoundTrip = new System.Windows.Forms.RadioButton();
            rbYesRoundTrip = new System.Windows.Forms.RadioButton();
            dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            txtFlightCost = new System.Windows.Forms.TextBox();
            txtTaxesAndFees = new System.Windows.Forms.TextBox();
            txtTotalFlight = new System.Windows.Forms.TextBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnSaveFlight = new System.Windows.Forms.Button();
            btnCancelEdit = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnInfo = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvEditAirfare).BeginInit();
            tlEditFlightButtons.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            pPesonalUseAmount.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEditAirfare
            // 
            dgvEditAirfare.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvEditAirfare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEditAirfare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditAirfare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DepartureDate, ReturnDate, FlightCost, TaxesAndFees, DistrictPay, TotalAirfare, AirfareID, Notes, PersonalUse, PersonalUseAmount });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvEditAirfare.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEditAirfare.Location = new System.Drawing.Point(14, 61);
            dgvEditAirfare.Name = "dgvEditAirfare";
            dgvEditAirfare.ReadOnly = true;
            dgvEditAirfare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEditAirfare.Size = new System.Drawing.Size(668, 139);
            dgvEditAirfare.TabIndex = 1;
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "Departure Date";
            DepartureDate.Name = "DepartureDate";
            DepartureDate.ReadOnly = true;
            DepartureDate.Width = 150;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Return Date";
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            ReturnDate.Width = 150;
            // 
            // FlightCost
            // 
            FlightCost.HeaderText = "Flight Cost";
            FlightCost.Name = "FlightCost";
            FlightCost.ReadOnly = true;
            FlightCost.Width = 150;
            // 
            // TaxesAndFees
            // 
            TaxesAndFees.HeaderText = "Taxes and Fees";
            TaxesAndFees.Name = "TaxesAndFees";
            TaxesAndFees.ReadOnly = true;
            TaxesAndFees.Visible = false;
            TaxesAndFees.Width = 110;
            // 
            // DistrictPay
            // 
            DistrictPay.HeaderText = "District Pay";
            DistrictPay.Name = "DistrictPay";
            DistrictPay.ReadOnly = true;
            DistrictPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            DistrictPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            DistrictPay.Width = 150;
            // 
            // TotalAirfare
            // 
            TotalAirfare.HeaderText = "Total Airfare";
            TotalAirfare.Name = "TotalAirfare";
            TotalAirfare.ReadOnly = true;
            TotalAirfare.Visible = false;
            // 
            // AirfareID
            // 
            AirfareID.HeaderText = "AirfareID";
            AirfareID.Name = "AirfareID";
            AirfareID.ReadOnly = true;
            AirfareID.Visible = false;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Visible = false;
            // 
            // PersonalUse
            // 
            PersonalUse.HeaderText = "Personal Use";
            PersonalUse.Name = "PersonalUse";
            PersonalUse.ReadOnly = true;
            PersonalUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            PersonalUse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            PersonalUse.Visible = false;
            // 
            // PersonalUseAmount
            // 
            PersonalUseAmount.HeaderText = "Personal Use Amount";
            PersonalUseAmount.Name = "PersonalUseAmount";
            PersonalUseAmount.ReadOnly = true;
            PersonalUseAmount.Visible = false;
            // 
            // tlEditFlightButtons
            // 
            tlEditFlightButtons.ColumnCount = 7;
            tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.166667F));
            tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23299F));
            tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.166667F));
            tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            tlEditFlightButtons.Controls.Add(btnEditFlight, 6, 0);
            tlEditFlightButtons.Controls.Add(btnAddFlight, 4, 0);
            tlEditFlightButtons.Controls.Add(btnDeleteFlight, 2, 0);
            tlEditFlightButtons.Controls.Add(label1, 1, 0);
            tlEditFlightButtons.Controls.Add(label2, 3, 0);
            tlEditFlightButtons.Controls.Add(label3, 5, 0);
            tlEditFlightButtons.Controls.Add(btnClose, 0, 0);
            tlEditFlightButtons.Location = new System.Drawing.Point(430, 7);
            tlEditFlightButtons.Name = "tlEditFlightButtons";
            tlEditFlightButtons.RowCount = 1;
            tlEditFlightButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlEditFlightButtons.Size = new System.Drawing.Size(240, 48);
            tlEditFlightButtons.TabIndex = 2;
            // 
            // btnEditFlight
            // 
            btnEditFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEditFlight.FlatAppearance.BorderSize = 0;
            btnEditFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditFlight.Image = (System.Drawing.Image)resources.GetObject("btnEditFlight.Image");
            btnEditFlight.Location = new System.Drawing.Point(197, 3);
            btnEditFlight.Name = "btnEditFlight";
            btnEditFlight.Size = new System.Drawing.Size(34, 42);
            btnEditFlight.TabIndex = 0;
            btnEditFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnEditFlight, "Edit Flight");
            btnEditFlight.UseVisualStyleBackColor = true;
            btnEditFlight.Click += btnEditFlight_Click;
            // 
            // btnAddFlight
            // 
            btnAddFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddFlight.FlatAppearance.BorderSize = 0;
            btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddFlight.Image = (System.Drawing.Image)resources.GetObject("btnAddFlight.Image");
            btnAddFlight.Location = new System.Drawing.Point(131, 3);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new System.Drawing.Size(35, 42);
            btnAddFlight.TabIndex = 1;
            btnAddFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnAddFlight, "Add Flight");
            btnAddFlight.UseVisualStyleBackColor = true;
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // btnDeleteFlight
            // 
            btnDeleteFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteFlight.FlatAppearance.BorderSize = 0;
            btnDeleteFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDeleteFlight.Image = (System.Drawing.Image)resources.GetObject("btnDeleteFlight.Image");
            btnDeleteFlight.Location = new System.Drawing.Point(65, 3);
            btnDeleteFlight.Name = "btnDeleteFlight";
            btnDeleteFlight.Size = new System.Drawing.Size(39, 42);
            btnDeleteFlight.TabIndex = 2;
            btnDeleteFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnDeleteFlight, "Delete Flight");
            btnDeleteFlight.UseVisualStyleBackColor = true;
            btnDeleteFlight.Click += btnDeleteFlight_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(44, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(15, 25);
            label1.TabIndex = 4;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(110, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(15, 25);
            label2.TabIndex = 5;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(172, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(13, 25);
            label3.TabIndex = 6;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(3, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(35, 42);
            btnClose.TabIndex = 3;
            btnClose.Tag = "Close";
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnClose, "Close");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(pPesonalUseAmount);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lblTotalFlight);
            panel1.Controls.Add(lblTaxesAndFees);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(txtTaxesAndFees);
            panel1.Controls.Add(txtTotalFlight);
            panel1.Location = new System.Drawing.Point(13, 255);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(668, 369);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32479F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.67522F));
            tableLayoutPanel3.Controls.Add(lblNotes, 0, 0);
            tableLayoutPanel3.Controls.Add(txtNotes, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(113, 288);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(468, 69);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(4, 28);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(46, 13);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(57, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(407, 60);
            txtNotes.TabIndex = 1;
            // 
            // pPesonalUseAmount
            // 
            pPesonalUseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pPesonalUseAmount.Controls.Add(txtPersonalUseAmount);
            pPesonalUseAmount.Controls.Add(lblPersonalUseAmount);
            pPesonalUseAmount.Enabled = false;
            pPesonalUseAmount.Location = new System.Drawing.Point(113, 253);
            pPesonalUseAmount.Name = "pPesonalUseAmount";
            pPesonalUseAmount.Size = new System.Drawing.Size(468, 29);
            pPesonalUseAmount.TabIndex = 3;
            // 
            // txtPersonalUseAmount
            // 
            txtPersonalUseAmount.Location = new System.Drawing.Point(367, 3);
            txtPersonalUseAmount.Name = "txtPersonalUseAmount";
            txtPersonalUseAmount.Size = new System.Drawing.Size(96, 20);
            txtPersonalUseAmount.TabIndex = 1;
            txtPersonalUseAmount.KeyPress += txtPersonalUseAmount_KeyPress;
            // 
            // lblPersonalUseAmount
            // 
            lblPersonalUseAmount.AutoSize = true;
            lblPersonalUseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPersonalUseAmount.Location = new System.Drawing.Point(12, 7);
            lblPersonalUseAmount.Name = "lblPersonalUseAmount";
            lblPersonalUseAmount.Size = new System.Drawing.Size(338, 13);
            lblPersonalUseAmount.TabIndex = 0;
            lblPersonalUseAmount.Text = "Please write the amount that you used for personal issues:";
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(rbNoPersonalUse);
            panel4.Controls.Add(rbYesPesonalUse);
            panel4.Controls.Add(lblPersonalUse);
            panel4.Location = new System.Drawing.Point(113, 218);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(468, 29);
            panel4.TabIndex = 2;
            // 
            // rbNoPersonalUse
            // 
            rbNoPersonalUse.AutoSize = true;
            rbNoPersonalUse.Location = new System.Drawing.Point(428, 6);
            rbNoPersonalUse.Name = "rbNoPersonalUse";
            rbNoPersonalUse.Size = new System.Drawing.Size(39, 17);
            rbNoPersonalUse.TabIndex = 2;
            rbNoPersonalUse.TabStop = true;
            rbNoPersonalUse.Text = "No";
            rbNoPersonalUse.UseVisualStyleBackColor = true;
            rbNoPersonalUse.CheckedChanged += rbNoPersonalUse_CheckedChanged;
            // 
            // rbYesPesonalUse
            // 
            rbYesPesonalUse.AutoSize = true;
            rbYesPesonalUse.Location = new System.Drawing.Point(368, 6);
            rbYesPesonalUse.Name = "rbYesPesonalUse";
            rbYesPesonalUse.Size = new System.Drawing.Size(43, 17);
            rbYesPesonalUse.TabIndex = 1;
            rbYesPesonalUse.TabStop = true;
            rbYesPesonalUse.Text = "Yes";
            rbYesPesonalUse.UseVisualStyleBackColor = true;
            rbYesPesonalUse.CheckedChanged += rbYesPesonalUse_CheckedChanged;
            // 
            // lblPersonalUse
            // 
            lblPersonalUse.AutoSize = true;
            lblPersonalUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPersonalUse.Location = new System.Drawing.Point(13, 8);
            lblPersonalUse.Name = "lblPersonalUse";
            lblPersonalUse.Size = new System.Drawing.Size(319, 13);
            lblPersonalUse.TabIndex = 0;
            lblPersonalUse.Text = "Did you use some part of the flight for personal issues?";
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(rbNoDistrictPay);
            panel3.Controls.Add(rbYesDistrictPay);
            panel3.Controls.Add(lblDistricPay);
            panel3.Location = new System.Drawing.Point(113, 181);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(468, 31);
            panel3.TabIndex = 1;
            // 
            // rbNoDistrictPay
            // 
            rbNoDistrictPay.AutoSize = true;
            rbNoDistrictPay.Location = new System.Drawing.Point(428, 8);
            rbNoDistrictPay.Name = "rbNoDistrictPay";
            rbNoDistrictPay.Size = new System.Drawing.Size(39, 17);
            rbNoDistrictPay.TabIndex = 2;
            rbNoDistrictPay.TabStop = true;
            rbNoDistrictPay.Text = "No";
            rbNoDistrictPay.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPay
            // 
            rbYesDistrictPay.AutoSize = true;
            rbYesDistrictPay.Location = new System.Drawing.Point(368, 8);
            rbYesDistrictPay.Name = "rbYesDistrictPay";
            rbYesDistrictPay.Size = new System.Drawing.Size(43, 17);
            rbYesDistrictPay.TabIndex = 1;
            rbYesDistrictPay.TabStop = true;
            rbYesDistrictPay.Text = "Yes";
            rbYesDistrictPay.UseVisualStyleBackColor = true;
            // 
            // lblDistricPay
            // 
            lblDistricPay.AutoSize = true;
            lblDistricPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistricPay.Location = new System.Drawing.Point(12, 8);
            lblDistricPay.Name = "lblDistricPay";
            lblDistricPay.Size = new System.Drawing.Size(200, 13);
            lblDistricPay.TabIndex = 0;
            lblDistricPay.Text = "Did the district pay for your flight?";
            // 
            // lblTotalFlight
            // 
            lblTotalFlight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalFlight.AutoSize = true;
            lblTotalFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalFlight.Location = new System.Drawing.Point(3, 34);
            lblTotalFlight.Name = "lblTotalFlight";
            lblTotalFlight.Size = new System.Drawing.Size(40, 13);
            lblTotalFlight.TabIndex = 5;
            lblTotalFlight.Text = "Total:";
            lblTotalFlight.Visible = false;
            // 
            // lblTaxesAndFees
            // 
            lblTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTaxesAndFees.AutoSize = true;
            lblTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTaxesAndFees.Location = new System.Drawing.Point(3, 10);
            lblTaxesAndFees.Name = "lblTaxesAndFees";
            lblTaxesAndFees.Size = new System.Drawing.Size(101, 13);
            lblTaxesAndFees.TabIndex = 4;
            lblTaxesAndFees.Text = "Taxes and Fees:";
            lblTaxesAndFees.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.24852F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.75148F));
            tableLayoutPanel2.Controls.Add(lblRoundTrip, 0, 0);
            tableLayoutPanel2.Controls.Add(lblDepartureDate, 0, 1);
            tableLayoutPanel2.Controls.Add(lblReturnDate, 0, 2);
            tableLayoutPanel2.Controls.Add(lblFlightCost, 0, 3);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpDepartureDate, 1, 1);
            tableLayoutPanel2.Controls.Add(dtpReturnDate, 1, 2);
            tableLayoutPanel2.Controls.Add(txtFlightCost, 1, 3);
            tableLayoutPanel2.Location = new System.Drawing.Point(174, 15);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(338, 152);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblRoundTrip
            // 
            lblRoundTrip.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblRoundTrip.AutoSize = true;
            lblRoundTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRoundTrip.Location = new System.Drawing.Point(4, 12);
            lblRoundTrip.Name = "lblRoundTrip";
            lblRoundTrip.Size = new System.Drawing.Size(102, 13);
            lblRoundTrip.TabIndex = 0;
            lblRoundTrip.Text = "Round Trip:";
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartureDate.AutoSize = true;
            lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDepartureDate.Location = new System.Drawing.Point(4, 49);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new System.Drawing.Size(102, 13);
            lblDepartureDate.TabIndex = 1;
            lblDepartureDate.Text = "Departure Date:";
            // 
            // lblReturnDate
            // 
            lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblReturnDate.Location = new System.Drawing.Point(4, 86);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new System.Drawing.Size(102, 13);
            lblReturnDate.TabIndex = 2;
            lblReturnDate.Text = "Return Date:";
            // 
            // lblFlightCost
            // 
            lblFlightCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFlightCost.AutoSize = true;
            lblFlightCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFlightCost.Location = new System.Drawing.Point(4, 125);
            lblFlightCost.Name = "lblFlightCost";
            lblFlightCost.Size = new System.Drawing.Size(102, 13);
            lblFlightCost.TabIndex = 3;
            lblFlightCost.Text = "Flight Cost:";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel2.Controls.Add(rbNoRoundTrip);
            panel2.Controls.Add(rbYesRoundTrip);
            panel2.Location = new System.Drawing.Point(113, 6);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(221, 26);
            panel2.TabIndex = 7;
            // 
            // rbNoRoundTrip
            // 
            rbNoRoundTrip.AutoSize = true;
            rbNoRoundTrip.Checked = true;
            rbNoRoundTrip.Location = new System.Drawing.Point(65, 3);
            rbNoRoundTrip.Name = "rbNoRoundTrip";
            rbNoRoundTrip.Size = new System.Drawing.Size(39, 17);
            rbNoRoundTrip.TabIndex = 1;
            rbNoRoundTrip.TabStop = true;
            rbNoRoundTrip.Text = "No";
            rbNoRoundTrip.UseVisualStyleBackColor = true;
            rbNoRoundTrip.CheckedChanged += rbNoRoundTrip_CheckedChanged;
            // 
            // rbYesRoundTrip
            // 
            rbYesRoundTrip.AutoSize = true;
            rbYesRoundTrip.Location = new System.Drawing.Point(15, 3);
            rbYesRoundTrip.Name = "rbYesRoundTrip";
            rbYesRoundTrip.Size = new System.Drawing.Size(43, 17);
            rbYesRoundTrip.TabIndex = 0;
            rbYesRoundTrip.Text = "Yes";
            rbYesRoundTrip.UseVisualStyleBackColor = true;
            rbYesRoundTrip.CheckedChanged += rbYesRoundTrip_CheckedChanged;
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDepartureDate.Location = new System.Drawing.Point(113, 46);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new System.Drawing.Size(221, 20);
            dtpDepartureDate.TabIndex = 8;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpReturnDate.Enabled = false;
            dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReturnDate.Location = new System.Drawing.Point(113, 83);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new System.Drawing.Size(221, 20);
            dtpReturnDate.TabIndex = 9;
            // 
            // txtFlightCost
            // 
            txtFlightCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFlightCost.Location = new System.Drawing.Point(113, 121);
            txtFlightCost.Name = "txtFlightCost";
            txtFlightCost.Size = new System.Drawing.Size(221, 20);
            txtFlightCost.TabIndex = 10;
            txtFlightCost.TextChanged += txtFlightCost_TextChanged;
            txtFlightCost.KeyPress += txtFlightCost_KeyPress;
            txtFlightCost.KeyUp += txtFlightCost_KeyUp;
            // 
            // txtTaxesAndFees
            // 
            txtTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTaxesAndFees.Location = new System.Drawing.Point(110, 7);
            txtTaxesAndFees.Name = "txtTaxesAndFees";
            txtTaxesAndFees.Size = new System.Drawing.Size(37, 20);
            txtTaxesAndFees.TabIndex = 11;
            txtTaxesAndFees.Text = "0";
            txtTaxesAndFees.Visible = false;
            txtTaxesAndFees.KeyPress += txtTaxesAndFees_KeyPress;
            txtTaxesAndFees.KeyUp += txtTaxesAndFees_KeyUp;
            // 
            // txtTotalFlight
            // 
            txtTotalFlight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTotalFlight.Location = new System.Drawing.Point(49, 31);
            txtTotalFlight.Name = "txtTotalFlight";
            txtTotalFlight.Size = new System.Drawing.Size(55, 20);
            txtTotalFlight.TabIndex = 12;
            txtTotalFlight.Visible = false;
            txtTotalFlight.KeyPress += txtTotalFlight_KeyPress;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(btnSaveFlight, 0, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(594, 628);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(82, 36);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnSaveFlight
            // 
            btnSaveFlight.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSaveFlight.FlatAppearance.BorderSize = 0;
            btnSaveFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSaveFlight.Image = (System.Drawing.Image)resources.GetObject("btnSaveFlight.Image");
            btnSaveFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaveFlight.Location = new System.Drawing.Point(4, 3);
            btnSaveFlight.Name = "btnSaveFlight";
            btnSaveFlight.Size = new System.Drawing.Size(75, 30);
            btnSaveFlight.TabIndex = 0;
            btnSaveFlight.Text = "Save";
            btnSaveFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSaveFlight.UseVisualStyleBackColor = true;
            btnSaveFlight.Click += btnSaveFlight_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelEdit.Image = (System.Drawing.Image)resources.GetObject("btnCancelEdit.Image");
            btnCancelEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelEdit.Location = new System.Drawing.Point(17, 629);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new System.Drawing.Size(87, 38);
            btnCancelEdit.TabIndex = 1;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 250;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new System.Drawing.Point(10, 37);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(22, 21);
            btnInfo.TabIndex = 5;
            toolTip1.SetToolTip(btnInfo, "Select a flight from the list and then click on the button option you want to perform");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // EditAirFare
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(671, 659);
            ControlBox = false;
            Controls.Add(btnInfo);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(btnCancelEdit);
            Controls.Add(panel1);
            Controls.Add(tlEditFlightButtons);
            Controls.Add(dgvEditAirfare);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "EditAirFare";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Airfare";
            Load += EditAirFare_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditAirfare).EndInit();
            tlEditFlightButtons.ResumeLayout(false);
            tlEditFlightButtons.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            pPesonalUseAmount.ResumeLayout(false);
            pPesonalUseAmount.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEditAirfare;
        private System.Windows.Forms.TableLayoutPanel tlEditFlightButtons;
        private System.Windows.Forms.Button btnEditFlight;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRoundTrip;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblFlightCost;
        private System.Windows.Forms.Label lblTaxesAndFees;
        private System.Windows.Forms.Label lblTotalFlight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNoRoundTrip;
        private System.Windows.Forms.RadioButton rbYesRoundTrip;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtFlightCost;
        private System.Windows.Forms.TextBox txtTaxesAndFees;
        private System.Windows.Forms.Panel pPesonalUseAmount;
        private System.Windows.Forms.TextBox txtPersonalUseAmount;
        private System.Windows.Forms.Label lblPersonalUseAmount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbNoPersonalUse;
        private System.Windows.Forms.RadioButton rbYesPesonalUse;
        private System.Windows.Forms.Label lblPersonalUse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbNoDistrictPay;
        private System.Windows.Forms.RadioButton rbYesDistrictPay;
        private System.Windows.Forms.Label lblDistricPay;
        private System.Windows.Forms.TextBox txtTotalFlight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSaveFlight;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAirfare;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirfareID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PersonalUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalUseAmount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}