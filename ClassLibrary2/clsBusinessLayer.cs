using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsBusinessLayer
    {
    

        public static DataTable GetAllPeopleWithFilter(string Filter = "", string serech = "")
        {
            return clsDataAccess.GetAllPeopleWithFilter(Filter, serech);
        }

        public static bool chickNoIsFound(string NO)
        {
            return clsDataAccess.chickNoIsFound(NO);
        }

     

     

    }
}
