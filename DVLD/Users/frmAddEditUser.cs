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

namespace DVLD.Users
{
    public partial class frmAddEditUser : Form
    {

        clsUser _User = new clsUser();
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public frmAddEditUser()
        {
            InitializeComponent();
            Mode = enMode.AddNew;

        }

        public frmAddEditUser(int UserID)
        {
            
            InitializeComponent();
            Mode = enMode.Update;
            _LoadData(UserID);
            
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }


        //Update Mode
        public void _LoadData(int UserID)
        {
           
            ctrlPersonInfoCardWithFilter1.LoadData(clsUser.FindByID(UserID).PersonID);

            lbUserID.Text = UserID.ToString();
            _User = clsUser.FindByID(UserID);
            txUsername.Text = _User.UserName.ToString();
            txPassword.Text = _User.Password.ToString();
            chIsactive.Checked = _User.IsActive;
        }

        //Next
        private void Next_Click(object sender, EventArgs e)
        {
            

           if(Mode == enMode.AddNew)
            {
                int ID = ctrlPersonInfoCardWithFilter1.GetPersonID();

                if (!clsUser.ChechUserIsFound(ID))
                {
                    _User.PersonID = ID;
                    tcADDUser.SelectedTab = tcADDUser.TabPages["tbLogin"];
                }
                else
                {
                    MessageBox.Show("Person is alredy is a User");
                }
            }
            else
            {
                tcADDUser.SelectedTab = tcADDUser.TabPages["tbLogin"];
            }
           


        }

        //Save
        private void Save_Click(object sender, EventArgs e)
        {
            _User.UserName = txUsername.Text;
            _User.Password = txPassword.Text;
            _User.IsActive = chIsactive.Checked;

            if(_User.Save())
            {
                MessageBox.Show("تم بنجاح");
            }
            else
            {
                MessageBox.Show("فشل");

            }
        }

        private void ctrlPersonInfoCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
