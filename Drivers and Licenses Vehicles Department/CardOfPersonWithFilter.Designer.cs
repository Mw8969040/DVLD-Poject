namespace Drivers_and_Licenses_Vehicles_Department
{
    partial class CardOfPersonWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardOfPersonWithFilter));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cardOfPerson1 = new Drivers_and_Licenses_Vehicles_Department.CardOfPerson();
            this.GBFilter = new System.Windows.Forms.GroupBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBFilter = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.GBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cardOfPerson1
            // 
            this.cardOfPerson1.Location = new System.Drawing.Point(15, 85);
            this.cardOfPerson1.Name = "cardOfPerson1";
            this.cardOfPerson1.Size = new System.Drawing.Size(707, 311);
            this.cardOfPerson1.TabIndex = 0;
            this.cardOfPerson1.Load += new System.EventHandler(this.cardOfPerson1_Load);
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.ButtonAdd);
            this.GBFilter.Controls.Add(this.ButtonSearch);
            this.GBFilter.Controls.Add(this.txtFilterValue);
            this.GBFilter.Controls.Add(this.label3);
            this.GBFilter.Controls.Add(this.label2);
            this.GBFilter.Controls.Add(this.CBFilter);
            this.GBFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFilter.Location = new System.Drawing.Point(21, 18);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(690, 61);
            this.GBFilter.TabIndex = 1;
            this.GBFilter.TabStop = false;
            this.GBFilter.Text = "Filter";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.White;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(284, 25);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(121, 21);
            this.txtFilterValue.TabIndex = 88;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(89, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 87;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Filter By";
            // 
            // CBFilter
            // 
            this.CBFilter.BackColor = System.Drawing.SystemColors.Window;
            this.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFilter.FormattingEnabled = true;
            this.CBFilter.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.CBFilter.Location = new System.Drawing.Point(115, 26);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(121, 23);
            this.CBFilter.TabIndex = 85;
            this.CBFilter.SelectedIndexChanged += new System.EventHandler(this.CBFilter_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Animated = true;
            this.ButtonAdd.AnimatedGIF = true;
            this.ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAdd.FillColor = System.Drawing.SystemColors.Control;
            this.ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonAdd.Location = new System.Drawing.Point(526, 15);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(40, 40);
            this.ButtonAdd.TabIndex = 90;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
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
            this.ButtonSearch.Location = new System.Drawing.Point(439, 15);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(40, 40);
            this.ButtonSearch.TabIndex = 89;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // CardOfPersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBFilter);
            this.Controls.Add(this.cardOfPerson1);
            this.Name = "CardOfPersonWithFilter";
            this.Size = new System.Drawing.Size(737, 406);
            this.Load += new System.EventHandler(this.CardOfPersonWithFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.GBFilter.ResumeLayout(false);
            this.GBFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CardOfPerson cardOfPerson1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox GBFilter;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBFilter;
    }
}
