using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD
{
    public partial class frmAddAndEditPeople : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        clsPerson _Person;
        private enMode _Mode;
        private int _PersonID = -1;
        private enGendor _Gendor = enGendor.Male;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           _Gendor = enGendor.Male;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _Gendor = enGendor.Female;
        }

        public frmAddAndEditPeople()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddAndEditPeople(int ID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = ID;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           RefreshData();
           _FillCountries();
           cbCountry.SelectedIndex = clsCountry.Find("sudan").ID;


            if (_Mode == enMode.Update)
                LoadData();
        }

        private void _FillCountries()
        {
            DataTable Dt = clsCountry.LoadCountries();
  
            foreach (DataRow row in Dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void RefreshData()
        {


            if (_PersonID != -1)
            {
                lbTitle.Text = "Update Person";
            }
            else
            {
                _Person = new clsPerson();
            }

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            radioButton1.Checked = true;
        }

        private void LoadData() 
        {

           _Person = clsPerson.FindpersonByID(_PersonID);
            if (_Person != null)
            {
                label3.Text = _Person.ID.ToString();
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;

                if(_Person.Gendor == 0)
                {
                    radioButton1.Checked = true ;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                txtNationalNo.Text = _Person.NationalNo;
                dtpDateOfBirth.Value = _Person.DateOfBirth;
                txtPhone.Text = _Person.Phone;
                txtEmail.Text= _Person.Email;
                cbCountry.SelectedIndex = _Person.CountryID;
                txtAddress.Text= _Person.Address;

                if (_Person.ImagePath != null)
                {
                pictureBox1.ImageLocation = _Person.ImagePath;
                llRemoveImage.Visible = true;
                }
                else
                {
                    pictureBox1.ImageLocation=null;
                }
            }


        }

        //private bool _HandlePersonImage()
        //{

        //    //this procedure will handle the person image,
        //    //it will take care of deleting the old image from the folder
        //    //in case the image changed. and it will rename the new image with guid and 
        //    // place it in the images folder.


        //    //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
        //    if (_Person.ImagePath != pbPersonImage.ImageLocation)
        //    {
        //        if (_Person.ImagePath != "")
        //        {
        //            //first we delete the old image from the folder in case there is any.

        //            try
        //            {
        //                File.Delete(_Person.ImagePath);
        //            }
        //            catch (IOException)
        //            {
        //                // We could not delete the file.
        //                //log it later   
        //            }
        //        }

        //        if (pbPersonImage.ImageLocation != null)
        //        {
        //            //then we copy the new image to the image folder after we rename it
        //            string SourceImageFile = pbPersonImage.ImageLocation.ToString();

        //            if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
        //            {
        //                pbPersonImage.ImageLocation = SourceImageFile;
        //                return true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }

        //    }
        //    return true;
        //}

        //save
        private void button1_Click(object sender, EventArgs e)
        {

            //clsPerson _Person = new clsPerson();

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.CountryID = cbCountry.SelectedIndex;

         

            if(_Gendor == enGendor.Male)
            {
                _Person.Gendor = 0;
            }
            else
            {
                _Person.Gendor = 1;
            }
            
            if(pictureBox1.ImageLocation != null)
            {
                _Person.ImagePath = pictureBox1.ImageLocation;

            }



           if ( _Person.Save())
            {
                MessageBox.Show("نجاح ");

                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.ID);

            }
            else
            {
                MessageBox.Show("فشل");
            }
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = selectedFilePath;
                //pictureBox1.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = "";

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
