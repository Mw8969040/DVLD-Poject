namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class FrmLocalLicenseApplicationInfo
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
            this.cardDrivingLicenseApplication1 = new Drivers_and_Licenses_Vehicles_Department.CardDrivingLicenseApplication();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUser = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardDrivingLicenseApplication1
            // 
            this.cardDrivingLicenseApplication1.Location = new System.Drawing.Point(15, 52);
            this.cardDrivingLicenseApplication1.Name = "cardDrivingLicenseApplication1";
            this.cardDrivingLicenseApplication1.Size = new System.Drawing.Size(863, 470);
            this.cardDrivingLicenseApplication1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 15);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.LblUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 45);
            this.panel2.TabIndex = 26;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblUser.Location = new System.Drawing.Point(198, 8);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(503, 31);
            this.LblUser.TabIndex = 13;
            this.LblUser.Text = "Local Driving License Application Info";
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
            this.Close.Location = new System.Drawing.Point(869, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 14;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.cardDrivingLicenseApplication1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // FrmLocalLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cardDrivingLicenseApplication1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLocalLicenseApplicationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLocalLicenseApplicationInfo";
            this.Load += new System.EventHandler(this.FrmLocalLicenseApplicationInfo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CardDrivingLicenseApplication cardDrivingLicenseApplication1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUser;
        private Guna.UI2.WinForms.Guna2Button Close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}