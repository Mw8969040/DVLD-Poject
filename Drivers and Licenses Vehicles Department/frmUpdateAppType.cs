using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class frmUpdateAppType : Form
    {
        int _AppID;
        ClsApplicationTypes _ApplicationTypes;
        Form AddingStatus = new AddingStatus();
        public frmUpdateAppType(int AppID)
        {
            InitializeComponent();
            _AppID = AppID;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(ClsApplicationTypes.UpdateApplicationType(int.Parse(LblID.Text),txtTitle.Text,int.Parse(txtFees.Text)))
            {
                AddingStatus.Tag = "Application Updated Successfully !";
                AddingStatus.ShowDialog();
            }


        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _FindAndLoadDataApp()
        {
           _ApplicationTypes= ClsApplicationTypes.Find(_AppID);

            if(_ApplicationTypes == null )
            {
                MessageBox.Show("Application Not Found .","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            LblID.Text=_ApplicationTypes.AppID.ToString();
            txtTitle.Text= _ApplicationTypes.Title;
            txtFees.Text = _ApplicationTypes.Fees.ToString();
        }

        private void frmUpdateAppType_Load(object sender, EventArgs e)
        {
            _FindAndLoadDataApp();
        }
    }
}
