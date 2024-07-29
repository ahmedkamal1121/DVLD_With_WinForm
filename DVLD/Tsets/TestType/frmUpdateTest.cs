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

namespace DVLD.Manage
{
    public partial class frmUpdateTest : Form
    {
        private int _ID ;
        clsTestTypes _TestTypes ;
        public frmUpdateTest(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmUpdateTest_Load(object sender, EventArgs e)
        {

            _TestTypes = clsTestTypes.Find(_ID);
            lbID.Text = _ID.ToString();
            txTitle.Text =  _TestTypes.TestTypeDes;
            txDes.Text = _TestTypes.TestTypeTitle;
            txFees.Text = _TestTypes.TestTypeFees.ToString();

        }

        //Save
        private void button1_Click(object sender, EventArgs e)
        {
            _TestTypes.TestTypeTitle = txTitle.Text;
            _TestTypes.TestTypeDes = txDes.Text;
            _TestTypes.TestTypeFees = Convert.ToSingle(txFees.Text.Trim());

            if (_TestTypes.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
