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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFOReview));
            dgvEstimates = new System.Windows.Forms.DataGridView();
            Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Budgeted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstimatedTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstimatedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnCFOApproval = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnEmailDirector = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnView = new System.Windows.Forms.Button();
            lblEmailSending = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvEstimates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEstimates
            // 
            dgvEstimates.AllowUserToAddRows = false;
            dgvEstimates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstimates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Departure, Return, Purpose, Event, Budgeted, User, EstimatedTotal, EstimatedID, UserID, Status });
            dgvEstimates.Location = new System.Drawing.Point(23, 68);
            dgvEstimates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvEstimates.MultiSelect = false;
            dgvEstimates.Name = "dgvEstimates";
            dgvEstimates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEstimates.Size = new System.Drawing.Size(1008, 356);
            dgvEstimates.TabIndex = 0;
            dgvEstimates.CellBeginEdit += dgvEstimates_CellBeginEdit;
            dgvEstimates.CellClick += dgvEstimates_CellClick;
            dgvEstimates.CellContentClick += dgvEstimates_CellContentClick;
            dgvEstimates.CellEndEdit += dgvEstimates_CellEndEdit;
            dgvEstimates.CellMouseClick += dgvEstimates_CellMouseClick;
            dgvEstimates.CellValueChanged += dgvEstimates_CellValueChanged;
            dgvEstimates.CurrentCellDirtyStateChanged += dgvEstimates_CurrentCellDirtyStateChanged;
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
            // Purpose
            // 
            Purpose.HeaderText = "Purpose";
            Purpose.Name = "Purpose";
            Purpose.ReadOnly = true;
            Purpose.Visible = false;
            Purpose.Width = 175;
            // 
            // Event
            // 
            Event.HeaderText = "Event";
            Event.Name = "Event";
            Event.ReadOnly = true;
            Event.Width = 175;
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
            User.Width = 170;
            // 
            // EstimatedTotal
            // 
            EstimatedTotal.HeaderText = "Cost";
            EstimatedTotal.Name = "EstimatedTotal";
            EstimatedTotal.ReadOnly = true;
            EstimatedTotal.Width = 75;
            // 
            // EstimatedID
            // 
            EstimatedID.HeaderText = "EstimatedID";
            EstimatedID.Name = "EstimatedID";
            EstimatedID.Visible = false;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.Visible = false;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Visible = false;
            // 
            // btnCFOApproval
            // 
            btnCFOApproval.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCFOApproval.FlatAppearance.BorderSize = 0;
            btnCFOApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCFOApproval.Image = (System.Drawing.Image)resources.GetObject("btnCFOApproval.Image");
            btnCFOApproval.Location = new System.Drawing.Point(132, 4);
            btnCFOApproval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCFOApproval.Name = "btnCFOApproval";
            btnCFOApproval.Size = new System.Drawing.Size(38, 43);
            btnCFOApproval.TabIndex = 1;
            toolTip1.SetToolTip(btnCFOApproval, "Mark Travel as Reviewd by CFO");
            btnCFOApproval.UseVisualStyleBackColor = true;
            btnCFOApproval.Click += btnCFOApproval_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new System.Drawing.Point(67, 5);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(35, 40);
            btnCancel.TabIndex = 2;
            toolTip1.SetToolTip(btnCancel, "Close");
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEmailDirector
            // 
            btnEmailDirector.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEmailDirector.FlatAppearance.BorderSize = 0;
            btnEmailDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEmailDirector.Image = (System.Drawing.Image)resources.GetObject("btnEmailDirector.Image");
            btnEmailDirector.Location = new System.Drawing.Point(3, 4);
            btnEmailDirector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEmailDirector.Name = "btnEmailDirector";
            btnEmailDirector.Size = new System.Drawing.Size(37, 43);
            btnEmailDirector.TabIndex = 0;
            toolTip1.SetToolTip(btnEmailDirector, "Send Email for Director's Approval");
            btnEmailDirector.UseVisualStyleBackColor = true;
            btnEmailDirector.Visible = false;
            btnEmailDirector.Click += btnEmailDirector_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(108, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 22);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(46, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(15, 22);
            label2.TabIndex = 4;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            // 
            // btnView
            // 
            btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Image = (System.Drawing.Image)resources.GetObject("btnView.Image");
            btnView.Location = new System.Drawing.Point(202, 4);
            btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(40, 43);
            btnView.TabIndex = 6;
            toolTip1.SetToolTip(btnView, "View Details");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // lblEmailSending
            // 
            lblEmailSending.AutoSize = true;
            lblEmailSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmailSending.Location = new System.Drawing.Point(75, 38);
            lblEmailSending.Name = "lblEmailSending";
            lblEmailSending.Size = new System.Drawing.Size(182, 13);
            lblEmailSending.TabIndex = 3;
            lblEmailSending.Text = "Sending Notification Emails.....";
            lblEmailSending.Visible = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_1229052;
            pictureBox1.Location = new System.Drawing.Point(23, 28);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(44, 41);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // tlpOptions
            // 
            tlpOptions.ColumnCount = 7;
            tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
            tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.30159F));
            tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.61307F));
            tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.55276F));
            tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tlpOptions.Controls.Add(label1, 3, 0);
            tlpOptions.Controls.Add(label2, 1, 0);
            tlpOptions.Controls.Add(label3, 5, 0);
            tlpOptions.Controls.Add(btnView, 6, 0);
            tlpOptions.Controls.Add(btnCFOApproval, 4, 0);
            tlpOptions.Controls.Add(btnCancel, 2, 0);
            tlpOptions.Controls.Add(btnEmailDirector, 0, 0);
            tlpOptions.Location = new System.Drawing.Point(793, 14);
            tlpOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlpOptions.Name = "tlpOptions";
            tlpOptions.RowCount = 1;
            tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpOptions.Size = new System.Drawing.Size(251, 51);
            tlpOptions.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(176, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(14, 22);
            label3.TabIndex = 5;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CFOReview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1052, 457);
            ControlBox = false;
            Controls.Add(tlpOptions);
            Controls.Add(lblEmailSending);
            Controls.Add(pictureBox1);
            Controls.Add(dgvEstimates);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "CFOReview";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CFO Travel Authorization Review";
            Load += CFOReview_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstimates).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpOptions.ResumeLayout(false);
            tlpOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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