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

namespace DVLD.LiecinesApplication.Replace
{
    public partial class frnReplacment : Form
    {
        private int _LicenseID;
        private clsApp.enApplicationType _enApplicationType = clsApp.enApplicationType.ReplaceDamagedDrivingLicense;
        private clsLicenes.enIssueReason _IssueReson = clsLicenes.enIssueReason.DamagedReplacement;
        clsLicenes _License;

        public frnReplacment()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicenseInfoWithFitler1_OnLicenseSelected(int LicenseID)
        {

            _LicenseID = LicenseID;
            _License = clsLicenes.FindByLicenseID(LicenseID);


            if (!_License.IsActive)
            {
                MessageBox.Show("معليش الرخصة بتاعتو ما شغالة ");
                btnIssueReplacement.Enabled = false;

                return;
            }

            lblOldLicenseID.Text = _LicenseID.ToString();//ON PERSON
            btnIssueReplacement.Enabled = true;



        }

        private void frnReplacment_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find((int)_enApplicationType).ApplicationFees.ToString();
            lblCreatedByUser.Text = clsUser.FindByID(CrUser.ID).UserName.ToString();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {

            clsLicenes NewLincense;
            NewLincense =  _License.Replace(_IssueReson, CrUser.ID);

            if(NewLincense != null)
            {
                MessageBox.Show("Licensed Replace Successfully with ID=" + NewLincense.LicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApplicationID.Text = NewLincense.ApplicationID.ToString();
                lblRreplacedLicenseID.Text = NewLincense.LicenseID.ToString();
            }
            else
            {
                MessageBox.Show("Faild in Save ");
                return;
            }

            ////Save Appliaction
            //clsApp App = new clsApp();
            //App.ApplicantPersonID = _License.ApplicationInfo.ApplicantPersonID;
            //App.ApplicationDate = DateTime.Now;
            //App.ApplicationTypeID = (int)_enApplicationType;
            //App.ApplicationStatus = clsApp.enApplicationStatus.Completed;
            //App.LastStatusDate = DateTime.Now;
            //App.PaidFees = clsApplicationType.Find((int)_enApplicationType).ApplicationFees;
            //App.CreatedByUserID = CrUser.ID;

            //if (!App.Save())
            //{
            //    MessageBox.Show("Faild in Save APP");
            //    return;
            //}



            //clsLicenes NewLicense = new clsLicenes();
            //NewLicense.ApplicationID = App.ApplicationID;
            //NewLicense.DriverID = _License.DriverID;
            //NewLicense.LicenseClass = _License.LicenseClass;
            //NewLicense.IssueDate = _License.IssueDate;
            //NewLicense.ExpirationDate = _License.ExpirationDate;
            //NewLicense.IsActive = true;
            //NewLicense.IssueReason = _IssueReson;
            //NewLicense.PaidFees = clsApplicationType.Find((int)_enApplicationType).ApplicationFees;
            //NewLicense.CreatedByUserID = _License.CreatedByUserID;
            //NewLicense.Notes = _License.Notes;

            //if (NewLicense.Save())
            //{

            //    if (clsLicenes.UnActiveLicense(_LicenseID))
            //    {
            //        MessageBox.Show("Licensed Replace Successfully with ID=" + NewLicense.LicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        lblApplicationID.Text = App.ApplicationID.ToString();
            //        lblRreplacedLicenseID.Text = NewLicense.LicenseID.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Faild in DeActivet ");
            //        return;
            //    }


            //}
            //else
            //{
            //    MessageBox.Show("Faild in Save ");
            //    return;
            //}


    



    }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            _enApplicationType = clsApp.enApplicationType.ReplaceDamagedDrivingLicense;
            _IssueReson = clsLicenes.enIssueReason.DamagedReplacement;
            lblApplicationFees.Text = clsApplicationType.Find((int)_enApplicationType).ApplicationFees.ToString();

        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            _enApplicationType = clsApp.enApplicationType.ReplaceLostDrivingLicense;
            _IssueReson = clsLicenes.enIssueReason.LostReplacement;
            lblApplicationFees.Text = clsApplicationType.Find((int)_enApplicationType).ApplicationFees.ToString();


        }
    }
}
