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
using DVLD.Licenses;
using DVLD.LiecinesApplication.Local_Driving_License;
using DVLD.Tsets;

namespace DVLD.LiecinesApplication
{
    public partial class frmListApplications : Form
    {
        public frmListApplications()
        {
            InitializeComponent();
        }

        private void frmListApplications_Load(object sender, EventArgs e)
        {
            dvgAppList.DataSource = clsApp.GetAllApps();
            if (dvgAppList.Rows.Count > 0)
            {

                dvgAppList.Columns[0].HeaderText = "L.D.L.AppID";
                dvgAppList.Columns[0].Width = 80;

                dvgAppList.Columns[1].HeaderText = "Driving Class";
                dvgAppList.Columns[1].Width = 230;

                dvgAppList.Columns[2].HeaderText = "National No.";
                dvgAppList.Columns[2].Width = 90;

                dvgAppList.Columns[3].HeaderText = "Full Name";
                dvgAppList.Columns[3].Width = 250;

                dvgAppList.Columns[4].HeaderText = "Application Date";
                dvgAppList.Columns[4].Width = 200;

                dvgAppList.Columns[5].HeaderText = "Pass Test";
                dvgAppList.Columns[5].Width = 30;

                dvgAppList.Columns[5].HeaderText = "Status";
                dvgAppList.Columns[5].Width = 50;

            }
        }

   
        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmNewLocalLicencs frm = new frmNewLocalLicencs();
            frm.ShowDialog();

            dvgAppList.DataSource = clsApp.GetAllApps();
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
          
            int ID = (int)dvgAppList.CurrentRow.Cells[0].Value;

            clsStatusAndPassed obj = clsStatusAndPassed.CheckStatusAndTest(ID);

            if (obj.Status == "New")
            {
                ScheduleTestsMenue.Enabled = true;
                CancelApplicaitonToolStripMenuItem.Enabled = true;
                DeleteApplicationToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled =false;


                if (obj.PassedTestCount == 0)
                {
                    scheduleVisionTestToolStripMenuItem.Enabled = true;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

                }
                else if (obj.PassedTestCount == 1)
                {
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = true;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

                }
                else if (obj.PassedTestCount == 2)
                {
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

                }
                else
                {
                    ScheduleTestsMenue.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled=true;
                }


            }
            else
             if (obj.Status == "Completed")
            {
                ScheduleTestsMenue.Enabled = false;
                CancelApplicaitonToolStripMenuItem.Enabled=false;
                DeleteApplicationToolStripMenuItem.Enabled=false;
                toolStripMenuItem1.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;


            }
            else
            {
                ScheduleTestsMenue.Enabled = false;
                CancelApplicaitonToolStripMenuItem.Enabled = false;
                DeleteApplicationToolStripMenuItem.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;


            }

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vision
            frmShedoulTestList frm = new frmShedoulTestList((int)dvgAppList.CurrentRow.Cells[0].Value,1);
            frm.ShowDialog();
            dvgAppList.DataSource = clsApp.GetAllApps();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Wiretter
            frmShedoulTestList frm = new frmShedoulTestList((int)dvgAppList.CurrentRow.Cells[0].Value, 2);
            frm.ShowDialog();
            dvgAppList.DataSource = clsApp.GetAllApps();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Street
            frmShedoulTestList frm = new frmShedoulTestList((int)dvgAppList.CurrentRow.Cells[0].Value, 3);
            frm.ShowDialog();
            dvgAppList.DataSource = clsApp.GetAllApps();

        }
      
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationInfo frm = new frmApplicationInfo((int)dvgAppList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void ScheduleTestsMenue_Click(object sender, EventArgs e)
        {

        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueLinecenseForTheFirstTime frm = new frmIssueLinecenseForTheFirstTime((int)dvgAppList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            dvgAppList.DataSource = clsApp.GetAllApps();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLincensesInfo frm = new frmShowLincensesInfo((int)dvgAppList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("Are you sure you want to Cancel app [" + dvgAppList.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int ID = clsLocalDrivingLicenseApplication.Find((int)dvgAppList.CurrentRow.Cells[0].Value).ApplicationID;
                if (clsApp.ChangeStatus(ID, 2))
                {
                    MessageBox.Show(" Canceled");
                    dvgAppList.DataSource = clsApp.GetAllApps();

                }
                else
                {
                    MessageBox.Show("Faild");
                }

            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsLocalDrivingLicenseApplication.Find((int)dvgAppList.CurrentRow.Cells[0].Value).PersonInfo.ID;
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }
    }
}
