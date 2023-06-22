namespace TravelExpenses
{
    partial class ArchivedTravels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivedTravels));
            dgvArchivedTravels = new System.Windows.Forms.DataGridView();
            Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Pupose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnClose = new System.Windows.Forms.Button();
            btnPDF = new System.Windows.Forms.Button();
            lblSeparator = new System.Windows.Forms.Label();
            pnSearch = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            cbEmployee = new System.Windows.Forms.ComboBox();
            lblSearch = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvArchivedTravels).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnSearch.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvArchivedTravels
            // 
            dgvArchivedTravels.AllowUserToAddRows = false;
            dgvArchivedTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchivedTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Departure, Return, Event, Pupose, Status, Origin, Destination, Total, TravelID, UserID, User, Approved });
            dgvArchivedTravels.Location = new System.Drawing.Point(33, 152);
            dgvArchivedTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvArchivedTravels.MultiSelect = false;
            dgvArchivedTravels.Name = "dgvArchivedTravels";
            dgvArchivedTravels.ReadOnly = true;
            dgvArchivedTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvArchivedTravels.Size = new System.Drawing.Size(855, 674);
            dgvArchivedTravels.TabIndex = 0;
            // 
            // Departure
            // 
            Departure.HeaderText = "Departure";
            Departure.Name = "Departure";
            Departure.ReadOnly = true;
            Departure.Width = 80;
            // 
            // Return
            // 
            Return.HeaderText = "Return";
            Return.Name = "Return";
            Return.ReadOnly = true;
            Return.Width = 80;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Width = 200;
            // 
            // Pupose
            // 
            Pupose.HeaderText = "Purpose";
            Pupose.Name = "Pupose";
            Pupose.ReadOnly = true;
            Pupose.Visible = false;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Visible = false;
            Status.Width = 80;
            // 
            // Origin
            // 
            Origin.HeaderText = "Origin";
            Origin.Name = "Origin";
            Origin.ReadOnly = true;
            Origin.Visible = false;
            // 
            // Destination
            // 
            Destination.HeaderText = "Destination";
            Destination.Name = "Destination";
            Destination.ReadOnly = true;
            Destination.Visible = false;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Visible = false;
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
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 150;
            // 
            // Approved
            // 
            Approved.HeaderText = "Approved by Accounting";
            Approved.Name = "Approved";
            Approved.ReadOnly = true;
            Approved.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.60584F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            tableLayoutPanel1.Controls.Add(btnClose, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPDF, 2, 0);
            tableLayoutPanel1.Controls.Add(lblSeparator, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(9, 7);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(128, 43);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(4, 3);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(44, 36);
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
            btnPDF.Location = new System.Drawing.Point(79, 3);
            btnPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new System.Drawing.Size(45, 36);
            btnPDF.TabIndex = 1;
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // lblSeparator
            // 
            lblSeparator.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSeparator.AutoSize = true;
            lblSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSeparator.Location = new System.Drawing.Point(56, 9);
            lblSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSeparator.Name = "lblSeparator";
            lblSeparator.Size = new System.Drawing.Size(15, 25);
            lblSeparator.TabIndex = 2;
            lblSeparator.Text = "|";
            lblSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnSearch
            // 
            pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnSearch.Controls.Add(btnSearch);
            pnSearch.Controls.Add(cbEmployee);
            pnSearch.Controls.Add(lblSearch);
            pnSearch.Location = new System.Drawing.Point(33, 88);
            pnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new System.Drawing.Size(505, 57);
            pnSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Image = (System.Drawing.Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new System.Drawing.Point(443, 12);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(56, 40);
            btnSearch.TabIndex = 2;
            btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbEmployee
            // 
            cbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(188, 20);
            cbEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(236, 23);
            cbEmployee.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.Location = new System.Drawing.Point(15, 21);
            lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(133, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Select Employee:";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new System.Drawing.Point(740, 88);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(147, 57);
            panel1.TabIndex = 3;
            // 
            // ArchivedTravels
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(923, 861);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pnSearch);
            Controls.Add(dgvArchivedTravels);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ArchivedTravels";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Archived Travels";
            Load += ArchivedTravels_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchivedTravels).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivedTravels;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pupose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approved;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
    }
}