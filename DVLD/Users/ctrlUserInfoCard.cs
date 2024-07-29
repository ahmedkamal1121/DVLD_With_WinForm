using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class ctrlUserInfoCard : UserControl
    {
        public ctrlUserInfoCard()
        {
            InitializeComponent();
        }

        public void LoadData(int UserID , string Username ,bool IsActive ,int PersonID)
        {
            //Person Info
            ctrlPersonInfoCard1.LoadPersonInfo(PersonID);

            //Login Info 
            lbname.Text = Username;
            lbID.Text = UserID.ToString();
            lbActive.Text = IsActive == true ? "true" : "false";

        }

        private void ctrlPersonInfoCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
