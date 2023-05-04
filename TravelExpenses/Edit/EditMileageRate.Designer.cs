namespace TravelExpenses
{
    partial class EditMileageRate
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
            this.lblMileageRate = new System.Windows.Forms.Label();
            this.txtMileageRate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCurrentMileageRate = new System.Windows.Forms.Label();
            this.lblCurrentMileageRateValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMileageRate
            // 
            this.lblMileageRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMileageRate.AutoSize = true;
            this.lblMileageRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileageRate.Location = new System.Drawing.Point(3, 42);
            this.lblMileageRate.Name = "lblMileageRate";
            this.lblMileageRate.Size = new System.Drawing.Size(135, 13);
            this.lblMileageRate.TabIndex = 0;
            this.lblMileageRate.Text = "New Mileage Rate:";
            this.lblMileageRate.Click += new System.EventHandler(this.lblMileageRate_Click);
            // 
            // txtMileageRate
            // 
            this.txtMileageRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMileageRate.Location = new System.Drawing.Point(144, 38);
            this.txtMileageRate.Name = "txtMileageRate";
            this.txtMileageRate.Size = new System.Drawing.Size(136, 20);
            this.txtMileageRate.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Green;
            this.btnUpdate.Location = new System.Drawing.Point(231, 127);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCurrentMileageRate
            // 
            this.lblCurrentMileageRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentMileageRate.AutoSize = true;
            this.lblCurrentMileageRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMileageRate.Location = new System.Drawing.Point(3, 9);
            this.lblCurrentMileageRate.Name = "lblCurrentMileageRate";
            this.lblCurrentMileageRate.Size = new System.Drawing.Size(135, 13);
            this.lblCurrentMileageRate.TabIndex = 3;
            this.lblCurrentMileageRate.Text = "Current Mileage Rate:";
            // 
            // lblCurrentMileageRateValue
            // 
            this.lblCurrentMileageRateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentMileageRateValue.AutoSize = true;
            this.lblCurrentMileageRateValue.Location = new System.Drawing.Point(144, 9);
            this.lblCurrentMileageRateValue.Name = "lblCurrentMileageRateValue";
            this.lblCurrentMileageRateValue.Size = new System.Drawing.Size(136, 13);
            this.lblCurrentMileageRateValue.TabIndex = 4;
            this.lblCurrentMileageRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentMileageRate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentMileageRateValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMileageRate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMileageRate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 65);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 87);
            this.panel1.TabIndex = 6;
            // 
            // EditMileageRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 172);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMileageRate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Mileage Rate";
            this.Load += new System.EventHandler(this.EditMileageRate_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMileageRate;
        private System.Windows.Forms.TextBox txtMileageRate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCurrentMileageRate;
        private System.Windows.Forms.Label lblCurrentMileageRateValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}