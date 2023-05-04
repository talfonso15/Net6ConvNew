namespace TravelExpenses
{
    partial class Mileage
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
            this.rbNoDistrictProvidedVehicle = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictProvidedVehicle = new System.Windows.Forms.RadioButton();
            this.lblMileageDistrictVehicule = new System.Windows.Forms.Label();
            this.pDirectorApproved = new System.Windows.Forms.Panel();
            this.rbNoReimbursementMileage = new System.Windows.Forms.RadioButton();
            this.rbYesReimbursementMileage = new System.Windows.Forms.RadioButton();
            this.lblDirectorAprovedReimbursement = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMapMileageClaimed = new System.Windows.Forms.Label();
            this.txtMapMileageClaimed = new System.Windows.Forms.TextBox();
            this.lblVicinityMileage = new System.Windows.Forms.Label();
            this.txtVicinityMileage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextMileage = new System.Windows.Forms.Button();
            this.btnBackMileage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelMileage = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMileageNotes = new System.Windows.Forms.Label();
            this.txtMileageNotes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentMileageRate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pDirectorApproved.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbNoDistrictProvidedVehicle);
            this.panel1.Controls.Add(this.rbYesDistrictProvidedVehicle);
            this.panel1.Controls.Add(this.lblMileageDistrictVehicule);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 54);
            this.panel1.TabIndex = 0;
            // 
            // rbNoDistrictProvidedVehicle
            // 
            this.rbNoDistrictProvidedVehicle.AutoSize = true;
            this.rbNoDistrictProvidedVehicle.Location = new System.Drawing.Point(545, 18);
            this.rbNoDistrictProvidedVehicle.Name = "rbNoDistrictProvidedVehicle";
            this.rbNoDistrictProvidedVehicle.Size = new System.Drawing.Size(39, 17);
            this.rbNoDistrictProvidedVehicle.TabIndex = 2;
            this.rbNoDistrictProvidedVehicle.Text = "No";
            this.rbNoDistrictProvidedVehicle.UseVisualStyleBackColor = true;
            this.rbNoDistrictProvidedVehicle.CheckedChanged += new System.EventHandler(this.rbNoDistrictProvidedVehicle_CheckedChanged);
            // 
            // rbYesDistrictProvidedVehicle
            // 
            this.rbYesDistrictProvidedVehicle.AutoSize = true;
            this.rbYesDistrictProvidedVehicle.Checked = true;
            this.rbYesDistrictProvidedVehicle.Location = new System.Drawing.Point(486, 18);
            this.rbYesDistrictProvidedVehicle.Name = "rbYesDistrictProvidedVehicle";
            this.rbYesDistrictProvidedVehicle.Size = new System.Drawing.Size(43, 17);
            this.rbYesDistrictProvidedVehicle.TabIndex = 1;
            this.rbYesDistrictProvidedVehicle.TabStop = true;
            this.rbYesDistrictProvidedVehicle.Text = "Yes";
            this.rbYesDistrictProvidedVehicle.UseVisualStyleBackColor = true;
            this.rbYesDistrictProvidedVehicle.CheckedChanged += new System.EventHandler(this.rbYesDistrictProvidedVehicle_CheckedChanged);
            // 
            // lblMileageDistrictVehicule
            // 
            this.lblMileageDistrictVehicule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMileageDistrictVehicule.AutoSize = true;
            this.lblMileageDistrictVehicule.Location = new System.Drawing.Point(22, 22);
            this.lblMileageDistrictVehicule.Name = "lblMileageDistrictVehicule";
            this.lblMileageDistrictVehicule.Size = new System.Drawing.Size(230, 13);
            this.lblMileageDistrictVehicule.TabIndex = 0;
            this.lblMileageDistrictVehicule.Text = "Did the district provided you a district\'s vehicle?";
            // 
            // pDirectorApproved
            // 
            this.pDirectorApproved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDirectorApproved.Controls.Add(this.rbNoReimbursementMileage);
            this.pDirectorApproved.Controls.Add(this.rbYesReimbursementMileage);
            this.pDirectorApproved.Controls.Add(this.lblDirectorAprovedReimbursement);
            this.pDirectorApproved.Enabled = false;
            this.pDirectorApproved.Location = new System.Drawing.Point(30, 90);
            this.pDirectorApproved.Name = "pDirectorApproved";
            this.pDirectorApproved.Size = new System.Drawing.Size(608, 53);
            this.pDirectorApproved.TabIndex = 1;
            // 
            // rbNoReimbursementMileage
            // 
            this.rbNoReimbursementMileage.AutoSize = true;
            this.rbNoReimbursementMileage.Location = new System.Drawing.Point(545, 19);
            this.rbNoReimbursementMileage.Name = "rbNoReimbursementMileage";
            this.rbNoReimbursementMileage.Size = new System.Drawing.Size(39, 17);
            this.rbNoReimbursementMileage.TabIndex = 2;
            this.rbNoReimbursementMileage.Text = "No";
            this.rbNoReimbursementMileage.UseVisualStyleBackColor = true;
            // 
            // rbYesReimbursementMileage
            // 
            this.rbYesReimbursementMileage.AutoSize = true;
            this.rbYesReimbursementMileage.Location = new System.Drawing.Point(486, 19);
            this.rbYesReimbursementMileage.Name = "rbYesReimbursementMileage";
            this.rbYesReimbursementMileage.Size = new System.Drawing.Size(43, 17);
            this.rbYesReimbursementMileage.TabIndex = 1;
            this.rbYesReimbursementMileage.Text = "Yes";
            this.rbYesReimbursementMileage.UseVisualStyleBackColor = true;
            // 
            // lblDirectorAprovedReimbursement
            // 
            this.lblDirectorAprovedReimbursement.AutoSize = true;
            this.lblDirectorAprovedReimbursement.Location = new System.Drawing.Point(22, 23);
            this.lblDirectorAprovedReimbursement.Name = "lblDirectorAprovedReimbursement";
            this.lblDirectorAprovedReimbursement.Size = new System.Drawing.Size(410, 13);
            this.lblDirectorAprovedReimbursement.TabIndex = 0;
            this.lblDirectorAprovedReimbursement.Text = "Did the Executive Director approved mileage reimbursement of your personal vehicl" +
    "e?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.30769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.69231F));
            this.tableLayoutPanel1.Controls.Add(this.lblMapMileageClaimed, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMapMileageClaimed, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVicinityMileage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtVicinityMileage, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 80);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblMapMileageClaimed
            // 
            this.lblMapMileageClaimed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMapMileageClaimed.AutoSize = true;
            this.lblMapMileageClaimed.Location = new System.Drawing.Point(4, 13);
            this.lblMapMileageClaimed.Name = "lblMapMileageClaimed";
            this.lblMapMileageClaimed.Size = new System.Drawing.Size(162, 13);
            this.lblMapMileageClaimed.TabIndex = 0;
            this.lblMapMileageClaimed.Text = "Map Mileage Claimed:";
            // 
            // txtMapMileageClaimed
            // 
            this.txtMapMileageClaimed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMapMileageClaimed.Location = new System.Drawing.Point(173, 10);
            this.txtMapMileageClaimed.Name = "txtMapMileageClaimed";
            this.txtMapMileageClaimed.Size = new System.Drawing.Size(148, 20);
            this.txtMapMileageClaimed.TabIndex = 1;
            this.txtMapMileageClaimed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMapMileageClaimed_KeyPress);
            // 
            // lblVicinityMileage
            // 
            this.lblVicinityMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVicinityMileage.AutoSize = true;
            this.lblVicinityMileage.Location = new System.Drawing.Point(4, 53);
            this.lblVicinityMileage.Name = "lblVicinityMileage";
            this.lblVicinityMileage.Size = new System.Drawing.Size(162, 13);
            this.lblVicinityMileage.TabIndex = 2;
            this.lblVicinityMileage.Text = "Vicinity Mileage Claimed:";
            // 
            // txtVicinityMileage
            // 
            this.txtVicinityMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVicinityMileage.Location = new System.Drawing.Point(173, 49);
            this.txtVicinityMileage.Name = "txtVicinityMileage";
            this.txtVicinityMileage.Size = new System.Drawing.Size(148, 20);
            this.txtVicinityMileage.TabIndex = 3;
            this.txtVicinityMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVicinityMileage_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.39449F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.6055F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.Controls.Add(this.btnNextMileage, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackMileage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(463, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(175, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnNextMileage
            // 
            this.btnNextMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextMileage.FlatAppearance.BorderSize = 0;
            this.btnNextMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMileage.Image = global::TravelExpenses.Properties.Resources.next;
            this.btnNextMileage.Location = new System.Drawing.Point(101, 3);
            this.btnNextMileage.Name = "btnNextMileage";
            this.btnNextMileage.Size = new System.Drawing.Size(69, 28);
            this.btnNextMileage.TabIndex = 2;
            this.btnNextMileage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextMileage.UseVisualStyleBackColor = true;
            this.btnNextMileage.Click += new System.EventHandler(this.btnNextMileage_Click);
            // 
            // btnBackMileage
            // 
            this.btnBackMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackMileage.FlatAppearance.BorderSize = 0;
            this.btnBackMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMileage.Image = global::TravelExpenses.Properties.Resources.back;
            this.btnBackMileage.Location = new System.Drawing.Point(5, 3);
            this.btnBackMileage.Name = "btnBackMileage";
            this.btnBackMileage.Size = new System.Drawing.Size(60, 28);
            this.btnBackMileage.TabIndex = 1;
            this.btnBackMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackMileage.UseVisualStyleBackColor = true;
            this.btnBackMileage.Click += new System.EventHandler(this.btnBackMileage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelMileage
            // 
            this.btnCancelMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelMileage.FlatAppearance.BorderSize = 0;
            this.btnCancelMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMileage.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelMileage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelMileage.Location = new System.Drawing.Point(12, 363);
            this.btnCancelMileage.Name = "btnCancelMileage";
            this.btnCancelMileage.Size = new System.Drawing.Size(95, 34);
            this.btnCancelMileage.TabIndex = 0;
            this.btnCancelMileage.Text = "Cancel";
            this.btnCancelMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelMileage.UseVisualStyleBackColor = true;
            this.btnCancelMileage.Click += new System.EventHandler(this.btnCancelMileage_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.881579F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.11842F));
            this.tableLayoutPanel3.Controls.Add(this.lblMileageNotes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtMileageNotes, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(30, 256);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(608, 53);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblMileageNotes
            // 
            this.lblMileageNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMileageNotes.AutoSize = true;
            this.lblMileageNotes.Location = new System.Drawing.Point(4, 20);
            this.lblMileageNotes.Name = "lblMileageNotes";
            this.lblMileageNotes.Size = new System.Drawing.Size(47, 13);
            this.lblMileageNotes.TabIndex = 0;
            this.lblMileageNotes.Text = "Notes:";
            // 
            // txtMileageNotes
            // 
            this.txtMileageNotes.Location = new System.Drawing.Point(58, 4);
            this.txtMileageNotes.Multiline = true;
            this.txtMileageNotes.Name = "txtMileageNotes";
            this.txtMileageNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMileageNotes.Size = new System.Drawing.Size(546, 45);
            this.txtMileageNotes.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.pictureBox1.Location = new System.Drawing.Point(35, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentMileageRate
            // 
            this.lblCurrentMileageRate.AutoSize = true;
            this.lblCurrentMileageRate.Location = new System.Drawing.Point(58, 324);
            this.lblCurrentMileageRate.Name = "lblCurrentMileageRate";
            this.lblCurrentMileageRate.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentMileageRate.TabIndex = 6;
            // 
            // Mileage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 409);
            this.ControlBox = false;
            this.Controls.Add(this.lblCurrentMileageRate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnCancelMileage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pDirectorApproved);
            this.Controls.Add(this.panel1);
            this.Name = "Mileage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mileage";
            this.Load += new System.EventHandler(this.Mileage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pDirectorApproved.ResumeLayout(false);
            this.pDirectorApproved.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoDistrictProvidedVehicle;
        private System.Windows.Forms.RadioButton rbYesDistrictProvidedVehicle;
        private System.Windows.Forms.Label lblMileageDistrictVehicule;
        private System.Windows.Forms.Panel pDirectorApproved;
        private System.Windows.Forms.RadioButton rbNoReimbursementMileage;
        private System.Windows.Forms.RadioButton rbYesReimbursementMileage;
        private System.Windows.Forms.Label lblDirectorAprovedReimbursement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMapMileageClaimed;
        private System.Windows.Forms.TextBox txtMapMileageClaimed;
        private System.Windows.Forms.Label lblVicinityMileage;
        private System.Windows.Forms.TextBox txtVicinityMileage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancelMileage;
        private System.Windows.Forms.Button btnBackMileage;
        private System.Windows.Forms.Button btnNextMileage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMileageNotes;
        private System.Windows.Forms.TextBox txtMileageNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentMileageRate;
    }
}