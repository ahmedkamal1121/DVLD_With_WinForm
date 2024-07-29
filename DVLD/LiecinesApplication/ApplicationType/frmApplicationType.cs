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

namespace DVLD.LiecinesApplication.ApplicationType
{
    public partial class frmApplicationType : Form
    {
        public frmApplicationType()
        {
            InitializeComponent();
        }

        private void frmApplicationType_Load(object sender, EventArgs e)
        {
            dvgApp.DataSource = clsApplicationType.GetAllApplicationType();

            dvgApp.Columns[0].HeaderText = "ID";
            dvgApp.Columns[0].Width = 50;

            dvgApp.Columns[1].HeaderText = "Title";
            dvgApp.Columns[1].Width = 380;

            dvgApp.Columns[2].HeaderText = "Fees";
            dvgApp.Columns[2].Width = 150;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmUpdateApp frm = new frmUpdateApp((int)dvgApp.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            dvgApp.DataSource = clsApplicationType.GetAllApplicationType();
        }
    }
}
