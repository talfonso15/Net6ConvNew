namespace TravelExpenses
{
    partial class RegisterTravel
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
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            this.tblNotes = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTravelNext = new System.Windows.Forms.Button();
            this.btnCancelTravel = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblTravelState = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtOtherPurpose = new System.Windows.Forms.TextBox();
            this.lblOtherPurpose = new System.Windows.Forms.Label();
            this.cbTravelPurpose = new System.Windows.Forms.ComboBox();
            this.lblTravelPurpose = new System.Windows.Forms.Label();
            this.txtOtherEvent = new System.Windows.Forms.TextBox();
            this.lblOtherEvent = new System.Windows.Forms.Label();
            this.cbTravelEvent = new System.Windows.Forms.ComboBox();
            this.lblTravelEvent = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblNotes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(86, 59);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(83, 13);
            this.lblDepartureTime.TabIndex = 0;
            this.lblDepartureTime.Text = "Departure Time:";
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDepartureTime.CustomFormat = "hh:mm tt";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(224, 52);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(119, 20);
            this.dtpDepartureTime.TabIndex = 1;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(87, 89);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(83, 13);
            this.lblDepartureDate.TabIndex = 2;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(224, 83);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(119, 20);
            this.dtpDepartureDate.TabIndex = 3;
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpDepartureDate_ValueChanged);
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.Location = new System.Drawing.Point(87, 123);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(68, 13);
            this.lblReturnTime.TabIndex = 4;
            this.lblReturnTime.Text = "Return Time:";
            // 
            // dtpReturnTime
            // 
            this.dtpReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpReturnTime.CustomFormat = "hh:mm tt";
            this.dtpReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnTime.Location = new System.Drawing.Point(224, 116);
            this.dtpReturnTime.Name = "dtpReturnTime";
            this.dtpReturnTime.ShowUpDown = true;
            this.dtpReturnTime.Size = new System.Drawing.Size(119, 20);
            this.dtpReturnTime.TabIndex = 5;
            // 
            // tblNotes
            // 
            this.tblNotes.ColumnCount = 1;
            this.tblNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNotes.Controls.Add(this.txtNotes, 0, 0);
            this.tblNotes.Location = new System.Drawing.Point(19, 443);
            this.tblNotes.Name = "tblNotes";
            this.tblNotes.RowCount = 1;
            this.tblNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNotes.Size = new System.Drawing.Size(467, 91);
            this.tblNotes.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotes.Location = new System.Drawing.Point(3, 3);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(460, 84);
            this.txtNotes.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnTravelNext, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(290, 553);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 40);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnTravelNext
            // 
            this.btnTravelNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTravelNext.FlatAppearance.BorderSize = 0;
            this.btnTravelNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravelNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTravelNext.Image = global::TravelExpenses.Properties.Resources.next;
            this.btnTravelNext.Location = new System.Drawing.Point(114, 3);
            this.btnTravelNext.Name = "btnTravelNext";
            this.btnTravelNext.Size = new System.Drawing.Size(76, 34);
            this.btnTravelNext.TabIndex = 0;
            this.btnTravelNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravelNext.UseVisualStyleBackColor = true;
            this.btnTravelNext.Click += new System.EventHandler(this.btnTravelNext_Click);
            // 
            // btnCancelTravel
            // 
            this.btnCancelTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelTravel.FlatAppearance.BorderSize = 0;
            this.btnCancelTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTravel.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelTravel.Location = new System.Drawing.Point(16, 555);
            this.btnCancelTravel.Name = "btnCancelTravel";
            this.btnCancelTravel.Size = new System.Drawing.Size(95, 34);
            this.btnCancelTravel.TabIndex = 1;
            this.btnCancelTravel.Text = "Cancel";
            this.btnCancelTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelTravel.UseVisualStyleBackColor = true;
            this.btnCancelTravel.Click += new System.EventHandler(this.btnCancelTravel_Click);
            // 
            // cbState
            // 
            this.cbState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Alabama,AL",
            "Alaska,AK",
            "Arizona,AZ",
            "Arkansas,AR",
            "California,CA",
            "Colorado,CO",
            "Connecticut,CT",
            "Delaware,DE",
            "Florida,FL",
            "Georgia,GA",
            "Hawaii,HI",
            "Idaho,ID",
            "Illinois,IL",
            "Indiana,IN",
            "Iowa,IA",
            "Kansas,KS",
            "Kentucky,KY",
            "Louisiana,LA",
            "Maine,ME",
            "Maryland,MD",
            "Massachusetts,MA",
            "Michigan,MI",
            "Minnesota,MN",
            "Mississippi,MS",
            "Missouri,MO",
            "Montana,MT",
            "Nebraska,NE",
            "Nevada,NV",
            "New Hampshire,NH",
            "New Jersey,NJ",
            "New Mexico,NM",
            "New York,NY",
            "North Carolina,NC",
            "North Dakota,ND",
            "Ohio,OH",
            "Oklahoma,OK",
            "Oregon,OR",
            "Pennsylvania,PA",
            "Rhode Island,RI",
            "South Carolina,SC",
            "South Dakota,SD",
            "Tennessee,TN",
            "Texas,TX",
            "Utah,UT",
            "Vermont,VT",
            "Virginia,VA",
            "Washington,WA",
            "West Virginia,WV",
            "Wisconsin,WI",
            "Wyoming,WY",
            "Other"});
            this.cbState.Location = new System.Drawing.Point(224, 317);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(192, 21);
            this.cbState.TabIndex = 23;
            // 
            // lblTravelState
            // 
            this.lblTravelState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelState.AutoSize = true;
            this.lblTravelState.Location = new System.Drawing.Point(86, 317);
            this.lblTravelState.Name = "lblTravelState";
            this.lblTravelState.Size = new System.Drawing.Size(68, 13);
            this.lblTravelState.TabIndex = 22;
            this.lblTravelState.Text = "Travel State:";
            // 
            // lblDestination
            // 
            this.lblDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(86, 283);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 21;
            this.lblDestination.Text = "Destination:";
            // 
            // lblOrigin
            // 
            this.lblOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(87, 257);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(37, 13);
            this.lblOrigin.TabIndex = 20;
            this.lblOrigin.Text = "Origin:";
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDestination.Location = new System.Drawing.Point(224, 283);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(194, 20);
            this.txtDestination.TabIndex = 19;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrigin.Location = new System.Drawing.Point(224, 250);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(194, 20);
            this.txtOrigin.TabIndex = 17;
            // 
            // txtOtherPurpose
            // 
            this.txtOtherPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOtherPurpose.Enabled = false;
            this.txtOtherPurpose.Location = new System.Drawing.Point(224, 390);
            this.txtOtherPurpose.Name = "txtOtherPurpose";
            this.txtOtherPurpose.Size = new System.Drawing.Size(194, 20);
            this.txtOtherPurpose.TabIndex = 15;
            this.txtOtherPurpose.Visible = false;
            // 
            // lblOtherPurpose
            // 
            this.lblOtherPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherPurpose.AutoSize = true;
            this.lblOtherPurpose.Enabled = false;
            this.lblOtherPurpose.Location = new System.Drawing.Point(86, 393);
            this.lblOtherPurpose.Name = "lblOtherPurpose";
            this.lblOtherPurpose.Size = new System.Drawing.Size(78, 13);
            this.lblOtherPurpose.TabIndex = 14;
            this.lblOtherPurpose.Text = "Other Purpose:";
            this.lblOtherPurpose.Visible = false;
            // 
            // cbTravelPurpose
            // 
            this.cbTravelPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTravelPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelPurpose.FormattingEnabled = true;
            this.cbTravelPurpose.Items.AddRange(new object[] {
            "Training",
            "Professional",
            "Industry-related",
            "Work outside district",
            "Seminar",
            "Workshops",
            "Other"});
            this.cbTravelPurpose.Location = new System.Drawing.Point(224, 360);
            this.cbTravelPurpose.Name = "cbTravelPurpose";
            this.cbTravelPurpose.Size = new System.Drawing.Size(194, 21);
            this.cbTravelPurpose.TabIndex = 13;
            this.cbTravelPurpose.Visible = false;
            this.cbTravelPurpose.SelectedIndexChanged += new System.EventHandler(this.cbTravelPurpose_SelectedIndexChanged);
            // 
            // lblTravelPurpose
            // 
            this.lblTravelPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelPurpose.AutoSize = true;
            this.lblTravelPurpose.Location = new System.Drawing.Point(86, 368);
            this.lblTravelPurpose.Name = "lblTravelPurpose";
            this.lblTravelPurpose.Size = new System.Drawing.Size(82, 13);
            this.lblTravelPurpose.TabIndex = 12;
            this.lblTravelPurpose.Text = "Travel Purpose:";
            this.lblTravelPurpose.Visible = false;
            // 
            // txtOtherEvent
            // 
            this.txtOtherEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOtherEvent.Enabled = false;
            this.txtOtherEvent.Location = new System.Drawing.Point(224, 216);
            this.txtOtherEvent.Name = "txtOtherEvent";
            this.txtOtherEvent.Size = new System.Drawing.Size(194, 20);
            this.txtOtherEvent.TabIndex = 11;
            // 
            // lblOtherEvent
            // 
            this.lblOtherEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherEvent.AutoSize = true;
            this.lblOtherEvent.Enabled = false;
            this.lblOtherEvent.Location = new System.Drawing.Point(87, 220);
            this.lblOtherEvent.Name = "lblOtherEvent";
            this.lblOtherEvent.Size = new System.Drawing.Size(67, 13);
            this.lblOtherEvent.TabIndex = 10;
            this.lblOtherEvent.Text = "Other Event:";
            // 
            // cbTravelEvent
            // 
            this.cbTravelEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTravelEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTravelEvent.FormattingEnabled = true;
            this.cbTravelEvent.Items.AddRange(new object[] {
            "FMCA Aerial Fly In",
            "AMCA Annual Meeting",
            "FMCA Annual Meeting",
            "FASD Annual Meeting",
            "Chemical Response Training",
            "FMCA Legislative",
            "AMCA Legislative",
            "FGFOA Accounting",
            "FMCA Dodd Short Course",
            "FASD Legislative",
            "FRS Training",
            "Aquatic Weed Shortcourse",
            "FAPMS",
            "APMS",
            "SFAPMS",
            "FLMS",
            "CHNEP",
            "Other"});
            this.cbTravelEvent.Location = new System.Drawing.Point(224, 183);
            this.cbTravelEvent.Name = "cbTravelEvent";
            this.cbTravelEvent.Size = new System.Drawing.Size(194, 21);
            this.cbTravelEvent.TabIndex = 9;
            this.cbTravelEvent.SelectedIndexChanged += new System.EventHandler(this.cbTravelEvent_SelectedIndexChanged);
            // 
            // lblTravelEvent
            // 
            this.lblTravelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTravelEvent.AutoSize = true;
            this.lblTravelEvent.Location = new System.Drawing.Point(87, 188);
            this.lblTravelEvent.Name = "lblTravelEvent";
            this.lblTravelEvent.Size = new System.Drawing.Size(71, 13);
            this.lblTravelEvent.TabIndex = 8;
            this.lblTravelEvent.Text = "Travel Event:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(224, 151);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(119, 20);
            this.dtpReturnDate.TabIndex = 7;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(87, 158);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(68, 13);
            this.lblReturnDate.TabIndex = 6;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Describe the specific skills or strategies obtained as a result of participating " +
    "in this travel event:";
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(462, 419);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(24, 18);
            this.btnInfo.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnInfo, "Only for travel event that requires it, you should ask your supervisor ");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // RegisterTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.btnCancelTravel);
            this.Controls.Add(this.lblTravelState);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.tblNotes);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.txtOtherPurpose);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblOtherPurpose);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblReturnTime);
            this.Controls.Add(this.cbTravelPurpose);
            this.Controls.Add(this.dtpReturnTime);
            this.Controls.Add(this.lblTravelPurpose);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.txtOtherEvent);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lblOtherEvent);
            this.Controls.Add(this.lblTravelEvent);
            this.Controls.Add(this.cbTravelEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterTravel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Travel";
            this.Load += new System.EventHandler(this.RegisterTravel_Load);
            this.tblNotes.ResumeLayout(false);
            this.tblNotes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.DateTimePicker dtpReturnTime;
        private System.Windows.Forms.TableLayoutPanel tblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTravelNext;
        private System.Windows.Forms.Button btnCancelTravel;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblTravelState;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtOtherPurpose;
        private System.Windows.Forms.Label lblOtherPurpose;
        private System.Windows.Forms.ComboBox cbTravelPurpose;
        private System.Windows.Forms.Label lblTravelPurpose;
        private System.Windows.Forms.TextBox txtOtherEvent;
        private System.Windows.Forms.Label lblOtherEvent;
        private System.Windows.Forms.ComboBox cbTravelEvent;
        private System.Windows.Forms.Label lblTravelEvent;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}