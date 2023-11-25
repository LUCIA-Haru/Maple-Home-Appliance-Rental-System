namespace HomeAppliance_RentalSystem
{
    partial class Admin_Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Sign_Up));
            this.btnBack = new System.Windows.Forms.Button();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.cboAPosition = new System.Windows.Forms.ComboBox();
            this.dtaAdmin = new System.Windows.Forms.DateTimePicker();
            this.btnADelete = new System.Windows.Forms.Button();
            this.btnAReset = new System.Windows.Forms.Button();
            this.btnASave = new System.Windows.Forms.Button();
            this.dgvASignUp = new System.Windows.Forms.DataGridView();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblAPosition = new System.Windows.Forms.Label();
            this.lblAAddress = new System.Windows.Forms.Label();
            this.lblADOB = new System.Windows.Forms.Label();
            this.lblANRC = new System.Windows.Forms.Label();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.txtANRC = new System.Windows.Forms.TextBox();
            this.txtAAddress = new System.Windows.Forms.TextBox();
            this.txtAPhone = new System.Windows.Forms.TextBox();
            this.txtAdID = new System.Windows.Forms.TextBox();
            this.txtAEmail = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.txtAPassword = new System.Windows.Forms.TextBox();
            this.lblAEmail = new System.Windows.Forms.Label();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblAName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAPasssword = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblExiit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 31);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.gbAdmin.Controls.Add(this.cboAPosition);
            this.gbAdmin.Controls.Add(this.dtaAdmin);
            this.gbAdmin.Controls.Add(this.btnADelete);
            this.gbAdmin.Controls.Add(this.btnAReset);
            this.gbAdmin.Controls.Add(this.btnASave);
            this.gbAdmin.Controls.Add(this.dgvASignUp);
            this.gbAdmin.Controls.Add(this.lblApp);
            this.gbAdmin.Controls.Add(this.lblAPosition);
            this.gbAdmin.Controls.Add(this.lblAAddress);
            this.gbAdmin.Controls.Add(this.lblADOB);
            this.gbAdmin.Controls.Add(this.lblANRC);
            this.gbAdmin.Controls.Add(this.pbAdmin);
            this.gbAdmin.Controls.Add(this.txtANRC);
            this.gbAdmin.Controls.Add(this.txtAAddress);
            this.gbAdmin.Controls.Add(this.txtAPhone);
            this.gbAdmin.Controls.Add(this.txtAdID);
            this.gbAdmin.Controls.Add(this.txtAEmail);
            this.gbAdmin.Controls.Add(this.txtAName);
            this.gbAdmin.Controls.Add(this.txtAPassword);
            this.gbAdmin.Controls.Add(this.lblAEmail);
            this.gbAdmin.Controls.Add(this.lblAdminID);
            this.gbAdmin.Controls.Add(this.lblAName);
            this.gbAdmin.Controls.Add(this.label5);
            this.gbAdmin.Controls.Add(this.lblAPasssword);
            this.gbAdmin.Controls.Add(this.pictureBox4);
            this.gbAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmin.Location = new System.Drawing.Point(11, 105);
            this.gbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.gbAdmin.Size = new System.Drawing.Size(883, 571);
            this.gbAdmin.TabIndex = 54;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin ";
            // 
            // cboAPosition
            // 
            this.cboAPosition.FormattingEnabled = true;
            this.cboAPosition.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Assistant Manager"});
            this.cboAPosition.Location = new System.Drawing.Point(600, 128);
            this.cboAPosition.Name = "cboAPosition";
            this.cboAPosition.Size = new System.Drawing.Size(230, 32);
            this.cboAPosition.TabIndex = 85;
            this.cboAPosition.Text = "Choose Position";
            // 
            // dtaAdmin
            // 
            this.dtaAdmin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaAdmin.Location = new System.Drawing.Point(600, 90);
            this.dtaAdmin.Name = "dtaAdmin";
            this.dtaAdmin.Size = new System.Drawing.Size(230, 29);
            this.dtaAdmin.TabIndex = 84;
            // 
            // btnADelete
            // 
            this.btnADelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnADelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADelete.FlatAppearance.BorderSize = 0;
            this.btnADelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADelete.Location = new System.Drawing.Point(411, 333);
            this.btnADelete.Name = "btnADelete";
            this.btnADelete.Size = new System.Drawing.Size(84, 28);
            this.btnADelete.TabIndex = 83;
            this.btnADelete.Text = "&Delete";
            this.btnADelete.UseVisualStyleBackColor = false;
            this.btnADelete.Click += new System.EventHandler(this.btnADelete_Click);
            // 
            // btnAReset
            // 
            this.btnAReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(180)))));
            this.btnAReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAReset.FlatAppearance.BorderSize = 0;
            this.btnAReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAReset.Location = new System.Drawing.Point(294, 333);
            this.btnAReset.Name = "btnAReset";
            this.btnAReset.Size = new System.Drawing.Size(84, 28);
            this.btnAReset.TabIndex = 82;
            this.btnAReset.Text = "&Reset";
            this.btnAReset.UseVisualStyleBackColor = false;
            this.btnAReset.Click += new System.EventHandler(this.btnAReset_Click);
            // 
            // btnASave
            // 
            this.btnASave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.btnASave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnASave.FlatAppearance.BorderSize = 0;
            this.btnASave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnASave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASave.Location = new System.Drawing.Point(168, 333);
            this.btnASave.Name = "btnASave";
            this.btnASave.Size = new System.Drawing.Size(84, 28);
            this.btnASave.TabIndex = 80;
            this.btnASave.Text = "&Save";
            this.btnASave.UseVisualStyleBackColor = false;
            this.btnASave.Click += new System.EventHandler(this.btnASave_Click);
            // 
            // dgvASignUp
            // 
            this.dgvASignUp.AllowUserToAddRows = false;
            this.dgvASignUp.AllowUserToDeleteRows = false;
            this.dgvASignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.dgvASignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvASignUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASignUp.Location = new System.Drawing.Point(23, 387);
            this.dgvASignUp.Name = "dgvASignUp";
            this.dgvASignUp.ReadOnly = true;
            this.dgvASignUp.RowTemplate.Height = 24;
            this.dgvASignUp.Size = new System.Drawing.Size(825, 161);
            this.dgvASignUp.TabIndex = 79;
            this.dgvASignUp.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvASignUp_CellMouseClick);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(423, 237);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(141, 24);
            this.lblApp.TabIndex = 78;
            this.lblApp.Text = "Profile Picture :";
            // 
            // lblAPosition
            // 
            this.lblAPosition.AutoSize = true;
            this.lblAPosition.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPosition.Location = new System.Drawing.Point(423, 136);
            this.lblAPosition.Name = "lblAPosition";
            this.lblAPosition.Size = new System.Drawing.Size(89, 24);
            this.lblAPosition.TabIndex = 77;
            this.lblAPosition.Text = "Position :";
            // 
            // lblAAddress
            // 
            this.lblAAddress.AutoSize = true;
            this.lblAAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAAddress.Location = new System.Drawing.Point(423, 178);
            this.lblAAddress.Name = "lblAAddress";
            this.lblAAddress.Size = new System.Drawing.Size(93, 24);
            this.lblAAddress.TabIndex = 76;
            this.lblAAddress.Text = "Address : ";
            // 
            // lblADOB
            // 
            this.lblADOB.AutoSize = true;
            this.lblADOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADOB.Location = new System.Drawing.Point(423, 96);
            this.lblADOB.Name = "lblADOB";
            this.lblADOB.Size = new System.Drawing.Size(130, 24);
            this.lblADOB.TabIndex = 75;
            this.lblADOB.Text = "Date of Birth :";
            // 
            // lblANRC
            // 
            this.lblANRC.AutoSize = true;
            this.lblANRC.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANRC.Location = new System.Drawing.Point(423, 42);
            this.lblANRC.Name = "lblANRC";
            this.lblANRC.Size = new System.Drawing.Size(57, 24);
            this.lblANRC.TabIndex = 74;
            this.lblANRC.Text = "NRC :";
            // 
            // pbAdmin
            // 
            this.pbAdmin.BackColor = System.Drawing.Color.White;
            this.pbAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAdmin.Location = new System.Drawing.Point(600, 237);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(230, 121);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdmin.TabIndex = 72;
            this.pbAdmin.TabStop = false;
            this.pbAdmin.Click += new System.EventHandler(this.pbApic1_Click);
            // 
            // txtANRC
            // 
            this.txtANRC.Location = new System.Drawing.Point(600, 44);
            this.txtANRC.Name = "txtANRC";
            this.txtANRC.Size = new System.Drawing.Size(230, 29);
            this.txtANRC.TabIndex = 71;
            // 
            // txtAAddress
            // 
            this.txtAAddress.Location = new System.Drawing.Point(600, 175);
            this.txtAAddress.Multiline = true;
            this.txtAAddress.Name = "txtAAddress";
            this.txtAAddress.Size = new System.Drawing.Size(230, 47);
            this.txtAAddress.TabIndex = 69;
            // 
            // txtAPhone
            // 
            this.txtAPhone.Location = new System.Drawing.Point(138, 136);
            this.txtAPhone.Name = "txtAPhone";
            this.txtAPhone.Size = new System.Drawing.Size(230, 29);
            this.txtAPhone.TabIndex = 68;
            // 
            // txtAdID
            // 
            this.txtAdID.Enabled = false;
            this.txtAdID.Location = new System.Drawing.Point(138, 44);
            this.txtAdID.Name = "txtAdID";
            this.txtAdID.Size = new System.Drawing.Size(230, 29);
            this.txtAdID.TabIndex = 67;
            // 
            // txtAEmail
            // 
            this.txtAEmail.Location = new System.Drawing.Point(138, 187);
            this.txtAEmail.Name = "txtAEmail";
            this.txtAEmail.Size = new System.Drawing.Size(230, 29);
            this.txtAEmail.TabIndex = 66;
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(138, 91);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(230, 29);
            this.txtAName.TabIndex = 65;
            // 
            // txtAPassword
            // 
            this.txtAPassword.Location = new System.Drawing.Point(138, 237);
            this.txtAPassword.Name = "txtAPassword";
            this.txtAPassword.PasswordChar = '*';
            this.txtAPassword.Size = new System.Drawing.Size(230, 29);
            this.txtAPassword.TabIndex = 64;
            // 
            // lblAEmail
            // 
            this.lblAEmail.AutoSize = true;
            this.lblAEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAEmail.Location = new System.Drawing.Point(5, 192);
            this.lblAEmail.Name = "lblAEmail";
            this.lblAEmail.Size = new System.Drawing.Size(67, 24);
            this.lblAEmail.TabIndex = 56;
            this.lblAEmail.Text = "Email :";
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.Location = new System.Drawing.Point(5, 42);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(96, 24);
            this.lblAdminID.TabIndex = 57;
            this.lblAdminID.Text = "AdminID :";
            // 
            // lblAName
            // 
            this.lblAName.AutoSize = true;
            this.lblAName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAName.Location = new System.Drawing.Point(3, 98);
            this.lblAName.Name = "lblAName";
            this.lblAName.Size = new System.Drawing.Size(98, 24);
            this.lblAName.TabIndex = 58;
            this.lblAName.Text = "Fullname :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "Phone No. :";
            // 
            // lblAPasssword
            // 
            this.lblAPasssword.AutoSize = true;
            this.lblAPasssword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPasssword.Location = new System.Drawing.Point(1, 242);
            this.lblAPasssword.Name = "lblAPasssword";
            this.lblAPasssword.Size = new System.Drawing.Size(105, 24);
            this.lblAPasssword.TabIndex = 62;
            this.lblAPasssword.Text = "Password : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(351, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 87;
            this.pictureBox4.TabStop = false;
            // 
            // lblExiit
            // 
            this.lblExiit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblExiit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExiit.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExiit.Location = new System.Drawing.Point(863, 14);
            this.lblExiit.Name = "lblExiit";
            this.lblExiit.Size = new System.Drawing.Size(30, 31);
            this.lblExiit.TabIndex = 55;
            this.lblExiit.Text = "X";
            this.lblExiit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExiit.Click += new System.EventHandler(this.lblExiit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 45);
            this.label1.TabIndex = 57;
            this.label1.Text = "~ SignUp Form ~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 681);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // Admin_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExiit);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Sign_Up";
            this.Load += new System.EventHandler(this.Admin_Sign_Up_Load);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Label lblAEmail;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblAName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAPasssword;
        private System.Windows.Forms.TextBox txtANRC;
        private System.Windows.Forms.TextBox txtAAddress;
        private System.Windows.Forms.TextBox txtAPhone;
        private System.Windows.Forms.TextBox txtAdID;
        private System.Windows.Forms.TextBox txtAEmail;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.TextBox txtAPassword;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblAPosition;
        private System.Windows.Forms.Label lblAAddress;
        private System.Windows.Forms.Label lblADOB;
        private System.Windows.Forms.Label lblANRC;
        private System.Windows.Forms.Button btnADelete;
        private System.Windows.Forms.Button btnAReset;
        private System.Windows.Forms.Button btnASave;
        private System.Windows.Forms.DataGridView dgvASignUp;
        private System.Windows.Forms.Label lblExiit;
        private System.Windows.Forms.DateTimePicker dtaAdmin;
        private System.Windows.Forms.ComboBox cboAPosition;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}