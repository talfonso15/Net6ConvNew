namespace TravelExpenses
{
    partial class EditMileage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMileage));
            panel1 = new System.Windows.Forms.Panel();
            rbNoDistrictVehicle = new System.Windows.Forms.RadioButton();
            rbYesDistrictVehicle = new System.Windows.Forms.RadioButton();
            lblDistrictVehicle = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblMileageClaimed = new System.Windows.Forms.Label();
            txtMapMileage = new System.Windows.Forms.TextBox();
            lblVicinityMileage = new System.Windows.Forms.Label();
            txtVicicnityMileage = new System.Windows.Forms.TextBox();
            pDirectorApp = new System.Windows.Forms.Panel();
            rbNoDirectorApproval = new System.Windows.Forms.RadioButton();
            rbYesDirectorApproval = new System.Windows.Forms.RadioButton();
            lblDirectorApproval = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnUpdateMileage = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pDirectorApp.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(rbNoDistrictVehicle);
            panel1.Controls.Add(rbYesDistrictVehicle);
            panel1.Controls.Add(lblDistrictVehicle);
            panel1.Location = new System.Drawing.Point(14, 83);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(737, 41);
            panel1.TabIndex = 0;
            // 
            // rbNoDistrictVehicle
            // 
            rbNoDistrictVehicle.AutoSize = true;
            rbNoDistrictVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbNoDistrictVehicle.Location = new System.Drawing.Point(681, 9);
            rbNoDistrictVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDistrictVehicle.Name = "rbNoDistrictVehicle";
            rbNoDistrictVehicle.Size = new System.Drawing.Size(41, 17);
            rbNoDistrictVehicle.TabIndex = 2;
            rbNoDistrictVehicle.TabStop = true;
            rbNoDistrictVehicle.Text = "No";
            rbNoDistrictVehicle.UseVisualStyleBackColor = true;
            rbNoDistrictVehicle.CheckedChanged += rbNoDistrictVehicle_CheckedChanged;
            // 
            // rbYesDistrictVehicle
            // 
            rbYesDistrictVehicle.AutoSize = true;
            rbYesDistrictVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbYesDistrictVehicle.Location = new System.Drawing.Point(618, 9);
            rbYesDistrictVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDistrictVehicle.Name = "rbYesDistrictVehicle";
            rbYesDistrictVehicle.Size = new System.Drawing.Size(46, 17);
            rbYesDistrictVehicle.TabIndex = 1;
            rbYesDistrictVehicle.TabStop = true;
            rbYesDistrictVehicle.Text = "Yes";
            rbYesDistrictVehicle.UseVisualStyleBackColor = true;
            rbYesDistrictVehicle.CheckedChanged += rbYesDistrictVehicle_CheckedChanged;
            // 
            // lblDistrictVehicle
            // 
            lblDistrictVehicle.AutoSize = true;
            lblDistrictVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistrictVehicle.Location = new System.Drawing.Point(4, 14);
            lblDistrictVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrictVehicle.Name = "lblDistrictVehicle";
            lblDistrictVehicle.Size = new System.Drawing.Size(281, 13);
            lblDistrictVehicle.TabIndex = 0;
            lblDistrictVehicle.Text = "Did the district provided you a district's vehicle?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.98658F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.81879F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.83893F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.35571F));
            tableLayoutPanel1.Controls.Add(lblMileageClaimed, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMapMileage, 1, 0);
            tableLayoutPanel1.Controls.Add(lblVicinityMileage, 2, 0);
            tableLayoutPanel1.Controls.Add(txtVicicnityMileage, 3, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(14, 33);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(737, 39);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMileageClaimed
            // 
            lblMileageClaimed.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMileageClaimed.AutoSize = true;
            lblMileageClaimed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMileageClaimed.Location = new System.Drawing.Point(5, 13);
            lblMileageClaimed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMileageClaimed.Name = "lblMileageClaimed";
            lblMileageClaimed.Size = new System.Drawing.Size(160, 13);
            lblMileageClaimed.TabIndex = 0;
            lblMileageClaimed.Text = "Map Mileage Claimed:";
            // 
            // txtMapMileage
            // 
            txtMapMileage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMapMileage.Location = new System.Drawing.Point(174, 8);
            txtMapMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMapMileage.Name = "txtMapMileage";
            txtMapMileage.Size = new System.Drawing.Size(159, 23);
            txtMapMileage.TabIndex = 2;
            txtMapMileage.KeyPress += txtMapMileage_KeyPress;
            // 
            // lblVicinityMileage
            // 
            lblVicinityMileage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVicinityMileage.AutoSize = true;
            lblVicinityMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblVicinityMileage.Location = new System.Drawing.Point(342, 13);
            lblVicinityMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVicinityMileage.Name = "lblVicinityMileage";
            lblVicinityMileage.Size = new System.Drawing.Size(181, 13);
            lblVicinityMileage.TabIndex = 1;
            lblVicinityMileage.Text = "Vicinity Mileage Claimed:";
            // 
            // txtVicicnityMileage
            // 
            txtVicicnityMileage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtVicicnityMileage.Location = new System.Drawing.Point(532, 8);
            txtVicicnityMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtVicicnityMileage.Name = "txtVicicnityMileage";
            txtVicicnityMileage.Size = new System.Drawing.Size(200, 23);
            txtVicicnityMileage.TabIndex = 3;
            txtVicicnityMileage.KeyPress += txtVicicnityMileage_KeyPress;
            // 
            // pDirectorApp
            // 
            pDirectorApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pDirectorApp.Controls.Add(rbNoDirectorApproval);
            pDirectorApp.Controls.Add(rbYesDirectorApproval);
            pDirectorApp.Controls.Add(lblDirectorApproval);
            pDirectorApp.Location = new System.Drawing.Point(14, 132);
            pDirectorApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pDirectorApp.Name = "pDirectorApp";
            pDirectorApp.Size = new System.Drawing.Size(737, 42);
            pDirectorApp.TabIndex = 2;
            // 
            // rbNoDirectorApproval
            // 
            rbNoDirectorApproval.AutoSize = true;
            rbNoDirectorApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbNoDirectorApproval.Location = new System.Drawing.Point(681, 12);
            rbNoDirectorApproval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoDirectorApproval.Name = "rbNoDirectorApproval";
            rbNoDirectorApproval.Size = new System.Drawing.Size(41, 17);
            rbNoDirectorApproval.TabIndex = 2;
            rbNoDirectorApproval.TabStop = true;
            rbNoDirectorApproval.Text = "No";
            rbNoDirectorApproval.UseVisualStyleBackColor = true;
            rbNoDirectorApproval.CheckedChanged += rbNoDirectorApproval_CheckedChanged;
            // 
            // rbYesDirectorApproval
            // 
            rbYesDirectorApproval.AutoSize = true;
            rbYesDirectorApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbYesDirectorApproval.Location = new System.Drawing.Point(618, 12);
            rbYesDirectorApproval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDirectorApproval.Name = "rbYesDirectorApproval";
            rbYesDirectorApproval.Size = new System.Drawing.Size(46, 17);
            rbYesDirectorApproval.TabIndex = 1;
            rbYesDirectorApproval.TabStop = true;
            rbYesDirectorApproval.Text = "Yes";
            rbYesDirectorApproval.UseVisualStyleBackColor = true;
            rbYesDirectorApproval.CheckedChanged += rbYesDirectorApproval_CheckedChanged;
            // 
            // lblDirectorApproval
            // 
            lblDirectorApproval.AutoSize = true;
            lblDirectorApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDirectorApproval.Location = new System.Drawing.Point(5, 14);
            lblDirectorApproval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDirectorApproval.Name = "lblDirectorApproval";
            lblDirectorApproval.Size = new System.Drawing.Size(493, 13);
            lblDirectorApproval.TabIndex = 0;
            lblDirectorApproval.Text = "Did the Executive Director approved mileage reimbursement of your personal vehicle?";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.544304F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.4557F));
            tableLayoutPanel2.Controls.Add(lblNotes, 0, 0);
            tableLayoutPanel2.Controls.Add(txtNotes, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(14, 181);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(737, 46);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(5, 16);
            lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(54, 13);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(68, 5);
            txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(664, 36);
            txtNotes.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel3.Location = new System.Drawing.Point(293, 234);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(136, 33);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // btnUpdateMileage
            // 
            btnUpdateMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpdateMileage.FlatAppearance.BorderSize = 0;
            btnUpdateMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdateMileage.Image = (System.Drawing.Image)resources.GetObject("btnUpdateMileage.Image");
            btnUpdateMileage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUpdateMileage.Location = new System.Drawing.Point(657, 235);
            btnUpdateMileage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdateMileage.Name = "btnUpdateMileage";
            btnUpdateMileage.Size = new System.Drawing.Size(94, 34);
            btnUpdateMileage.TabIndex = 0;
            btnUpdateMileage.Text = "Update";
            btnUpdateMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnUpdateMileage.UseVisualStyleBackColor = true;
            btnUpdateMileage.Click += btnUpdateMileage_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(17, 234);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(84, 41);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Close";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // EditMileage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(764, 279);
            ControlBox = false;
            Controls.Add(btnUpdateMileage);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(btnCancel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pDirectorApp);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditMileage";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Mileage";
            Load += EditMileage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pDirectorApp.ResumeLayout(false);
            pDirectorApp.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMileageClaimed;
        private System.Windows.Forms.TextBox txtMapMileage;
        private System.Windows.Forms.Label lblVicinityMileage;
        private System.Windows.Forms.TextBox txtVicicnityMileage;
        private System.Windows.Forms.RadioButton rbNoDistrictVehicle;
        private System.Windows.Forms.RadioButton rbYesDistrictVehicle;
        private System.Windows.Forms.Label lblDistrictVehicle;
        private System.Windows.Forms.Panel pDirectorApp;
        private System.Windows.Forms.RadioButton rbNoDirectorApproval;
        private System.Windows.Forms.RadioButton rbYesDirectorApproval;
        private System.Windows.Forms.Label lblDirectorApproval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUpdateMileage;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}