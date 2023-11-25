namespace HomeAppliance_RentalSystem
{
    partial class Category_Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Entry));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblCTitle = new System.Windows.Forms.Label();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnCaDelete = new System.Windows.Forms.Button();
            this.btnCaSave = new System.Windows.Forms.Button();
            this.btnCaUpdate = new System.Windows.Forms.Button();
            this.btnCaReset = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblX
            // 
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblX.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(863, 14);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(30, 31);
            this.lblX.TabIndex = 63;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblCTitle
            // 
            this.lblCTitle.AutoSize = true;
            this.lblCTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTitle.Location = new System.Drawing.Point(333, 67);
            this.lblCTitle.Name = "lblCTitle";
            this.lblCTitle.Size = new System.Drawing.Size(241, 44);
            this.lblCTitle.TabIndex = 65;
            this.lblCTitle.Text = "~ Category ~";
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.dgvCategory);
            this.gbCategory.Controls.Add(this.btnCaDelete);
            this.gbCategory.Controls.Add(this.btnCaSave);
            this.gbCategory.Controls.Add(this.btnCaUpdate);
            this.gbCategory.Controls.Add(this.btnCaReset);
            this.gbCategory.Controls.Add(this.txtCatName);
            this.gbCategory.Controls.Add(this.txtCatID);
            this.gbCategory.Controls.Add(this.lblCatName);
            this.gbCategory.Controls.Add(this.lblCatID);
            this.gbCategory.Location = new System.Drawing.Point(98, 125);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(701, 495);
            this.gbCategory.TabIndex = 66;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Catgory_Entry";
            // 
            // dgvCategory
            // 
            this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(181, 135);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(327, 249);
            this.dgvCategory.TabIndex = 8;
            this.dgvCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategory_CellMouseClick);
            // 
            // btnCaDelete
            // 
            this.btnCaDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnCaDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaDelete.FlatAppearance.BorderSize = 0;
            this.btnCaDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaDelete.Location = new System.Drawing.Point(503, 422);
            this.btnCaDelete.Name = "btnCaDelete";
            this.btnCaDelete.Size = new System.Drawing.Size(84, 28);
            this.btnCaDelete.TabIndex = 7;
            this.btnCaDelete.Text = "&Delete";
            this.btnCaDelete.UseVisualStyleBackColor = false;
            this.btnCaDelete.Click += new System.EventHandler(this.btnCaDelete_Click);
            // 
            // btnCaSave
            // 
            this.btnCaSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.btnCaSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaSave.FlatAppearance.BorderSize = 0;
            this.btnCaSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaSave.Location = new System.Drawing.Point(86, 422);
            this.btnCaSave.Name = "btnCaSave";
            this.btnCaSave.Size = new System.Drawing.Size(84, 28);
            this.btnCaSave.TabIndex = 6;
            this.btnCaSave.Text = "&Save";
            this.btnCaSave.UseVisualStyleBackColor = false;
            this.btnCaSave.Click += new System.EventHandler(this.btnCaSave_Click);
            // 
            // btnCaUpdate
            // 
            this.btnCaUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(235)))), ((int)(((byte)(178)))));
            this.btnCaUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaUpdate.FlatAppearance.BorderSize = 0;
            this.btnCaUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaUpdate.Location = new System.Drawing.Point(226, 422);
            this.btnCaUpdate.Name = "btnCaUpdate";
            this.btnCaUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnCaUpdate.TabIndex = 5;
            this.btnCaUpdate.Text = "&Update";
            this.btnCaUpdate.UseVisualStyleBackColor = false;
            this.btnCaUpdate.Click += new System.EventHandler(this.btnCaUpdate_Click);
            // 
            // btnCaReset
            // 
            this.btnCaReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(180)))));
            this.btnCaReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaReset.FlatAppearance.BorderSize = 0;
            this.btnCaReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaReset.Location = new System.Drawing.Point(367, 422);
            this.btnCaReset.Name = "btnCaReset";
            this.btnCaReset.Size = new System.Drawing.Size(84, 28);
            this.btnCaReset.TabIndex = 4;
            this.btnCaReset.Text = "&Reset";
            this.btnCaReset.UseVisualStyleBackColor = false;
            this.btnCaReset.Click += new System.EventHandler(this.btnCaReset_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(394, 80);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(193, 29);
            this.txtCatName.TabIndex = 3;
            // 
            // txtCatID
            // 
            this.txtCatID.Enabled = false;
            this.txtCatID.Location = new System.Drawing.Point(100, 80);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(193, 29);
            this.txtCatID.TabIndex = 2;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(436, 37);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(137, 23);
            this.lblCatName.TabIndex = 1;
            this.lblCatName.Text = "Category Name";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(155, 37);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(101, 23);
            this.lblCatID.TabIndex = 0;
            this.lblCatID.Text = "CategoryID";
            // 
            // Category_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.lblCTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblX);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Category_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category_Entry";
            this.Load += new System.EventHandler(this.Category_Entry_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblCTitle;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.Button btnCaDelete;
        private System.Windows.Forms.Button btnCaSave;
        private System.Windows.Forms.Button btnCaUpdate;
        private System.Windows.Forms.Button btnCaReset;
        private System.Windows.Forms.DataGridView dgvCategory;
    }
}