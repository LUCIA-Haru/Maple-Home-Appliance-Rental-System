namespace HomeAppliance_RentalSystem
{
    partial class Reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HomeAppliance_DataSet = new HomeAppliance_RentalSystem.HomeAppliance_DataSet();
            this.RentalDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rgvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReport = new System.Windows.Forms.Button();
            this.RentalDetailTableAdapter = new HomeAppliance_RentalSystem.HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.RentalTableAdapter = new HomeAppliance_RentalSystem.HomeAppliance_DataSetTableAdapters.RentalTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeAppliance_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalBindingSource
            // 
            this.RentalBindingSource.DataMember = "Rental";
            this.RentalBindingSource.DataSource = this.HomeAppliance_DataSet;
            // 
            // HomeAppliance_DataSet
            // 
            this.HomeAppliance_DataSet.DataSetName = "HomeAppliance_DataSet";
            this.HomeAppliance_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RentalDetailBindingSource
            // 
            this.RentalDetailBindingSource.DataMember = "RentalDetail";
            this.RentalDetailBindingSource.DataSource = this.HomeAppliance_DataSet;
            // 
            // rgvReport
            // 
            this.rgvReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            reportDataSource3.Name = "Rental";
            reportDataSource3.Value = this.RentalBindingSource;
            this.rgvReport.LocalReport.DataSources.Add(reportDataSource3);
            this.rgvReport.LocalReport.ReportEmbeddedResource = "HomeAppliance_RentalSystem.Report.rdlc";
            this.rgvReport.Location = new System.Drawing.Point(0, 70);
            this.rgvReport.Name = "rgvReport";
            this.rgvReport.Size = new System.Drawing.Size(905, 655);
            this.rgvReport.TabIndex = 0;
            this.rgvReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(665, 70);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(82, 27);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // RentalDetailTableAdapter
            // 
            this.RentalDetailTableAdapter.ClearBeforeFill = true;
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
            this.btnBack.TabIndex = 70;
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
            this.lblX.TabIndex = 69;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // RentalTableAdapter
            // 
            this.RentalTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(355, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 44);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "~ Report~";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(905, 725);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.rgvReport);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeAppliance_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rgvReport;
        private System.Windows.Forms.BindingSource RentalDetailBindingSource;
        private HomeAppliance_DataSet HomeAppliance_DataSet;
        private System.Windows.Forms.Button btnReport;
        private HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter RentalDetailTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.BindingSource RentalBindingSource;
        private HomeAppliance_DataSetTableAdapters.RentalTableAdapter RentalTableAdapter;
        private System.Windows.Forms.Label lblTitle;
    }
}