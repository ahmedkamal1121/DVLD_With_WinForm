using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;

namespace DVLD.Tsets
{
    public partial class frmSheodleTest : Form
    {
  
        int _Type;
        int _Trial;
        private int _LocalApplicationID;

        public frmSheodleTest(int ID, int Type, int trial)
        {
            InitializeComponent();
            _LocalApplicationID = ID;
            _Type = Type;
            _Trial = trial;
        }

        private void frmSheodleTest_Load(object sender, EventArgs e)
        {
            ctrlShodelTest1.LoadData(_LocalApplicationID, _Type,_Trial);

        }


    }
}
