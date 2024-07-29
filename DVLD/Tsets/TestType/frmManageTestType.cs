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
//using ClassLibrary2;

namespace DVLD.Manage
{
    public partial class frmManageTestType : Form
    {
        public frmManageTestType()
        {
            InitializeComponent();
        }

        private void frmManageTestType_Load(object sender, EventArgs e)
        {
            dvgTest.DataSource = clsTestTypes.GetAllTestType();

            dvgTest.Columns[0].HeaderText = "ID";
            dvgTest.Columns[0].Width = 50;

            dvgTest.Columns[1].HeaderText = "Title";
            dvgTest.Columns[1].Width = 180;

            dvgTest.Columns[2].HeaderText = "Des";
            dvgTest.Columns[2].Width = 280;

            dvgTest.Columns[3].HeaderText = "Fees";
            dvgTest.Columns[3].Width = 150;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTest frm = new frmUpdateTest((int)dvgTest.CurrentRow.Cells[0].Value);
            frm.ShowDialog();


            dvgTest.DataSource = clsTestTypes.GetAllTestType();


        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
