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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCarRental));
            dgvEditCar = new System.Windows.Forms.DataGridView();
            PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DropOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarCostperDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RentalCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LDWInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SupplementalInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExtraInsurance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ExtraInsuranceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonalIssues = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            PersonalIssuesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarRentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tlEditButtons = new System.Windows.Forms.TableLayoutPanel();
            btnAddCar = new System.Windows.Forms.Button();
            btnDeleteCar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnCancelEditCar = new System.Windows.Forms.Button();
            btnEditCar = new System.Windows.Forms.Button();
            pCarData = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            pPersonalIssuesAmount = new System.Windows.Forms.Panel();
            txtPersonalUseAmount = new System.Windows.Forms.TextBox();
            lblPersonalIssuesAmount = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            rbNoPersonalIssues = new System.Windows.Forms.RadioButton();
            rbYesPeronalIssues = new System.Windows.Forms.RadioButton();
            lblPesonalIssues = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            rbYesDistrictPay = new System.Windows.Forms.RadioButton();
            lblDistrictPay = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblPickUpDate = new System.Windows.Forms.Label();
            lblDropOffDate = new System.Windows.Forms.Label();
            lblCarType = new System.Windows.Forms.Label();
            lblRentalCompany = new System.Windows.Forms.Label();
            lblDays = new System.Windows.Forms.Label();
            lblCarCost = new System.Windows.Forms.Label();
            dtpPickUpDate = new System.Windows.Forms.DateTimePicker();
            dtpDropOffDate = new System.Windows.Forms.DateTimePicker();
            cbCarType = new System.Windows.Forms.ComboBox();
            cbRentalCompany = new System.Windows.Forms.ComboBox();
            nudDays = new System.Windows.Forms.NumericUpDown();
            txtCarCost = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            txtTotalCar = new System.Windows.Forms.TextBox();
            lblTaxesAndFees = new System.Windows.Forms.Label();
            txtExtraInsuranceAmount = new System.Windows.Forms.TextBox();
            lblExtraInsuranceAmount = new System.Windows.Forms.Label();
            chxExtraInsurance = new System.Windows.Forms.CheckBox();
            lblExtraInsurance = new System.Windows.Forms.Label();
            txtTaxesAndFees = new System.Windows.Forms.TextBox();
            txtSupplementalInsurance = new System.Windows.Forms.TextBox();
            lblSupplementalInsurance = new System.Windows.Forms.Label();
            lblLDWInsurance = new System.Windows.Forms.Label();
            txtLDWInsurance = new System.Windows.Forms.TextBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnSaveCar = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvEditCar).BeginInit();
            tlEditButtons.SuspendLayout();
            pCarData.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            pPersonalIssuesAmount.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).BeginInit();
            SuspendLayout();
            // 
            // dgvEditCar
            // 
            dgvEditCar.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvEditCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEditCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PickUpDate, DropOffDate, CarCostperDay, DistrictPay, Total, CarType, RentalCompany, Days, TaxesAndFees, LDWInsurance, SupplementalInsurance, ExtraInsurance, ExtraInsuranceAmount, PersonalIssues, PersonalIssuesAmount, CarRentalID, Notes });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvEditCar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEditCar.Location = new System.Drawing.Point(16, 65);
            dgvEditCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvEditCar.Name = "dgvEditCar";
            dgvEditCar.ReadOnly = true;
            dgvEditCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEditCar.Size = new System.Drawing.Size(716, 121);
            dgvEditCar.TabIndex = 0;
            dgvEditCar.CellContentClick += dgvEditCar_CellContentClick;
            // 
            // PickUpDate
            // 
            PickUpDate.HeaderText = "Pick Up Date";
            PickUpDate.Name = "PickUpDate";
            PickUpDate.ReadOnly = true;
            PickUpDate.Width = 110;
            // 
            // DropOffDate
            // 
            DropOffDate.HeaderText = "Drop Off Date";
            DropOffDate.Name = "DropOffDate";
            DropOffDate.ReadOnly = true;
            DropOffDate.Width = 110;
            // 
            // CarCostperDay
            // 
            CarCostperDay.HeaderText = "Car Cost per Day";
            CarCostperDay.Name = "CarCostperDay";
            CarCostperDay.ReadOnly = true;
            CarCostperDay.Width = 150;
            // 
            // DistrictPay
            // 
            DistrictPay.HeaderText = "District Pay";
            DistrictPay.Name = "DistrictPay";
            DistrictPay.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // CarType
            // 
            CarType.HeaderText = "Car Type";
            CarType.Name = "CarType";
            CarType.ReadOnly = true;
            CarType.Visible = false;
            // 
            // RentalCompany
            // 
            RentalCompany.HeaderText = "Rental Company";
            RentalCompany.Name = "RentalCompany";
            RentalCompany.ReadOnly = true;
            RentalCompany.Visible = false;
            // 
            // Days
            // 
            Days.HeaderText = "Days";
            Days.Name = "Days";
            Days.ReadOnly = true;
            Days.Visible = false;
            // 
            // TaxesAndFees
            // 
            TaxesAndFees.HeaderText = "Taxes And Fees";
            TaxesAndFees.Name = "TaxesAndFees";
            TaxesAndFees.ReadOnly = true;
            TaxesAndFees.Visible = false;
            // 
            // LDWInsurance
            // 
            LDWInsurance.HeaderText = "LDW Insurance";
            LDWInsurance.Name = "LDWInsurance";
            LDWInsurance.ReadOnly = true;
            LDWInsurance.Visible = false;
            // 
            // SupplementalInsurance
            // 
            SupplementalInsurance.HeaderText = "Supplemental Insurance";
            SupplementalInsurance.Name = "SupplementalInsurance";
            SupplementalInsurance.ReadOnly = true;
            SupplementalInsurance.Visible = false;
            // 
            // ExtraInsurance
            // 
            ExtraInsurance.HeaderText = "Extra Insurance";
            ExtraInsurance.Name = "ExtraInsurance";
            ExtraInsurance.ReadOnly = true;
            ExtraInsurance.Visible = false;
            // 
            // ExtraInsuranceAmount
            // 
            ExtraInsuranceAmount.HeaderText = "Extra Insurance Amount";
            ExtraInsuranceAmount.Name = "ExtraInsuranceAmount";
            ExtraInsuranceAmount.ReadOnly = true;
            ExtraInsuranceAmount.Visible = false;
            // 
            // PersonalIssues
            // 
            PersonalIssues.HeaderText = "Personal Issues";
            PersonalIssues.Name = "PersonalIssues";
            PersonalIssues.ReadOnly = true;
            PersonalIssues.Visible = false;
            // 
            // PersonalIssuesAmount
            // 
            PersonalIssuesAmount.HeaderText = "Personal Issues Amount";
            PersonalIssuesAmount.Name = "PersonalIssuesAmount";
            PersonalIssuesAmount.ReadOnly = true;
            PersonalIssuesAmount.Visible = false;
            // 
            // CarRentalID
            // 
            CarRentalID.HeaderText = "CarRentalID";
            CarRentalID.Name = "CarRentalID";
            CarRentalID.ReadOnly = true;
            CarRentalID.Visible = false;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Visible = false;
            // 
            // tlEditButtons
            // 
            tlEditButtons.ColumnCount = 7;
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33834F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33083F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.54135F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            tlEditButtons.Controls.Add(btnAddCar, 4, 0);
            tlEditButtons.Controls.Add(btnDeleteCar, 2, 0);
            tlEditButtons.Controls.Add(label1, 1, 0);
            tlEditButtons.Controls.Add(label2, 3, 0);
            tlEditButtons.Controls.Add(label3, 5, 0);
            tlEditButtons.Controls.Add(btnCancelEditCar, 0, 0);
            tlEditButtons.Controls.Add(btnEditCar, 6, 0);
            tlEditButtons.Location = new System.Drawing.Point(478, 12);
            tlEditButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlEditButtons.Name = "tlEditButtons";
            tlEditButtons.RowCount = 1;
            tlEditButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlEditButtons.Size = new System.Drawing.Size(252, 48);
            tlEditButtons.TabIndex = 2;
            tlEditButtons.Paint += tlEditButtons_Paint;
            // 
            // btnAddCar
            // 
            btnAddCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddCar.Image = (System.Drawing.Image)resources.GetObject("btnAddCar.Image");
            btnAddCar.Location = new System.Drawing.Point(140, 3);
            btnAddCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new System.Drawing.Size(37, 42);
            btnAddCar.TabIndex = 1;
            btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteCar.FlatAppearance.BorderSize = 0;
            btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDeleteCar.Image = (System.Drawing.Image)resources.GetObject("btnDeleteCar.Image");
            btnDeleteCar.Location = new System.Drawing.Point(72, 3);
            btnDeleteCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new System.Drawing.Size(34, 42);
            btnDeleteCar.TabIndex = 2;
            btnDeleteCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(51, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(13, 25);
            label1.TabIndex = 4;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(115, 11);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(14, 25);
            label2.TabIndex = 5;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(189, 11);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 25);
            label3.TabIndex = 6;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelEditCar
            // 
            btnCancelEditCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelEditCar.FlatAppearance.BorderSize = 0;
            btnCancelEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelEditCar.Image = (System.Drawing.Image)resources.GetObject("btnCancelEditCar.Image");
            btnCancelEditCar.Location = new System.Drawing.Point(5, 3);
            btnCancelEditCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelEditCar.Name = "btnCancelEditCar";
            btnCancelEditCar.Size = new System.Drawing.Size(37, 42);
            btnCancelEditCar.TabIndex = 3;
            btnCancelEditCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelEditCar.UseVisualStyleBackColor = true;
            btnCancelEditCar.Click += btnCancelEditCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEditCar.FlatAppearance.BorderSize = 0;
            btnEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditCar.Image = (System.Drawing.Image)resources.GetObject("btnEditCar.Image");
            btnEditCar.Location = new System.Drawing.Point(214, 3);
            btnEditCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new System.Drawing.Size(34, 42);
            btnEditCar.TabIndex = 0;
            btnEditCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEditCar.UseVisualStyleBackColor = true;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // pCarData
            // 
            pCarData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pCarData.Controls.Add(tableLayoutPanel3);
            pCarData.Controls.Add(pPersonalIssuesAmount);
            pCarData.Controls.Add(panel2);
            pCarData.Controls.Add(panel1);
            pCarData.Controls.Add(tableLayoutPanel2);
            pCarData.Controls.Add(lblTaxesAndFees);
            pCarData.Controls.Add(txtExtraInsuranceAmount);
            pCarData.Controls.Add(lblExtraInsuranceAmount);
            pCarData.Controls.Add(chxExtraInsurance);
            pCarData.Controls.Add(lblExtraInsurance);
            pCarData.Controls.Add(txtTaxesAndFees);
            pCarData.Controls.Add(txtSupplementalInsurance);
            pCarData.Controls.Add(lblSupplementalInsurance);
            pCarData.Controls.Add(lblLDWInsurance);
            pCarData.Controls.Add(txtLDWInsurance);
            pCarData.Location = new System.Drawing.Point(16, 213);
            pCarData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pCarData.Name = "pCarData";
            pCarData.Size = new System.Drawing.Size(716, 430);
            pCarData.TabIndex = 3;
            pCarData.Paint += pCarData_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32076F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.67924F));
            tableLayoutPanel3.Controls.Add(lblNotes, 0, 0);
            tableLayoutPanel3.Controls.Add(txtNotes, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(80, 362);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(556, 45);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(5, 16);
            lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(54, 13);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(68, 5);
            txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(483, 35);
            txtNotes.TabIndex = 1;
            // 
            // pPersonalIssuesAmount
            // 
            pPersonalIssuesAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pPersonalIssuesAmount.Controls.Add(txtPersonalUseAmount);
            pPersonalIssuesAmount.Controls.Add(lblPersonalIssuesAmount);
            pPersonalIssuesAmount.Enabled = false;
            pPersonalIssuesAmount.Location = new System.Drawing.Point(80, 326);
            pPersonalIssuesAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pPersonalIssuesAmount.Name = "pPersonalIssuesAmount";
            pPersonalIssuesAmount.Size = new System.Drawing.Size(556, 32);
            pPersonalIssuesAmount.TabIndex = 3;
            // 
            // txtPersonalUseAmount
            // 
            txtPersonalUseAmount.Location = new System.Drawing.Point(439, 3);
            txtPersonalUseAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPersonalUseAmount.Name = "txtPersonalUseAmount";
            txtPersonalUseAmount.Size = new System.Drawing.Size(102, 23);
            txtPersonalUseAmount.TabIndex = 1;
            txtPersonalUseAmount.KeyPress += txtPersonalUseAmount_KeyPress;
            // 
            // lblPersonalIssuesAmount
            // 
            lblPersonalIssuesAmount.AutoSize = true;
            lblPersonalIssuesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPersonalIssuesAmount.Location = new System.Drawing.Point(7, 8);
            lblPersonalIssuesAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPersonalIssuesAmount.Name = "lblPersonalIssuesAmount";
            lblPersonalIssuesAmount.Size = new System.Drawing.Size(353, 13);
            lblPersonalIssuesAmount.TabIndex = 0;
            lblPersonalIssuesAmount.Text = "Please provide the amount that you used for personal issues:";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(rbNoPersonalIssues);
            panel2.Controls.Add(rbYesPeronalIssues);
            panel2.Controls.Add(lblPesonalIssues);
            panel2.Location = new System.Drawing.Point(80, 288);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(556, 31);
            panel2.TabIndex = 2;
            // 
            // rbNoPersonalIssues
            // 
            rbNoPersonalIssues.AutoSize = true;
            rbNoPersonalIssues.Location = new System.Drawing.Point(500, 5);
            rbNoPersonalIssues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoPersonalIssues.Name = "rbNoPersonalIssues";
            rbNoPersonalIssues.Size = new System.Drawing.Size(41, 19);
            rbNoPersonalIssues.TabIndex = 2;
            rbNoPersonalIssues.TabStop = true;
            rbNoPersonalIssues.Text = "No";
            rbNoPersonalIssues.UseVisualStyleBackColor = true;
            rbNoPersonalIssues.CheckedChanged += rbNoPersonalIssues_CheckedChanged;
            // 
            // rbYesPeronalIssues
            // 
            rbYesPeronalIssues.AutoSize = true;
            rbYesPeronalIssues.Location = new System.Drawing.Point(439, 5);
            rbYesPeronalIssues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesPeronalIssues.Name = "rbYesPeronalIssues";
            rbYesPeronalIssues.Size = new System.Drawing.Size(42, 19);
            rbYesPeronalIssues.TabIndex = 1;
            rbYesPeronalIssues.TabStop = true;
            rbYesPeronalIssues.Text = "Yes";
            rbYesPeronalIssues.UseVisualStyleBackColor = true;
            rbYesPeronalIssues.CheckedChanged += rbYesPeronalIssues_CheckedChanged;
            // 
            // lblPesonalIssues
            // 
            lblPesonalIssues.AutoSize = true;
            lblPesonalIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPesonalIssues.Location = new System.Drawing.Point(7, 8);
            lblPesonalIssues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPesonalIssues.Name = "lblPesonalIssues";
            lblPesonalIssues.Size = new System.Drawing.Size(310, 13);
            lblPesonalIssues.TabIndex = 0;
            lblPesonalIssues.Text = "Did you use any of the car rental for personal issues?";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(rbNoDistrictPay);
            panel1.Controls.Add(rbYesDistrictPay);
            panel1.Controls.Add(lblDistrictPay);
            panel1.Location = new System.Drawing.Point(80, 251);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(556, 30);
            panel1.TabIndex = 1;
            // 
            // rbNoDistrictPay
            // 
            rbNoDistrictPay.AutoSize = true;
            rbNoDistrictPay.Location = new System.Drawing.Point(500, 5);
            rbNoDistrictPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDistrictPay.Name = "rbNoDistrictPay";
            rbNoDistrictPay.Size = new System.Drawing.Size(41, 19);
            rbNoDistrictPay.TabIndex = 2;
            rbNoDistrictPay.TabStop = true;
            rbNoDistrictPay.Text = "No";
            rbNoDistrictPay.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPay
            // 
            rbYesDistrictPay.AutoSize = true;
            rbYesDistrictPay.Location = new System.Drawing.Point(439, 3);
            rbYesDistrictPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDistrictPay.Name = "rbYesDistrictPay";
            rbYesDistrictPay.Size = new System.Drawing.Size(42, 19);
            rbYesDistrictPay.TabIndex = 1;
            rbYesDistrictPay.TabStop = true;
            rbYesDistrictPay.Text = "Yes";
            rbYesDistrictPay.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPay
            // 
            lblDistrictPay.AutoSize = true;
            lblDistrictPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistrictPay.Location = new System.Drawing.Point(7, 7);
            lblDistrictPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrictPay.Name = "lblDistrictPay";
            lblDistrictPay.Size = new System.Drawing.Size(226, 13);
            lblDistrictPay.TabIndex = 0;
            lblDistrictPay.Text = "Did the district pay for your car rental?";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34837F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65163F));
            tableLayoutPanel2.Controls.Add(lblPickUpDate, 0, 0);
            tableLayoutPanel2.Controls.Add(lblDropOffDate, 0, 1);
            tableLayoutPanel2.Controls.Add(lblCarType, 0, 2);
            tableLayoutPanel2.Controls.Add(lblRentalCompany, 0, 3);
            tableLayoutPanel2.Controls.Add(lblDays, 0, 4);
            tableLayoutPanel2.Controls.Add(lblCarCost, 0, 5);
            tableLayoutPanel2.Controls.Add(dtpPickUpDate, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpDropOffDate, 1, 1);
            tableLayoutPanel2.Controls.Add(cbCarType, 1, 2);
            tableLayoutPanel2.Controls.Add(cbRentalCompany, 1, 3);
            tableLayoutPanel2.Controls.Add(nudDays, 1, 4);
            tableLayoutPanel2.Controls.Add(txtCarCost, 1, 5);
            tableLayoutPanel2.Controls.Add(lblTotal, 0, 6);
            tableLayoutPanel2.Controls.Add(txtTotalCar, 1, 6);
            tableLayoutPanel2.Location = new System.Drawing.Point(131, 7);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel2.Size = new System.Drawing.Size(465, 233);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblPickUpDate
            // 
            lblPickUpDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPickUpDate.AutoSize = true;
            lblPickUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPickUpDate.Location = new System.Drawing.Point(5, 10);
            lblPickUpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPickUpDate.Name = "lblPickUpDate";
            lblPickUpDate.Size = new System.Drawing.Size(173, 13);
            lblPickUpDate.TabIndex = 0;
            lblPickUpDate.Text = "Pick Up Date:";
            // 
            // lblDropOffDate
            // 
            lblDropOffDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDropOffDate.AutoSize = true;
            lblDropOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDropOffDate.Location = new System.Drawing.Point(5, 43);
            lblDropOffDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDropOffDate.Name = "lblDropOffDate";
            lblDropOffDate.Size = new System.Drawing.Size(173, 13);
            lblDropOffDate.TabIndex = 1;
            lblDropOffDate.Text = "Drop Off Date:";
            // 
            // lblCarType
            // 
            lblCarType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCarType.AutoSize = true;
            lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCarType.Location = new System.Drawing.Point(5, 76);
            lblCarType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarType.Name = "lblCarType";
            lblCarType.Size = new System.Drawing.Size(173, 13);
            lblCarType.TabIndex = 2;
            lblCarType.Text = "Car Type:";
            // 
            // lblRentalCompany
            // 
            lblRentalCompany.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblRentalCompany.AutoSize = true;
            lblRentalCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRentalCompany.Location = new System.Drawing.Point(5, 109);
            lblRentalCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRentalCompany.Name = "lblRentalCompany";
            lblRentalCompany.Size = new System.Drawing.Size(173, 13);
            lblRentalCompany.TabIndex = 3;
            lblRentalCompany.Text = "Rental Company:";
            // 
            // lblDays
            // 
            lblDays.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDays.AutoSize = true;
            lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDays.Location = new System.Drawing.Point(5, 142);
            lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new System.Drawing.Size(173, 13);
            lblDays.TabIndex = 4;
            lblDays.Text = "Days:";
            // 
            // lblCarCost
            // 
            lblCarCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCarCost.AutoSize = true;
            lblCarCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCarCost.Location = new System.Drawing.Point(5, 175);
            lblCarCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarCost.Name = "lblCarCost";
            lblCarCost.Size = new System.Drawing.Size(173, 13);
            lblCarCost.TabIndex = 5;
            lblCarCost.Text = "Car Cost:";
            // 
            // dtpPickUpDate
            // 
            dtpPickUpDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpPickUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpPickUpDate.Location = new System.Drawing.Point(187, 5);
            dtpPickUpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpPickUpDate.Name = "dtpPickUpDate";
            dtpPickUpDate.Size = new System.Drawing.Size(273, 23);
            dtpPickUpDate.TabIndex = 12;
            dtpPickUpDate.ValueChanged += dtpPickUpDate_ValueChanged;
            // 
            // dtpDropOffDate
            // 
            dtpDropOffDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpDropOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDropOffDate.Location = new System.Drawing.Point(187, 38);
            dtpDropOffDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDropOffDate.Name = "dtpDropOffDate";
            dtpDropOffDate.Size = new System.Drawing.Size(273, 23);
            dtpDropOffDate.TabIndex = 13;
            dtpDropOffDate.ValueChanged += dtpDropOffDate_ValueChanged;
            // 
            // cbCarType
            // 
            cbCarType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCarType.FormattingEnabled = true;
            cbCarType.Items.AddRange(new object[] { "compact", "mid-size" });
            cbCarType.Location = new System.Drawing.Point(187, 71);
            cbCarType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbCarType.Name = "cbCarType";
            cbCarType.Size = new System.Drawing.Size(273, 23);
            cbCarType.TabIndex = 14;
            // 
            // cbRentalCompany
            // 
            cbRentalCompany.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbRentalCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbRentalCompany.FormattingEnabled = true;
            cbRentalCompany.Items.AddRange(new object[] { "Enterprise", "National", "Other" });
            cbRentalCompany.Location = new System.Drawing.Point(187, 104);
            cbRentalCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbRentalCompany.Name = "cbRentalCompany";
            cbRentalCompany.Size = new System.Drawing.Size(273, 23);
            cbRentalCompany.TabIndex = 15;
            // 
            // nudDays
            // 
            nudDays.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nudDays.Location = new System.Drawing.Point(187, 137);
            nudDays.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudDays.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudDays.Name = "nudDays";
            nudDays.ReadOnly = true;
            nudDays.Size = new System.Drawing.Size(273, 23);
            nudDays.TabIndex = 16;
            nudDays.ValueChanged += nudDays_ValueChanged;
            nudDays.KeyUp += nudDays_KeyUp;
            // 
            // txtCarCost
            // 
            txtCarCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCarCost.Location = new System.Drawing.Point(187, 170);
            txtCarCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCarCost.Name = "txtCarCost";
            txtCarCost.Size = new System.Drawing.Size(273, 23);
            txtCarCost.TabIndex = 17;
            txtCarCost.KeyPress += txtCarCost_KeyPress;
            txtCarCost.KeyUp += txtCarCost_KeyUp;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(5, 209);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(173, 13);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total:";
            // 
            // txtTotalCar
            // 
            txtTotalCar.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTotalCar.Location = new System.Drawing.Point(187, 204);
            txtTotalCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTotalCar.Name = "txtTotalCar";
            txtTotalCar.Size = new System.Drawing.Size(273, 23);
            txtTotalCar.TabIndex = 23;
            txtTotalCar.TextChanged += txtTotalCar_TextChanged;
            txtTotalCar.KeyPress += txtTotalCar_KeyPress;
            txtTotalCar.KeyUp += txtTotalCar_KeyUp;
            // 
            // lblTaxesAndFees
            // 
            lblTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTaxesAndFees.AutoSize = true;
            lblTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTaxesAndFees.Location = new System.Drawing.Point(6, -39);
            lblTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTaxesAndFees.Name = "lblTaxesAndFees";
            lblTaxesAndFees.Size = new System.Drawing.Size(101, 13);
            lblTaxesAndFees.TabIndex = 6;
            lblTaxesAndFees.Text = "Taxes and Fees:";
            lblTaxesAndFees.Visible = false;
            // 
            // txtExtraInsuranceAmount
            // 
            txtExtraInsuranceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtExtraInsuranceAmount.Enabled = false;
            txtExtraInsuranceAmount.Location = new System.Drawing.Point(34, 139);
            txtExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtExtraInsuranceAmount.Name = "txtExtraInsuranceAmount";
            txtExtraInsuranceAmount.Size = new System.Drawing.Size(39, 23);
            txtExtraInsuranceAmount.TabIndex = 22;
            txtExtraInsuranceAmount.Visible = false;
            txtExtraInsuranceAmount.KeyPress += txtExtraInsuranceAmount_KeyPress;
            txtExtraInsuranceAmount.KeyUp += txtExtraInsuranceAmount_KeyUp;
            // 
            // lblExtraInsuranceAmount
            // 
            lblExtraInsuranceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblExtraInsuranceAmount.AutoSize = true;
            lblExtraInsuranceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExtraInsuranceAmount.Location = new System.Drawing.Point(9, 123);
            lblExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExtraInsuranceAmount.Name = "lblExtraInsuranceAmount";
            lblExtraInsuranceAmount.Size = new System.Drawing.Size(114, 13);
            lblExtraInsuranceAmount.TabIndex = 10;
            lblExtraInsuranceAmount.Text = "Extra Insu Amount:";
            lblExtraInsuranceAmount.Visible = false;
            // 
            // chxExtraInsurance
            // 
            chxExtraInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chxExtraInsurance.AutoSize = true;
            chxExtraInsurance.Location = new System.Drawing.Point(104, 91);
            chxExtraInsurance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxExtraInsurance.Name = "chxExtraInsurance";
            chxExtraInsurance.Size = new System.Drawing.Size(15, 14);
            chxExtraInsurance.TabIndex = 21;
            chxExtraInsurance.UseVisualStyleBackColor = true;
            chxExtraInsurance.Visible = false;
            chxExtraInsurance.CheckedChanged += chxExtraInsurance_CheckedChanged;
            // 
            // lblExtraInsurance
            // 
            lblExtraInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblExtraInsurance.AutoSize = true;
            lblExtraInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExtraInsurance.Location = new System.Drawing.Point(7, 91);
            lblExtraInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExtraInsurance.Name = "lblExtraInsurance";
            lblExtraInsurance.Size = new System.Drawing.Size(100, 13);
            lblExtraInsurance.TabIndex = 9;
            lblExtraInsurance.Text = "Extra Insurance:";
            lblExtraInsurance.Visible = false;
            // 
            // txtTaxesAndFees
            // 
            txtTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTaxesAndFees.Location = new System.Drawing.Point(105, -39);
            txtTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTaxesAndFees.Name = "txtTaxesAndFees";
            txtTaxesAndFees.Size = new System.Drawing.Size(18, 23);
            txtTaxesAndFees.TabIndex = 18;
            txtTaxesAndFees.Text = "0";
            txtTaxesAndFees.Visible = false;
            txtTaxesAndFees.KeyPress += txtTaxesAndFees_KeyPress;
            txtTaxesAndFees.KeyUp += txtTaxesAndFees_KeyUp;
            // 
            // txtSupplementalInsurance
            // 
            txtSupplementalInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSupplementalInsurance.Location = new System.Drawing.Point(88, 51);
            txtSupplementalInsurance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSupplementalInsurance.Name = "txtSupplementalInsurance";
            txtSupplementalInsurance.Size = new System.Drawing.Size(19, 23);
            txtSupplementalInsurance.TabIndex = 20;
            txtSupplementalInsurance.Text = "0";
            txtSupplementalInsurance.Visible = false;
            txtSupplementalInsurance.KeyPress += txtSupplementalInsurance_KeyPress;
            txtSupplementalInsurance.KeyUp += txtSupplementalInsurance_KeyUp;
            // 
            // lblSupplementalInsurance
            // 
            lblSupplementalInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSupplementalInsurance.AutoSize = true;
            lblSupplementalInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSupplementalInsurance.Location = new System.Drawing.Point(4, 35);
            lblSupplementalInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSupplementalInsurance.Name = "lblSupplementalInsurance";
            lblSupplementalInsurance.Size = new System.Drawing.Size(115, 13);
            lblSupplementalInsurance.TabIndex = 8;
            lblSupplementalInsurance.Text = "Supplemental Insu:";
            lblSupplementalInsurance.Visible = false;
            // 
            // lblLDWInsurance
            // 
            lblLDWInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLDWInsurance.AutoSize = true;
            lblLDWInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLDWInsurance.Location = new System.Drawing.Point(4, -3);
            lblLDWInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLDWInsurance.Name = "lblLDWInsurance";
            lblLDWInsurance.Size = new System.Drawing.Size(99, 13);
            lblLDWInsurance.TabIndex = 7;
            lblLDWInsurance.Text = "LDW Insurance:";
            lblLDWInsurance.Visible = false;
            // 
            // txtLDWInsurance
            // 
            txtLDWInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLDWInsurance.Location = new System.Drawing.Point(105, -7);
            txtLDWInsurance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLDWInsurance.Name = "txtLDWInsurance";
            txtLDWInsurance.Size = new System.Drawing.Size(18, 23);
            txtLDWInsurance.TabIndex = 19;
            txtLDWInsurance.Text = "0";
            txtLDWInsurance.Visible = false;
            txtLDWInsurance.KeyPress += txtLDWInsurance_KeyPress;
            txtLDWInsurance.KeyUp += txtLDWInsurance_KeyUp;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Location = new System.Drawing.Point(420, 653);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(100, 39);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnSaveCar
            // 
            btnSaveCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSaveCar.FlatAppearance.BorderSize = 0;
            btnSaveCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSaveCar.Image = (System.Drawing.Image)resources.GetObject("btnSaveCar.Image");
            btnSaveCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaveCar.Location = new System.Drawing.Point(666, 656);
            btnSaveCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new System.Drawing.Size(75, 33);
            btnSaveCar.TabIndex = 0;
            btnSaveCar.Text = "Save";
            btnSaveCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSaveCar.UseVisualStyleBackColor = true;
            btnSaveCar.Click += btnSaveCar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(17, 653);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(92, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(8, 37);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 27);
            button1.TabIndex = 5;
            toolTip1.SetToolTip(button1, "Select a car rental from the list and then click on the option button you want to perform");
            button1.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 250;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // EditCarRental
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(739, 685);
            ControlBox = false;
            Controls.Add(btnSaveCar);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(btnCancel);
            Controls.Add(pCarData);
            Controls.Add(tlEditButtons);
            Controls.Add(dgvEditCar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditCarRental";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Car Rental";
            Load += EditCarRental_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditCar).EndInit();
            tlEditButtons.ResumeLayout(false);
            tlEditButtons.PerformLayout();
            pCarData.ResumeLayout(false);
            pCarData.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            pPersonalIssuesAmount.ResumeLayout(false);
            pPersonalIssuesAmount.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).EndInit();
            ResumeLayout(false);
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