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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOtherExpenses));
            dgvEditOtherExp = new System.Windows.Forms.DataGridView();
            Prepaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ExpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tlEditButtons = new System.Windows.Forms.TableLayoutPanel();
            btnEditOtherExp = new System.Windows.Forms.Button();
            btnAddOtherExp = new System.Windows.Forms.Button();
            btnDeleteOtherExp = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblDescription = new System.Windows.Forms.Label();
            lblAmount = new System.Windows.Forms.Label();
            lblPrepaid = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            txtAmount = new System.Windows.Forms.TextBox();
            chxPrepaid = new System.Windows.Forms.CheckBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnSaveOtherExp = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnInfo = new System.Windows.Forms.Button();
            btnCancelEdit = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvEditOtherExp).BeginInit();
            tlEditButtons.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEditOtherExp
            // 
            dgvEditOtherExp.AllowUserToAddRows = false;
            dgvEditOtherExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditOtherExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Prepaid, Description, Amount, Notes, ExpID });
            dgvEditOtherExp.Location = new System.Drawing.Point(8, 60);
            dgvEditOtherExp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvEditOtherExp.Name = "dgvEditOtherExp";
            dgvEditOtherExp.ReadOnly = true;
            dgvEditOtherExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEditOtherExp.Size = new System.Drawing.Size(670, 133);
            dgvEditOtherExp.TabIndex = 2;
            // 
            // Prepaid
            // 
            Prepaid.HeaderText = "P-Card Paid";
            Prepaid.Name = "Prepaid";
            Prepaid.ReadOnly = true;
            Prepaid.Width = 70;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 165;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Width = 165;
            // 
            // ExpID
            // 
            ExpID.HeaderText = "ExpID";
            ExpID.Name = "ExpID";
            ExpID.ReadOnly = true;
            ExpID.Visible = false;
            // 
            // tlEditButtons
            // 
            tlEditButtons.ColumnCount = 7;
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.0895538F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.9253731F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.5671654F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.41791F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            tlEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlEditButtons.Controls.Add(btnEditOtherExp, 6, 0);
            tlEditButtons.Controls.Add(btnAddOtherExp, 4, 0);
            tlEditButtons.Controls.Add(btnDeleteOtherExp, 2, 0);
            tlEditButtons.Controls.Add(btnClose, 0, 0);
            tlEditButtons.Controls.Add(label3, 3, 0);
            tlEditButtons.Controls.Add(label2, 5, 0);
            tlEditButtons.Controls.Add(label4, 1, 0);
            tlEditButtons.Location = new System.Drawing.Point(438, 12);
            tlEditButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlEditButtons.Name = "tlEditButtons";
            tlEditButtons.RowCount = 1;
            tlEditButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlEditButtons.Size = new System.Drawing.Size(239, 44);
            tlEditButtons.TabIndex = 3;
            // 
            // btnEditOtherExp
            // 
            btnEditOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEditOtherExp.FlatAppearance.BorderSize = 0;
            btnEditOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditOtherExp.Image = (System.Drawing.Image)resources.GetObject("btnEditOtherExp.Image");
            btnEditOtherExp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEditOtherExp.Location = new System.Drawing.Point(195, 3);
            btnEditOtherExp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditOtherExp.Name = "btnEditOtherExp";
            btnEditOtherExp.Size = new System.Drawing.Size(40, 37);
            btnEditOtherExp.TabIndex = 0;
            btnEditOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnEditOtherExp, "Edit Expense");
            btnEditOtherExp.UseVisualStyleBackColor = true;
            btnEditOtherExp.Click += btnEditOtherExp_Click;
            // 
            // btnAddOtherExp
            // 
            btnAddOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddOtherExp.FlatAppearance.BorderSize = 0;
            btnAddOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddOtherExp.Image = (System.Drawing.Image)resources.GetObject("btnAddOtherExp.Image");
            btnAddOtherExp.Location = new System.Drawing.Point(131, 3);
            btnAddOtherExp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddOtherExp.Name = "btnAddOtherExp";
            btnAddOtherExp.Size = new System.Drawing.Size(37, 37);
            btnAddOtherExp.TabIndex = 1;
            btnAddOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnAddOtherExp, "Add Expense");
            btnAddOtherExp.UseVisualStyleBackColor = true;
            btnAddOtherExp.Click += btnAddOtherExp_Click;
            // 
            // btnDeleteOtherExp
            // 
            btnDeleteOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteOtherExp.FlatAppearance.BorderSize = 0;
            btnDeleteOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDeleteOtherExp.Image = (System.Drawing.Image)resources.GetObject("btnDeleteOtherExp.Image");
            btnDeleteOtherExp.Location = new System.Drawing.Point(66, 3);
            btnDeleteOtherExp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteOtherExp.Name = "btnDeleteOtherExp";
            btnDeleteOtherExp.Size = new System.Drawing.Size(34, 37);
            btnDeleteOtherExp.TabIndex = 2;
            btnDeleteOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnDeleteOtherExp, "Delete Expense");
            btnDeleteOtherExp.UseVisualStyleBackColor = true;
            btnDeleteOtherExp.Click += btnDeleteOtherExp_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(4, 3);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(33, 37);
            btnClose.TabIndex = 3;
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnClose, "Close");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(110, 13);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(13, 17);
            label3.TabIndex = 5;
            label3.Text = "|";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(176, 13);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(11, 17);
            label2.TabIndex = 4;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(45, 13);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(11, 17);
            label4.TabIndex = 6;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new System.Drawing.Point(8, 232);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(669, 241);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.86942F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.13058F));
            tableLayoutPanel3.Controls.Add(lblNotes, 0, 0);
            tableLayoutPanel3.Controls.Add(txtNotes, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(41, 164);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(603, 63);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(5, 25);
            lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(99, 13);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(113, 6);
            txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(485, 50);
            txtNotes.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(lblDescription, 0, 0);
            tableLayoutPanel2.Controls.Add(lblAmount, 0, 1);
            tableLayoutPanel2.Controls.Add(lblPrepaid, 0, 2);
            tableLayoutPanel2.Controls.Add(txtDescription, 1, 0);
            tableLayoutPanel2.Controls.Add(txtAmount, 1, 1);
            tableLayoutPanel2.Controls.Add(chxPrepaid, 1, 2);
            tableLayoutPanel2.Location = new System.Drawing.Point(41, 17);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel2.Size = new System.Drawing.Size(603, 140);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDescription.Location = new System.Drawing.Point(5, 21);
            lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(232, 13);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description:";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAmount.Location = new System.Drawing.Point(5, 69);
            lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(232, 13);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblPrepaid
            // 
            lblPrepaid.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPrepaid.AutoSize = true;
            lblPrepaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrepaid.Location = new System.Drawing.Point(5, 111);
            lblPrepaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrepaid.Name = "lblPrepaid";
            lblPrepaid.Size = new System.Drawing.Size(232, 13);
            lblPrepaid.TabIndex = 2;
            lblPrepaid.Text = "P-Card paid?";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDescription.Location = new System.Drawing.Point(246, 5);
            txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtDescription.Size = new System.Drawing.Size(352, 46);
            txtDescription.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtAmount.Location = new System.Drawing.Point(246, 64);
            txtAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new System.Drawing.Size(194, 23);
            txtAmount.TabIndex = 4;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // chxPrepaid
            // 
            chxPrepaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chxPrepaid.AutoSize = true;
            chxPrepaid.Location = new System.Drawing.Point(246, 111);
            chxPrepaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxPrepaid.Name = "chxPrepaid";
            chxPrepaid.Size = new System.Drawing.Size(15, 14);
            chxPrepaid.TabIndex = 5;
            chxPrepaid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.90419F));
            tableLayoutPanel4.Location = new System.Drawing.Point(296, 479);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(92, 32);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // btnSaveOtherExp
            // 
            btnSaveOtherExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSaveOtherExp.BackColor = System.Drawing.Color.Transparent;
            btnSaveOtherExp.FlatAppearance.BorderSize = 0;
            btnSaveOtherExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveOtherExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSaveOtherExp.ForeColor = System.Drawing.Color.Black;
            btnSaveOtherExp.Image = (System.Drawing.Image)resources.GetObject("btnSaveOtherExp.Image");
            btnSaveOtherExp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaveOtherExp.Location = new System.Drawing.Point(600, 479);
            btnSaveOtherExp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSaveOtherExp.Name = "btnSaveOtherExp";
            btnSaveOtherExp.Size = new System.Drawing.Size(77, 38);
            btnSaveOtherExp.TabIndex = 0;
            btnSaveOtherExp.Text = "Save";
            btnSaveOtherExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSaveOtherExp.UseVisualStyleBackColor = false;
            btnSaveOtherExp.Click += btnSaveOtherExp_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new System.Drawing.Point(12, 32);
            btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(27, 23);
            btnInfo.TabIndex = 6;
            toolTip1.SetToolTip(btnInfo, "Select an expense from the list and then click on the option that you want to perform on it.");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelEdit.BackColor = System.Drawing.Color.Transparent;
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelEdit.ForeColor = System.Drawing.Color.Black;
            btnCancelEdit.Image = (System.Drawing.Image)resources.GetObject("btnCancelEdit.Image");
            btnCancelEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelEdit.Location = new System.Drawing.Point(8, 479);
            btnCancelEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new System.Drawing.Size(90, 38);
            btnCancelEdit.TabIndex = 1;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // EditOtherExpenses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(682, 518);
            ControlBox = false;
            Controls.Add(btnSaveOtherExp);
            Controls.Add(btnInfo);
            Controls.Add(btnCancelEdit);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(panel1);
            Controls.Add(tlEditButtons);
            Controls.Add(dgvEditOtherExp);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditOtherExpenses";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Other Expenses";
            Load += EditOtherExpenses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditOtherExp).EndInit();
            tlEditButtons.ResumeLayout(false);
            tlEditButtons.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
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