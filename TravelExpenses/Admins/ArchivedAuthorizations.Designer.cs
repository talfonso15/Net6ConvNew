namespace TravelExpenses
{
    partial class ArchivedAuthorizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivedAuthorizations));
            dgvAthorizations = new System.Windows.Forms.DataGridView();
            Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstimatedTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MileagePersonal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnClose = new System.Windows.Forms.Button();
            btnPDF = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            cbEmployee = new System.Windows.Forms.ComboBox();
            lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvAthorizations).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAthorizations
            // 
            dgvAthorizations.AllowUserToAddRows = false;
            dgvAthorizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAthorizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Departure, Return, Event, Purpose, Budgeted, User, EstimatedTotal, TravelID, UserID, District, Department, MileagePersonal });
            dgvAthorizations.Location = new System.Drawing.Point(19, 66);
            dgvAthorizations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvAthorizations.Name = "dgvAthorizations";
            dgvAthorizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAthorizations.Size = new System.Drawing.Size(876, 584);
            dgvAthorizations.TabIndex = 0;
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
            Event.Width = 250;
            // 
            // Purpose
            // 
            Purpose.HeaderText = "Purpose";
            Purpose.Name = "Purpose";
            Purpose.Visible = false;
            // 
            // Budgeted
            // 
            Budgeted.HeaderText = "Budgeted";
            Budgeted.Name = "Budgeted";
            Budgeted.Width = 60;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            User.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            User.Width = 150;
            // 
            // EstimatedTotal
            // 
            EstimatedTotal.HeaderText = "Estimate Total";
            EstimatedTotal.Name = "EstimatedTotal";
            EstimatedTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            EstimatedTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            EstimatedTotal.Width = 80;
            // 
            // TravelID
            // 
            TravelID.HeaderText = "TravelID";
            TravelID.Name = "TravelID";
            TravelID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            TravelID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            TravelID.Visible = false;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.Visible = false;
            // 
            // District
            // 
            District.HeaderText = "District";
            District.Name = "District";
            District.Visible = false;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.Visible = false;
            // 
            // MileagePersonal
            // 
            MileagePersonal.HeaderText = "MileagePersonal";
            MileagePersonal.Name = "MileagePersonal";
            MileagePersonal.Visible = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(dgvAthorizations);
            panel1.Location = new System.Drawing.Point(24, 142);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(911, 667);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.42857F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.28571F));
            tableLayoutPanel1.Controls.Add(btnClose, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPDF, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(743, 7);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(152, 52);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(9, 3);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(44, 45);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPDF.Image = (System.Drawing.Image)resources.GetObject("btnPDF.Image");
            btnPDF.Location = new System.Drawing.Point(92, 3);
            btnPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new System.Drawing.Size(51, 45);
            btnPDF.TabIndex = 1;
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(66, 13);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 25);
            label1.TabIndex = 2;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(cbEmployee);
            panel2.Controls.Add(lblSearch);
            panel2.Location = new System.Drawing.Point(24, 76);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(611, 59);
            panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Image = (System.Drawing.Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new System.Drawing.Point(541, 8);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(51, 40);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbEmployee
            // 
            cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(172, 17);
            cbEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(336, 23);
            cbEmployee.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.Location = new System.Drawing.Point(15, 21);
            lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(118, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Select Employee:";
            // 
            // ArchivedAuthorizations
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(958, 831);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ArchivedAuthorizations";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Archived Authorizations";
            Load += ArchivedAuthorizations_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAthorizations).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAthorizations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Budgeted;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MileagePersonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnSearch;
    }
}