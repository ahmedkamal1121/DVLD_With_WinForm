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

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int UserID = -1;
            string Username = txUsername.Text;
            string Password = txPassword.Text;

            if(clsUser.LoginUser(Username, Password ))
            {
                clsUser user = clsUser.FindByUserName(Username);


                if (chRemaber.Checked)
                {
                    //store username and password
                    CrUser.RememberUsernameAndPassword(txUsername.Text.Trim(), txPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    CrUser.RememberUsernameAndPassword("", "");

                }

                if (!user.IsActive)
                {

                    txUsername.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                Main main = new Main(this);
                UserID = user.UserID;
                CrUser.ID = UserID;
                this.Hide();
                main.Show();



            }
            else
            {

                MessageBox.Show("Error in Username or Password");

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (CrUser.GetStoredCredential(ref UserName, ref Password))
            {
                txUsername.Text = UserName;
                txPassword.Text = Password;
                chRemaber.Checked = true;
            }
            else
                chRemaber.Checked = false;
        }

        private void txUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
