namespace TravelExpenses
{
    partial class OtherExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherExpenses));
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblDescription = new System.Windows.Forms.Label();
            txtExpenseDescription = new System.Windows.Forms.TextBox();
            lblAmount = new System.Windows.Forms.Label();
            txtExpenseAmount = new System.Windows.Forms.TextBox();
            lblPrepaid = new System.Windows.Forms.Label();
            chxPrepaid = new System.Windows.Forms.CheckBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblExpensesNotes = new System.Windows.Forms.Label();
            txtExpensesNotes = new System.Windows.Forms.TextBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnExpenseAmount = new System.Windows.Forms.Button();
            lblHeaderExpenses = new System.Windows.Forms.Label();
            dgvOtherExpenses = new System.Windows.Forms.DataGridView();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnNextExpenses = new System.Windows.Forms.Button();
            btnBackExpenses = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnCancelExpenses = new System.Windows.Forms.Button();
            lblListExpenses = new System.Windows.Forms.Label();
            PCardPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Delete = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOtherExpenses).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new System.Drawing.Point(28, 62);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(644, 220);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.19876F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.80124F));
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 0);
            tableLayoutPanel1.Controls.Add(txtExpenseDescription, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAmount, 0, 1);
            tableLayoutPanel1.Controls.Add(txtExpenseAmount, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPrepaid, 0, 2);
            tableLayoutPanel1.Controls.Add(chxPrepaid, 1, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(30, 32);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Size = new System.Drawing.Size(574, 114);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(4, 11);
            lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(211, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description:";
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Location = new System.Drawing.Point(223, 3);
            txtExpenseDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtExpenseDescription.Multiline = true;
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtExpenseDescription.Size = new System.Drawing.Size(347, 29);
            txtExpenseDescription.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Location = new System.Drawing.Point(4, 49);
            lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(211, 15);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount:";
            // 
            // txtExpenseAmount
            // 
            txtExpenseAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtExpenseAmount.Location = new System.Drawing.Point(223, 45);
            txtExpenseAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtExpenseAmount.Name = "txtExpenseAmount";
            txtExpenseAmount.Size = new System.Drawing.Size(116, 23);
            txtExpenseAmount.TabIndex = 4;
            txtExpenseAmount.KeyPress += txtExpenseAmount_KeyPress;
            // 
            // lblPrepaid
            // 
            lblPrepaid.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPrepaid.AutoSize = true;
            lblPrepaid.Location = new System.Drawing.Point(4, 87);
            lblPrepaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrepaid.Name = "lblPrepaid";
            lblPrepaid.Size = new System.Drawing.Size(211, 15);
            lblPrepaid.TabIndex = 5;
            lblPrepaid.Text = "P-Card Paid?";
            // 
            // chxPrepaid
            // 
            chxPrepaid.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            chxPrepaid.AutoSize = true;
            chxPrepaid.Location = new System.Drawing.Point(223, 88);
            chxPrepaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxPrepaid.Name = "chxPrepaid";
            chxPrepaid.Size = new System.Drawing.Size(347, 14);
            chxPrepaid.TabIndex = 6;
            chxPrepaid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88175F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.11826F));
            tableLayoutPanel2.Controls.Add(lblExpensesNotes, 0, 0);
            tableLayoutPanel2.Controls.Add(txtExpensesNotes, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(30, 153);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(574, 53);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblExpensesNotes
            // 
            lblExpensesNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblExpensesNotes.AutoSize = true;
            lblExpensesNotes.Location = new System.Drawing.Point(4, 19);
            lblExpensesNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblExpensesNotes.Name = "lblExpensesNotes";
            lblExpensesNotes.Size = new System.Drawing.Size(71, 15);
            lblExpensesNotes.TabIndex = 0;
            lblExpensesNotes.Text = "Notes:";
            // 
            // txtExpensesNotes
            // 
            txtExpensesNotes.Location = new System.Drawing.Point(83, 3);
            txtExpensesNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtExpensesNotes.Multiline = true;
            txtExpensesNotes.Name = "txtExpensesNotes";
            txtExpensesNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtExpensesNotes.Size = new System.Drawing.Size(487, 46);
            txtExpensesNotes.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnExpenseAmount, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(98, 295);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(574, 54);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnExpenseAmount
            // 
            btnExpenseAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnExpenseAmount.BackColor = System.Drawing.Color.Azure;
            btnExpenseAmount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnExpenseAmount.FlatAppearance.BorderSize = 5;
            btnExpenseAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnExpenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExpenseAmount.Image = (System.Drawing.Image)resources.GetObject("btnExpenseAmount.Image");
            btnExpenseAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnExpenseAmount.Location = new System.Drawing.Point(367, 4);
            btnExpenseAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExpenseAmount.Name = "btnExpenseAmount";
            btnExpenseAmount.Size = new System.Drawing.Size(203, 46);
            btnExpenseAmount.TabIndex = 3;
            btnExpenseAmount.Text = "Add Expense to the List";
            btnExpenseAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExpenseAmount.UseVisualStyleBackColor = false;
            btnExpenseAmount.Click += btnExpenseAmount_Click;
            // 
            // lblHeaderExpenses
            // 
            lblHeaderExpenses.AutoSize = true;
            lblHeaderExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblHeaderExpenses.Location = new System.Drawing.Point(23, 31);
            lblHeaderExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeaderExpenses.Name = "lblHeaderExpenses";
            lblHeaderExpenses.Size = new System.Drawing.Size(193, 20);
            lblHeaderExpenses.TabIndex = 1;
            lblHeaderExpenses.Text = "Enter Expense Details:";
            // 
            // dgvOtherExpenses
            // 
            dgvOtherExpenses.AllowUserToAddRows = false;
            dgvOtherExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOtherExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PCardPaid, Description, Amount, Notes, Delete });
            dgvOtherExpenses.Location = new System.Drawing.Point(24, 410);
            dgvOtherExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvOtherExpenses.Name = "dgvOtherExpenses";
            dgvOtherExpenses.ReadOnly = true;
            dgvOtherExpenses.RowTemplate.Height = 30;
            dgvOtherExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOtherExpenses.Size = new System.Drawing.Size(644, 180);
            dgvOtherExpenses.TabIndex = 2;
            dgvOtherExpenses.CellContentClick += dgvOtherExpenses_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.53061F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46939F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            tableLayoutPanel3.Controls.Add(btnNextExpenses, 2, 0);
            tableLayoutPanel3.Controls.Add(btnBackExpenses, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(482, 597);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(205, 46);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // btnNextExpenses
            // 
            btnNextExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNextExpenses.FlatAppearance.BorderSize = 0;
            btnNextExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNextExpenses.Image = (System.Drawing.Image)resources.GetObject("btnNextExpenses.Image");
            btnNextExpenses.Location = new System.Drawing.Point(113, 3);
            btnNextExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNextExpenses.Name = "btnNextExpenses";
            btnNextExpenses.Size = new System.Drawing.Size(84, 39);
            btnNextExpenses.TabIndex = 2;
            btnNextExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNextExpenses.UseVisualStyleBackColor = true;
            btnNextExpenses.Click += btnNextExpenses_Click;
            // 
            // btnBackExpenses
            // 
            btnBackExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBackExpenses.FlatAppearance.BorderSize = 0;
            btnBackExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBackExpenses.Image = (System.Drawing.Image)resources.GetObject("btnBackExpenses.Image");
            btnBackExpenses.Location = new System.Drawing.Point(4, 3);
            btnBackExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBackExpenses.Name = "btnBackExpenses";
            btnBackExpenses.Size = new System.Drawing.Size(73, 39);
            btnBackExpenses.TabIndex = 1;
            btnBackExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBackExpenses.UseVisualStyleBackColor = true;
            btnBackExpenses.Click += btnBackExpenses_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(85, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(16, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelExpenses
            // 
            btnCancelExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelExpenses.FlatAppearance.BorderSize = 0;
            btnCancelExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelExpenses.Image = (System.Drawing.Image)resources.GetObject("btnCancelExpenses.Image");
            btnCancelExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelExpenses.Location = new System.Drawing.Point(14, 603);
            btnCancelExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelExpenses.Name = "btnCancelExpenses";
            btnCancelExpenses.Size = new System.Drawing.Size(95, 39);
            btnCancelExpenses.TabIndex = 0;
            btnCancelExpenses.Text = "Cancel";
            btnCancelExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelExpenses.UseVisualStyleBackColor = true;
            btnCancelExpenses.Click += btnCancelExpenses_Click;
            // 
            // lblListExpenses
            // 
            lblListExpenses.AutoSize = true;
            lblListExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblListExpenses.Location = new System.Drawing.Point(23, 376);
            lblListExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblListExpenses.Name = "lblListExpenses";
            lblListExpenses.Size = new System.Drawing.Size(121, 20);
            lblListExpenses.TabIndex = 5;
            lblListExpenses.Text = "Expenses List";
            // 
            // PCardPaid
            // 
            PCardPaid.HeaderText = "PCard Paid";
            PCardPaid.Name = "PCardPaid";
            PCardPaid.ReadOnly = true;
            PCardPaid.Width = 80;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 240;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 80;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Visible = false;
            Notes.Width = 150;
            // 
            // Delete
            // 
            Delete.Description = "Delete";
            Delete.HeaderText = "";
            Delete.Image = (System.Drawing.Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.ToolTipText = "Delete";
            // 
            // OtherExpenses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(701, 657);
            ControlBox = false;
            Controls.Add(tableLayoutPanel4);
            Controls.Add(btnCancelExpenses);
            Controls.Add(lblListExpenses);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(dgvOtherExpenses);
            Controls.Add(lblHeaderExpenses);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "OtherExpenses";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Other Expenses";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOtherExpenses).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtExpenseDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Label lblHeaderExpenses;
        private System.Windows.Forms.DataGridView dgvOtherExpenses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblExpensesNotes;
        private System.Windows.Forms.TextBox txtExpensesNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancelExpenses;
        private System.Windows.Forms.Button btnBackExpenses;
        private System.Windows.Forms.Button btnNextExpenses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblPrepaid;
        private System.Windows.Forms.CheckBox chxPrepaid;
        private System.Windows.Forms.Label lblListExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PCardPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}