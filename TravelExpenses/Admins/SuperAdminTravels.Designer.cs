namespace TravelExpenses
{
    partial class SuperAdminTravels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminTravels));
            pnCriteria = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblShowBy = new System.Windows.Forms.Label();
            lblEmployee = new System.Windows.Forms.Label();
            lblDepartments = new System.Windows.Forms.Label();
            cbtravels = new System.Windows.Forms.ComboBox();
            cbEmployee = new System.Windows.Forms.ComboBox();
            cbDepartments = new System.Windows.Forms.ComboBox();
            btnShow = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnChangeStatus = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            btnPDF = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btnView = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            dgvTravels = new System.Windows.Forms.DataGridView();
            Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            pnCriteria.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).BeginInit();
            SuspendLayout();
            // 
            // pnCriteria
            // 
            pnCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnCriteria.Controls.Add(tableLayoutPanel1);
            pnCriteria.Controls.Add(btnShow);
            pnCriteria.Location = new System.Drawing.Point(27, 47);
            pnCriteria.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            pnCriteria.Name = "pnCriteria";
            pnCriteria.Size = new System.Drawing.Size(841, 166);
            pnCriteria.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.28685F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.71315F));
            tableLayoutPanel1.Controls.Add(lblShowBy, 0, 0);
            tableLayoutPanel1.Controls.Add(lblEmployee, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDepartments, 0, 2);
            tableLayoutPanel1.Controls.Add(cbtravels, 1, 0);
            tableLayoutPanel1.Controls.Add(cbEmployee, 1, 1);
            tableLayoutPanel1.Controls.Add(cbDepartments, 1, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(24, 17);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Size = new System.Drawing.Size(670, 132);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblShowBy
            // 
            lblShowBy.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblShowBy.AutoSize = true;
            lblShowBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblShowBy.Location = new System.Drawing.Point(5, 12);
            lblShowBy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblShowBy.Name = "lblShowBy";
            lblShowBy.Size = new System.Drawing.Size(179, 20);
            lblShowBy.TabIndex = 0;
            lblShowBy.Text = "Filter travels by:";
            // 
            // lblEmployee
            // 
            lblEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmployee.Location = new System.Drawing.Point(5, 57);
            lblEmployee.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new System.Drawing.Size(179, 18);
            lblEmployee.TabIndex = 1;
            lblEmployee.Text = "Select Employee:";
            // 
            // lblDepartments
            // 
            lblDepartments.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartments.AutoSize = true;
            lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDepartments.Location = new System.Drawing.Point(5, 101);
            lblDepartments.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDepartments.Name = "lblDepartments";
            lblDepartments.Size = new System.Drawing.Size(179, 18);
            lblDepartments.TabIndex = 2;
            lblDepartments.Text = "Select Department:";
            // 
            // cbtravels
            // 
            cbtravels.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbtravels.FormattingEnabled = true;
            cbtravels.Items.AddRange(new object[] { "All", "Department", "Employee" });
            cbtravels.Location = new System.Drawing.Point(194, 8);
            cbtravels.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cbtravels.Name = "cbtravels";
            cbtravels.Size = new System.Drawing.Size(471, 28);
            cbtravels.TabIndex = 3;
            cbtravels.SelectedIndexChanged += cbtravels_SelectedIndexChanged;
            // 
            // cbEmployee
            // 
            cbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(194, 52);
            cbEmployee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(471, 28);
            cbEmployee.TabIndex = 4;
            // 
            // cbDepartments
            // 
            cbDepartments.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Items.AddRange(new object[] { "Accounting/Purchasing 101", "Air/Flee/Bldg & Grounds 102", "Educ & Communication 103", "Executive 104", "Field Validation 105", "Mosquito Group 106", "Pilots 107", "Scientific Intelligence 108", "Hyacinth", "Commissioners" });
            cbDepartments.Location = new System.Drawing.Point(194, 96);
            cbDepartments.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new System.Drawing.Size(471, 28);
            cbDepartments.TabIndex = 5;
            // 
            // btnShow
            // 
            btnShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShow.Image = (System.Drawing.Image)resources.GetObject("btnShow.Image");
            btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShow.Location = new System.Drawing.Point(710, 109);
            btnShow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(121, 51);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(dgvTravels);
            panel2.Location = new System.Drawing.Point(27, 257);
            panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1328, 633);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78919F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263062F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78919F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263062F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78919F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.262537F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78906F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.265651F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78906F));
            tableLayoutPanel2.Controls.Add(btnChangeStatus, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClose, 8, 0);
            tableLayoutPanel2.Controls.Add(label3, 7, 0);
            tableLayoutPanel2.Controls.Add(btnPDF, 6, 0);
            tableLayoutPanel2.Controls.Add(label2, 5, 0);
            tableLayoutPanel2.Controls.Add(btnView, 4, 0);
            tableLayoutPanel2.Controls.Add(label1, 3, 0);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(930, 19);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(389, 63);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnChangeStatus.FlatAppearance.BorderSize = 0;
            btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChangeStatus.Image = (System.Drawing.Image)resources.GetObject("btnChangeStatus.Image");
            btnChangeStatus.Location = new System.Drawing.Point(5, 5);
            btnChangeStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new System.Drawing.Size(51, 53);
            btnChangeStatus.TabIndex = 8;
            toolTip1.SetToolTip(btnChangeStatus, "Change Status");
            btnChangeStatus.UseVisualStyleBackColor = true;
            btnChangeStatus.Visible = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(330, 5);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(53, 53);
            btnClose.TabIndex = 2;
            toolTip1.SetToolTip(btnClose, "Close");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(309, 21);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(10, 20);
            label3.TabIndex = 5;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPDF.Image = (System.Drawing.Image)resources.GetObject("btnPDF.Image");
            btnPDF.Location = new System.Drawing.Point(248, 5);
            btnPDF.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new System.Drawing.Size(51, 53);
            btnPDF.TabIndex = 1;
            toolTip1.SetToolTip(btnPDF, "Generate PDF");
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(228, 21);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(10, 20);
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
            btnView.Location = new System.Drawing.Point(167, 5);
            btnView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(51, 53);
            btnView.TabIndex = 0;
            toolTip1.SetToolTip(btnView, "View Details");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(147, 21);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(10, 20);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(66, 21);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(10, 20);
            label4.TabIndex = 7;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Image = (System.Drawing.Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new System.Drawing.Point(86, 5);
            btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(51, 53);
            btnDelete.TabIndex = 6;
            toolTip1.SetToolTip(btnDelete, "Delete Travel");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvTravels
            // 
            dgvTravels.AllowUserToAddRows = false;
            dgvTravels.AllowUserToResizeRows = false;
            dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Departure, Return, Event, Destination, Employee, Status, Total, TravelID, UserID });
            dgvTravels.Location = new System.Drawing.Point(24, 91);
            dgvTravels.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dgvTravels.MultiSelect = false;
            dgvTravels.Name = "dgvTravels";
            dgvTravels.ReadOnly = true;
            dgvTravels.RowHeadersWidth = 51;
            dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTravels.Size = new System.Drawing.Size(1278, 511);
            dgvTravels.TabIndex = 0;
            // 
            // Departure
            // 
            Departure.HeaderText = "Departure";
            Departure.MinimumWidth = 6;
            Departure.Name = "Departure";
            Departure.ReadOnly = true;
            Departure.Width = 80;
            // 
            // Return
            // 
            Return.HeaderText = "Return";
            Return.MinimumWidth = 6;
            Return.Name = "Return";
            Return.ReadOnly = true;
            Return.Width = 80;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.MinimumWidth = 6;
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Width = 250;
            // 
            // Destination
            // 
            Destination.HeaderText = "Destination";
            Destination.MinimumWidth = 6;
            Destination.Name = "Destination";
            Destination.ReadOnly = true;
            Destination.Width = 225;
            // 
            // Employee
            // 
            Employee.HeaderText = "Employee";
            Employee.MinimumWidth = 6;
            Employee.Name = "Employee";
            Employee.ReadOnly = true;
            Employee.Width = 140;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 70;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 60;
            // 
            // TravelID
            // 
            TravelID.HeaderText = "TravelID";
            TravelID.MinimumWidth = 6;
            TravelID.Name = "TravelID";
            TravelID.ReadOnly = true;
            TravelID.Visible = false;
            TravelID.Width = 125;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Visible = false;
            UserID.Width = 125;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            // 
            // SuperAdminTravels
            // 
            AcceptButton = btnShow;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1397, 928);
            Controls.Add(panel2);
            Controls.Add(pnCriteria);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuperAdminTravels";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Super Admin Travels";
            Load += SuperAdminTravels_Load;
            pnCriteria.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnCriteria;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblShowBy;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox cbtravels;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Label label4;
    }
}