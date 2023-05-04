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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNoDistrictVehicle = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictVehicle = new System.Windows.Forms.RadioButton();
            this.lblDistrictVehicle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMileageClaimed = new System.Windows.Forms.Label();
            this.txtMapMileage = new System.Windows.Forms.TextBox();
            this.lblVicinityMileage = new System.Windows.Forms.Label();
            this.txtVicicnityMileage = new System.Windows.Forms.TextBox();
            this.pDirectorApp = new System.Windows.Forms.Panel();
            this.rbNoDirectorApproval = new System.Windows.Forms.RadioButton();
            this.rbYesDirectorApproval = new System.Windows.Forms.RadioButton();
            this.lblDirectorApproval = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateMileage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pDirectorApp.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbNoDistrictVehicle);
            this.panel1.Controls.Add(this.rbYesDistrictVehicle);
            this.panel1.Controls.Add(this.lblDistrictVehicle);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 36);
            this.panel1.TabIndex = 0;
            // 
            // rbNoDistrictVehicle
            // 
            this.rbNoDistrictVehicle.AutoSize = true;
            this.rbNoDistrictVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoDistrictVehicle.Location = new System.Drawing.Point(584, 8);
            this.rbNoDistrictVehicle.Name = "rbNoDistrictVehicle";
            this.rbNoDistrictVehicle.Size = new System.Drawing.Size(41, 17);
            this.rbNoDistrictVehicle.TabIndex = 2;
            this.rbNoDistrictVehicle.TabStop = true;
            this.rbNoDistrictVehicle.Text = "No";
            this.rbNoDistrictVehicle.UseVisualStyleBackColor = true;
            this.rbNoDistrictVehicle.CheckedChanged += new System.EventHandler(this.rbNoDistrictVehicle_CheckedChanged);
            // 
            // rbYesDistrictVehicle
            // 
            this.rbYesDistrictVehicle.AutoSize = true;
            this.rbYesDistrictVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYesDistrictVehicle.Location = new System.Drawing.Point(530, 8);
            this.rbYesDistrictVehicle.Name = "rbYesDistrictVehicle";
            this.rbYesDistrictVehicle.Size = new System.Drawing.Size(46, 17);
            this.rbYesDistrictVehicle.TabIndex = 1;
            this.rbYesDistrictVehicle.TabStop = true;
            this.rbYesDistrictVehicle.Text = "Yes";
            this.rbYesDistrictVehicle.UseVisualStyleBackColor = true;
            this.rbYesDistrictVehicle.CheckedChanged += new System.EventHandler(this.rbYesDistrictVehicle_CheckedChanged);
            // 
            // lblDistrictVehicle
            // 
            this.lblDistrictVehicle.AutoSize = true;
            this.lblDistrictVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictVehicle.Location = new System.Drawing.Point(3, 12);
            this.lblDistrictVehicle.Name = "lblDistrictVehicle";
            this.lblDistrictVehicle.Size = new System.Drawing.Size(281, 13);
            this.lblDistrictVehicle.TabIndex = 0;
            this.lblDistrictVehicle.Text = "Did the district provided you a district\'s vehicle?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.98658F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.81879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.83893F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.35571F));
            this.tableLayoutPanel1.Controls.Add(this.lblMileageClaimed, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMapMileage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVicinityMileage, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVicicnityMileage, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMileageClaimed
            // 
            this.lblMileageClaimed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMileageClaimed.AutoSize = true;
            this.lblMileageClaimed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileageClaimed.Location = new System.Drawing.Point(4, 10);
            this.lblMileageClaimed.Name = "lblMileageClaimed";
            this.lblMileageClaimed.Size = new System.Drawing.Size(138, 13);
            this.lblMileageClaimed.TabIndex = 0;
            this.lblMileageClaimed.Text = "Map Mileage Claimed:";
            // 
            // txtMapMileage
            // 
            this.txtMapMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMapMileage.Location = new System.Drawing.Point(149, 7);
            this.txtMapMileage.Name = "txtMapMileage";
            this.txtMapMileage.Size = new System.Drawing.Size(137, 20);
            this.txtMapMileage.TabIndex = 2;
            this.txtMapMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMapMileage_KeyPress);
            // 
            // lblVicinityMileage
            // 
            this.lblVicinityMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVicinityMileage.AutoSize = true;
            this.lblVicinityMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVicinityMileage.Location = new System.Drawing.Point(293, 10);
            this.lblVicinityMileage.Name = "lblVicinityMileage";
            this.lblVicinityMileage.Size = new System.Drawing.Size(156, 13);
            this.lblVicinityMileage.TabIndex = 1;
            this.lblVicinityMileage.Text = "Vicinity Mileage Claimed:";
            // 
            // txtVicicnityMileage
            // 
            this.txtVicicnityMileage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVicicnityMileage.Location = new System.Drawing.Point(456, 7);
            this.txtVicicnityMileage.Name = "txtVicicnityMileage";
            this.txtVicicnityMileage.Size = new System.Drawing.Size(172, 20);
            this.txtVicicnityMileage.TabIndex = 3;
            this.txtVicicnityMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVicicnityMileage_KeyPress);
            // 
            // pDirectorApp
            // 
            this.pDirectorApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDirectorApp.Controls.Add(this.rbNoDirectorApproval);
            this.pDirectorApp.Controls.Add(this.rbYesDirectorApproval);
            this.pDirectorApp.Controls.Add(this.lblDirectorApproval);
            this.pDirectorApp.Location = new System.Drawing.Point(12, 114);
            this.pDirectorApp.Name = "pDirectorApp";
            this.pDirectorApp.Size = new System.Drawing.Size(632, 37);
            this.pDirectorApp.TabIndex = 2;
            // 
            // rbNoDirectorApproval
            // 
            this.rbNoDirectorApproval.AutoSize = true;
            this.rbNoDirectorApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoDirectorApproval.Location = new System.Drawing.Point(584, 10);
            this.rbNoDirectorApproval.Name = "rbNoDirectorApproval";
            this.rbNoDirectorApproval.Size = new System.Drawing.Size(41, 17);
            this.rbNoDirectorApproval.TabIndex = 2;
            this.rbNoDirectorApproval.TabStop = true;
            this.rbNoDirectorApproval.Text = "No";
            this.rbNoDirectorApproval.UseVisualStyleBackColor = true;
            this.rbNoDirectorApproval.CheckedChanged += new System.EventHandler(this.rbNoDirectorApproval_CheckedChanged);
            // 
            // rbYesDirectorApproval
            // 
            this.rbYesDirectorApproval.AutoSize = true;
            this.rbYesDirectorApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYesDirectorApproval.Location = new System.Drawing.Point(530, 10);
            this.rbYesDirectorApproval.Name = "rbYesDirectorApproval";
            this.rbYesDirectorApproval.Size = new System.Drawing.Size(46, 17);
            this.rbYesDirectorApproval.TabIndex = 1;
            this.rbYesDirectorApproval.TabStop = true;
            this.rbYesDirectorApproval.Text = "Yes";
            this.rbYesDirectorApproval.UseVisualStyleBackColor = true;
            this.rbYesDirectorApproval.CheckedChanged += new System.EventHandler(this.rbYesDirectorApproval_CheckedChanged);
            // 
            // lblDirectorApproval
            // 
            this.lblDirectorApproval.AutoSize = true;
            this.lblDirectorApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorApproval.Location = new System.Drawing.Point(4, 12);
            this.lblDirectorApproval.Name = "lblDirectorApproval";
            this.lblDirectorApproval.Size = new System.Drawing.Size(493, 13);
            this.lblDirectorApproval.TabIndex = 0;
            this.lblDirectorApproval.Text = "Did the Executive Director approved mileage reimbursement of your personal vehicl" +
    "e?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.544304F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.4557F));
            this.tableLayoutPanel2.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 157);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 40);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(4, 13);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(47, 13);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(58, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(570, 32);
            this.txtNotes.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateMileage, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(543, 203);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(117, 47);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnUpdateMileage
            // 
            this.btnUpdateMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateMileage.FlatAppearance.BorderSize = 0;
            this.btnUpdateMileage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMileage.Image = global::TravelExpenses.Properties.Resources._1495734626_db_update;
            this.btnUpdateMileage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMileage.Location = new System.Drawing.Point(10, 3);
            this.btnUpdateMileage.Name = "btnUpdateMileage";
            this.btnUpdateMileage.Size = new System.Drawing.Size(96, 41);
            this.btnUpdateMileage.TabIndex = 0;
            this.btnUpdateMileage.Text = "Update";
            this.btnUpdateMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateMileage.UseVisualStyleBackColor = true;
            this.btnUpdateMileage.Click += new System.EventHandler(this.btnUpdateMileage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(9, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 41);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Close";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditMileage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 246);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pDirectorApp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditMileage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Mileage";
            this.Load += new System.EventHandler(this.EditMileage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pDirectorApp.ResumeLayout(false);
            this.pDirectorApp.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

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