namespace TravelExpenses
{
    partial class EditThirdPartyTravel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditThirdPartyTravel));
            panel1 = new System.Windows.Forms.Panel();
            btnShowTravels = new System.Windows.Forms.Button();
            cbEmployee = new System.Windows.Forms.ComboBox();
            lblEmployees = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnClose = new System.Windows.Forms.Button();
            btnEditTravel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dgvTravels = new System.Windows.Forms.DataGridView();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnShowTravels);
            panel1.Controls.Add(cbEmployee);
            panel1.Controls.Add(lblEmployees);
            panel1.Location = new System.Drawing.Point(49, 30);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(592, 68);
            panel1.TabIndex = 0;
            // 
            // btnShowTravels
            // 
            btnShowTravels.FlatAppearance.BorderSize = 0;
            btnShowTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowTravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShowTravels.Image = (System.Drawing.Image)resources.GetObject("btnShowTravels.Image");
            btnShowTravels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShowTravels.Location = new System.Drawing.Point(441, 14);
            btnShowTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShowTravels.Name = "btnShowTravels";
            btnShowTravels.Size = new System.Drawing.Size(125, 47);
            btnShowTravels.TabIndex = 2;
            btnShowTravels.Text = "Show Travels";
            btnShowTravels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnShowTravels.UseVisualStyleBackColor = true;
            btnShowTravels.Click += btnShowTravels_Click;
            // 
            // cbEmployee
            // 
            cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new System.Drawing.Point(168, 24);
            cbEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new System.Drawing.Size(243, 23);
            cbEmployee.TabIndex = 1;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmployees.Location = new System.Drawing.Point(30, 28);
            lblEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new System.Drawing.Size(105, 13);
            lblEmployees.TabIndex = 0;
            lblEmployees.Text = "Select Employee:";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(dgvTravels);
            panel2.Location = new System.Drawing.Point(49, 127);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(693, 349);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.71429F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28572F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tableLayoutPanel1.Controls.Add(btnClose, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEditTravel, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(540, 3);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(142, 47);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(84, 3);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(54, 40);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEditTravel
            // 
            btnEditTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEditTravel.FlatAppearance.BorderSize = 0;
            btnEditTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditTravel.Image = (System.Drawing.Image)resources.GetObject("btnEditTravel.Image");
            btnEditTravel.Location = new System.Drawing.Point(4, 3);
            btnEditTravel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditTravel.Name = "btnEditTravel";
            btnEditTravel.Size = new System.Drawing.Size(53, 40);
            btnEditTravel.TabIndex = 1;
            btnEditTravel.UseVisualStyleBackColor = true;
            btnEditTravel.Click += btnEditTravel_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(65, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(11, 17);
            label1.TabIndex = 2;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTravels
            // 
            dgvTravels.AllowUserToAddRows = false;
            dgvTravels.AllowUserToDeleteRows = false;
            dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DepartureDate, ReturnDate, Event, UserName, TravelID, UserID });
            dgvTravels.Location = new System.Drawing.Point(20, 57);
            dgvTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvTravels.MultiSelect = false;
            dgvTravels.Name = "dgvTravels";
            dgvTravels.ReadOnly = true;
            dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTravels.Size = new System.Drawing.Size(651, 275);
            dgvTravels.TabIndex = 0;
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "Departure";
            DepartureDate.Name = "DepartureDate";
            DepartureDate.ReadOnly = true;
            DepartureDate.Width = 80;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Return";
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            ReturnDate.Width = 80;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Width = 200;
            // 
            // UserName
            // 
            UserName.HeaderText = "User";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 150;
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
            // EditThirdPartyTravel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(780, 501);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditThirdPartyTravel";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Third Party Travel";
            Load += EditThirdPartyTravel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTravels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button btnShowTravels;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditTravel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
    }
}