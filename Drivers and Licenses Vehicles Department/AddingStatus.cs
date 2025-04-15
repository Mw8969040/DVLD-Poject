using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class AddingStatus : Form
    {
        public AddingStatus()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddingStatus_Load(object sender, EventArgs e)
        {
            lblStatus.Text = this.Tag.ToString();
            lblStatus.Location = new Point((this.ClientSize.Width - lblStatus.Width) / 2, 15);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
