namespace TravelExpenses
{
    partial class EditMeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMeals));
            dgvEditMeals = new System.Windows.Forms.DataGridView();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Breakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Lunch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Dinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MealsDateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblTotalMeals = new System.Windows.Forms.Label();
            txtMealsTotal = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            pProvidedMeals = new System.Windows.Forms.Panel();
            rbNoProvidedMeal = new System.Windows.Forms.RadioButton();
            rbYesProvidedMeal = new System.Windows.Forms.RadioButton();
            lblMelasProvided = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnUpdateMeals = new System.Windows.Forms.Button();
            btnCancelUpdateMeals = new System.Windows.Forms.Button();
            lblTotalPerDiemRateValue = new System.Windows.Forms.Label();
            lblTotalPerDiemRate = new System.Windows.Forms.Label();
            lblDinner = new System.Windows.Forms.Label();
            txtDinner = new System.Windows.Forms.TextBox();
            lblLunch = new System.Windows.Forms.Label();
            txtLunch = new System.Windows.Forms.TextBox();
            lblBreakfast = new System.Windows.Forms.Label();
            btnCalculateMeals = new System.Windows.Forms.Button();
            txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            lblMealsPerDiemRate = new System.Windows.Forms.Label();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            lblZipCode = new System.Windows.Forms.Label();
            txtZipCode = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            lblInfoLink = new System.Windows.Forms.Label();
            linkLabelMealPerDiemRate = new System.Windows.Forms.LinkLabel();
            lblWarninglabel1 = new System.Windows.Forms.Label();
            pWarning = new System.Windows.Forms.Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvEditMeals).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pProvidedMeals.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            pWarning.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEditMeals
            // 
            dgvEditMeals.AllowUserToAddRows = false;
            dgvEditMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Date, Breakfast, Lunch, Dinner, Total, MealsDateID });
            dgvEditMeals.Location = new System.Drawing.Point(31, 209);
            dgvEditMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvEditMeals.Name = "dgvEditMeals";
            dgvEditMeals.Size = new System.Drawing.Size(634, 233);
            dgvEditMeals.TabIndex = 0;
            dgvEditMeals.CellContentClick += dgvEditMeals_CellContentClick;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Breakfast
            // 
            Breakfast.HeaderText = "Breakfast";
            Breakfast.Name = "Breakfast";
            // 
            // Lunch
            // 
            Lunch.HeaderText = "Lunch";
            Lunch.Name = "Lunch";
            // 
            // Dinner
            // 
            Dinner.HeaderText = "Dinner";
            Dinner.Name = "Dinner";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // MealsDateID
            // 
            MealsDateID.HeaderText = "MealsDateID";
            MealsDateID.Name = "MealsDateID";
            MealsDateID.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.82301F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.17699F));
            tableLayoutPanel1.Controls.Add(lblTotalMeals, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMealsTotal, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(31, 449);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(634, 35);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTotalMeals
            // 
            lblTotalMeals.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblTotalMeals.AutoSize = true;
            lblTotalMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalMeals.Location = new System.Drawing.Point(452, 9);
            lblTotalMeals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalMeals.Name = "lblTotalMeals";
            lblTotalMeals.Size = new System.Drawing.Size(50, 17);
            lblTotalMeals.TabIndex = 0;
            lblTotalMeals.Text = "Total:";
            // 
            // txtMealsTotal
            // 
            txtMealsTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsTotal.Location = new System.Drawing.Point(510, 6);
            txtMealsTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMealsTotal.Name = "txtMealsTotal";
            txtMealsTotal.ReadOnly = true;
            txtMealsTotal.Size = new System.Drawing.Size(120, 23);
            txtMealsTotal.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.1547F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.84531F));
            tableLayoutPanel2.Controls.Add(lblNotes, 0, 0);
            tableLayoutPanel2.Controls.Add(txtNotes, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(31, 538);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(634, 60);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.Location = new System.Drawing.Point(5, 21);
            lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(68, 17);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNotes.Location = new System.Drawing.Point(82, 5);
            txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(547, 50);
            txtNotes.TabIndex = 1;
            // 
            // pProvidedMeals
            // 
            pProvidedMeals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pProvidedMeals.Controls.Add(rbNoProvidedMeal);
            pProvidedMeals.Controls.Add(rbYesProvidedMeal);
            pProvidedMeals.Controls.Add(lblMelasProvided);
            pProvidedMeals.Location = new System.Drawing.Point(31, 490);
            pProvidedMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pProvidedMeals.Name = "pProvidedMeals";
            pProvidedMeals.Size = new System.Drawing.Size(633, 40);
            pProvidedMeals.TabIndex = 3;
            // 
            // rbNoProvidedMeal
            // 
            rbNoProvidedMeal.AutoSize = true;
            rbNoProvidedMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbNoProvidedMeal.Location = new System.Drawing.Point(578, 10);
            rbNoProvidedMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoProvidedMeal.Name = "rbNoProvidedMeal";
            rbNoProvidedMeal.Size = new System.Drawing.Size(41, 17);
            rbNoProvidedMeal.TabIndex = 2;
            rbNoProvidedMeal.TabStop = true;
            rbNoProvidedMeal.Text = "No";
            rbNoProvidedMeal.UseVisualStyleBackColor = true;
            // 
            // rbYesProvidedMeal
            // 
            rbYesProvidedMeal.AutoSize = true;
            rbYesProvidedMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rbYesProvidedMeal.Location = new System.Drawing.Point(520, 10);
            rbYesProvidedMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesProvidedMeal.Name = "rbYesProvidedMeal";
            rbYesProvidedMeal.Size = new System.Drawing.Size(46, 17);
            rbYesProvidedMeal.TabIndex = 1;
            rbYesProvidedMeal.TabStop = true;
            rbYesProvidedMeal.Text = "Yes";
            rbYesProvidedMeal.UseVisualStyleBackColor = true;
            // 
            // lblMelasProvided
            // 
            lblMelasProvided.AutoSize = true;
            lblMelasProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMelasProvided.Location = new System.Drawing.Point(4, 10);
            lblMelasProvided.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMelasProvided.Name = "lblMelasProvided";
            lblMelasProvided.Size = new System.Drawing.Size(412, 17);
            lblMelasProvided.TabIndex = 0;
            lblMelasProvided.Text = "Were any of the checked meals above provided to you?";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnUpdateMeals, 1, 0);
            tableLayoutPanel3.Controls.Add(btnCancelUpdateMeals, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(320, 615);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(345, 62);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // btnUpdateMeals
            // 
            btnUpdateMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpdateMeals.FlatAppearance.BorderSize = 0;
            btnUpdateMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdateMeals.Image = (System.Drawing.Image)resources.GetObject("btnUpdateMeals.Image");
            btnUpdateMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUpdateMeals.Location = new System.Drawing.Point(213, 7);
            btnUpdateMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdateMeals.Name = "btnUpdateMeals";
            btnUpdateMeals.Size = new System.Drawing.Size(91, 48);
            btnUpdateMeals.TabIndex = 0;
            btnUpdateMeals.Text = "Update";
            btnUpdateMeals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnUpdateMeals.UseVisualStyleBackColor = true;
            btnUpdateMeals.Click += btnUpdateMeals_Click;
            // 
            // btnCancelUpdateMeals
            // 
            btnCancelUpdateMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelUpdateMeals.FlatAppearance.BorderSize = 0;
            btnCancelUpdateMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelUpdateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelUpdateMeals.Image = (System.Drawing.Image)resources.GetObject("btnCancelUpdateMeals.Image");
            btnCancelUpdateMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelUpdateMeals.Location = new System.Drawing.Point(43, 7);
            btnCancelUpdateMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelUpdateMeals.Name = "btnCancelUpdateMeals";
            btnCancelUpdateMeals.Size = new System.Drawing.Size(86, 48);
            btnCancelUpdateMeals.TabIndex = 1;
            btnCancelUpdateMeals.Text = "Close";
            btnCancelUpdateMeals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelUpdateMeals.UseVisualStyleBackColor = true;
            btnCancelUpdateMeals.Click += btnCancelUpdateMeals_Click;
            // 
            // lblTotalPerDiemRateValue
            // 
            lblTotalPerDiemRateValue.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalPerDiemRateValue.AutoSize = true;
            lblTotalPerDiemRateValue.Location = new System.Drawing.Point(452, 40);
            lblTotalPerDiemRateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalPerDiemRateValue.Name = "lblTotalPerDiemRateValue";
            lblTotalPerDiemRateValue.Size = new System.Drawing.Size(67, 15);
            lblTotalPerDiemRateValue.TabIndex = 29;
            lblTotalPerDiemRateValue.Text = "0";
            lblTotalPerDiemRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRate
            // 
            lblTotalPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalPerDiemRate.AutoSize = true;
            lblTotalPerDiemRate.Location = new System.Drawing.Point(452, 8);
            lblTotalPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalPerDiemRate.Name = "lblTotalPerDiemRate";
            lblTotalPerDiemRate.Size = new System.Drawing.Size(67, 15);
            lblTotalPerDiemRate.TabIndex = 28;
            lblTotalPerDiemRate.Text = "Total";
            lblTotalPerDiemRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDinner
            // 
            lblDinner.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDinner.AutoSize = true;
            lblDinner.Location = new System.Drawing.Point(360, 8);
            lblDinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new System.Drawing.Size(84, 15);
            lblDinner.TabIndex = 27;
            lblDinner.Text = "Dinner";
            lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDinner
            // 
            txtDinner.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDinner.Location = new System.Drawing.Point(360, 36);
            txtDinner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDinner.Name = "txtDinner";
            txtDinner.Size = new System.Drawing.Size(84, 23);
            txtDinner.TabIndex = 26;
            txtDinner.TextChanged += txtDinner_TextChanged;
            txtDinner.KeyPress += txtDinner_KeyPress;
            // 
            // lblLunch
            // 
            lblLunch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLunch.AutoSize = true;
            lblLunch.Location = new System.Drawing.Point(269, 8);
            lblLunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new System.Drawing.Size(83, 15);
            lblLunch.TabIndex = 25;
            lblLunch.Text = "Lunch";
            lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLunch
            // 
            txtLunch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLunch.Location = new System.Drawing.Point(269, 36);
            txtLunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLunch.Name = "txtLunch";
            txtLunch.Size = new System.Drawing.Size(83, 23);
            txtLunch.TabIndex = 24;
            txtLunch.TextChanged += txtLunch_TextChanged;
            txtLunch.KeyPress += txtLunch_KeyPress;
            // 
            // lblBreakfast
            // 
            lblBreakfast.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblBreakfast.AutoSize = true;
            lblBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            lblBreakfast.Location = new System.Drawing.Point(177, 8);
            lblBreakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new System.Drawing.Size(84, 15);
            lblBreakfast.TabIndex = 23;
            lblBreakfast.Text = "Breakfast";
            lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateMeals
            // 
            btnCalculateMeals.Enabled = false;
            btnCalculateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCalculateMeals.ForeColor = System.Drawing.Color.Green;
            btnCalculateMeals.Location = new System.Drawing.Point(536, 103);
            btnCalculateMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCalculateMeals.Name = "btnCalculateMeals";
            btnCalculateMeals.Size = new System.Drawing.Size(84, 27);
            btnCalculateMeals.TabIndex = 22;
            btnCalculateMeals.Text = "Calculate";
            btnCalculateMeals.UseVisualStyleBackColor = true;
            btnCalculateMeals.Click += btnCalculateMeals_Click;
            // 
            // txtMealsPerDiemRate
            // 
            txtMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsPerDiemRate.Location = new System.Drawing.Point(177, 36);
            txtMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            txtMealsPerDiemRate.Size = new System.Drawing.Size(84, 23);
            txtMealsPerDiemRate.TabIndex = 21;
            txtMealsPerDiemRate.TextChanged += txtMealsPerDiemRate_TextChanged;
            txtMealsPerDiemRate.KeyPress += txtMealsPerDiemRate_KeyPress;
            // 
            // lblMealsPerDiemRate
            // 
            lblMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMealsPerDiemRate.AutoSize = true;
            lblMealsPerDiemRate.Location = new System.Drawing.Point(4, 40);
            lblMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            lblMealsPerDiemRate.Size = new System.Drawing.Size(165, 15);
            lblMealsPerDiemRate.TabIndex = 20;
            lblMealsPerDiemRate.Text = "Meals Per Diem Rate:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.03571F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63393F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41072F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63393F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0625F));
            tableLayoutPanel4.Controls.Add(lblBreakfast, 1, 0);
            tableLayoutPanel4.Controls.Add(lblTotalPerDiemRateValue, 4, 1);
            tableLayoutPanel4.Controls.Add(lblLunch, 2, 0);
            tableLayoutPanel4.Controls.Add(txtDinner, 3, 1);
            tableLayoutPanel4.Controls.Add(lblTotalPerDiemRate, 4, 0);
            tableLayoutPanel4.Controls.Add(txtLunch, 2, 1);
            tableLayoutPanel4.Controls.Add(lblDinner, 3, 0);
            tableLayoutPanel4.Controls.Add(lblMealsPerDiemRate, 0, 1);
            tableLayoutPanel4.Controls.Add(txtMealsPerDiemRate, 1, 1);
            tableLayoutPanel4.Controls.Add(lblZipCode, 0, 2);
            tableLayoutPanel4.Controls.Add(txtZipCode, 1, 2);
            tableLayoutPanel4.Location = new System.Drawing.Point(6, 30);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel4.Size = new System.Drawing.Size(523, 97);
            tableLayoutPanel4.TabIndex = 30;
            // 
            // lblZipCode
            // 
            lblZipCode.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new System.Drawing.Point(4, 73);
            lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new System.Drawing.Size(165, 15);
            lblZipCode.TabIndex = 30;
            lblZipCode.Text = "Travel Location Zip Code:";
            // 
            // txtZipCode
            // 
            txtZipCode.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtZipCode.Location = new System.Drawing.Point(177, 69);
            txtZipCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new System.Drawing.Size(84, 23);
            txtZipCode.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(lblInfoLink);
            panel1.Controls.Add(linkLabelMealPerDiemRate);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(btnCalculateMeals);
            panel1.Location = new System.Drawing.Point(31, 20);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(633, 139);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // lblInfoLink
            // 
            lblInfoLink.AutoSize = true;
            lblInfoLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInfoLink.Location = new System.Drawing.Point(9, 7);
            lblInfoLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfoLink.Name = "lblInfoLink";
            lblInfoLink.Size = new System.Drawing.Size(213, 13);
            lblInfoLink.TabIndex = 31;
            lblInfoLink.Text = "Link for checking the Meals Per Diem Rate:";
            // 
            // linkLabelMealPerDiemRate
            // 
            linkLabelMealPerDiemRate.AutoSize = true;
            linkLabelMealPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabelMealPerDiemRate.Location = new System.Drawing.Point(265, 7);
            linkLabelMealPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabelMealPerDiemRate.Name = "linkLabelMealPerDiemRate";
            linkLabelMealPerDiemRate.Size = new System.Drawing.Size(262, 13);
            linkLabelMealPerDiemRate.TabIndex = 32;
            linkLabelMealPerDiemRate.TabStop = true;
            linkLabelMealPerDiemRate.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            linkLabelMealPerDiemRate.LinkClicked += linkLabelMealPerDiemRate_LinkClicked;
            // 
            // lblWarninglabel1
            // 
            lblWarninglabel1.AutoSize = true;
            lblWarninglabel1.BackColor = System.Drawing.Color.Transparent;
            lblWarninglabel1.ForeColor = System.Drawing.Color.DarkRed;
            lblWarninglabel1.Location = new System.Drawing.Point(6, 7);
            lblWarninglabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWarninglabel1.Name = "lblWarninglabel1";
            lblWarninglabel1.Size = new System.Drawing.Size(600, 15);
            lblWarninglabel1.TabIndex = 33;
            lblWarninglabel1.Text = "If you change a Per Diem value, please hit calculate to refresh the data,otherwise your changes will not be saved. ";
            // 
            // pWarning
            // 
            pWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pWarning.Controls.Add(lblWarninglabel1);
            pWarning.Location = new System.Drawing.Point(26, 166);
            pWarning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pWarning.Name = "pWarning";
            pWarning.Size = new System.Drawing.Size(651, 31);
            pWarning.TabIndex = 33;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // EditMeals
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(693, 689);
            ControlBox = false;
            Controls.Add(pWarning);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(pProvidedMeals);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvEditMeals);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditMeals";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Meals";
            Load += EditMeals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditMeals).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pProvidedMeals.ResumeLayout(false);
            pProvidedMeals.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pWarning.ResumeLayout(false);
            pWarning.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditMeals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalMeals;
        private System.Windows.Forms.TextBox txtMealsTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pProvidedMeals;
        private System.Windows.Forms.RadioButton rbNoProvidedMeal;
        private System.Windows.Forms.RadioButton rbYesProvidedMeal;
        private System.Windows.Forms.Label lblMelasProvided;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUpdateMeals;
        private System.Windows.Forms.Button btnCancelUpdateMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Breakfast;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lunch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealsDateID;
        private System.Windows.Forms.Label lblTotalPerDiemRateValue;
        private System.Windows.Forms.Label lblTotalPerDiemRate;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Button btnCalculateMeals;
        private System.Windows.Forms.TextBox txtMealsPerDiemRate;
        private System.Windows.Forms.Label lblMealsPerDiemRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblInfoLink;
        private System.Windows.Forms.LinkLabel linkLabelMealPerDiemRate;
        private System.Windows.Forms.Label lblWarninglabel1;
        private System.Windows.Forms.Panel pWarning;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}