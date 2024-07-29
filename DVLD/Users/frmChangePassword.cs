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
    public partial class frmChangePassword : Form
    {
        private clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _User = clsUser.FindByID(UserID);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlUserInfoCard1.LoadData(_User.UserID, _User.UserName, _User.IsActive, _User.PersonID);
        }

        private void txNpass_TextChanged(object sender, EventArgs e)
        {
            if(!clsUser.LoginUser(_User.UserName, txOpass.Text))
            {
                MessageBox.Show("Old Password is Wrong :) ");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (clsUser.LoginUser(_User.UserName, txOpass.Text))
            {

                    if (clsUser.ChangePassword(_User.UserID,txNpass.Text))
                    {

                        MessageBox.Show("Change Password Done");

                    }
                    else
                    {

                        MessageBox.Show("Change Password Faild");

                    }

            }
            else
            {
                       MessageBox.Show("Old Password is Wrong :) ");
            }
        }
    }
}
