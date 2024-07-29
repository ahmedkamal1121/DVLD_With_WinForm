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

namespace DVLD.Licenses
{
    public partial class frmPersonLicenseHistory : Form
    {
        private clsDriver _Driver;
 

        public frmPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _Driver = clsDriver.IsFound(PersonID);
        }

      

        private void frmPersonLicenseHistory_Load(object sender, EventArgs e)
        {

            ctrlPersonInfoCardWithFilter1.LoadData(_Driver.PersonID);
            ctrlLincenseCategory1.LoadData(_Driver.DriverID);
        }
    }
}
