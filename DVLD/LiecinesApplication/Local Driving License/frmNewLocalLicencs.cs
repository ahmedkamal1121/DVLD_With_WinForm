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

namespace DVLD.LiecinesApplication
{
    public partial class frmNewLocalLicencs : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsPerson _Person;
        private clsLocalDrivingLicenseApplication _App;
        private enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        public frmNewLocalLicencs()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmNewLocalLicencs(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void _FillClasses()
        {
            DataTable Dt = clsLicensesClasses.GetAllClasses();

            foreach (DataRow row in Dt.Rows)
            {
                cbClasses.Items.Add(row["ClassName"]);
            }
        }

        private void _RefreshData()
        {

            _FillClasses();


            if (_Mode == enMode.AddNew)
            {
                Title.Text = "New Local Driving Licencs";
                this.Text = "New Local Driving Licencs";

                lbDate.Text = DateTime.Now.ToShortDateString();
                cbClasses.SelectedIndex = 2;
                lbUser.Text = clsUser.FindByID(CrUser.ID).UserName;
                tbAppinfo.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                Title.Text = "Update Local Driving Licencs";
                this.Text = "Update Local Driving Licencs";

                tbAppinfo.Enabled = true;
                btnSave.Enabled = true;

            }
        }

        //private void _LoadData()
        //{
        //    ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
        //    lblLocalDrivingLicebseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
        //    lblApplicationDate.Text = clsFormat.DateToShort(_LocalDrivingLicenseApplication.ApplicationDate);
        //    cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName);
        //    lblFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
        //    lblCreatedByUser.Text = clsUser.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;
        //}


        private void frmNewLocalLicencs_Load(object sender, EventArgs e)
        {
            _RefreshData();

            //if (_Mode == enMode.Update)
            //    _LoadData();

        }

  
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(ctrlPersonInfoCardWithFilter1.GetPersonID() != -1)
            {
                _Person = clsPerson.FindpersonByID(ctrlPersonInfoCardWithFilter1.GetPersonID());
                btnSave.Enabled = true;
                tbAppinfo.Enabled = true;
                tbNewApp.SelectedTab = tbNewApp.TabPages["tbAppinfo"];
            }
            else
            {
                MessageBox.Show("No person Selected");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Chesck if he have same class
            if (clsApp.IsPesronHaveSameClasslicenese(_Person.NationalNo, cbClasses.Text))
            {
                MessageBox.Show("Peson Have Same Appliction Type");
                return;
            }

            int LiceneseID = clsLicensesClasses.Find(cbClasses.Text).LicenseClassID;
            _App = new clsLocalDrivingLicenseApplication();


            //Make Obj
            _App.ApplicantPersonID = _Person.ID;
            _App.ApplicationDate = DateTime.Now;
            _App.LastStatusDate = DateTime.Now;
            _App.ApplicationTypeID = 1;
            _App.CreatedByUserID = CrUser.ID;
            _App.ApplicationStatus = clsApp.enApplicationStatus.New;
            _App.PaidFees = Convert.ToSingle(lbFees.Text);
            _App.LicenseClassID = LiceneseID;

            //Save

            if(_App.Save())
            {
                MessageBox.Show("تم حفظ الطلب");
            }
            else
            {
                MessageBox.Show("فشل للاسف");

            }


        }
    }
}
