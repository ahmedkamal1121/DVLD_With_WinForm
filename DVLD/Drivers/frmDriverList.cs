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
using DVLD.people;

namespace DVLD.Drivers
{
    public partial class frmDriverList : Form
    {
        public frmDriverList()
        {
            InitializeComponent();
        }

        private void frmDriverList_Load(object sender, EventArgs e)
        {
            dgvDrivers.DataSource = clsDriver.GetAllDrivers();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
