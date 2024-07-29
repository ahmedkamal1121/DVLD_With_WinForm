using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsLicensesClasses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public float ClassFees { set; get; }


        public clsLicensesClasses() 
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 18;
            this.DefaultValidityLength = 10;
            this.ClassFees = 0;
            Mode = enMode.Update;
        }

        public clsLicensesClasses(int LicenseClassID, string ClassName,
                  string ClassDescription,
                  byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)

        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = enMode.Update;
        }


        static public DataTable GetAllClasses()
        {
            return clsAppData.GetAllClasses();
        }


        public static clsLicensesClasses Find(string ClassName)
        {
            int LicenseClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (clsLicensesClassesData.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicensesClasses(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }


        public static clsLicensesClasses FindByID(int LicenseClassID)
        {
            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (clsLicensesClassesData.GetLicenseClassInfoByID(ref ClassName, LicenseClassID, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicensesClasses(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }


    }
}
