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
            this.components = new System.ComponentModel.Container();
            this.dtgTravels = new System.Windows.Forms.DataGridView();
            this.TravelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTravelItem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelAddItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTravels)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTravels
            // 
            this.dtgTravels.AllowUserToAddRows = false;
            this.dtgTravels.AllowUserToDeleteRows = false;
            this.dtgTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TravelID,
            this.DepartureDate,
            this.ReturnDate,
            this.TravelEvent,
            this.TravelPurpose,
            this.Origin,
            this.Destination});
            this.dtgTravels.Location = new System.Drawing.Point(12, 57);
            this.dtgTravels.Name = "dtgTravels";
            this.dtgTravels.ReadOnly = true;
            this.dtgTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTravels.Size = new System.Drawing.Size(684, 245);
            this.dtgTravels.TabIndex = 1;
            // 
            // TravelID
            // 
            this.TravelID.HeaderText = "TravelID";
            this.TravelID.Name = "TravelID";
            this.TravelID.ReadOnly = true;
            this.TravelID.Visible = false;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure Date";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Width = 120;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // TravelEvent
            // 
            this.TravelEvent.HeaderText = "Travel Event";
            this.TravelEvent.Name = "TravelEvent";
            this.TravelEvent.ReadOnly = true;
            // 
            // TravelPurpose
            // 
            this.TravelPurpose.HeaderText = "Travel Purpose";
            this.TravelPurpose.Name = "TravelPurpose";
            this.TravelPurpose.ReadOnly = true;
            this.TravelPurpose.Width = 120;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // btnAddTravelItem
            // 
            this.btnAddTravelItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTravelItem.FlatAppearance.BorderSize = 0;
            this.btnAddTravelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTravelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTravelItem.Image = global::TravelExpenses.Properties.Resources.if_add1__32378__1_;
            this.btnAddTravelItem.Location = new System.Drawing.Point(60, 3);
            this.btnAddTravelItem.Name = "btnAddTravelItem";
            this.btnAddTravelItem.Size = new System.Drawing.Size(35, 33);
            this.btnAddTravelItem.TabIndex = 2;
            this.btnAddTravelItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddTravelItem, "Add Item to Travel");
            this.btnAddTravelItem.UseVisualStyleBackColor = true;
            this.btnAddTravelItem.Click += new System.EventHandler(this.btnAddTravelItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34694F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelAddItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddTravelItem, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(598, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(98, 39);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnCancelAddItems
            // 
            this.btnCancelAddItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelAddItems.FlatAppearance.BorderSize = 0;
            this.btnCancelAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddItems.Image = global::TravelExpenses.Properties.Resources.if_Shutdown_Box_Red_34246;
            this.btnCancelAddItems.Location = new System.Drawing.Point(3, 3);
            this.btnCancelAddItems.Name = "btnCancelAddItems";
            this.btnCancelAddItems.Size = new System.Drawing.Size(34, 33);
            this.btnCancelAddItems.TabIndex = 3;
            this.btnCancelAddItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCancelAddItems, "Close");
            this.btnCancelAddItems.UseVisualStyleBackColor = true;
            this.btnCancelAddItems.Click += new System.EventHandler(this.btnCancelAddItems_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(6, 33);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 20);
            this.btnInfo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnInfo, "Select a travel from the list and then click on the add button");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // AddTravelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 336);
            this.ControlBox = false;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dtgTravels);
            this.Name = "AddTravelItem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Travel Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTravelItem_FormClosed);
            this.Load += new System.EventHandler(this.AddTravelItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTravels)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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