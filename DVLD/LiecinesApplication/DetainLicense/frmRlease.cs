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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.LiecinesApplication.DetainLicense
{
    public partial class frmRlease : Form
    {
        int _SelectedLicenseID = -1;

        public frmRlease()
        {
            InitializeComponent();
        }

        private void frmRlease_Load(object sender, EventArgs e)
        {

        }

        private void ctrlDriverLicenseInfoWithFitler1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)

            {
                return;
            }

            ////ToDo: make sure the license is not detained already.
            if (!ctrlDriverLicenseInfoWithFitler1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationFees.Text = clsApplicationType.Find((int)clsApp.enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationFees.ToString();
            lblCreatedByUser.Text = clsUser.FindByID(CrUser.ID).UserName;

            lblDetainID.Text = ctrlDriverLicenseInfoWithFitler1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblLicenseID.Text = ctrlDriverLicenseInfoWithFitler1.SelectedLicenseInfo.LicenseID.ToString();

            lblCreatedByUser.Text = ctrlDriverLicenseInfoWithFitler1.SelectedLicenseInfo.DetainedInfo.CreatedByUserInfo.UserName;
            lblDetainDate.Text = ctrlDriverLicenseInfoWithFitler1.SelectedLicenseInfo.DetainedInfo.DetainDate.ToShortDateString();
            lblFineFees.Text = ctrlDriverLicenseInfoWithFitler1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

            btnRelease.Enabled = true;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplocationID = -1;
            ApplocationID = ctrlDriverLicenseInfoWithFitler1.SelectedLicenseInfo.Rlease(CrUser.ID, _SelectedLicenseID);

            if(ApplocationID == -1)
            {
                MessageBox.Show("Falid");
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblApplicationID.Text = ApplocationID.ToString();
            btnRelease.Enabled = false;
            llShowLicenseInfo.Enabled = true;



        }
    }
}
