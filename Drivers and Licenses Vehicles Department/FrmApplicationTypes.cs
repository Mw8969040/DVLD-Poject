using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public partial class FrmApplicationTypes : Form
    {
        public FrmApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshAppTypes()
        {
            DataViewManageAppTypes.DataSource=ClsApplicationTypes.ListAppTypes();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm=new frmUpdateAppType((int)DataViewManageAppTypes.CurrentRow.Cells[0].Value);
            fm.ShowDialog();
            _RefreshAppTypes();
        }

        private void FrmApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshAppTypes();

            if(DataViewManageAppTypes.Rows.Count > 0 )
            {
                DataViewManageAppTypes.Columns[0].HeaderText = "App ID";
                DataViewManageAppTypes.Columns[0].Width = 100;

                DataViewManageAppTypes.Columns[1].HeaderText = "App Type Title";
                DataViewManageAppTypes.Columns[1].Width = 150;

              

                DataViewManageAppTypes.Columns[2].HeaderText = "App Type Fees";
                DataViewManageAppTypes.Columns[2].Width = 100;
            }
        }
    }
}
