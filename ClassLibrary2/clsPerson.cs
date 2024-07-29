using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public string NationalNo { set; get; }
        public short Gendor { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string ImagePath { set; get; }
        public int CountryID { set; get; }

        public clsPerson()

        {
            this.ID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.NationalNo = "";
            this.Gendor = -1;
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
             string LastName, string NationalNo, DateTime DateOfBirth, short Gendor,
             string Address, string Phone, string Email, string ImagePath,int CountryID)

        {
            this.ID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;
            this.CountryID = CountryID;
            Mode = enMode.Update;
        }


        public static DataTable GetAllPeople(string Filter = "", string serech = "")
        {
            return clsDataAccess.GetAllPeople(Filter, serech);
        }

        public bool _AddNewContact()
        {
            this.ID = clsPersonData2.AddNewPerson(
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.NationalNo,
                this.DateOfBirth,
                this.Gendor,
                this.Address,
                this.Phone,
                this.Email,
               this.CountryID,
               this.ImagePath);

            return (this.ID != -1);
        }

        public bool _UpdateContact()
        {
            return clsPersonData2.UpdateContact(
                this.ID,
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.NationalNo,
                this.DateOfBirth,
                this.Gendor,
                this.Address,
                this.Phone,
                this.Email,
               this.CountryID,
               this.ImagePath);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateContact();




            }

            return false;
        }

        public static clsPerson FindpersonByID(int ID)
        {


            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData2.GetPersonInfoByID
                                (
                                    ID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth,
                                    ref Gendor, ref Address, ref Phone, ref Email
                                    , ref ImagePath, ref CountryID
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPerson(ID, FirstName, SecondName, ThirdName, LastName,
                          NationalNo, DateOfBirth, Gendor, Address, Phone, Email, ImagePath, CountryID);
            else
                return null;
        }


        public static clsPerson FindpersonByNo(string NoNationalNo)
        {


            int ID = -1; string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData2.GetPersonInfoByNo
                                (
                                   ref ID, ref FirstName, ref SecondName,
                                    ref ThirdName, ref LastName, NoNationalNo, ref DateOfBirth,
                                    ref Gendor, ref Address, ref Phone, ref Email
                                    , ref ImagePath, ref CountryID
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPerson(ID, FirstName, SecondName, ThirdName, LastName,
                          NoNationalNo, DateOfBirth, Gendor, Address, Phone, Email, ImagePath, CountryID);
            else
                return null;
        }


        public static bool Delete(int ID)
        {
            return clsPersonData2.Delete(ID);
        }
    }

   

}
