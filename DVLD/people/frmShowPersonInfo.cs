using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.people
{
    public partial class frmShowPersonInfo : Form
    {
        int PersonID;
        public frmShowPersonInfo()
        {
            InitializeComponent();
        }

        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            PersonID = personID;
        }



        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInfoCard1.LoadPersonInfo(PersonID);
        }
    }
}
