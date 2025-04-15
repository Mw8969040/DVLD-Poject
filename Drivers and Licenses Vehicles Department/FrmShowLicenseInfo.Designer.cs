namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class FrmShowLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowLicenseInfo));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLDL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardLicenseInfo1 = new Drivers_and_Licenses_Vehicles_Department.CardLocalLicenseInfo();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.LblLDL);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 47);
            this.panel2.TabIndex = 213;
            // 
            // LblLDL
            // 
            this.LblLDL.AutoSize = true;
            this.LblLDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLDL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblLDL.Location = new System.Drawing.Point(279, 9);
            this.LblLDL.Name = "LblLDL";
            this.LblLDL.Size = new System.Drawing.Size(260, 31);
            this.LblLDL.TabIndex = 12;
            this.LblLDL.Text = "Driver License Info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 15);
            this.panel1.TabIndex = 214;
            // 
            // cardLicenseInfo1
            // 
            this.cardLicenseInfo1.Location = new System.Drawing.Point(24, 181);
            this.cardLicenseInfo1.Name = "cardLicenseInfo1";
            this.cardLicenseInfo1.Size = new System.Drawing.Size(814, 354);
            this.cardLicenseInfo1.TabIndex = 216;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonImage.Image")));
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(335, 48);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(154, 132);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 215;
            this.pbPersonImage.TabStop = false;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoRoundedCorners = true;
            this.Close.BorderRadius = 10;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::Drivers_and_Licenses_Vehicles_Department.Properties.Resources.Close_64;
            this.Close.Location = new System.Drawing.Point(835, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 11;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 217;
            this.pictureBox1.TabStop = false;
            // 
            // FrmShowLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cardLicenseInfo1);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShowLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLicenseInfo";
            this.Load += new System.EventHandler(this.FrmShowLicenseInfo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblLDL;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private CardLocalLicenseInfo cardLicenseInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}