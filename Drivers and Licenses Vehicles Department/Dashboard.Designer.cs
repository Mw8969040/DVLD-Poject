namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.Logo_DVLD = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.buttons_Bar1 = new Drivers_and_Licenses_Vehicles_Department.Buttons_Bar();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_DVLD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dashboard";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoRoundedCorners = true;
            this.Close.BackColor = System.Drawing.SystemColors.Control;
            this.Close.BorderRadius = 10;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.FillColor = System.Drawing.SystemColors.Control;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::Drivers_and_Licenses_Vehicles_Department.Properties.Resources.CloseBlack;
            this.Close.Location = new System.Drawing.Point(1021, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 10;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Logo_DVLD
            // 
            this.Logo_DVLD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo_DVLD.BackColor = System.Drawing.SystemColors.Control;
            this.Logo_DVLD.FillColor = System.Drawing.SystemColors.ControlLight;
            this.Logo_DVLD.Image = ((System.Drawing.Image)(resources.GetObject("Logo_DVLD.Image")));
            this.Logo_DVLD.ImageRotate = 0F;
            this.Logo_DVLD.Location = new System.Drawing.Point(282, 104);
            this.Logo_DVLD.Name = "Logo_DVLD";
            this.Logo_DVLD.Size = new System.Drawing.Size(713, 659);
            this.Logo_DVLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_DVLD.TabIndex = 7;
            this.Logo_DVLD.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // buttons_Bar1
            // 
            this.buttons_Bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.buttons_Bar1.Location = new System.Drawing.Point(0, 0);
            this.buttons_Bar1.Name = "buttons_Bar1";
            this.buttons_Bar1.Size = new System.Drawing.Size(233, 788);
            this.buttons_Bar1.TabIndex = 11;
            this.buttons_Bar1.OnCalculationComplete += new Drivers_and_Licenses_Vehicles_Department.Buttons_Bar.CalculationCompletedHandler(this.buttons_Bar1_OnCalculationComplete);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1045, 788);
            this.Controls.Add(this.buttons_Bar1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo_DVLD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_DVLD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox Logo_DVLD;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Close;
        private Buttons_Bar buttons_Bar1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

