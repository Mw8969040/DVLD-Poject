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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private void Close_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text =="" || txtUserName.Text=="User Name")
            {
                e.Cancel = true;
                errorProvider.SetError(txtUserName, "This Field is Requierd .");
            }
            else
            {
                e.Cancel= false;
                errorProvider.SetError(txtUserName, "");
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {

            if (txtUserName.Text == "User Name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text=="Password")
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "This Field is Requierd .");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, "");
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Enter Password and User_Name .","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            ClsUsers User= ClsUsers.Find(txtUserName.Text);

            if(User==null || User.Password!=txtPassword.Text.Trim())
            {
                MessageBox.Show("Error In Password Or User_Name Try Again .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }

            if(User.IsActive==0)
            {
                MessageBox.Show("Sorry This User Is Not Active ,Contact Admin .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            GLobal.CurrentUser = User;

            Form form = new Dashboard();
            this.Hide();
            form.ShowDialog();
        }
    }
}
