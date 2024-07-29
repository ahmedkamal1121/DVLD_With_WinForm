using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int InternationalLicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int IssueUsingLocalLicense { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        //public int LicenseID { set; get; }
        //public clsDriver DriverInfo;
        //public clsApp ApplicationInfo;

        public clsInternationalLicense()
        {
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssueUsingLocalLicense = -1;
            this.CreatedByUserID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;

            Mode = enMode.AddNew;
        }


        public clsInternationalLicense(int ApplicationID, int DriverID ,int IssueUsingLocalLicense ,int CreatedByUserID ,DateTime IssueDate, DateTime ExpirationDate ,bool IsActive)
        {
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssueUsingLocalLicense = IssueUsingLocalLicense;
            this.CreatedByUserID = CreatedByUserID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }
     


        static public DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        static public bool ChechUserIsFound(int ID)
        {
            return clsInternationalLicenseData.ChechUserIsFound (ID);
        }

        private bool _AddNewLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNew(this.ApplicationID, this.DriverID, this.IssueUsingLocalLicense,
               this.IssueDate, this.ExpirationDate,
               this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                return _AddNewLicense();
            }

            return false;
        }
    }
}
