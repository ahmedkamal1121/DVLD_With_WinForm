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

namespace DVLD.LiecinesApplication.DetainLicense
{
    public partial class frmDetainLicenseApp : Form
    {
        private int _LicenseID;
        private clsLicenes _License;

        public frmDetainLicenseApp()
        {
            InitializeComponent();
        }

        private void frmDetainLicenseApp_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text =clsUser.FindByID( CrUser.ID).UserName;
        }

        private void ctrlDriverLicenseInfoWithFitler1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _License = clsLicenes.FindByLicenseID( _LicenseID );

            if(_License == null )
            {
                MessageBox.Show("Not Found");
                return;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("License Already Detain");
                return;
            }

            if (!_License.IsActive)
            {
                MessageBox.Show("License  UnActive");

                return;
            }

            btnDetain.Enabled = true;

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            int DetainID = -1;
            DetainID = _License.Detaine(Convert.ToSingle(txtFineFees.Text),CrUser.ID);

            if(DetainID == -1)
            {
                MessageBox.Show("Faild");
                return;
            }

            MessageBox.Show("Done");
            lblDetainID.Text = DetainID.ToString();
            lblLicenseID.Text = _LicenseID.ToString();



        }
    }
}
