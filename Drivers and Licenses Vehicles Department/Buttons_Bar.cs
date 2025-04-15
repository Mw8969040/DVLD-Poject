using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class Buttons_Bar : UserControl
    {
        public Buttons_Bar()
        {
            InitializeComponent();
        }

        public delegate void CalculationCompletedHandler();

        public event CalculationCompletedHandler OnCalculationComplete;

        protected virtual void CalculationComplete()
        {
            if (OnCalculationComplete != null)
            {
                OnCalculationComplete.Invoke();
            }
        }


        private void ButApplications_Click(object sender, EventArgs e)
        {


            if (ButApplications.Tag.ToString() == "Show")
            {
                PanelApplications.Visible = true;
                ButApplications.Tag = "Hide";
                ButPeople.Top = 499;
                ButDrivers.Top = 562;
                ButUsers.Top = 625;
                ButAccountSetting.Top = 683;
            }
            else if (ButApplications.Tag.ToString() == "Hide")
            {
                PanelApplications.Visible = false;
                ButApplications.Tag = "Show";
                ButPeople.Top = 241;
                ButDrivers.Top = 304;
                ButUsers.Top = 367;
                ButAccountSetting.Top = 430;
            }
            

        }

        private void Buttons_Bar_Load(object sender, EventArgs e)
        {
            ButPeople.Top = 241;
            ButDrivers.Top = 304;
            ButUsers.Top = 367;
            ButAccountSetting.Top = 430;

        }

        private void ButPeople_Click(object sender, EventArgs e)
        {
            Form fm = new People();
            fm.Show();
            CalculationComplete();

        }

        private void ButUsers_Click(object sender, EventArgs e)
        {
            Form fm = new Users();
            fm.Show();
            CalculationComplete();
        }

        private void mainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Dashboard();
            fm.Show();
            CalculationComplete();
        }

        private void ButAccountSetting_Click(object sender, EventArgs e)
        {
            Point menuPosition = new Point(ButAccountSetting.Left + 50, 50);
            contextMenuStrip1.Show(ButAccountSetting, menuPosition);     
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fm = new ShowUserDetails(GLobal.CurrentUser.UserID);
            fm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Change_Password(GLobal.CurrentUser.UserID);
            fm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GLobal.CurrentUser = null;
            if (MessageBox.Show("Are you sure LogOut .", "LogOut", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Form fm = new LogIn();

                for (int i = Application.OpenForms.Count - 1; i >= 1; i--)
                {
                    Form form = Application.OpenForms[i];
                    if (form != fm) 
                    {
                        form.Close();
                    }
                }

                fm.Show();
            }
        }

        private void ButManageAppTypes_Click(object sender, EventArgs e)
        {
            Form fm = new FrmApplicationTypes();
            fm.ShowDialog();
        }

        private void ButManageType_Click(object sender, EventArgs e)
        {
            Form fm=new FrmTestTypes();
            fm.ShowDialog();
        }

        private void ButServices_Click(object sender, EventArgs e)
        {
                Point MenuPosition = new Point(ButServices.Right, 15);
                contextMenuStrip2.Show(ButServices, MenuPosition);  
        }

        private void ButManageApplication_Click(object sender, EventArgs e)
        {
            Point MenuPosition = new Point(ButServices.Right, 15);
            contextMenuStrip3.Show(ButManageApplication, MenuPosition);
        }

        private void LocalLicenseTool_Click(object sender, EventArgs e)
        {
            Form fm = new LocalLicense();
            fm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm=new FrmNewLocalDrivingLicense();
            fm.ShowDialog();
        }

        private void ButDrivers_Click(object sender, EventArgs e)
        {
            Form fm = new Drivers();
            fm.ShowDialog();
            CalculationComplete();
        }

        private void InternationalLicenseStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form fm = new InterNationalLicense();
            fm.ShowDialog();
        }
    }
}
