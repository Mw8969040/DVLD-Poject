namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class CardDrivingLicense
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDrivingLicense));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLocal = new System.Windows.Forms.TabPage();
            this.CountLocal = new System.Windows.Forms.Label();
            this.RecordLocal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalDataViewLicense = new System.Windows.Forms.DataGridView();
            this.tabInternational = new System.Windows.Forms.TabPage();
            this.CountInternational = new System.Windows.Forms.Label();
            this.RecordsInterNational = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InternationalDGvLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLincenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalDataViewLicense)).BeginInit();
            this.tabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalDGvLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLocal);
            this.tabControl1.Controls.Add(this.tabInternational);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLocal
            // 
            this.TabLocal.Controls.Add(this.CountLocal);
            this.TabLocal.Controls.Add(this.RecordLocal);
            this.TabLocal.Controls.Add(this.label3);
            this.TabLocal.Controls.Add(this.LocalDataViewLicense);
            this.TabLocal.Location = new System.Drawing.Point(4, 25);
            this.TabLocal.Name = "TabLocal";
            this.TabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.TabLocal.Size = new System.Drawing.Size(751, 198);
            this.TabLocal.TabIndex = 0;
            this.TabLocal.Text = "Local";
            this.TabLocal.UseVisualStyleBackColor = true;
            // 
            // CountLocal
            // 
            this.CountLocal.AutoSize = true;
            this.CountLocal.Location = new System.Drawing.Point(82, 179);
            this.CountLocal.Name = "CountLocal";
            this.CountLocal.Size = new System.Drawing.Size(21, 16);
            this.CountLocal.TabIndex = 138;
            this.CountLocal.Text = "??";
            // 
            // RecordLocal
            // 
            this.RecordLocal.AutoSize = true;
            this.RecordLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLocal.Location = new System.Drawing.Point(6, 178);
            this.RecordLocal.Name = "RecordLocal";
            this.RecordLocal.Size = new System.Drawing.Size(76, 15);
            this.RecordLocal.TabIndex = 137;
            this.RecordLocal.Text = "# Records:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 136;
            this.label3.Text = "Local Licenses History:";
            // 
            // LocalDataViewLicense
            // 
            this.LocalDataViewLicense.AllowUserToAddRows = false;
            this.LocalDataViewLicense.BackgroundColor = System.Drawing.Color.White;
            this.LocalDataViewLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalDataViewLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.LocalDataViewLicense.Location = new System.Drawing.Point(7, 26);
            this.LocalDataViewLicense.Name = "LocalDataViewLicense";
            this.LocalDataViewLicense.Size = new System.Drawing.Size(739, 150);
            this.LocalDataViewLicense.TabIndex = 0;
            // 
            // tabInternational
            // 
            this.tabInternational.Controls.Add(this.CountInternational);
            this.tabInternational.Controls.Add(this.RecordsInterNational);
            this.tabInternational.Controls.Add(this.label6);
            this.tabInternational.Controls.Add(this.InternationalDGvLicense);
            this.tabInternational.Location = new System.Drawing.Point(4, 25);
            this.tabInternational.Name = "tabInternational";
            this.tabInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternational.Size = new System.Drawing.Size(751, 198);
            this.tabInternational.TabIndex = 1;
            this.tabInternational.Text = "International";
            this.tabInternational.UseVisualStyleBackColor = true;
            // 
            // CountInternational
            // 
            this.CountInternational.AutoSize = true;
            this.CountInternational.Location = new System.Drawing.Point(82, 179);
            this.CountInternational.Name = "CountInternational";
            this.CountInternational.Size = new System.Drawing.Size(21, 16);
            this.CountInternational.TabIndex = 142;
            this.CountInternational.Text = "??";
            // 
            // RecordsInterNational
            // 
            this.RecordsInterNational.AutoSize = true;
            this.RecordsInterNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsInterNational.Location = new System.Drawing.Point(6, 178);
            this.RecordsInterNational.Name = "RecordsInterNational";
            this.RecordsInterNational.Size = new System.Drawing.Size(76, 15);
            this.RecordsInterNational.TabIndex = 141;
            this.RecordsInterNational.Text = "# Records:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 16);
            this.label6.TabIndex = 140;
            this.label6.Text = "International Licenses History:";
            // 
            // InternationalDGvLicense
            // 
            this.InternationalDGvLicense.AllowUserToAddRows = false;
            this.InternationalDGvLicense.BackgroundColor = System.Drawing.Color.White;
            this.InternationalDGvLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternationalDGvLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.InternationalDGvLicense.Location = new System.Drawing.Point(7, 26);
            this.InternationalDGvLicense.Name = "InternationalDGvLicense";
            this.InternationalDGvLicense.Size = new System.Drawing.Size(739, 150);
            this.InternationalDGvLicense.TabIndex = 139;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLincenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 42);
            // 
            // showLincenseInfoToolStripMenuItem
            // 
            this.showLincenseInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLincenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLincenseInfoToolStripMenuItem.Image")));
            this.showLincenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLincenseInfoToolStripMenuItem.Name = "showLincenseInfoToolStripMenuItem";
            this.showLincenseInfoToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.showLincenseInfoToolStripMenuItem.Text = "Show Lincense Info";
            // 
            // CardDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CardDrivingLicense";
            this.Size = new System.Drawing.Size(777, 260);
            this.Load += new System.EventHandler(this.CardDrivingLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabLocal.ResumeLayout(false);
            this.TabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalDataViewLicense)).EndInit();
            this.tabInternational.ResumeLayout(false);
            this.tabInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalDGvLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabLocal;
        private System.Windows.Forms.TabPage tabInternational;
        private System.Windows.Forms.DataGridView LocalDataViewLicense;
        private System.Windows.Forms.Label CountLocal;
        private System.Windows.Forms.Label RecordLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CountInternational;
        private System.Windows.Forms.Label RecordsInterNational;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView InternationalDGvLicense;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLincenseInfoToolStripMenuItem;
    }
}
