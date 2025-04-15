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
    public partial class ShowPersonDetails : Form
    {
        public ShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            cardOfPerson1.LoadPersonInfo(PersonID);
        }

        public ShowPersonDetails(string NationalNo)
        {
            InitializeComponent();
            cardOfPerson1.LoadPersonInfo(NationalNo);
        }


        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void cardOfPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
