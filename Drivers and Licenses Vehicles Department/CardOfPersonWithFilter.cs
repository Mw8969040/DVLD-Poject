using BusinessDLVDLayer;
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
    public partial class CardOfPersonWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;
            if(Handler != null )
            {
                Handler(PersonID);
            }
        }

        public CardOfPersonWithFilter()
        {
            InitializeComponent();
        }

        private int _PersonID = -1;

        private bool _ShowButtonAdd = true;

        private bool _FilterEnabled = true;

        private bool _ShowButtonSearch =true;
        public int PersonID
        {
            get { return cardOfPerson1.PersonID; }
        }

        public ClsPeople Person
        {
            get { return cardOfPerson1.Person; }
        }

        public bool ShowButtonSearch
        {
            get { return _ShowButtonSearch; }

            set
            { 
                _ShowButtonSearch = value;
                ButtonSearch.Visible = _ShowButtonSearch;
            }
        }
        public bool ShowButtonAdd
        {
            get { return _ShowButtonAdd; }

            set
            {
                _ShowButtonAdd = value;
                  ButtonAdd.Visible = _ShowButtonAdd;
            }
        }

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                GBFilter.Enabled = _FilterEnabled;
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
          //  CBFilter.SelectedIndex = 0;
         // txtFilterValue.Text=PersonID.ToString();
            OnDataBack(PersonID);
        }

        private void FindNow()
        {
            if(CBFilter.Text=="Person ID")
            {
                cardOfPerson1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
            }
            else if(CBFilter.Text=="National No")
            {
             cardOfPerson1.LoadPersonInfo(txtFilterValue.Text);
            }

            if(OnPersonSelected != null && FilterEnabled )
            {
                OnPersonSelected(cardOfPerson1.PersonID);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddPerson Fm = new AddPerson(-1);
            Fm.DataBack += OnDataBack;
            Fm.ShowDialog();
        }

        private void OnDataBack(int PersonID)
        {
            CBFilter.SelectedIndex = 0;
            txtFilterValue.Text=PersonID.ToString();
            cardOfPerson1.LoadPersonInfo(PersonID);
        }

        private void CardOfPersonWithFilter_Load(object sender, EventArgs e)
        {
            CBFilter.SelectedIndex = 0;
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // بتعمل فحص للكل ال validating الى عندى فى البرنامج
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Hover over the red fields for details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FindNow(); 
        }


        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if(txtFilterValue.Text =="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtFilterValue, "");
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        { 
            // if press enter ButtonSearch will Done
            if(e.KeyChar==(char)13)
            {
                ButtonSearch.PerformClick();
            }

            //to Enter digits only;
            if(CBFilter.Text=="Person ID")
            {
                e.Handled=!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cardOfPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
