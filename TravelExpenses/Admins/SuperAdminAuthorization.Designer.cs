namespace TravelExpenses
{
    partial class SuperAdminAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminAuthorization));
            panel1 = new System.Windows.Forms.Panel();
            btnShow = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblEmployee = new System.Windows.Forms.Label();
            cbEmployee = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            dgvAthorizations = new System.Windows.Forms.DataGridView();
            Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstimateTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MileagePersonal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnArchive = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnPDF = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btnView = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAthorizations).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new System.Drawing.Point(30, 50);
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
            btnShow.Location = new System.Drawing.Point(596, 17);
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
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.21382F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.78618F));
            tableLayoutPanel1.Controls.Add(lblEmployee, 0, 0);
            tableLayoutPanel1.Controls.Add(cbEmployee, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(28, 17);
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
            lblEmployee.Size = new System.Drawing.Size(138, 15);
            lblEmployee.TabIndex = 0;
            lblEmployee.Text = "Select Employee:";
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(150, 7);
            cbEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(386, 23);
            cbEmployee.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvAthorizations);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new System.Drawing.Point(30, 152);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(960, 504);
            panel2.TabIndex = 1;
            // 
            // dgvAthorizations
            // 
            dgvAthorizations.AllowUserToAddRows = false;
            dgvAthorizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAthorizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Departure, Return, Event, Purpose, Budgeted, User, EstimateTotal, TravelID, UserID, District, Department1, MileagePersonal });
            dgvAthorizations.Location = new System.Drawing.Point(27, 72);
            dgvAthorizations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvAthorizations.MultiSelect = false;
            dgvAthorizations.Name = "dgvAthorizations";
            dgvAthorizations.ReadOnly = true;
            dgvAthorizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAthorizations.Size = new System.Drawing.Size(910, 408);
            dgvAthorizations.TabIndex = 1;
            // 
            // Departure
            // 
            Departure.HeaderText = "Departure";
            Departure.Name = "Departure";
            Departure.ReadOnly = true;
            Departure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Departure.Width = 70;
            // 
            // Return
            // 
            Return.HeaderText = "Return";
            Return.Name = "Return";
            Return.ReadOnly = true;
            Return.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Return.Width = 70;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Width = 205;
            // 
            // Purpose
            // 
            Purpose.HeaderText = "Purpose";
            Purpose.Name = "Purpose";
            Purpose.ReadOnly = true;
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
            User.Width = 150;
            // 
            // EstimateTotal
            // 
            EstimateTotal.HeaderText = "Estimate Total";
            EstimateTotal.Name = "EstimateTotal";
            EstimateTotal.ReadOnly = true;
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
            Department1.HeaderText = "Department1";
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85631F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.285436F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85631F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.285436F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85631F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.232582F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.69774F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.234442F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.69542F));
            tableLayoutPanel2.Controls.Add(btnArchive, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 3, 0);
            tableLayoutPanel2.Controls.Add(btnClose, 8, 0);
            tableLayoutPanel2.Controls.Add(label1, 7, 0);
            tableLayoutPanel2.Controls.Add(btnPDF, 6, 0);
            tableLayoutPanel2.Controls.Add(label2, 5, 0);
            tableLayoutPanel2.Controls.Add(btnView, 4, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(596, 13);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(351, 52);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnArchive.FlatAppearance.BorderSize = 0;
            btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnArchive.Image = (System.Drawing.Image)resources.GetObject("btnArchive.Image");
            btnArchive.Location = new System.Drawing.Point(4, 3);
            btnArchive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new System.Drawing.Size(47, 45);
            btnArchive.TabIndex = 6;
            toolTip1.SetToolTip(btnArchive, "Archive Authorization");
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Visible = false;
            btnArchive.Click += btnArchive_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(132, 17);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(10, 17);
            label4.TabIndex = 7;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(298, 4);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(46, 44);
            btnClose.TabIndex = 2;
            toolTip1.SetToolTip(btnClose, "Close");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(278, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(10, 17);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPDF.Image = (System.Drawing.Image)resources.GetObject("btnPDF.Image");
            btnPDF.Location = new System.Drawing.Point(223, 4);
            btnPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new System.Drawing.Size(46, 44);
            btnPDF.TabIndex = 1;
            toolTip1.SetToolTip(btnPDF, "PDF");
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(205, 17);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(10, 17);
            label2.TabIndex = 4;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Image = (System.Drawing.Image)resources.GetObject("btnView.Image");
            btnView.Location = new System.Drawing.Point(150, 3);
            btnView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(47, 45);
            btnView.TabIndex = 0;
            toolTip1.SetToolTip(btnView, "View Details");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Image = (System.Drawing.Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new System.Drawing.Point(77, 3);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(47, 45);
            btnDelete.TabIndex = 8;
            toolTip1.SetToolTip(btnDelete, "Delete Authorization");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(59, 17);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(10, 17);
            label3.TabIndex = 5;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            // 
            // SuperAdminAuthorization
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1024, 670);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperAdminAuthorization";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Super Admin Authorization";
            Load += SuperAdminAuthorization_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAthorizations).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAthorizations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Budgeted;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MileagePersonal;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
    }
}