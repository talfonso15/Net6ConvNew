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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mileage));
            panel1 = new System.Windows.Forms.Panel();
            rbNoDistrictProvidedVehicle = new System.Windows.Forms.RadioButton();
            rbYesDistrictProvidedVehicle = new System.Windows.Forms.RadioButton();
            lblMileageDistrictVehicule = new System.Windows.Forms.Label();
            pDirectorApproved = new System.Windows.Forms.Panel();
            rbNoReimbursementMileage = new System.Windows.Forms.RadioButton();
            rbYesReimbursementMileage = new System.Windows.Forms.RadioButton();
            lblDirectorAprovedReimbursement = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblMapMileageClaimed = new System.Windows.Forms.Label();
            txtMapMileageClaimed = new System.Windows.Forms.TextBox();
            lblVicinityMileage = new System.Windows.Forms.Label();
            txtVicinityMileage = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnNextMileage = new System.Windows.Forms.Button();
            btnBackMileage = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnCancelMileage = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            lblMileageNotes = new System.Windows.Forms.Label();
            txtMileageNotes = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblCurrentMileageRate = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            pDirectorApproved.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(rbNoDistrictProvidedVehicle);
            panel1.Controls.Add(rbYesDistrictProvidedVehicle);
            panel1.Controls.Add(lblMileageDistrictVehicule);
            panel1.Location = new System.Drawing.Point(35, 35);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(709, 62);
            panel1.TabIndex = 0;
            // 
            // rbNoDistrictProvidedVehicle
            // 
            rbNoDistrictProvidedVehicle.AutoSize = true;
            rbNoDistrictProvidedVehicle.Location = new System.Drawing.Point(636, 21);
            rbNoDistrictProvidedVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDistrictProvidedVehicle.Name = "rbNoDistrictProvidedVehicle";
            rbNoDistrictProvidedVehicle.Size = new System.Drawing.Size(41, 19);
            rbNoDistrictProvidedVehicle.TabIndex = 2;
            rbNoDistrictProvidedVehicle.Text = "No";
            rbNoDistrictProvidedVehicle.UseVisualStyleBackColor = true;
            rbNoDistrictProvidedVehicle.CheckedChanged += rbNoDistrictProvidedVehicle_CheckedChanged;
            // 
            // rbYesDistrictProvidedVehicle
            // 
            rbYesDistrictProvidedVehicle.AutoSize = true;
            rbYesDistrictProvidedVehicle.Checked = true;
            rbYesDistrictProvidedVehicle.Location = new System.Drawing.Point(567, 21);
            rbYesDistrictProvidedVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDistrictProvidedVehicle.Name = "rbYesDistrictProvidedVehicle";
            rbYesDistrictProvidedVehicle.Size = new System.Drawing.Size(42, 19);
            rbYesDistrictProvidedVehicle.TabIndex = 1;
            rbYesDistrictProvidedVehicle.TabStop = true;
            rbYesDistrictProvidedVehicle.Text = "Yes";
            rbYesDistrictProvidedVehicle.UseVisualStyleBackColor = true;
            rbYesDistrictProvidedVehicle.CheckedChanged += rbYesDistrictProvidedVehicle_CheckedChanged;
            // 
            // lblMileageDistrictVehicule
            // 
            lblMileageDistrictVehicule.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblMileageDistrictVehicule.AutoSize = true;
            lblMileageDistrictVehicule.Location = new System.Drawing.Point(26, 25);
            lblMileageDistrictVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMileageDistrictVehicule.Name = "lblMileageDistrictVehicule";
            lblMileageDistrictVehicule.Size = new System.Drawing.Size(258, 15);
            lblMileageDistrictVehicule.TabIndex = 0;
            lblMileageDistrictVehicule.Text = "Did the district provided you a district's vehicle?";
            // 
            // pDirectorApproved
            // 
            pDirectorApproved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pDirectorApproved.Controls.Add(rbNoReimbursementMileage);
            pDirectorApproved.Controls.Add(rbYesReimbursementMileage);
            pDirectorApproved.Controls.Add(lblDirectorAprovedReimbursement);
            pDirectorApproved.Enabled = false;
            pDirectorApproved.Location = new System.Drawing.Point(35, 104);
            pDirectorApproved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pDirectorApproved.Name = "pDirectorApproved";
            pDirectorApproved.Size = new System.Drawing.Size(709, 61);
            pDirectorApproved.TabIndex = 1;
            // 
            // rbNoReimbursementMileage
            // 
            rbNoReimbursementMileage.AutoSize = true;
            rbNoReimbursementMileage.Location = new System.Drawing.Point(636, 22);
            rbNoReimbursementMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoReimbursementMileage.Name = "rbNoReimbursementMileage";
            rbNoReimbursementMileage.Size = new System.Drawing.Size(41, 19);
            rbNoReimbursementMileage.TabIndex = 2;
            rbNoReimbursementMileage.Text = "No";
            rbNoReimbursementMileage.UseVisualStyleBackColor = true;
            // 
            // rbYesReimbursementMileage
            // 
            rbYesReimbursementMileage.AutoSize = true;
            rbYesReimbursementMileage.Location = new System.Drawing.Point(567, 22);
            rbYesReimbursementMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesReimbursementMileage.Name = "rbYesReimbursementMileage";
            rbYesReimbursementMileage.Size = new System.Drawing.Size(42, 19);
            rbYesReimbursementMileage.TabIndex = 1;
            rbYesReimbursementMileage.Text = "Yes";
            rbYesReimbursementMileage.UseVisualStyleBackColor = true;
            // 
            // lblDirectorAprovedReimbursement
            // 
            lblDirectorAprovedReimbursement.AutoSize = true;
            lblDirectorAprovedReimbursement.Location = new System.Drawing.Point(26, 27);
            lblDirectorAprovedReimbursement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDirectorAprovedReimbursement.Name = "lblDirectorAprovedReimbursement";
            lblDirectorAprovedReimbursement.Size = new System.Drawing.Size(459, 15);
            lblDirectorAprovedReimbursement.TabIndex = 0;
            lblDirectorAprovedReimbursement.Text = "Did the Executive Director approved mileage reimbursement of your personal vehicle?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.30769F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.69231F));
            tableLayoutPanel1.Controls.Add(lblMapMileageClaimed, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMapMileageClaimed, 1, 0);
            tableLayoutPanel1.Controls.Add(lblVicinityMileage, 0, 1);
            tableLayoutPanel1.Controls.Add(txtVicinityMileage, 1, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(35, 182);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new System.Drawing.Size(379, 92);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblMapMileageClaimed
            // 
            lblMapMileageClaimed.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMapMileageClaimed.AutoSize = true;
            lblMapMileageClaimed.Location = new System.Drawing.Point(5, 15);
            lblMapMileageClaimed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMapMileageClaimed.Name = "lblMapMileageClaimed";
            lblMapMileageClaimed.Size = new System.Drawing.Size(188, 15);
            lblMapMileageClaimed.TabIndex = 0;
            lblMapMileageClaimed.Text = "Map Mileage Claimed:";
            // 
            // txtMapMileageClaimed
            // 
            txtMapMileageClaimed.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMapMileageClaimed.Location = new System.Drawing.Point(202, 11);
            txtMapMileageClaimed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMapMileageClaimed.Name = "txtMapMileageClaimed";
            txtMapMileageClaimed.Size = new System.Drawing.Size(172, 23);
            txtMapMileageClaimed.TabIndex = 1;
            txtMapMileageClaimed.KeyPress += txtMapMileageClaimed_KeyPress;
            // 
            // lblVicinityMileage
            // 
            lblVicinityMileage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVicinityMileage.AutoSize = true;
            lblVicinityMileage.Location = new System.Drawing.Point(5, 61);
            lblVicinityMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVicinityMileage.Name = "lblVicinityMileage";
            lblVicinityMileage.Size = new System.Drawing.Size(188, 15);
            lblVicinityMileage.TabIndex = 2;
            lblVicinityMileage.Text = "Vicinity Mileage Claimed:";
            // 
            // txtVicinityMileage
            // 
            txtVicinityMileage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtVicinityMileage.Location = new System.Drawing.Point(202, 57);
            txtVicinityMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtVicinityMileage.Name = "txtVicinityMileage";
            txtVicinityMileage.Size = new System.Drawing.Size(172, 23);
            txtVicinityMileage.TabIndex = 3;
            txtVicinityMileage.KeyPress += txtVicinityMileage_KeyPress;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.17117F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.8288288F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tableLayoutPanel2.Controls.Add(btnNextMileage, 2, 0);
            tableLayoutPanel2.Controls.Add(btnBackMileage, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(565, 419);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(179, 41);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnNextMileage
            // 
            btnNextMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNextMileage.FlatAppearance.BorderSize = 0;
            btnNextMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNextMileage.Image = (System.Drawing.Image)resources.GetObject("btnNextMileage.Image");
            btnNextMileage.Location = new System.Drawing.Point(115, 3);
            btnNextMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNextMileage.Name = "btnNextMileage";
            btnNextMileage.Size = new System.Drawing.Size(60, 35);
            btnNextMileage.TabIndex = 2;
            btnNextMileage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNextMileage.UseVisualStyleBackColor = true;
            btnNextMileage.Click += btnNextMileage_Click;
            // 
            // btnBackMileage
            // 
            btnBackMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBackMileage.FlatAppearance.BorderSize = 0;
            btnBackMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBackMileage.Image = (System.Drawing.Image)resources.GetObject("btnBackMileage.Image");
            btnBackMileage.Location = new System.Drawing.Point(4, 3);
            btnBackMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBackMileage.Name = "btnBackMileage";
            btnBackMileage.Size = new System.Drawing.Size(70, 35);
            btnBackMileage.TabIndex = 1;
            btnBackMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBackMileage.UseVisualStyleBackColor = true;
            btnBackMileage.Click += btnBackMileage_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(83, 8);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelMileage
            // 
            btnCancelMileage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancelMileage.FlatAppearance.BorderSize = 0;
            btnCancelMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelMileage.Image = (System.Drawing.Image)resources.GetObject("btnCancelMileage.Image");
            btnCancelMileage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelMileage.Location = new System.Drawing.Point(14, 419);
            btnCancelMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelMileage.Name = "btnCancelMileage";
            btnCancelMileage.Size = new System.Drawing.Size(95, 39);
            btnCancelMileage.TabIndex = 0;
            btnCancelMileage.Text = "Cancel";
            btnCancelMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelMileage.UseVisualStyleBackColor = true;
            btnCancelMileage.Click += btnCancelMileage_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.881579F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.11842F));
            tableLayoutPanel3.Controls.Add(lblMileageNotes, 0, 0);
            tableLayoutPanel3.Controls.Add(txtMileageNotes, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(35, 295);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(709, 61);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // lblMileageNotes
            // 
            lblMileageNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMileageNotes.AutoSize = true;
            lblMileageNotes.Location = new System.Drawing.Point(5, 23);
            lblMileageNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMileageNotes.Name = "lblMileageNotes";
            lblMileageNotes.Size = new System.Drawing.Size(54, 15);
            lblMileageNotes.TabIndex = 0;
            lblMileageNotes.Text = "Notes:";
            // 
            // txtMileageNotes
            // 
            txtMileageNotes.Location = new System.Drawing.Point(68, 4);
            txtMileageNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMileageNotes.Multiline = true;
            txtMileageNotes.Name = "txtMileageNotes";
            txtMileageNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtMileageNotes.Size = new System.Drawing.Size(636, 51);
            txtMileageNotes.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(41, 369);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(23, 23);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblCurrentMileageRate
            // 
            lblCurrentMileageRate.AutoSize = true;
            lblCurrentMileageRate.Location = new System.Drawing.Point(68, 374);
            lblCurrentMileageRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCurrentMileageRate.Name = "lblCurrentMileageRate";
            lblCurrentMileageRate.Size = new System.Drawing.Size(0, 15);
            lblCurrentMileageRate.TabIndex = 6;
            // 
            // Mileage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(758, 472);
            ControlBox = false;
            Controls.Add(lblCurrentMileageRate);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnCancelMileage);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pDirectorApproved);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Mileage";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mileage";
            Load += Mileage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pDirectorApproved.ResumeLayout(false);
            pDirectorApproved.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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