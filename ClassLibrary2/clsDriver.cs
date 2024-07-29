using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsDriver
    {
        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonIfon { set; get; }
        public DateTime CreatedDate { set; get; }
        public int CreatedByUserID { set; get; }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
        }

        public clsDriver(int DriverID,int PersonID ,int CreatedByUserID,DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.PersonIfon = clsPerson.FindpersonByID(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }

        static public clsDriver IsFound(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverData.FindByPersonID(ref DriverID, PersonID,ref  CreatedByUserID,ref  CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }

          
        }

        static public clsDriver FindByID(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverData.FindByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }


        }



        private bool _AddNewDriver()
        {
            return clsDriverData.AddnewDriver(this.PersonID,this.CreatedByUserID, this.CreatedDate);
        }

        public bool Save()
        {
            return _AddNewDriver();
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetallDrivers();
        }

        public static DataTable GetAllLicenseByDriverID(int ID)
        {
            return clsLicenesData.GetAllLicenseByDriverID(ID);
        }

        public static DataTable GetAllInternatinalLicenseByDriverID(int ID)
        {
            return clsLicenesData.GetAllInternatinalLicenseByDriverID(ID);
        }

    }
}
