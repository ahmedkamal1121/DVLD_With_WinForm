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
    public partial class frmDetainList : Form
    {
        DataTable dt;
        public frmDetainList()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmDetainList_Load(object sender, EventArgs e)
        {
            dt = clsDetainedLicense.GetAllDetainLisecse();
            dgvDetainedLicenses.DataSource = dt;
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmRlease frm = new frmRlease();
            frm.ShowDialog();
            dgvDetainedLicenses.DataSource = dt;

        }
    }
}
