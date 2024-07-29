using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsTestAppointments
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public  int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public clsApp RetakeInfo { set; get; }


        public clsTestAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;

        }

        public clsTestAppointments(int TestAppointmentID, int TestTypeID,
           int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
           int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeInfo = clsApp.Find(RetakeTestApplicationID);
            Mode = enMode.Update;
        }

        static public DataTable GetallAppmentforApplecant(int ID,int Type)
        {
            return clsTestAppointmentsData.GetallAppmentforApplecant(ID, Type);
        }

        public static clsTestAppointments Find(int TestAppointmentID)
        {
            int TestTypeID = 1; int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointmentsData.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppointments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }

        private bool _AddNewAppoinment()
        {
            this.TestAppointmentID = clsTestAppointmentsData.AddNewTestAppointment(
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,
                this.PaidFees,
                this.CreatedByUserID,
                this.RetakeTestApplicationID
                );

            return (this.TestAppointmentID != -1);
        }

        public static bool CheakIFPersonHaveSameAppoinmnentTestType(int ID,int Type)
        {
            return clsTestAppointmentsData.CheakIFPersonHaveSameAppoinmnentTestType(ID,Type);
        }

        //private bool _UpdateAppoment()
        //{

        //}

        public bool Save()
        {
            if(Mode == enMode.AddNew)
            {
                if(_AddNewAppoinment())
                {
                    return true;
                }
                else
                {
                    return false;
                };
            }

            //if (Mode == enMode.Update)
            //    return _UpdateAppoment();
            return false;
        }




    }
}
