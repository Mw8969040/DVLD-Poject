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
    public partial class FrmScduleTest : Form
    {
       private int _LocalDrivingLicenseID;
       private int _TestAppointMentID = -1;
       private  ClsTestTypes.enTestType _Type;
        public FrmScduleTest(int LocalDrivingLicenseID , int TestAppointMentID , ClsTestTypes.enTestType Type)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            _Type = Type;
            _TestAppointMentID= TestAppointMentID;

        }

        private void FrmScduleTest_Load(object sender, EventArgs e)
        {
            cardScduleTest1.TestType = _Type;
            cardScduleTest1.LoadData(_LocalDrivingLicenseID, _TestAppointMentID);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cardScduleTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
