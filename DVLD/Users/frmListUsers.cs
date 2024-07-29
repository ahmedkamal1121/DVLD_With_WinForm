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
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            dvUsers.DataSource = clsUser.GetAllUsers();

            dvUsers.Columns[0].HeaderText = "User ID";
            dvUsers.Columns[0].Width = 90;

            dvUsers.Columns[1].HeaderText = "Person ID";
            dvUsers.Columns[1].Width = 100;


            dvUsers.Columns[2].HeaderText = "User Name";
            dvUsers.Columns[2].Width = 250;

            dvUsers.Columns[3].HeaderText = "Password";
            dvUsers.Columns[3].Width = 100;


            dvUsers.Columns[4].HeaderText = "Is Active";
            dvUsers.Columns[4].Width = 90;


          
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();

            dvUsers.DataSource = clsUser.GetAllUsers();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((int)dvUsers.CurrentRow.Cells[0].Value);
            int UserID = (int)dvUsers.CurrentRow.Cells[0].Value;
            frmAddEditUser frm = new frmAddEditUser(UserID);
            frm.ShowDialog();

            dvUsers.DataSource = clsUser.GetAllUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + dvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.Delete((int)dvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم السمح ");
                }
                else
                {
                    MessageBox.Show("فشل المسح ");

                }
            }

            dvUsers.DataSource = clsUser.GetAllUsers();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo((int)dvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void chengePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            dvUsers.DataSource = clsUser.GetAllUsers();
        }
    }
}
