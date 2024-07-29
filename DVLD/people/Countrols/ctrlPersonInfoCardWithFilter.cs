using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD.people.Countrols
{
    public partial class ctrlPersonInfoCardWithFilter : UserControl
    {
        public ctrlPersonInfoCardWithFilter()
        {
            InitializeComponent();
        }

        clsPerson _Person;
        clsUser _User;
        string FitlerType;

        public int GetPersonID()
        {
            return (txSerash.Text == "" ? -1 : _Person.ID) ;
        }

        //Update Mode
        public void LoadData(int PersonID)
        {

            //_User = clsUser.FindByUserName

            //if (_User != null )
            //{
                txSerash.Text = PersonID.ToString();
                ctrlPersonInfoCard1.LoadPersonInfo(PersonID);
                gbFilter.Enabled = false;

            //}
            //else
            //{
            //    MessageBox.Show("Not Found");
            //}




        }

        private void ctrlPersonInfoCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFitler.Items.Add("PersonID");
            cbFitler.Items.Add("National No");
            cbFitler.SelectedIndex = 0;
        }

        private void DataBackEvent(object sender, int _PersonID)
        {
            // Handle the data received
            cbFitler.SelectedIndex = 0;
            txSerash.Text = _PersonID.ToString();
            ctrlPersonInfoCard1.LoadPersonInfo(_PersonID);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddAndEditPeople frm = new frmAddAndEditPeople();
            frm.DataBack += DataBackEvent; // Subscribe to the event
            frm.ShowDialog();
            btnSersh_Click(this,e);
        }

        private void btnSersh_Click(object sender, EventArgs e)
        {
           
            if(txSerash.Text == "")
            {
                MessageBox.Show("Write Number First");
                return;
            }

                   if(FitlerType == "PersonID")
                    {
                        _Person = clsPerson.FindpersonByID(Convert.ToInt32(txSerash.Text));
                    }
                    else
                    {
                        _Person = clsPerson.FindpersonByNo(txSerash.Text);
                    }

                    if (_Person != null)
                    {
                        ctrlPersonInfoCard1.LoadPersonInfo(_Person.ID);

                    }
                    else
                    {
                        MessageBox.Show("Not found");
                    }
        }

        private void txSerash_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFitler_SelectedIndexChanged(object sender, EventArgs e)
        {
            FitlerType = cbFitler.Text;
        }

        private void txSerash_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                btnSersh.PerformClick();
            }

            ////this will allow only digits if person id is selected
            if (cbFitler.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
