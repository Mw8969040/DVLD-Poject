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
    public partial class FrmLicenseHistory : Form
    {
        int _PersonID;

        public FrmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
           

            CardOfPerson();
            CardOfLicense();
        }

        private void CardOfLicense()
        {
            cardDrivingLicense1.LoadData(_PersonID);
        }
        private void CardOfPerson()
        {
            cardOfPersonWithFilter1.FilterEnabled = false;
            cardOfPersonWithFilter1.ShowButtonAdd = false;
            cardOfPersonWithFilter1.ShowButtonSearch = false;
            cardOfPersonWithFilter1.LoadPersonInfo(_PersonID);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLicenseHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
