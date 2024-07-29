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
using DVLD.Properties;

namespace DVLD.Tsets
{
    public partial class frmShedoulTestList : Form
    {
        private DataTable _Data;
        private int _Trial;
        private int _LocalApplicationID;

        enum enType { Vision = 1 , Writr = 2 , Street = 3 }
        enType _Type;

        public frmShedoulTestList(int ID, int Type)
        {
            InitializeComponent();
            _LocalApplicationID = ID;
            _Type = (enType)Type;
        }

        private void _ResetForm()
        {
           if(_Type == enType.Vision)
            {
                lbTitle.Text = "Vision Test Appointments";
                pbTestTypeImage.Image = Resources.Vision_512;

            }else if (_Type == enType.Writr)
            {
                lbTitle.Text = "Writter Test Appointments";
                pbTestTypeImage.Image = Resources.Written_Test_512;
            }
            else
            {
                lbTitle.Text = "Street Test Appointments";
                pbTestTypeImage.Image = Resources.Street_Test_32;
            }
        }


        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            _ResetForm();
            ctrlApplicationInfo1.LoadData(_LocalApplicationID);
            _Data = clsTestAppointments.GetallAppmentforApplecant(_LocalApplicationID, (int)_Type);
            _Trial = _Data.Rows.Count;
            dvgAppoinments.DataSource = _Data;
        }

        //Add Appoiment
        private void Add_Click(object sender, EventArgs e)
        {
    

          if(clsTestAppointments.CheakIFPersonHaveSameAppoinmnentTestType(_LocalApplicationID, (int)_Type))
            {
                MessageBox.Show("Person Has Active Test Appoiment ");
            }
            else
            {
                if (clsTest.IspersonPassedBefor(_LocalApplicationID, (int)_Type))
                {
                    MessageBox.Show("You Can not take this test Already Pased");

                }
                else
                {
                    frmSheodleTest frm = new frmSheodleTest(_LocalApplicationID, (int)_Type, _Trial);
                    frm.ShowDialog();
                    dvgAppoinments.DataSource = clsTestAppointments.GetallAppmentforApplecant(_LocalApplicationID, (int)_Type);
                }
              
                
            }

           
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int _TestAppoinment = (int)dvgAppoinments.CurrentRow.Cells[0].Value;

            if (clsTestAppointments.Find(_TestAppoinment).IsLocked)
            {
                MessageBox.Show("Test is Locked");
            }
            else
            {
                frmTakeTest frm = new frmTakeTest(_LocalApplicationID, _TestAppoinment, (int)_Type, _Trial);
                frm.ShowDialog();
                dvgAppoinments.DataSource = clsTestAppointments.GetallAppmentforApplecant(_LocalApplicationID, (int)_Type);
                ctrlApplicationInfo1.LoadData(_LocalApplicationID);
            }
        
        }

        private void ctrlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
