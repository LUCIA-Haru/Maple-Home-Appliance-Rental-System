namespace HomeAppliance_RentalSystem
{
    partial class Renting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renting));
            this.gbApp = new System.Windows.Forms.GroupBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAPImage = new System.Windows.Forms.PictureBox();
            this.cboApName = new System.Windows.Forms.ComboBox();
            this.txtApfee = new System.Windows.Forms.TextBox();
            this.lblApImage = new System.Windows.Forms.Label();
            this.txtApID = new System.Windows.Forms.TextBox();
            this.lblANAme = new System.Windows.Forms.Label();
            this.lblApID = new System.Windows.Forms.Label();
            this.lblApFee = new System.Windows.Forms.Label();
            this.gbRenting = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitAmount = new System.Windows.Forms.TextBox();
            this.lblUnitAmount = new System.Windows.Forms.Label();
            this.cboDuration = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.lblrentID = new System.Windows.Forms.Label();
            this.txtRTA = new System.Windows.Forms.TextBox();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.txtRTQ = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.lblRDate = new System.Windows.Forms.Label();
            this.lblTQuantity = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblTAmount = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerNRC = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCAddress = new System.Windows.Forms.Label();
            this.lblCNRC = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.dgvRenting = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRReset = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.gbApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAPImage)).BeginInit();
            this.gbRenting.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenting)).BeginInit();
            this.SuspendLayout();
            // 
            // gbApp
            // 
            this.gbApp.Controls.Add(this.txtquantity);
            this.gbApp.Controls.Add(this.lblQuantity);
            this.gbApp.Controls.Add(this.label1);
            this.gbApp.Controls.Add(this.pbAPImage);
            this.gbApp.Controls.Add(this.cboApName);
            this.gbApp.Controls.Add(this.txtApfee);
            this.gbApp.Controls.Add(this.lblApImage);
            this.gbApp.Controls.Add(this.txtApID);
            this.gbApp.Controls.Add(this.lblANAme);
            this.gbApp.Controls.Add(this.lblApID);
            this.gbApp.Controls.Add(this.lblApFee);
            this.gbApp.Location = new System.Drawing.Point(31, 486);
            this.gbApp.Name = "gbApp";
            this.gbApp.Size = new System.Drawing.Size(396, 232);
            this.gbApp.TabIndex = 0;
            this.gbApp.TabStop = false;
            this.gbApp.Text = "Appliances Details";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(179, 130);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(191, 27);
            this.txtquantity.TabIndex = 84;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 130);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 19);
            this.lblQuantity.TabIndex = 83;
            this.lblQuantity.Text = "Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "$";
            // 
            // pbAPImage
            // 
            this.pbAPImage.BackColor = System.Drawing.Color.White;
            this.pbAPImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAPImage.Location = new System.Drawing.Point(179, 163);
            this.pbAPImage.Name = "pbAPImage";
            this.pbAPImage.Size = new System.Drawing.Size(192, 69);
            this.pbAPImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAPImage.TabIndex = 81;
            this.pbAPImage.TabStop = false;
            // 
            // cboApName
            // 
            this.cboApName.FormattingEnabled = true;
            this.cboApName.Location = new System.Drawing.Point(179, 24);
            this.cboApName.Name = "cboApName";
            this.cboApName.Size = new System.Drawing.Size(192, 27);
            this.cboApName.TabIndex = 73;
            this.cboApName.SelectedIndexChanged += new System.EventHandler(this.cboApName_SelectedIndexChanged);
            // 
            // txtApfee
            // 
            this.txtApfee.Location = new System.Drawing.Point(202, 97);
            this.txtApfee.Name = "txtApfee";
            this.txtApfee.Size = new System.Drawing.Size(169, 27);
            this.txtApfee.TabIndex = 80;
            // 
            // lblApImage
            // 
            this.lblApImage.AutoSize = true;
            this.lblApImage.Location = new System.Drawing.Point(20, 163);
            this.lblApImage.Name = "lblApImage";
            this.lblApImage.Size = new System.Drawing.Size(65, 19);
            this.lblApImage.TabIndex = 16;
            this.lblApImage.Text = "Image :";
            // 
            // txtApID
            // 
            this.txtApID.Location = new System.Drawing.Point(180, 61);
            this.txtApID.Name = "txtApID";
            this.txtApID.Size = new System.Drawing.Size(191, 27);
            this.txtApID.TabIndex = 76;
            // 
            // lblANAme
            // 
            this.lblANAme.AutoSize = true;
            this.lblANAme.Location = new System.Drawing.Point(20, 32);
            this.lblANAme.Name = "lblANAme";
            this.lblANAme.Size = new System.Drawing.Size(149, 19);
            this.lblANAme.TabIndex = 14;
            this.lblANAme.Text = "Appliances Name :";
            // 
            // lblApID
            // 
            this.lblApID.AutoSize = true;
            this.lblApID.Location = new System.Drawing.Point(20, 64);
            this.lblApID.Name = "lblApID";
            this.lblApID.Size = new System.Drawing.Size(120, 19);
            this.lblApID.TabIndex = 13;
            this.lblApID.Text = "Appliances ID :";
            // 
            // lblApFee
            // 
            this.lblApFee.AutoSize = true;
            this.lblApFee.Location = new System.Drawing.Point(21, 97);
            this.lblApFee.Name = "lblApFee";
            this.lblApFee.Size = new System.Drawing.Size(95, 19);
            this.lblApFee.TabIndex = 12;
            this.lblApFee.Text = "Rental Fee :";
            // 
            // gbRenting
            // 
            this.gbRenting.Controls.Add(this.label3);
            this.gbRenting.Controls.Add(this.label4);
            this.gbRenting.Controls.Add(this.label2);
            this.gbRenting.Controls.Add(this.txtUnitAmount);
            this.gbRenting.Controls.Add(this.lblUnitAmount);
            this.gbRenting.Controls.Add(this.cboDuration);
            this.gbRenting.Controls.Add(this.lblDuration);
            this.gbRenting.Controls.Add(this.dtpStart);
            this.gbRenting.Controls.Add(this.dtpDue);
            this.gbRenting.Controls.Add(this.lblrentID);
            this.gbRenting.Controls.Add(this.txtRTA);
            this.gbRenting.Controls.Add(this.txtRID);
            this.gbRenting.Controls.Add(this.txtRTQ);
            this.gbRenting.Controls.Add(this.btnRemove);
            this.gbRenting.Controls.Add(this.btnADD);
            this.gbRenting.Controls.Add(this.lblRDate);
            this.gbRenting.Controls.Add(this.lblTQuantity);
            this.gbRenting.Controls.Add(this.lblDueDate);
            this.gbRenting.Controls.Add(this.lblTAmount);
            this.gbRenting.Location = new System.Drawing.Point(12, 87);
            this.gbRenting.Name = "gbRenting";
            this.gbRenting.Size = new System.Drawing.Size(878, 171);
            this.gbRenting.TabIndex = 0;
            this.gbRenting.TabStop = false;
            this.gbRenting.Text = "Renting Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "$";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(821, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 86;
            this.label2.Text = "Month";
            // 
            // txtUnitAmount
            // 
            this.txtUnitAmount.Location = new System.Drawing.Point(377, 84);
            this.txtUnitAmount.Name = "txtUnitAmount";
            this.txtUnitAmount.Size = new System.Drawing.Size(145, 27);
            this.txtUnitAmount.TabIndex = 85;
            // 
            // lblUnitAmount
            // 
            this.lblUnitAmount.AutoSize = true;
            this.lblUnitAmount.Location = new System.Drawing.Point(261, 73);
            this.lblUnitAmount.Name = "lblUnitAmount";
            this.lblUnitAmount.Size = new System.Drawing.Size(79, 38);
            this.lblUnitAmount.TabIndex = 84;
            this.lblUnitAmount.Text = "Unit \r\nAmount :";
            // 
            // cboDuration
            // 
            this.cboDuration.FormattingEnabled = true;
            this.cboDuration.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "9"});
            this.cboDuration.Location = new System.Drawing.Point(656, 84);
            this.cboDuration.Name = "cboDuration";
            this.cboDuration.Size = new System.Drawing.Size(161, 27);
            this.cboDuration.TabIndex = 83;
            this.cboDuration.Text = "Choose Duration";
            this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.cboDuration_SelectedIndexChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(560, 84);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(84, 19);
            this.lblDuration.TabIndex = 82;
            this.lblDuration.Text = "Duration :";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(361, 34);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(161, 27);
            this.dtpStart.TabIndex = 81;
            // 
            // dtpDue
            // 
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(656, 34);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(161, 27);
            this.dtpDue.TabIndex = 80;
            // 
            // lblrentID
            // 
            this.lblrentID.AutoSize = true;
            this.lblrentID.Location = new System.Drawing.Point(6, 40);
            this.lblrentID.Name = "lblrentID";
            this.lblrentID.Size = new System.Drawing.Size(69, 19);
            this.lblrentID.TabIndex = 7;
            this.lblrentID.Text = "RentID :";
            // 
            // txtRTA
            // 
            this.txtRTA.Location = new System.Drawing.Point(377, 130);
            this.txtRTA.Name = "txtRTA";
            this.txtRTA.Size = new System.Drawing.Size(145, 27);
            this.txtRTA.TabIndex = 77;
            // 
            // txtRID
            // 
            this.txtRID.Enabled = false;
            this.txtRID.Location = new System.Drawing.Point(94, 40);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(161, 27);
            this.txtRID.TabIndex = 79;
            // 
            // txtRTQ
            // 
            this.txtRTQ.Location = new System.Drawing.Point(94, 84);
            this.txtRTQ.Name = "txtRTQ";
            this.txtRTQ.Size = new System.Drawing.Size(161, 27);
            this.txtRTQ.TabIndex = 78;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(752, 128);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 28);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(209)))), ((int)(((byte)(250)))));
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADD.Location = new System.Drawing.Point(596, 128);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(84, 28);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lblRDate
            // 
            this.lblRDate.AutoSize = true;
            this.lblRDate.Location = new System.Drawing.Point(261, 37);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(93, 19);
            this.lblRDate.TabIndex = 8;
            this.lblRDate.Text = "Start Date :";
            // 
            // lblTQuantity
            // 
            this.lblTQuantity.AutoSize = true;
            this.lblTQuantity.Location = new System.Drawing.Point(6, 91);
            this.lblTQuantity.Name = "lblTQuantity";
            this.lblTQuantity.Size = new System.Drawing.Size(83, 38);
            this.lblTQuantity.TabIndex = 11;
            this.lblTQuantity.Text = "Total \r\nQuantity :";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(560, 37);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(88, 19);
            this.lblDueDate.TabIndex = 9;
            this.lblDueDate.Text = "Due Date :";
            // 
            // lblTAmount
            // 
            this.lblTAmount.AutoSize = true;
            this.lblTAmount.Location = new System.Drawing.Point(261, 118);
            this.lblTAmount.Name = "lblTAmount";
            this.lblTAmount.Size = new System.Drawing.Size(79, 38);
            this.lblTAmount.TabIndex = 10;
            this.lblTAmount.Text = "Total \r\nAmount :";
            // 
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.gbCustomer.Controls.Add(this.pictureBox3);
            this.gbCustomer.Controls.Add(this.lblCustomerAddress);
            this.gbCustomer.Controls.Add(this.lblCustomerNRC);
            this.gbCustomer.Controls.Add(this.lblCustomerName);
            this.gbCustomer.Controls.Add(this.lblCustomerID);
            this.gbCustomer.Controls.Add(this.pictureBox2);
            this.gbCustomer.Controls.Add(this.lblCAddress);
            this.gbCustomer.Controls.Add(this.lblCNRC);
            this.gbCustomer.Controls.Add(this.lblCName);
            this.gbCustomer.Controls.Add(this.lblCID);
            this.gbCustomer.Location = new System.Drawing.Point(454, 486);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(417, 232);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Details";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(328, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(169, 131);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(20, 26);
            this.lblCustomerAddress.TabIndex = 87;
            this.lblCustomerAddress.Text = "-";
            // 
            // lblCustomerNRC
            // 
            this.lblCustomerNRC.AutoSize = true;
            this.lblCustomerNRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblCustomerNRC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNRC.Location = new System.Drawing.Point(169, 97);
            this.lblCustomerNRC.Name = "lblCustomerNRC";
            this.lblCustomerNRC.Size = new System.Drawing.Size(20, 26);
            this.lblCustomerNRC.TabIndex = 86;
            this.lblCustomerNRC.Text = "-";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(169, 64);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(20, 26);
            this.lblCustomerName.TabIndex = 85;
            this.lblCustomerName.Text = "-";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(169, 25);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(20, 26);
            this.lblCustomerID.TabIndex = 83;
            this.lblCustomerID.Text = "-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // lblCAddress
            // 
            this.lblCAddress.AutoSize = true;
            this.lblCAddress.Location = new System.Drawing.Point(17, 131);
            this.lblCAddress.Name = "lblCAddress";
            this.lblCAddress.Size = new System.Drawing.Size(77, 19);
            this.lblCAddress.TabIndex = 17;
            this.lblCAddress.Text = "Address :";
            // 
            // lblCNRC
            // 
            this.lblCNRC.AutoSize = true;
            this.lblCNRC.Location = new System.Drawing.Point(17, 97);
            this.lblCNRC.Name = "lblCNRC";
            this.lblCNRC.Size = new System.Drawing.Size(54, 19);
            this.lblCNRC.TabIndex = 18;
            this.lblCNRC.Text = "NRC : ";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(17, 64);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(140, 19);
            this.lblCName.TabIndex = 19;
            this.lblCName.Text = "Customer Name :";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(17, 32);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(111, 19);
            this.lblCID.TabIndex = 15;
            this.lblCID.Text = "Customer ID :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 31);
            this.btnBack.TabIndex = 68;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblX
            // 
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblX.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(871, 12);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 24);
            this.lblX.TabIndex = 67;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // dgvRenting
            // 
            this.dgvRenting.AllowUserToAddRows = false;
            this.dgvRenting.AllowUserToDeleteRows = false;
            this.dgvRenting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.dgvRenting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenting.Location = new System.Drawing.Point(12, 264);
            this.dgvRenting.Name = "dgvRenting";
            this.dgvRenting.ReadOnly = true;
            this.dgvRenting.RowTemplate.Height = 24;
            this.dgvRenting.Size = new System.Drawing.Size(878, 175);
            this.dgvRenting.TabIndex = 69;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(362, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 44);
            this.lblTitle.TabIndex = 70;
            this.lblTitle.Text = "~ Renting ~";
            // 
            // btnRReset
            // 
            this.btnRReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(180)))));
            this.btnRReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRReset.FlatAppearance.BorderSize = 0;
            this.btnRReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRReset.Location = new System.Drawing.Point(474, 445);
            this.btnRReset.Name = "btnRReset";
            this.btnRReset.Size = new System.Drawing.Size(84, 28);
            this.btnRReset.TabIndex = 1;
            this.btnRReset.Text = "&Reset";
            this.btnRReset.UseVisualStyleBackColor = false;
            this.btnRReset.Click += new System.EventHandler(this.btnRReset_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRent.FlatAppearance.BorderSize = 0;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRent.Location = new System.Drawing.Point(318, 445);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(84, 28);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "&Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // Renting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.btnRReset);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.gbRenting);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRenting);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.gbApp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Renting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renting";
            this.Load += new System.EventHandler(this.Renting_Load);
            this.gbApp.ResumeLayout(false);
            this.gbApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAPImage)).EndInit();
            this.gbRenting.ResumeLayout(false);
            this.gbRenting.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbApp;
        private System.Windows.Forms.GroupBox gbRenting;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.DataGridView dgvRenting;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblApImage;
        private System.Windows.Forms.Label lblANAme;
        private System.Windows.Forms.Label lblApID;
        private System.Windows.Forms.Label lblApFee;
        private System.Windows.Forms.Label lblrentID;
        private System.Windows.Forms.Label lblTQuantity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTAmount;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblCAddress;
        private System.Windows.Forms.Label lblCNRC;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Button btnRReset;
        private System.Windows.Forms.PictureBox pbAPImage;
        private System.Windows.Forms.ComboBox cboApName;
        private System.Windows.Forms.TextBox txtApfee;
        private System.Windows.Forms.TextBox txtApID;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.TextBox txtRTA;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.TextBox txtRTQ;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cboDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerNRC;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUnitAmount;
        private System.Windows.Forms.Label lblUnitAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}