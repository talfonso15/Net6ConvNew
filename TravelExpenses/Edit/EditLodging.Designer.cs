namespace TravelExpenses
{
    partial class EditLodging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLodging));
            dgvEditLodgings = new System.Windows.Forms.DataGridView();
            FacilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NumberofNights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CostperNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OtherTaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LodgingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            taxesPerNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            DirectorApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tlGridviewButtons = new System.Windows.Forms.TableLayoutPanel();
            btnCancelEditLod = new System.Windows.Forms.Button();
            btnEditLod = new System.Windows.Forms.Button();
            btnAddNewLod = new System.Windows.Forms.Button();
            btnDeleteLod = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pEditing = new System.Windows.Forms.Panel();
            pDirectorApp = new System.Windows.Forms.Panel();
            rbNoDirectorApp = new System.Windows.Forms.RadioButton();
            rbYesDIrectorApp = new System.Windows.Forms.RadioButton();
            lblDirectorApp = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            rbYesDistrictPay = new System.Windows.Forms.RadioButton();
            lblDistrictPay = new System.Windows.Forms.Label();
            nudNumberOfNights = new System.Windows.Forms.NumericUpDown();
            txtCostPerNight = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblFaciltyName = new System.Windows.Forms.Label();
            txtFacilityName = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            txtTotalLod = new System.Windows.Forms.TextBox();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            lblCostPerNight = new System.Windows.Forms.Label();
            lblNumberOfNights = new System.Windows.Forms.Label();
            lblTaxesAndFeesPerNight = new System.Windows.Forms.Label();
            txtTaxesAndFeesPerNight = new System.Windows.Forms.TextBox();
            lblOtherTaxesAndFees = new System.Windows.Forms.Label();
            txtOtherTaxesAndFees = new System.Windows.Forms.TextBox();
            btnSaveLod = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnInfo = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvEditLodgings).BeginInit();
            tlGridviewButtons.SuspendLayout();
            pEditing.SuspendLayout();
            pDirectorApp.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfNights).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEditLodgings
            // 
            dgvEditLodgings.AllowUserToAddRows = false;
            dgvEditLodgings.AllowUserToResizeColumns = false;
            dgvEditLodgings.AllowUserToResizeRows = false;
            dgvEditLodgings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditLodgings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FacilityName, NumberofNights, CostperNight, OtherTaxesAndFees, Total, LodgingId, taxesPerNight, DistrictPay, DirectorApproved, Notes });
            dgvEditLodgings.Location = new System.Drawing.Point(20, 56);
            dgvEditLodgings.Name = "dgvEditLodgings";
            dgvEditLodgings.ReadOnly = true;
            dgvEditLodgings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEditLodgings.Size = new System.Drawing.Size(645, 150);
            dgvEditLodgings.TabIndex = 1;
            // 
            // FacilityName
            // 
            FacilityName.HeaderText = "Facility Name";
            FacilityName.Name = "FacilityName";
            FacilityName.ReadOnly = true;
            FacilityName.Width = 350;
            // 
            // NumberofNights
            // 
            NumberofNights.HeaderText = "Number of Nights";
            NumberofNights.Name = "NumberofNights";
            NumberofNights.ReadOnly = true;
            NumberofNights.Visible = false;
            NumberofNights.Width = 150;
            // 
            // CostperNight
            // 
            CostperNight.HeaderText = "Cost per Night";
            CostperNight.Name = "CostperNight";
            CostperNight.ReadOnly = true;
            CostperNight.Visible = false;
            // 
            // OtherTaxesAndFees
            // 
            OtherTaxesAndFees.HeaderText = "Other Taxes & Fees";
            OtherTaxesAndFees.Name = "OtherTaxesAndFees";
            OtherTaxesAndFees.ReadOnly = true;
            OtherTaxesAndFees.Visible = false;
            OtherTaxesAndFees.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // LodgingId
            // 
            LodgingId.HeaderText = "LodgingId";
            LodgingId.Name = "LodgingId";
            LodgingId.ReadOnly = true;
            LodgingId.Visible = false;
            // 
            // taxesPerNight
            // 
            taxesPerNight.HeaderText = "taxes Per Night";
            taxesPerNight.Name = "taxesPerNight";
            taxesPerNight.ReadOnly = true;
            taxesPerNight.Visible = false;
            // 
            // DistrictPay
            // 
            DistrictPay.HeaderText = "DistrictPay";
            DistrictPay.Name = "DistrictPay";
            DistrictPay.ReadOnly = true;
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
            Notes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Notes.Visible = false;
            // 
            // tlGridviewButtons
            // 
            tlGridviewButtons.ColumnCount = 7;
            tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91667F));
            tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33333F));
            tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.916667F));
            tlGridviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            tlGridviewButtons.Controls.Add(btnCancelEditLod, 0, 0);
            tlGridviewButtons.Controls.Add(btnEditLod, 6, 0);
            tlGridviewButtons.Controls.Add(btnAddNewLod, 4, 0);
            tlGridviewButtons.Controls.Add(btnDeleteLod, 2, 0);
            tlGridviewButtons.Controls.Add(label1, 1, 0);
            tlGridviewButtons.Controls.Add(label2, 3, 0);
            tlGridviewButtons.Controls.Add(label3, 5, 0);
            tlGridviewButtons.Location = new System.Drawing.Point(434, 5);
            tlGridviewButtons.Name = "tlGridviewButtons";
            tlGridviewButtons.RowCount = 1;
            tlGridviewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlGridviewButtons.Size = new System.Drawing.Size(240, 48);
            tlGridviewButtons.TabIndex = 2;
            // 
            // btnCancelEditLod
            // 
            btnCancelEditLod.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelEditLod.FlatAppearance.BorderSize = 0;
            btnCancelEditLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelEditLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelEditLod.Image = (System.Drawing.Image)resources.GetObject("btnCancelEditLod.Image");
            btnCancelEditLod.Location = new System.Drawing.Point(5, 5);
            btnCancelEditLod.Name = "btnCancelEditLod";
            btnCancelEditLod.Size = new System.Drawing.Size(32, 38);
            btnCancelEditLod.TabIndex = 2;
            btnCancelEditLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCancelEditLod, "Close");
            btnCancelEditLod.UseVisualStyleBackColor = true;
            btnCancelEditLod.Click += btnCancelEditLod_Click;
            // 
            // btnEditLod
            // 
            btnEditLod.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEditLod.FlatAppearance.BorderSize = 0;
            btnEditLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditLod.Image = (System.Drawing.Image)resources.GetObject("btnEditLod.Image");
            btnEditLod.Location = new System.Drawing.Point(198, 5);
            btnEditLod.Name = "btnEditLod";
            btnEditLod.Size = new System.Drawing.Size(32, 38);
            btnEditLod.TabIndex = 0;
            btnEditLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnEditLod, "Edit Logging");
            btnEditLod.UseVisualStyleBackColor = true;
            btnEditLod.Click += btnEditLod_Click;
            // 
            // btnAddNewLod
            // 
            btnAddNewLod.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddNewLod.FlatAppearance.BorderSize = 0;
            btnAddNewLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddNewLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddNewLod.Image = (System.Drawing.Image)resources.GetObject("btnAddNewLod.Image");
            btnAddNewLod.Location = new System.Drawing.Point(131, 5);
            btnAddNewLod.Name = "btnAddNewLod";
            btnAddNewLod.Size = new System.Drawing.Size(32, 38);
            btnAddNewLod.TabIndex = 3;
            btnAddNewLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnAddNewLod, "New Lodging");
            btnAddNewLod.UseVisualStyleBackColor = true;
            btnAddNewLod.Click += btnAddNewLod_Click;
            // 
            // btnDeleteLod
            // 
            btnDeleteLod.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteLod.FlatAppearance.BorderSize = 0;
            btnDeleteLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDeleteLod.Image = (System.Drawing.Image)resources.GetObject("btnDeleteLod.Image");
            btnDeleteLod.Location = new System.Drawing.Point(67, 5);
            btnDeleteLod.Name = "btnDeleteLod";
            btnDeleteLod.Size = new System.Drawing.Size(32, 38);
            btnDeleteLod.TabIndex = 1;
            btnDeleteLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnDeleteLod, "Delete Lodging");
            btnDeleteLod.UseVisualStyleBackColor = true;
            btnDeleteLod.Click += btnDeleteLod_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(45, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 25);
            label1.TabIndex = 4;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(108, 11);
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
            label3.Location = new System.Drawing.Point(172, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(13, 25);
            label3.TabIndex = 6;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEditing
            // 
            pEditing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pEditing.Controls.Add(pDirectorApp);
            pEditing.Controls.Add(panel1);
            pEditing.Controls.Add(nudNumberOfNights);
            pEditing.Controls.Add(txtCostPerNight);
            pEditing.Controls.Add(tableLayoutPanel2);
            pEditing.Controls.Add(lblCostPerNight);
            pEditing.Controls.Add(lblNumberOfNights);
            pEditing.Location = new System.Drawing.Point(20, 263);
            pEditing.Name = "pEditing";
            pEditing.Size = new System.Drawing.Size(645, 342);
            pEditing.TabIndex = 3;
            // 
            // pDirectorApp
            // 
            pDirectorApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pDirectorApp.Controls.Add(rbNoDirectorApp);
            pDirectorApp.Controls.Add(rbYesDIrectorApp);
            pDirectorApp.Controls.Add(lblDirectorApp);
            pDirectorApp.Enabled = false;
            pDirectorApp.Location = new System.Drawing.Point(28, 285);
            pDirectorApp.Name = "pDirectorApp";
            pDirectorApp.Size = new System.Drawing.Size(590, 34);
            pDirectorApp.TabIndex = 2;
            // 
            // rbNoDirectorApp
            // 
            rbNoDirectorApp.AutoSize = true;
            rbNoDirectorApp.Location = new System.Drawing.Point(534, 8);
            rbNoDirectorApp.Name = "rbNoDirectorApp";
            rbNoDirectorApp.Size = new System.Drawing.Size(39, 17);
            rbNoDirectorApp.TabIndex = 2;
            rbNoDirectorApp.Text = "No";
            rbNoDirectorApp.UseVisualStyleBackColor = true;
            // 
            // rbYesDIrectorApp
            // 
            rbYesDIrectorApp.AutoSize = true;
            rbYesDIrectorApp.Location = new System.Drawing.Point(476, 8);
            rbYesDIrectorApp.Name = "rbYesDIrectorApp";
            rbYesDIrectorApp.Size = new System.Drawing.Size(43, 17);
            rbYesDIrectorApp.TabIndex = 1;
            rbYesDIrectorApp.Text = "Yes";
            rbYesDIrectorApp.UseVisualStyleBackColor = true;
            // 
            // lblDirectorApp
            // 
            lblDirectorApp.AutoSize = true;
            lblDirectorApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDirectorApp.Location = new System.Drawing.Point(12, 9);
            lblDirectorApp.Name = "lblDirectorApp";
            lblDirectorApp.Size = new System.Drawing.Size(402, 13);
            lblDirectorApp.TabIndex = 0;
            lblDirectorApp.Text = "Did the director gave you his approval for the lodging reimbursement?";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(rbNoDistrictPay);
            panel1.Controls.Add(rbYesDistrictPay);
            panel1.Controls.Add(lblDistrictPay);
            panel1.Location = new System.Drawing.Point(28, 244);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(590, 35);
            panel1.TabIndex = 1;
            // 
            // rbNoDistrictPay
            // 
            rbNoDistrictPay.AutoSize = true;
            rbNoDistrictPay.Location = new System.Drawing.Point(534, 10);
            rbNoDistrictPay.Name = "rbNoDistrictPay";
            rbNoDistrictPay.Size = new System.Drawing.Size(39, 17);
            rbNoDistrictPay.TabIndex = 2;
            rbNoDistrictPay.TabStop = true;
            rbNoDistrictPay.Text = "No";
            rbNoDistrictPay.UseVisualStyleBackColor = true;
            rbNoDistrictPay.CheckedChanged += rbNoDistrictPay_CheckedChanged;
            // 
            // rbYesDistrictPay
            // 
            rbYesDistrictPay.AutoSize = true;
            rbYesDistrictPay.Location = new System.Drawing.Point(476, 10);
            rbYesDistrictPay.Name = "rbYesDistrictPay";
            rbYesDistrictPay.Size = new System.Drawing.Size(43, 17);
            rbYesDistrictPay.TabIndex = 1;
            rbYesDistrictPay.TabStop = true;
            rbYesDistrictPay.Text = "Yes";
            rbYesDistrictPay.UseVisualStyleBackColor = true;
            rbYesDistrictPay.CheckedChanged += rbYesDistrictPay_CheckedChanged;
            // 
            // lblDistrictPay
            // 
            lblDistrictPay.AutoSize = true;
            lblDistrictPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistrictPay.Location = new System.Drawing.Point(12, 12);
            lblDistrictPay.Name = "lblDistrictPay";
            lblDistrictPay.Size = new System.Drawing.Size(227, 13);
            lblDistrictPay.TabIndex = 0;
            lblDistrictPay.Text = "Did the district pay for your lodging(s)?";
            // 
            // nudNumberOfNights
            // 
            nudNumberOfNights.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nudNumberOfNights.Location = new System.Drawing.Point(330, 218);
            nudNumberOfNights.Name = "nudNumberOfNights";
            nudNumberOfNights.Size = new System.Drawing.Size(39, 20);
            nudNumberOfNights.TabIndex = 3;
            nudNumberOfNights.Visible = false;
            nudNumberOfNights.ValueChanged += nudNumberOfNights_ValueChanged;
            nudNumberOfNights.KeyUp += nudNumberOfNights_KeyUp;
            // 
            // txtCostPerNight
            // 
            txtCostPerNight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCostPerNight.Location = new System.Drawing.Point(147, 219);
            txtCostPerNight.Name = "txtCostPerNight";
            txtCostPerNight.Size = new System.Drawing.Size(23, 20);
            txtCostPerNight.TabIndex = 5;
            txtCostPerNight.Visible = false;
            txtCostPerNight.KeyPress += txtCostPerNight_KeyPress;
            txtCostPerNight.KeyUp += txtCostPerNight_KeyUp;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.79661F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.20339F));
            tableLayoutPanel2.Controls.Add(lblFaciltyName, 0, 0);
            tableLayoutPanel2.Controls.Add(txtFacilityName, 1, 0);
            tableLayoutPanel2.Controls.Add(lblTotal, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTotalLod, 1, 1);
            tableLayoutPanel2.Controls.Add(lblNotes, 0, 2);
            tableLayoutPanel2.Controls.Add(txtNotes, 1, 2);
            tableLayoutPanel2.Location = new System.Drawing.Point(28, 32);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            tableLayoutPanel2.Size = new System.Drawing.Size(590, 177);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblFaciltyName
            // 
            lblFaciltyName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFaciltyName.AutoSize = true;
            lblFaciltyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFaciltyName.Location = new System.Drawing.Point(4, 14);
            lblFaciltyName.Name = "lblFaciltyName";
            lblFaciltyName.Size = new System.Drawing.Size(215, 13);
            lblFaciltyName.TabIndex = 0;
            lblFaciltyName.Text = "Facility Name:";
            // 
            // txtFacilityName
            // 
            txtFacilityName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFacilityName.Location = new System.Drawing.Point(226, 5);
            txtFacilityName.Multiline = true;
            txtFacilityName.Name = "txtFacilityName";
            txtFacilityName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtFacilityName.Size = new System.Drawing.Size(360, 30);
            txtFacilityName.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(4, 56);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(215, 13);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total:";
            // 
            // txtTotalLod
            // 
            txtTotalLod.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTotalLod.Location = new System.Drawing.Point(226, 52);
            txtTotalLod.Name = "txtTotalLod";
            txtTotalLod.Size = new System.Drawing.Size(360, 20);
            txtTotalLod.TabIndex = 11;
            txtTotalLod.TextChanged += txtTotalLod_TextChanged;
            txtTotalLod.KeyPress += txtTotalLod_KeyPress;
            txtTotalLod.KeyUp += txtTotalLod_KeyUp;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(4, 124);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(215, 13);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(226, 90);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(360, 80);
            txtNotes.TabIndex = 13;
            // 
            // lblCostPerNight
            // 
            lblCostPerNight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCostPerNight.AutoSize = true;
            lblCostPerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCostPerNight.Location = new System.Drawing.Point(49, 222);
            lblCostPerNight.Name = "lblCostPerNight";
            lblCostPerNight.Size = new System.Drawing.Size(92, 13);
            lblCostPerNight.TabIndex = 4;
            lblCostPerNight.Text = "Cost per Night:";
            lblCostPerNight.Visible = false;
            // 
            // lblNumberOfNights
            // 
            lblNumberOfNights.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNumberOfNights.AutoSize = true;
            lblNumberOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNumberOfNights.Location = new System.Drawing.Point(213, 222);
            lblNumberOfNights.Name = "lblNumberOfNights";
            lblNumberOfNights.Size = new System.Drawing.Size(109, 13);
            lblNumberOfNights.TabIndex = 2;
            lblNumberOfNights.Text = "Number of Nights:";
            lblNumberOfNights.Visible = false;
            // 
            // lblTaxesAndFeesPerNight
            // 
            lblTaxesAndFeesPerNight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTaxesAndFeesPerNight.AutoSize = true;
            lblTaxesAndFeesPerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTaxesAndFeesPerNight.Location = new System.Drawing.Point(17, 224);
            lblTaxesAndFeesPerNight.Name = "lblTaxesAndFeesPerNight";
            lblTaxesAndFeesPerNight.Size = new System.Drawing.Size(157, 13);
            lblTaxesAndFeesPerNight.TabIndex = 6;
            lblTaxesAndFeesPerNight.Text = "Taxes and Fees per Night:";
            lblTaxesAndFeesPerNight.Visible = false;
            // 
            // txtTaxesAndFeesPerNight
            // 
            txtTaxesAndFeesPerNight.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTaxesAndFeesPerNight.Location = new System.Drawing.Point(180, 224);
            txtTaxesAndFeesPerNight.Name = "txtTaxesAndFeesPerNight";
            txtTaxesAndFeesPerNight.Size = new System.Drawing.Size(31, 20);
            txtTaxesAndFeesPerNight.TabIndex = 7;
            txtTaxesAndFeesPerNight.Text = "0";
            txtTaxesAndFeesPerNight.Visible = false;
            txtTaxesAndFeesPerNight.KeyPress += txtTaxesAndFeesPerNight_KeyPress;
            txtTaxesAndFeesPerNight.KeyUp += txtTaxesAndFeesPerNight_KeyUp;
            // 
            // lblOtherTaxesAndFees
            // 
            lblOtherTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOtherTaxesAndFees.AutoSize = true;
            lblOtherTaxesAndFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblOtherTaxesAndFees.Location = new System.Drawing.Point(26, 250);
            lblOtherTaxesAndFees.Name = "lblOtherTaxesAndFees";
            lblOtherTaxesAndFees.Size = new System.Drawing.Size(136, 13);
            lblOtherTaxesAndFees.TabIndex = 8;
            lblOtherTaxesAndFees.Text = "Other Taxes and Fees:";
            lblOtherTaxesAndFees.Visible = false;
            // 
            // txtOtherTaxesAndFees
            // 
            txtOtherTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOtherTaxesAndFees.Location = new System.Drawing.Point(180, 250);
            txtOtherTaxesAndFees.Name = "txtOtherTaxesAndFees";
            txtOtherTaxesAndFees.Size = new System.Drawing.Size(31, 20);
            txtOtherTaxesAndFees.TabIndex = 9;
            txtOtherTaxesAndFees.Text = "0";
            txtOtherTaxesAndFees.Visible = false;
            txtOtherTaxesAndFees.KeyPress += txtOtherTaxesAndFees_KeyPress;
            txtOtherTaxesAndFees.KeyUp += txtOtherTaxesAndFees_KeyUp;
            // 
            // btnSaveLod
            // 
            btnSaveLod.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSaveLod.FlatAppearance.BorderSize = 0;
            btnSaveLod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveLod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSaveLod.Image = (System.Drawing.Image)resources.GetObject("btnSaveLod.Image");
            btnSaveLod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaveLod.Location = new System.Drawing.Point(588, 623);
            btnSaveLod.Name = "btnSaveLod";
            btnSaveLod.Size = new System.Drawing.Size(76, 34);
            btnSaveLod.TabIndex = 0;
            btnSaveLod.Text = "Save";
            btnSaveLod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSaveLod.UseVisualStyleBackColor = true;
            btnSaveLod.Click += btnSaveLod_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(15, 623);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
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
            btnInfo.Location = new System.Drawing.Point(15, 31);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(22, 23);
            btnInfo.TabIndex = 5;
            toolTip1.SetToolTip(btnInfo, "Select a lodging from the list and then click on the option that you want to perform on it.");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // EditLodging
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(691, 669);
            ControlBox = false;
            Controls.Add(btnSaveLod);
            Controls.Add(btnInfo);
            Controls.Add(btnCancel);
            Controls.Add(pEditing);
            Controls.Add(tlGridviewButtons);
            Controls.Add(dgvEditLodgings);
            Controls.Add(txtOtherTaxesAndFees);
            Controls.Add(lblOtherTaxesAndFees);
            Controls.Add(txtTaxesAndFeesPerNight);
            Controls.Add(lblTaxesAndFeesPerNight);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "EditLodging";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Lodgings";
            Load += EditLodging_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditLodgings).EndInit();
            tlGridviewButtons.ResumeLayout(false);
            tlGridviewButtons.PerformLayout();
            pEditing.ResumeLayout(false);
            pEditing.PerformLayout();
            pDirectorApp.ResumeLayout(false);
            pDirectorApp.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfNights).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEditLodgings;
        private System.Windows.Forms.TableLayoutPanel tlGridviewButtons;
        private System.Windows.Forms.Button btnEditLod;
        private System.Windows.Forms.Button btnDeleteLod;
        private System.Windows.Forms.Button btnCancelEditLod;
        private System.Windows.Forms.Panel pEditing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFaciltyName;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.NumericUpDown nudNumberOfNights;
        private System.Windows.Forms.Label lblCostPerNight;
        private System.Windows.Forms.TextBox txtCostPerNight;
        private System.Windows.Forms.Label lblTaxesAndFeesPerNight;
        private System.Windows.Forms.TextBox txtTaxesAndFeesPerNight;
        private System.Windows.Forms.Label lblOtherTaxesAndFees;
        private System.Windows.Forms.TextBox txtOtherTaxesAndFees;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalLod;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoDistrictPay;
        private System.Windows.Forms.RadioButton rbYesDistrictPay;
        private System.Windows.Forms.Label lblDistrictPay;
        private System.Windows.Forms.Panel pDirectorApp;
        private System.Windows.Forms.Label lblDirectorApp;
        private System.Windows.Forms.RadioButton rbNoDirectorApp;
        private System.Windows.Forms.RadioButton rbYesDIrectorApp;
        private System.Windows.Forms.Button btnSaveLod;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewLod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberofNights;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostperNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherTaxesAndFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn LodgingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxesPerNight;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DirectorApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}