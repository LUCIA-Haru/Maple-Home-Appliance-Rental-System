namespace HomeAppliance_RentalSystem
{
    partial class Maple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maple));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMaple = new System.Windows.Forms.Label();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.timerMaple = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMaple
            // 
            this.lblMaple.BackColor = System.Drawing.Color.Transparent;
            this.lblMaple.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblMaple.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaple.Location = new System.Drawing.Point(177, 33);
            this.lblMaple.Name = "lblMaple";
            this.lblMaple.Size = new System.Drawing.Size(584, 88);
            this.lblMaple.TabIndex = 58;
            this.lblMaple.Text = "Maple Home Appliances \r\nRental Company.,LTD";
            this.lblMaple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlBar.Controls.Add(this.pnlProgress);
            this.pnlBar.Location = new System.Drawing.Point(273, 527);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(379, 13);
            this.pnlBar.TabIndex = 59;
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlProgress.Location = new System.Drawing.Point(0, 0);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(101, 13);
            this.pnlProgress.TabIndex = 60;
            // 
            // timerMaple
            // 
            this.timerMaple.Enabled = true;
            this.timerMaple.Interval = 10;
            this.timerMaple.Tick += new System.EventHandler(this.timerMaple_Tick);
            // 
            // Maple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(905, 571);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.lblMaple);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maple";
            this.Load += new System.EventHandler(this.Maple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMaple;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Timer timerMaple;
    }
}