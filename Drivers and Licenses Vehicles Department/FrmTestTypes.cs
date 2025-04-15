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
    public partial class FrmTestTypes : Form
    {
        public FrmTestTypes()
        {
            InitializeComponent();
        }


        private void _RefreshDataView()
        {
            DataViewManageTestTypes.DataSource = ClsTestTypes.ListTestTypes();
        }

        private void FrmTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshDataView();

            if(DataViewManageTestTypes.Rows.Count>0)
            {
                DataViewManageTestTypes.Columns[0].HeaderText = "Test ID";
                DataViewManageTestTypes.Columns[0].Width = 50;

                DataViewManageTestTypes.Columns[1].HeaderText = "Test Type Title";
                DataViewManageTestTypes.Columns[1].Width = 100;

                DataViewManageTestTypes.Columns[2].HeaderText = "Test Type Description";
                DataViewManageTestTypes.Columns[2].Width = 100;

                DataViewManageTestTypes.Columns[3].HeaderText = "Test Type Fees";
                DataViewManageTestTypes.Columns[3].Width = 150;

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new FrmUpdateTestType((int)DataViewManageTestTypes.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
            _RefreshDataView();
        }
    }
}
