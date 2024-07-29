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
using DVLD.Licenses;

namespace DVLD.LiecinesApplication.Intrnational_Driving_License
{
    public partial class frmAddNewInternNational : Form
    {
        clsLicenes _License;
        public frmAddNewInternNational()
        {
            InitializeComponent();
        }

        private void frmAddNewInternNational_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblFees.Text = clsApplicationType.Find((int)clsApp.enApplicationType.NewInternationalLicense).ApplicationFees.ToString();
            lblCreatedByUser.Text = clsUser.FindByID(CrUser.ID).UserName.ToString();
            //_License = clsLicenes.FindByLicenseID(ctrlDriverLicenseInfoWithFitler1.GetLicenseID());
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            clsInternationalLicense internationalLicense = new clsInternationalLicense();
            internationalLicense.DriverID = _License.DriverID;
            internationalLicense.IssueUsingLocalLicense = _License.LicenseID;
            internationalLicense.CreatedByUserID = CrUser.ID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.IsActive = true;

            clsApp App = new clsApp();
            App.ApplicantPersonID = _License.ApplicationInfo.ApplicantPersonID;
            App.ApplicationDate = DateTime.Now;
            App.ApplicationTypeID = 6;
            App.ApplicationStatus = clsApp.enApplicationStatus.Completed;
            App.LastStatusDate = DateTime.Now;
            App.PaidFees = clsApplicationType.Find(6).ApplicationFees;//dwdwwd
            App.CreatedByUserID = CrUser.ID;

            if (App.Save())
            {
                internationalLicense.ApplicationID =App.ApplicationID;

            }
            else
            {
                internationalLicense.ApplicationID = -1;

            }


            if (internationalLicense.ApplicationID == -1)
            {

                MessageBox.Show("Faild in Save Application");

            }

            if (internationalLicense.Save())
            {
                lblInternationalLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
                lblApplicationID.Text = App.ApplicationID.ToString();
                clsLocalDrivingLicenseApplication.FindByAppID(_License.ApplicationID).LocalDrivingLicenseApplicationID.ToString();
                lblLocalLicenseID.Text = _License.LicenseID.ToString();
                MessageBox.Show("Done");

            }
            else
            {
                MessageBox.Show("Faild");

            }
        }

        private void ctrlDriverLicenseInfoWithFitler1_OnLicenseSelected(int LicenseID)
        {
            _License = clsLicenes.FindByLicenseID(LicenseID);

            if (_License == null)
                return;

            if (_License.LicenseClassIfo.LicenseClassID != 3)
            {
                MessageBox.Show("معليش الرخصة بتاعتو ما عادية ");
                return;

            }

            if (!_License.IsActive)
            {
                MessageBox.Show("معليش الرخصة بتاعتو ما شغالة ");
                return;
            }

            if(_License.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("معليش الرخصة منتهية  ");
                return;
            }

            if (clsInternationalLicense.ChechUserIsFound(_License.ApplicationInfo.ApplicantPersonID))
            {
                MessageBox.Show("معليش  عندو رخصه الزول ده ");
                return;
            }

            btnIssueLicense.Enabled = true;

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(_License.ApplicationInfo.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
