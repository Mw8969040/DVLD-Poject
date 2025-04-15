namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class FrmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTakeTest));
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLDL = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ctrlSecheduledTest1 = new Drivers_and_Licenses_Vehicles_Department.ctrlSecheduledTest();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(249, 556);
            this.lblUserMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(255, 20);
            this.lblUserMessage.TabIndex = 209;
            this.lblUserMessage.Text = "You cannot change the results";
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserMessage.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(379, 498);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 36);
            this.btnSave.TabIndex = 207;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(118, 581);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(408, 71);
            this.txtNotes.TabIndex = 206;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Location = new System.Drawing.Point(188, 556);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(41, 17);
            this.rbFail.TabIndex = 205;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Checked = true;
            this.rbPass.Location = new System.Drawing.Point(120, 556);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(48, 17);
            this.rbPass.TabIndex = 204;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 593);
            this.label10.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 202;
            this.label10.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 557);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 200;
            this.label8.Text = "Result:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(72, 593);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 203;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(72, 557);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 201;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 15);
            this.panel1.TabIndex = 211;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.LblLDL);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 47);
            this.panel2.TabIndex = 212;
            // 
            // LblLDL
            // 
            this.LblLDL.AutoSize = true;
            this.LblLDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLDL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblLDL.Location = new System.Drawing.Point(192, 9);
            this.LblLDL.Name = "LblLDL";
            this.LblLDL.Size = new System.Drawing.Size(145, 31);
            this.LblLDL.TabIndex = 12;
            this.LblLDL.Text = "Take Test";
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
            this.Close.Location = new System.Drawing.Point(503, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 11;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel2;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // ctrlSecheduledTest1
            // 
            this.ctrlSecheduledTest1.Location = new System.Drawing.Point(2, 47);
            this.ctrlSecheduledTest1.Name = "ctrlSecheduledTest1";
            this.ctrlSecheduledTest1.Size = new System.Drawing.Size(525, 502);
            this.ctrlSecheduledTest1.TabIndex = 213;
            // 
            // FrmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 671);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlSecheduledTest1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTakeTest";
            this.Load += new System.EventHandler(this.FrmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblLDL;
        private Guna.UI2.WinForms.Guna2Button Close;
        private ctrlSecheduledTest ctrlSecheduledTest1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}