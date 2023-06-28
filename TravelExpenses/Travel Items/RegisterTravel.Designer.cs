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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterTravel));
            lblDepartureTime = new System.Windows.Forms.Label();
            dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            lblDepartureDate = new System.Windows.Forms.Label();
            dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            lblReturnTime = new System.Windows.Forms.Label();
            dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            tblNotes = new System.Windows.Forms.TableLayoutPanel();
            txtNotes = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnTravelNext = new System.Windows.Forms.Button();
            btnCancelTravel = new System.Windows.Forms.Button();
            cbState = new System.Windows.Forms.ComboBox();
            lblTravelState = new System.Windows.Forms.Label();
            lblDestination = new System.Windows.Forms.Label();
            lblOrigin = new System.Windows.Forms.Label();
            txtDestination = new System.Windows.Forms.TextBox();
            txtOrigin = new System.Windows.Forms.TextBox();
            txtOtherPurpose = new System.Windows.Forms.TextBox();
            lblOtherPurpose = new System.Windows.Forms.Label();
            cbTravelPurpose = new System.Windows.Forms.ComboBox();
            lblTravelPurpose = new System.Windows.Forms.Label();
            txtOtherEvent = new System.Windows.Forms.TextBox();
            lblOtherEvent = new System.Windows.Forms.Label();
            cbTravelEvent = new System.Windows.Forms.ComboBox();
            lblTravelEvent = new System.Windows.Forms.Label();
            dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            lblReturnDate = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnInfo = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            tblNotes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDepartureTime
            // 
            lblDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartureTime.AutoSize = true;
            lblDepartureTime.Location = new System.Drawing.Point(100, 68);
            lblDepartureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartureTime.Name = "lblDepartureTime";
            lblDepartureTime.Size = new System.Drawing.Size(91, 15);
            lblDepartureTime.TabIndex = 0;
            lblDepartureTime.Text = "Departure Time:";
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpDepartureTime.CustomFormat = "hh:mm tt";
            dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDepartureTime.Location = new System.Drawing.Point(272, 60);
            dtpDepartureTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.ShowUpDown = true;
            dtpDepartureTime.Size = new System.Drawing.Size(138, 23);
            dtpDepartureTime.TabIndex = 1;
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartureDate.AutoSize = true;
            lblDepartureDate.Location = new System.Drawing.Point(102, 103);
            lblDepartureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new System.Drawing.Size(89, 15);
            lblDepartureDate.TabIndex = 2;
            lblDepartureDate.Text = "Departure Date:";
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDepartureDate.Location = new System.Drawing.Point(272, 96);
            dtpDepartureDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new System.Drawing.Size(138, 23);
            dtpDepartureDate.TabIndex = 3;
            dtpDepartureDate.ValueChanged += dtpDepartureDate_ValueChanged;
            // 
            // lblReturnTime
            // 
            lblReturnTime.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblReturnTime.AutoSize = true;
            lblReturnTime.Location = new System.Drawing.Point(102, 142);
            lblReturnTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReturnTime.Name = "lblReturnTime";
            lblReturnTime.Size = new System.Drawing.Size(74, 15);
            lblReturnTime.TabIndex = 4;
            lblReturnTime.Text = "Return Time:";
            // 
            // dtpReturnTime
            // 
            dtpReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpReturnTime.CustomFormat = "hh:mm tt";
            dtpReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpReturnTime.Location = new System.Drawing.Point(272, 134);
            dtpReturnTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpReturnTime.Name = "dtpReturnTime";
            dtpReturnTime.ShowUpDown = true;
            dtpReturnTime.Size = new System.Drawing.Size(138, 23);
            dtpReturnTime.TabIndex = 5;
            // 
            // tblNotes
            // 
            tblNotes.ColumnCount = 1;
            tblNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tblNotes.Controls.Add(txtNotes, 0, 0);
            tblNotes.Location = new System.Drawing.Point(22, 511);
            tblNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tblNotes.Name = "tblNotes";
            tblNotes.RowCount = 1;
            tblNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblNotes.Size = new System.Drawing.Size(545, 105);
            tblNotes.TabIndex = 1;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtNotes.Location = new System.Drawing.Point(4, 4);
            txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtNotes.Size = new System.Drawing.Size(536, 96);
            txtNotes.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnTravelNext, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(360, 626);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(207, 40);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnTravelNext
            // 
            btnTravelNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnTravelNext.FlatAppearance.BorderSize = 0;
            btnTravelNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTravelNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTravelNext.Image = (System.Drawing.Image)resources.GetObject("btnTravelNext.Image");
            btnTravelNext.Location = new System.Drawing.Point(110, 3);
            btnTravelNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTravelNext.Name = "btnTravelNext";
            btnTravelNext.Size = new System.Drawing.Size(89, 34);
            btnTravelNext.TabIndex = 0;
            btnTravelNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTravelNext.UseVisualStyleBackColor = true;
            btnTravelNext.Click += btnTravelNext_Click;
            // 
            // btnCancelTravel
            // 
            btnCancelTravel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCancelTravel.FlatAppearance.BorderSize = 0;
            btnCancelTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelTravel.Image = (System.Drawing.Image)resources.GetObject("btnCancelTravel.Image");
            btnCancelTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelTravel.Location = new System.Drawing.Point(19, 627);
            btnCancelTravel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelTravel.Name = "btnCancelTravel";
            btnCancelTravel.Size = new System.Drawing.Size(94, 39);
            btnCancelTravel.TabIndex = 1;
            btnCancelTravel.Text = "Cancel";
            btnCancelTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelTravel.UseVisualStyleBackColor = true;
            btnCancelTravel.Click += btnCancelTravel_Click;
            // 
            // cbState
            // 
            cbState.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbState.FormattingEnabled = true;
            cbState.Items.AddRange(new object[] { "Alabama,AL", "Alaska,AK", "Arizona,AZ", "Arkansas,AR", "California,CA", "Colorado,CO", "Connecticut,CT", "Delaware,DE", "Florida,FL", "Georgia,GA", "Hawaii,HI", "Idaho,ID", "Illinois,IL", "Indiana,IN", "Iowa,IA", "Kansas,KS", "Kentucky,KY", "Louisiana,LA", "Maine,ME", "Maryland,MD", "Massachusetts,MA", "Michigan,MI", "Minnesota,MN", "Mississippi,MS", "Missouri,MO", "Montana,MT", "Nebraska,NE", "Nevada,NV", "New Hampshire,NH", "New Jersey,NJ", "New Mexico,NM", "New York,NY", "North Carolina,NC", "North Dakota,ND", "Ohio,OH", "Oklahoma,OK", "Oregon,OR", "Pennsylvania,PA", "Rhode Island,RI", "South Carolina,SC", "South Dakota,SD", "Tennessee,TN", "Texas,TX", "Utah,UT", "Vermont,VT", "Virginia,VA", "Washington,WA", "West Virginia,WV", "Wisconsin,WI", "Wyoming,WY", "Other" });
            cbState.Location = new System.Drawing.Point(272, 366);
            cbState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbState.Name = "cbState";
            cbState.Size = new System.Drawing.Size(223, 23);
            cbState.TabIndex = 23;
            // 
            // lblTravelState
            // 
            lblTravelState.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTravelState.AutoSize = true;
            lblTravelState.Location = new System.Drawing.Point(100, 366);
            lblTravelState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTravelState.Name = "lblTravelState";
            lblTravelState.Size = new System.Drawing.Size(69, 15);
            lblTravelState.TabIndex = 22;
            lblTravelState.Text = "Travel State:";
            // 
            // lblDestination
            // 
            lblDestination.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDestination.AutoSize = true;
            lblDestination.Location = new System.Drawing.Point(100, 327);
            lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new System.Drawing.Size(70, 15);
            lblDestination.TabIndex = 21;
            lblDestination.Text = "Destination:";
            // 
            // lblOrigin
            // 
            lblOrigin.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new System.Drawing.Point(102, 297);
            lblOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new System.Drawing.Size(43, 15);
            lblOrigin.TabIndex = 20;
            lblOrigin.Text = "Origin:";
            // 
            // txtDestination
            // 
            txtDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtDestination.Location = new System.Drawing.Point(272, 327);
            txtDestination.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new System.Drawing.Size(226, 23);
            txtDestination.TabIndex = 19;
            // 
            // txtOrigin
            // 
            txtOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtOrigin.Location = new System.Drawing.Point(272, 288);
            txtOrigin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new System.Drawing.Size(226, 23);
            txtOrigin.TabIndex = 17;
            // 
            // txtOtherPurpose
            // 
            txtOtherPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtOtherPurpose.Enabled = false;
            txtOtherPurpose.Location = new System.Drawing.Point(272, 450);
            txtOtherPurpose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOtherPurpose.Name = "txtOtherPurpose";
            txtOtherPurpose.Size = new System.Drawing.Size(226, 23);
            txtOtherPurpose.TabIndex = 15;
            txtOtherPurpose.Visible = false;
            // 
            // lblOtherPurpose
            // 
            lblOtherPurpose.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOtherPurpose.AutoSize = true;
            lblOtherPurpose.Enabled = false;
            lblOtherPurpose.Location = new System.Drawing.Point(100, 453);
            lblOtherPurpose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOtherPurpose.Name = "lblOtherPurpose";
            lblOtherPurpose.Size = new System.Drawing.Size(86, 15);
            lblOtherPurpose.TabIndex = 14;
            lblOtherPurpose.Text = "Other Purpose:";
            lblOtherPurpose.Visible = false;
            // 
            // cbTravelPurpose
            // 
            cbTravelPurpose.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbTravelPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTravelPurpose.FormattingEnabled = true;
            cbTravelPurpose.Items.AddRange(new object[] { "Training", "Professional", "Industry-related", "Work outside district", "Seminar", "Workshops", "Other" });
            cbTravelPurpose.Location = new System.Drawing.Point(272, 415);
            cbTravelPurpose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbTravelPurpose.Name = "cbTravelPurpose";
            cbTravelPurpose.Size = new System.Drawing.Size(226, 23);
            cbTravelPurpose.TabIndex = 13;
            cbTravelPurpose.Visible = false;
            cbTravelPurpose.SelectedIndexChanged += cbTravelPurpose_SelectedIndexChanged;
            // 
            // lblTravelPurpose
            // 
            lblTravelPurpose.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTravelPurpose.AutoSize = true;
            lblTravelPurpose.Location = new System.Drawing.Point(100, 425);
            lblTravelPurpose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTravelPurpose.Name = "lblTravelPurpose";
            lblTravelPurpose.Size = new System.Drawing.Size(86, 15);
            lblTravelPurpose.TabIndex = 12;
            lblTravelPurpose.Text = "Travel Purpose:";
            lblTravelPurpose.Visible = false;
            // 
            // txtOtherEvent
            // 
            txtOtherEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtOtherEvent.Enabled = false;
            txtOtherEvent.Location = new System.Drawing.Point(272, 249);
            txtOtherEvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOtherEvent.Name = "txtOtherEvent";
            txtOtherEvent.Size = new System.Drawing.Size(226, 23);
            txtOtherEvent.TabIndex = 11;
            // 
            // lblOtherEvent
            // 
            lblOtherEvent.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblOtherEvent.AutoSize = true;
            lblOtherEvent.Enabled = false;
            lblOtherEvent.Location = new System.Drawing.Point(102, 254);
            lblOtherEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOtherEvent.Name = "lblOtherEvent";
            lblOtherEvent.Size = new System.Drawing.Size(72, 15);
            lblOtherEvent.TabIndex = 10;
            lblOtherEvent.Text = "Other Event:";
            // 
            // cbTravelEvent
            // 
            cbTravelEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbTravelEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTravelEvent.FormattingEnabled = true;
            cbTravelEvent.Items.AddRange(new object[] { "FMCA Aerial Fly In", "AMCA Annual Meeting", "FMCA Annual Meeting", "FASD Annual Meeting", "Chemical Response Training", "FMCA Legislative", "AMCA Legislative", "FGFOA Accounting", "FMCA Dodd Short Course", "FASD Legislative", "FRS Training", "Aquatic Weed Shortcourse", "FAPMS", "APMS", "SFAPMS", "FLMS", "CHNEP", "Other" });
            cbTravelEvent.Location = new System.Drawing.Point(272, 211);
            cbTravelEvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbTravelEvent.Name = "cbTravelEvent";
            cbTravelEvent.Size = new System.Drawing.Size(226, 23);
            cbTravelEvent.TabIndex = 9;
            cbTravelEvent.SelectedIndexChanged += cbTravelEvent_SelectedIndexChanged;
            // 
            // lblTravelEvent
            // 
            lblTravelEvent.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTravelEvent.AutoSize = true;
            lblTravelEvent.Location = new System.Drawing.Point(102, 217);
            lblTravelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTravelEvent.Name = "lblTravelEvent";
            lblTravelEvent.Size = new System.Drawing.Size(72, 15);
            lblTravelEvent.TabIndex = 8;
            lblTravelEvent.Text = "Travel Event:";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReturnDate.Location = new System.Drawing.Point(272, 174);
            dtpReturnDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new System.Drawing.Size(138, 23);
            dtpReturnDate.TabIndex = 7;
            // 
            // lblReturnDate
            // 
            lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new System.Drawing.Point(102, 182);
            lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new System.Drawing.Size(72, 15);
            lblReturnDate.TabIndex = 6;
            lblReturnDate.Text = "Return Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 486);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(501, 15);
            label1.TabIndex = 24;
            label1.Text = "Describe the specific skills or strategies obtained as a result of participating in this travel event:";
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = (System.Drawing.Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new System.Drawing.Point(539, 483);
            btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(28, 21);
            btnInfo.TabIndex = 25;
            toolTip1.SetToolTip(btnInfo, "Only for travel event that requires it, you should ask your supervisor ");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // RegisterTravel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(577, 669);
            ControlBox = false;
            Controls.Add(btnInfo);
            Controls.Add(label1);
            Controls.Add(cbState);
            Controls.Add(btnCancelTravel);
            Controls.Add(lblTravelState);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtDestination);
            Controls.Add(tblNotes);
            Controls.Add(txtOrigin);
            Controls.Add(lblDepartureTime);
            Controls.Add(lblDestination);
            Controls.Add(dtpDepartureTime);
            Controls.Add(txtOtherPurpose);
            Controls.Add(lblDepartureDate);
            Controls.Add(lblOtherPurpose);
            Controls.Add(dtpDepartureDate);
            Controls.Add(lblOrigin);
            Controls.Add(lblReturnTime);
            Controls.Add(cbTravelPurpose);
            Controls.Add(dtpReturnTime);
            Controls.Add(lblTravelPurpose);
            Controls.Add(lblReturnDate);
            Controls.Add(txtOtherEvent);
            Controls.Add(dtpReturnDate);
            Controls.Add(lblOtherEvent);
            Controls.Add(lblTravelEvent);
            Controls.Add(cbTravelEvent);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RegisterTravel";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Register Travel";
            Load += RegisterTravel_Load;
            tblNotes.ResumeLayout(false);
            tblNotes.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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