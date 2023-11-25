namespace HomeAppliance_RentalSystem
{
    partial class Admin_LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_LoginForm));
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvALogin = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkASignIn = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAReset = new System.Windows.Forms.Button();
            this.btnALogin = new System.Windows.Forms.Button();
            this.txtAPassword = new System.Windows.Forms.TextBox();
            this.txtAEmail = new System.Windows.Forms.TextBox();
            this.lblAPassword = new System.Windows.Forms.Label();
            this.lblAEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDesign.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvALogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            this.pbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(208, 27);
            this.pbLogin.Margin = new System.Windows.Forms.Padding(6);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(511, 258);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogin.TabIndex = 1;
            this.pbLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 725);
            this.panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlDesign
            // 
            this.pnlDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pnlDesign.Controls.Add(this.lblX);
            this.pnlDesign.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDesign.Location = new System.Drawing.Point(800, 0);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(105, 725);
            this.pnlDesign.TabIndex = 6;
            // 
            // lblX
            // 
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblX.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(63, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(30, 31);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dgvALogin);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.linkASignIn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnAReset);
            this.groupBox1.Controls.Add(this.btnALogin);
            this.groupBox1.Controls.Add(this.txtAPassword);
            this.groupBox1.Controls.Add(this.txtAEmail);
            this.groupBox1.Controls.Add(this.lblAPassword);
            this.groupBox1.Controls.Add(this.lblAEmail);
            this.groupBox1.Location = new System.Drawing.Point(112, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 431);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin LogIn Form";
            // 
            // dgvALogin
            // 
            this.dgvALogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvALogin.Location = new System.Drawing.Point(205, 317);
            this.dgvALogin.Name = "dgvALogin";
            this.dgvALogin.RowTemplate.Height = 24;
            this.dgvALogin.Size = new System.Drawing.Size(240, 12);
            this.dgvALogin.TabIndex = 10;
            this.dgvALogin.Visible = false;

            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // linkASignIn
            // 
            this.linkASignIn.AutoSize = true;
            this.linkASignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkASignIn.Location = new System.Drawing.Point(98, 256);
            this.linkASignIn.Name = "linkASignIn";
            this.linkASignIn.Size = new System.Drawing.Size(79, 24);
            this.linkASignIn.TabIndex = 11;
            this.linkASignIn.TabStop = true;
            this.linkASignIn.Text = "SignUp?";
            this.linkASignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkASignIn_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
 
            // 
            // btnAReset
            // 
            this.btnAReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnAReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAReset.FlatAppearance.BorderSize = 0;
            this.btnAReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAReset.Location = new System.Drawing.Point(404, 249);
            this.btnAReset.Name = "btnAReset";
            this.btnAReset.Size = new System.Drawing.Size(105, 31);
            this.btnAReset.TabIndex = 9;
            this.btnAReset.Text = "Reset";
            this.btnAReset.UseVisualStyleBackColor = false;
            this.btnAReset.Click += new System.EventHandler(this.btnAReset_Click);
            // 
            // btnALogin
            // 
            this.btnALogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.btnALogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnALogin.FlatAppearance.BorderSize = 0;
            this.btnALogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnALogin.Location = new System.Drawing.Point(243, 249);
            this.btnALogin.Name = "btnALogin";
            this.btnALogin.Size = new System.Drawing.Size(105, 31);
            this.btnALogin.TabIndex = 8;
            this.btnALogin.Text = "Login";
            this.btnALogin.UseVisualStyleBackColor = false;
            this.btnALogin.Click += new System.EventHandler(this.btnALogin_Click);
            // 
            // txtAPassword
            // 
            this.txtAPassword.Location = new System.Drawing.Point(243, 149);
            this.txtAPassword.Name = "txtAPassword";
            this.txtAPassword.PasswordChar = '*';
            this.txtAPassword.Size = new System.Drawing.Size(311, 29);
            this.txtAPassword.TabIndex = 7;
            // 
            // txtAEmail
            // 
            this.txtAEmail.Location = new System.Drawing.Point(243, 59);
            this.txtAEmail.Name = "txtAEmail";
            this.txtAEmail.Size = new System.Drawing.Size(311, 29);
            this.txtAEmail.TabIndex = 6;
            // 
            // lblAPassword
            // 
            this.lblAPassword.AutoSize = true;
            this.lblAPassword.Location = new System.Drawing.Point(98, 149);
            this.lblAPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAPassword.Name = "lblAPassword";
            this.lblAPassword.Size = new System.Drawing.Size(111, 24);
            this.lblAPassword.TabIndex = 5;
            this.lblAPassword.Text = "Passoword :";
            // 
            // lblAEmail
            // 
            this.lblAEmail.AutoSize = true;
            this.lblAEmail.Location = new System.Drawing.Point(98, 62);
            this.lblAEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAEmail.Name = "lblAEmail";
            this.lblAEmail.Size = new System.Drawing.Size(72, 24);
            this.lblAEmail.TabIndex = 4;
            this.lblAEmail.Text = "Email : ";
            // 
            // Admin_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.pnlDesign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbLogin);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlDesign.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvALogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAPassword;
        private System.Windows.Forms.TextBox txtAEmail;
        private System.Windows.Forms.Label lblAPassword;
        private System.Windows.Forms.Label lblAEmail;
        private System.Windows.Forms.DataGridView dgvALogin;
        private System.Windows.Forms.Button btnAReset;
        private System.Windows.Forms.Button btnALogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel linkASignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}