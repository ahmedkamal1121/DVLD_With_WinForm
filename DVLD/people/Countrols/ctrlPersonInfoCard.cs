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
    public partial class ctrlPersonInfoCard : UserControl
    {
        public ctrlPersonInfoCard()
        {
            InitializeComponent();
        }

        clsPerson _Person;
        public int PersonID;


        public void LoadPersonInfo(int ID)
        {
            PersonID = ID;
            FindPerson();
        }

        public void FindPerson()
        {
            _Person = clsPerson.FindpersonByID(PersonID);
            if (_Person != null )
            {
                lbID.Text = _Person.ID.ToString();
                lbName.Text = _Person.FirstName + " " + _Person.SecondName;
                lbNA.Text = _Person.NationalNo;
                lbGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
                lbCountry.Text = clsCountry.Find(_Person.CountryID).CountryName;
                lbEmail.Text = _Person.Email;
                lbAddress.Text = _Person.Address;
                lbPhone.Text = _Person.Phone;
                lbBirth.Text = _Person.DateOfBirth.ToShortDateString();
                pcImage.ImageLocation = _Person.ImagePath;
            }
            else
            {
                MessageBox.Show("Not Found");
            }
           
        }

        private void ctrlPersonInfoCard_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbAddress_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndEditPeople frm = new frmAddAndEditPeople(_Person.ID);
            frm.ShowDialog();

            //Refresh
            FindPerson();

        }
    }
}
