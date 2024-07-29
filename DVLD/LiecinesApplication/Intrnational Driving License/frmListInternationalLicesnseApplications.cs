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

namespace DVLD.LiecinesApplication.Intrnational_Driving_License
{
    public partial class frmListInternationalLicesnseApplications : Form
    {
        public frmListInternationalLicesnseApplications()
        {
            InitializeComponent();
        }

        private void frmListInternationalLicesnseApplications_Load(object sender, EventArgs e)
        {
            dgvInternationalLicenses.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
        }
    }
}
