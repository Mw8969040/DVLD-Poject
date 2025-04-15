namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class ShowPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPersonDetails));
            this.LblPerson = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.ButClose = new System.Windows.Forms.Button();
            this.cardOfPerson1 = new Drivers_and_Licenses_Vehicles_Department.CardOfPerson();
            this.SuspendLayout();
            // 
            // LblPerson
            // 
            this.LblPerson.AutoSize = true;
            this.LblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPerson.Location = new System.Drawing.Point(262, 38);
            this.LblPerson.Name = "LblPerson";
            this.LblPerson.Size = new System.Drawing.Size(205, 31);
            this.LblPerson.TabIndex = 13;
            this.LblPerson.Text = "Person Details";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.ButClose;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoRoundedCorners = true;
            this.Close.BackColor = System.Drawing.Color.Gainsboro;
            this.Close.BorderRadius = 10;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.FillColor = System.Drawing.Color.Gainsboro;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::Drivers_and_Licenses_Vehicles_Department.Properties.Resources.Close_64;
            this.Close.Location = new System.Drawing.Point(709, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 15;
            this.Close.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // ButClose
            // 
            this.ButClose.BackColor = System.Drawing.SystemColors.Control;
            this.ButClose.FlatAppearance.BorderSize = 0;
            this.ButClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButClose.Image = ((System.Drawing.Image)(resources.GetObject("ButClose.Image")));
            this.ButClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButClose.Location = new System.Drawing.Point(625, 394);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(88, 42);
            this.ButClose.TabIndex = 14;
            this.ButClose.Text = "       Close";
            this.ButClose.UseVisualStyleBackColor = false;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // cardOfPerson1
            // 
            this.cardOfPerson1.Location = new System.Drawing.Point(16, 77);
            this.cardOfPerson1.Name = "cardOfPerson1";
            this.cardOfPerson1.Size = new System.Drawing.Size(707, 311);
            this.cardOfPerson1.TabIndex = 16;
            this.cardOfPerson1.Load += new System.EventHandler(this.cardOfPerson1_Load);
            // 
            // ShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(735, 443);
            this.Controls.Add(this.cardOfPerson1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.LblPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPersonDetails";
            this.Load += new System.EventHandler(this.ShowPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPerson;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Button ButClose;
        private Guna.UI2.WinForms.Guna2Button Close;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private CardOfPerson cardOfPerson1;
    }
}