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

namespace DVLD.LiecinesApplication.Local_Driving_License
{
    public partial class frmIssueLinecenseForTheFirstTime : Form
    {
        //local
        private int _LocalAppID;
        private clsLocalDrivingLicenseApplication _LocalApp;
        public frmIssueLinecenseForTheFirstTime(int ID)
        {
            InitializeComponent();
            _LocalAppID = ID;
        }

        private void frmIssueLinecenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.LoadData(_LocalAppID);
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = -1;
            _LocalApp = clsLocalDrivingLicenseApplication.Find(_LocalAppID);

            LicenseID = _LocalApp.IssueLinecenseForTheFirstTime(CrUser.ID, txtNotes.Text.Trim());

            if (LicenseID != -1)
            {
                MessageBox.Show("done");
                
            }
            else
            {
                MessageBox.Show("faild");

            }
        }
    }
}
