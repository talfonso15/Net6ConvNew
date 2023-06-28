namespace TravelExpenses
{
    partial class Lodging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lodging));
            dtgLodgings = new System.Windows.Forms.DataGridView();
            lblLodgingHeader = new System.Windows.Forms.Label();
            tblLodging = new System.Windows.Forms.TableLayoutPanel();
            lblFacilityName = new System.Windows.Forms.Label();
            txtFacilityName = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            lblNotes = new System.Windows.Forms.Label();
            txtLodgingNotes = new System.Windows.Forms.TextBox();
            txtCostPerNight = new System.Windows.Forms.TextBox();
            lblCostPerNight = new System.Windows.Forms.Label();
            lblNumberOfNights = new System.Windows.Forms.Label();
            nudNumberNights = new System.Windows.Forms.NumericUpDown();
            lblDifferentRates = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            rbYesDiffRates = new System.Windows.Forms.RadioButton();
            rbNoDifRates = new System.Windows.Forms.RadioButton();
            txtTaxesAndFees = new System.Windows.Forms.TextBox();
            lblTaxesFeesOther = new System.Windows.Forms.Label();
            txtOtherTaxesAndFees = new System.Windows.Forms.TextBox();
            lblTaxesAndFees = new System.Windows.Forms.Label();
            pLodging = new System.Windows.Forms.Panel();
            pnDirectorApprovedLodging = new System.Windows.Forms.Panel();
            rbNoApprovedLodging = new System.Windows.Forms.RadioButton();
            rbYesApprovedLodging = new System.Windows.Forms.RadioButton();
            lblDIrectorApprovedLodging = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            rbNoDistrictPayLodging = new System.Windows.Forms.RadioButton();
            rbYesDistrictPayLodging = new System.Windows.Forms.RadioButton();
            lblDistrictPayLodging = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnAddLodging = new System.Windows.Forms.Button();
            tblLodgingNavigationButtons = new System.Windows.Forms.TableLayoutPanel();
            btnNext = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblLodgingList = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            FacilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NumberOfNights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CostPerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            DirectorApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TaxesAndFeesPerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dtgLodgings).BeginInit();
            tblLodging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberNights).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            pLodging.SuspendLayout();
            pnDirectorApprovedLodging.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblLodgingNavigationButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dtgLodgings
            // 
            dtgLodgings.AllowUserToAddRows = false;
            dtgLodgings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLodgings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FacilityName, NumberOfNights, CostPerNight, TaxesAndFees, Total, DistrictPay, DirectorApproved, Notes, TaxesAndFeesPerNight, Edit });
            dtgLodgings.Location = new System.Drawing.Point(41, 549);
            dtgLodgings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtgLodgings.Name = "dtgLodgings";
            dtgLodgings.ReadOnly = true;
            dtgLodgings.RowTemplate.Height = 30;
            dtgLodgings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgLodgings.Size = new System.Drawing.Size(742, 151);
            dtgLodgings.TabIndex = 0;
            dtgLodgings.CellContentClick += dtgLodgings_CellContentClick;
            // 
            // lblLodgingHeader
            // 
            lblLodgingHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblLodgingHeader.AutoSize = true;
            lblLodgingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblLodgingHeader.Location = new System.Drawing.Point(40, 46);
            lblLodgingHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLodgingHeader.Name = "lblLodgingHeader";
            lblLodgingHeader.Size = new System.Drawing.Size(162, 20);
            lblLodgingHeader.TabIndex = 1;
            lblLodgingHeader.Text = "Enter Hotel Details";
            // 
            // tblLodging
            // 
            tblLodging.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tblLodging.ColumnCount = 2;
            tblLodging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59399F));
            tblLodging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.40601F));
            tblLodging.Controls.Add(lblFacilityName, 0, 0);
            tblLodging.Controls.Add(txtFacilityName, 1, 0);
            tblLodging.Controls.Add(lblTotal, 0, 1);
            tblLodging.Controls.Add(txtTotal, 1, 1);
            tblLodging.Controls.Add(lblNotes, 0, 2);
            tblLodging.Controls.Add(txtLodgingNotes, 1, 2);
            tblLodging.Location = new System.Drawing.Point(20, 15);
            tblLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tblLodging.Name = "tblLodging";
            tblLodging.RowCount = 3;
            tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tblLodging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tblLodging.Size = new System.Drawing.Size(685, 142);
            tblLodging.TabIndex = 2;
            // 
            // lblFacilityName
            // 
            lblFacilityName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFacilityName.AutoSize = true;
            lblFacilityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFacilityName.Location = new System.Drawing.Point(5, 17);
            lblFacilityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFacilityName.Name = "lblFacilityName";
            lblFacilityName.Size = new System.Drawing.Size(248, 13);
            lblFacilityName.TabIndex = 0;
            lblFacilityName.Text = "Facility Name:";
            // 
            // txtFacilityName
            // 
            txtFacilityName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFacilityName.Location = new System.Drawing.Point(262, 9);
            txtFacilityName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFacilityName.Multiline = true;
            txtFacilityName.Name = "txtFacilityName";
            txtFacilityName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtFacilityName.Size = new System.Drawing.Size(418, 29);
            txtFacilityName.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(5, 64);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(248, 13);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTotal.Location = new System.Drawing.Point(262, 59);
            txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(418, 23);
            txtTotal.TabIndex = 9;
            txtTotal.KeyPress += txtTotal_KeyPress;
            txtTotal.KeyUp += txtTotal_KeyUp;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(5, 111);
            lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(248, 13);
            lblNotes.TabIndex = 11;
            lblNotes.Text = "Notes:";
            // 
            // txtLodgingNotes
            // 
            txtLodgingNotes.Location = new System.Drawing.Point(262, 98);
            txtLodgingNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLodgingNotes.Multiline = true;
            txtLodgingNotes.Name = "txtLodgingNotes";
            txtLodgingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtLodgingNotes.Size = new System.Drawing.Size(418, 39);
            txtLodgingNotes.TabIndex = 12;
            // 
            // txtCostPerNight
            // 
            txtCostPerNight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCostPerNight.Location = new System.Drawing.Point(376, 464);
            txtCostPerNight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCostPerNight.Name = "txtCostPerNight";
            txtCostPerNight.Size = new System.Drawing.Size(66, 23);
            txtCostPerNight.TabIndex = 5;
            txtCostPerNight.Visible = false;
            txtCostPerNight.KeyPress += txtCostPerNight_KeyPress;
            txtCostPerNight.KeyUp += txtCostPerNight_KeyUp;
            // 
            // lblCostPerNight
            // 
            lblCostPerNight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCostPerNight.AutoSize = true;
            lblCostPerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCostPerNight.Location = new System.Drawing.Point(260, 464);
            lblCostPerNight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCostPerNight.Name = "lblCostPerNight";
            lblCostPerNight.Size = new System.Drawing.Size(93, 13);
            lblCostPerNight.TabIndex = 4;
            lblCostPerNight.Text = "Cost Per Night:";
            lblCostPerNight.Visible = false;
            // 
            // lblNumberOfNights
            // 
            lblNumberOfNights.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNumberOfNights.AutoSize = true;
            lblNumberOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNumberOfNights.Location = new System.Drawing.Point(66, 464);
            lblNumberOfNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNumberOfNights.Name = "lblNumberOfNights";
            lblNumberOfNights.Size = new System.Drawing.Size(111, 13);
            lblNumberOfNights.TabIndex = 2;
            lblNumberOfNights.Text = "Number Of Nights:";
            lblNumberOfNights.Visible = false;
            // 
            // nudNumberNights
            // 
            nudNumberNights.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nudNumberNights.Location = new System.Drawing.Point(203, 462);
            nudNumberNights.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudNumberNights.Name = "nudNumberNights";
            nudNumberNights.Size = new System.Drawing.Size(50, 23);
            nudNumberNights.TabIndex = 3;
            nudNumberNights.Visible = false;
            nudNumberNights.ValueChanged += nudNumberNights_ValueChanged;
            nudNumberNights.KeyUp += nudNumberNights_KeyUp;
            // 
            // lblDifferentRates
            // 
            lblDifferentRates.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDifferentRates.AutoSize = true;
            lblDifferentRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDifferentRates.Location = new System.Drawing.Point(103, 14);
            lblDifferentRates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDifferentRates.Name = "lblDifferentRates";
            lblDifferentRates.Size = new System.Drawing.Size(230, 13);
            lblDifferentRates.TabIndex = 15;
            lblDifferentRates.Text = "Do you have different rates per night??";
            lblDifferentRates.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83333F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16667F));
            tableLayoutPanel2.Controls.Add(rbYesDiffRates, 0, 0);
            tableLayoutPanel2.Controls.Add(rbNoDifRates, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(378, 6);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(112, 28);
            tableLayoutPanel2.TabIndex = 16;
            tableLayoutPanel2.Visible = false;
            // 
            // rbYesDiffRates
            // 
            rbYesDiffRates.AutoSize = true;
            rbYesDiffRates.Location = new System.Drawing.Point(4, 3);
            rbYesDiffRates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDiffRates.Name = "rbYesDiffRates";
            rbYesDiffRates.Size = new System.Drawing.Size(42, 19);
            rbYesDiffRates.TabIndex = 0;
            rbYesDiffRates.TabStop = true;
            rbYesDiffRates.Text = "Yes";
            rbYesDiffRates.UseVisualStyleBackColor = true;
            // 
            // rbNoDifRates
            // 
            rbNoDifRates.AutoSize = true;
            rbNoDifRates.Checked = true;
            rbNoDifRates.Location = new System.Drawing.Point(60, 3);
            rbNoDifRates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDifRates.Name = "rbNoDifRates";
            rbNoDifRates.Size = new System.Drawing.Size(41, 19);
            rbNoDifRates.TabIndex = 1;
            rbNoDifRates.TabStop = true;
            rbNoDifRates.Text = "No";
            rbNoDifRates.UseVisualStyleBackColor = true;
            // 
            // txtTaxesAndFees
            // 
            txtTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTaxesAndFees.Location = new System.Drawing.Point(719, 10);
            txtTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTaxesAndFees.Name = "txtTaxesAndFees";
            txtTaxesAndFees.Size = new System.Drawing.Size(84, 23);
            txtTaxesAndFees.TabIndex = 7;
            txtTaxesAndFees.Text = "0";
            txtTaxesAndFees.Visible = false;
            txtTaxesAndFees.KeyPress += txtTaxesAndFees_KeyPress;
            txtTaxesAndFees.KeyUp += txtTaxesAndFees_KeyUp;
            // 
            // lblTaxesFeesOther
            // 
            lblTaxesFeesOther.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTaxesFeesOther.AutoSize = true;
            lblTaxesFeesOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTaxesFeesOther.Location = new System.Drawing.Point(532, 42);
            lblTaxesFeesOther.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTaxesFeesOther.Name = "lblTaxesFeesOther";
            lblTaxesFeesOther.Size = new System.Drawing.Size(136, 13);
            lblTaxesFeesOther.TabIndex = 13;
            lblTaxesFeesOther.Text = "Other Taxes and Fees:";
            lblTaxesFeesOther.Visible = false;
            // 
            // txtOtherTaxesAndFees
            // 
            txtOtherTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOtherTaxesAndFees.Location = new System.Drawing.Point(719, 42);
            txtOtherTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOtherTaxesAndFees.Name = "txtOtherTaxesAndFees";
            txtOtherTaxesAndFees.Size = new System.Drawing.Size(84, 23);
            txtOtherTaxesAndFees.TabIndex = 14;
            txtOtherTaxesAndFees.Text = "0";
            txtOtherTaxesAndFees.Visible = false;
            txtOtherTaxesAndFees.KeyPress += txtOtherTaxesAndFees_KeyPress;
            txtOtherTaxesAndFees.KeyUp += txtOtherTaxesAndFees_KeyUp;
            // 
            // lblTaxesAndFees
            // 
            lblTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTaxesAndFees.AutoSize = true;
            lblTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTaxesAndFees.Location = new System.Drawing.Point(532, 14);
            lblTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTaxesAndFees.Name = "lblTaxesAndFees";
            lblTaxesAndFees.Size = new System.Drawing.Size(135, 13);
            lblTaxesAndFees.TabIndex = 6;
            lblTaxesAndFees.Text = "Taxes/Fees Per Night:";
            lblTaxesAndFees.Visible = false;
            // 
            // pLodging
            // 
            pLodging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pLodging.Controls.Add(pnDirectorApprovedLodging);
            pLodging.Controls.Add(panel1);
            pLodging.Controls.Add(tblLodging);
            pLodging.Location = new System.Drawing.Point(41, 76);
            pLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pLodging.Name = "pLodging";
            pLodging.Size = new System.Drawing.Size(742, 296);
            pLodging.TabIndex = 3;
            // 
            // pnDirectorApprovedLodging
            // 
            pnDirectorApprovedLodging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnDirectorApprovedLodging.Controls.Add(rbNoApprovedLodging);
            pnDirectorApprovedLodging.Controls.Add(rbYesApprovedLodging);
            pnDirectorApprovedLodging.Controls.Add(lblDIrectorApprovedLodging);
            pnDirectorApprovedLodging.Location = new System.Drawing.Point(20, 241);
            pnDirectorApprovedLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnDirectorApprovedLodging.Name = "pnDirectorApprovedLodging";
            pnDirectorApprovedLodging.Size = new System.Drawing.Size(684, 30);
            pnDirectorApprovedLodging.TabIndex = 5;
            pnDirectorApprovedLodging.Visible = false;
            // 
            // rbNoApprovedLodging
            // 
            rbNoApprovedLodging.AutoSize = true;
            rbNoApprovedLodging.Location = new System.Drawing.Point(635, 5);
            rbNoApprovedLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoApprovedLodging.Name = "rbNoApprovedLodging";
            rbNoApprovedLodging.Size = new System.Drawing.Size(41, 19);
            rbNoApprovedLodging.TabIndex = 2;
            rbNoApprovedLodging.TabStop = true;
            rbNoApprovedLodging.Text = "No";
            rbNoApprovedLodging.UseVisualStyleBackColor = true;
            // 
            // rbYesApprovedLodging
            // 
            rbYesApprovedLodging.AutoSize = true;
            rbYesApprovedLodging.Location = new System.Drawing.Point(578, 5);
            rbYesApprovedLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesApprovedLodging.Name = "rbYesApprovedLodging";
            rbYesApprovedLodging.Size = new System.Drawing.Size(42, 19);
            rbYesApprovedLodging.TabIndex = 1;
            rbYesApprovedLodging.TabStop = true;
            rbYesApprovedLodging.Text = "Yes";
            rbYesApprovedLodging.UseVisualStyleBackColor = true;
            // 
            // lblDIrectorApprovedLodging
            // 
            lblDIrectorApprovedLodging.AutoSize = true;
            lblDIrectorApprovedLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDIrectorApprovedLodging.Location = new System.Drawing.Point(4, 7);
            lblDIrectorApprovedLodging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDIrectorApprovedLodging.Name = "lblDIrectorApprovedLodging";
            lblDIrectorApprovedLodging.Size = new System.Drawing.Size(487, 13);
            lblDIrectorApprovedLodging.TabIndex = 0;
            lblDIrectorApprovedLodging.Text = "Did the director gave you his approval to be reimbursed for paying for your lodgings?";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(rbNoDistrictPayLodging);
            panel1.Controls.Add(rbYesDistrictPayLodging);
            panel1.Controls.Add(lblDistrictPayLodging);
            panel1.Location = new System.Drawing.Point(20, 175);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(684, 40);
            panel1.TabIndex = 5;
            // 
            // rbNoDistrictPayLodging
            // 
            rbNoDistrictPayLodging.AutoSize = true;
            rbNoDistrictPayLodging.Location = new System.Drawing.Point(634, 8);
            rbNoDistrictPayLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDistrictPayLodging.Name = "rbNoDistrictPayLodging";
            rbNoDistrictPayLodging.Size = new System.Drawing.Size(41, 19);
            rbNoDistrictPayLodging.TabIndex = 2;
            rbNoDistrictPayLodging.Text = "No";
            rbNoDistrictPayLodging.UseVisualStyleBackColor = true;
            rbNoDistrictPayLodging.CheckedChanged += rbNoDistrictPayLodging_CheckedChanged;
            // 
            // rbYesDistrictPayLodging
            // 
            rbYesDistrictPayLodging.AutoSize = true;
            rbYesDistrictPayLodging.Checked = true;
            rbYesDistrictPayLodging.Location = new System.Drawing.Point(576, 8);
            rbYesDistrictPayLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDistrictPayLodging.Name = "rbYesDistrictPayLodging";
            rbYesDistrictPayLodging.Size = new System.Drawing.Size(42, 19);
            rbYesDistrictPayLodging.TabIndex = 1;
            rbYesDistrictPayLodging.TabStop = true;
            rbYesDistrictPayLodging.Text = "Yes";
            rbYesDistrictPayLodging.UseVisualStyleBackColor = true;
            rbYesDistrictPayLodging.CheckedChanged += rbYesDistrictPayLodging_CheckedChanged;
            // 
            // lblDistrictPayLodging
            // 
            lblDistrictPayLodging.AutoSize = true;
            lblDistrictPayLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistrictPayLodging.Location = new System.Drawing.Point(4, 13);
            lblDistrictPayLodging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrictPayLodging.Name = "lblDistrictPayLodging";
            lblDistrictPayLodging.Size = new System.Drawing.Size(219, 13);
            lblDistrictPayLodging.TabIndex = 0;
            lblDistrictPayLodging.Text = "Did the district pay for your lodgings?";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Image = Properties.Resources.if_information_14516;
            button3.Location = new System.Drawing.Point(492, 462);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(24, 29);
            button3.TabIndex = 8;
            toolTip1.SetToolTip(button3, "If you have different rates each night, please type the average of the rates in this box");
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = Properties.Resources.if_information_14516;
            button1.Location = new System.Drawing.Point(536, 458);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(24, 35);
            button1.TabIndex = 6;
            toolTip1.SetToolTip(button1, "The total shown is calculated base on the numbers you entered \r\nabove but is just an aproximation,  please enter the total in your invoice\r\n if it is different from the calculated one.");
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAddLodging, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(106, 393);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(685, 54);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // btnAddLodging
            // 
            btnAddLodging.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnAddLodging.BackColor = System.Drawing.Color.Azure;
            btnAddLodging.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnAddLodging.FlatAppearance.BorderSize = 5;
            btnAddLodging.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAddLodging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddLodging.Image = (System.Drawing.Image)resources.GetObject("btnAddLodging.Image");
            btnAddLodging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddLodging.Location = new System.Drawing.Point(601, 4);
            btnAddLodging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddLodging.Name = "btnAddLodging";
            btnAddLodging.Size = new System.Drawing.Size(80, 46);
            btnAddLodging.TabIndex = 10;
            btnAddLodging.Text = "Save";
            btnAddLodging.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddLodging.UseVisualStyleBackColor = false;
            btnAddLodging.Click += btnAddLodging_Click;
            // 
            // tblLodgingNavigationButtons
            // 
            tblLodgingNavigationButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tblLodgingNavigationButtons.ColumnCount = 3;
            tblLodgingNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0685F));
            tblLodgingNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.93151F));
            tblLodgingNavigationButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tblLodgingNavigationButtons.Controls.Add(btnNext, 2, 0);
            tblLodgingNavigationButtons.Controls.Add(btnBack, 0, 0);
            tblLodgingNavigationButtons.Controls.Add(label1, 1, 0);
            tblLodgingNavigationButtons.Location = new System.Drawing.Point(622, 771);
            tblLodgingNavigationButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tblLodgingNavigationButtons.Name = "tblLodgingNavigationButtons";
            tblLodgingNavigationButtons.RowCount = 1;
            tblLodgingNavigationButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblLodgingNavigationButtons.Size = new System.Drawing.Size(182, 45);
            tblLodgingNavigationButtons.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNext.Image = (System.Drawing.Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new System.Drawing.Point(115, 3);
            btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(63, 38);
            btnNext.TabIndex = 2;
            btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBack.Image = (System.Drawing.Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new System.Drawing.Point(10, 3);
            btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(52, 38);
            btnBack.TabIndex = 1;
            btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(76, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLodgingList
            // 
            lblLodgingList.AutoSize = true;
            lblLodgingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblLodgingList.Location = new System.Drawing.Point(36, 508);
            lblLodgingList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLodgingList.Name = "lblLodgingList";
            lblLodgingList.Size = new System.Drawing.Size(116, 20);
            lblLodgingList.TabIndex = 5;
            lblLodgingList.Text = "Lodgings List";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(12, 771);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(96, 39);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FacilityName
            // 
            FacilityName.HeaderText = "Facility Name";
            FacilityName.Name = "FacilityName";
            FacilityName.ReadOnly = true;
            FacilityName.Width = 150;
            // 
            // NumberOfNights
            // 
            NumberOfNights.HeaderText = "Number of Nights";
            NumberOfNights.Name = "NumberOfNights";
            NumberOfNights.ReadOnly = true;
            NumberOfNights.Visible = false;
            NumberOfNights.Width = 120;
            // 
            // CostPerNight
            // 
            CostPerNight.HeaderText = "Cost per Night";
            CostPerNight.Name = "CostPerNight";
            CostPerNight.ReadOnly = true;
            CostPerNight.Visible = false;
            // 
            // TaxesAndFees
            // 
            TaxesAndFees.HeaderText = "Other Fees";
            TaxesAndFees.Name = "TaxesAndFees";
            TaxesAndFees.ReadOnly = true;
            TaxesAndFees.Visible = false;
            TaxesAndFees.Width = 120;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // DistrictPay
            // 
            DistrictPay.HeaderText = "District Pay";
            DistrictPay.Name = "DistrictPay";
            DistrictPay.ReadOnly = true;
            DistrictPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            DistrictPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            DistrictPay.Visible = false;
            // 
            // DirectorApproved
            // 
            DirectorApproved.HeaderText = "Director Approved";
            DirectorApproved.Name = "DirectorApproved";
            DirectorApproved.ReadOnly = true;
            DirectorApproved.Visible = false;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Width = 200;
            // 
            // TaxesAndFeesPerNight
            // 
            TaxesAndFeesPerNight.HeaderText = "Taxes and Fees Per Night";
            TaxesAndFeesPerNight.Name = "TaxesAndFeesPerNight";
            TaxesAndFeesPerNight.ReadOnly = true;
            TaxesAndFeesPerNight.Visible = false;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.Image = (System.Drawing.Image)resources.GetObject("Edit.Image");
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            // 
            // Lodging
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(810, 820);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblLodgingList);
            Controls.Add(nudNumberNights);
            Controls.Add(lblNumberOfNights);
            Controls.Add(txtCostPerNight);
            Controls.Add(btnCancel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblDifferentRates);
            Controls.Add(lblCostPerNight);
            Controls.Add(txtTaxesAndFees);
            Controls.Add(tblLodgingNavigationButtons);
            Controls.Add(pLodging);
            Controls.Add(lblLodgingHeader);
            Controls.Add(dtgLodgings);
            Controls.Add(lblTaxesAndFees);
            Controls.Add(lblTaxesFeesOther);
            Controls.Add(txtOtherTaxesAndFees);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Lodging";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Lodgings";
            Load += Lodging_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLodgings).EndInit();
            tblLodging.ResumeLayout(false);
            tblLodging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberNights).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pLodging.ResumeLayout(false);
            pnDirectorApprovedLodging.ResumeLayout(false);
            pnDirectorApprovedLodging.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tblLodgingNavigationButtons.ResumeLayout(false);
            tblLodgingNavigationButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLodgings;
        private System.Windows.Forms.Label lblLodgingHeader;
        private System.Windows.Forms.TableLayoutPanel tblLodging;
        private System.Windows.Forms.Label lblFacilityName;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.NumericUpDown nudNumberNights;
        private System.Windows.Forms.Label lblCostPerNight;
        private System.Windows.Forms.TextBox txtCostPerNight;
        private System.Windows.Forms.Label lblTaxesAndFees;
        private System.Windows.Forms.TextBox txtTaxesAndFees;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAddLodging;
        private System.Windows.Forms.Panel pLodging;
        private System.Windows.Forms.TableLayoutPanel tblLodgingNavigationButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoDistrictPayLodging;
        private System.Windows.Forms.RadioButton rbYesDistrictPayLodging;
        private System.Windows.Forms.Label lblDistrictPayLodging;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtLodgingNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnDirectorApprovedLodging;
        private System.Windows.Forms.RadioButton rbNoApprovedLodging;
        private System.Windows.Forms.RadioButton rbYesApprovedLodging;
        private System.Windows.Forms.Label lblDIrectorApprovedLodging;
        private System.Windows.Forms.Label lblTaxesFeesOther;
        private System.Windows.Forms.TextBox txtOtherTaxesAndFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLodgingList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDifferentRates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbYesDiffRates;
        private System.Windows.Forms.RadioButton rbNoDifRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfNights;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPerNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DirectorApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFeesPerNight;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}