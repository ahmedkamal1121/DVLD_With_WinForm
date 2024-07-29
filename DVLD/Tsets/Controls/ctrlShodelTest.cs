using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DVLD.Properties;

namespace DVLD.Tsets.Controls
{
    public partial class ctrlShodelTest : UserControl
    {


         private int _ID;
         private int _Type;
         private int _Trial;
        
         clsLocalDrivingLicenseApplication _LocalApplication;
         clsTestAppointments _TestAppointments;
         clsTestTypes _TestType;
        public ctrlShodelTest()
        {
            InitializeComponent();
        }

        private void _ResetForm()
        {
            if (_Type == 1)
            {

                pbTestTypeImage.Image = Resources.Vision_512;

            }
            else if (_Type ==2)
            {

                pbTestTypeImage.Image = Resources.Written_Test_512;
            }
            else
            {

                pbTestTypeImage.Image = Resources.Street_Test_32;
            }
        }

        private void _FillData()
        {
            lbDLAPP.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lbclass.Text = clsLicensesClasses.FindByID(_LocalApplication.LicenseClassID).ClassName;
            lbappname.Text = _LocalApplication.ApplicantFullName.ToString();
            lbFees.Text = _TestType.TestTypeFees.ToString();
            lblTrial.Text = _Trial.ToString();
            lblRetakeAppFees.Text = "5";
            lblTotalFees.Text = (5 + _TestType.TestTypeFees).ToString();


        }

        public void LoadData(int ID, int Type, int Trial)
        {
            _ID = ID;
            _Type = Type;
            _Trial = Trial;
            _LocalApplication = clsLocalDrivingLicenseApplication.Find(ID);
            _TestType=clsTestTypes.Find(_Type);
            _ResetForm();
            _FillData();
            gbRetakeTestInfo.Enabled = (_Trial > 0);

            dtpTestDate.Value = DateTime.Now;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // if dont Have Past Tesst
            _TestAppointments = new clsTestAppointments();
            _TestAppointments.TestTypeID = _TestType.TestTypeID;
            _TestAppointments.LocalDrivingLicenseApplicationID = _ID;
            _TestAppointments.AppointmentDate = dtpTestDate.Value;
            _TestAppointments.PaidFees = _TestType.TestTypeFees;
            _TestAppointments.CreatedByUserID = _LocalApplication.CreatedByUserID;

            if(_Trial > 0)
            {
                clsApp Retake = new clsApp();
                Retake.ApplicantPersonID = _LocalApplication.ApplicantPersonID;
                Retake.ApplicationDate = DateTime.Now;
                Retake.LastStatusDate = DateTime.Now;
                Retake.PaidFees = 5;  
                Retake.ApplicationTypeID = 7;
                Retake.CreatedByUserID = _LocalApplication.CreatedByUserID;

        _TestAppointments.RetakeTestApplicationID = Retake.Save() ? Retake.ApplicationID : -1;



                lblRetakeTestAppID.Text = _TestAppointments.RetakeTestApplicationID.ToString();

            }
            else
            {
                _TestAppointments.RetakeTestApplicationID = -1;

            }


            if (_TestAppointments.Save())
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("Faild");

            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblLocalDrivingLicenseAppID_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void lblDrivingClass_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTrial_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void dtpTestDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblFees_Click(object sender, EventArgs e)
        {

        }

        private void ctrlShodelTest_Load(object sender, EventArgs e)
        {

        }

        private void pbTestTypeImage_Click(object sender, EventArgs e)
        {

        }

    
    }
}
