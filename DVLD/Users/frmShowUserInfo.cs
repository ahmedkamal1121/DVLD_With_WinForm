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
    public partial class frmShowUserInfo : Form
    {
        private clsUser _User;
        //private clsPerson _Person;

        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _User = clsUser.FindByID(UserID);
            //_Person = clsPerson.FindpersonByID(_User.PersonID);
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfoCard1.LoadData(_User.UserID,_User.UserName ,_User.IsActive,_User.PersonID);
        }
    }
}
