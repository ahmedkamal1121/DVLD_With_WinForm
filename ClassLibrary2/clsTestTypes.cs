using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDes { get; set; }
        public float TestTypeFees { get; set; }

        clsTestTypes()
        {
            this.TestTypeDes = "";
            this.TestTypeID = -1;
            this.TestTypeTitle = "";
            this.TestTypeFees = 0;

         }

        clsTestTypes(int TestTypeID, string TestTypeDes, string TestTypeTitle, float TestTypeFees)
        {
            this.TestTypeDes = TestTypeDes;
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeFees = TestTypeFees;

        }

        static public DataTable GetAllTestType()
        {
            return clsTestTypesData.GetAllTestType();
        }

        static public clsTestTypes Find(int ID)
        {
            string TestTypeDes = "";
            int  TestTypeID = ID;
            string TestTypeTitle = "";
            float  TestTypeFees = 0;

            if (clsTestTypesData.FindByID(TestTypeID, ref TestTypeTitle, ref TestTypeDes,ref TestTypeFees))
            {
                return new clsTestTypes(TestTypeID, TestTypeDes, TestTypeTitle,TestTypeFees);
            }
            else
            {
                return null;
            }
        }

        static public bool Update(int TestTypeID, string Title, string Description, float Fees)
        {
            return clsTestTypesData.UpdateTestType(TestTypeID, Title, Description, Fees);
        }


        public bool Save()
        {

         return Update(this.TestTypeID, this.TestTypeTitle, this.TestTypeDes, this.TestTypeFees);

        }

    }
}
