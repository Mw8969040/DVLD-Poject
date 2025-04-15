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
    public partial class Change_Password : Form
    {
        ClsUsers _User =new ClsUsers();
        int _UserID;
        Form AddingStatus = new AddingStatus();
        public Change_Password(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
           cardUserInfo1.LoadUserInfo(UserID);

        }

        private void _LoadData(ref ClsUsers User)
        {
            User = ClsUsers.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("User Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
           _LoadData(ref _User);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // بتعمل فحص للكل ال validating الى عندى فى البرنامج
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red fields for details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _User.Password=txtNewPassword.Text;

            if(_User.Save())
            {
                AddingStatus.Tag = "Password Updated Successfully !";
                AddingStatus.ShowDialog();
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            string CurrentPassword = _User.Password;
            string Password=txtCurrentPassword.Text;

            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                errorProvider.SetError(txtCurrentPassword, "This Field Is Required.");
                e.Cancel = true;
            }

            else if (!CurrentPassword.Equals(Password, StringComparison.Ordinal))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCurrentPassword, "Passwords NOT Current to this user.");     
            }
            else
            {
                e.Cancel= false;
                errorProvider.SetError(txtCurrentPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string Password = txtNewPassword.Text;
            string Confirm = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(Confirm))
            {
                errorProvider.SetError(txtConfirmPassword, "This Field Is Required.");
                e.Cancel = true;
            }

            else if (!Password.Equals(Confirm, StringComparison.Ordinal))
            {
                errorProvider.SetError(txtConfirmPassword, "Passwords do not match.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfirmPassword, "");
                e.Cancel = false;
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProvider.SetError(txtNewPassword, "This Field Is Required .");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNewPassword, "");
                e.Cancel = false; ;
            }
        }
    }
}
