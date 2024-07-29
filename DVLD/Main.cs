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
using DVLD.Drivers;
using DVLD.LiecinesApplication;
using DVLD.LiecinesApplication.ApplicationType;
using DVLD.LiecinesApplication.DetainLicense;
using DVLD.LiecinesApplication.Intrnational_Driving_License;
using DVLD.LiecinesApplication.Renew;
using DVLD.LiecinesApplication.Replace;
using DVLD.Login;
using DVLD.Manage;
using DVLD.Users;


namespace DVLD
{
    public partial class Main : Form
    {
        frmLogin _frmlogin;
        public Main(frmLogin frm)
        {
            InitializeComponent();
            _frmlogin = frm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople ManagePeople = new ManagePeople();
            ManagePeople.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.frmListUsers ListUsers = new Users.frmListUsers();
            ListUsers.ShowDialog();
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(CrUser.ID);
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmApplicationType frm = new frmApplicationType();
            frm.ShowDialog();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestType frm = new frmManageTestType();
            frm.ShowDialog();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmNewLocalLicencs frm = new frmNewLocalLicencs();
            frm.ShowDialog();
        }

      
        private void localToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListApplications frm = new frmListApplications();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverList frm = new frmDriverList();    
            frm.ShowDialog();
        }

        private void internatinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewInternNational frm = new frmAddNewInternNational();
            frm.ShowDialog();
        }

        private void internatinalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frm = new frmListInternationalLicesnseApplications();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewDrinvingLicense frm = new frmRenewDrinvingLicense();
            frm.ShowDialog();
        }

        private void replacmentForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnReplacment frm = new frnReplacment();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApp frm = new frmDetainLicenseApp();
            frm.ShowDialog();
        }

        private void ManageDetainedLicensestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetainList frm = new frmDetainList();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRlease frm = new frmRlease();
            frm.ShowDialog();
        }

        private void releasDetainedDrivingLiceneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRlease frm = new frmRlease();
            frm.ShowDialog();
        }
    }
}
