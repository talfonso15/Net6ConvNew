namespace TravelExpenses
{
    partial class EditTravel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTravel));
            dgvTravels = new System.Windows.Forms.DataGridView();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnEditTravel = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            btnInfo = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvTravels).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTravels
            // 
            dgvTravels.AllowUserToAddRows = false;
            dgvTravels.AllowUserToDeleteRows = false;
            dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TravelID, DepartureDate, ReturnDate, TravelEvent, TravelPurpose, Origin, Destination });
            dgvTravels.Location = new System.Drawing.Point(13, 65);
            dgvTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvTravels.Name = "dgvTravels";
            dgvTravels.ReadOnly = true;
            dgvTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTravels.Size = new System.Drawing.Size(870, 410);
            dgvTravels.TabIndex = 1;
            // 
            // TravelID
            // 
            TravelID.HeaderText = "TravelID";
            TravelID.Name = "TravelID";
            TravelID.ReadOnly = true;
            TravelID.Visible = false;
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "Departure Date";
            DepartureDate.Name = "DepartureDate";
            DepartureDate.ReadOnly = true;
            DepartureDate.Width = 120;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Return Date";
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            // 
            // TravelEvent
            // 
            TravelEvent.HeaderText = "Travel Event";
            TravelEvent.Name = "TravelEvent";
            TravelEvent.ReadOnly = true;
            TravelEvent.Width = 120;
            // 
            // TravelPurpose
            // 
            TravelPurpose.HeaderText = "Travel Purpose";
            TravelPurpose.Name = "TravelPurpose";
            TravelPurpose.ReadOnly = true;
            TravelPurpose.Width = 120;
            // 
            // Origin
            // 
            Origin.HeaderText = "Origin";
            Origin.Name = "Origin";
            Origin.ReadOnly = true;
            Origin.Width = 120;
            // 
            // Destination
            // 
            Destination.HeaderText = "Destination";
            Destination.Name = "Destination";
            Destination.ReadOnly = true;
            Destination.Width = 120;
            // 
            // btnEditTravel
            // 
            btnEditTravel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEditTravel.FlatAppearance.BorderSize = 0;
            btnEditTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditTravel.Image = (System.Drawing.Image)resources.GetObject("btnEditTravel.Image");
            btnEditTravel.Location = new System.Drawing.Point(80, 5);
            btnEditTravel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditTravel.Name = "btnEditTravel";
            btnEditTravel.Size = new System.Drawing.Size(44, 39);
            btnEditTravel.TabIndex = 0;
            btnEditTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnEditTravel, "Edit Travel");
            btnEditTravel.UseVisualStyleBackColor = true;
            btnEditTravel.Click += btnEditTravel_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new System.Drawing.Point(4, 5);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(43, 39);
            btnCancel.TabIndex = 1;
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCancel, "Close");
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(btnEditTravel, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(750, 12);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(128, 50);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(55, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 17);
            label1.TabIndex = 2;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new System.Drawing.Point(13, 35);
            btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(27, 27);
            btnInfo.TabIndex = 3;
            toolTip1.SetToolTip(btnInfo, "Select the travel that you want to Edit and then select the edit button.");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 250;
            toolTip1.ReshowDelay = 100;
            // 
            // EditTravel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(892, 510);
            ControlBox = false;
            Controls.Add(btnInfo);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvTravels);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditTravel";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Travel";
            Load += EditTravel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTravels).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTravels;
        private System.Windows.Forms.Button btnEditTravel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}