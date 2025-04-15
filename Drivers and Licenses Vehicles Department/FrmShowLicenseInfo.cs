using BusinessDLVDLayer;
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
    public partial class FrmShowLicenseInfo : Form
    {
        public FrmShowLicenseInfo(ClsLicense License)
        {
            InitializeComponent();
            cardLicenseInfo1.LoadData(License);
        }

        private void FrmShowLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
