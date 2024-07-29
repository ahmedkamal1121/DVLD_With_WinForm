using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.LiecinesApplication.Local_Driving_License
{
    public partial class frmApplicationInfo : Form
    {
        private int _ID;
        public frmApplicationInfo(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.LoadData(_ID);
        }
    }
}
