namespace HomeAppliance_RentalSystem
{
    partial class Customer_LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_LoginForm));
            this.pblogin = new System.Windows.Forms.PictureBox();
            this.gbCLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvClogin = new System.Windows.Forms.DataGridView();
            this.linkCsignup = new System.Windows.Forms.LinkLabel();
            this.btnCReset = new System.Windows.Forms.Button();
            this.btnCLogin = new System.Windows.Forms.Button();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            this.gbCLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClogin)).BeginInit();
            this.pnlDesign.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblogin
            // 
            this.pblogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pblogin.Image = ((System.Drawing.Image)(resources.GetObject("pblogin.Image")));
            this.pblogin.Location = new System.Drawing.Point(220, 13);
            this.pblogin.Margin = new System.Windows.Forms.Padding(4);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(511, 258);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogin.TabIndex = 0;
            this.pblogin.TabStop = false;
            // 
            // gbCLogin
            // 
            this.gbCLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbCLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCLogin.BackgroundImage")));
            this.gbCLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbCLogin.Controls.Add(this.pictureBox1);
            this.gbCLogin.Controls.Add(this.pictureBox2);
            this.gbCLogin.Controls.Add(this.dgvClogin);
            this.gbCLogin.Controls.Add(this.linkCsignup);
            this.gbCLogin.Controls.Add(this.btnCReset);
            this.gbCLogin.Controls.Add(this.btnCLogin);
            this.gbCLogin.Controls.Add(this.lblCPassword);
            this.gbCLogin.Controls.Add(this.txtCEmail);
            this.gbCLogin.Controls.Add(this.txtCPassword);
            this.gbCLogin.Controls.Add(this.lblCEmail);
            this.gbCLogin.Location = new System.Drawing.Point(112, 304);
            this.gbCLogin.Margin = new System.Windows.Forms.Padding(4);
            this.gbCLogin.Name = "gbCLogin";
            this.gbCLogin.Padding = new System.Windows.Forms.Padding(4);
            this.gbCLogin.Size = new System.Drawing.Size(694, 421);
            this.gbCLogin.TabIndex = 1;
            this.gbCLogin.TabStop = false;
            this.gbCLogin.Text = "Customer LogIn Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // dgvClogin
            // 
            this.dgvClogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClogin.Location = new System.Drawing.Point(218, 307);
            this.dgvClogin.Name = "dgvClogin";
            this.dgvClogin.RowTemplate.Height = 24;
            this.dgvClogin.Size = new System.Drawing.Size(240, 16);
            this.dgvClogin.TabIndex = 2;
            this.dgvClogin.Visible = false;
            // 
            // linkCsignup
            // 
            this.linkCsignup.AutoSize = true;
            this.linkCsignup.Location = new System.Drawing.Point(104, 247);
            this.linkCsignup.Name = "linkCsignup";
            this.linkCsignup.Size = new System.Drawing.Size(80, 24);
            this.linkCsignup.TabIndex = 5;
            this.linkCsignup.TabStop = true;
            this.linkCsignup.Text = "SIgnUp?";
            this.linkCsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCsignup_LinkClicked);
            // 
            // btnCReset
            // 
            this.btnCReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnCReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCReset.FlatAppearance.BorderSize = 0;
            this.btnCReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCReset.Location = new System.Drawing.Point(403, 247);
            this.btnCReset.Name = "btnCReset";
            this.btnCReset.Size = new System.Drawing.Size(106, 30);
            this.btnCReset.TabIndex = 5;
            this.btnCReset.Text = "Reset";
            this.btnCReset.UseVisualStyleBackColor = false;
            this.btnCReset.Click += new System.EventHandler(this.btnCReset_Click);
            // 
            // btnCLogin
            // 
            this.btnCLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.btnCLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCLogin.Location = new System.Drawing.Point(236, 247);
            this.btnCLogin.Name = "btnCLogin";
            this.btnCLogin.Size = new System.Drawing.Size(106, 30);
            this.btnCLogin.TabIndex = 4;
            this.btnCLogin.Text = "Login";
            this.btnCLogin.UseVisualStyleBackColor = false;
            this.btnCLogin.Click += new System.EventHandler(this.btnCLogin_Click);
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.Location = new System.Drawing.Point(91, 142);
            this.lblCPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(111, 24);
            this.lblCPassword.TabIndex = 3;
            this.lblCPassword.Text = "Passoword :";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(243, 52);
            this.txtCEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(376, 29);
            this.txtCEmail.TabIndex = 2;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Location = new System.Drawing.Point(243, 142);
            this.txtCPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.Size = new System.Drawing.Size(376, 29);
            this.txtCPassword.TabIndex = 1;
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.Location = new System.Drawing.Point(91, 57);
            this.lblCEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(72, 24);
            this.lblCEmail.TabIndex = 0;
            this.lblCEmail.Text = "Email : ";
            // 
            // pnlDesign
            // 
            this.pnlDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pnlDesign.Controls.Add(this.lblX);
            this.pnlDesign.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDesign.Location = new System.Drawing.Point(800, 0);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(105, 725);
            this.pnlDesign.TabIndex = 3;
            // 
            // lblX
            // 
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(209)))), ((int)(((byte)(250)))));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 725);
            this.panel1.TabIndex = 4;
            // 
            // btnCBack
            // 
            this.btnCBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(209)))), ((int)(((byte)(250)))));
            this.btnCBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCBack.FlatAppearance.BorderSize = 0;
            this.btnCBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCBack.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCBack.Location = new System.Drawing.Point(12, 15);
            this.btnCBack.Name = "btnCBack";
            this.btnCBack.Size = new System.Drawing.Size(74, 31);
            this.btnCBack.TabIndex = 6;
            this.btnCBack.Text = "&Back";
            this.btnCBack.UseVisualStyleBackColor = false;
            this.btnCBack.Click += new System.EventHandler(this.btnCBack_Click);
            // 
            // Customer_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(209)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDesign);
            this.Controls.Add(this.gbCLogin);
            this.Controls.Add(this.pblogin);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer_LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_LoginForm";

            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            this.gbCLogin.ResumeLayout(false);
            this.gbCLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClogin)).EndInit();
            this.pnlDesign.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogin;
        private System.Windows.Forms.GroupBox gbCLogin;
        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.Button btnCReset;
        private System.Windows.Forms.Button btnCLogin;
        private System.Windows.Forms.DataGridView dgvClogin;
        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnCBack;
        private System.Windows.Forms.LinkLabel linkCsignup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}