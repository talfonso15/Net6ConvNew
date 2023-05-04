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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblResgistrationCost = new System.Windows.Forms.Label();
            this.txtResgistrationCost = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNoRegistrationPayDistrict = new System.Windows.Forms.RadioButton();
            this.rbYesRegistrationPayDistrict = new System.Windows.Forms.RadioButton();
            this.lblDistrictPayRegistration = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistrationNotes = new System.Windows.Forms.Label();
            this.txtRegistrationNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextRegistration = new System.Windows.Forms.Button();
            this.btnBackRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelRegistration = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.82722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17278F));
            this.tableLayoutPanel1.Controls.Add(this.lblResgistrationCost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtResgistrationCost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDistrictPayRegistration, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblResgistrationCost
            // 
            this.lblResgistrationCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResgistrationCost.AutoSize = true;
            this.lblResgistrationCost.Location = new System.Drawing.Point(4, 20);
            this.lblResgistrationCost.Name = "lblResgistrationCost";
            this.lblResgistrationCost.Size = new System.Drawing.Size(232, 13);
            this.lblResgistrationCost.TabIndex = 0;
            this.lblResgistrationCost.Text = "Registration Cost:";
            // 
            // txtResgistrationCost
            // 
            this.txtResgistrationCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResgistrationCost.Location = new System.Drawing.Point(243, 16);
            this.txtResgistrationCost.Name = "txtResgistrationCost";
            this.txtResgistrationCost.Size = new System.Drawing.Size(135, 20);
            this.txtResgistrationCost.TabIndex = 1;
            this.txtResgistrationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResgistrationCost_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbNoRegistrationPayDistrict);
            this.panel1.Controls.Add(this.rbYesRegistrationPayDistrict);
            this.panel1.Location = new System.Drawing.Point(243, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 43);
            this.panel1.TabIndex = 1;
            // 
            // rbNoRegistrationPayDistrict
            // 
            this.rbNoRegistrationPayDistrict.AutoSize = true;
            this.rbNoRegistrationPayDistrict.Location = new System.Drawing.Point(63, 16);
            this.rbNoRegistrationPayDistrict.Name = "rbNoRegistrationPayDistrict";
            this.rbNoRegistrationPayDistrict.Size = new System.Drawing.Size(39, 17);
            this.rbNoRegistrationPayDistrict.TabIndex = 2;
            this.rbNoRegistrationPayDistrict.Text = "No";
            this.rbNoRegistrationPayDistrict.UseVisualStyleBackColor = true;
            // 
            // rbYesRegistrationPayDistrict
            // 
            this.rbYesRegistrationPayDistrict.AutoSize = true;
            this.rbYesRegistrationPayDistrict.Checked = true;
            this.rbYesRegistrationPayDistrict.Location = new System.Drawing.Point(11, 15);
            this.rbYesRegistrationPayDistrict.Name = "rbYesRegistrationPayDistrict";
            this.rbYesRegistrationPayDistrict.Size = new System.Drawing.Size(43, 17);
            this.rbYesRegistrationPayDistrict.TabIndex = 1;
            this.rbYesRegistrationPayDistrict.TabStop = true;
            this.rbYesRegistrationPayDistrict.Text = "Yes";
            this.rbYesRegistrationPayDistrict.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPayRegistration
            // 
            this.lblDistrictPayRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistrictPayRegistration.AutoSize = true;
            this.lblDistrictPayRegistration.Location = new System.Drawing.Point(4, 71);
            this.lblDistrictPayRegistration.Name = "lblDistrictPayRegistration";
            this.lblDistrictPayRegistration.Size = new System.Drawing.Size(232, 13);
            this.lblDistrictPayRegistration.TabIndex = 0;
            this.lblDistrictPayRegistration.Text = "Did the district pay for your registration cost?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.65445F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.34555F));
            this.tableLayoutPanel2.Controls.Add(this.lblRegistrationNotes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtRegistrationNotes, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 60);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblRegistrationNotes
            // 
            this.lblRegistrationNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistrationNotes.AutoSize = true;
            this.lblRegistrationNotes.Location = new System.Drawing.Point(3, 23);
            this.lblRegistrationNotes.Name = "lblRegistrationNotes";
            this.lblRegistrationNotes.Size = new System.Drawing.Size(90, 13);
            this.lblRegistrationNotes.TabIndex = 0;
            this.lblRegistrationNotes.Text = "Notes:";
            // 
            // txtRegistrationNotes
            // 
            this.txtRegistrationNotes.Location = new System.Drawing.Point(99, 3);
            this.txtRegistrationNotes.Multiline = true;
            this.txtRegistrationNotes.Name = "txtRegistrationNotes";
            this.txtRegistrationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRegistrationNotes.Size = new System.Drawing.Size(274, 54);
            this.txtRegistrationNotes.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.39024F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60976F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.Controls.Add(this.btnNextRegistration, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBackRegistration, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(276, 333);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(156, 41);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnNextRegistration
            // 
            this.btnNextRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextRegistration.FlatAppearance.BorderSize = 0;
            this.btnNextRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRegistration.Image = global::TravelExpenses.Properties.Resources.next;
            this.btnNextRegistration.Location = new System.Drawing.Point(91, 3);
            this.btnNextRegistration.Name = "btnNextRegistration";
            this.btnNextRegistration.Size = new System.Drawing.Size(61, 34);
            this.btnNextRegistration.TabIndex = 2;
            this.btnNextRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextRegistration.UseVisualStyleBackColor = true;
            this.btnNextRegistration.Click += new System.EventHandler(this.btnNextRegistration_Click);
            // 
            // btnBackRegistration
            // 
            this.btnBackRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackRegistration.FlatAppearance.BorderSize = 0;
            this.btnBackRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackRegistration.Image = global::TravelExpenses.Properties.Resources.back;
            this.btnBackRegistration.Location = new System.Drawing.Point(3, 3);
            this.btnBackRegistration.Name = "btnBackRegistration";
            this.btnBackRegistration.Size = new System.Drawing.Size(59, 34);
            this.btnBackRegistration.TabIndex = 1;
            this.btnBackRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackRegistration.UseVisualStyleBackColor = true;
            this.btnBackRegistration.Click += new System.EventHandler(this.btnBackRegistration_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelRegistration
            // 
            this.btnCancelRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelRegistration.FlatAppearance.BorderSize = 0;
            this.btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRegistration.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelRegistration.Location = new System.Drawing.Point(12, 341);
            this.btnCancelRegistration.Name = "btnCancelRegistration";
            this.btnCancelRegistration.Size = new System.Drawing.Size(94, 34);
            this.btnCancelRegistration.TabIndex = 0;
            this.btnCancelRegistration.Text = "Cancel";
            this.btnCancelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelRegistration.UseVisualStyleBackColor = true;
            this.btnCancelRegistration.Click += new System.EventHandler(this.btnCancelRegistration_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(33, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 68);
            this.panel2.TabIndex = 4;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 386);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.btnCancelRegistration);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Registration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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