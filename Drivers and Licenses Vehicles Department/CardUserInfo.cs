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
    public partial class CardUserInfo : UserControl
    {
        public CardUserInfo()
        {
            InitializeComponent();
        }

        private int _UserID;

        private ClsUsers _User;

        private void _LoadLginInfo(ClsUsers User)
        {
            LblUserID.Text = _User.UserID.ToString();
            LblUserName.Text = _User.UserName.ToString();
            CheckActive.Text = _User.IsActive == 1 ? "Yes" : "No";
        }

        private void _LoadPersonInfo(int PersonID)
        {
            cardOfPerson1.LoadPersonInfo(PersonID);
        }

        public void LoadUserInfo(int UserID)
        {
            _User = ClsUsers.Find(UserID);
            if (_User == null)
            {
                MessageBox.Show("Person Is Not Exist", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadPersonInfo(_User.PersonID);
            _LoadLginInfo(_User);
        }
    }
}
