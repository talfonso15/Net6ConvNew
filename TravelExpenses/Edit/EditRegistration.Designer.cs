namespace TravelExpenses
{
    partial class EditRegistration
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistrationCost = new System.Windows.Forms.Label();
            this.lblDistrictPay = new System.Windows.Forms.Label();
            this.txtRegistrationCost = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            this.rbYesDistraictPay = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateRegistration = new System.Windows.Forms.Button();
            this.btnCancelRegistration = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.85102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.14898F));
            this.tableLayoutPanel1.Controls.Add(this.lblRegistrationCost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDistrictPay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegistrationCost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRegistrationCost
            // 
            this.lblRegistrationCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistrationCost.AutoSize = true;
            this.lblRegistrationCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCost.Location = new System.Drawing.Point(3, 16);
            this.lblRegistrationCost.Name = "lblRegistrationCost";
            this.lblRegistrationCost.Size = new System.Drawing.Size(268, 13);
            this.lblRegistrationCost.TabIndex = 0;
            this.lblRegistrationCost.Text = "Registration Cost:";
            // 
            // lblDistrictPay
            // 
            this.lblDistrictPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistrictPay.AutoSize = true;
            this.lblDistrictPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictPay.Location = new System.Drawing.Point(3, 63);
            this.lblDistrictPay.Name = "lblDistrictPay";
            this.lblDistrictPay.Size = new System.Drawing.Size(268, 13);
            this.lblDistrictPay.TabIndex = 1;
            this.lblDistrictPay.Text = "Did the district pay for your registration cost?";
            // 
            // txtRegistrationCost
            // 
            this.txtRegistrationCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegistrationCost.Location = new System.Drawing.Point(277, 13);
            this.txtRegistrationCost.Name = "txtRegistrationCost";
            this.txtRegistrationCost.Size = new System.Drawing.Size(163, 20);
            this.txtRegistrationCost.TabIndex = 2;
            this.txtRegistrationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistrationCost_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNoDistrictPay);
            this.panel2.Controls.Add(this.rbYesDistraictPay);
            this.panel2.Location = new System.Drawing.Point(277, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 41);
            this.panel2.TabIndex = 3;
            // 
            // rbNoDistrictPay
            // 
            this.rbNoDistrictPay.AutoSize = true;
            this.rbNoDistrictPay.Location = new System.Drawing.Point(102, 13);
            this.rbNoDistrictPay.Name = "rbNoDistrictPay";
            this.rbNoDistrictPay.Size = new System.Drawing.Size(39, 17);
            this.rbNoDistrictPay.TabIndex = 1;
            this.rbNoDistrictPay.TabStop = true;
            this.rbNoDistrictPay.Text = "No";
            this.rbNoDistrictPay.UseVisualStyleBackColor = true;
            // 
            // rbYesDistraictPay
            // 
            this.rbYesDistraictPay.AutoSize = true;
            this.rbYesDistraictPay.Location = new System.Drawing.Point(32, 13);
            this.rbYesDistraictPay.Name = "rbYesDistraictPay";
            this.rbYesDistraictPay.Size = new System.Drawing.Size(43, 17);
            this.rbYesDistraictPay.TabIndex = 0;
            this.rbYesDistraictPay.TabStop = true;
            this.rbYesDistraictPay.Text = "Yes";
            this.rbYesDistraictPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 134);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4183F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5817F));
            this.tableLayoutPanel2.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 9);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(459, 49);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(3, 18);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(50, 13);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(59, 3);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(397, 43);
            this.txtNotes.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(12, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 68);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateRegistration, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelRegistration, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(219, 265);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(263, 56);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnUpdateRegistration
            // 
            this.btnUpdateRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateRegistration.FlatAppearance.BorderSize = 0;
            this.btnUpdateRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRegistration.Image = global::TravelExpenses.Properties.Resources._1495734626_db_update;
            this.btnUpdateRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRegistration.Location = new System.Drawing.Point(149, 7);
            this.btnUpdateRegistration.Name = "btnUpdateRegistration";
            this.btnUpdateRegistration.Size = new System.Drawing.Size(95, 42);
            this.btnUpdateRegistration.TabIndex = 0;
            this.btnUpdateRegistration.Text = "Update";
            this.btnUpdateRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateRegistration.UseVisualStyleBackColor = true;
            this.btnUpdateRegistration.Click += new System.EventHandler(this.btnUpdateRegistration_Click);
            // 
            // btnCancelRegistration
            // 
            this.btnCancelRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelRegistration.FlatAppearance.BorderSize = 0;
            this.btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRegistration.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelRegistration.Location = new System.Drawing.Point(23, 7);
            this.btnCancelRegistration.Name = "btnCancelRegistration";
            this.btnCancelRegistration.Size = new System.Drawing.Size(85, 42);
            this.btnCancelRegistration.TabIndex = 1;
            this.btnCancelRegistration.Text = "Close";
            this.btnCancelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelRegistration.UseVisualStyleBackColor = true;
            this.btnCancelRegistration.Click += new System.EventHandler(this.btnCancelRegistration_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 343);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "EditRegistration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Registration";
            this.Load += new System.EventHandler(this.EditRegistration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRegistrationCost;
        private System.Windows.Forms.Label lblDistrictPay;
        private System.Windows.Forms.TextBox txtRegistrationCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNoDistrictPay;
        private System.Windows.Forms.RadioButton rbYesDistraictPay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUpdateRegistration;
        private System.Windows.Forms.Button btnCancelRegistration;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}