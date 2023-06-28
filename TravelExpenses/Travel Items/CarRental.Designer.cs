namespace TravelExpenses
{
    partial class CarRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRental));
            lblCarRentalHeader = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblPickUpDate = new System.Windows.Forms.Label();
            dtpPickUpDateCarRental = new System.Windows.Forms.DateTimePicker();
            lblDropOffDateCarRental = new System.Windows.Forms.Label();
            dtpDropOffDateCarRental = new System.Windows.Forms.DateTimePicker();
            lblCarType = new System.Windows.Forms.Label();
            cbCarType = new System.Windows.Forms.ComboBox();
            lblCompany = new System.Windows.Forms.Label();
            cbRentalCompany = new System.Windows.Forms.ComboBox();
            lblDays = new System.Windows.Forms.Label();
            nudDays = new System.Windows.Forms.NumericUpDown();
            lblCarCost = new System.Windows.Forms.Label();
            txtCarCost = new System.Windows.Forms.TextBox();
            lblTotalCarRental = new System.Windows.Forms.Label();
            txtTotalCarRental = new System.Windows.Forms.TextBox();
            tblCarRentalNotes = new System.Windows.Forms.TableLayoutPanel();
            lblCarRentalNotes = new System.Windows.Forms.Label();
            txtNotesCarRental = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            rbNoDistrictPayCarRental = new System.Windows.Forms.RadioButton();
            rbYesDistrictPayCarRental = new System.Windows.Forms.RadioButton();
            lblDistrictPayCarRental = new System.Windows.Forms.Label();
            pPersonalAmount = new System.Windows.Forms.Panel();
            txtPersonalAmountCarRental = new System.Windows.Forms.TextBox();
            lblPersonalAmountCarRental = new System.Windows.Forms.Label();
            pUsePersonalCarRental = new System.Windows.Forms.Panel();
            rbNoPersonalUseCarRental = new System.Windows.Forms.RadioButton();
            rbYesPersonalUseCarRental = new System.Windows.Forms.RadioButton();
            lblPersonalUseCarRental = new System.Windows.Forms.Label();
            lblTaxesAndFeesCarRental = new System.Windows.Forms.Label();
            txtCarTaxesAndFees = new System.Windows.Forms.TextBox();
            txtExtraInsuranceAmount = new System.Windows.Forms.TextBox();
            txtSupplementalInsurance = new System.Windows.Forms.TextBox();
            lblExtraInsuranceAmount = new System.Windows.Forms.Label();
            lblSupplementalInsurance = new System.Windows.Forms.Label();
            lblExtraInsurance = new System.Windows.Forms.Label();
            chxExtraInsurance = new System.Windows.Forms.CheckBox();
            lblLDWInsurance = new System.Windows.Forms.Label();
            txtLDWInsurance = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnAddCarRental = new System.Windows.Forms.Button();
            dgvCarRental = new System.Windows.Forms.DataGridView();
            tlpCarRentalNavigationButtons = new System.Windows.Forms.TableLayoutPanel();
            btnNextCarRental = new System.Windows.Forms.Button();
            btnBackCarRental = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblCarList = new System.Windows.Forms.Label();
            btnCancelCarRental = new System.Windows.Forms.Button();
            PickUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DropOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistricPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            PersonalUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            PersonalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LDWInsuranse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SupplementalInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExtraInsura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ExtraInsuranceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Delete = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).BeginInit();
            tblCarRentalNotes.SuspendLayout();
            panel2.SuspendLayout();
            pPersonalAmount.SuspendLayout();
            pUsePersonalCarRental.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarRental).BeginInit();
            tlpCarRentalNavigationButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblCarRentalHeader
            // 
            lblCarRentalHeader.AutoSize = true;
            lblCarRentalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblCarRentalHeader.Location = new System.Drawing.Point(23, 10);
            lblCarRentalHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarRentalHeader.Name = "lblCarRentalHeader";
            lblCarRentalHeader.Size = new System.Drawing.Size(205, 20);
            lblCarRentalHeader.TabIndex = 0;
            lblCarRentalHeader.Text = "Enter Car Rental Details";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(tblCarRentalNotes);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pPersonalAmount);
            panel1.Controls.Add(pUsePersonalCarRental);
            panel1.Controls.Add(lblTaxesAndFeesCarRental);
            panel1.Controls.Add(txtCarTaxesAndFees);
            panel1.Controls.Add(txtExtraInsuranceAmount);
            panel1.Controls.Add(txtSupplementalInsurance);
            panel1.Controls.Add(lblExtraInsuranceAmount);
            panel1.Controls.Add(lblSupplementalInsurance);
            panel1.Controls.Add(lblExtraInsurance);
            panel1.Controls.Add(chxExtraInsurance);
            panel1.Controls.Add(lblLDWInsurance);
            panel1.Controls.Add(txtLDWInsurance);
            panel1.Location = new System.Drawing.Point(23, 40);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(826, 431);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.15476F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.84524F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            tableLayoutPanel1.Controls.Add(lblPickUpDate, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpPickUpDateCarRental, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDropOffDateCarRental, 2, 0);
            tableLayoutPanel1.Controls.Add(dtpDropOffDateCarRental, 3, 0);
            tableLayoutPanel1.Controls.Add(lblCarType, 0, 1);
            tableLayoutPanel1.Controls.Add(cbCarType, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCompany, 2, 1);
            tableLayoutPanel1.Controls.Add(cbRentalCompany, 3, 1);
            tableLayoutPanel1.Controls.Add(lblDays, 0, 2);
            tableLayoutPanel1.Controls.Add(nudDays, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCarCost, 2, 2);
            tableLayoutPanel1.Controls.Add(txtCarCost, 3, 2);
            tableLayoutPanel1.Controls.Add(lblTotalCarRental, 0, 3);
            tableLayoutPanel1.Controls.Add(txtTotalCarRental, 1, 3);
            tableLayoutPanel1.Location = new System.Drawing.Point(27, 39);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new System.Drawing.Size(765, 151);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPickUpDate
            // 
            lblPickUpDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPickUpDate.AutoSize = true;
            lblPickUpDate.Location = new System.Drawing.Point(5, 15);
            lblPickUpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPickUpDate.Name = "lblPickUpDate";
            lblPickUpDate.Size = new System.Drawing.Size(134, 15);
            lblPickUpDate.TabIndex = 0;
            lblPickUpDate.Text = "Pick Up Date:";
            // 
            // dtpPickUpDateCarRental
            // 
            dtpPickUpDateCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpPickUpDateCarRental.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpPickUpDateCarRental.Location = new System.Drawing.Point(148, 11);
            dtpPickUpDateCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpPickUpDateCarRental.Name = "dtpPickUpDateCarRental";
            dtpPickUpDateCarRental.Size = new System.Drawing.Size(180, 23);
            dtpPickUpDateCarRental.TabIndex = 2;
            dtpPickUpDateCarRental.ValueChanged += dtpPickUpDateCarRental_ValueChanged;
            // 
            // lblDropOffDateCarRental
            // 
            lblDropOffDateCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDropOffDateCarRental.AutoSize = true;
            lblDropOffDateCarRental.Location = new System.Drawing.Point(337, 15);
            lblDropOffDateCarRental.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDropOffDateCarRental.Name = "lblDropOffDateCarRental";
            lblDropOffDateCarRental.Size = new System.Drawing.Size(168, 15);
            lblDropOffDateCarRental.TabIndex = 1;
            lblDropOffDateCarRental.Text = "Drop Off Date:";
            // 
            // dtpDropOffDateCarRental
            // 
            dtpDropOffDateCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpDropOffDateCarRental.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDropOffDateCarRental.Location = new System.Drawing.Point(514, 11);
            dtpDropOffDateCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDropOffDateCarRental.Name = "dtpDropOffDateCarRental";
            dtpDropOffDateCarRental.Size = new System.Drawing.Size(246, 23);
            dtpDropOffDateCarRental.TabIndex = 3;
            dtpDropOffDateCarRental.ValueChanged += dtpDropOffDateCarRental_ValueChanged;
            // 
            // lblCarType
            // 
            lblCarType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCarType.AutoSize = true;
            lblCarType.Location = new System.Drawing.Point(5, 56);
            lblCarType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarType.Name = "lblCarType";
            lblCarType.Size = new System.Drawing.Size(134, 15);
            lblCarType.TabIndex = 4;
            lblCarType.Text = "Car Type:";
            // 
            // cbCarType
            // 
            cbCarType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCarType.FormattingEnabled = true;
            cbCarType.Items.AddRange(new object[] { "compact", "mid-size" });
            cbCarType.Location = new System.Drawing.Point(148, 52);
            cbCarType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbCarType.Name = "cbCarType";
            cbCarType.Size = new System.Drawing.Size(180, 23);
            cbCarType.TabIndex = 5;
            // 
            // lblCompany
            // 
            lblCompany.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCompany.AutoSize = true;
            lblCompany.Location = new System.Drawing.Point(337, 56);
            lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new System.Drawing.Size(168, 15);
            lblCompany.TabIndex = 6;
            lblCompany.Text = "Rental Company:";
            // 
            // cbRentalCompany
            // 
            cbRentalCompany.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbRentalCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbRentalCompany.FormattingEnabled = true;
            cbRentalCompany.Items.AddRange(new object[] { "Enterprise", "National", "Other" });
            cbRentalCompany.Location = new System.Drawing.Point(514, 52);
            cbRentalCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbRentalCompany.Name = "cbRentalCompany";
            cbRentalCompany.Size = new System.Drawing.Size(246, 23);
            cbRentalCompany.TabIndex = 7;
            // 
            // lblDays
            // 
            lblDays.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDays.AutoSize = true;
            lblDays.Location = new System.Drawing.Point(5, 92);
            lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new System.Drawing.Size(134, 15);
            lblDays.TabIndex = 8;
            lblDays.Text = "Days:";
            // 
            // nudDays
            // 
            nudDays.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nudDays.Location = new System.Drawing.Point(148, 88);
            nudDays.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudDays.Name = "nudDays";
            nudDays.Size = new System.Drawing.Size(180, 23);
            nudDays.TabIndex = 9;
            nudDays.ValueChanged += nudDays_ValueChanged;
            nudDays.KeyUp += nudDays_KeyUp;
            // 
            // lblCarCost
            // 
            lblCarCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCarCost.AutoSize = true;
            lblCarCost.Location = new System.Drawing.Point(337, 92);
            lblCarCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarCost.Name = "lblCarCost";
            lblCarCost.Size = new System.Drawing.Size(168, 15);
            lblCarCost.TabIndex = 10;
            lblCarCost.Text = "Cost Per Day:";
            lblCarCost.Click += lblCarCost_Click;
            // 
            // txtCarCost
            // 
            txtCarCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCarCost.Location = new System.Drawing.Point(514, 88);
            txtCarCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCarCost.Name = "txtCarCost";
            txtCarCost.Size = new System.Drawing.Size(246, 23);
            txtCarCost.TabIndex = 11;
            txtCarCost.KeyPress += txtCarCost_KeyPress;
            txtCarCost.KeyUp += txtCarCost_KeyUp;
            // 
            // lblTotalCarRental
            // 
            lblTotalCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalCarRental.AutoSize = true;
            lblTotalCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalCarRental.Location = new System.Drawing.Point(5, 127);
            lblTotalCarRental.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalCarRental.Name = "lblTotalCarRental";
            lblTotalCarRental.Size = new System.Drawing.Size(134, 13);
            lblTotalCarRental.TabIndex = 14;
            lblTotalCarRental.Text = "Total:";
            // 
            // txtTotalCarRental
            // 
            txtTotalCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTotalCarRental.Location = new System.Drawing.Point(148, 122);
            txtTotalCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTotalCarRental.Name = "txtTotalCarRental";
            txtTotalCarRental.Size = new System.Drawing.Size(180, 23);
            txtTotalCarRental.TabIndex = 15;
            txtTotalCarRental.KeyUp += txtTotalCarRental_KeyUp;
            // 
            // tblCarRentalNotes
            // 
            tblCarRentalNotes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tblCarRentalNotes.ColumnCount = 2;
            tblCarRentalNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.890744F));
            tblCarRentalNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.10925F));
            tblCarRentalNotes.Controls.Add(lblCarRentalNotes, 0, 0);
            tblCarRentalNotes.Controls.Add(txtNotesCarRental, 1, 0);
            tblCarRentalNotes.Location = new System.Drawing.Point(27, 342);
            tblCarRentalNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tblCarRentalNotes.Name = "tblCarRentalNotes";
            tblCarRentalNotes.RowCount = 1;
            tblCarRentalNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblCarRentalNotes.Size = new System.Drawing.Size(770, 53);
            tblCarRentalNotes.TabIndex = 7;
            // 
            // lblCarRentalNotes
            // 
            lblCarRentalNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCarRentalNotes.AutoSize = true;
            lblCarRentalNotes.Location = new System.Drawing.Point(5, 19);
            lblCarRentalNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarRentalNotes.Name = "lblCarRentalNotes";
            lblCarRentalNotes.Size = new System.Drawing.Size(52, 15);
            lblCarRentalNotes.TabIndex = 0;
            lblCarRentalNotes.Text = "Notes:";
            // 
            // txtNotesCarRental
            // 
            txtNotesCarRental.Location = new System.Drawing.Point(66, 4);
            txtNotesCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNotesCarRental.Multiline = true;
            txtNotesCarRental.Name = "txtNotesCarRental";
            txtNotesCarRental.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotesCarRental.Size = new System.Drawing.Size(699, 42);
            txtNotesCarRental.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(rbNoDistrictPayCarRental);
            panel2.Controls.Add(rbYesDistrictPayCarRental);
            panel2.Controls.Add(lblDistrictPayCarRental);
            panel2.Location = new System.Drawing.Point(27, 208);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(770, 38);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // rbNoDistrictPayCarRental
            // 
            rbNoDistrictPayCarRental.AutoSize = true;
            rbNoDistrictPayCarRental.Location = new System.Drawing.Point(696, 8);
            rbNoDistrictPayCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDistrictPayCarRental.Name = "rbNoDistrictPayCarRental";
            rbNoDistrictPayCarRental.Size = new System.Drawing.Size(41, 19);
            rbNoDistrictPayCarRental.TabIndex = 1;
            rbNoDistrictPayCarRental.TabStop = true;
            rbNoDistrictPayCarRental.Text = "No";
            rbNoDistrictPayCarRental.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPayCarRental
            // 
            rbYesDistrictPayCarRental.AutoSize = true;
            rbYesDistrictPayCarRental.Checked = true;
            rbYesDistrictPayCarRental.Location = new System.Drawing.Point(610, 8);
            rbYesDistrictPayCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDistrictPayCarRental.Name = "rbYesDistrictPayCarRental";
            rbYesDistrictPayCarRental.Size = new System.Drawing.Size(42, 19);
            rbYesDistrictPayCarRental.TabIndex = 0;
            rbYesDistrictPayCarRental.TabStop = true;
            rbYesDistrictPayCarRental.Text = "Yes";
            rbYesDistrictPayCarRental.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPayCarRental
            // 
            lblDistrictPayCarRental.AutoSize = true;
            lblDistrictPayCarRental.Location = new System.Drawing.Point(23, 13);
            lblDistrictPayCarRental.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrictPayCarRental.Name = "lblDistrictPayCarRental";
            lblDistrictPayCarRental.Size = new System.Drawing.Size(208, 15);
            lblDistrictPayCarRental.TabIndex = 0;
            lblDistrictPayCarRental.Text = "Did the district pay for your car rental?";
            // 
            // pPersonalAmount
            // 
            pPersonalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pPersonalAmount.Controls.Add(txtPersonalAmountCarRental);
            pPersonalAmount.Controls.Add(lblPersonalAmountCarRental);
            pPersonalAmount.Enabled = false;
            pPersonalAmount.Location = new System.Drawing.Point(27, 295);
            pPersonalAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pPersonalAmount.Name = "pPersonalAmount";
            pPersonalAmount.Size = new System.Drawing.Size(770, 38);
            pPersonalAmount.TabIndex = 6;
            // 
            // txtPersonalAmountCarRental
            // 
            txtPersonalAmountCarRental.Location = new System.Drawing.Point(610, 8);
            txtPersonalAmountCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPersonalAmountCarRental.Name = "txtPersonalAmountCarRental";
            txtPersonalAmountCarRental.Size = new System.Drawing.Size(131, 23);
            txtPersonalAmountCarRental.TabIndex = 6;
            txtPersonalAmountCarRental.KeyPress += txtPersonalAmountCarRental_KeyPress;
            // 
            // lblPersonalAmountCarRental
            // 
            lblPersonalAmountCarRental.AutoSize = true;
            lblPersonalAmountCarRental.Location = new System.Drawing.Point(23, 12);
            lblPersonalAmountCarRental.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPersonalAmountCarRental.Name = "lblPersonalAmountCarRental";
            lblPersonalAmountCarRental.Size = new System.Drawing.Size(309, 15);
            lblPersonalAmountCarRental.TabIndex = 5;
            lblPersonalAmountCarRental.Text = "Please write the amount that you used for personal issues";
            // 
            // pUsePersonalCarRental
            // 
            pUsePersonalCarRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pUsePersonalCarRental.Controls.Add(rbNoPersonalUseCarRental);
            pUsePersonalCarRental.Controls.Add(rbYesPersonalUseCarRental);
            pUsePersonalCarRental.Controls.Add(lblPersonalUseCarRental);
            pUsePersonalCarRental.Location = new System.Drawing.Point(27, 253);
            pUsePersonalCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pUsePersonalCarRental.Name = "pUsePersonalCarRental";
            pUsePersonalCarRental.Size = new System.Drawing.Size(770, 35);
            pUsePersonalCarRental.TabIndex = 4;
            // 
            // rbNoPersonalUseCarRental
            // 
            rbNoPersonalUseCarRental.AutoSize = true;
            rbNoPersonalUseCarRental.Checked = true;
            rbNoPersonalUseCarRental.Location = new System.Drawing.Point(700, 7);
            rbNoPersonalUseCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoPersonalUseCarRental.Name = "rbNoPersonalUseCarRental";
            rbNoPersonalUseCarRental.Size = new System.Drawing.Size(41, 19);
            rbNoPersonalUseCarRental.TabIndex = 4;
            rbNoPersonalUseCarRental.TabStop = true;
            rbNoPersonalUseCarRental.Text = "No";
            rbNoPersonalUseCarRental.UseVisualStyleBackColor = true;
            rbNoPersonalUseCarRental.CheckedChanged += rbNoPersonalUseCarRental_CheckedChanged;
            // 
            // rbYesPersonalUseCarRental
            // 
            rbYesPersonalUseCarRental.AutoSize = true;
            rbYesPersonalUseCarRental.Location = new System.Drawing.Point(614, 7);
            rbYesPersonalUseCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesPersonalUseCarRental.Name = "rbYesPersonalUseCarRental";
            rbYesPersonalUseCarRental.Size = new System.Drawing.Size(42, 19);
            rbYesPersonalUseCarRental.TabIndex = 3;
            rbYesPersonalUseCarRental.Text = "Yes";
            rbYesPersonalUseCarRental.UseVisualStyleBackColor = true;
            rbYesPersonalUseCarRental.CheckedChanged += rbYesPersonalUseCarRental_CheckedChanged;
            // 
            // lblPersonalUseCarRental
            // 
            lblPersonalUseCarRental.AutoSize = true;
            lblPersonalUseCarRental.Location = new System.Drawing.Point(23, 12);
            lblPersonalUseCarRental.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPersonalUseCarRental.Name = "lblPersonalUseCarRental";
            lblPersonalUseCarRental.Size = new System.Drawing.Size(282, 15);
            lblPersonalUseCarRental.TabIndex = 2;
            lblPersonalUseCarRental.Text = "Did you use any of the car rental for personal issues?";
            // 
            // lblTaxesAndFeesCarRental
            // 
            lblTaxesAndFeesCarRental.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTaxesAndFeesCarRental.AutoSize = true;
            lblTaxesAndFeesCarRental.Location = new System.Drawing.Point(23, 14);
            lblTaxesAndFeesCarRental.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTaxesAndFeesCarRental.Name = "lblTaxesAndFeesCarRental";
            lblTaxesAndFeesCarRental.Size = new System.Drawing.Size(87, 15);
            lblTaxesAndFeesCarRental.TabIndex = 12;
            lblTaxesAndFeesCarRental.Text = "Taxes and Fees:";
            lblTaxesAndFeesCarRental.Visible = false;
            // 
            // txtCarTaxesAndFees
            // 
            txtCarTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCarTaxesAndFees.Location = new System.Drawing.Point(131, 10);
            txtCarTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCarTaxesAndFees.Name = "txtCarTaxesAndFees";
            txtCarTaxesAndFees.Size = new System.Drawing.Size(25, 23);
            txtCarTaxesAndFees.TabIndex = 13;
            txtCarTaxesAndFees.Visible = false;
            txtCarTaxesAndFees.KeyPress += txtCarTaxesAndFees_KeyPress;
            txtCarTaxesAndFees.KeyUp += textBox1_KeyUp;
            // 
            // txtExtraInsuranceAmount
            // 
            txtExtraInsuranceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtExtraInsuranceAmount.Enabled = false;
            txtExtraInsuranceAmount.Location = new System.Drawing.Point(771, 12);
            txtExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtExtraInsuranceAmount.Name = "txtExtraInsuranceAmount";
            txtExtraInsuranceAmount.Size = new System.Drawing.Size(25, 23);
            txtExtraInsuranceAmount.TabIndex = 23;
            txtExtraInsuranceAmount.Visible = false;
            txtExtraInsuranceAmount.KeyPress += txtExtraInsuranceAmount_KeyPress;
            txtExtraInsuranceAmount.KeyUp += txtExtraInsuranceAmount_KeyUp;
            // 
            // txtSupplementalInsurance
            // 
            txtSupplementalInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSupplementalInsurance.Location = new System.Drawing.Point(587, 10);
            txtSupplementalInsurance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSupplementalInsurance.Name = "txtSupplementalInsurance";
            txtSupplementalInsurance.Size = new System.Drawing.Size(25, 23);
            txtSupplementalInsurance.TabIndex = 19;
            txtSupplementalInsurance.Visible = false;
            txtSupplementalInsurance.KeyPress += txtSupplementalInsurance_KeyPress;
            txtSupplementalInsurance.KeyUp += txtSupplementalInsurance_KeyUp;
            // 
            // lblExtraInsuranceAmount
            // 
            lblExtraInsuranceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblExtraInsuranceAmount.AutoSize = true;
            lblExtraInsuranceAmount.Location = new System.Drawing.Point(620, 14);
            lblExtraInsuranceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExtraInsuranceAmount.Name = "lblExtraInsuranceAmount";
            lblExtraInsuranceAmount.Size = new System.Drawing.Size(137, 15);
            lblExtraInsuranceAmount.TabIndex = 22;
            lblExtraInsuranceAmount.Text = "Extra Insurance Amount:";
            lblExtraInsuranceAmount.Visible = false;
            // 
            // lblSupplementalInsurance
            // 
            lblSupplementalInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSupplementalInsurance.AutoSize = true;
            lblSupplementalInsurance.Location = new System.Drawing.Point(439, 15);
            lblSupplementalInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSupplementalInsurance.Name = "lblSupplementalInsurance";
            lblSupplementalInsurance.Size = new System.Drawing.Size(137, 15);
            lblSupplementalInsurance.TabIndex = 18;
            lblSupplementalInsurance.Text = "Supplemental Insurance:";
            lblSupplementalInsurance.Visible = false;
            // 
            // lblExtraInsurance
            // 
            lblExtraInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblExtraInsurance.AutoSize = true;
            lblExtraInsurance.Location = new System.Drawing.Point(163, 14);
            lblExtraInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExtraInsurance.Name = "lblExtraInsurance";
            lblExtraInsurance.Size = new System.Drawing.Size(90, 15);
            lblExtraInsurance.TabIndex = 20;
            lblExtraInsurance.Text = "Extra Insurance:";
            lblExtraInsurance.Visible = false;
            // 
            // chxExtraInsurance
            // 
            chxExtraInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chxExtraInsurance.AutoSize = true;
            chxExtraInsurance.Location = new System.Drawing.Point(268, 14);
            chxExtraInsurance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxExtraInsurance.Name = "chxExtraInsurance";
            chxExtraInsurance.Size = new System.Drawing.Size(15, 14);
            chxExtraInsurance.TabIndex = 21;
            chxExtraInsurance.UseVisualStyleBackColor = true;
            chxExtraInsurance.Visible = false;
            chxExtraInsurance.CheckedChanged += chxExtraInsurance_CheckedChanged;
            // 
            // lblLDWInsurance
            // 
            lblLDWInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLDWInsurance.AutoSize = true;
            lblLDWInsurance.Location = new System.Drawing.Point(293, 15);
            lblLDWInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLDWInsurance.Name = "lblLDWInsurance";
            lblLDWInsurance.Size = new System.Drawing.Size(89, 15);
            lblLDWInsurance.TabIndex = 16;
            lblLDWInsurance.Text = "LDW Insurance:";
            lblLDWInsurance.Visible = false;
            // 
            // txtLDWInsurance
            // 
            txtLDWInsurance.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLDWInsurance.Location = new System.Drawing.Point(399, 12);
            txtLDWInsurance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLDWInsurance.Name = "txtLDWInsurance";
            txtLDWInsurance.Size = new System.Drawing.Size(32, 23);
            txtLDWInsurance.TabIndex = 17;
            txtLDWInsurance.Visible = false;
            txtLDWInsurance.KeyPress += txtLDWInsurance_KeyPress;
            txtLDWInsurance.KeyUp += txtLDWInsurance_KeyUp;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnAddCarRental, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(284, 479);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(566, 53);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // btnAddCarRental
            // 
            btnAddCarRental.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnAddCarRental.BackColor = System.Drawing.Color.Azure;
            btnAddCarRental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnAddCarRental.FlatAppearance.BorderSize = 5;
            btnAddCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAddCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddCarRental.Image = (System.Drawing.Image)resources.GetObject("btnAddCarRental.Image");
            btnAddCarRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddCarRental.Location = new System.Drawing.Point(349, 3);
            btnAddCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddCarRental.Name = "btnAddCarRental";
            btnAddCarRental.Size = new System.Drawing.Size(213, 46);
            btnAddCarRental.TabIndex = 16;
            btnAddCarRental.Text = "Add Car Rental to the List";
            btnAddCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddCarRental.UseVisualStyleBackColor = false;
            btnAddCarRental.Click += btnAddCarRental_Click;
            // 
            // dgvCarRental
            // 
            dgvCarRental.AllowUserToAddRows = false;
            dgvCarRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PickUp, DropOff, CarType, Company, Days, CarCost, TaxesAndFees, DistricPay, PersonalUse, PersonalAmount, LDWInsuranse, SupplementalInsurance, ExtraInsura, ExtraInsuranceAmount, Total, Notes, Delete });
            dgvCarRental.Location = new System.Drawing.Point(23, 594);
            dgvCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvCarRental.Name = "dgvCarRental";
            dgvCarRental.ReadOnly = true;
            dgvCarRental.RowTemplate.Height = 30;
            dgvCarRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarRental.Size = new System.Drawing.Size(826, 159);
            dgvCarRental.TabIndex = 2;
            dgvCarRental.CellContentClick += dgvCarRental_CellContentClick;
            // 
            // tlpCarRentalNavigationButtons
            // 
            tlpCarRentalNavigationButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tlpCarRentalNavigationButtons.ColumnCount = 3;
            tlpCarRentalNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2F));
            tlpCarRentalNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.8F));
            tlpCarRentalNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tlpCarRentalNavigationButtons.Controls.Add(btnNextCarRental, 2, 0);
            tlpCarRentalNavigationButtons.Controls.Add(btnBackCarRental, 0, 0);
            tlpCarRentalNavigationButtons.Controls.Add(label1, 1, 0);
            tlpCarRentalNavigationButtons.Location = new System.Drawing.Point(690, 765);
            tlpCarRentalNavigationButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpCarRentalNavigationButtons.Name = "tlpCarRentalNavigationButtons";
            tlpCarRentalNavigationButtons.RowCount = 1;
            tlpCarRentalNavigationButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpCarRentalNavigationButtons.Size = new System.Drawing.Size(159, 42);
            tlpCarRentalNavigationButtons.TabIndex = 8;
            // 
            // btnNextCarRental
            // 
            btnNextCarRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNextCarRental.FlatAppearance.BorderSize = 0;
            btnNextCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNextCarRental.Image = (System.Drawing.Image)resources.GetObject("btnNextCarRental.Image");
            btnNextCarRental.Location = new System.Drawing.Point(111, 3);
            btnNextCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNextCarRental.Name = "btnNextCarRental";
            btnNextCarRental.Size = new System.Drawing.Size(44, 35);
            btnNextCarRental.TabIndex = 2;
            btnNextCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNextCarRental.UseVisualStyleBackColor = true;
            btnNextCarRental.Click += btnNextCarRental_Click;
            // 
            // btnBackCarRental
            // 
            btnBackCarRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBackCarRental.FlatAppearance.BorderSize = 0;
            btnBackCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBackCarRental.Image = (System.Drawing.Image)resources.GetObject("btnBackCarRental.Image");
            btnBackCarRental.Location = new System.Drawing.Point(6, 3);
            btnBackCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBackCarRental.Name = "btnBackCarRental";
            btnBackCarRental.Size = new System.Drawing.Size(46, 35);
            btnBackCarRental.TabIndex = 1;
            btnBackCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBackCarRental.UseVisualStyleBackColor = true;
            btnBackCarRental.Click += btnBackCarRental_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(63, 8);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarList
            // 
            lblCarList.AutoSize = true;
            lblCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblCarList.Location = new System.Drawing.Point(20, 549);
            lblCarList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCarList.Name = "lblCarList";
            lblCarList.Size = new System.Drawing.Size(138, 20);
            lblCarList.TabIndex = 9;
            lblCarList.Text = "Car Rentals List";
            // 
            // btnCancelCarRental
            // 
            btnCancelCarRental.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancelCarRental.FlatAppearance.BorderSize = 0;
            btnCancelCarRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelCarRental.Image = (System.Drawing.Image)resources.GetObject("btnCancelCarRental.Image");
            btnCancelCarRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelCarRental.Location = new System.Drawing.Point(23, 767);
            btnCancelCarRental.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelCarRental.Name = "btnCancelCarRental";
            btnCancelCarRental.Size = new System.Drawing.Size(93, 39);
            btnCancelCarRental.TabIndex = 0;
            btnCancelCarRental.Text = "Cancel";
            btnCancelCarRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelCarRental.UseVisualStyleBackColor = true;
            btnCancelCarRental.Click += btnCancelCarRental_Click;
            // 
            // PickUp
            // 
            PickUp.HeaderText = "Pick Up";
            PickUp.Name = "PickUp";
            PickUp.ReadOnly = true;
            PickUp.Width = 110;
            // 
            // DropOff
            // 
            DropOff.HeaderText = "Drop Off";
            DropOff.Name = "DropOff";
            DropOff.ReadOnly = true;
            DropOff.Width = 110;
            // 
            // CarType
            // 
            CarType.HeaderText = "Car Type";
            CarType.Name = "CarType";
            CarType.ReadOnly = true;
            CarType.Visible = false;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.Name = "Company";
            Company.ReadOnly = true;
            Company.Visible = false;
            // 
            // Days
            // 
            Days.HeaderText = "Days";
            Days.Name = "Days";
            Days.ReadOnly = true;
            Days.Width = 110;
            // 
            // CarCost
            // 
            CarCost.HeaderText = "Car Cost";
            CarCost.Name = "CarCost";
            CarCost.ReadOnly = true;
            CarCost.Visible = false;
            // 
            // TaxesAndFees
            // 
            TaxesAndFees.HeaderText = "Taxes & Fees";
            TaxesAndFees.Name = "TaxesAndFees";
            TaxesAndFees.ReadOnly = true;
            TaxesAndFees.Visible = false;
            TaxesAndFees.Width = 95;
            // 
            // DistricPay
            // 
            DistricPay.HeaderText = "District Pay";
            DistricPay.Name = "DistricPay";
            DistricPay.ReadOnly = true;
            // 
            // PersonalUse
            // 
            PersonalUse.HeaderText = "Personal Use";
            PersonalUse.Name = "PersonalUse";
            PersonalUse.ReadOnly = true;
            PersonalUse.Visible = false;
            // 
            // PersonalAmount
            // 
            PersonalAmount.HeaderText = "Personal Amount";
            PersonalAmount.Name = "PersonalAmount";
            PersonalAmount.ReadOnly = true;
            PersonalAmount.Visible = false;
            // 
            // LDWInsuranse
            // 
            LDWInsuranse.HeaderText = "LDW Insurance";
            LDWInsuranse.Name = "LDWInsuranse";
            LDWInsuranse.ReadOnly = true;
            LDWInsuranse.Visible = false;
            // 
            // SupplementalInsurance
            // 
            SupplementalInsurance.HeaderText = "Supplemental Insurance";
            SupplementalInsurance.Name = "SupplementalInsurance";
            SupplementalInsurance.ReadOnly = true;
            SupplementalInsurance.Visible = false;
            SupplementalInsurance.Width = 150;
            // 
            // ExtraInsura
            // 
            ExtraInsura.HeaderText = "Extra Insurance";
            ExtraInsura.Name = "ExtraInsura";
            ExtraInsura.ReadOnly = true;
            ExtraInsura.Visible = false;
            // 
            // ExtraInsuranceAmount
            // 
            ExtraInsuranceAmount.HeaderText = "Extra Insurance Amount";
            ExtraInsuranceAmount.Name = "ExtraInsuranceAmount";
            ExtraInsuranceAmount.ReadOnly = true;
            ExtraInsuranceAmount.Visible = false;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 110;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Visible = false;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Image = (System.Drawing.Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            // 
            // CarRental
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(863, 813);
            ControlBox = false;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblCarList);
            Controls.Add(btnCancelCarRental);
            Controls.Add(tlpCarRentalNavigationButtons);
            Controls.Add(dgvCarRental);
            Controls.Add(panel1);
            Controls.Add(lblCarRentalHeader);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CarRental";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Rentals";
            Load += CarRental_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).EndInit();
            tblCarRentalNotes.ResumeLayout(false);
            tblCarRentalNotes.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pPersonalAmount.ResumeLayout(false);
            pPersonalAmount.PerformLayout();
            pUsePersonalCarRental.ResumeLayout(false);
            pUsePersonalCarRental.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarRental).EndInit();
            tlpCarRentalNavigationButtons.ResumeLayout(false);
            tlpCarRentalNavigationButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCarRentalHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPickUpDate;
        private System.Windows.Forms.Label lblDropOffDateCarRental;
        private System.Windows.Forms.DateTimePicker dtpPickUpDateCarRental;
        private System.Windows.Forms.DateTimePicker dtpDropOffDateCarRental;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cbRentalCompany;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label lblCarCost;
        private System.Windows.Forms.TextBox txtCarCost;
        private System.Windows.Forms.Label lblTaxesAndFeesCarRental;
        private System.Windows.Forms.TextBox txtCarTaxesAndFees;
        private System.Windows.Forms.Button btnAddCarRental;
        private System.Windows.Forms.DataGridView dgvCarRental;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDistrictPayCarRental;
        private System.Windows.Forms.RadioButton rbNoDistrictPayCarRental;
        private System.Windows.Forms.RadioButton rbYesDistrictPayCarRental;
        private System.Windows.Forms.Label lblPersonalUseCarRental;
        private System.Windows.Forms.Panel pUsePersonalCarRental;
        private System.Windows.Forms.RadioButton rbNoPersonalUseCarRental;
        private System.Windows.Forms.RadioButton rbYesPersonalUseCarRental;
        private System.Windows.Forms.Label lblPersonalAmountCarRental;
        private System.Windows.Forms.Panel pPersonalAmount;
        private System.Windows.Forms.TextBox txtPersonalAmountCarRental;
        private System.Windows.Forms.TableLayoutPanel tblCarRentalNotes;
        private System.Windows.Forms.Label lblCarRentalNotes;
        private System.Windows.Forms.TextBox txtNotesCarRental;
        private System.Windows.Forms.TableLayoutPanel tlpCarRentalNavigationButtons;
        private System.Windows.Forms.Button btnCancelCarRental;
        private System.Windows.Forms.Button btnBackCarRental;
        private System.Windows.Forms.Button btnNextCarRental;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLDWInsurance;
        private System.Windows.Forms.TextBox txtLDWInsurance;
        private System.Windows.Forms.Label lblSupplementalInsurance;
        private System.Windows.Forms.TextBox txtSupplementalInsurance;
        private System.Windows.Forms.Label lblExtraInsurance;
        private System.Windows.Forms.CheckBox chxExtraInsurance;
        private System.Windows.Forms.Label lblExtraInsuranceAmount;
        private System.Windows.Forms.TextBox txtExtraInsuranceAmount;
        private System.Windows.Forms.Label lblTotalCarRental;
        private System.Windows.Forms.TextBox txtTotalCarRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistricPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PersonalUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDWInsuranse;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplementalInsurance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExtraInsura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraInsuranceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}