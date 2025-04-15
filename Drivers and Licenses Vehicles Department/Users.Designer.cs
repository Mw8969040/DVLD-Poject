namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.DataViewUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBIsActive = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.PicturePeople = new System.Windows.Forms.PictureBox();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.buttons_Bar1 = new Drivers_and_Licenses_Vehicles_Department.Buttons_Bar();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeople)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.Location = new System.Drawing.Point(557, 427);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(121, 21);
            this.txtFilter.TabIndex = 86;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(377, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 85;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 84;
            this.label2.Text = "Filter By";
            // 
            // CBFilter
            // 
            this.CBFilter.BackColor = System.Drawing.SystemColors.Window;
            this.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "FullName",
            "UserName",
            "Password",
            "IsActive"});
            this.CBFilter.Location = new System.Drawing.Point(402, 427);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(121, 21);
            this.CBFilter.TabIndex = 83;
            this.CBFilter.SelectedIndexChanged += new System.EventHandler(this.CBFilter_SelectedIndexChanged);
            // 
            // DataViewUsers
            // 
            this.DataViewUsers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataViewUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataViewUsers.ColumnHeadersHeight = 25;
            this.DataViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataViewUsers.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataViewUsers.GridColor = System.Drawing.Color.DarkGray;
            this.DataViewUsers.Location = new System.Drawing.Point(314, 481);
            this.DataViewUsers.Name = "DataViewUsers";
            this.DataViewUsers.ReadOnly = true;
            this.DataViewUsers.RowHeadersVisible = false;
            this.DataViewUsers.Size = new System.Drawing.Size(650, 274);
            this.DataViewUsers.TabIndex = 80;
            this.DataViewUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataViewUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataViewUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataViewUsers.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.DataViewUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataViewUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataViewUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataViewUsers.ThemeStyle.HeaderStyle.Height = 25;
            this.DataViewUsers.ThemeStyle.ReadOnly = true;
            this.DataViewUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataViewUsers.ThemeStyle.RowsStyle.Height = 22;
            this.DataViewUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPersonToolStripMenuItem,
            this.updatePersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem,
            this.toolStripSeparator2,
            this.changePasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 268);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.addNewPersonToolStripMenuItem.Text = "Add New User";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // updatePersonToolStripMenuItem
            // 
            this.updatePersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updatePersonToolStripMenuItem.Image")));
            this.updatePersonToolStripMenuItem.Name = "updatePersonToolStripMenuItem";
            this.updatePersonToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.updatePersonToolStripMenuItem.Text = "Update User";
            this.updatePersonToolStripMenuItem.Click += new System.EventHandler(this.updatePersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePersonToolStripMenuItem.Image")));
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.deletePersonToolStripMenuItem.Text = "Delete User";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 78;
            this.label1.Text = "Users";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(338, 766);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(14, 16);
            this.lblRecords.TabIndex = 89;
            this.lblRecords.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(327, 760);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 765);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "# Records";
            // 
            // CBIsActive
            // 
            this.CBIsActive.BackColor = System.Drawing.SystemColors.Window;
            this.CBIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIsActive.FormattingEnabled = true;
            this.CBIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.CBIsActive.Location = new System.Drawing.Point(557, 427);
            this.CBIsActive.Name = "CBIsActive";
            this.CBIsActive.Size = new System.Drawing.Size(121, 21);
            this.CBIsActive.TabIndex = 90;
            this.CBIsActive.SelectedIndexChanged += new System.EventHandler(this.CBIsActive_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.AutoRoundedCorners = true;
            this.ButtonAdd.BorderRadius = 19;
            this.ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdd.FillColor = System.Drawing.SystemColors.Control;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageSize = new System.Drawing.Size(35, 35);
            this.ButtonAdd.Location = new System.Drawing.Point(931, 410);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(40, 40);
            this.ButtonAdd.TabIndex = 82;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // PicturePeople
            // 
            this.PicturePeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePeople.Image = global::Drivers_and_Licenses_Vehicles_Department.Properties.Resources.people_3239147;
            this.PicturePeople.Location = new System.Drawing.Point(422, 65);
            this.PicturePeople.Name = "PicturePeople";
            this.PicturePeople.Size = new System.Drawing.Size(441, 333);
            this.PicturePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePeople.TabIndex = 81;
            this.PicturePeople.TabStop = false;
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
            this.Close.FillColor = System.Drawing.SystemColors.Control;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::Drivers_and_Licenses_Vehicles_Department.Properties.Resources.CloseBlack;
            this.Close.Location = new System.Drawing.Point(1020, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 79;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // buttons_Bar1
            // 
            this.buttons_Bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.buttons_Bar1.Location = new System.Drawing.Point(0, 0);
            this.buttons_Bar1.Name = "buttons_Bar1";
            this.buttons_Bar1.Size = new System.Drawing.Size(233, 788);
            this.buttons_Bar1.TabIndex = 0;
            this.buttons_Bar1.OnCalculationComplete += new Drivers_and_Licenses_Vehicles_Department.Buttons_Bar.CalculationCompletedHandler(this.buttons_Bar1_OnCalculationComplete);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 788);
            this.Controls.Add(this.CBIsActive);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBFilter);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.PicturePeople);
            this.Controls.Add(this.DataViewUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.buttons_Bar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buttons_Bar buttons_Bar1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBFilter;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private System.Windows.Forms.PictureBox PicturePeople;
        private Guna.UI2.WinForms.Guna2DataGridView DataViewUsers;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBIsActive;
    }
}