using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD.LiecinesApplication.ApplicationType
{
    public partial class frmUpdateApp : Form
    {
        private int _ID;
        private clsApplicationType _AppType;

        public frmUpdateApp(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmUpdateApp_Load(object sender, EventArgs e)
        {
            _AppType = clsApplicationType.Find(_ID);
            lbID.Text = _ID.ToString();
            txTitle.Text = _AppType.ApplicationTypeTitle;
            txFees.Text =_AppType.ApplicationFees.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _AppType.ApplicationTypeID = _ID;
            _AppType.ApplicationTypeTitle = txTitle.Text;
            _AppType.ApplicationFees=Convert.ToSingle(txFees.Text);

            if (_AppType.Update())
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("faild");
            }

        }
    }
}
