using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApp
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }

        public clsLicensesClasses LicenseClassInfo;
        public string PersonFullName
        {
            get
            {
                return clsPerson.FindpersonByID(ApplicantPersonID).FullName;
            }

        }



        public clsLocalDrivingLicenseApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            ////
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;


        }

        clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.ApplicationID = ApplicationID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicensesClasses.FindByID(LicenseClassID);
            Mode = enMode.Update;
        }

        clsLocalDrivingLicenseApplication(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int LocalDrivingLicenseApplicationID, int LicenseClassID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.FindpersonByID(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByID(CreatedByUserID);
            ////
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicensesClasses.FindByID(LicenseClassID);

            Mode = enMode.Update;
        }

        //clsApp
        private bool _AddNewAplication()
        {

            this.ApplicationID = clsAppData.AddNewApplication(
                this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (byte)this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        private bool _AddNewLocalApp()
        {
            this.LocalDrivingLicenseApplicationID =
                clsLocalDrivingLicenseApplicationData.AddNewLocalApp(this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        public void SetComplate()
        {
            clsAppData.ChangeStatus(this.ApplicationID, 3);
        }

        public void Cancel()
        {
            clsAppData.ChangeStatus(this.ApplicationID, 2);
        }


        public int IssueLinecenseForTheFirstTime(int CreatedByUserID, string Notes)
        {
            int DriverID = -1;

            clsDriver driver = clsDriver.IsFound(this.ApplicantPersonID);

            if(driver == null)
            {
                driver = new clsDriver();
                driver.CreatedDate = DateTime.Now;
                driver.CreatedByUserID = CreatedByUserID;
                driver.PersonID = this.ApplicantPersonID;

                if (driver.Save())
                {
                    DriverID = driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = driver.DriverID;

            }


            clsLicenes licenes = new clsLicenes();

            licenes.ApplicationID = this.ApplicationID;
            licenes.LicenseClass = this.LicenseClassID;
            licenes.DriverID = DriverID;
            licenes.IssueDate = DateTime.Now;
            licenes.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            licenes.Notes = Notes;
            licenes.PaidFees = this.ApplicationTypeInfo.ApplicationFees;
            licenes.CreatedByUserID = CreatedByUserID;
            licenes.IsActive = true;
            licenes.IssueReason = clsLicenes.enIssueReason.FirstTime;


            if (licenes.Save())
            {
                this.SetComplate();
                return licenes.LicenseID;

            }
            else
            {
                return -1;
            }


        }

        static public clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 1;
            DateTime  LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int  CreatedByUserID = -1;
            int LicenseClassID=-1;

            bool isFound = clsLocalDrivingLicenseApplicationData.Find(LocalDrivingLicenseApplicationID, ref ApplicationID,  ref  LicenseClassID);
           
            if(isFound)
            {
                //call Data Access
             if( clsAppData.Find(ApplicationID, ref  ApplicantPersonID,
                   ref  ApplicationDate, ref  ApplicationTypeID,
                   ref  ApplicationStatus, ref  LastStatusDate,
                     ref  PaidFees, ref  CreatedByUserID))
                {
                    return  new clsLocalDrivingLicenseApplication(
                        ApplicationID, 
                        ApplicantPersonID,
                        ApplicationDate,  
                        ApplicationTypeID,
                        (enApplicationStatus)ApplicationStatus,
                        LastStatusDate,
                        PaidFees,
                        CreatedByUserID,
                        LocalDrivingLicenseApplicationID,
                        LicenseClassID);

                }
            }
            else
            {
                return null;
            }

            return null;

        }

        static public clsLocalDrivingLicenseApplication FindJustLocal(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            bool isFound = clsLocalDrivingLicenseApplicationData.Find(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

            if (isFound)
            {
        
                    return new clsLocalDrivingLicenseApplication(
                        LocalDrivingLicenseApplicationID,
                        ApplicationID,
                        LicenseClassID);

            }
            else
            {
                return null;
            }

            return null;

        }

        static public clsLocalDrivingLicenseApplication FindByAppID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1, ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            int LicenseClassID = -1;

            bool isFound = clsLocalDrivingLicenseApplicationData.FindByAppID(ref LocalDrivingLicenseApplicationID,  ApplicationID, ref LicenseClassID);

            if (isFound)
            {
                //call Data Access
                if (clsAppData.Find(ApplicationID, ref ApplicantPersonID,
                      ref ApplicationDate, ref ApplicationTypeID,
                      ref ApplicationStatus, ref LastStatusDate,
                        ref PaidFees, ref CreatedByUserID))
                {
                    return new clsLocalDrivingLicenseApplication(
                        ApplicationID,
                        ApplicantPersonID,
                        ApplicationDate,
                        ApplicationTypeID,
                        (enApplicationStatus)ApplicationStatus,
                        LastStatusDate,
                        PaidFees,
                        CreatedByUserID,
                        LocalDrivingLicenseApplicationID,
                        LicenseClassID);

                }
            }
            else
            {
                return null;
            }

            return null;

        }


        public bool Save()
        {
            ////Save in Genral App
            //if (_AddNewAplication())
            //{
            //    //Save in Local App
            //   return _AddNewLocalApp();
            //}

            //return false;


            base.Mode = (clsApp.enMode)Mode;
            if (!base.Save())
                return false;

            //After we save the main application now we save the sub application.
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalApp())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return false;

                    //return _UpdateLocalDrivingLicenseApplication();

            }

            return false;

        }

    }
}
