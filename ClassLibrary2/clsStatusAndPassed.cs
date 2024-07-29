using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusinessLayer
{
    public class clsStatusAndPassed
    {
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int PassedTestCount { set; get; }
        public string Status { set; get; }

        clsStatusAndPassed(int LocalDrivingLicenseApplicationID, int PassedTestCount,string Status)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.PassedTestCount = PassedTestCount;
            this.Status = Status;
        }

        static public clsStatusAndPassed CheckStatusAndTest(int LocalDrivingLicenseApplicationID)
        {
            int PassedTestCount = -1;
            string Status = "";

            if (clsLocalDrivingLicenseApplicationData.CheckStatusAndTest(LocalDrivingLicenseApplicationID,ref Status, ref PassedTestCount))
            {
                return new clsStatusAndPassed(LocalDrivingLicenseApplicationID,PassedTestCount,Status);
            }
            else
            {
                return null;
            }
        }
    }
}
