namespace HomeAppliance_RentalSystem
{
    partial class Customer_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Search));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.lblEC = new System.Windows.Forms.Label();
            this.cboEC = new System.Windows.Forms.ComboBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboFee = new System.Windows.Forms.ComboBox();
            this.rdoDESC = new System.Windows.Forms.RadioButton();
            this.rdoASC = new System.Windows.Forms.RadioButton();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.gpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(339, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 44);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "~ Search ~";
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
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblX
            // 
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblX.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(863, 14);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(30, 31);
            this.lblX.TabIndex = 74;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(26, 91);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(851, 298);
            this.dgvSearch.TabIndex = 76;
            // 
            // gpSearch
            // 
            this.gpSearch.BackColor = System.Drawing.Color.Transparent;
            this.gpSearch.Controls.Add(this.btnReset);
            this.gpSearch.Controls.Add(this.lblEC);
            this.gpSearch.Controls.Add(this.cboEC);
            this.gpSearch.Controls.Add(this.btnRent);
            this.gpSearch.Controls.Add(this.lblTo);
            this.gpSearch.Controls.Add(this.lblCategory);
            this.gpSearch.Controls.Add(this.btnShow);
            this.gpSearch.Controls.Add(this.btnSearch);
            this.gpSearch.Controls.Add(this.cboFee);
            this.gpSearch.Controls.Add(this.rdoDESC);
            this.gpSearch.Controls.Add(this.rdoASC);
            this.gpSearch.Controls.Add(this.cboCategory);
            this.gpSearch.Location = new System.Drawing.Point(38, 410);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(839, 286);
            this.gpSearch.TabIndex = 77;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Search Here ";
            // 
            // lblEC
            // 
            this.lblEC.AutoSize = true;
            this.lblEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblEC.Location = new System.Drawing.Point(361, 48);
            this.lblEC.Name = "lblEC";
            this.lblEC.Size = new System.Drawing.Size(198, 24);
            this.lblEC.TabIndex = 86;
            this.lblEC.Text = "Energy Consumption :";
            // 
            // cboEC
            // 
            this.cboEC.FormattingEnabled = true;
            this.cboEC.Location = new System.Drawing.Point(586, 48);
            this.cboEC.Name = "cboEC";
            this.cboEC.Size = new System.Drawing.Size(228, 32);
            this.cboEC.TabIndex = 85;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(209)))), ((int)(((byte)(250)))));
            this.btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRent.Location = new System.Drawing.Point(375, 237);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(116, 43);
            this.btnRent.TabIndex = 84;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblTo.Location = new System.Drawing.Point(450, 97);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(109, 24);
            this.lblTo.TabIndex = 82;
            this.lblTo.Text = "Rental Fee :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblCategory.Location = new System.Drawing.Point(27, 102);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 24);
            this.lblCategory.TabIndex = 81;
            this.lblCategory.Text = "Category :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(489, 163);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 43);
            this.btnShow.TabIndex = 80;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(273, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 43);
            this.btnSearch.TabIndex = 79;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboFee
            // 
            this.cboFee.FormattingEnabled = true;
            this.cboFee.Location = new System.Drawing.Point(585, 94);
            this.cboFee.Name = "cboFee";
            this.cboFee.Size = new System.Drawing.Size(229, 32);
            this.cboFee.TabIndex = 3;
            // 
            // rdoDESC
            // 
            this.rdoDESC.AutoSize = true;
            this.rdoDESC.Location = new System.Drawing.Point(220, 46);
            this.rdoDESC.Name = "rdoDESC";
            this.rdoDESC.Size = new System.Drawing.Size(75, 28);
            this.rdoDESC.TabIndex = 2;
            this.rdoDESC.TabStop = true;
            this.rdoDESC.Text = "DESC";
            this.rdoDESC.UseVisualStyleBackColor = true;
            // 
            // rdoASC
            // 
            this.rdoASC.AutoSize = true;
            this.rdoASC.Location = new System.Drawing.Point(31, 46);
            this.rdoASC.Name = "rdoASC";
            this.rdoASC.Size = new System.Drawing.Size(65, 28);
            this.rdoASC.TabIndex = 1;
            this.rdoASC.TabStop = true;
            this.rdoASC.Text = "ASC";
            this.rdoASC.UseVisualStyleBackColor = true;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(163, 94);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(238, 32);
            this.cboCategory.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(179, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 43);
            this.btnReset.TabIndex = 87;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Customer_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.gpSearch);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Search";
            this.Load += new System.EventHandler(this.Customer_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.ComboBox cboFee;
        private System.Windows.Forms.RadioButton rdoDESC;
        private System.Windows.Forms.RadioButton rdoASC;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblEC;
        private System.Windows.Forms.ComboBox cboEC;
        private System.Windows.Forms.Button btnReset;
    }
}