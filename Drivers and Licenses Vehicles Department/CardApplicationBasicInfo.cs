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
using static System.Net.Mime.MediaTypeNames;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class CardApplicationBasicInfo : UserControl
    {
        public CardApplicationBasicInfo()
        {
            InitializeComponent();
           
        }

        private ClsApplication _Application;

        private int _ApplicationID;

        public ClsApplication Application
        {
            get { return _Application; }
        }

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }
        
        private void _FillApplicationInfo( )
        {
            _ApplicationID=_Application.ApplicationID;
            lblApplicationID.Text = _ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText;
            lblFees.Text = _Application.ApplicationFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.Title;
            lblApplicant.Text = _Application.FullName;
            lblDate.Text=_Application.ApplicationDate.ToString("dd/MM/yyyy");
            lblStatusDate.Text = _Application.LastStatusDate.ToString("dd/MM/yyyy");
            lblCreatedByUser.Text = _Application.UserInfo.UserName;

        }

        public  void LoadData(int ApplicationID)
        {
           _Application= ClsApplication.FindBase(ApplicationID);

            if(_Application == null)
            {
                MessageBox.Show("Application Not Found , Try Again .","Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillApplicationInfo();
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form fm = new ShowPersonDetails(_Application.ApplicationPersonID);
            fm.ShowDialog();

            LoadData(_ApplicationID);
        }
    }
}
