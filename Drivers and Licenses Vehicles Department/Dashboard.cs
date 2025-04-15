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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttons_Bar1_OnCalculationComplete()
        {
            this.Close();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            Logo_DVLD.Location = new Point((this.Width - Logo_DVLD.Width) / 2 + 120, Math.Max(100, 100));
        }
    }
}
