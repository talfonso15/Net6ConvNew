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
            this.dgvEditMeals = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lunch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealsDateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalMeals = new System.Windows.Forms.Label();
            this.txtMealsTotal = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pProvidedMeals = new System.Windows.Forms.Panel();
            this.rbNoProvidedMeal = new System.Windows.Forms.RadioButton();
            this.rbYesProvidedMeal = new System.Windows.Forms.RadioButton();
            this.lblMelasProvided = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateMeals = new System.Windows.Forms.Button();
            this.btnCancelUpdateMeals = new System.Windows.Forms.Button();
            this.lblTotalPerDiemRateValue = new System.Windows.Forms.Label();
            this.lblTotalPerDiemRate = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.lblLunch = new System.Windows.Forms.Label();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.btnCalculateMeals = new System.Windows.Forms.Button();
            this.txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            this.lblMealsPerDiemRate = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoLink = new System.Windows.Forms.Label();
            this.linkLabelMealPerDiemRate = new System.Windows.Forms.LinkLabel();
            this.lblWarninglabel1 = new System.Windows.Forms.Label();
            this.pWarning = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditMeals)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pProvidedMeals.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEditMeals
            // 
            this.dgvEditMeals.AllowUserToAddRows = false;
            this.dgvEditMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Breakfast,
            this.Lunch,
            this.Dinner,
            this.Total,
            this.MealsDateID});
            this.dgvEditMeals.Location = new System.Drawing.Point(27, 181);
            this.dgvEditMeals.Name = "dgvEditMeals";
            this.dgvEditMeals.Size = new System.Drawing.Size(543, 202);
            this.dgvEditMeals.TabIndex = 0;
            this.dgvEditMeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditMeals_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Breakfast
            // 
            this.Breakfast.HeaderText = "Breakfast";
            this.Breakfast.Name = "Breakfast";
            // 
            // Lunch
            // 
            this.Lunch.HeaderText = "Lunch";
            this.Lunch.Name = "Lunch";
            // 
            // Dinner
            // 
            this.Dinner.HeaderText = "Dinner";
            this.Dinner.Name = "Dinner";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // MealsDateID
            // 
            this.MealsDateID.HeaderText = "MealsDateID";
            this.MealsDateID.Name = "MealsDateID";
            this.MealsDateID.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.82301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.17699F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalMeals, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMealsTotal, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 389);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTotalMeals
            // 
            this.lblTotalMeals.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalMeals.AutoSize = true;
            this.lblTotalMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMeals.Location = new System.Drawing.Point(380, 6);
            this.lblTotalMeals.Name = "lblTotalMeals";
            this.lblTotalMeals.Size = new System.Drawing.Size(50, 17);
            this.lblTotalMeals.TabIndex = 0;
            this.lblTotalMeals.Text = "Total:";
            // 
            // txtMealsTotal
            // 
            this.txtMealsTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsTotal.Location = new System.Drawing.Point(436, 5);
            this.txtMealsTotal.Name = "txtMealsTotal";
            this.txtMealsTotal.ReadOnly = true;
            this.txtMealsTotal.Size = new System.Drawing.Size(104, 20);
            this.txtMealsTotal.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.1547F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.84531F));
            this.tableLayoutPanel2.Controls.Add(this.lblNotes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNotes, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 466);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(543, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(4, 17);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(59, 17);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(70, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(469, 44);
            this.txtNotes.TabIndex = 1;
            // 
            // pProvidedMeals
            // 
            this.pProvidedMeals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pProvidedMeals.Controls.Add(this.rbNoProvidedMeal);
            this.pProvidedMeals.Controls.Add(this.rbYesProvidedMeal);
            this.pProvidedMeals.Controls.Add(this.lblMelasProvided);
            this.pProvidedMeals.Location = new System.Drawing.Point(27, 425);
            this.pProvidedMeals.Name = "pProvidedMeals";
            this.pProvidedMeals.Size = new System.Drawing.Size(543, 35);
            this.pProvidedMeals.TabIndex = 3;
            // 
            // rbNoProvidedMeal
            // 
            this.rbNoProvidedMeal.AutoSize = true;
            this.rbNoProvidedMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoProvidedMeal.Location = new System.Drawing.Point(495, 9);
            this.rbNoProvidedMeal.Name = "rbNoProvidedMeal";
            this.rbNoProvidedMeal.Size = new System.Drawing.Size(41, 17);
            this.rbNoProvidedMeal.TabIndex = 2;
            this.rbNoProvidedMeal.TabStop = true;
            this.rbNoProvidedMeal.Text = "No";
            this.rbNoProvidedMeal.UseVisualStyleBackColor = true;
            // 
            // rbYesProvidedMeal
            // 
            this.rbYesProvidedMeal.AutoSize = true;
            this.rbYesProvidedMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYesProvidedMeal.Location = new System.Drawing.Point(446, 9);
            this.rbYesProvidedMeal.Name = "rbYesProvidedMeal";
            this.rbYesProvidedMeal.Size = new System.Drawing.Size(46, 17);
            this.rbYesProvidedMeal.TabIndex = 1;
            this.rbYesProvidedMeal.TabStop = true;
            this.rbYesProvidedMeal.Text = "Yes";
            this.rbYesProvidedMeal.UseVisualStyleBackColor = true;
            // 
            // lblMelasProvided
            // 
            this.lblMelasProvided.AutoSize = true;
            this.lblMelasProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMelasProvided.Location = new System.Drawing.Point(3, 9);
            this.lblMelasProvided.Name = "lblMelasProvided";
            this.lblMelasProvided.Size = new System.Drawing.Size(412, 17);
            this.lblMelasProvided.TabIndex = 0;
            this.lblMelasProvided.Text = "Were any of the checked meals above provided to you?";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateMeals, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelUpdateMeals, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(274, 533);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(296, 54);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnUpdateMeals
            // 
            this.btnUpdateMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateMeals.FlatAppearance.BorderSize = 0;
            this.btnUpdateMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMeals.Image = global::TravelExpenses.Properties.Resources._1495734626_db_update;
            this.btnUpdateMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMeals.Location = new System.Drawing.Point(174, 6);
            this.btnUpdateMeals.Name = "btnUpdateMeals";
            this.btnUpdateMeals.Size = new System.Drawing.Size(95, 42);
            this.btnUpdateMeals.TabIndex = 0;
            this.btnUpdateMeals.Text = "Update";
            this.btnUpdateMeals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateMeals.UseVisualStyleBackColor = true;
            this.btnUpdateMeals.Click += new System.EventHandler(this.btnUpdateMeals_Click);
            // 
            // btnCancelUpdateMeals
            // 
            this.btnCancelUpdateMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelUpdateMeals.FlatAppearance.BorderSize = 0;
            this.btnCancelUpdateMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUpdateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdateMeals.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelUpdateMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelUpdateMeals.Location = new System.Drawing.Point(32, 6);
            this.btnCancelUpdateMeals.Name = "btnCancelUpdateMeals";
            this.btnCancelUpdateMeals.Size = new System.Drawing.Size(84, 42);
            this.btnCancelUpdateMeals.TabIndex = 1;
            this.btnCancelUpdateMeals.Text = "Close";
            this.btnCancelUpdateMeals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelUpdateMeals.UseVisualStyleBackColor = true;
            this.btnCancelUpdateMeals.Click += new System.EventHandler(this.btnCancelUpdateMeals_Click);
            // 
            // lblTotalPerDiemRateValue
            // 
            this.lblTotalPerDiemRateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPerDiemRateValue.AutoSize = true;
            this.lblTotalPerDiemRateValue.Location = new System.Drawing.Point(387, 35);
            this.lblTotalPerDiemRateValue.Name = "lblTotalPerDiemRateValue";
            this.lblTotalPerDiemRateValue.Size = new System.Drawing.Size(58, 13);
            this.lblTotalPerDiemRateValue.TabIndex = 29;
            this.lblTotalPerDiemRateValue.Text = "0";
            this.lblTotalPerDiemRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRate
            // 
            this.lblTotalPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPerDiemRate.AutoSize = true;
            this.lblTotalPerDiemRate.Location = new System.Drawing.Point(387, 7);
            this.lblTotalPerDiemRate.Name = "lblTotalPerDiemRate";
            this.lblTotalPerDiemRate.Size = new System.Drawing.Size(58, 13);
            this.lblTotalPerDiemRate.TabIndex = 28;
            this.lblTotalPerDiemRate.Text = "Total";
            this.lblTotalPerDiemRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDinner
            // 
            this.lblDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(308, 7);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(73, 13);
            this.lblDinner.TabIndex = 27;
            this.lblDinner.Text = "Dinner";
            this.lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDinner
            // 
            this.txtDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDinner.Location = new System.Drawing.Point(308, 32);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(73, 20);
            this.txtDinner.TabIndex = 26;
            this.txtDinner.TextChanged += new System.EventHandler(this.txtDinner_TextChanged);
            this.txtDinner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinner_KeyPress);
            // 
            // lblLunch
            // 
            this.lblLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(230, 7);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(72, 13);
            this.lblLunch.TabIndex = 25;
            this.lblLunch.Text = "Lunch";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLunch
            // 
            this.txtLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLunch.Location = new System.Drawing.Point(230, 32);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(72, 20);
            this.txtLunch.TabIndex = 24;
            this.txtLunch.TextChanged += new System.EventHandler(this.txtLunch_TextChanged);
            this.txtLunch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunch_KeyPress);
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBreakfast.Location = new System.Drawing.Point(151, 7);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(73, 13);
            this.lblBreakfast.TabIndex = 23;
            this.lblBreakfast.Text = "Breakfast";
            this.lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateMeals
            // 
            this.btnCalculateMeals.Enabled = false;
            this.btnCalculateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMeals.ForeColor = System.Drawing.Color.Green;
            this.btnCalculateMeals.Location = new System.Drawing.Point(459, 89);
            this.btnCalculateMeals.Name = "btnCalculateMeals";
            this.btnCalculateMeals.Size = new System.Drawing.Size(72, 23);
            this.btnCalculateMeals.TabIndex = 22;
            this.btnCalculateMeals.Text = "Calculate";
            this.btnCalculateMeals.UseVisualStyleBackColor = true;
            this.btnCalculateMeals.Click += new System.EventHandler(this.btnCalculateMeals_Click);
            // 
            // txtMealsPerDiemRate
            // 
            this.txtMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsPerDiemRate.Location = new System.Drawing.Point(151, 32);
            this.txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            this.txtMealsPerDiemRate.Size = new System.Drawing.Size(73, 20);
            this.txtMealsPerDiemRate.TabIndex = 21;
            this.txtMealsPerDiemRate.TextChanged += new System.EventHandler(this.txtMealsPerDiemRate_TextChanged);
            this.txtMealsPerDiemRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMealsPerDiemRate_KeyPress);
            // 
            // lblMealsPerDiemRate
            // 
            this.lblMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealsPerDiemRate.AutoSize = true;
            this.lblMealsPerDiemRate.Location = new System.Drawing.Point(3, 35);
            this.lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            this.lblMealsPerDiemRate.Size = new System.Drawing.Size(142, 13);
            this.lblMealsPerDiemRate.TabIndex = 20;
            this.lblMealsPerDiemRate.Text = "Meals Per Diem Rate:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.03571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63393F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41072F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63393F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0625F));
            this.tableLayoutPanel4.Controls.Add(this.lblBreakfast, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalPerDiemRateValue, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblLunch, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDinner, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalPerDiemRate, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtLunch, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblDinner, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblMealsPerDiemRate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtMealsPerDiemRate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblZipCode, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtZipCode, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 26);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(448, 84);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // lblZipCode
            // 
            this.lblZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(3, 63);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(142, 13);
            this.lblZipCode.TabIndex = 30;
            this.lblZipCode.Text = "Travel Location Zip Code:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZipCode.Location = new System.Drawing.Point(151, 60);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(73, 20);
            this.txtZipCode.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInfoLink);
            this.panel1.Controls.Add(this.linkLabelMealPerDiemRate);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.btnCalculateMeals);
            this.panel1.Location = new System.Drawing.Point(27, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 121);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblInfoLink
            // 
            this.lblInfoLink.AutoSize = true;
            this.lblInfoLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLink.Location = new System.Drawing.Point(8, 6);
            this.lblInfoLink.Name = "lblInfoLink";
            this.lblInfoLink.Size = new System.Drawing.Size(213, 13);
            this.lblInfoLink.TabIndex = 31;
            this.lblInfoLink.Text = "Link for checking the Meals Per Diem Rate:";
            // 
            // linkLabelMealPerDiemRate
            // 
            this.linkLabelMealPerDiemRate.AutoSize = true;
            this.linkLabelMealPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMealPerDiemRate.Location = new System.Drawing.Point(227, 6);
            this.linkLabelMealPerDiemRate.Name = "linkLabelMealPerDiemRate";
            this.linkLabelMealPerDiemRate.Size = new System.Drawing.Size(262, 13);
            this.linkLabelMealPerDiemRate.TabIndex = 32;
            this.linkLabelMealPerDiemRate.TabStop = true;
            this.linkLabelMealPerDiemRate.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            this.linkLabelMealPerDiemRate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMealPerDiemRate_LinkClicked);
            // 
            // lblWarninglabel1
            // 
            this.lblWarninglabel1.AutoSize = true;
            this.lblWarninglabel1.BackColor = System.Drawing.Color.Transparent;
            this.lblWarninglabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarninglabel1.Location = new System.Drawing.Point(5, 6);
            this.lblWarninglabel1.Name = "lblWarninglabel1";
            this.lblWarninglabel1.Size = new System.Drawing.Size(545, 13);
            this.lblWarninglabel1.TabIndex = 33;
            this.lblWarninglabel1.Text = "If you change a Per Diem value, please hit calculate to refresh the data,otherwis" +
    "e your changes will not be saved. ";
            // 
            // pWarning
            // 
            this.pWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pWarning.Controls.Add(this.lblWarninglabel1);
            this.pWarning.Location = new System.Drawing.Point(22, 144);
            this.pWarning.Name = "pWarning";
            this.pWarning.Size = new System.Drawing.Size(558, 27);
            this.pWarning.TabIndex = 33;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // EditMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 597);
            this.ControlBox = false;
            this.Controls.Add(this.pWarning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pProvidedMeals);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvEditMeals);
            this.Name = "EditMeals";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Meals";
            this.Load += new System.EventHandler(this.EditMeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditMeals)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pProvidedMeals.ResumeLayout(false);
            this.pProvidedMeals.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pWarning.ResumeLayout(false);
            this.pWarning.PerformLayout();
            this.ResumeLayout(false);

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