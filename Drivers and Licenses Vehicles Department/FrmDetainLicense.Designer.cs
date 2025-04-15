namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class FrmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetainLicense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.PicturePeople = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUser = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDetainedLicense = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DataViewDetainedLicense = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnReleaseDetainedLicense = new Guna.UI2.WinForms.Guna2Button();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PesonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeople)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDetainedLicense)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.SystemColors.Window;
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.CBStatus.Location = new System.Drawing.Point(255, 298);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(121, 21);
            this.CBStatus.TabIndex = 106;
            this.CBStatus.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.Location = new System.Drawing.Point(255, 298);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(121, 21);
            this.txtFilter.TabIndex = 105;
            this.txtFilter.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(75, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 104;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 103;
            this.label2.Text = "Filter By";
            // 
            // CBFilter
            // 
            this.CBFilter.BackColor = System.Drawing.SystemColors.Window;
            this.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Items.AddRange(new object[] {
            "None",
            "LDLAppID",
            "Full Name",
            "National No",
            "Status"});
            this.CBFilter.Location = new System.Drawing.Point(100, 298);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(121, 21);
            this.CBFilter.TabIndex = 102;
            // 
            // PicturePeople
            // 
            this.PicturePeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePeople.Image = ((System.Drawing.Image)(resources.GetObject("PicturePeople.Image")));
            this.PicturePeople.Location = new System.Drawing.Point(366, 69);
            this.PicturePeople.Name = "PicturePeople";
            this.PicturePeople.Size = new System.Drawing.Size(350, 240);
            this.PicturePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePeople.TabIndex = 99;
            this.PicturePeople.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.LblUser);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 47);
            this.panel2.TabIndex = 97;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblUser.Location = new System.Drawing.Point(389, 8);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(295, 31);
            this.LblUser.TabIndex = 12;
            this.LblUser.Text = "List Detained License";
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
            this.Close.Location = new System.Drawing.Point(1026, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 11;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblRecords);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 35);
            this.panel1.TabIndex = 98;
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.White;
            this.lblRecords.Location = new System.Drawing.Point(98, 11);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(14, 16);
            this.lblRecords.TabIndex = 92;
            this.lblRecords.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 91;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "# Records";
            // 
            // BtnDetainedLicense
            // 
            this.BtnDetainedLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetainedLicense.AutoRoundedCorners = true;
            this.BtnDetainedLicense.BorderRadius = 19;
            this.BtnDetainedLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDetainedLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDetainedLicense.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.BtnDetainedLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDetainedLicense.FillColor = System.Drawing.SystemColors.Control;
            this.BtnDetainedLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDetainedLicense.ForeColor = System.Drawing.Color.White;
            this.BtnDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("BtnDetainedLicense.Image")));
            this.BtnDetainedLicense.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnDetainedLicense.Location = new System.Drawing.Point(1000, 287);
            this.BtnDetainedLicense.Name = "BtnDetainedLicense";
            this.BtnDetainedLicense.Size = new System.Drawing.Size(40, 40);
            this.BtnDetainedLicense.TabIndex = 101;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // DataViewDetainedLicense
            // 
            this.DataViewDetainedLicense.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DataViewDetainedLicense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataViewDetainedLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewDetainedLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataViewDetainedLicense.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewDetainedLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataViewDetainedLicense.ColumnHeadersHeight = 25;
            this.DataViewDetainedLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewDetainedLicense.DefaultCellStyle = dataGridViewCellStyle15;
            this.DataViewDetainedLicense.GridColor = System.Drawing.Color.DarkGray;
            this.DataViewDetainedLicense.Location = new System.Drawing.Point(12, 333);
            this.DataViewDetainedLicense.Name = "DataViewDetainedLicense";
            this.DataViewDetainedLicense.ReadOnly = true;
            this.DataViewDetainedLicense.RowHeadersVisible = false;
            this.DataViewDetainedLicense.Size = new System.Drawing.Size(1028, 274);
            this.DataViewDetainedLicense.TabIndex = 100;
            this.DataViewDetainedLicense.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewDetainedLicense.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataViewDetainedLicense.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataViewDetainedLicense.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataViewDetainedLicense.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataViewDetainedLicense.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataViewDetainedLicense.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.DataViewDetainedLicense.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataViewDetainedLicense.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataViewDetainedLicense.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewDetainedLicense.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewDetainedLicense.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataViewDetainedLicense.ThemeStyle.HeaderStyle.Height = 25;
            this.DataViewDetainedLicense.ThemeStyle.ReadOnly = true;
            this.DataViewDetainedLicense.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewDetainedLicense.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewDetainedLicense.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewDetainedLicense.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataViewDetainedLicense.ThemeStyle.RowsStyle.Height = 22;
            this.DataViewDetainedLicense.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewDetainedLicense.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BtnReleaseDetainedLicense
            // 
            this.BtnReleaseDetainedLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReleaseDetainedLicense.AutoRoundedCorners = true;
            this.BtnReleaseDetainedLicense.BorderRadius = 19;
            this.BtnReleaseDetainedLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReleaseDetainedLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReleaseDetainedLicense.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.BtnReleaseDetainedLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReleaseDetainedLicense.FillColor = System.Drawing.SystemColors.Control;
            this.BtnReleaseDetainedLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnReleaseDetainedLicense.ForeColor = System.Drawing.Color.White;
            this.BtnReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("BtnReleaseDetainedLicense.Image")));
            this.BtnReleaseDetainedLicense.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnReleaseDetainedLicense.Location = new System.Drawing.Point(942, 287);
            this.BtnReleaseDetainedLicense.Name = "BtnReleaseDetainedLicense";
            this.BtnReleaseDetainedLicense.Size = new System.Drawing.Size(40, 40);
            this.BtnReleaseDetainedLicense.TabIndex = 107;
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PesonDetailsToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(281, 184);
            // 
            // PesonDetailsToolStripMenuItem
            // 
            this.PesonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PesonDetailsToolStripMenuItem.Image")));
            this.PesonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
            this.PesonDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.PesonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.PesonDetailsToolStripMenuItem.Click += new System.EventHandler(this.PesonDetailsToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show License Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(277, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image")));
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // FrmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 647);
            this.Controls.Add(this.BtnReleaseDetainedLicense);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBFilter);
            this.Controls.Add(this.PicturePeople);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDetainedLicense);
            this.Controls.Add(this.DataViewDetainedLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetainLicense";
            this.Load += new System.EventHandler(this.FrmDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeople)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDetainedLicense)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBFilter;
        private System.Windows.Forms.PictureBox PicturePeople;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUser;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button BtnDetainedLicense;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView DataViewDetainedLicense;
        private Guna.UI2.WinForms.Guna2Button BtnReleaseDetainedLicense;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem PesonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}