namespace TravelExpenses
{
    partial class AddTravelItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTravelItem));
            dtgTravels = new System.Windows.Forms.DataGridView();
            TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAddTravelItem = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnCancelAddItems = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnInfo = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dtgTravels).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgTravels
            // 
            dtgTravels.AllowUserToAddRows = false;
            dtgTravels.AllowUserToDeleteRows = false;
            dtgTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TravelID, DepartureDate, ReturnDate, TravelEvent, TravelPurpose, Origin, Destination });
            dtgTravels.Location = new System.Drawing.Point(14, 66);
            dtgTravels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtgTravels.Name = "dtgTravels";
            dtgTravels.ReadOnly = true;
            dtgTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgTravels.Size = new System.Drawing.Size(798, 283);
            dtgTravels.TabIndex = 1;
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
            // 
            // Destination
            // 
            Destination.HeaderText = "Destination";
            Destination.Name = "Destination";
            Destination.ReadOnly = true;
            // 
            // btnAddTravelItem
            // 
            btnAddTravelItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddTravelItem.FlatAppearance.BorderSize = 0;
            btnAddTravelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddTravelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddTravelItem.Image = (System.Drawing.Image)resources.GetObject("btnAddTravelItem.Image");
            btnAddTravelItem.Location = new System.Drawing.Point(71, 3);
            btnAddTravelItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddTravelItem.Name = "btnAddTravelItem";
            btnAddTravelItem.Size = new System.Drawing.Size(39, 38);
            btnAddTravelItem.TabIndex = 2;
            btnAddTravelItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnAddTravelItem, "Add Item to Travel");
            btnAddTravelItem.UseVisualStyleBackColor = true;
            btnAddTravelItem.Click += btnAddTravelItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34694F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(btnCancelAddItems, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAddTravelItem, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(698, 17);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(114, 45);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnCancelAddItems
            // 
            btnCancelAddItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelAddItems.FlatAppearance.BorderSize = 0;
            btnCancelAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelAddItems.Image = (System.Drawing.Image)resources.GetObject("btnCancelAddItems.Image");
            btnCancelAddItems.Location = new System.Drawing.Point(4, 3);
            btnCancelAddItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelAddItems.Name = "btnCancelAddItems";
            btnCancelAddItems.Size = new System.Drawing.Size(39, 38);
            btnCancelAddItems.TabIndex = 3;
            btnCancelAddItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCancelAddItems, "Close");
            btnCancelAddItems.UseVisualStyleBackColor = true;
            btnCancelAddItems.Click += btnCancelAddItems_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(51, 14);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(12, 17);
            label1.TabIndex = 4;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new System.Drawing.Point(7, 38);
            btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(29, 23);
            btnInfo.TabIndex = 4;
            toolTip1.SetToolTip(btnInfo, "Select a travel from the list and then click on the add button");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 250;
            // 
            // AddTravelItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(826, 388);
            ControlBox = false;
            Controls.Add(btnInfo);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dtgTravels);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddTravelItem";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add Travel Item";
            FormClosed += AddTravelItem_FormClosed;
            Load += AddTravelItem_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTravels).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dtgTravels;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.Button btnAddTravelItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancelAddItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnInfo;
    }
}