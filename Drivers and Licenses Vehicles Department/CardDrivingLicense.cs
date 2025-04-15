using BusinessDLVDLayer;
using DVLD_Buisness;
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
    public partial class CardDrivingLicense : UserControl
    {
        int _DriverID = -1;
        public CardDrivingLicense()
        {
            InitializeComponent();
        }

        private void _FillDGVLocal()
        {
           LocalDataViewLicense.DataSource=ClsLicense.ListLicneseByDriverID(_DriverID);
           CountLocal.Text = LocalDataViewLicense.Rows.Count.ToString();

            if (LocalDataViewLicense.Rows.Count > 0)
            {
                LocalDataViewLicense.Columns[0].HeaderText = "License ID";
                LocalDataViewLicense.Columns[0].Width = 95;

                LocalDataViewLicense.Columns[1].HeaderText = "App ID";
                LocalDataViewLicense.Columns[1].Width = 75;

                LocalDataViewLicense.Columns[2].HeaderText = "Class Name";
                LocalDataViewLicense.Columns[2].Width = 190;

                LocalDataViewLicense.Columns[3].HeaderText = "Issue Date";
                LocalDataViewLicense.Columns[3].Width = 130;

                LocalDataViewLicense.Columns[4].HeaderText = "Expiration Date";
                LocalDataViewLicense.Columns[4].Width = 140;

                LocalDataViewLicense.Columns[5].HeaderText = "Is Active";
                LocalDataViewLicense.Columns[5].Width = 65;

            }
        }

        private void _FillDGVInternational()
        {
            InternationalDGvLicense.DataSource=ClsInternationalLicense.GetDriverInternationalLicenses(_DriverID);
            CountInternational.Text= InternationalDGvLicense.Rows.Count.ToString();

            if (InternationalDGvLicense.Rows.Count > 0)
            {
                InternationalDGvLicense.Columns[0].HeaderText = "Int.License ID";
                InternationalDGvLicense.Columns[0].Width = 120;

                InternationalDGvLicense.Columns[1].HeaderText = "Application ID";
                InternationalDGvLicense.Columns[1].Width = 120;

                InternationalDGvLicense.Columns[2].HeaderText = "L.License ID";
                InternationalDGvLicense.Columns[2].Width = 120;

                InternationalDGvLicense.Columns[3].HeaderText = "Issue Date";
                InternationalDGvLicense.Columns[3].Width = 125;

                InternationalDGvLicense.Columns[4].HeaderText = "Expiration Date";
                InternationalDGvLicense.Columns[4].Width = 140;

                InternationalDGvLicense.Columns[5].HeaderText = "Is Active";
                InternationalDGvLicense.Columns[5].Width = 70;

            }
        }

        public  void LoadData(int PersonID)
        {
           

            ClsDrivers Driver =ClsDrivers.FindByPersonID(PersonID);
            if (Driver == null)
            {
                MessageBox.Show("Driver not found , try again ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _DriverID = Driver.DriverID;
            CardDrivingLicense_Load(null, null);
        }
        private void CardDrivingLicense_Load(object sender, EventArgs e)
        {
            _FillDGVLocal();
            _FillDGVInternational();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
