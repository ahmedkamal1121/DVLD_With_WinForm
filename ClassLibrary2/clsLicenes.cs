using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using static BusinessLayer.clsApp;

namespace BusinessLayer
{
    public class clsLicenes
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public clsDriver DriverInfo;
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }

        public clsApp ApplicationInfo;
        public int DriverID { set; get; }
        public int LicenseClass { set; get; }

        public clsLicensesClasses LicenseClassIfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enIssueReason IssueReason { set; get; }

        //public string IssueReasonText
        //{
        //    get
        //    {
        //        return GetIssueReasonText(this.IssueReason);
        //    }
        //}

        public clsDetainedLicense DetainedInfo { set; get; }
        public int CreatedByUserID { set; get; }

        public bool IsDetained
        {
            get { return clsDetainedLicense.IsLicenseDetained(this.LicenseID); }
        }

        public clsLicenes()

        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }

        public clsLicenes(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            float PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)

        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApp.Find(ApplicationID);
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.LicenseClassIfo = clsLicensesClasses.FindByID(LicenseClass);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.DriverInfo = clsDriver.FindByID(DriverID);

            //this.LicenseClassIfo = clsLicenseClass.Find(this.LicenseClass);
            this.DetainedInfo = clsDetainedLicense.FindByLicenseID(this.LicenseID);

            Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            //call DataAccess Layer 

            this.LicenseID = clsLicenesData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);


            return (this.LicenseID != -1);
        }

        //public int ReNewLicense()
        //{
        //    clsApp App = new clsApp();
        //    App.ApplicantPersonID = this.ApplicationInfo.ApplicantPersonID;
        //    App.ApplicationDate = DateTime.Now;
        //    App.ApplicationTypeID = 6;
        //    App.ApplicationStatus = clsApp.enApplicationStatus.Completed;
        //    App.LastStatusDate = DateTime.Now;
        //    App.PaidFees = clsApplicationType.Find(2).ApplicationFees;
        //    App.CreatedByUserID = CrUser.ID;

        //    if (!App.Save())
        //    {
        //        return -1;
        //    }

        //    clsLicenes NewLicense = new clsLicenes();
        //    NewLicense.ApplicationID = App.ApplicationID;
        //    NewLicense.DriverID = this.DriverID;
        //    NewLicense.LicenseClass = this.LicenseClass;
        //    NewLicense.IssueDate = DateTime.Now;
        //    NewLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassIfo.DefaultValidityLength);
        //    NewLicense.IsActive = true;
        //    NewLicense.IssueReason = clsLicenes.enIssueReason.Renew;
        //    NewLicense.PaidFees = clsApplicationType.Find(2).ApplicationFees;
        //    NewLicense.CreatedByUserID = this.CreatedByUserID;

        //    if (NewLicense.Save())
        //    {
        //        DeactivateCurrentLicense();
        //        return NewLicense.LicenseID;

        //    }
        //    else
        //    {
        //        return -1;
        //    }


        //}


        public clsLicenes RenewLicense(string Notes, int CreatedByUserID)
        {

            //First Create Applicaiton 
            clsApp Application = new clsApp();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApp.enApplicationType.RenewDrivingLicense;
            Application.ApplicationStatus = clsApp.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)clsApp.enApplicationType.RenewDrivingLicense).ApplicationFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
            {
                return null;
            }

            clsLicenes NewLicense = new clsLicenes();

            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;

            int DefaultValidityLength = this.LicenseClassIfo.DefaultValidityLength;

            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassIfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;


            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;
        }

        public clsLicenes Replace(enIssueReason IssueReson,int CreatedByUserID)
        {
            //Save Appliaction
            clsApp App = new clsApp();
            App.ApplicantPersonID = this.ApplicationInfo.ApplicantPersonID;
            App.ApplicationDate = DateTime.Now;

            App.ApplicationTypeID = IssueReson == enIssueReason.DamagedReplacement ? 
                (int)clsApp.enApplicationType.ReplaceDamagedDrivingLicense
              : (int)clsApp.enApplicationType.ReplaceLostDrivingLicense;

            App.ApplicationStatus = clsApp.enApplicationStatus.Completed;
            App.LastStatusDate = DateTime.Now;
            App.PaidFees = clsApplicationType.Find((int)IssueReson).ApplicationFees;
            App.CreatedByUserID = CrUser.ID;

            if (!App.Save())
            {
                return null;
            }


            clsLicenes NewLicense = new clsLicenes();
            NewLicense.ApplicationID = App.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IssueDate = this.IssueDate;
            NewLicense.ExpirationDate = this.ExpirationDate;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReson;
            NewLicense.PaidFees = clsApplicationType.Find((int)IssueReson).ApplicationFees;
            NewLicense.CreatedByUserID =CreatedByUserID;
            NewLicense.Notes = this.Notes;

            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;

        }

        public int Detaine(float FineFees, int CreatedByUserID)
        {
           

            clsDetainedLicense detainedLicense = new clsDetainedLicense();
            detainedLicense.FineFees = Convert.ToSingle(FineFees);
            detainedLicense.CreatedByUserID=CreatedByUserID;
            detainedLicense.DetainDate= DateTime.Now;
            detainedLicense.IsReleased = false;
            detainedLicense.LicenseID = this.LicenseID;

            if (!detainedLicense.Save())
            {
                return -1;
            }

            return detainedLicense.DetainID;



        }

        public int Rlease(int CreatedByUserID,int LisenseID)
        {
            //First Create Applicaiton 
            clsApp Application = new clsApp();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApp.enApplicationType.ReleaseDetainedDrivingLicsense;
            Application.ApplicationStatus = clsApp.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)clsApp.enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
            {
                return -1;
            }

            clsDetainedLicense detainedLicense = new clsDetainedLicense();
            detainedLicense = clsDetainedLicense.FindByLicenseID(LicenseID);

            if(detainedLicense == null)
            {
                MessageBox.Show("Faild");
                return -1;
            }

            detainedLicense.ReleasedByUserID = CreatedByUserID;
            detainedLicense.ReleaseApplicationID = Application.ApplicationID;

            if (!detainedLicense.Release())
            {
                MessageBox.Show("Faild");
                return -1;
            }


            return detainedLicense.ReleaseApplicationID;


        }

        public bool DeactivateCurrentLicense()
        {
            return (clsLicenesData.DeactivateLicense(this.LicenseID));
        }

        public bool Save()
        {
            return _AddNewLicense();
        }

        public static clsLicenes Find(int ApplicationID)
        {
            int LicenseID = -1; int DriverID = -1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = 0; bool IsActive = true; int CreatedByUserID = 1;
            byte IssueReason = 1;
            if (clsLicenesData.GetLicenseInfoByID(ref LicenseID,  ApplicationID, ref DriverID, ref LicenseClass,
            ref IssueDate, ref ExpirationDate, ref Notes,
            ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new clsLicenes(LicenseID, ApplicationID, DriverID, LicenseClass,
                                     IssueDate, ExpirationDate, Notes,
                                     PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;

        }

        public static clsLicenes FindByLicenseID(int LicenseID)
        {
            int ApplicationID = -1; int DriverID = -1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = 0; bool IsActive = true; int CreatedByUserID = 1;
            byte IssueReason = 1;
            if (clsLicenesData.GetLicenseInfoByLicenseID( LicenseID,ref ApplicationID, ref DriverID, ref LicenseClass,
            ref IssueDate, ref ExpirationDate, ref Notes,
            ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new clsLicenes(LicenseID, ApplicationID, DriverID, LicenseClass,
                                     IssueDate, ExpirationDate, Notes,
                                     PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;

        }

        public static bool UnActiveLicense(int ID)
        {
            return clsLicenesData.UnActiveLicense(ID);
        }

    }
}
