using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusinessLayer
{
    public class clsApp
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public enMode Mode = enMode.AddNew;

        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }

        public clsPerson PersonInfo;

        public string ApplicantFullName
        {
            get
            {
                return clsPerson.FindpersonByID(ApplicantPersonID).FullName;
            }
        }

        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { get; set; }

        public clsApplicationType ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {

                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo;

        public clsApp()

        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }

        public clsApp(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID)

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
            Mode = enMode.Update;
        }


        static public DataTable GetAllApps()
        {
            return clsAppData.GetAllApps();
        }

         private bool _AddNewAplication()
        {

            this.ApplicationID = clsAppData.AddNewApplication(
                this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (byte)this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        public bool Save()
        {
            return _AddNewAplication();
           
        }

        static public clsApp Find(int ApplicationID)
        {
          int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;

            if (clsAppData.Find(ApplicationID, ref ApplicantPersonID,
                   ref ApplicationDate, ref ApplicationTypeID,
                   ref ApplicationStatus, ref LastStatusDate,
                     ref PaidFees, ref CreatedByUserID))
            {

                return new clsApp(ApplicationID, ApplicantPersonID,
                         ApplicationDate, ApplicationTypeID,
                          (enApplicationStatus)ApplicationStatus, LastStatusDate,
                          PaidFees, CreatedByUserID);


            }
            else
            {
                return null;
            }
        }

        static public bool IsPesronHaveSameClasslicenese(string NationalNo, string cbClasses)
        {
            return clsAppData.IsPesronHaveSameClasslicenese(NationalNo, cbClasses);
        }


        static public bool ChangeStatus(int ApplicationID, int Status)
        {
            return clsAppData.ChangeStatus(ApplicationID, Status);
        }





    }
}
