using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsTest
    {
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public int CreatedByUserID { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }

        clsTestAppointments TestAppointmentInfo { set; get; }

        public clsTest()

        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

            //Mode = enMode.AddNew;

        }

        public clsTest(int TestID, int TestAppointmentID,
            bool TestResult, string Notes, int CreatedByUserID)

        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestAppointmentInfo = clsTestAppointments.Find(TestAppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            //Mode = enMode.Update;
        }


        private bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return (this.TestID != -1);
        }

        public bool Save()
        {
          return _AddNewTest();
        }

        static public bool IspersonPassedBefor( int LocalApplicationID, int Type)
        {
        
            return clsTestData.IspersonPassedBefor(LocalApplicationID, Type);

        }


    }
}
