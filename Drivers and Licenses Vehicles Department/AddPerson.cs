using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class AddPerson : Form
    {
        enum EnMode {AddPerson=0 ,UpdatePerson=1 , InfoPerson=2 };
        enum EnGendor { Male=0 , Female=1 };

        EnMode enMode = EnMode.AddPerson;

        int _PersonID;
        ClsPeople _Person;

        Form AddingStatus=new AddingStatus();

        public delegate void OnDataBack(int PersonID);
        public event OnDataBack DataBack;
        public AddPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

            if(PersonID==-1)
            {
                enMode = EnMode.AddPerson;
            }

            else
            {
                enMode=EnMode.UpdatePerson;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void _LoadCountriesINCBCountries()
        {
            DataTable dt=ClsCountry.ListCountries();

            foreach(DataRow row in dt.Rows)
            {
                CBCountry.Items.Add(row["CountryName"]);
            }

            CBCountry.Sorted = true;
            CBCountry.SelectedItem = "Jordan";
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First_Name")
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
        }

        private void _ColorOFTextBOXOFName()
        {
            txtFirstName.ForeColor = Color.Black;
            txtSecondName.ForeColor = Color.Black;
            txtThirdName.ForeColor = Color.Black;
            txtLastName.ForeColor = Color.Black;
         
        }

        private void _LoadData()
        { 
            _LoadCountriesINCBCountries();
            
            if(enMode==EnMode.AddPerson)
            {
                AddingStatus.Tag = "Person Addes Successfully !";
               _Person = new ClsPeople();
                LblPerson.Text = "Add New Person";
                return;
            }

            _Person = ClsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("The Person is not found ! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _ColorOFTextBOXOFName();
            AddingStatus.Tag = "Person Updated Successfully !";
            LblPerson.Location = new Point((this.ClientSize.Width - LblPerson.Width) / 2-25, 10);
            LblPerson.Text = "Edit Person ID = " + _Person.PersonID.ToString();
            txtID.Text = _Person.PersonID.ToString();
            txtFirstName.Text=_Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text=_Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNational_No.Text = _Person.NationalNo;
            if(_Person.Gendor==(short)EnGendor.Male)
            {
                RadioMale.Checked=true;
            }
            else
            {
                radioFemale.Checked = true;
            }
            txtPhone.Text = _Person.Phone;
            DateTimePicker.Value = _Person.DateOfBirth;
            txtEmail.Text= _Person.Email;
            txtAddress.Text= _Person.Address;
            CBCountry.SelectedIndex = CBCountry.FindString(ClsCountry.FindCountry(_Person.CountryID).CountryName);
            if (_Person.ImagePath == "")
            {
                UpdateRadioButtonImage();
            }

            else
            {
                pictureOfPerson.Load(_Person.ImagePath);
            }

            llRemove_Image.Visible = (_Person.ImagePath != "");
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First_Name";
                txtFirstName.ForeColor = Color.Gray;
            }
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtID;
            DateTimePicker.MinDate = DateTime.Now.AddYears(-100); // أقل عمر ممكن 100 سنة
            DateTimePicker.MaxDate = DateTime.Now.AddYears(-18);  // الحد الأقصى هو 18 سنة
            DateTimePicker.Value = DateTimePicker.MaxDate; // تعيين القيمة الافتراضية لعمر 18 سنة

            _LoadData();
        }

        private void txtSecondName_Enter(object sender, EventArgs e)
        {
            if (txtSecondName.Text == "Second_Name")
            {
                txtSecondName.Text = "";
                txtSecondName.ForeColor = Color.Black;
            }
        }

        private void txtSecodName_Leave(object sender, EventArgs e)
        {
            if (txtSecondName.Text == "")
            {
                txtSecondName.Text = "Second_Name";
                txtSecondName.ForeColor = Color.Gray;
            }
        }

        private void txtThirdName_Enter(object sender, EventArgs e)
        {
            if (txtThirdName.Text == "Third_Name")
            {
                txtThirdName.Text = "";
                txtThirdName.ForeColor = Color.Black;
            }
        }

        private void txtThirdName_Leave(object sender, EventArgs e)
        {
            if (txtThirdName.Text == "")
            {
                txtThirdName.Text = "Third_Name";
                txtThirdName.ForeColor = Color.Gray;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last_Name")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.Black;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last_Name";
                txtLastName.ForeColor = Color.Gray;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pictureOfPerson.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // يمكن عرض رسالة خطأ هنا إذا لزم الأمر
                    }
                }

                if (!string.IsNullOrEmpty(pictureOfPerson.ImageLocation))
                {
                    string SourceImageFile = pictureOfPerson.ImageLocation.ToString();

                    if (ClsUtil.CopyImageToProjectImageFolder(ref SourceImageFile))
                    {
                        _Person.ImagePath = SourceImageFile; // تحديث المسار الجديد للصورة
                        pictureOfPerson.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void UpdateRadioButtonImage()
        {
            if(RadioMale.Checked)
            {
                pictureOfPerson.Image=Properties.Resources.Male_512;
            }
            else if(radioFemale.Checked)
            {
                pictureOfPerson.Image = Properties.Resources.Female_512;
            }
        }

        private void RadioMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonImage();
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonImage();
        }

       

        private void llSet_Image_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Path = openFileDialog1.FileName;
                pictureOfPerson.Load(Path);
                llRemove_Image.Visible = true;
               
            }
        }

        private void llRemove_Image_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // حذف الصورة القديمة من النظام
            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                try
                {
                    File.Delete(_Person.ImagePath);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error deleting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pictureOfPerson.ImageLocation = null;
            _Person.ImagePath = "";
            UpdateRadioButtonImage();
            llRemove_Image.Visible = false;

            // لتجنب التركيز على الـ TextBoxes
            this.ActiveControl = txtID;
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ClsCountry Country = ClsCountry.FindCountry(CBCountry.Text);
            if (Country == null)
            {
                MessageBox.Show("Invalid Country!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CountryID = Country.CountryID;

            // تحديث بيانات الشخص
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNational_No.Text;
            _Person.Gendor = RadioMale.Checked ? (short)EnGendor.Male : (short)EnGendor.Female;
            _Person.Phone = txtPhone.Text;
            _Person.DateOfBirth = DateTimePicker.Value;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.CountryID = CountryID;

            // **التعامل مع الصورة قبل حفظ البيانات**
            if (!_HandlePersonImage())
            {
                MessageBox.Show("Error processing image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // حفظ البيانات
            if (_Person.Save())
            {
                AddingStatus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error in saving person.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBack?.Invoke(_Person.PersonID);
            // تحديث وضع التعديل

            // enMode = EnMode.UpdatePerson;
            if (enMode == EnMode.AddPerson)
            {
                LblPerson.Location = new Point((this.ClientSize.Width - LblPerson.Width) / 2 - 25, 10);
                LblPerson.Text = "Edit Person ID = " + _Person.PersonID.ToString();
                txtID.Text = _Person.PersonID.ToString();
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(!txtFirstName.Text.All(char.IsLetter))
            {
                errorProvider.SetError(txtFirstName, "Please enter Valid Name !");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, "");
                e.Cancel = false; ;
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (!txtSecondName.Text.All(char.IsLetter))
            {
                errorProvider.SetError(txtSecondName, "Please enter a valid name!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSecondName, "");
                e.Cancel = false;
            }
        }


        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            
            if(txtThirdName.Text.Trim()=="")
            {
                return; 
            }

            if (!txtThirdName.Text.All(char.IsLetter))
            {
                errorProvider.SetError(txtThirdName, "Please enter Valid Name !");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtThirdName, "");
                e.Cancel = false; ;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {

            if (!txtLastName.Text.All(char.IsLetter))
            {
                errorProvider.SetError(txtLastName, "Please enter Valid Name !");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, "");
                e.Cancel = false; ;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {

            if (!txtPhone.Text.All(char.IsDigit))
            {
                errorProvider.SetError(txtPhone, "Please enter Valid Number !");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhone, "");
                e.Cancel = false; ;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (txtEmail.Text.Trim() == "")
            {
                return;
            }


            string email = txtEmail.Text;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                errorProvider.SetError(txtEmail, "Please enter valid Email .");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
                e.Cancel = false; ;
            }
        }

        private void txtNational_No_Validating(object sender, CancelEventArgs e)
        {
            if (enMode == EnMode.AddPerson && ClsPeople.IsNationalNoExist(txtNational_No.Text))
            {
                errorProvider.SetError(txtNational_No, "This National No already exists, try another one!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNational_No, "");
                e.Cancel = false;
            }
        }
    }
}
