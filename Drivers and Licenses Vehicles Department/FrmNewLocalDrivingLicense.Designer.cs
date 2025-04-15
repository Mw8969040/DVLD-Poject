namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class FrmNewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewLocalDrivingLicense));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLDL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplicationInfo = new System.Windows.Forms.TabPage();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblAppFees = new System.Windows.Forms.Label();
            this.LblAppDate = new System.Windows.Forms.Label();
            this.CBLicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.cardOfPersonWithFilter1 = new Drivers_and_Licenses_Vehicles_Department.CardOfPersonWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.ApplicationInfo.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("ButtonClose.Image")));
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new System.Drawing.Point(674, 525);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(80, 38);
            this.ButtonClose.TabIndex = 27;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.Close_Click);
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
            this.Close.Location = new System.Drawing.Point(739, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 11;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNext.Location = new System.Drawing.Point(634, 392);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(80, 38);
            this.ButtonNext.TabIndex = 20;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevButton.Image = ((System.Drawing.Image)(resources.GetObject("PrevButton.Image")));
            this.PrevButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrevButton.Location = new System.Drawing.Point(8, 391);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(80, 38);
            this.PrevButton.TabIndex = 81;
            this.PrevButton.Text = "Prev";
            this.PrevButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(148, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 29);
            this.label9.TabIndex = 78;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(67, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Created By";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblID.Location = new System.Drawing.Point(265, 98);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(22, 16);
            this.LblID.TabIndex = 76;
            this.LblID.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(149, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(27, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Application Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(149, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(48, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "License Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(150, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(151, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(100, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "App ID";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(194, 263);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(194, 220);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(11, 525);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 38);
            this.ButtonSave.TabIndex = 26;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Visible = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(31, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Application Date";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Drivers_and_Licenses_Vehicles_Department.Properties.Resources.Number_321;
            this.pictureBox3.Location = new System.Drawing.Point(194, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel2;
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
            this.panel2.Size = new System.Drawing.Size(766, 47);
            this.panel2.TabIndex = 24;
            // 
            // LblLDL
            // 
            this.LblLDL.AutoSize = true;
            this.LblLDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLDL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblLDL.Location = new System.Drawing.Point(130, 9);
            this.LblLDL.Name = "LblLDL";
            this.LblLDL.Size = new System.Drawing.Size(511, 31);
            this.LblLDL.TabIndex = 12;
            this.LblLDL.Text = "New Local Driving License Application";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 15);
            this.panel1.TabIndex = 25;
            // 
            // ApplicationInfo
            // 
            this.ApplicationInfo.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationInfo.Controls.Add(this.LblUser);
            this.ApplicationInfo.Controls.Add(this.LblAppFees);
            this.ApplicationInfo.Controls.Add(this.LblAppDate);
            this.ApplicationInfo.Controls.Add(this.CBLicenseClass);
            this.ApplicationInfo.Controls.Add(this.PrevButton);
            this.ApplicationInfo.Controls.Add(this.label9);
            this.ApplicationInfo.Controls.Add(this.label10);
            this.ApplicationInfo.Controls.Add(this.LblID);
            this.ApplicationInfo.Controls.Add(this.label5);
            this.ApplicationInfo.Controls.Add(this.label8);
            this.ApplicationInfo.Controls.Add(this.label2);
            this.ApplicationInfo.Controls.Add(this.label3);
            this.ApplicationInfo.Controls.Add(this.label7);
            this.ApplicationInfo.Controls.Add(this.label6);
            this.ApplicationInfo.Controls.Add(this.label1);
            this.ApplicationInfo.Controls.Add(this.label4);
            this.ApplicationInfo.Controls.Add(this.pictureBox5);
            this.ApplicationInfo.Controls.Add(this.pictureBox4);
            this.ApplicationInfo.Controls.Add(this.pictureBox1);
            this.ApplicationInfo.Controls.Add(this.pictureBox2);
            this.ApplicationInfo.Controls.Add(this.pictureBox3);
            this.ApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.ApplicationInfo.Name = "ApplicationInfo";
            this.ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfo.Size = new System.Drawing.Size(734, 434);
            this.ApplicationInfo.TabIndex = 1;
            this.ApplicationInfo.Text = "Application Info";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.Black;
            this.LblUser.Location = new System.Drawing.Point(263, 272);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(40, 16);
            this.LblUser.TabIndex = 85;
            this.LblUser.Text = "User";
            // 
            // LblAppFees
            // 
            this.LblAppFees.AutoSize = true;
            this.LblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppFees.ForeColor = System.Drawing.Color.Black;
            this.LblAppFees.Location = new System.Drawing.Point(265, 227);
            this.LblAppFees.Name = "LblAppFees";
            this.LblAppFees.Size = new System.Drawing.Size(42, 16);
            this.LblAppFees.TabIndex = 84;
            this.LblAppFees.Text = "Fees";
            // 
            // LblAppDate
            // 
            this.LblAppDate.AutoSize = true;
            this.LblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppDate.ForeColor = System.Drawing.Color.Black;
            this.LblAppDate.Location = new System.Drawing.Point(265, 141);
            this.LblAppDate.Name = "LblAppDate";
            this.LblAppDate.Size = new System.Drawing.Size(40, 16);
            this.LblAppDate.TabIndex = 83;
            this.LblAppDate.Text = "Date";
            // 
            // CBLicenseClass
            // 
            this.CBLicenseClass.AutoRoundedCorners = true;
            this.CBLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.CBLicenseClass.BorderRadius = 17;
            this.CBLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLicenseClass.FillColor = System.Drawing.Color.Gainsboro;
            this.CBLicenseClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBLicenseClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBLicenseClass.ItemHeight = 30;
            this.CBLicenseClass.Location = new System.Drawing.Point(263, 173);
            this.CBLicenseClass.Name = "CBLicenseClass";
            this.CBLicenseClass.Size = new System.Drawing.Size(321, 36);
            this.CBLicenseClass.TabIndex = 82;
            // 
            // PersonInfo
            // 
            this.PersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.PersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonInfo.Controls.Add(this.ButtonNext);
            this.PersonInfo.Controls.Add(this.cardOfPersonWithFilter1);
            this.PersonInfo.Location = new System.Drawing.Point(4, 22);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfo.Size = new System.Drawing.Size(734, 434);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Person Info";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PersonInfo);
            this.TabControl.Controls.Add(this.ApplicationInfo);
            this.TabControl.Location = new System.Drawing.Point(12, 59);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(742, 460);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 23;
            // 
            // cardOfPersonWithFilter1
            // 
            this.cardOfPersonWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardOfPersonWithFilter1.FilterEnabled = true;
            this.cardOfPersonWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.cardOfPersonWithFilter1.Name = "cardOfPersonWithFilter1";
            this.cardOfPersonWithFilter1.ShowButtonAdd = true;
            this.cardOfPersonWithFilter1.ShowButtonSearch = true;
            this.cardOfPersonWithFilter1.Size = new System.Drawing.Size(726, 426);
            this.cardOfPersonWithFilter1.TabIndex = 0;
            // 
            // FrmNewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 580);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewLocalDrivingLicense";
            this.Load += new System.EventHandler(this.FrmNewLocalDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ApplicationInfo.ResumeLayout(false);
            this.ApplicationInfo.PerformLayout();
            this.PersonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblLDL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage ApplicationInfo;
        private CardOfPersonWithFilter cardOfPersonWithFilter1;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblAppFees;
        private System.Windows.Forms.Label LblAppDate;
        private Guna.UI2.WinForms.Guna2ComboBox CBLicenseClass;
    }
}