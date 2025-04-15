namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class FrmScduleTest
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLDL = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cardScduleTest1 = new Drivers_and_Licenses_Vehicles_Department.CardScduleTest();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.LblLDL);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 47);
            this.panel2.TabIndex = 25;
            // 
            // LblLDL
            // 
            this.LblLDL.AutoSize = true;
            this.LblLDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLDL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblLDL.Location = new System.Drawing.Point(165, 9);
            this.LblLDL.Name = "LblLDL";
            this.LblLDL.Size = new System.Drawing.Size(243, 31);
            this.LblLDL.TabIndex = 12;
            this.LblLDL.Text = "Test Appointment";
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
            this.Close.Location = new System.Drawing.Point(531, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 11;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 15);
            this.panel1.TabIndex = 26;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel2;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // cardScduleTest1
            // 
            this.cardScduleTest1.Location = new System.Drawing.Point(17, 51);
            this.cardScduleTest1.Name = "cardScduleTest1";
            this.cardScduleTest1.Size = new System.Drawing.Size(525, 606);
            this.cardScduleTest1.TabIndex = 0;
            this.cardScduleTest1.Load += new System.EventHandler(this.cardScduleTest1_Load);
            // 
            // FrmScduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cardScduleTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmScduleTest";
            this.Load += new System.EventHandler(this.FrmScduleTest_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CardScduleTest cardScduleTest1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblLDL;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}