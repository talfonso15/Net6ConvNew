namespace TravelExpenses
{
    partial class EditCarRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEditCar = new System.Windows.Forms.DataGridView();
            this.PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarCostperDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDWInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplementalInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraInsurance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExtraInsuranceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalIssues = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalIssuesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarRentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlEditButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelEditCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.pCarData = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pPersonalIssuesAmount = new System.Windows.Forms.Panel();
            this.txtPersonalUseAmount = new System.Windows.Forms.TextBox();
            this.lblPersonalIssuesAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoPersonalIssues = new System.Windows.Forms.RadioButton();
            this.rbYesPeronalIssues = new System.Windows.Forms.RadioButton();
            this.lblPesonalIssues = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictPay = new System.Windows.Forms.RadioButton();
            this.lblDistrictPay = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPickUpDate = new System.Windows.Forms.Label();
            this.lblDropOffDate = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblRentalCompany = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblCarCost = new System.Windows.Forms.Label();
            this.dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDropOffDate = new System.Windows.Forms.DateTimePicker();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.cbRentalCompany = new System.Windows.Forms.ComboBox();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.txtCarCost = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalCar = new System.Windows.Forms.TextBox();
            this.lblTaxesAndFees = new System.Windows.Forms.Label();
            this.txtExtraInsuranceAmount = new System.Windows.Forms.TextBox();
            this.lblExtraInsuranceAmount = new System.Windows.Forms.Label();
            this.chxExtraInsurance = new System.Windows.Forms.CheckBox();
            this.lblExtraInsurance = new System.Windows.Forms.Label();
            this.txtTaxesAndFees = new System.Windows.Forms.TextBox();
            this.txtSupplementalInsurance = new System.Windows.Forms.TextBox();
            this.lblSupplementalInsurance = new System.Windows.Forms.Label();
            this.lblLDWInsurance = new System.Windows.Forms.Label();
            this.txtLDWInsurance = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCar)).BeginInit();
            this.tlEditButtons.SuspendLayout();
            this.pCarData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pPersonalIssuesAmount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEditCar
            // 
            this.dgvEditCar.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEditCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PickUpDate,
            this.DropOffDate,
            this.CarCostperDay,
            this.DistrictPay,
            this.Total,
            this.CarType,
            this.RentalCompany,
            this.Days,
            this.TaxesAndFees,
            this.LDWInsurance,
            this.SupplementalInsurance,
            this.ExtraInsurance,
            this.ExtraInsuranceAmount,
            this.PersonalIssues,
            this.PersonalIssuesAmount,
            this.CarRentalID,
            this.Notes});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditCar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEditCar.Location = new System.Drawing.Point(26, 56);
            this.dgvEditCar.Name = "dgvEditCar";
            this.dgvEditCar.ReadOnly = true;
            this.dgvEditCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditCar.Size = new System.Drawing.Size(614, 105);
            this.dgvEditCar.TabIndex = 0;
            this.dgvEditCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditCar_CellContentClick);
            // 
            // PickUpDate
            // 
            this.PickUpDate.HeaderText = "Pick Up Date";
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.ReadOnly = true;
            this.PickUpDate.Width = 110;
            // 
            // DropOffDate
            // 
            this.DropOffDate.HeaderText = "Drop Off Date";
            this.DropOffDate.Name = "DropOffDate";
            this.DropOffDate.ReadOnly = true;
            this.DropOffDate.Width = 110;
            // 
            // CarCostperDay
            // 
            this.CarCostperDay.HeaderText = "Car Cost per Day";
            this.CarCostperDay.Name = "CarCostperDay";
            this.CarCostperDay.ReadOnly = true;
            this.CarCostperDay.Width = 150;
            // 
            // DistrictPay
            // 
            this.DistrictPay.HeaderText = "District Pay";
            this.DistrictPay.Name = "DistrictPay";
            this.DistrictPay.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Car Type";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            this.CarType.Visible = false;
            // 
            // RentalCompany
            // 
            this.RentalCompany.HeaderText = "Rental Company";
            this.RentalCompany.Name = "RentalCompany";
            this.RentalCompany.ReadOnly = true;
            this.RentalCompany.Visible = false;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.Visible = false;
            // 
            // TaxesAndFees
            // 
            this.TaxesAndFees.HeaderText = "Taxes And Fees";
            this.TaxesAndFees.Name = "TaxesAndFees";
            this.TaxesAndFees.ReadOnly = true;
            this.TaxesAndFees.Visible = false;
            // 
            // LDWInsurance
            // 
            this.LDWInsurance.HeaderText = "LDW Insurance";
            this.LDWInsurance.Name = "LDWInsurance";
            this.LDWInsurance.ReadOnly = true;
            this.LDWInsurance.Visible = false;
            // 
            // SupplementalInsurance
            // 
            this.SupplementalInsurance.HeaderText = "Supplemental Insurance";
            this.SupplementalInsurance.Name = "SupplementalInsurance";
            this.SupplementalInsurance.ReadOnly = true;
            this.SupplementalInsurance.Visible = false;
            // 
            // ExtraInsurance
            // 
            this.ExtraInsurance.HeaderText = "Extra Insurance";
            this.ExtraInsurance.Name = "ExtraInsurance";
            this.ExtraInsurance.ReadOnly = true;
            this.ExtraInsurance.Visible = false;
            // 
            // ExtraInsuranceAmount
            // 
            this.ExtraInsuranceAmount.HeaderText = "Extra Insurance Amount";
            this.ExtraInsuranceAmount.Name = "ExtraInsuranceAmount";
            this.ExtraInsuranceAmount.ReadOnly = true;
            this.ExtraInsuranceAmount.Visible = false;
            // 
            // PersonalIssues
            // 
            this.PersonalIssues.HeaderText = "Personal Issues";
            this.PersonalIssues.Name = "PersonalIssues";
            this.PersonalIssues.ReadOnly = true;
            this.PersonalIssues.Visible = false;
            // 
            // PersonalIssuesAmount
            // 
            this.PersonalIssuesAmount.HeaderText = "Personal Issues Amount";
            this.PersonalIssuesAmount.Name = "PersonalIssuesAmount";
            this.PersonalIssuesAmount.ReadOnly = true;
            this.PersonalIssuesAmount.Visible = false;
            // 
            // CarRentalID
            // 
            this.CarRentalID.HeaderText = "CarRentalID";
            this.CarRentalID.Name = "CarRentalID";
            this.CarRentalID.ReadOnly = true;
            this.CarRentalID.Visible = false;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            // 
            // tlEditButtons
            // 
            this.tlEditButtons.ColumnCount = 7;
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33834F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33083F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.54135F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlEditButtons.Controls.Add(this.btnAddCar, 4, 0);
            this.tlEditButtons.Controls.Add(this.btnDeleteCar, 2, 0);
            this.tlEditButtons.Controls.Add(this.label1, 1, 0);
            this.tlEditButtons.Controls.Add(this.label2, 3, 0);
            this.tlEditButtons.Controls.Add(this.label3, 5, 0);
            this.tlEditButtons.Controls.Add(this.btnCancelEditCar, 0, 0);
            this.tlEditButtons.Controls.Add(this.btnEditCar, 6, 0);
            this.tlEditButtons.Location = new System.Drawing.Point(405, 4);
            this.tlEditButtons.Name = "tlEditButtons";
            this.tlEditButtons.RowCount = 1;
            this.tlEditButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEditButtons.Size = new System.Drawing.Size(245, 48);
            this.tlEditButtons.TabIndex = 2;
            this.tlEditButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tlEditButtons_Paint);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCar.FlatAppearance.BorderSize = 0;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Image = global::TravelExpenses.Properties.Resources.if_add1__32378__1_;
            this.btnAddCar.Location = new System.Drawing.Point(124, 5);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(32, 38);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCar.FlatAppearance.BorderSize = 0;
            this.btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Image = global::TravelExpenses.Properties.Resources.if_edit_delete_118920;
            this.btnDeleteCar.Location = new System.Drawing.Point(66, 5);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(29, 38);
            this.btnDeleteCar.TabIndex = 2;
            this.btnDeleteCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 11);
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
            this.label2.Location = new System.Drawing.Point(103, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelEditCar
            // 
            this.btnCancelEditCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelEditCar.FlatAppearance.BorderSize = 0;
            this.btnCancelEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditCar.Image = global::TravelExpenses.Properties.Resources.if_Shutdown_Box_Red_34246;
            this.btnCancelEditCar.Location = new System.Drawing.Point(5, 5);
            this.btnCancelEditCar.Name = "btnCancelEditCar";
            this.btnCancelEditCar.Size = new System.Drawing.Size(32, 38);
            this.btnCancelEditCar.TabIndex = 3;
            this.btnCancelEditCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelEditCar.UseVisualStyleBackColor = true;
            this.btnCancelEditCar.Click += new System.EventHandler(this.btnCancelEditCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCar.FlatAppearance.BorderSize = 0;
            this.btnEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Image = global::TravelExpenses.Properties.Resources.if_General_Office_09_2530835;
            this.btnEditCar.Location = new System.Drawing.Point(193, 5);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(42, 38);
            this.btnEditCar.TabIndex = 0;
            this.btnEditCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // pCarData
            // 
            this.pCarData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCarData.Controls.Add(this.tableLayoutPanel3);
            this.pCarData.Controls.Add(this.pPersonalIssuesAmount);
            this.pCarData.Controls.Add(this.panel2);
            this.pCarData.Controls.Add(this.panel1);
            this.pCarData.Controls.Add(this.tableLayoutPanel2);
            this.pCarData.Controls.Add(this.lblTaxesAndFees);
            this.pCarData.Controls.Add(this.txtExtraInsuranceAmount);
            this.pCarData.Controls.Add(this.lblExtraInsuranceAmount);
            this.pCarData.Controls.Add(this.chxExtraInsurance);
            this.pCarData.Controls.Add(this.lblExtraInsurance);
            this.pCarData.Controls.Add(this.txtTaxesAndFees);
            this.pCarData.Controls.Add(this.txtSupplementalInsurance);
            this.pCarData.Controls.Add(this.lblSupplementalInsurance);
            this.pCarData.Controls.Add(this.lblLDWInsurance);
            this.pCarData.Controls.Add(this.txtLDWInsurance);
            this.pCarData.Location = new System.Drawing.Point(26, 185);
            this.pCarData.Name = "pCarData";
            this.pCarData.Size = new System.Drawing.Size(614, 456);
            this.pCarData.TabIndex = 3;
            this.pCarData.Paint += new System.Windows.Forms.PaintEventHandler(this.pCarData_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32076F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.67924F));
            this.tableLayoutPanel3.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(69, 383);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 39);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(4, 13);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(47, 13);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(58, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(415, 31);
            this.txtNotes.TabIndex = 1;
            // 
            // pPersonalIssuesAmount
            // 
            this.pPersonalIssuesAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPersonalIssuesAmount.Controls.Add(this.txtPersonalUseAmount);
            this.pPersonalIssuesAmount.Controls.Add(this.lblPersonalIssuesAmount);
            this.pPersonalIssuesAmount.Enabled = false;
            this.pPersonalIssuesAmount.Location = new System.Drawing.Point(69, 352);
            this.pPersonalIssuesAmount.Name = "pPersonalIssuesAmount";
            this.pPersonalIssuesAmount.Size = new System.Drawing.Size(477, 28);
            this.pPersonalIssuesAmount.TabIndex = 3;
            // 
            // txtPersonalUseAmount
            // 
            this.txtPersonalUseAmount.Location = new System.Drawing.Point(376, 3);
            this.txtPersonalUseAmount.Name = "txtPersonalUseAmount";
            this.txtPersonalUseAmount.Size = new System.Drawing.Size(88, 20);
            this.txtPersonalUseAmount.TabIndex = 1;
            this.txtPersonalUseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonalUseAmount_KeyPress);
            // 
            // lblPersonalIssuesAmount
            // 
            this.lblPersonalIssuesAmount.AutoSize = true;
            this.lblPersonalIssuesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalIssuesAmount.Location = new System.Drawing.Point(6, 7);
            this.lblPersonalIssuesAmount.Name = "lblPersonalIssuesAmount";
            this.lblPersonalIssuesAmount.Size = new System.Drawing.Size(353, 13);
            this.lblPersonalIssuesAmount.TabIndex = 0;
            this.lblPersonalIssuesAmount.Text = "Please provide the amount that you used for personal issues:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbNoPersonalIssues);
            this.panel2.Controls.Add(this.rbYesPeronalIssues);
            this.panel2.Controls.Add(this.lblPesonalIssues);
            this.panel2.Location = new System.Drawing.Point(69, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 27);
            this.panel2.TabIndex = 2;
            // 
            // rbNoPersonalIssues
            // 
            this.rbNoPersonalIssues.AutoSize = true;
            this.rbNoPersonalIssues.Location = new System.Drawing.Point(429, 4);
            this.rbNoPersonalIssues.Name = "rbNoPersonalIssues";
            this.rbNoPersonalIssues.Size = new System.Drawing.Size(39, 17);
            this.rbNoPersonalIssues.TabIndex = 2;
            this.rbNoPersonalIssues.TabStop = true;
            this.rbNoPersonalIssues.Text = "No";
            this.rbNoPersonalIssues.UseVisualStyleBackColor = true;
            this.rbNoPersonalIssues.CheckedChanged += new System.EventHandler(this.rbNoPersonalIssues_CheckedChanged);
            // 
            // rbYesPeronalIssues
            // 
            this.rbYesPeronalIssues.AutoSize = true;
            this.rbYesPeronalIssues.Location = new System.Drawing.Point(376, 4);
            this.rbYesPeronalIssues.Name = "rbYesPeronalIssues";
            this.rbYesPeronalIssues.Size = new System.Drawing.Size(43, 17);
            this.rbYesPeronalIssues.TabIndex = 1;
            this.rbYesPeronalIssues.TabStop = true;
            this.rbYesPeronalIssues.Text = "Yes";
            this.rbYesPeronalIssues.UseVisualStyleBackColor = true;
            this.rbYesPeronalIssues.CheckedChanged += new System.EventHandler(this.rbYesPeronalIssues_CheckedChanged);
            // 
            // lblPesonalIssues
            // 
            this.lblPesonalIssues.AutoSize = true;
            this.lblPesonalIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesonalIssues.Location = new System.Drawing.Point(6, 7);
            this.lblPesonalIssues.Name = "lblPesonalIssues";
            this.lblPesonalIssues.Size = new System.Drawing.Size(310, 13);
            this.lblPesonalIssues.TabIndex = 0;
            this.lblPesonalIssues.Text = "Did you use any of the car rental for personal issues?";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbNoDistrictPay);
            this.panel1.Controls.Add(this.rbYesDistrictPay);
            this.panel1.Controls.Add(this.lblDistrictPay);
            this.panel1.Location = new System.Drawing.Point(69, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 26);
            this.panel1.TabIndex = 1;
            // 
            // rbNoDistrictPay
            // 
            this.rbNoDistrictPay.AutoSize = true;
            this.rbNoDistrictPay.Location = new System.Drawing.Point(429, 4);
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
            this.rbYesDistrictPay.Location = new System.Drawing.Point(376, 3);
            this.rbYesDistrictPay.Name = "rbYesDistrictPay";
            this.rbYesDistrictPay.Size = new System.Drawing.Size(43, 17);
            this.rbYesDistrictPay.TabIndex = 1;
            this.rbYesDistrictPay.TabStop = true;
            this.rbYesDistrictPay.Text = "Yes";
            this.rbYesDistrictPay.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPay
            // 
            this.lblDistrictPay.AutoSize = true;
            this.lblDistrictPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictPay.Location = new System.Drawing.Point(6, 6);
            this.lblDistrictPay.Name = "lblDistrictPay";
            this.lblDistrictPay.Size = new System.Drawing.Size(226, 13);
            this.lblDistrictPay.TabIndex = 0;
            this.lblDistrictPay.Text = "Did the district pay for your car rental?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34837F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65163F));
            this.tableLayoutPanel2.Controls.Add(this.lblPickUpDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDropOffDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCarType, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblRentalCompany, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDays, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblCarCost, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.dtpPickUpDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpDropOffDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbCarType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbRentalCompany, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.nudDays, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtCarCost, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblTotal, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalCar, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(112, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(399, 239);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUpDate.Location = new System.Drawing.Point(4, 10);
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(149, 13);
            this.lblPickUpDate.TabIndex = 0;
            this.lblPickUpDate.Text = "Pick Up Date:";
            // 
            // lblDropOffDate
            // 
            this.lblDropOffDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDropOffDate.AutoSize = true;
            this.lblDropOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropOffDate.Location = new System.Drawing.Point(4, 44);
            this.lblDropOffDate.Name = "lblDropOffDate";
            this.lblDropOffDate.Size = new System.Drawing.Size(149, 13);
            this.lblDropOffDate.TabIndex = 1;
            this.lblDropOffDate.Text = "Drop Off Date:";
            // 
            // lblCarType
            // 
            this.lblCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarType.Location = new System.Drawing.Point(4, 78);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(149, 13);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Car Type:";
            // 
            // lblRentalCompany
            // 
            this.lblRentalCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRentalCompany.AutoSize = true;
            this.lblRentalCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalCompany.Location = new System.Drawing.Point(4, 112);
            this.lblRentalCompany.Name = "lblRentalCompany";
            this.lblRentalCompany.Size = new System.Drawing.Size(149, 13);
            this.lblRentalCompany.TabIndex = 3;
            this.lblRentalCompany.Text = "Rental Company:";
            // 
            // lblDays
            // 
            this.lblDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(4, 146);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(149, 13);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Days:";
            // 
            // lblCarCost
            // 
            this.lblCarCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarCost.AutoSize = true;
            this.lblCarCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCost.Location = new System.Drawing.Point(4, 180);
            this.lblCarCost.Name = "lblCarCost";
            this.lblCarCost.Size = new System.Drawing.Size(149, 13);
            this.lblCarCost.TabIndex = 5;
            this.lblCarCost.Text = "Car Cost:";
            // 
            // dtpPickUpDate
            // 
            this.dtpPickUpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPickUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPickUpDate.Location = new System.Drawing.Point(160, 7);
            this.dtpPickUpDate.Name = "dtpPickUpDate";
            this.dtpPickUpDate.Size = new System.Drawing.Size(235, 20);
            this.dtpPickUpDate.TabIndex = 12;
            this.dtpPickUpDate.ValueChanged += new System.EventHandler(this.dtpPickUpDate_ValueChanged);
            // 
            // dtpDropOffDate
            // 
            this.dtpDropOffDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDropOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDropOffDate.Location = new System.Drawing.Point(160, 40);
            this.dtpDropOffDate.Name = "dtpDropOffDate";
            this.dtpDropOffDate.Size = new System.Drawing.Size(235, 20);
            this.dtpDropOffDate.TabIndex = 13;
            this.dtpDropOffDate.ValueChanged += new System.EventHandler(this.dtpDropOffDate_ValueChanged);
            // 
            // cbCarType
            // 
            this.cbCarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Items.AddRange(new object[] {
            "compact",
            "mid-size"});
            this.cbCarType.Location = new System.Drawing.Point(160, 74);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(235, 21);
            this.cbCarType.TabIndex = 14;
            // 
            // cbRentalCompany
            // 
            this.cbRentalCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRentalCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentalCompany.FormattingEnabled = true;
            this.cbRentalCompany.Items.AddRange(new object[] {
            "Enterprise",
            "National",
            "Other"});
            this.cbRentalCompany.Location = new System.Drawing.Point(160, 108);
            this.cbRentalCompany.Name = "cbRentalCompany";
            this.cbRentalCompany.Size = new System.Drawing.Size(235, 21);
            this.cbRentalCompany.TabIndex = 15;
            // 
            // nudDays
            // 
            this.nudDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDays.Location = new System.Drawing.Point(160, 142);
            this.nudDays.Name = "nudDays";
            this.nudDays.ReadOnly = true;
            this.nudDays.Size = new System.Drawing.Size(235, 20);
            this.nudDays.TabIndex = 16;
            this.nudDays.ValueChanged += new System.EventHandler(this.nudDays_ValueChanged);
            this.nudDays.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudDays_KeyUp);
            // 
            // txtCarCost
            // 
            this.txtCarCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarCost.Location = new System.Drawing.Point(160, 176);
            this.txtCarCost.Name = "txtCarCost";
            this.txtCarCost.Size = new System.Drawing.Size(235, 20);
            this.txtCarCost.TabIndex = 17;
            this.txtCarCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarCost_KeyPress);
            this.txtCarCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCarCost_KeyUp);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(4, 214);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotalCar
            // 
            this.txtTotalCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCar.Location = new System.Drawing.Point(160, 211);
            this.txtTotalCar.Name = "txtTotalCar";
            this.txtTotalCar.Size = new System.Drawing.Size(235, 20);
            this.txtTotalCar.TabIndex = 23;
            this.txtTotalCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalCar_KeyPress);
            // 
            // lblTaxesAndFees
            // 
            this.lblTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesAndFees.AutoSize = true;
            this.lblTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxesAndFees.Location = new System.Drawing.Point(5, 8);
            this.lblTaxesAndFees.Name = "lblTaxesAndFees";
            this.lblTaxesAndFees.Size = new System.Drawing.Size(101, 13);
            this.lblTaxesAndFees.TabIndex = 6;
            this.lblTaxesAndFees.Text = "Taxes and Fees:";
            this.lblTaxesAndFees.Visible = false;
            // 
            // txtExtraInsuranceAmount
            // 
            this.txtExtraInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtraInsuranceAmount.Enabled = false;
            this.txtExtraInsuranceAmount.Location = new System.Drawing.Point(202, 428);
            this.txtExtraInsuranceAmount.Name = "txtExtraInsuranceAmount";
            this.txtExtraInsuranceAmount.Size = new System.Drawing.Size(34, 20);
            this.txtExtraInsuranceAmount.TabIndex = 22;
            this.txtExtraInsuranceAmount.Visible = false;
            this.txtExtraInsuranceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraInsuranceAmount_KeyPress);
            this.txtExtraInsuranceAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExtraInsuranceAmount_KeyUp);
            // 
            // lblExtraInsuranceAmount
            // 
            this.lblExtraInsuranceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtraInsuranceAmount.AutoSize = true;
            this.lblExtraInsuranceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraInsuranceAmount.Location = new System.Drawing.Point(54, 431);
            this.lblExtraInsuranceAmount.Name = "lblExtraInsuranceAmount";
            this.lblExtraInsuranceAmount.Size = new System.Drawing.Size(146, 13);
            this.lblExtraInsuranceAmount.TabIndex = 10;
            this.lblExtraInsuranceAmount.Text = "Extra Insurance Amount:";
            this.lblExtraInsuranceAmount.Visible = false;
            // 
            // chxExtraInsurance
            // 
            this.chxExtraInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxExtraInsurance.AutoSize = true;
            this.chxExtraInsurance.Location = new System.Drawing.Point(526, 9);
            this.chxExtraInsurance.Name = "chxExtraInsurance";
            this.chxExtraInsurance.Size = new System.Drawing.Size(15, 14);
            this.chxExtraInsurance.TabIndex = 21;
            this.chxExtraInsurance.UseVisualStyleBackColor = true;
            this.chxExtraInsurance.Visible = false;
            this.chxExtraInsurance.CheckedChanged += new System.EventHandler(this.chxExtraInsurance_CheckedChanged);
            // 
            // lblExtraInsurance
            // 
            this.lblExtraInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtraInsurance.AutoSize = true;
            this.lblExtraInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraInsurance.Location = new System.Drawing.Point(423, 8);
            this.lblExtraInsurance.Name = "lblExtraInsurance";
            this.lblExtraInsurance.Size = new System.Drawing.Size(100, 13);
            this.lblExtraInsurance.TabIndex = 9;
            this.lblExtraInsurance.Text = "Extra Insurance:";
            this.lblExtraInsurance.Visible = false;
            // 
            // txtTaxesAndFees
            // 
            this.txtTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxesAndFees.Location = new System.Drawing.Point(106, 5);
            this.txtTaxesAndFees.Name = "txtTaxesAndFees";
            this.txtTaxesAndFees.Size = new System.Drawing.Size(16, 20);
            this.txtTaxesAndFees.TabIndex = 18;
            this.txtTaxesAndFees.Text = "0";
            this.txtTaxesAndFees.Visible = false;
            this.txtTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxesAndFees_KeyPress);
            this.txtTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaxesAndFees_KeyUp);
            // 
            // txtSupplementalInsurance
            // 
            this.txtSupplementalInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplementalInsurance.Location = new System.Drawing.Point(400, 6);
            this.txtSupplementalInsurance.Name = "txtSupplementalInsurance";
            this.txtSupplementalInsurance.Size = new System.Drawing.Size(17, 20);
            this.txtSupplementalInsurance.TabIndex = 20;
            this.txtSupplementalInsurance.Text = "0";
            this.txtSupplementalInsurance.Visible = false;
            this.txtSupplementalInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplementalInsurance_KeyPress);
            this.txtSupplementalInsurance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSupplementalInsurance_KeyUp);
            // 
            // lblSupplementalInsurance
            // 
            this.lblSupplementalInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplementalInsurance.AutoSize = true;
            this.lblSupplementalInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplementalInsurance.Location = new System.Drawing.Point(251, 8);
            this.lblSupplementalInsurance.Name = "lblSupplementalInsurance";
            this.lblSupplementalInsurance.Size = new System.Drawing.Size(147, 13);
            this.lblSupplementalInsurance.TabIndex = 8;
            this.lblSupplementalInsurance.Text = "Supplemental Insurance:";
            this.lblSupplementalInsurance.Visible = false;
            // 
            // lblLDWInsurance
            // 
            this.lblLDWInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLDWInsurance.AutoSize = true;
            this.lblLDWInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDWInsurance.Location = new System.Drawing.Point(128, 8);
            this.lblLDWInsurance.Name = "lblLDWInsurance";
            this.lblLDWInsurance.Size = new System.Drawing.Size(99, 13);
            this.lblLDWInsurance.TabIndex = 7;
            this.lblLDWInsurance.Text = "LDW Insurance:";
            this.lblLDWInsurance.Visible = false;
            // 
            // txtLDWInsurance
            // 
            this.txtLDWInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLDWInsurance.Location = new System.Drawing.Point(229, 6);
            this.txtLDWInsurance.Name = "txtLDWInsurance";
            this.txtLDWInsurance.Size = new System.Drawing.Size(16, 20);
            this.txtLDWInsurance.TabIndex = 19;
            this.txtLDWInsurance.Text = "0";
            this.txtLDWInsurance.Visible = false;
            this.txtLDWInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLDWInsurance_KeyPress);
            this.txtLDWInsurance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLDWInsurance_KeyUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnSaveCar, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(565, 664);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(86, 44);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveCar.FlatAppearance.BorderSize = 0;
            this.btnSaveCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCar.Image = global::TravelExpenses.Properties.Resources._1495047519_Save;
            this.btnSaveCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCar.Location = new System.Drawing.Point(4, 6);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(78, 32);
            this.btnSaveCar.TabIndex = 0;
            this.btnSaveCar.Text = "Save";
            this.btnSaveCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCar.UseVisualStyleBackColor = true;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(24, 671);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.button1.Location = new System.Drawing.Point(19, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button1, "Select a car rental from the list and then click on the option button you want to" +
        " perform");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditCarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 703);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pCarData);
            this.Controls.Add(this.tlEditButtons);
            this.Controls.Add(this.dgvEditCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditCarRental";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Car Rental";
            this.Load += new System.EventHandler(this.EditCarRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCar)).EndInit();
            this.tlEditButtons.ResumeLayout(false);
            this.tlEditButtons.PerformLayout();
            this.pCarData.ResumeLayout(false);
            this.pCarData.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pPersonalIssuesAmount.ResumeLayout(false);
            this.pPersonalIssuesAmount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditCar;
        private System.Windows.Forms.TableLayoutPanel tlEditButtons;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnCancelEditCar;
        private System.Windows.Forms.Panel pCarData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblDropOffDate;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblRentalCompany;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblCarCost;
        private System.Windows.Forms.Label lblTaxesAndFees;
        private System.Windows.Forms.Label lblLDWInsurance;
        private System.Windows.Forms.Label lblSupplementalInsurance;
        private System.Windows.Forms.Label lblExtraInsurance;
        private System.Windows.Forms.Label lblExtraInsuranceAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpPickUpDate;
        private System.Windows.Forms.DateTimePicker dtpDropOffDate;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.ComboBox cbRentalCompany;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.TextBox txtCarCost;
        private System.Windows.Forms.TextBox txtTaxesAndFees;
        private System.Windows.Forms.TextBox txtLDWInsurance;
        private System.Windows.Forms.TextBox txtSupplementalInsurance;
        private System.Windows.Forms.CheckBox chxExtraInsurance;
        private System.Windows.Forms.TextBox txtExtraInsuranceAmount;
        private System.Windows.Forms.TextBox txtTotalCar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNoPersonalIssues;
        private System.Windows.Forms.RadioButton rbYesPeronalIssues;
        private System.Windows.Forms.Label lblPesonalIssues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoDistrictPay;
        private System.Windows.Forms.RadioButton rbYesDistrictPay;
        private System.Windows.Forms.Label lblDistrictPay;
        private System.Windows.Forms.Panel pPersonalIssuesAmount;
        private System.Windows.Forms.TextBox txtPersonalUseAmount;
        private System.Windows.Forms.Label lblPersonalIssuesAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarCostperDay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDWInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplementalInsurance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExtraInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraInsuranceAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PersonalIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalIssuesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarRentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}