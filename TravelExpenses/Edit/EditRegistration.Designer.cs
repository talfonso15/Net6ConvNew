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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRegistration));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblRegistrationCost = new System.Windows.Forms.Label();
            lblDistrictPay = new System.Windows.Forms.Label();
            txtRegistrationCost = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            rbNoDistrictPay = new System.Windows.Forms.RadioButton();
            rbYesDistraictPay = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnUpdateRegistration = new System.Windows.Forms.Button();
            btnCancelRegistration = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.85102F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.14898F));
            tableLayoutPanel1.Controls.Add(lblRegistrationCost, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDistrictPay, 0, 1);
            tableLayoutPanel1.Controls.Add(txtRegistrationCost, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(15, 24);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(517, 107);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRegistrationCost
            // 
            lblRegistrationCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblRegistrationCost.AutoSize = true;
            lblRegistrationCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRegistrationCost.Location = new System.Drawing.Point(4, 20);
            lblRegistrationCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegistrationCost.Name = "lblRegistrationCost";
            lblRegistrationCost.Size = new System.Drawing.Size(311, 13);
            lblRegistrationCost.TabIndex = 0;
            lblRegistrationCost.Text = "Registration Cost:";
            // 
            // lblDistrictPay
            // 
            lblDistrictPay.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDistrictPay.AutoSize = true;
            lblDistrictPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistrictPay.Location = new System.Drawing.Point(4, 73);
            lblDistrictPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrictPay.Name = "lblDistrictPay";
            lblDistrictPay.Size = new System.Drawing.Size(311, 13);
            lblDistrictPay.TabIndex = 1;
            lblDistrictPay.Text = "Did the district pay for your registration cost?";
            // 
            // txtRegistrationCost
            // 
            txtRegistrationCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtRegistrationCost.Location = new System.Drawing.Point(323, 15);
            txtRegistrationCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRegistrationCost.Name = "txtRegistrationCost";
            txtRegistrationCost.Size = new System.Drawing.Size(190, 23);
            txtRegistrationCost.TabIndex = 2;
            txtRegistrationCost.KeyPress += txtRegistrationCost_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbNoDistrictPay);
            panel2.Controls.Add(rbYesDistraictPay);
            panel2.Location = new System.Drawing.Point(323, 56);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(190, 47);
            panel2.TabIndex = 3;
            // 
            // rbNoDistrictPay
            // 
            rbNoDistrictPay.AutoSize = true;
            rbNoDistrictPay.Location = new System.Drawing.Point(119, 15);
            rbNoDistrictPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDistrictPay.Name = "rbNoDistrictPay";
            rbNoDistrictPay.Size = new System.Drawing.Size(41, 19);
            rbNoDistrictPay.TabIndex = 1;
            rbNoDistrictPay.TabStop = true;
            rbNoDistrictPay.Text = "No";
            rbNoDistrictPay.UseVisualStyleBackColor = true;
            // 
            // rbYesDistraictPay
            // 
            rbYesDistraictPay.AutoSize = true;
            rbYesDistraictPay.Location = new System.Drawing.Point(37, 15);
            rbYesDistraictPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDistraictPay.Name = "rbYesDistraictPay";
            rbYesDistraictPay.Size = new System.Drawing.Size(42, 19);
            rbYesDistraictPay.TabIndex = 0;
            rbYesDistraictPay.TabStop = true;
            rbYesDistraictPay.Text = "Yes";
            rbYesDistraictPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new System.Drawing.Point(14, 35);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(548, 154);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4183F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5817F));
            tableLayoutPanel2.Controls.Add(lblNotes, 0, 0);
            tableLayoutPanel2.Controls.Add(txtNotes, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(7, 10);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(536, 57);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(4, 22);
            lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(58, 13);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(70, 4);
            txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(462, 49);
            txtNotes.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Location = new System.Drawing.Point(14, 210);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(548, 78);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnUpdateRegistration, 1, 0);
            tableLayoutPanel3.Controls.Add(btnCancelRegistration, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(255, 306);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(307, 65);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // btnUpdateRegistration
            // 
            btnUpdateRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpdateRegistration.FlatAppearance.BorderSize = 0;
            btnUpdateRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdateRegistration.Image = (System.Drawing.Image)resources.GetObject("btnUpdateRegistration.Image");
            btnUpdateRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUpdateRegistration.Location = new System.Drawing.Point(184, 8);
            btnUpdateRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdateRegistration.Name = "btnUpdateRegistration";
            btnUpdateRegistration.Size = new System.Drawing.Size(92, 48);
            btnUpdateRegistration.TabIndex = 0;
            btnUpdateRegistration.Text = "Update";
            btnUpdateRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnUpdateRegistration.UseVisualStyleBackColor = true;
            btnUpdateRegistration.Click += btnUpdateRegistration_Click;
            // 
            // btnCancelRegistration
            // 
            btnCancelRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelRegistration.FlatAppearance.BorderSize = 0;
            btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelRegistration.Image = (System.Drawing.Image)resources.GetObject("btnCancelRegistration.Image");
            btnCancelRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelRegistration.Location = new System.Drawing.Point(34, 8);
            btnCancelRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelRegistration.Name = "btnCancelRegistration";
            btnCancelRegistration.Size = new System.Drawing.Size(85, 48);
            btnCancelRegistration.TabIndex = 1;
            btnCancelRegistration.Text = "Close";
            btnCancelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelRegistration.UseVisualStyleBackColor = true;
            btnCancelRegistration.Click += btnCancelRegistration_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // EditRegistration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 396);
            ControlBox = false;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditRegistration";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Registration";
            Load += EditRegistration_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
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