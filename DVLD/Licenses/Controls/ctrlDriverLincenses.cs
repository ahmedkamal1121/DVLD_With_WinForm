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
    public partial class ctrlDriverLincenses : UserControl
    {
    
        private clsApp _App;
        private clsLicenes _Lincense;
        private int _LicenseClass;
        private int _LicenseID;

        //public int LicenseClass {  get; }


        public int LicenseID
        {
            get { return _LicenseID; }
        }


        public ctrlDriverLincenses()
        {
            InitializeComponent();
        }

        public void LoadData(int LicenseID)
        {
            
            _Lincense = clsLicenes.FindByLicenseID(LicenseID);
            if(_Lincense == null )
            {
                MessageBox.Show("License Not Found ");
                return;
            }
            _LicenseID = _Lincense.LicenseID;
            _LicenseClass = _Lincense.LicenseClassIfo.LicenseClassID;

            _App = _Lincense.ApplicationInfo;

            lblClass.Text = _Lincense.LicenseClassIfo.ClassName.ToString();
            lblFullName.Text = _App.ApplicantFullName;
            lblLicenseID.Text = _Lincense.LicenseID.ToString();
            lblNationalNo.Text = _App.PersonInfo.NationalNo;
            lblGendor.Text = _App.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = _Lincense.IssueDate.ToShortDateString().ToString();
            lblIssueReason.Text =_Lincense.IssueReason.ToString();
            lblNotes.Text = _Lincense.Notes;
            lblIsActive.Text = _Lincense.IsActive ? "true" : "false";
            lblDateOfBirth.Text = _App.PersonInfo.DateOfBirth.ToShortDateString().ToString();
            lblDriverID.Text = _Lincense.DriverID.ToString();
            lblExpirationDate.Text = _Lincense.ExpirationDate.ToShortDateString().ToString();
            lblNotes.Text = _Lincense.Notes == "" ? "No Notes" : _Lincense.Notes;
            lblIsDetained.Text = _Lincense.IsDetained ? "true" : "false";

            //if (_Local.PersonInfo.ImagePath != null)
            //{
            //    pbPersonImage.ImageLocation = _Local.PersonInfo.ImagePath;
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblIsDetained_Click(object sender, EventArgs e)
        {

        }
    }
}
