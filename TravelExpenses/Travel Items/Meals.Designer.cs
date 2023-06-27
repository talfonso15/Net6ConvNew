namespace TravelExpenses
{
    partial class Meals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meals));
            dtgMeals = new System.Windows.Forms.DataGridView();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Breakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Lunch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Dinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblProvidedMeal = new System.Windows.Forms.Label();
            pProvidedMeal = new System.Windows.Forms.Panel();
            rbNoProvidedMeal = new System.Windows.Forms.RadioButton();
            rbYesProvidedMeal = new System.Windows.Forms.RadioButton();
            pbUncheckMeal = new System.Windows.Forms.Panel();
            lblUncheckMeal = new System.Windows.Forms.Label();
            lbMealsNotes = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            txtMealsNotes = new System.Windows.Forms.TextBox();
            tlNavButtons = new System.Windows.Forms.TableLayoutPanel();
            btnNextMeal = new System.Windows.Forms.Button();
            btnBackMeal = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblMealsTotal = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            txtMealsTotal = new System.Windows.Forms.TextBox();
            lblMealsPerDiemRate = new System.Windows.Forms.Label();
            txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            btnCalculateMeals = new System.Windows.Forms.Button();
            lblInfoLink = new System.Windows.Forms.Label();
            linkLabelMealPerDiemRate = new System.Windows.Forms.LinkLabel();
            lblBreakfast = new System.Windows.Forms.Label();
            txtLunch = new System.Windows.Forms.TextBox();
            lblLunch = new System.Windows.Forms.Label();
            txtDinner = new System.Windows.Forms.TextBox();
            lblDinner = new System.Windows.Forms.Label();
            lblTotalPerDiemRate = new System.Windows.Forms.Label();
            lblTotalPerDiemRateValue = new System.Windows.Forms.Label();
            gbZipCode = new System.Windows.Forms.GroupBox();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            lblZipCode = new System.Windows.Forms.Label();
            txtZipCode = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnHelp = new System.Windows.Forms.Button();
            btnCancelMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtgMeals).BeginInit();
            pProvidedMeal.SuspendLayout();
            pbUncheckMeal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlNavButtons.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gbZipCode.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgMeals
            // 
            dtgMeals.AllowUserToAddRows = false;
            dtgMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Date, Breakfast, Lunch, Dinner, Total });
            dtgMeals.Location = new System.Drawing.Point(24, 180);
            dtgMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtgMeals.Name = "dtgMeals";
            dtgMeals.Size = new System.Drawing.Size(640, 310);
            dtgMeals.TabIndex = 0;
            dtgMeals.CellContentClick += dtgMeals_CellContentClick;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Breakfast
            // 
            Breakfast.HeaderText = "Breakfast";
            Breakfast.Name = "Breakfast";
            Breakfast.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Breakfast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Lunch
            // 
            Lunch.HeaderText = "Lunch";
            Lunch.Name = "Lunch";
            Lunch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Lunch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Dinner
            // 
            Dinner.HeaderText = "Dinner";
            Dinner.Name = "Dinner";
            Dinner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Dinner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // lblProvidedMeal
            // 
            lblProvidedMeal.AutoSize = true;
            lblProvidedMeal.Location = new System.Drawing.Point(21, 23);
            lblProvidedMeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProvidedMeal.Name = "lblProvidedMeal";
            lblProvidedMeal.Size = new System.Drawing.Size(298, 15);
            lblProvidedMeal.TabIndex = 1;
            lblProvidedMeal.Text = "Were any of the checked meals above provided to you?";
            // 
            // pProvidedMeal
            // 
            pProvidedMeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pProvidedMeal.Controls.Add(rbNoProvidedMeal);
            pProvidedMeal.Controls.Add(rbYesProvidedMeal);
            pProvidedMeal.Controls.Add(lblProvidedMeal);
            pProvidedMeal.Location = new System.Drawing.Point(24, 563);
            pProvidedMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pProvidedMeal.Name = "pProvidedMeal";
            pProvidedMeal.Size = new System.Drawing.Size(640, 62);
            pProvidedMeal.TabIndex = 2;
            // 
            // rbNoProvidedMeal
            // 
            rbNoProvidedMeal.AutoSize = true;
            rbNoProvidedMeal.Checked = true;
            rbNoProvidedMeal.Location = new System.Drawing.Point(527, 21);
            rbNoProvidedMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoProvidedMeal.Name = "rbNoProvidedMeal";
            rbNoProvidedMeal.Size = new System.Drawing.Size(41, 19);
            rbNoProvidedMeal.TabIndex = 3;
            rbNoProvidedMeal.TabStop = true;
            rbNoProvidedMeal.Text = "No";
            rbNoProvidedMeal.UseVisualStyleBackColor = true;
            rbNoProvidedMeal.CheckedChanged += rbNoProvidedMeal_CheckedChanged;
            // 
            // rbYesProvidedMeal
            // 
            rbYesProvidedMeal.AutoSize = true;
            rbYesProvidedMeal.Location = new System.Drawing.Point(455, 21);
            rbYesProvidedMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesProvidedMeal.Name = "rbYesProvidedMeal";
            rbYesProvidedMeal.Size = new System.Drawing.Size(42, 19);
            rbYesProvidedMeal.TabIndex = 2;
            rbYesProvidedMeal.Text = "Yes";
            rbYesProvidedMeal.UseVisualStyleBackColor = true;
            rbYesProvidedMeal.CheckedChanged += rbYesProvidedMeal_CheckedChanged;
            // 
            // pbUncheckMeal
            // 
            pbUncheckMeal.BackColor = System.Drawing.Color.Red;
            pbUncheckMeal.Controls.Add(lblUncheckMeal);
            pbUncheckMeal.Location = new System.Drawing.Point(24, 714);
            pbUncheckMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pbUncheckMeal.Name = "pbUncheckMeal";
            pbUncheckMeal.Size = new System.Drawing.Size(640, 62);
            pbUncheckMeal.TabIndex = 3;
            pbUncheckMeal.Visible = false;
            // 
            // lblUncheckMeal
            // 
            lblUncheckMeal.AutoSize = true;
            lblUncheckMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUncheckMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblUncheckMeal.Location = new System.Drawing.Point(167, 17);
            lblUncheckMeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUncheckMeal.Name = "lblUncheckMeal";
            lblUncheckMeal.Size = new System.Drawing.Size(264, 24);
            lblUncheckMeal.TabIndex = 0;
            lblUncheckMeal.Text = "Please uncheck the free meal.";
            // 
            // lbMealsNotes
            // 
            lbMealsNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbMealsNotes.AutoSize = true;
            lbMealsNotes.Location = new System.Drawing.Point(62, 22);
            lbMealsNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMealsNotes.Name = "lbMealsNotes";
            lbMealsNotes.Size = new System.Drawing.Size(41, 15);
            lbMealsNotes.TabIndex = 0;
            lbMealsNotes.Text = "Notes:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.68306F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.31694F));
            tableLayoutPanel1.Controls.Add(lbMealsNotes, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMealsNotes, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(24, 639);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(640, 60);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txtMealsNotes
            // 
            txtMealsNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtMealsNotes.Location = new System.Drawing.Point(171, 6);
            txtMealsNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMealsNotes.Multiline = true;
            txtMealsNotes.Name = "txtMealsNotes";
            txtMealsNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtMealsNotes.Size = new System.Drawing.Size(461, 47);
            txtMealsNotes.TabIndex = 1;
            // 
            // tlNavButtons
            // 
            tlNavButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tlNavButtons.ColumnCount = 3;
            tlNavButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.73913F));
            tlNavButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.26087F));
            tlNavButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            tlNavButtons.Controls.Add(btnNextMeal, 2, 0);
            tlNavButtons.Controls.Add(btnBackMeal, 0, 0);
            tlNavButtons.Controls.Add(label1, 1, 0);
            tlNavButtons.Location = new System.Drawing.Point(517, 800);
            tlNavButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlNavButtons.Name = "tlNavButtons";
            tlNavButtons.RowCount = 1;
            tlNavButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlNavButtons.Size = new System.Drawing.Size(161, 60);
            tlNavButtons.TabIndex = 5;
            // 
            // btnNextMeal
            // 
            btnNextMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNextMeal.FlatAppearance.BorderSize = 0;
            btnNextMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNextMeal.Image = (System.Drawing.Image)resources.GetObject("btnNextMeal.Image");
            btnNextMeal.Location = new System.Drawing.Point(98, 10);
            btnNextMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNextMeal.Name = "btnNextMeal";
            btnNextMeal.Size = new System.Drawing.Size(59, 39);
            btnNextMeal.TabIndex = 2;
            btnNextMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNextMeal.UseVisualStyleBackColor = true;
            btnNextMeal.Click += btnNextMeal_Click;
            // 
            // btnBackMeal
            // 
            btnBackMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBackMeal.FlatAppearance.BorderSize = 0;
            btnBackMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBackMeal.Image = (System.Drawing.Image)resources.GetObject("btnBackMeal.Image");
            btnBackMeal.Location = new System.Drawing.Point(18, 10);
            btnBackMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBackMeal.Name = "btnBackMeal";
            btnBackMeal.Size = new System.Drawing.Size(31, 39);
            btnBackMeal.TabIndex = 1;
            btnBackMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBackMeal.UseVisualStyleBackColor = true;
            btnBackMeal.Click += btnBackMeal_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(72, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMealsTotal
            // 
            lblMealsTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblMealsTotal.AutoSize = true;
            lblMealsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMealsTotal.Location = new System.Drawing.Point(445, 13);
            lblMealsTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMealsTotal.Name = "lblMealsTotal";
            lblMealsTotal.Size = new System.Drawing.Size(54, 20);
            lblMealsTotal.TabIndex = 6;
            lblMealsTotal.Text = "Total:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.68852F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.31148F));
            tableLayoutPanel3.Controls.Add(lblMealsTotal, 0, 0);
            tableLayoutPanel3.Controls.Add(txtMealsTotal, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(24, 502);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(640, 46);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // txtMealsTotal
            // 
            txtMealsTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsTotal.Location = new System.Drawing.Point(507, 11);
            txtMealsTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMealsTotal.Name = "txtMealsTotal";
            txtMealsTotal.ReadOnly = true;
            txtMealsTotal.Size = new System.Drawing.Size(129, 23);
            txtMealsTotal.TabIndex = 7;
            // 
            // lblMealsPerDiemRate
            // 
            lblMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMealsPerDiemRate.AutoSize = true;
            lblMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMealsPerDiemRate.Location = new System.Drawing.Point(7, 35);
            lblMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            lblMealsPerDiemRate.Size = new System.Drawing.Size(95, 13);
            lblMealsPerDiemRate.TabIndex = 8;
            lblMealsPerDiemRate.Text = "Per Diem Rate:";
            // 
            // txtMealsPerDiemRate
            // 
            txtMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMealsPerDiemRate.Location = new System.Drawing.Point(113, 32);
            txtMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            txtMealsPerDiemRate.Size = new System.Drawing.Size(91, 20);
            txtMealsPerDiemRate.TabIndex = 9;
            txtMealsPerDiemRate.TextChanged += textBox1_TextChanged;
            txtMealsPerDiemRate.KeyPress += textBox1_KeyPress;
            // 
            // btnCalculateMeals
            // 
            btnCalculateMeals.Enabled = false;
            btnCalculateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCalculateMeals.ForeColor = System.Drawing.Color.Green;
            btnCalculateMeals.Location = new System.Drawing.Point(538, 121);
            btnCalculateMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCalculateMeals.Name = "btnCalculateMeals";
            btnCalculateMeals.Size = new System.Drawing.Size(88, 27);
            btnCalculateMeals.TabIndex = 10;
            btnCalculateMeals.Text = "Calculate";
            btnCalculateMeals.UseVisualStyleBackColor = true;
            btnCalculateMeals.Click += btnCalculateMeals_Click;
            // 
            // lblInfoLink
            // 
            lblInfoLink.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblInfoLink.AutoSize = true;
            lblInfoLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInfoLink.Location = new System.Drawing.Point(7, 9);
            lblInfoLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfoLink.Name = "lblInfoLink";
            lblInfoLink.Size = new System.Drawing.Size(256, 13);
            lblInfoLink.TabIndex = 11;
            lblInfoLink.Text = "Link for checking the Meals Per Diem Rate:";
            // 
            // linkLabelMealPerDiemRate
            // 
            linkLabelMealPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            linkLabelMealPerDiemRate.AutoSize = true;
            linkLabelMealPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabelMealPerDiemRate.Location = new System.Drawing.Point(274, 9);
            linkLabelMealPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabelMealPerDiemRate.Name = "linkLabelMealPerDiemRate";
            linkLabelMealPerDiemRate.Size = new System.Drawing.Size(330, 13);
            linkLabelMealPerDiemRate.TabIndex = 12;
            linkLabelMealPerDiemRate.TabStop = true;
            linkLabelMealPerDiemRate.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            linkLabelMealPerDiemRate.LinkClicked += linkLabelMealPerDiemRate_LinkClicked;
            // 
            // lblBreakfast
            // 
            lblBreakfast.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblBreakfast.AutoSize = true;
            lblBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBreakfast.Location = new System.Drawing.Point(113, 7);
            lblBreakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new System.Drawing.Size(91, 13);
            lblBreakfast.TabIndex = 13;
            lblBreakfast.Text = "Breakfast";
            lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLunch
            // 
            txtLunch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLunch.Location = new System.Drawing.Point(215, 32);
            txtLunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLunch.Name = "txtLunch";
            txtLunch.Size = new System.Drawing.Size(95, 20);
            txtLunch.TabIndex = 14;
            txtLunch.TextChanged += txtLunch_TextChanged;
            txtLunch.KeyPress += txtLunch_KeyPress;
            // 
            // lblLunch
            // 
            lblLunch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLunch.AutoSize = true;
            lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLunch.Location = new System.Drawing.Point(215, 7);
            lblLunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new System.Drawing.Size(95, 13);
            lblLunch.TabIndex = 15;
            lblLunch.Text = "Lunch";
            lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDinner
            // 
            txtDinner.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDinner.Location = new System.Drawing.Point(321, 32);
            txtDinner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDinner.Name = "txtDinner";
            txtDinner.Size = new System.Drawing.Size(92, 20);
            txtDinner.TabIndex = 16;
            txtDinner.TextChanged += txtDinner_TextChanged;
            txtDinner.KeyPress += txtDinner_KeyPress;
            // 
            // lblDinner
            // 
            lblDinner.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDinner.AutoSize = true;
            lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDinner.Location = new System.Drawing.Point(321, 7);
            lblDinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new System.Drawing.Size(92, 13);
            lblDinner.TabIndex = 17;
            lblDinner.Text = "Dinner";
            lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRate
            // 
            lblTotalPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalPerDiemRate.AutoSize = true;
            lblTotalPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotalPerDiemRate.Location = new System.Drawing.Point(424, 7);
            lblTotalPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalPerDiemRate.Name = "lblTotalPerDiemRate";
            lblTotalPerDiemRate.Size = new System.Drawing.Size(86, 13);
            lblTotalPerDiemRate.TabIndex = 18;
            lblTotalPerDiemRate.Text = "Total";
            lblTotalPerDiemRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRateValue
            // 
            lblTotalPerDiemRateValue.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalPerDiemRateValue.AutoSize = true;
            lblTotalPerDiemRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotalPerDiemRateValue.Location = new System.Drawing.Point(424, 35);
            lblTotalPerDiemRateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalPerDiemRateValue.Name = "lblTotalPerDiemRateValue";
            lblTotalPerDiemRateValue.Size = new System.Drawing.Size(86, 13);
            lblTotalPerDiemRateValue.TabIndex = 19;
            lblTotalPerDiemRateValue.Text = "0";
            lblTotalPerDiemRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbZipCode
            // 
            gbZipCode.Controls.Add(tableLayoutPanel5);
            gbZipCode.Controls.Add(tableLayoutPanel4);
            gbZipCode.Controls.Add(tableLayoutPanel2);
            gbZipCode.Controls.Add(btnCalculateMeals);
            gbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbZipCode.Location = new System.Drawing.Point(24, 14);
            gbZipCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbZipCode.Name = "gbZipCode";
            gbZipCode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbZipCode.Size = new System.Drawing.Size(629, 159);
            gbZipCode.TabIndex = 20;
            gbZipCode.TabStop = false;
            gbZipCode.Text = "U.S.  General Services Administration Per Diem Data";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.95393F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.04607F));
            tableLayoutPanel5.Controls.Add(lblInfoLink, 0, 0);
            tableLayoutPanel5.Controls.Add(linkLabelMealPerDiemRate, 1, 0);
            tableLayoutPanel5.Location = new System.Drawing.Point(14, 18);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new System.Drawing.Size(611, 31);
            tableLayoutPanel5.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.92593F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.07407F));
            tableLayoutPanel4.Controls.Add(lblZipCode, 0, 0);
            tableLayoutPanel4.Controls.Add(txtZipCode, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(14, 52);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(318, 33);
            tableLayoutPanel4.TabIndex = 16;
            // 
            // lblZipCode
            // 
            lblZipCode.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblZipCode.Location = new System.Drawing.Point(7, 10);
            lblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new System.Drawing.Size(195, 13);
            lblZipCode.TabIndex = 13;
            lblZipCode.Text = "Zip code of the travel location:";
            // 
            // txtZipCode
            // 
            txtZipCode.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtZipCode.Location = new System.Drawing.Point(213, 6);
            txtZipCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new System.Drawing.Size(98, 20);
            txtZipCode.TabIndex = 14;
            txtZipCode.TextChanged += textBox1_TextChanged_1;
            txtZipCode.KeyPress += textBox1_KeyPress_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86456F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09029F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28442F));
            tableLayoutPanel2.Controls.Add(lblMealsPerDiemRate, 0, 1);
            tableLayoutPanel2.Controls.Add(lblTotalPerDiemRateValue, 4, 1);
            tableLayoutPanel2.Controls.Add(lblBreakfast, 1, 0);
            tableLayoutPanel2.Controls.Add(lblTotalPerDiemRate, 4, 0);
            tableLayoutPanel2.Controls.Add(txtMealsPerDiemRate, 1, 1);
            tableLayoutPanel2.Controls.Add(txtDinner, 3, 1);
            tableLayoutPanel2.Controls.Add(lblDinner, 3, 0);
            tableLayoutPanel2.Controls.Add(lblLunch, 2, 0);
            tableLayoutPanel2.Controls.Add(txtLunch, 2, 1);
            tableLayoutPanel2.Location = new System.Drawing.Point(14, 88);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            tableLayoutPanel2.Size = new System.Drawing.Size(517, 60);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 300;
            // 
            // btnHelp
            // 
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHelp.Image = Properties.Resources.Help2;
            btnHelp.Location = new System.Drawing.Point(656, 30);
            btnHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(35, 35);
            btnHelp.TabIndex = 21;
            toolTip1.SetToolTip(btnHelp, "Click here to see what you have to look for on the GSA page");
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnCancelMeal
            // 
            btnCancelMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelMeal.FlatAppearance.BorderSize = 0;
            btnCancelMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelMeal.Image = (System.Drawing.Image)resources.GetObject("btnCancelMeal.Image");
            btnCancelMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelMeal.Location = new System.Drawing.Point(24, 819);
            btnCancelMeal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelMeal.Name = "btnCancelMeal";
            btnCancelMeal.Size = new System.Drawing.Size(94, 39);
            btnCancelMeal.TabIndex = 0;
            btnCancelMeal.Text = "Cancel";
            btnCancelMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelMeal.UseVisualStyleBackColor = true;
            btnCancelMeal.Click += btnCancelMeal_Click;
            // 
            // Meals
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(692, 873);
            ControlBox = false;
            Controls.Add(btnHelp);
            Controls.Add(gbZipCode);
            Controls.Add(btnCancelMeal);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tlNavButtons);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pbUncheckMeal);
            Controls.Add(pProvidedMeal);
            Controls.Add(dtgMeals);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Meals";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Meals";
            Load += Meals_Load;
            VisibleChanged += Meals_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dtgMeals).EndInit();
            pProvidedMeal.ResumeLayout(false);
            pProvidedMeal.PerformLayout();
            pbUncheckMeal.ResumeLayout(false);
            pbUncheckMeal.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlNavButtons.ResumeLayout(false);
            tlNavButtons.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            gbZipCode.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMeals;
        private System.Windows.Forms.Label lblProvidedMeal;
        private System.Windows.Forms.Panel pProvidedMeal;
        private System.Windows.Forms.RadioButton rbNoProvidedMeal;
        private System.Windows.Forms.RadioButton rbYesProvidedMeal;
        private System.Windows.Forms.Panel pbUncheckMeal;
        private System.Windows.Forms.Label lblUncheckMeal;
        private System.Windows.Forms.Label lbMealsNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMealsNotes;
        private System.Windows.Forms.TableLayoutPanel tlNavButtons;
        private System.Windows.Forms.Button btnCancelMeal;
        private System.Windows.Forms.Button btnBackMeal;
        private System.Windows.Forms.Button btnNextMeal;
        private System.Windows.Forms.Label lblMealsTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtMealsTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Breakfast;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lunch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMealsPerDiemRate;
        private System.Windows.Forms.TextBox txtMealsPerDiemRate;
        private System.Windows.Forms.Button btnCalculateMeals;
        private System.Windows.Forms.Label lblInfoLink;
        private System.Windows.Forms.LinkLabel linkLabelMealPerDiemRate;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblTotalPerDiemRate;
        private System.Windows.Forms.Label lblTotalPerDiemRateValue;
        private System.Windows.Forms.GroupBox gbZipCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}