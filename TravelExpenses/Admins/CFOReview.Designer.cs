namespace TravelExpenses
{
    partial class CFOReview
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
            this.dgvEstimates = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCFOApproval = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEmailDirector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnView = new System.Windows.Forms.Button();
            this.lblEmailSending = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstimates
            // 
            this.dgvEstimates.AllowUserToAddRows = false;
            this.dgvEstimates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstimates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Return,
            this.Purpose,
            this.Event,
            this.Budgeted,
            this.User,
            this.EstimatedTotal,
            this.EstimatedID,
            this.UserID,
            this.Status});
            this.dgvEstimates.Location = new System.Drawing.Point(30, 91);
            this.dgvEstimates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEstimates.MultiSelect = false;
            this.dgvEstimates.Name = "dgvEstimates";
            this.dgvEstimates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstimates.Size = new System.Drawing.Size(1296, 474);
            this.dgvEstimates.TabIndex = 0;
            this.dgvEstimates.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvEstimates_CellBeginEdit);
            this.dgvEstimates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimates_CellClick);
            this.dgvEstimates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimates_CellContentClick);
            this.dgvEstimates.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimates_CellEndEdit);
            this.dgvEstimates.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstimates_CellMouseClick);
            this.dgvEstimates.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstimates_CellValueChanged);
            this.dgvEstimates.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEstimates_CurrentCellDirtyStateChanged);
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.Width = 80;
            // 
            // Return
            // 
            this.Return.HeaderText = "Return";
            this.Return.Name = "Return";
            this.Return.ReadOnly = true;
            this.Return.Width = 80;
            // 
            // Purpose
            // 
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            this.Purpose.Visible = false;
            this.Purpose.Width = 175;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Width = 175;
            // 
            // Budgeted
            // 
            this.Budgeted.HeaderText = "Budgeted";
            this.Budgeted.Name = "Budgeted";
            this.Budgeted.Width = 60;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.Width = 170;
            // 
            // EstimatedTotal
            // 
            this.EstimatedTotal.HeaderText = "Cost";
            this.EstimatedTotal.Name = "EstimatedTotal";
            this.EstimatedTotal.ReadOnly = true;
            this.EstimatedTotal.Width = 75;
            // 
            // EstimatedID
            // 
            this.EstimatedID.HeaderText = "EstimatedID";
            this.EstimatedID.Name = "EstimatedID";
            this.EstimatedID.Visible = false;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = false;
            // 
            // btnCFOApproval
            // 
            this.btnCFOApproval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCFOApproval.FlatAppearance.BorderSize = 0;
            this.btnCFOApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCFOApproval.Image = global::TravelExpenses.Properties.Resources.if_check_70974;
            this.btnCFOApproval.Location = new System.Drawing.Point(173, 5);
            this.btnCFOApproval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCFOApproval.Name = "btnCFOApproval";
            this.btnCFOApproval.Size = new System.Drawing.Size(49, 58);
            this.btnCFOApproval.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCFOApproval, "Mark Travel as Reviewd by CFO");
            this.btnCFOApproval.UseVisualStyleBackColor = true;
            this.btnCFOApproval.Click += new System.EventHandler(this.btnCFOApproval_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::TravelExpenses.Properties.Resources.if_Shutdown_Box_Red_34246;
            this.btnCancel.Location = new System.Drawing.Point(88, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(46, 54);
            this.btnCancel.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCancel, "Close");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEmailDirector
            // 
            this.btnEmailDirector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmailDirector.FlatAppearance.BorderSize = 0;
            this.btnEmailDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailDirector.Image = global::TravelExpenses.Properties.Resources.if_Apple_Mail_2697658;
            this.btnEmailDirector.Location = new System.Drawing.Point(4, 5);
            this.btnEmailDirector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmailDirector.Name = "btnEmailDirector";
            this.btnEmailDirector.Size = new System.Drawing.Size(48, 58);
            this.btnEmailDirector.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnEmailDirector, "Send Email for Director\'s Approval");
            this.btnEmailDirector.UseVisualStyleBackColor = true;
            this.btnEmailDirector.Visible = false;
            this.btnEmailDirector.Click += new System.EventHandler(this.btnEmailDirector_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Image = global::TravelExpenses.Properties.Resources.if_5_330396;
            this.btnView.Location = new System.Drawing.Point(262, 5);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(51, 57);
            this.btnView.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnView, "View Details");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblEmailSending
            // 
            this.lblEmailSending.AutoSize = true;
            this.lblEmailSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSending.Location = new System.Drawing.Point(96, 51);
            this.lblEmailSending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailSending.Name = "lblEmailSending";
            this.lblEmailSending.Size = new System.Drawing.Size(182, 13);
            this.lblEmailSending.TabIndex = 3;
            this.lblEmailSending.Text = "Sending Notification Emails.....";
            this.lblEmailSending.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelExpenses.Properties.Resources.image_1229052;
            this.pictureBox1.Location = new System.Drawing.Point(30, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tlpOptions
            // 
            this.tlpOptions.ColumnCount = 7;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.30159F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.61307F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.55276F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpOptions.Controls.Add(this.label1, 3, 0);
            this.tlpOptions.Controls.Add(this.label2, 1, 0);
            this.tlpOptions.Controls.Add(this.label3, 5, 0);
            this.tlpOptions.Controls.Add(this.btnView, 6, 0);
            this.tlpOptions.Controls.Add(this.btnCFOApproval, 4, 0);
            this.tlpOptions.Controls.Add(this.btnCancel, 2, 0);
            this.tlpOptions.Controls.Add(this.btnEmailDirector, 0, 0);
            this.tlpOptions.Location = new System.Drawing.Point(1020, 18);
            this.tlpOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 1;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Size = new System.Drawing.Size(323, 68);
            this.tlpOptions.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CFOReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 609);
            this.ControlBox = false;
            this.Controls.Add(this.tlpOptions);
            this.Controls.Add(this.lblEmailSending);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEstimates);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CFOReview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFO Travel Authorization Review";
            this.Load += new System.EventHandler(this.CFOReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstimates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstimates;
        private System.Windows.Forms.Button btnCFOApproval;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEmailDirector;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmailSending;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Budgeted;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}