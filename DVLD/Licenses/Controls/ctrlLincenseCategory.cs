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

namespace DVLD.Licenses.Controls
{
    public partial class ctrlLincenseCategory : UserControl
    {

        private int _DriverID;
        public ctrlLincenseCategory()
        {
            InitializeComponent();
        }

        public void LoadData(int ID)
        {
            //_DriverID = ID;
            dgvLocalLicensesHistory.DataSource = clsDriver.GetAllLicenseByDriverID(ID);
            dgvInternationalLicensesHistory.DataSource = clsDriver.GetAllInternatinalLicenseByDriverID(ID);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
