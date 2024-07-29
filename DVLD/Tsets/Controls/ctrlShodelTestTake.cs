using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD.Tsets.Controls
{
    public partial class ctrlShodelTestTake : UserControl
    {
        private int _AppomentID;
        private int _Type;
        clsLocalDrivingLicenseApplication _LocalApplication;
        clsTestAppointments _TestAppointments;
        clsTestTypes _TestType;

        public ctrlShodelTestTake()
        {
            InitializeComponent();
        }

        private void _FillData()
        {
            lbDLAPP.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lbclass.Text = clsLicensesClasses.FindByID(_LocalApplication.LicenseClassID).ClassName;
            lbappname.Text = _LocalApplication.ApplicantFullName.ToString();
            lbFees.Text = _TestType.TestTypeFees.ToString();
            lblDate.Text = _TestAppointments.AppointmentDate.ToShortDateString();   

        }

        public void LoadData(int AppliecntID, int TestID, int Type,int Trial)
        {
            _AppomentID = TestID;
            _LocalApplication = clsLocalDrivingLicenseApplication.Find(AppliecntID);
            _TestType = clsTestTypes.Find(Type);
            _TestAppointments = clsTestAppointments.Find(TestID);
            _FillData();
             lblTrial.Text = Trial.ToString();
            //_Type = Type/*;*/


        }

        private void gbTestType_Enter(object sender, EventArgs e)
        {

        }
    }
}
