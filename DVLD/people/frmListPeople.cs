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
using DVLD.people;

namespace DVLD
{
    public partial class ManagePeople : Form
    {


        public ManagePeople()
        {
            InitializeComponent();
        }

        public string FilterType = "";

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GendorCaption", "DateOfBirth", "CountryName",
                                                         "Phone", "Email");
        public void FillFilterCb()
        {
            cbFilter.Items.Add("None");
            cbFilter.Items.Add("National No.");
            cbFilter.Items.Add("First Name");
            cbFilter.Items.Add("Second Name");
            cbFilter.Items.Add("ThirdName");
            cbFilter.Items.Add("LastName");
            cbFilter.Items.Add("Gendor");
            cbFilter.Items.Add("NationalityCountryID");
        }
        public void RefreshData()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dataGridView1.DataSource = _dtPeople;
            //lblRecordsCount.Text = dataGridView1.Rows.Count.ToString();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //RefreshData();
            FillFilterCb();
            dataGridView1.DataSource = _dtPeople;
            cbFilter.SelectedIndex = 0;
            //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

            dataGridView1.Columns[0].HeaderText = "Person ID";
            dataGridView1.Columns[0].Width = 90;

            dataGridView1.Columns[1].HeaderText = "National No.";
            dataGridView1.Columns[1].Width = 100;


            dataGridView1.Columns[2].HeaderText = "First Name";
            dataGridView1.Columns[2].Width = 120;

            dataGridView1.Columns[3].HeaderText = "Second Name";
            dataGridView1.Columns[3].Width = 140;


            dataGridView1.Columns[4].HeaderText = "Third Name";
            dataGridView1.Columns[4].Width = 120;

            dataGridView1.Columns[5].HeaderText = "Last Name";
            dataGridView1.Columns[5].Width = 120;

            dataGridView1.Columns[6].HeaderText = "Date Of Birth";
            dataGridView1.Columns[6].Width = 120;

            dataGridView1.Columns[7].HeaderText = "Gendor";
            dataGridView1.Columns[7].Width = 70;

            dataGridView1.Columns[8].HeaderText = "Address";
            dataGridView1.Columns[8].Width = 120;


            dataGridView1.Columns[9].HeaderText = "Phone";
            dataGridView1.Columns[9].Width = 120;


            dataGridView1.Columns[10].HeaderText = "Email";
            dataGridView1.Columns[10].Width = 170;
            FillFilterCb();

        }

        private void txSerche_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.

            if (txSerche.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSerche.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txSerche.Text.Trim());

            //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
            dataGridView1.DataSource = _dtPeople;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddAndEditPeople frm = new frmAddAndEditPeople();
            frm.ShowDialog();

            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text != "None")
            {
            txSerche.Visible = true;
            FilterType = cbFilter.Text;
            }
            else
            {
                txSerche.Visible = false;
                FilterType = "";
            }
            
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddAndEditPeople frm = new frmAddAndEditPeople((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            RefreshData();
        }

        private void deletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dataGridView1.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsPerson.Delete((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("نجح المسح");
                }
                else
                {
                    MessageBox.Show("فشل");
                }

            }
            RefreshData();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }


        //
        private void txSerche_KeyUp(object sender, KeyEventArgs e)
        {
            //RefreshData(FilterType, txSerche.Text);
        }


      
        private void txSerche_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilter.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
