namespace TravelExpenses
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblResgistrationCost = new System.Windows.Forms.Label();
            txtResgistrationCost = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            rbNoRegistrationPayDistrict = new System.Windows.Forms.RadioButton();
            rbYesRegistrationPayDistrict = new System.Windows.Forms.RadioButton();
            lblDistrictPayRegistration = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblRegistrationNotes = new System.Windows.Forms.Label();
            txtRegistrationNotes = new System.Windows.Forms.TextBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnNextRegistration = new System.Windows.Forms.Button();
            btnBackRegistration = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnCancelRegistration = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.82722F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17278F));
            tableLayoutPanel1.Controls.Add(lblResgistrationCost, 0, 0);
            tableLayoutPanel1.Controls.Add(txtResgistrationCost, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDistrictPayRegistration, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(38, 60);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new System.Drawing.Size(446, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblResgistrationCost
            // 
            lblResgistrationCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblResgistrationCost.AutoSize = true;
            lblResgistrationCost.Location = new System.Drawing.Point(5, 23);
            lblResgistrationCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblResgistrationCost.Name = "lblResgistrationCost";
            lblResgistrationCost.Size = new System.Drawing.Size(270, 15);
            lblResgistrationCost.TabIndex = 0;
            lblResgistrationCost.Text = "Registration Cost:";
            // 
            // txtResgistrationCost
            // 
            txtResgistrationCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtResgistrationCost.Location = new System.Drawing.Point(284, 19);
            txtResgistrationCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtResgistrationCost.Name = "txtResgistrationCost";
            txtResgistrationCost.Size = new System.Drawing.Size(157, 23);
            txtResgistrationCost.TabIndex = 1;
            txtResgistrationCost.KeyPress += txtResgistrationCost_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(rbNoRegistrationPayDistrict);
            panel1.Controls.Add(rbYesRegistrationPayDistrict);
            panel1.Location = new System.Drawing.Point(284, 65);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(157, 50);
            panel1.TabIndex = 1;
            // 
            // rbNoRegistrationPayDistrict
            // 
            rbNoRegistrationPayDistrict.AutoSize = true;
            rbNoRegistrationPayDistrict.Location = new System.Drawing.Point(74, 18);
            rbNoRegistrationPayDistrict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoRegistrationPayDistrict.Name = "rbNoRegistrationPayDistrict";
            rbNoRegistrationPayDistrict.Size = new System.Drawing.Size(41, 19);
            rbNoRegistrationPayDistrict.TabIndex = 2;
            rbNoRegistrationPayDistrict.Text = "No";
            rbNoRegistrationPayDistrict.UseVisualStyleBackColor = true;
            // 
            // rbYesRegistrationPayDistrict
            // 
            rbYesRegistrationPayDistrict.AutoSize = true;
            rbYesRegistrationPayDistrict.Checked = true;
            rbYesRegistrationPayDistrict.Location = new System.Drawing.Point(13, 17);
            rbYesRegistrationPayDistrict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesRegistrationPayDistrict.Name = "rbYesRegistrationPayDistrict";
            rbYesRegistrationPayDistrict.Size = new System.Drawing.Size(42, 19);
            rbYesRegistrationPayDistrict.TabIndex = 1;
            rbYesRegistrationPayDistrict.TabStop = true;
            rbYesRegistrationPayDistrict.Text = "Yes";
            rbYesRegistrationPayDistrict.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPayRegistration
            // 
            lblDistrictPayRegistration.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDistrictPayRegistration.AutoSize = true;
            lblDistrictPayRegistration.Location = new System.Drawing.Point(5, 82);
            lblDistrictPayRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrictPayRegistration.Name = "lblDistrictPayRegistration";
            lblDistrictPayRegistration.Size = new System.Drawing.Size(270, 15);
            lblDistrictPayRegistration.TabIndex = 0;
            lblDistrictPayRegistration.Text = "Did the district pay for your registration cost?";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.65445F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.34555F));
            tableLayoutPanel2.Controls.Add(lblRegistrationNotes, 0, 0);
            tableLayoutPanel2.Controls.Add(txtRegistrationNotes, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(4, 6);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(439, 69);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lblRegistrationNotes
            // 
            lblRegistrationNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblRegistrationNotes.AutoSize = true;
            lblRegistrationNotes.Location = new System.Drawing.Point(4, 27);
            lblRegistrationNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegistrationNotes.Name = "lblRegistrationNotes";
            lblRegistrationNotes.Size = new System.Drawing.Size(104, 15);
            lblRegistrationNotes.TabIndex = 0;
            lblRegistrationNotes.Text = "Notes:";
            // 
            // txtRegistrationNotes
            // 
            txtRegistrationNotes.Location = new System.Drawing.Point(116, 3);
            txtRegistrationNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRegistrationNotes.Multiline = true;
            txtRegistrationNotes.Name = "txtRegistrationNotes";
            txtRegistrationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtRegistrationNotes.Size = new System.Drawing.Size(319, 62);
            txtRegistrationNotes.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.39024F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60976F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanel3.Controls.Add(btnNextRegistration, 2, 0);
            tableLayoutPanel3.Controls.Add(btnBackRegistration, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(322, 384);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(182, 47);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // btnNextRegistration
            // 
            btnNextRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNextRegistration.FlatAppearance.BorderSize = 0;
            btnNextRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNextRegistration.Image = (System.Drawing.Image)resources.GetObject("btnNextRegistration.Image");
            btnNextRegistration.Location = new System.Drawing.Point(106, 4);
            btnNextRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNextRegistration.Name = "btnNextRegistration";
            btnNextRegistration.Size = new System.Drawing.Size(71, 39);
            btnNextRegistration.TabIndex = 2;
            btnNextRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNextRegistration.UseVisualStyleBackColor = true;
            btnNextRegistration.Click += btnNextRegistration_Click;
            // 
            // btnBackRegistration
            // 
            btnBackRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBackRegistration.FlatAppearance.BorderSize = 0;
            btnBackRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBackRegistration.Image = (System.Drawing.Image)resources.GetObject("btnBackRegistration.Image");
            btnBackRegistration.Location = new System.Drawing.Point(4, 4);
            btnBackRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBackRegistration.Name = "btnBackRegistration";
            btnBackRegistration.Size = new System.Drawing.Size(67, 39);
            btnBackRegistration.TabIndex = 1;
            btnBackRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBackRegistration.UseVisualStyleBackColor = true;
            btnBackRegistration.Click += btnBackRegistration_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(79, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelRegistration
            // 
            btnCancelRegistration.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancelRegistration.FlatAppearance.BorderSize = 0;
            btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelRegistration.Image = (System.Drawing.Image)resources.GetObject("btnCancelRegistration.Image");
            btnCancelRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelRegistration.Location = new System.Drawing.Point(14, 393);
            btnCancelRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelRegistration.Name = "btnCancelRegistration";
            btnCancelRegistration.Size = new System.Drawing.Size(94, 39);
            btnCancelRegistration.TabIndex = 0;
            btnCancelRegistration.Text = "Cancel";
            btnCancelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelRegistration.UseVisualStyleBackColor = true;
            btnCancelRegistration.Click += btnCancelRegistration_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new System.Drawing.Point(38, 218);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(445, 78);
            panel2.TabIndex = 4;
            // 
            // Registration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(518, 445);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(btnCancelRegistration);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Registration";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblResgistrationCost;
        private System.Windows.Forms.TextBox txtResgistrationCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoRegistrationPayDistrict;
        private System.Windows.Forms.RadioButton rbYesRegistrationPayDistrict;
        private System.Windows.Forms.Label lblDistrictPayRegistration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRegistrationNotes;
        private System.Windows.Forms.TextBox txtRegistrationNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancelRegistration;
        private System.Windows.Forms.Button btnBackRegistration;
        private System.Windows.Forms.Button btnNextRegistration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}