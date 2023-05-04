namespace TravelExpenses
{
    partial class EditOtherExpenses
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
            this.dgvEditOtherExp = new System.Windows.Forms.DataGridView();
            this.Prepaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlEditButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditOtherExp = new System.Windows.Forms.Button();
            this.btnAddOtherExp = new System.Windows.Forms.Button();
            this.btnDeleteOtherExp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrepaid = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.chxPrepaid = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveOtherExp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditOtherExp)).BeginInit();
            this.tlEditButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEditOtherExp
            // 
            this.dgvEditOtherExp.AllowUserToAddRows = false;
            this.dgvEditOtherExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditOtherExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prepaid,
            this.Description,
            this.Amount,
            this.Notes,
            this.ExpID});
            this.dgvEditOtherExp.Location = new System.Drawing.Point(7, 52);
            this.dgvEditOtherExp.Name = "dgvEditOtherExp";
            this.dgvEditOtherExp.ReadOnly = true;
            this.dgvEditOtherExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditOtherExp.Size = new System.Drawing.Size(574, 115);
            this.dgvEditOtherExp.TabIndex = 2;
            // 
            // Prepaid
            // 
            this.Prepaid.HeaderText = "P-Card Paid";
            this.Prepaid.Name = "Prepaid";
            this.Prepaid.ReadOnly = true;
            this.Prepaid.Width = 70;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 165;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 165;
            // 
            // ExpID
            // 
            this.ExpID.HeaderText = "ExpID";
            this.ExpID.Name = "ExpID";
            this.ExpID.ReadOnly = true;
            this.ExpID.Visible = false;
            // 
            // tlEditButtons
            // 
            this.tlEditButtons.ColumnCount = 7;
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.45378F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.44538F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlEditButtons.Controls.Add(this.btnEditOtherExp, 6, 0);
            this.tlEditButtons.Controls.Add(this.btnAddOtherExp, 4, 0);
            this.tlEditButtons.Controls.Add(this.btnDeleteOtherExp, 2, 0);
            this.tlEditButtons.Controls.Add(this.btnClose, 0, 0);
            this.tlEditButtons.Controls.Add(this.label3, 3, 0);
            this.tlEditButtons.Controls.Add(this.label2, 5, 0);
            this.tlEditButtons.Controls.Add(this.label4, 1, 0);
            this.tlEditButtons.Location = new System.Drawing.Point(375, 10);
            this.tlEditButtons.Name = "tlEditButtons";
            this.tlEditButtons.RowCount = 1;
            this.tlEditButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEditButtons.Size = new System.Drawing.Size(215, 38);
            this.tlEditButtons.TabIndex = 3;
            // 
            // btnEditOtherExp
            // 
            this.btnEditOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditOtherExp.FlatAppearance.BorderSize = 0;
            this.btnEditOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOtherExp.Image = global::TravelExpenses.Properties.Resources.if_General_Office_09_2530835;
            this.btnEditOtherExp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditOtherExp.Location = new System.Drawing.Point(168, 3);
            this.btnEditOtherExp.Name = "btnEditOtherExp";
            this.btnEditOtherExp.Size = new System.Drawing.Size(37, 32);
            this.btnEditOtherExp.TabIndex = 0;
            this.btnEditOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditOtherExp, "Edit Expense");
            this.btnEditOtherExp.UseVisualStyleBackColor = true;
            this.btnEditOtherExp.Click += new System.EventHandler(this.btnEditOtherExp_Click);
            // 
            // btnAddOtherExp
            // 
            this.btnAddOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOtherExp.FlatAppearance.BorderSize = 0;
            this.btnAddOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOtherExp.Image = global::TravelExpenses.Properties.Resources.if_add1__32378__1_;
            this.btnAddOtherExp.Location = new System.Drawing.Point(103, 3);
            this.btnAddOtherExp.Name = "btnAddOtherExp";
            this.btnAddOtherExp.Size = new System.Drawing.Size(36, 32);
            this.btnAddOtherExp.TabIndex = 1;
            this.btnAddOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddOtherExp, "Add Expense");
            this.btnAddOtherExp.UseVisualStyleBackColor = true;
            this.btnAddOtherExp.Click += new System.EventHandler(this.btnAddOtherExp_Click);
            // 
            // btnDeleteOtherExp
            // 
            this.btnDeleteOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOtherExp.FlatAppearance.BorderSize = 0;
            this.btnDeleteOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOtherExp.Image = global::TravelExpenses.Properties.Resources.if_edit_delete_118920;
            this.btnDeleteOtherExp.Location = new System.Drawing.Point(55, 3);
            this.btnDeleteOtherExp.Name = "btnDeleteOtherExp";
            this.btnDeleteOtherExp.Size = new System.Drawing.Size(29, 32);
            this.btnDeleteOtherExp.TabIndex = 2;
            this.btnDeleteOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteOtherExp, "Delete Expense");
            this.btnDeleteOtherExp.UseVisualStyleBackColor = true;
            this.btnDeleteOtherExp.Click += new System.EventHandler(this.btnDeleteOtherExp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::TravelExpenses.Properties.Resources.if_Shutdown_Box_Red_34246;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(7, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 209);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.86942F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.13058F));
            this.tableLayoutPanel3.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(35, 142);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(517, 55);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(4, 21);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(85, 13);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(96, 5);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(417, 44);
            this.txtNotes.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAmount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPrepaid, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAmount, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chxPrepaid, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(35, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 121);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(4, 17);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(199, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(4, 59);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(199, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // lblPrepaid
            // 
            this.lblPrepaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrepaid.AutoSize = true;
            this.lblPrepaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepaid.Location = new System.Drawing.Point(4, 95);
            this.lblPrepaid.Name = "lblPrepaid";
            this.lblPrepaid.Size = new System.Drawing.Size(199, 13);
            this.lblPrepaid.TabIndex = 2;
            this.lblPrepaid.Text = "P-Card paid?";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(210, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(303, 40);
            this.txtDescription.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAmount.Location = new System.Drawing.Point(210, 55);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(167, 20);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // chxPrepaid
            // 
            this.chxPrepaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxPrepaid.AutoSize = true;
            this.chxPrepaid.Location = new System.Drawing.Point(210, 95);
            this.chxPrepaid.Name = "chxPrepaid";
            this.chxPrepaid.Size = new System.Drawing.Size(15, 14);
            this.chxPrepaid.TabIndex = 5;
            this.chxPrepaid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.90419F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(490, 420);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(79, 34);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnSaveOtherExp
            // 
            this.btnSaveOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveOtherExp.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveOtherExp.FlatAppearance.BorderSize = 0;
            this.btnSaveOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOtherExp.ForeColor = System.Drawing.Color.Black;
            this.btnSaveOtherExp.Image = global::TravelExpenses.Properties.Resources._1495047519_Save;
            this.btnSaveOtherExp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOtherExp.Location = new System.Drawing.Point(501, 421);
            this.btnSaveOtherExp.Name = "btnSaveOtherExp";
            this.btnSaveOtherExp.Size = new System.Drawing.Size(76, 33);
            this.btnSaveOtherExp.TabIndex = 0;
            this.btnSaveOtherExp.Text = "Save";
            this.btnSaveOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveOtherExp.UseVisualStyleBackColor = false;
            this.btnSaveOtherExp.Click += new System.EventHandler(this.btnSaveOtherExp_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(10, 28);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(23, 20);
            this.btnInfo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnInfo, "Select an expense from the list and then click on the option that you want to per" +
        "form on it.");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelEdit.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelEdit.Location = new System.Drawing.Point(15, 422);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(87, 33);
            this.btnCancelEdit.TabIndex = 1;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditOtherExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 456);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveOtherExp);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlEditButtons);
            this.Controls.Add(this.dgvEditOtherExp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditOtherExpenses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Other Expenses";
            this.Load += new System.EventHandler(this.EditOtherExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditOtherExp)).EndInit();
            this.tlEditButtons.ResumeLayout(false);
            this.tlEditButtons.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEditOtherExp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prepaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpID;
        private System.Windows.Forms.TableLayoutPanel tlEditButtons;
        private System.Windows.Forms.Button btnEditOtherExp;
        private System.Windows.Forms.Button btnAddOtherExp;
        private System.Windows.Forms.Button btnDeleteOtherExp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPrepaid;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.CheckBox chxPrepaid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSaveOtherExp;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}