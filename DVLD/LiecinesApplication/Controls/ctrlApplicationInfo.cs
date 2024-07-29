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
using DVLD.people;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalApplication;

        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int ID)
        {
            _LocalApplication = clsLocalDrivingLicenseApplication.Find(ID);
            _Filldata();
          
        }

        private void _Filldata()
        {
            lbDLAPP.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lbclass.Text = clsLicensesClasses.FindByID(_LocalApplication.LicenseClassID).ClassName;
            lbtest.Text = clsStatusAndPassed.CheckStatusAndTest(_LocalApplication.LocalDrivingLicenseApplicationID).PassedTestCount.ToString();
            lbID.Text = _LocalApplication.ApplicationID.ToString();
            lbstatus.Text = _LocalApplication.ApplicationStatus.ToString();
            lbFees.Text = _LocalApplication.PaidFees.ToString();
            lbType.Text = _LocalApplication.ApplicationTypeInfo.ApplicationTypeTitle;
            lbappname.Text = _LocalApplication.ApplicantFullName.ToString();
            lbCreatedBy.Text = _LocalApplication.CreatedByUserInfo.UserName;
            lbdate.Text = _LocalApplication.ApplicationDate.ToString();
            lbstatusDate.Text = _LocalApplication.LastStatusDate.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_LocalApplication.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
