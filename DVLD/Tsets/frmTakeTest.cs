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

namespace DVLD.Tsets
{
    public partial class frmTakeTest : Form
    {
        private int _TestID;
        private int _Type;
        private int _AppliecntID;
        private int _Trial;


        public clsTest _Test;

        public frmTakeTest(int AppliecntID ,int ID,int Type,int Trial)
        {
            InitializeComponent();
            _TestID = ID;
            _Type = Type;
            _Trial = Trial;
            _AppliecntID = AppliecntID;
            _Test = new clsTest();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlShodelTestTake1.LoadData(_AppliecntID, _TestID, _Type, _Trial);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Test.TestAppointmentID = _TestID;
            _Test.TestResult = rbPass.Checked ? true : false;
            _Test.CreatedByUserID = clsLocalDrivingLicenseApplication.Find(_AppliecntID).CreatedByUserID;
            _Test.Notes = txtNotes.Text;

            if (_Test.Save())
            {
                MessageBox.Show("Done");

            }
            else
            {
                MessageBox.Show("Faild");

            }




        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ctrlShodelTestTake1_Load(object sender, EventArgs e)
        {

        }

    

      

        private void rbPass_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
