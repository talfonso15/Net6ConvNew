namespace TravelExpenses
{
    partial class ListAllTravels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAllTravels));
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnView = new System.Windows.Forms.Button();
            btnApprove = new System.Windows.Forms.Button();
            btnSummarizedPDF = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnInfo = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvAllTravels = new System.Windows.Forms.DataGridView();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TravelPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IDTravel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblSendingEmail = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAllTravels).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            // 
            // btnView
            // 
            btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Image = (System.Drawing.Image)resources.GetObject("btnView.Image");
            btnView.Location = new System.Drawing.Point(284, 7);
            btnView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(51, 72);
            btnView.TabIndex = 5;
            toolTip1.SetToolTip(btnView, "View Travel");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnApprove
            // 
            btnApprove.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApprove.Image = (System.Drawing.Image)resources.GetObject("btnApprove.Image");
            btnApprove.Location = new System.Drawing.Point(188, 7);
            btnApprove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new System.Drawing.Size(49, 72);
            btnApprove.TabIndex = 4;
            toolTip1.SetToolTip(btnApprove, "Approve Travel");
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnSummarizedPDF
            // 
            btnSummarizedPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSummarizedPDF.FlatAppearance.BorderSize = 0;
            btnSummarizedPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSummarizedPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSummarizedPDF.Image = (System.Drawing.Image)resources.GetObject("btnSummarizedPDF.Image");
            btnSummarizedPDF.Location = new System.Drawing.Point(97, 7);
            btnSummarizedPDF.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnSummarizedPDF.Name = "btnSummarizedPDF";
            btnSummarizedPDF.Size = new System.Drawing.Size(49, 72);
            btnSummarizedPDF.TabIndex = 2;
            btnSummarizedPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnSummarizedPDF, "Summarized PDF");
            btnSummarizedPDF.UseVisualStyleBackColor = true;
            btnSummarizedPDF.Click += btnSummarizedPDF_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new System.Drawing.Point(6, 7);
            btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(49, 72);
            btnCancel.TabIndex = 3;
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCancel, "Close");
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new System.Drawing.Point(20, 88);
            btnInfo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(34, 38);
            btnInfo.TabIndex = 7;
            toolTip1.SetToolTip(btnInfo, "Select a travel and then click on the option you want to perform on it:");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // dgvAllTravels
            // 
            dgvAllTravels.AllowUserToAddRows = false;
            dgvAllTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DepartureDate, ReturnDate, TravelEvent, TravelPurpose, Origin, Destination, Status, Total, IDTravel, Approved });
            dgvAllTravels.Location = new System.Drawing.Point(26, 133);
            dgvAllTravels.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            dgvAllTravels.Name = "dgvAllTravels";
            dgvAllTravels.ReadOnly = true;
            dgvAllTravels.RowHeadersWidth = 62;
            dgvAllTravels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAllTravels.Size = new System.Drawing.Size(1463, 597);
            dgvAllTravels.TabIndex = 0;
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "Departure Date";
            DepartureDate.MinimumWidth = 8;
            DepartureDate.Name = "DepartureDate";
            DepartureDate.ReadOnly = true;
            DepartureDate.Width = 180;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Return Date";
            ReturnDate.MinimumWidth = 8;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            ReturnDate.Width = 150;
            // 
            // TravelEvent
            // 
            TravelEvent.HeaderText = "Travel Event";
            TravelEvent.MinimumWidth = 8;
            TravelEvent.Name = "TravelEvent";
            TravelEvent.ReadOnly = true;
            TravelEvent.Width = 260;
            // 
            // TravelPurpose
            // 
            TravelPurpose.HeaderText = "Travel Purpose";
            TravelPurpose.MinimumWidth = 8;
            TravelPurpose.Name = "TravelPurpose";
            TravelPurpose.ReadOnly = true;
            TravelPurpose.Visible = false;
            TravelPurpose.Width = 120;
            // 
            // Origin
            // 
            Origin.HeaderText = "Origin";
            Origin.MinimumWidth = 8;
            Origin.Name = "Origin";
            Origin.ReadOnly = true;
            Origin.Visible = false;
            Origin.Width = 150;
            // 
            // Destination
            // 
            Destination.HeaderText = "Destination";
            Destination.MinimumWidth = 8;
            Destination.Name = "Destination";
            Destination.ReadOnly = true;
            Destination.Visible = false;
            Destination.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 80;
            // 
            // IDTravel
            // 
            IDTravel.HeaderText = "IDTravel";
            IDTravel.MinimumWidth = 8;
            IDTravel.Name = "IDTravel";
            IDTravel.ReadOnly = true;
            IDTravel.Visible = false;
            IDTravel.Width = 150;
            // 
            // Approved
            // 
            Approved.HeaderText = "Approved";
            Approved.MinimumWidth = 8;
            Approved.Name = "Approved";
            Approved.ReadOnly = true;
            Approved.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69911F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.849559F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69911F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.849559F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69911F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.849559F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35399F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 5, 0);
            tableLayoutPanel1.Controls.Add(btnApprove, 4, 0);
            tableLayoutPanel1.Controls.Add(btnView, 6, 0);
            tableLayoutPanel1.Controls.Add(btnSummarizedPDF, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(1134, 35);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(347, 87);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(67, 31);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(18, 25);
            label4.TabIndex = 7;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(158, 31);
            label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(18, 25);
            label6.TabIndex = 10;
            label6.Text = "|";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(249, 31);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(18, 25);
            label5.TabIndex = 8;
            label5.Text = "|";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(lblSendingEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnInfo);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(dgvAllTravels);
            panel1.Location = new System.Drawing.Point(26, 27);
            panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1531, 764);
            panel1.TabIndex = 3;
            // 
            // lblSendingEmail
            // 
            lblSendingEmail.AutoSize = true;
            lblSendingEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSendingEmail.Location = new System.Drawing.Point(150, 90);
            lblSendingEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblSendingEmail.Name = "lblSendingEmail";
            lblSendingEmail.Size = new System.Drawing.Size(266, 20);
            lblSendingEmail.TabIndex = 9;
            lblSendingEmail.Text = "Sending Notification Emails.....";
            lblSendingEmail.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_1229052;
            pictureBox1.Location = new System.Drawing.Point(89, 63);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(59, 67);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // ListAllTravels
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1571, 855);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "ListAllTravels";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "All My Expenses Report";
            FormClosed += ListAllTravels_FormClosed;
            Load += ListAllTravels_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllTravels).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvAllTravels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSummarizedPDF;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSendingEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approved;
    }
}