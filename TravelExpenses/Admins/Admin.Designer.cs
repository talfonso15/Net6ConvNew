namespace TravelExpenses
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblEmployee = new System.Windows.Forms.Label();
            lblShowBy = new System.Windows.Forms.Label();
            cbEmployee = new System.Windows.Forms.ComboBox();
            lblDepartments = new System.Windows.Forms.Label();
            cbDepartments = new System.Windows.Forms.ComboBox();
            cbtravels = new System.Windows.Forms.ComboBox();
            pnCriteria = new System.Windows.Forms.Panel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            lblDateRange = new System.Windows.Forms.Label();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            lblTo = new System.Windows.Forms.Label();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            btnShow = new System.Windows.Forms.Button();
            dgvTravels = new System.Windows.Forms.DataGridView();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AccountingApproval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnFinalize = new System.Windows.Forms.Button();
            btnPDF = new System.Windows.Forms.Button();
            btnAccAprr = new System.Windows.Forms.Button();
            btnView = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lblDelete = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnEdit = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            btnSendEmails = new System.Windows.Forms.Button();
            btnHide = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            pnCriteria.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66584F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.33417F));
            tableLayoutPanel1.Controls.Add(lblEmployee, 0, 1);
            tableLayoutPanel1.Controls.Add(lblShowBy, 0, 0);
            tableLayoutPanel1.Controls.Add(cbEmployee, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDepartments, 0, 2);
            tableLayoutPanel1.Controls.Add(cbDepartments, 1, 2);
            tableLayoutPanel1.Controls.Add(cbtravels, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(15, 6);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new System.Drawing.Size(581, 102);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblEmployee
            // 
            lblEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmployee.Location = new System.Drawing.Point(4, 42);
            lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new System.Drawing.Size(187, 15);
            lblEmployee.TabIndex = 1;
            lblEmployee.Text = "Select Employee:";
            lblEmployee.Visible = false;
            // 
            // lblShowBy
            // 
            lblShowBy.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblShowBy.AutoSize = true;
            lblShowBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblShowBy.Location = new System.Drawing.Point(4, 8);
            lblShowBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblShowBy.Name = "lblShowBy";
            lblShowBy.Size = new System.Drawing.Size(187, 17);
            lblShowBy.TabIndex = 0;
            lblShowBy.Text = "Show travels by:";
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(199, 38);
            cbEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(378, 23);
            cbEmployee.TabIndex = 3;
            cbEmployee.Visible = false;
            cbEmployee.SelectedIndexChanged += cbEmployee_SelectedIndexChanged;
            // 
            // lblDepartments
            // 
            lblDepartments.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartments.AutoSize = true;
            lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDepartments.Location = new System.Drawing.Point(4, 76);
            lblDepartments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartments.Name = "lblDepartments";
            lblDepartments.Size = new System.Drawing.Size(187, 15);
            lblDepartments.TabIndex = 4;
            lblDepartments.Text = "Select Department:";
            lblDepartments.Visible = false;
            // 
            // cbDepartments
            // 
            cbDepartments.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Items.AddRange(new object[] { "Accounting/Purchasing 101", "Air/Flee/Bldg & Grounds 102", "Educ & Communication 103", "Executive 104", "Field Validation 105", "Mosquito Group 106", "Pilots 107", "Scientific Intelligence 108", "Hyacinth", "Commissioners" });
            cbDepartments.Location = new System.Drawing.Point(199, 72);
            cbDepartments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new System.Drawing.Size(378, 23);
            cbDepartments.TabIndex = 5;
            cbDepartments.Visible = false;
            // 
            // cbtravels
            // 
            cbtravels.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbtravels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbtravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbtravels.FormattingEnabled = true;
            cbtravels.Items.AddRange(new object[] { "All", "Department", "Employee", "Department + Date Range", "Employee + Date Range" });
            cbtravels.Location = new System.Drawing.Point(199, 5);
            cbtravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbtravels.Name = "cbtravels";
            cbtravels.Size = new System.Drawing.Size(378, 23);
            cbtravels.TabIndex = 1;
            cbtravels.SelectedIndexChanged += cbtravels_SelectedIndexChanged;
            // 
            // pnCriteria
            // 
            pnCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnCriteria.Controls.Add(tableLayoutPanel4);
            pnCriteria.Controls.Add(tableLayoutPanel1);
            pnCriteria.Controls.Add(btnShow);
            pnCriteria.Location = new System.Drawing.Point(14, 9);
            pnCriteria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnCriteria.Name = "pnCriteria";
            pnCriteria.Size = new System.Drawing.Size(736, 149);
            pnCriteria.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.54321F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.45679F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            tableLayoutPanel4.Controls.Add(lblDateRange, 0, 0);
            tableLayoutPanel4.Controls.Add(dtpStartDate, 1, 0);
            tableLayoutPanel4.Controls.Add(lblTo, 2, 0);
            tableLayoutPanel4.Controls.Add(dtpEndDate, 3, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(15, 110);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(581, 35);
            tableLayoutPanel4.TabIndex = 5;
            tableLayoutPanel4.Visible = false;
            // 
            // lblDateRange
            // 
            lblDateRange.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDateRange.AutoSize = true;
            lblDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDateRange.Location = new System.Drawing.Point(4, 11);
            lblDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDateRange.Name = "lblDateRange";
            lblDateRange.Size = new System.Drawing.Size(161, 13);
            lblDateRange.TabIndex = 0;
            lblDateRange.Text = "Date Range:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpStartDate.Location = new System.Drawing.Point(173, 6);
            dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(150, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTo.AutoSize = true;
            lblTo.Location = new System.Drawing.Point(331, 10);
            lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new System.Drawing.Size(27, 15);
            lblTo.TabIndex = 2;
            lblTo.Text = "To";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpEndDate.Location = new System.Drawing.Point(366, 6);
            dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(211, 23);
            dtpEndDate.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShow.ForeColor = System.Drawing.Color.RoyalBlue;
            btnShow.Image = (System.Drawing.Image)resources.GetObject("btnShow.Image");
            btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShow.Location = new System.Drawing.Point(626, 107);
            btnShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(92, 35);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show";
            btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dgvTravels
            // 
            dgvTravels.AllowUserToAddRows = false;
            dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DepartureDate, ReturnDate, TravelEvent, TravelPurpose, Status, Origin, Destination, Total, TravelID, UserID, Username, AccountingApproval });
            dgvTravels.Location = new System.Drawing.Point(16, 69);
            dgvTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvTravels.MultiSelect = false;
            dgvTravels.Name = "dgvTravels";
            dgvTravels.ReadOnly = true;
            dgvTravels.RowHeadersWidth = 62;
            dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTravels.Size = new System.Drawing.Size(1141, 369);
            dgvTravels.TabIndex = 2;
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "Departure";
            DepartureDate.MinimumWidth = 8;
            DepartureDate.Name = "DepartureDate";
            DepartureDate.ReadOnly = true;
            DepartureDate.Width = 80;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Return";
            ReturnDate.MinimumWidth = 8;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            ReturnDate.Width = 80;
            // 
            // TravelEvent
            // 
            TravelEvent.HeaderText = "Event";
            TravelEvent.MinimumWidth = 8;
            TravelEvent.Name = "TravelEvent";
            TravelEvent.ReadOnly = true;
            TravelEvent.Width = 150;
            // 
            // TravelPurpose
            // 
            TravelPurpose.HeaderText = "Purpose";
            TravelPurpose.MinimumWidth = 8;
            TravelPurpose.Name = "TravelPurpose";
            TravelPurpose.ReadOnly = true;
            TravelPurpose.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 70;
            // 
            // Origin
            // 
            Origin.HeaderText = "Origin";
            Origin.MinimumWidth = 8;
            Origin.Name = "Origin";
            Origin.ReadOnly = true;
            Origin.Width = 150;
            // 
            // Destination
            // 
            Destination.HeaderText = "Destination";
            Destination.MinimumWidth = 8;
            Destination.Name = "Destination";
            Destination.ReadOnly = true;
            Destination.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 70;
            // 
            // TravelID
            // 
            TravelID.HeaderText = "TravelID";
            TravelID.MinimumWidth = 8;
            TravelID.Name = "TravelID";
            TravelID.ReadOnly = true;
            TravelID.Visible = false;
            TravelID.Width = 150;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.MinimumWidth = 8;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Visible = false;
            UserID.Width = 150;
            // 
            // Username
            // 
            Username.HeaderText = "User";
            Username.MinimumWidth = 8;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Visible = false;
            Username.Width = 150;
            // 
            // AccountingApproval
            // 
            AccountingApproval.HeaderText = "Approved";
            AccountingApproval.MinimumWidth = 8;
            AccountingApproval.Name = "AccountingApproval";
            AccountingApproval.ReadOnly = true;
            AccountingApproval.Visible = false;
            AccountingApproval.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            tableLayoutPanel2.Controls.Add(label3, 7, 0);
            tableLayoutPanel2.Controls.Add(label1, 3, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 0, 0);
            tableLayoutPanel2.Controls.Add(btnFinalize, 2, 0);
            tableLayoutPanel2.Controls.Add(btnPDF, 4, 0);
            tableLayoutPanel2.Controls.Add(btnAccAprr, 6, 0);
            tableLayoutPanel2.Controls.Add(btnView, 8, 0);
            tableLayoutPanel2.Controls.Add(label2, 5, 0);
            tableLayoutPanel2.Controls.Add(lblDelete, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(620, 10);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(283, 52);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(226, 18);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(10, 15);
            label3.TabIndex = 5;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(106, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(10, 15);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Image = (System.Drawing.Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new System.Drawing.Point(4, 5);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(34, 41);
            btnDelete.TabIndex = 8;
            toolTip1.SetToolTip(btnDelete, "Delete Travel");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFinalize
            // 
            btnFinalize.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnFinalize.FlatAppearance.BorderSize = 0;
            btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnFinalize.Image = (System.Drawing.Image)resources.GetObject("btnFinalize.Image");
            btnFinalize.Location = new System.Drawing.Point(64, 3);
            btnFinalize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFinalize.Name = "btnFinalize";
            btnFinalize.Size = new System.Drawing.Size(34, 46);
            btnFinalize.TabIndex = 2;
            btnFinalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnFinalize, "Archive travel");
            btnFinalize.UseVisualStyleBackColor = true;
            btnFinalize.Click += btnFinalize_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPDF.Image = (System.Drawing.Image)resources.GetObject("btnPDF.Image");
            btnPDF.Location = new System.Drawing.Point(124, 3);
            btnPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new System.Drawing.Size(34, 46);
            btnPDF.TabIndex = 1;
            btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnPDF, "Create PDF");
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnAccAprr
            // 
            btnAccAprr.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAccAprr.FlatAppearance.BorderSize = 0;
            btnAccAprr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccAprr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAccAprr.Image = (System.Drawing.Image)resources.GetObject("btnAccAprr.Image");
            btnAccAprr.Location = new System.Drawing.Point(185, 5);
            btnAccAprr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAccAprr.Name = "btnAccAprr";
            btnAccAprr.Size = new System.Drawing.Size(32, 41);
            btnAccAprr.TabIndex = 6;
            btnAccAprr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnAccAprr, "Accounting Approval");
            btnAccAprr.UseVisualStyleBackColor = true;
            btnAccAprr.Click += btnAccAprr_Click;
            // 
            // btnView
            // 
            btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnView.Image = (System.Drawing.Image)resources.GetObject("btnView.Image");
            btnView.Location = new System.Drawing.Point(244, 8);
            btnView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(35, 36);
            btnView.TabIndex = 0;
            btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnView, "View Travel Details");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(166, 18);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(10, 15);
            label2.TabIndex = 4;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelete
            // 
            lblDelete.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDelete.AutoSize = true;
            lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDelete.Location = new System.Drawing.Point(46, 18);
            lblDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new System.Drawing.Size(10, 15);
            lblDelete.TabIndex = 7;
            lblDelete.Text = "|";
            lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblDelete.Visible = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(lblInfo);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(dgvTravels);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new System.Drawing.Point(14, 165);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1174, 462);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 8;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.85123968F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.7685947F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.61157036F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.9421482F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.85123968F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5289249F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.02479362F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5950413F));
            tableLayoutPanel3.Controls.Add(btnEdit, 3, 0);
            tableLayoutPanel3.Controls.Add(label7, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCancel, 7, 0);
            tableLayoutPanel3.Controls.Add(label5, 6, 0);
            tableLayoutPanel3.Controls.Add(btnSendEmails, 1, 0);
            tableLayoutPanel3.Controls.Add(btnHide, 5, 0);
            tableLayoutPanel3.Controls.Add(label4, 4, 0);
            tableLayoutPanel3.Controls.Add(label6, 2, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(904, 10);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(242, 52);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEdit.Image = (System.Drawing.Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new System.Drawing.Point(82, 10);
            btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(33, 32);
            btnEdit.TabIndex = 7;
            btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnEdit, "Edit Travel");
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(4, 18);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(11, 15);
            label7.TabIndex = 6;
            label7.Text = "|";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new System.Drawing.Point(200, 6);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(36, 39);
            btnCancel.TabIndex = 3;
            toolTip1.SetToolTip(btnCancel, "Close");
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(182, 18);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(9, 15);
            label5.TabIndex = 2;
            label5.Text = "|";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendEmails
            // 
            btnSendEmails.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSendEmails.Enabled = false;
            btnSendEmails.FlatAppearance.BorderSize = 0;
            btnSendEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendEmails.Image = (System.Drawing.Image)resources.GetObject("btnSendEmails.Image");
            btnSendEmails.Location = new System.Drawing.Point(23, 4);
            btnSendEmails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSendEmails.Name = "btnSendEmails";
            btnSendEmails.Size = new System.Drawing.Size(35, 43);
            btnSendEmails.TabIndex = 4;
            toolTip1.SetToolTip(btnSendEmails, "Send Notification Email to Employee");
            btnSendEmails.UseVisualStyleBackColor = true;
            btnSendEmails.Click += btnSendEmails_Click;
            // 
            // btnHide
            // 
            btnHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHide.Image = (System.Drawing.Image)resources.GetObject("btnHide.Image");
            btnHide.Location = new System.Drawing.Point(142, 5);
            btnHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHide.Name = "btnHide";
            btnHide.Size = new System.Drawing.Size(32, 41);
            btnHide.TabIndex = 1;
            toolTip1.SetToolTip(btnHide, "Hide/Show Approved Travels");
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(123, 18);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(11, 15);
            label4.TabIndex = 0;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(66, 18);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(8, 15);
            label6.TabIndex = 5;
            label6.Text = "|";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblInfo.Location = new System.Drawing.Point(71, 38);
            lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(182, 13);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Sending Notification Emails.....";
            lblInfo.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_1229052;
            pictureBox1.Location = new System.Drawing.Point(22, 24);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(42, 40);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            backgroundWorker2.RunWorkerCompleted += backgroundWorker2_RunWorkerCompleted;
            // 
            // Admin
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1188, 625);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(pnCriteria);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Admin";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnCriteria.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblShowBy;
        private System.Windows.Forms.ComboBox cbtravels;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel pnCriteria;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccAprr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountingApproval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
    }
}