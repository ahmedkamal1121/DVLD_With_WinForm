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

namespace DVLD.Licenses
{
    public partial class frmShowLincensesInfo : Form
    {
        private int _LocalID;
        private clsLocalDrivingLicenseApplication LocalID;
        public frmShowLincensesInfo(int ID)
        {
            InitializeComponent();
            _LocalID = ID;
        }

        private void frmShowLincensesInfo_Load(object sender, EventArgs e)
        {
            int LicenseID = clsLicenes.Find(clsLocalDrivingLicenseApplication.Find(_LocalID).ApplicationID).LicenseID;
            ctrlDriverLincenses1.LoadData(LicenseID);
        }
    }
}
