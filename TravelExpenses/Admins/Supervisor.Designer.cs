namespace TravelExpenses
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            panel1 = new System.Windows.Forms.Panel();
            btnShowTravels = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblSelectEmployee = new System.Windows.Forms.Label();
            cbEmployee = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnFinalizeTravel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnClose = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dgvTravels = new System.Windows.Forms.DataGridView();
            Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SupervisorApproval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            btnHideApproved = new System.Windows.Forms.Button();
            btnPDF = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnView = new System.Windows.Forms.Button();
            btnSupervisorAppr = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShowTravels);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new System.Drawing.Point(33, 28);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(616, 64);
            panel1.TabIndex = 0;
            // 
            // btnShowTravels
            // 
            btnShowTravels.FlatAppearance.BorderSize = 0;
            btnShowTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowTravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShowTravels.Image = (System.Drawing.Image)resources.GetObject("btnShowTravels.Image");
            btnShowTravels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShowTravels.Location = new System.Drawing.Point(456, 12);
            btnShowTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShowTravels.Name = "btnShowTravels";
            btnShowTravels.Size = new System.Drawing.Size(142, 45);
            btnShowTravels.TabIndex = 1;
            btnShowTravels.Text = "Show Travels";
            btnShowTravels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnShowTravels.UseVisualStyleBackColor = true;
            btnShowTravels.Click += btnShowTravels_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.94479F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05521F));
            tableLayoutPanel1.Controls.Add(lblSelectEmployee, 0, 0);
            tableLayoutPanel1.Controls.Add(cbEmployee, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(24, 15);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(380, 32);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSelectEmployee
            // 
            lblSelectEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSelectEmployee.AutoSize = true;
            lblSelectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSelectEmployee.Location = new System.Drawing.Point(4, 8);
            lblSelectEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSelectEmployee.Name = "lblSelectEmployee";
            lblSelectEmployee.Size = new System.Drawing.Size(155, 15);
            lblSelectEmployee.TabIndex = 0;
            lblSelectEmployee.Text = "Select Employee:";
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(167, 4);
            cbEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(209, 23);
            cbEmployee.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(lblInfo);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(dgvTravels);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new System.Drawing.Point(33, 114);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1092, 394);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.51724F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.Controls.Add(btnFinalizeTravel, 0, 0);
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(650, 20);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(72, 51);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // btnFinalizeTravel
            // 
            btnFinalizeTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnFinalizeTravel.FlatAppearance.BorderSize = 0;
            btnFinalizeTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFinalizeTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnFinalizeTravel.Image = (System.Drawing.Image)resources.GetObject("btnFinalizeTravel.Image");
            btnFinalizeTravel.Location = new System.Drawing.Point(5, 3);
            btnFinalizeTravel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFinalizeTravel.Name = "btnFinalizeTravel";
            btnFinalizeTravel.Size = new System.Drawing.Size(37, 44);
            btnFinalizeTravel.TabIndex = 2;
            btnFinalizeTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnFinalizeTravel, "Finalize travel");
            btnFinalizeTravel.UseVisualStyleBackColor = true;
            btnFinalizeTravel.Visible = false;
            btnFinalizeTravel.Click += btnFinalizeTravel_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(51, 13);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.80769F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.19231F));
            tableLayoutPanel3.Controls.Add(btnClose, 1, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(1006, 20);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tableLayoutPanel3.Size = new System.Drawing.Size(76, 51);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(26, 5);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(46, 40);
            btnClose.TabIndex = 3;
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnClose, "Close Window");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(4, 13);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(14, 25);
            label4.TabIndex = 0;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblInfo.Location = new System.Drawing.Point(78, 50);
            lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(186, 13);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Sending Notification Emails......";
            lblInfo.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_1229052;
            pictureBox1.Location = new System.Drawing.Point(31, 32);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(42, 38);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // dgvTravels
            // 
            dgvTravels.AllowUserToAddRows = false;
            dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Departure, Return, Event, Purpose, Status, Origin, TravelDest, Total, TravelID, UserID, User, UserDepartment, SupervisorApproval });
            dgvTravels.Location = new System.Drawing.Point(31, 77);
            dgvTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvTravels.Name = "dgvTravels";
            dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTravels.Size = new System.Drawing.Size(1040, 291);
            dgvTravels.TabIndex = 0;
            // 
            // Departure
            // 
            Departure.HeaderText = "Departure";
            Departure.Name = "Departure";
            Departure.Width = 80;
            // 
            // Return
            // 
            Return.HeaderText = "Return";
            Return.Name = "Return";
            Return.Width = 80;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.Name = "Event";
            Event.Width = 120;
            // 
            // Purpose
            // 
            Purpose.HeaderText = "Purpose";
            Purpose.Name = "Purpose";
            Purpose.Visible = false;
            Purpose.Width = 120;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Visible = false;
            Status.Width = 80;
            // 
            // Origin
            // 
            Origin.HeaderText = "Origin";
            Origin.Name = "Origin";
            Origin.Visible = false;
            Origin.Width = 120;
            // 
            // TravelDest
            // 
            TravelDest.HeaderText = "Destination";
            TravelDest.Name = "TravelDest";
            TravelDest.Visible = false;
            TravelDest.Width = 120;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 60;
            // 
            // TravelID
            // 
            TravelID.HeaderText = "TravelID";
            TravelID.Name = "TravelID";
            TravelID.Visible = false;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.Visible = false;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            // 
            // UserDepartment
            // 
            UserDepartment.HeaderText = "Department";
            UserDepartment.Name = "UserDepartment";
            UserDepartment.Visible = false;
            // 
            // SupervisorApproval
            // 
            SupervisorApproval.HeaderText = "Approved";
            SupervisorApproval.Name = "SupervisorApproval";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.01408F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.98592F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(btnHideApproved, 0, 0);
            tableLayoutPanel2.Controls.Add(btnPDF, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 3, 0);
            tableLayoutPanel2.Controls.Add(label3, 5, 0);
            tableLayoutPanel2.Controls.Add(btnView, 6, 0);
            tableLayoutPanel2.Controls.Add(btnSupervisorAppr, 4, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(722, 20);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(282, 51);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(61, 13);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(17, 25);
            label5.TabIndex = 3;
            label5.Text = "|";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHideApproved
            // 
            btnHideApproved.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnHideApproved.FlatAppearance.BorderSize = 0;
            btnHideApproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHideApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHideApproved.Image = (System.Drawing.Image)resources.GetObject("btnHideApproved.Image");
            btnHideApproved.Location = new System.Drawing.Point(4, 3);
            btnHideApproved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHideApproved.Name = "btnHideApproved";
            btnHideApproved.Size = new System.Drawing.Size(49, 44);
            btnHideApproved.TabIndex = 2;
            toolTip1.SetToolTip(btnHideApproved, "Hide Approved Travels");
            btnHideApproved.UseVisualStyleBackColor = true;
            btnHideApproved.Click += btnHideApproved_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPDF.Image = (System.Drawing.Image)resources.GetObject("btnPDF.Image");
            btnPDF.Location = new System.Drawing.Point(86, 3);
            btnPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new System.Drawing.Size(33, 44);
            btnPDF.TabIndex = 1;
            btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnPDF, "Generate PDF");
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(127, 13);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(18, 25);
            label2.TabIndex = 4;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(210, 13);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(16, 25);
            label3.TabIndex = 5;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnView.Image = (System.Drawing.Image)resources.GetObject("btnView.Image");
            btnView.Location = new System.Drawing.Point(234, 3);
            btnView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(44, 44);
            btnView.TabIndex = 0;
            btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnView, "View Travel Details");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnSupervisorAppr
            // 
            btnSupervisorAppr.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSupervisorAppr.FlatAppearance.BorderSize = 0;
            btnSupervisorAppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSupervisorAppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSupervisorAppr.Image = (System.Drawing.Image)resources.GetObject("btnSupervisorAppr.Image");
            btnSupervisorAppr.Location = new System.Drawing.Point(156, 3);
            btnSupervisorAppr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSupervisorAppr.Name = "btnSupervisorAppr";
            btnSupervisorAppr.Size = new System.Drawing.Size(43, 44);
            btnSupervisorAppr.TabIndex = 6;
            btnSupervisorAppr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnSupervisorAppr, "Supervisor Approval");
            btnSupervisorAppr.UseVisualStyleBackColor = true;
            btnSupervisorAppr.Click += btnSupervisorAppr_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Supervisor
            // 
            AcceptButton = btnShowTravels;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1141, 603);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Supervisor";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Tag = "-";
            Text = "  ";
            FormClosed += Supervisor_FormClosed;
            Load += Supervisor_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnShowTravels;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnFinalizeTravel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupervisorAppr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupervisorApproval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHideApproved;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
private System.Windows.Forms.DataGridViewTextBoxColumn Status;
private System.Windows.Forms.DataGridViewTextBoxColumn Origin;*/
    }
}