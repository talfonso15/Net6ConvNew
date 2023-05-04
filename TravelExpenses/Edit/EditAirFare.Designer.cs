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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEditAirfare = new System.Windows.Forms.DataGridView();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TotalAirfare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirfareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalUseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlEditFlightButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditFlight = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pPesonalUseAmount = new System.Windows.Forms.Panel();
            this.txtPersonalUseAmount = new System.Windows.Forms.TextBox();
            this.lblPersonalUseAmount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbNoPersonalUse = new System.Windows.Forms.RadioButton();
            this.rbYesPesonalUse = new System.Windows.Forms.RadioButton();
            this.lblPersonalUse = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictPay = new System.Windows.Forms.RadioButton();
            this.lblDistricPay = new System.Windows.Forms.Label();
            this.lblTotalFlight = new System.Windows.Forms.Label();
            this.lblTaxesAndFees = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRoundTrip = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblFlightCost = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoRoundTrip = new System.Windows.Forms.RadioButton();
            this.rbYesRoundTrip = new System.Windows.Forms.RadioButton();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtFlightCost = new System.Windows.Forms.TextBox();
            this.txtTaxesAndFees = new System.Windows.Forms.TextBox();
            this.txtTotalFlight = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveFlight = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAirfare)).BeginInit();
            this.tlEditFlightButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pPesonalUseAmount.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEditAirfare
            // 
            this.dgvEditAirfare.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditAirfare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditAirfare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditAirfare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureDate,
            this.ReturnDate,
            this.FlightCost,
            this.TaxesAndFees,
            this.DistrictPay,
            this.TotalAirfare,
            this.AirfareID,
            this.Notes,
            this.PersonalUse,
            this.PersonalUseAmount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditAirfare.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEditAirfare.Location = new System.Drawing.Point(14, 61);
            this.dgvEditAirfare.Name = "dgvEditAirfare";
            this.dgvEditAirfare.ReadOnly = true;
            this.dgvEditAirfare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditAirfare.Size = new System.Drawing.Size(668, 139);
            this.dgvEditAirfare.TabIndex = 1;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure Date";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Width = 150;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 150;
            // 
            // FlightCost
            // 
            this.FlightCost.HeaderText = "Flight Cost";
            this.FlightCost.Name = "FlightCost";
            this.FlightCost.ReadOnly = true;
            this.FlightCost.Width = 150;
            // 
            // TaxesAndFees
            // 
            this.TaxesAndFees.HeaderText = "Taxes and Fees";
            this.TaxesAndFees.Name = "TaxesAndFees";
            this.TaxesAndFees.ReadOnly = true;
            this.TaxesAndFees.Visible = false;
            this.TaxesAndFees.Width = 110;
            // 
            // DistrictPay
            // 
            this.DistrictPay.HeaderText = "District Pay";
            this.DistrictPay.Name = "DistrictPay";
            this.DistrictPay.ReadOnly = true;
            this.DistrictPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DistrictPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DistrictPay.Width = 150;
            // 
            // TotalAirfare
            // 
            this.TotalAirfare.HeaderText = "Total Airfare";
            this.TotalAirfare.Name = "TotalAirfare";
            this.TotalAirfare.ReadOnly = true;
            this.TotalAirfare.Visible = false;
            // 
            // AirfareID
            // 
            this.AirfareID.HeaderText = "AirfareID";
            this.AirfareID.Name = "AirfareID";
            this.AirfareID.ReadOnly = true;
            this.AirfareID.Visible = false;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            // 
            // PersonalUse
            // 
            this.PersonalUse.HeaderText = "Personal Use";
            this.PersonalUse.Name = "PersonalUse";
            this.PersonalUse.ReadOnly = true;
            this.PersonalUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonalUse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PersonalUse.Visible = false;
            // 
            // PersonalUseAmount
            // 
            this.PersonalUseAmount.HeaderText = "Personal Use Amount";
            this.PersonalUseAmount.Name = "PersonalUseAmount";
            this.PersonalUseAmount.ReadOnly = true;
            this.PersonalUseAmount.Visible = false;
            // 
            // tlEditFlightButtons
            // 
            this.tlEditFlightButtons.ColumnCount = 7;
            this.tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23299F));
            this.tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.68935F));
            this.tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23299F));
            this.tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.68935F));
            this.tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23299F));
            this.tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.68935F));
            this.tlEditFlightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23299F));
            this.tlEditFlightButtons.Controls.Add(this.btnEditFlight, 6, 0);
            this.tlEditFlightButtons.Controls.Add(this.btnAddFlight, 4, 0);
            this.tlEditFlightButtons.Controls.Add(this.btnDeleteFlight, 2, 0);
            this.tlEditFlightButtons.Controls.Add(this.label1, 1, 0);
            this.tlEditFlightButtons.Controls.Add(this.label2, 3, 0);
            this.tlEditFlightButtons.Controls.Add(this.label3, 5, 0);
            this.tlEditFlightButtons.Controls.Add(this.btnClose, 0, 0);
            this.tlEditFlightButtons.Location = new System.Drawing.Point(420, 7);
            this.tlEditFlightButtons.Name = "tlEditFlightButtons";
            this.tlEditFlightButtons.RowCount = 1;
            this.tlEditFlightButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEditFlightButtons.Size = new System.Drawing.Size(258, 48);
            this.tlEditFlightButtons.TabIndex = 2;
            // 
            // btnEditFlight
            // 
            this.btnEditFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditFlight.FlatAppearance.BorderSize = 0;
            this.btnEditFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFlight.Image = global::TravelExpenses.Properties.Resources.if_General_Office_09_2530835;
            this.btnEditFlight.Location = new System.Drawing.Point(214, 3);
            this.btnEditFlight.Name = "btnEditFlight";
            this.btnEditFlight.Size = new System.Drawing.Size(34, 42);
            this.btnEditFlight.TabIndex = 0;
            this.btnEditFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditFlight, "Edit Flight");
            this.btnEditFlight.UseVisualStyleBackColor = true;
            this.btnEditFlight.Click += new System.EventHandler(this.btnEditFlight_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFlight.FlatAppearance.BorderSize = 0;
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Image = global::TravelExpenses.Properties.Resources.if_add1__32378__1_;
            this.btnAddFlight.Location = new System.Drawing.Point(141, 3);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(39, 42);
            this.btnAddFlight.TabIndex = 1;
            this.btnAddFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddFlight, "Add Flight");
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteFlight.FlatAppearance.BorderSize = 0;
            this.btnDeleteFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.Image = global::TravelExpenses.Properties.Resources.if_edit_delete_118920;
            this.btnDeleteFlight.Location = new System.Drawing.Point(72, 3);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(40, 42);
            this.btnDeleteFlight.TabIndex = 2;
            this.btnDeleteFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteFlight, "Delete Flight");
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::TravelExpenses.Properties.Resources.if_Shutdown_Box_Red_34246;
            this.btnClose.Location = new System.Drawing.Point(4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Tag = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.pPesonalUseAmount);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTotalFlight);
            this.panel1.Controls.Add(this.lblTaxesAndFees);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.txtTaxesAndFees);
            this.panel1.Controls.Add(this.txtTotalFlight);
            this.panel1.Location = new System.Drawing.Point(13, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 369);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32479F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.67522F));
            this.tableLayoutPanel3.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(113, 288);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(468, 69);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(4, 28);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(57, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(407, 60);
            this.txtNotes.TabIndex = 1;
            // 
            // pPesonalUseAmount
            // 
            this.pPesonalUseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPesonalUseAmount.Controls.Add(this.txtPersonalUseAmount);
            this.pPesonalUseAmount.Controls.Add(this.lblPersonalUseAmount);
            this.pPesonalUseAmount.Enabled = false;
            this.pPesonalUseAmount.Location = new System.Drawing.Point(113, 253);
            this.pPesonalUseAmount.Name = "pPesonalUseAmount";
            this.pPesonalUseAmount.Size = new System.Drawing.Size(468, 29);
            this.pPesonalUseAmount.TabIndex = 3;
            // 
            // txtPersonalUseAmount
            // 
            this.txtPersonalUseAmount.Location = new System.Drawing.Point(367, 3);
            this.txtPersonalUseAmount.Name = "txtPersonalUseAmount";
            this.txtPersonalUseAmount.Size = new System.Drawing.Size(96, 20);
            this.txtPersonalUseAmount.TabIndex = 1;
            this.txtPersonalUseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonalUseAmount_KeyPress);
            // 
            // lblPersonalUseAmount
            // 
            this.lblPersonalUseAmount.AutoSize = true;
            this.lblPersonalUseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalUseAmount.Location = new System.Drawing.Point(12, 7);
            this.lblPersonalUseAmount.Name = "lblPersonalUseAmount";
            this.lblPersonalUseAmount.Size = new System.Drawing.Size(338, 13);
            this.lblPersonalUseAmount.TabIndex = 0;
            this.lblPersonalUseAmount.Text = "Please write the amount that you used for personal issues:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rbNoPersonalUse);
            this.panel4.Controls.Add(this.rbYesPesonalUse);
            this.panel4.Controls.Add(this.lblPersonalUse);
            this.panel4.Location = new System.Drawing.Point(113, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 29);
            this.panel4.TabIndex = 2;
            // 
            // rbNoPersonalUse
            // 
            this.rbNoPersonalUse.AutoSize = true;
            this.rbNoPersonalUse.Location = new System.Drawing.Point(428, 6);
            this.rbNoPersonalUse.Name = "rbNoPersonalUse";
            this.rbNoPersonalUse.Size = new System.Drawing.Size(39, 17);
            this.rbNoPersonalUse.TabIndex = 2;
            this.rbNoPersonalUse.TabStop = true;
            this.rbNoPersonalUse.Text = "No";
            this.rbNoPersonalUse.UseVisualStyleBackColor = true;
            this.rbNoPersonalUse.CheckedChanged += new System.EventHandler(this.rbNoPersonalUse_CheckedChanged);
            // 
            // rbYesPesonalUse
            // 
            this.rbYesPesonalUse.AutoSize = true;
            this.rbYesPesonalUse.Location = new System.Drawing.Point(368, 6);
            this.rbYesPesonalUse.Name = "rbYesPesonalUse";
            this.rbYesPesonalUse.Size = new System.Drawing.Size(43, 17);
            this.rbYesPesonalUse.TabIndex = 1;
            this.rbYesPesonalUse.TabStop = true;
            this.rbYesPesonalUse.Text = "Yes";
            this.rbYesPesonalUse.UseVisualStyleBackColor = true;
            this.rbYesPesonalUse.CheckedChanged += new System.EventHandler(this.rbYesPesonalUse_CheckedChanged);
            // 
            // lblPersonalUse
            // 
            this.lblPersonalUse.AutoSize = true;
            this.lblPersonalUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalUse.Location = new System.Drawing.Point(13, 8);
            this.lblPersonalUse.Name = "lblPersonalUse";
            this.lblPersonalUse.Size = new System.Drawing.Size(319, 13);
            this.lblPersonalUse.TabIndex = 0;
            this.lblPersonalUse.Text = "Did you use some part of the flight for personal issues?";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbNoDistrictPay);
            this.panel3.Controls.Add(this.rbYesDistrictPay);
            this.panel3.Controls.Add(this.lblDistricPay);
            this.panel3.Location = new System.Drawing.Point(113, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 31);
            this.panel3.TabIndex = 1;
            // 
            // rbNoDistrictPay
            // 
            this.rbNoDistrictPay.AutoSize = true;
            this.rbNoDistrictPay.Location = new System.Drawing.Point(428, 8);
            this.rbNoDistrictPay.Name = "rbNoDistrictPay";
            this.rbNoDistrictPay.Size = new System.Drawing.Size(39, 17);
            this.rbNoDistrictPay.TabIndex = 2;
            this.rbNoDistrictPay.TabStop = true;
            this.rbNoDistrictPay.Text = "No";
            this.rbNoDistrictPay.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPay
            // 
            this.rbYesDistrictPay.AutoSize = true;
            this.rbYesDistrictPay.Location = new System.Drawing.Point(368, 8);
            this.rbYesDistrictPay.Name = "rbYesDistrictPay";
            this.rbYesDistrictPay.Size = new System.Drawing.Size(43, 17);
            this.rbYesDistrictPay.TabIndex = 1;
            this.rbYesDistrictPay.TabStop = true;
            this.rbYesDistrictPay.Text = "Yes";
            this.rbYesDistrictPay.UseVisualStyleBackColor = true;
            // 
            // lblDistricPay
            // 
            this.lblDistricPay.AutoSize = true;
            this.lblDistricPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistricPay.Location = new System.Drawing.Point(12, 8);
            this.lblDistricPay.Name = "lblDistricPay";
            this.lblDistricPay.Size = new System.Drawing.Size(200, 13);
            this.lblDistricPay.TabIndex = 0;
            this.lblDistricPay.Text = "Did the district pay for your flight?";
            // 
            // lblTotalFlight
            // 
            this.lblTotalFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFlight.AutoSize = true;
            this.lblTotalFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFlight.Location = new System.Drawing.Point(3, 34);
            this.lblTotalFlight.Name = "lblTotalFlight";
            this.lblTotalFlight.Size = new System.Drawing.Size(40, 13);
            this.lblTotalFlight.TabIndex = 5;
            this.lblTotalFlight.Text = "Total:";
            this.lblTotalFlight.Visible = false;
            // 
            // lblTaxesAndFees
            // 
            this.lblTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesAndFees.AutoSize = true;
            this.lblTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxesAndFees.Location = new System.Drawing.Point(3, 10);
            this.lblTaxesAndFees.Name = "lblTaxesAndFees";
            this.lblTaxesAndFees.Size = new System.Drawing.Size(101, 13);
            this.lblTaxesAndFees.TabIndex = 4;
            this.lblTaxesAndFees.Text = "Taxes and Fees:";
            this.lblTaxesAndFees.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.24852F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.75148F));
            this.tableLayoutPanel2.Controls.Add(this.lblRoundTrip, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDepartureDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblReturnDate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFlightCost, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpDepartureDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpReturnDate, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtFlightCost, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(174, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(338, 152);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblRoundTrip
            // 
            this.lblRoundTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoundTrip.AutoSize = true;
            this.lblRoundTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundTrip.Location = new System.Drawing.Point(4, 12);
            this.lblRoundTrip.Name = "lblRoundTrip";
            this.lblRoundTrip.Size = new System.Drawing.Size(102, 13);
            this.lblRoundTrip.TabIndex = 0;
            this.lblRoundTrip.Text = "Round Trip:";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(4, 49);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(102, 13);
            this.lblDepartureDate.TabIndex = 1;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(4, 86);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(102, 13);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblFlightCost
            // 
            this.lblFlightCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightCost.AutoSize = true;
            this.lblFlightCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightCost.Location = new System.Drawing.Point(4, 125);
            this.lblFlightCost.Name = "lblFlightCost";
            this.lblFlightCost.Size = new System.Drawing.Size(102, 13);
            this.lblFlightCost.TabIndex = 3;
            this.lblFlightCost.Text = "Flight Cost:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.rbNoRoundTrip);
            this.panel2.Controls.Add(this.rbYesRoundTrip);
            this.panel2.Location = new System.Drawing.Point(113, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 26);
            this.panel2.TabIndex = 7;
            // 
            // rbNoRoundTrip
            // 
            this.rbNoRoundTrip.AutoSize = true;
            this.rbNoRoundTrip.Checked = true;
            this.rbNoRoundTrip.Location = new System.Drawing.Point(65, 3);
            this.rbNoRoundTrip.Name = "rbNoRoundTrip";
            this.rbNoRoundTrip.Size = new System.Drawing.Size(39, 17);
            this.rbNoRoundTrip.TabIndex = 1;
            this.rbNoRoundTrip.TabStop = true;
            this.rbNoRoundTrip.Text = "No";
            this.rbNoRoundTrip.UseVisualStyleBackColor = true;
            this.rbNoRoundTrip.CheckedChanged += new System.EventHandler(this.rbNoRoundTrip_CheckedChanged);
            // 
            // rbYesRoundTrip
            // 
            this.rbYesRoundTrip.AutoSize = true;
            this.rbYesRoundTrip.Location = new System.Drawing.Point(15, 3);
            this.rbYesRoundTrip.Name = "rbYesRoundTrip";
            this.rbYesRoundTrip.Size = new System.Drawing.Size(43, 17);
            this.rbYesRoundTrip.TabIndex = 0;
            this.rbYesRoundTrip.Text = "Yes";
            this.rbYesRoundTrip.UseVisualStyleBackColor = true;
            this.rbYesRoundTrip.CheckedChanged += new System.EventHandler(this.rbYesRoundTrip_CheckedChanged);
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(113, 46);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(221, 20);
            this.dtpDepartureDate.TabIndex = 8;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(113, 83);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(221, 20);
            this.dtpReturnDate.TabIndex = 9;
            // 
            // txtFlightCost
            // 
            this.txtFlightCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlightCost.Location = new System.Drawing.Point(113, 121);
            this.txtFlightCost.Name = "txtFlightCost";
            this.txtFlightCost.Size = new System.Drawing.Size(221, 20);
            this.txtFlightCost.TabIndex = 10;
            this.txtFlightCost.TextChanged += new System.EventHandler(this.txtFlightCost_TextChanged);
            this.txtFlightCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightCost_KeyPress);
            this.txtFlightCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFlightCost_KeyUp);
            // 
            // txtTaxesAndFees
            // 
            this.txtTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxesAndFees.Location = new System.Drawing.Point(110, 7);
            this.txtTaxesAndFees.Name = "txtTaxesAndFees";
            this.txtTaxesAndFees.Size = new System.Drawing.Size(37, 20);
            this.txtTaxesAndFees.TabIndex = 11;
            this.txtTaxesAndFees.Text = "0";
            this.txtTaxesAndFees.Visible = false;
            this.txtTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxesAndFees_KeyPress);
            this.txtTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaxesAndFees_KeyUp);
            // 
            // txtTotalFlight
            // 
            this.txtTotalFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFlight.Location = new System.Drawing.Point(49, 31);
            this.txtTotalFlight.Name = "txtTotalFlight";
            this.txtTotalFlight.Size = new System.Drawing.Size(55, 20);
            this.txtTotalFlight.TabIndex = 12;
            this.txtTotalFlight.Visible = false;
            this.txtTotalFlight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalFlight_KeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnSaveFlight, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(600, 632);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(82, 42);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnSaveFlight
            // 
            this.btnSaveFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFlight.FlatAppearance.BorderSize = 0;
            this.btnSaveFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFlight.Image = global::TravelExpenses.Properties.Resources._1495047519_Save;
            this.btnSaveFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFlight.Location = new System.Drawing.Point(4, 3);
            this.btnSaveFlight.Name = "btnSaveFlight";
            this.btnSaveFlight.Size = new System.Drawing.Size(75, 36);
            this.btnSaveFlight.TabIndex = 0;
            this.btnSaveFlight.Text = "Save";
            this.btnSaveFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveFlight.UseVisualStyleBackColor = true;
            this.btnSaveFlight.Click += new System.EventHandler(this.btnSaveFlight_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelEdit.Location = new System.Drawing.Point(17, 637);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(87, 38);
            this.btnCancelEdit.TabIndex = 1;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(10, 37);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(22, 21);
            this.btnInfo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnInfo, "Select a flight from the list and then click on the button option you want to per" +
        "form");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditAirFare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 675);
            this.ControlBox = false;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlEditFlightButtons);
            this.Controls.Add(this.dgvEditAirfare);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditAirFare";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Airfare";
            this.Load += new System.EventHandler(this.EditAirFare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAirfare)).EndInit();
            this.tlEditFlightButtons.ResumeLayout(false);
            this.tlEditFlightButtons.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pPesonalUseAmount.ResumeLayout(false);
            this.pPesonalUseAmount.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

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