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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.lblMileageEstimated = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalculateMileageCost = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentMileageRate = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblInformation);
            this.panel2.Controls.Add(this.txtMileage);
            this.panel2.Controls.Add(this.lblMileageEstimated);
            this.panel2.Location = new System.Drawing.Point(24, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 60);
            this.panel2.TabIndex = 1;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Red;
            this.lblInformation.Location = new System.Drawing.Point(279, 20);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(16, 15);
            this.lblInformation.TabIndex = 2;
            this.lblInformation.Text = "?";
            this.toolTip1.SetToolTip(this.lblInformation, "Estimate Mileage x Current Mileage Rate");
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(147, 17);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(124, 20);
            this.txtMileage.TabIndex = 1;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // lblMileageEstimated
            // 
            this.lblMileageEstimated.AutoSize = true;
            this.lblMileageEstimated.Location = new System.Drawing.Point(14, 20);
            this.lblMileageEstimated.Name = "lblMileageEstimated";
            this.lblMileageEstimated.Size = new System.Drawing.Size(114, 13);
            this.lblMileageEstimated.TabIndex = 0;
            this.lblMileageEstimated.Text = "Estimated Mileage:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "The Mileage Cost =";
            // 
            // btnCalculateMileageCost
            // 
            this.btnCalculateMileageCost.FlatAppearance.BorderSize = 0;
            this.btnCalculateMileageCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateMileageCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMileageCost.Image = global::TravelExpenses.Properties.Resources.calc;
            this.btnCalculateMileageCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculateMileageCost.Location = new System.Drawing.Point(366, 25);
            this.btnCalculateMileageCost.Name = "btnCalculateMileageCost";
            this.btnCalculateMileageCost.Size = new System.Drawing.Size(132, 48);
            this.btnCalculateMileageCost.TabIndex = 2;
            this.btnCalculateMileageCost.Text = "Calculate Cost";
            this.btnCalculateMileageCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculateMileageCost.UseVisualStyleBackColor = true;
            this.btnCalculateMileageCost.Click += new System.EventHandler(this.btnCalculateMileageCost_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.pictureBox1.Location = new System.Drawing.Point(24, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentMileageRate
            // 
            this.lblCurrentMileageRate.AutoSize = true;
            this.lblCurrentMileageRate.Location = new System.Drawing.Point(47, 89);
            this.lblCurrentMileageRate.Name = "lblCurrentMileageRate";
            this.lblCurrentMileageRate.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentMileageRate.TabIndex = 4;
            // 
            // MileageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 118);
            this.ControlBox = false;
            this.Controls.Add(this.lblCurrentMileageRate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalculateMileageCost);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MileageCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mileage Cost Calculator";
            this.Load += new System.EventHandler(this.MileageCalculator_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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