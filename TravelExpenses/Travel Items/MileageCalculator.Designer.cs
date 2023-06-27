namespace TravelExpenses
{
    partial class MileageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MileageCalculator));
            panel2 = new System.Windows.Forms.Panel();
            lblInformation = new System.Windows.Forms.Label();
            txtMileage = new System.Windows.Forms.TextBox();
            lblMileageEstimated = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnCalculateMileageCost = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblCurrentMileageRate = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(lblInformation);
            panel2.Controls.Add(txtMileage);
            panel2.Controls.Add(lblMileageEstimated);
            panel2.Location = new System.Drawing.Point(24, 19);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(325, 60);
            panel2.TabIndex = 1;
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblInformation.ForeColor = System.Drawing.Color.Red;
            lblInformation.Location = new System.Drawing.Point(279, 20);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new System.Drawing.Size(16, 15);
            lblInformation.TabIndex = 2;
            lblInformation.Text = "?";
            toolTip1.SetToolTip(lblInformation, "Estimate Mileage x Current Mileage Rate");
            // 
            // txtMileage
            // 
            txtMileage.Location = new System.Drawing.Point(147, 17);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new System.Drawing.Size(124, 20);
            txtMileage.TabIndex = 1;
            txtMileage.KeyPress += txtMileage_KeyPress;
            // 
            // lblMileageEstimated
            // 
            lblMileageEstimated.AutoSize = true;
            lblMileageEstimated.Location = new System.Drawing.Point(14, 20);
            lblMileageEstimated.Name = "lblMileageEstimated";
            lblMileageEstimated.Size = new System.Drawing.Size(114, 13);
            lblMileageEstimated.TabIndex = 0;
            lblMileageEstimated.Text = "Estimated Mileage:";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 5;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "The Mileage Cost =";
            // 
            // btnCalculateMileageCost
            // 
            btnCalculateMileageCost.FlatAppearance.BorderSize = 0;
            btnCalculateMileageCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalculateMileageCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCalculateMileageCost.Image = (System.Drawing.Image)resources.GetObject("btnCalculateMileageCost.Image");
            btnCalculateMileageCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCalculateMileageCost.Location = new System.Drawing.Point(358, 25);
            btnCalculateMileageCost.Name = "btnCalculateMileageCost";
            btnCalculateMileageCost.Size = new System.Drawing.Size(132, 48);
            btnCalculateMileageCost.TabIndex = 2;
            btnCalculateMileageCost.Text = "Calculate Cost";
            btnCalculateMileageCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCalculateMileageCost.UseVisualStyleBackColor = true;
            btnCalculateMileageCost.Click += btnCalculateMileageCost_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(24, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(19, 23);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblCurrentMileageRate
            // 
            lblCurrentMileageRate.AutoSize = true;
            lblCurrentMileageRate.Location = new System.Drawing.Point(47, 89);
            lblCurrentMileageRate.Name = "lblCurrentMileageRate";
            lblCurrentMileageRate.Size = new System.Drawing.Size(0, 13);
            lblCurrentMileageRate.TabIndex = 4;
            // 
            // MileageCalculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(497, 110);
            ControlBox = false;
            Controls.Add(lblCurrentMileageRate);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalculateMileageCost);
            Controls.Add(panel2);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "MileageCalculator";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mileage Cost Calculator";
            Load += MileageCalculator_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label lblMileageEstimated;
        private System.Windows.Forms.Button btnCalculateMileageCost;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentMileageRate;
    }
}