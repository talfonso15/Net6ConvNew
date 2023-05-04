namespace TravelExpenses
{
    partial class Sync
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPublicationName = new System.Windows.Forms.Label();
            this.lblPublication = new System.Windows.Forms.Label();
            this.lblSubscriptionName = new System.Windows.Forms.Label();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.txtSyncDetails = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPublicationName);
            this.panel1.Controls.Add(this.lblPublication);
            this.panel1.Controls.Add(this.lblSubscriptionName);
            this.panel1.Controls.Add(this.lblSubscription);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblPublicationName
            // 
            this.lblPublicationName.AutoSize = true;
            this.lblPublicationName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPublicationName.Location = new System.Drawing.Point(166, 59);
            this.lblPublicationName.Name = "lblPublicationName";
            this.lblPublicationName.Size = new System.Drawing.Size(108, 17);
            this.lblPublicationName.TabIndex = 3;
            this.lblPublicationName.Text = "publication name";
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPublication.Location = new System.Drawing.Point(25, 59);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(120, 17);
            this.lblPublication.TabIndex = 2;
            this.lblPublication.Text = "Publication name:";
            // 
            // lblSubscriptionName
            // 
            this.lblSubscriptionName.AutoSize = true;
            this.lblSubscriptionName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubscriptionName.Location = new System.Drawing.Point(166, 21);
            this.lblSubscriptionName.Name = "lblSubscriptionName";
            this.lblSubscriptionName.Size = new System.Drawing.Size(115, 17);
            this.lblSubscriptionName.TabIndex = 1;
            this.lblSubscriptionName.Text = "subscription name";
            // 
            // lblSubscription
            // 
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSubscription.Location = new System.Drawing.Point(18, 21);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(127, 17);
            this.lblSubscription.TabIndex = 0;
            this.lblSubscription.Text = "Subscription name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbStatus);
            this.groupBox1.Controls.Add(this.txtSyncDetails);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sync Details";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(21, 169);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(331, 23);
            this.pbStatus.TabIndex = 1;
            // 
            // txtSyncDetails
            // 
            this.txtSyncDetails.Location = new System.Drawing.Point(21, 42);
            this.txtSyncDetails.Multiline = true;
            this.txtSyncDetails.Name = "txtSyncDetails";
            this.txtSyncDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSyncDetails.Size = new System.Drawing.Size(331, 108);
            this.txtSyncDetails.TabIndex = 0;
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSync.Image = global::TravelExpenses.Properties.Resources._1496097664_reload;
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(304, 363);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(77, 43);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Image = global::TravelExpenses.Properties.Resources._1493421169_Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(198, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 43);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // Sync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 417);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Sync";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sync";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubscription;
        private System.Windows.Forms.Label lblPublicationName;
        private System.Windows.Forms.Label lblPublication;
        private System.Windows.Forms.Label lblSubscriptionName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.TextBox txtSyncDetails;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnCancel;
    }
}