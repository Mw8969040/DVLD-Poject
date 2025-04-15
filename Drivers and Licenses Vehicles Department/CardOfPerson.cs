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
    public partial class CardOfPerson : UserControl
    {
        private int _PersonID =-1;
        private ClsPeople _Person;

        public CardOfPerson()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get { return _PersonID; }
        }

        public ClsPeople Person
        {
            get { return _Person; }
        }

        private void ResetPersonInfo()
        {
            LblID.Text = "ID";
            LblName.Text = "Name";
            LblNational_No.Text = "National No";
            LblGendor.Text = "Gender";
            LblEmail.Text = "Email";
            LblAddress.Text = "Address";
            LblDate.Text = "Date of Birth";
            LblPhone.Text = "Phone";
            LblCountry.Text = "Country";
            pictureOfPerson.Image = Properties.Resources.Male_512; 
        }

        private void _FillPersonData()
        {
            _PersonID = _Person.PersonID;
            LblID.Text=_Person.PersonID.ToString();
            LblName .Text= _Person.FirstName + "  " + _Person.SecondName + "  " + _Person.ThirdName + "  " + _Person.LastName;
            LblNational_No.Text= _Person.NationalNo.ToString();
            LblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            PictureGendor.Image = _Person.Gendor == 0 ? Properties.Resources.Man_32 : Properties.Resources.Woman_32;
            LblEmail.Text = _Person.Email;
            LblAddress.Text= _Person.Address;
            LblDate.Text=_Person.DateOfBirth.ToString("dd/MM/yyyy");
            LblPhone.Text= _Person.Phone;
            LblCountry.Text = ClsCountry.FindCountry(_Person.CountryID).CountryName.ToString();
            if(_Person.ImagePath=="")
            {
                pictureOfPerson.Image = _Person.Gendor == 0 ? Properties.Resources.Male_512 : Properties.Resources.Female_512;
            }
            else
            {
               pictureOfPerson.Load(_Person.ImagePath);
            }
            LnkUpdate.Enabled = true;
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person=ClsPeople.Find(PersonID);

            if(_Person==null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person With ID = "+PersonID.ToString() , "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonData();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = ClsPeople.Find(NationalNo);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person With National_No = " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonData();
        }

        private void CardOfPerson_Load(object sender, EventArgs e)
        {

        }

        private void LnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form fm = new AddPerson(_PersonID);
            fm.ShowDialog();

            //Refresh
            LoadPersonInfo(_PersonID);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
