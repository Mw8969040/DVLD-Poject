using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class AddUpdateUser : Form
    {
        int _UserID;
        ClsUsers _User;

        enum EnMode { AddUser = 0, UpdateUser = 1 };
        enum EnCheckActive { NotActive = 0, Active = 1 };

        EnMode enMode = EnMode.AddUser;

        Form AddingStatus = new AddingStatus();
        public AddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

            if(UserID==-1)
            {
                enMode = EnMode.AddUser;
                cardOfPersonWithFilter1.FilterEnabled = true;
                cardOfPersonWithFilter1.ShowButtonAdd = true ;
                cardOfPersonWithFilter1.ShowButtonSearch = true;
            }
            else
            {
                enMode = EnMode.UpdateUser;
                cardOfPersonWithFilter1.FilterEnabled = false;
                cardOfPersonWithFilter1.ShowButtonAdd = false;
                cardOfPersonWithFilter1.ShowButtonSearch = false;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if(ClsUsers.IsPersonIDNotExist(cardOfPersonWithFilter1.PersonID) && enMode==EnMode.AddUser)
            {
                MessageBox.Show("This Person Is User Already !","Information",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            TabControl.SelectedTab =LoginInfo;
            ButtonSave.Visible = true;
            this.ActiveControl = null;
        }

        private void _LoadDataUser()
        {
            if(enMode==EnMode.AddUser)
            {
                LblUser.Text = "Add New User";
                AddingStatus.Tag = "User Added Successfully !";
                _User=new ClsUsers();
                return;
            }

            _User = ClsUsers.Find(_UserID);

            if(_User==null)
            {
                MessageBox.Show("This User Not Found !","Eror" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cardOfPersonWithFilter1.LoadPersonInfo(_User.PersonID);

            AddingStatus.Tag = "User Updated Successfully !";
            LblUser.Location = new Point((this.ClientSize.Width - LblUser.Width) / 2 - 25, 10);
            LblUser.Text = "Edit User ID = " + _User.UserID.ToString();
            LblID.Text=_User.UserID.ToString();
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            txtUserName.Text = _User.UserName;
            IsActive.Checked = (_User.IsActive != (short)EnCheckActive.NotActive);
        }
        private void PrevButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = PersonInfo;
            ButtonSave.Visible=false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red fields for details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _User.PersonID = cardOfPersonWithFilter1.PersonID;
            _User.Password = txtPassword.Text;
            _User.UserName= txtUserName.Text;
            _User.IsActive=IsActive.Checked?(short)EnCheckActive.Active:(short)EnCheckActive.NotActive;


            if (_User.Save())
            {
                AddingStatus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error in saving User.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (enMode==EnMode.AddUser)
            {
                LblUser.Location = new Point((this.ClientSize.Width - LblUser.Width) / 2 - 25, 10);
                LblUser.Text = "Edit User ID = " + _User.UserID.ToString();
                LblID.Text=_User.UserID.ToString();
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text=="")
            {
                errorProvider.SetError(txtUserName, "This Field Is Required .");
            }
            else
            {
                errorProvider.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "This Field Is Required .");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
                e.Cancel = false; ;
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string Password = txtPassword.Text;
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
                e.Cancel= false; 
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadDataUser();
        }

       
    }
}
