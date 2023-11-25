namespace HomeAppliance_RentalSystem
{
    partial class Brand_Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brand_Entry));
            this.lblX = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblBrID = new System.Windows.Forms.Label();
            this.lblBrName = new System.Windows.Forms.Label();
            this.gbBrand = new System.Windows.Forms.GroupBox();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.btnBDelete = new System.Windows.Forms.Button();
            this.btnBReset = new System.Windows.Forms.Button();
            this.btnBUpdate = new System.Windows.Forms.Button();
            this.btnBSave = new System.Windows.Forms.Button();
            this.txtBrName = new System.Windows.Forms.TextBox();
            this.txtBrID = new System.Windows.Forms.TextBox();
            this.lblBTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Location = new System.Drawing.Point(960, 13);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(38, 45);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExit
            // 
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblExit.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(863, 14);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(30, 31);
            this.lblExit.TabIndex = 53;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblBrID
            // 
            this.lblBrID.AutoSize = true;
            this.lblBrID.Location = new System.Drawing.Point(169, 32);
            this.lblBrID.Name = "lblBrID";
            this.lblBrID.Size = new System.Drawing.Size(75, 23);
            this.lblBrID.TabIndex = 54;
            this.lblBrID.Text = "BrandID";
            // 
            // lblBrName
            // 
            this.lblBrName.AutoSize = true;
            this.lblBrName.Location = new System.Drawing.Point(450, 32);
            this.lblBrName.Name = "lblBrName";
            this.lblBrName.Size = new System.Drawing.Size(111, 23);
            this.lblBrName.TabIndex = 55;
            this.lblBrName.Text = "Brand Name";
            // 
            // gbBrand
            // 
            this.gbBrand.Controls.Add(this.dgvBrand);
            this.gbBrand.Controls.Add(this.btnBDelete);
            this.gbBrand.Controls.Add(this.btnBReset);
            this.gbBrand.Controls.Add(this.btnBUpdate);
            this.gbBrand.Controls.Add(this.btnBSave);
            this.gbBrand.Controls.Add(this.txtBrName);
            this.gbBrand.Controls.Add(this.txtBrID);
            this.gbBrand.Controls.Add(this.lblBrID);
            this.gbBrand.Controls.Add(this.lblBrName);
            this.gbBrand.Location = new System.Drawing.Point(70, 136);
            this.gbBrand.Name = "gbBrand";
            this.gbBrand.Size = new System.Drawing.Size(763, 481);
            this.gbBrand.TabIndex = 56;
            this.gbBrand.TabStop = false;
            this.gbBrand.Text = "Brand_Entry";
            // 
            // dgvBrand
            // 
            this.dgvBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBrand.Location = new System.Drawing.Point(216, 133);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.RowTemplate.Height = 24;
            this.dgvBrand.Size = new System.Drawing.Size(267, 247);
            this.dgvBrand.TabIndex = 62;
            this.dgvBrand.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBrand_CellMouseClick);
            // 
            // btnBDelete
            // 
            this.btnBDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnBDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBDelete.FlatAppearance.BorderSize = 0;
            this.btnBDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBDelete.Location = new System.Drawing.Point(545, 407);
            this.btnBDelete.Name = "btnBDelete";
            this.btnBDelete.Size = new System.Drawing.Size(85, 28);
            this.btnBDelete.TabIndex = 61;
            this.btnBDelete.Text = "&Delete";
            this.btnBDelete.UseVisualStyleBackColor = false;
            this.btnBDelete.Click += new System.EventHandler(this.btnBDelete_Click);
            // 
            // btnBReset
            // 
            this.btnBReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(180)))));
            this.btnBReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBReset.FlatAppearance.BorderSize = 0;
            this.btnBReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBReset.Location = new System.Drawing.Point(398, 407);
            this.btnBReset.Name = "btnBReset";
            this.btnBReset.Size = new System.Drawing.Size(85, 28);
            this.btnBReset.TabIndex = 58;
            this.btnBReset.Text = "&Reset";
            this.btnBReset.UseVisualStyleBackColor = false;
            this.btnBReset.Click += new System.EventHandler(this.btnBReset_Click);
            // 
            // btnBUpdate
            // 
            this.btnBUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(235)))), ((int)(((byte)(178)))));
            this.btnBUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBUpdate.FlatAppearance.BorderSize = 0;
            this.btnBUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBUpdate.Location = new System.Drawing.Point(252, 407);
            this.btnBUpdate.Name = "btnBUpdate";
            this.btnBUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnBUpdate.TabIndex = 59;
            this.btnBUpdate.Text = "&Update";
            this.btnBUpdate.UseVisualStyleBackColor = false;
            this.btnBUpdate.Click += new System.EventHandler(this.btnBUpdate_Click);
            // 
            // btnBSave
            // 
            this.btnBSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.btnBSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBSave.FlatAppearance.BorderSize = 0;
            this.btnBSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBSave.Location = new System.Drawing.Point(95, 407);
            this.btnBSave.Name = "btnBSave";
            this.btnBSave.Size = new System.Drawing.Size(84, 28);
            this.btnBSave.TabIndex = 60;
            this.btnBSave.Text = "&Save";
            this.btnBSave.UseVisualStyleBackColor = false;
            this.btnBSave.Click += new System.EventHandler(this.btnBSave_Click);
            // 
            // txtBrName
            // 
            this.txtBrName.Location = new System.Drawing.Point(408, 75);
            this.txtBrName.Name = "txtBrName";
            this.txtBrName.Size = new System.Drawing.Size(193, 29);
            this.txtBrName.TabIndex = 57;
            // 
            // txtBrID
            // 
            this.txtBrID.Enabled = false;
            this.txtBrID.Location = new System.Drawing.Point(114, 75);
            this.txtBrID.Name = "txtBrID";
            this.txtBrID.Size = new System.Drawing.Size(193, 29);
            this.txtBrID.TabIndex = 56;

            // 
            // lblBTitle
            // 
            this.lblBTitle.AutoSize = true;
            this.lblBTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTitle.Location = new System.Drawing.Point(351, 75);
            this.lblBTitle.Name = "lblBTitle";
            this.lblBTitle.Size = new System.Drawing.Size(189, 44);
            this.lblBTitle.TabIndex = 57;
            this.lblBTitle.Text = "~ Brand ~";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 31);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Brand_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBTitle);
            this.Controls.Add(this.gbBrand);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblX);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Brand_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.Brand_Entry_Load);
            this.gbBrand.ResumeLayout(false);
            this.gbBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblBrID;
        private System.Windows.Forms.Label lblBrName;
        private System.Windows.Forms.GroupBox gbBrand;
        private System.Windows.Forms.TextBox txtBrName;
        private System.Windows.Forms.TextBox txtBrID;
        private System.Windows.Forms.Label lblBTitle;
        private System.Windows.Forms.Button btnBDelete;
        private System.Windows.Forms.Button btnBReset;
        private System.Windows.Forms.Button btnBUpdate;
        private System.Windows.Forms.Button btnBSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvBrand;
    }
}