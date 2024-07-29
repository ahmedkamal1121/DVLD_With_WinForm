using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1;
using DataAccess;

namespace BusinessLayer
{
    public class clsApplicationType
    {

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public float ApplicationFees { get; set; }

        clsApplicationType()
        {

            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;

        }

        clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
        {

            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;

        }

        static public DataTable GetAllApplicationType()
        {
            return clsApplicationTypeData.GetAllApplicationType();
        }

        static public clsApplicationType Find(int ID)
        {

            int ApplicationTypeID = ID;
            string ApplicationTypeTitle = "";
            float ApplicationFees = 0;

            if (clsApplicationTypeData.FindByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else
            {
                return null;
            }
        }

         public bool Update()
        {
            return clsApplicationTypeData.UpdateAppType(this.ApplicationTypeID,this.ApplicationTypeTitle,this.ApplicationFees);
        }

    

    }
}
