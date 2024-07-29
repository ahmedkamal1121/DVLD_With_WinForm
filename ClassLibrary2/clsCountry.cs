using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
   public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()

        {
            this.ID = -1;
            this.CountryName = "";

            Mode = enMode.AddNew;

        }

        public clsCountry( int ID,string NAME)

        {
            this.ID = ID;
            this.CountryName = NAME;

            Mode = enMode.AddNew;

        }


        public static clsCountry Find(string Name)
        {
            int ID = -1;

            if (clsDataAccess.FindCOUNTRY(Name ,ref ID))
            {
                return new clsCountry(ID, Name);
            }
            else
            {
                return null;
            };
        }

        public static clsCountry Find(int ID)
        {
            string Name = "";

            if (clsDataAccess.FindCOUNTRYById(ref Name,  ID))
            {
                return new clsCountry(ID, Name);
            }
            else
            {
                return null;
            };
        }

        public static DataTable LoadCountries()
        {
            return clsDataAccess.LoadCountries();
        }
    }
}
