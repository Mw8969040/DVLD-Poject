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
    public partial class ShowUserDetails : Form
    {
        public ShowUserDetails(int UserID)
        {
            InitializeComponent();
            cardUserInfo1.LoadUserInfo(UserID);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
