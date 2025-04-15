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
    public partial class FrmUpdateTestType : Form
    {
       int _TestID;
        ClsTestTypes _TestType;
        AddingStatus AddingStatus=new AddingStatus();
        public FrmUpdateTestType(int TestID)
        {
            InitializeComponent();
            _TestID = TestID;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FindAndLoadDataTest()
        {
            _TestType = ClsTestTypes.Find(_TestID);

            if (_TestType == null)
            {
                MessageBox.Show("Test Not Found .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LblID.Text = _TestType.TestID.ToString();
            txtDescription.Text= _TestType.Description;
            txtTitle.Text = _TestType.Title;
            txtFees.Text = _TestType.Fees.ToString();
        }

        private void FrmUpdateTestType_Load(object sender, EventArgs e)
        {
            _FindAndLoadDataTest();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ClsTestTypes.UpdateTestType(int.Parse(LblID.Text), txtTitle.Text,txtDescription.Text, int.Parse(txtFees.Text)))
            {
                AddingStatus.Tag = "Test Updated Successfully !";
                AddingStatus.ShowDialog();
            }

        }
    }
}
