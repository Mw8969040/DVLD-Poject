namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class CardInternationalLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardInternationalLicenseInfoWithFilter));
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterLicense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardLocalLicenseInfo1 = new Drivers_and_Licenses_Vehicles_Department.CardLocalLicenseInfo();
            this.GBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.ButtonSearch);
            this.GBFilter.Controls.Add(this.txtFilterLicense);
            this.GBFilter.Controls.Add(this.label3);
            this.GBFilter.Controls.Add(this.label2);
            this.GBFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFilter.Location = new System.Drawing.Point(169, 8);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(423, 61);
            this.GBFilter.TabIndex = 2;
            this.GBFilter.TabStop = false;
            this.GBFilter.Text = "Filter";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Animated = true;
            this.ButtonSearch.AnimatedGIF = true;
            this.ButtonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSearch.FillColor = System.Drawing.SystemColors.Control;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.Image")));
            this.ButtonSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonSearch.Location = new System.Drawing.Point(352, 15);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(40, 40);
            this.ButtonSearch.TabIndex = 89;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // txtFilterLicense
            // 
            this.txtFilterLicense.BackColor = System.Drawing.Color.White;
            this.txtFilterLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterLicense.Location = new System.Drawing.Point(175, 24);
            this.txtFilterLicense.Multiline = true;
            this.txtFilterLicense.Name = "txtFilterLicense";
            this.txtFilterLicense.Size = new System.Drawing.Size(121, 21);
            this.txtFilterLicense.TabIndex = 88;
            this.txtFilterLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterLicense_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(107, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 87;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "License ID";
            // 
            // cardLocalLicenseInfo1
            // 
            this.cardLocalLicenseInfo1.Location = new System.Drawing.Point(3, 78);
            this.cardLocalLicenseInfo1.Name = "cardLocalLicenseInfo1";
            this.cardLocalLicenseInfo1.Size = new System.Drawing.Size(815, 360);
            this.cardLocalLicenseInfo1.TabIndex = 3;
            this.cardLocalLicenseInfo1.Load += new System.EventHandler(this.cardLocalLicenseInfo1_Load);
            // 
            // CardInternationalLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardLocalLicenseInfo1);
            this.Controls.Add(this.GBFilter);
            this.Name = "CardInternationalLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(820, 438);
            this.Load += new System.EventHandler(this.CardLocalLicenseInfoWithFilter_Load);
            this.GBFilter.ResumeLayout(false);
            this.GBFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBFilter;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private System.Windows.Forms.TextBox txtFilterLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CardLocalLicenseInfo cardLocalLicenseInfo1;
    }
}
