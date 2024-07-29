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

namespace DVLD.Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoWithFitler : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        private clsLicenes _License;
        private int _LicenseID;
        public ctrlDriverLicenseInfoWithFitler()
        {
            InitializeComponent();
        }

        public clsLicenes SelectedLicenseInfo
        {
            get { return _License; }
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public int GetLicenseID()
        {
            return _LicenseID;
        }



        private void _DoseLicenseFit()
        {

            //if (clsLicenes.FindByLicenseID(_LincenseID).LicenseClassIfo.LicenseClassID != 3)
            //{
            //    MessageBox.Show("NOT ACCURAY");

            //}
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LicenseID = Convert.ToInt32(txtLicenseID.Text);
            _License = clsLicenes.FindByLicenseID(_LicenseID);
            ctrlDriverLincenses1.LoadData(_LicenseID);
            _LicenseID = ctrlDriverLincenses1.LicenseID;

            if (OnLicenseSelected != null)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);

            _DoseLicenseFit();
        }

        private void ctrlDriverLincenses1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlDriverLicenseInfoWithFitler_Load(object sender, EventArgs e)
        {

        }
    }
}
