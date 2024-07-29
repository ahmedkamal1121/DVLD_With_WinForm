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
using DVLD.Licenses.Controls;

namespace DVLD.LiecinesApplication.Renew
{
    public partial class frmRenewDrinvingLicense : Form
    {
        private int _LicenseID;
        clsLicenes _License;
        public frmRenewDrinvingLicense()
        {
            InitializeComponent();
           
        }

        private void frmRenewDrinvingLicense_Load(object sender, EventArgs e)
        {
          
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = lblApplicationDate.Text;

            lblExpirationDate.Text = "???";
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApp.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
            lblCreatedByUser.Text = clsUser.FindByID( CrUser.ID).UserName.ToString();
        }

        private void ctrlDriverLicenseInfoWithFitler1_OnLicenseSelected(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicenes.FindByLicenseID(LicenseID);


            if (!_License.IsActive)
            {
                MessageBox.Show("معليش الرخصة بتاعتو ما شغالة ");
                btnSave.Enabled = false;

                return;
            }

            if (_License.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("معليش الرخصة سارية");
                btnSave.Enabled = false;

                return;
            }

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            clsLicenes NewLicense ;
            NewLicense = _License.RenewLicense(txtNotes.Text.Trim(),CrUser.ID);

            if(NewLicense != null)
            {
                MessageBox.Show("Licensed Renewed Successfully with ID=" + NewLicense.LicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild");

            }

            //Save Appliaction
            //clsApp App = new clsApp();
            //App.ApplicantPersonID = _License.ApplicationInfo.ApplicantPersonID;
            //App.ApplicationDate = DateTime.Now;
            //App.ApplicationTypeID = 6;
            //App.ApplicationStatus = clsApp.enApplicationStatus.Completed;
            //App.LastStatusDate = DateTime.Now;
            //App.PaidFees = clsApplicationType.Find(2).ApplicationFees;
            //App.CreatedByUserID = CrUser.ID;

            //if(!App.Save())
            //{
            //    MessageBox.Show("Faild in Save APP");
            //    return;
            //}

            //NewLicense
            //clsLicenes NewLicense = new clsLicenes();
            //NewLicense.ApplicationID = App.ApplicationID;
            //NewLicense.DriverID = _License.DriverID;
            //NewLicense.LicenseClass = _License.LicenseClass;
            //NewLicense.IssueDate = DateTime.Now;
            //NewLicense.ExpirationDate = DateTime.Now.AddYears(_License.LicenseClassIfo.DefaultValidityLength);
            //NewLicense.IsActive = _License.IsActive;
            //NewLicense.IssueReason = clsLicenes.enIssueReason.Renew;
            //NewLicense.PaidFees = clsApplicationType.Find(2).ApplicationFees;
            //NewLicense.CreatedByUserID = _License.CreatedByUserID;

            //    if (NewLicense.Save())
            //    {

            //        if (clsLicenes.UnActiveLicense(_LicenseID))
            //        {
            //            MessageBox.Show("Licensed Renewed Successfully with ID=" + NewLicense.LicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Faild in DeActivet ");
            //            return;
            //        }


            //    }
            //    else
            //    {
            //        MessageBox.Show("Faild in Save ");
            //        return;
            //    }


        }

    }
}
