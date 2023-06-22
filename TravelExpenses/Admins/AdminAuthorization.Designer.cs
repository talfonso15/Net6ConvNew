namespace TravelExpenses
{
    partial class AdminAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAuthorization));
            panel1 = new System.Windows.Forms.Panel();
            btnShow = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblEmployee = new System.Windows.Forms.Label();
            cbEmployee = new System.Windows.Forms.ComboBox();
            dgvAthorizations = new System.Windows.Forms.DataGridView();
            DepDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelTOtal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MileagePersonal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ApprovedBySupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnHideApproved = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnClose = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnView = new System.Windows.Forms.Button();
            btnApprEstimateDirector = new System.Windows.Forms.Button();
            btnPDF = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAthorizations).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new System.Drawing.Point(36, 28);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(726, 75);
            panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShow.Image = (System.Drawing.Image)resources.GetObject("btnShow.Image");
            btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShow.Location = new System.Drawing.Point(600, 15);
            btnShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(104, 45);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58963F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.41037F));
            tableLayoutPanel1.Controls.Add(lblEmployee, 0, 0);
            tableLayoutPanel1.Controls.Add(cbEmployee, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(30, 17);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(540, 38);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEmployee
            // 
            lblEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmployee.Location = new System.Drawing.Point(4, 11);
            lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new System.Drawing.Size(151, 15);
            lblEmployee.TabIndex = 0;
            lblEmployee.Text = "Select Employee:";
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(163, 7);
            cbEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(373, 23);
            cbEmployee.TabIndex = 1;
            // 
            // dgvAthorizations
            // 
            dgvAthorizations.AllowUserToAddRows = false;
            dgvAthorizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAthorizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DepDate, RetDate, Event, Purpose, Budgeted, User, TravelTOtal, TravelID, UserID, District, Department1, MileagePersonal, ApprovedBySupervisor });
            dgvAthorizations.Location = new System.Drawing.Point(30, 90);
            dgvAthorizations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvAthorizations.MultiSelect = false;
            dgvAthorizations.Name = "dgvAthorizations";
            dgvAthorizations.ReadOnly = true;
            dgvAthorizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAthorizations.Size = new System.Drawing.Size(916, 272);
            dgvAthorizations.TabIndex = 1;
            // 
            // DepDate
            // 
            DepDate.HeaderText = "Departure";
            DepDate.Name = "DepDate";
            DepDate.ReadOnly = true;
            DepDate.Width = 80;
            // 
            // RetDate
            // 
            RetDate.HeaderText = "Return";
            RetDate.Name = "RetDate";
            RetDate.ReadOnly = true;
            RetDate.Width = 80;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Width = 200;
            // 
            // Purpose
            // 
            Purpose.HeaderText = "Purpose";
            Purpose.Name = "Purpose";
            Purpose.ReadOnly = true;
            Purpose.Visible = false;
            Purpose.Width = 80;
            // 
            // Budgeted
            // 
            Budgeted.HeaderText = "Budgeted";
            Budgeted.Name = "Budgeted";
            Budgeted.ReadOnly = true;
            Budgeted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Budgeted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Budgeted.Width = 60;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 140;
            // 
            // TravelTOtal
            // 
            TravelTOtal.HeaderText = "Estimate Total";
            TravelTOtal.Name = "TravelTOtal";
            TravelTOtal.ReadOnly = true;
            TravelTOtal.Visible = false;
            // 
            // TravelID
            // 
            TravelID.HeaderText = "TravelID";
            TravelID.Name = "TravelID";
            TravelID.ReadOnly = true;
            TravelID.Visible = false;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Visible = false;
            // 
            // District
            // 
            District.HeaderText = "District";
            District.Name = "District";
            District.ReadOnly = true;
            District.Visible = false;
            // 
            // Department1
            // 
            Department1.HeaderText = "Department";
            Department1.Name = "Department1";
            Department1.ReadOnly = true;
            Department1.Visible = false;
            // 
            // MileagePersonal
            // 
            MileagePersonal.HeaderText = "MileagePersonal";
            MileagePersonal.Name = "MileagePersonal";
            MileagePersonal.ReadOnly = true;
            MileagePersonal.Visible = false;
            // 
            // ApprovedBySupervisor
            // 
            ApprovedBySupervisor.HeaderText = "Approved";
            ApprovedBySupervisor.Name = "ApprovedBySupervisor";
            ApprovedBySupervisor.ReadOnly = true;
            ApprovedBySupervisor.Visible = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(lblInfo);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(dgvAthorizations);
            panel2.Location = new System.Drawing.Point(36, 125);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(959, 379);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.6101F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38989F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.Controls.Add(btnHideApproved, 0, 0);
            tableLayoutPanel4.Controls.Add(label4, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(626, 29);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(69, 55);
            tableLayoutPanel4.TabIndex = 6;
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
            btnHideApproved.Size = new System.Drawing.Size(38, 48);
            btnHideApproved.TabIndex = 2;
            btnHideApproved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnHideApproved, "Hide Approved Authorization");
            btnHideApproved.UseVisualStyleBackColor = true;
            btnHideApproved.Visible = false;
            btnHideApproved.Click += btnHideApproved_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(51, 19);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(14, 17);
            label4.TabIndex = 3;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.15385F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.84615F));
            tableLayoutPanel3.Controls.Add(btnClose, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(876, 29);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(76, 55);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(25, 4);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(44, 46);
            btnClose.TabIndex = 3;
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnClose, "Close Window");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(4, 19);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(11, 17);
            label3.TabIndex = 4;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblInfo.Location = new System.Drawing.Point(74, 60);
            lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(176, 13);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Sending Email to Employee....";
            lblInfo.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_1229052;
            pictureBox1.Location = new System.Drawing.Point(30, 42);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(36, 43);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71137F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.43294F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71138F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.43294F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71138F));
            tableLayoutPanel2.Controls.Add(btnView, 4, 0);
            tableLayoutPanel2.Controls.Add(btnApprEstimateDirector, 2, 0);
            tableLayoutPanel2.Controls.Add(btnPDF, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 3, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(696, 29);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(180, 55);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnView
            // 
            btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnView.Image = (System.Drawing.Image)resources.GetObject("btnView.Image");
            btnView.Location = new System.Drawing.Point(136, 9);
            btnView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(40, 37);
            btnView.TabIndex = 0;
            btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnView, "View");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnApprEstimateDirector
            // 
            btnApprEstimateDirector.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnApprEstimateDirector.FlatAppearance.BorderSize = 0;
            btnApprEstimateDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApprEstimateDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnApprEstimateDirector.Image = (System.Drawing.Image)resources.GetObject("btnApprEstimateDirector.Image");
            btnApprEstimateDirector.Location = new System.Drawing.Point(70, 3);
            btnApprEstimateDirector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnApprEstimateDirector.Name = "btnApprEstimateDirector";
            btnApprEstimateDirector.Size = new System.Drawing.Size(38, 48);
            btnApprEstimateDirector.TabIndex = 1;
            btnApprEstimateDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnApprEstimateDirector, "Director Approval");
            btnApprEstimateDirector.UseVisualStyleBackColor = true;
            btnApprEstimateDirector.Click += btnApprEstimateDirector_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPDF.Image = (System.Drawing.Image)resources.GetObject("btnPDF.Image");
            btnPDF.Location = new System.Drawing.Point(4, 3);
            btnPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new System.Drawing.Size(38, 48);
            btnPDF.TabIndex = 2;
            btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnPDF, "Create PDF");
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(50, 19);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(12, 17);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(116, 19);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(12, 17);
            label2.TabIndex = 4;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // AdminAuthorization
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1040, 585);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AdminAuthorization";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Admin Authorization";
            FormClosed += AdminAuthorization_FormClosed;
            Load += AdminAuthorization_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAthorizations).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DataGridView dgvAthorizations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnApprEstimateDirector;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Budgeted;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelTOtal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MileagePersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBySupervisor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnHideApproved;
        private System.Windows.Forms.Label label4;
    }
}