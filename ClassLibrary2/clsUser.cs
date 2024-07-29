using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public clsPerson Person { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public clsUser() 
        {
            this.UserID = -1;
            this.Person = new clsPerson();
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        public clsUser(int UserID ,int PersonID , string UserName,  string Password , bool IsActive)
        {

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Person = clsPerson.FindpersonByID(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;

        }

        public static bool LoginUser(string Username, string Password)
        {
            return clsUserData.LoginUser(Username, Password);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool ChechUserIsFound( int ID)
        {
            return clsUserData.ChechUserIsFound(ID);
        }

        private bool _AddNewUser()
        {

            this.UserID = clsUserData.AddNewUser(this.PersonID,this.UserName,
                this.Password,this.IsActive);

            return (UserID != -1);
        }

        private bool _UpdateUser()
        {

            return clsUserData.UpdateUser(this.UserID,this.PersonID, this.UserName,
                this.Password, this.IsActive);
    
        }

        public static clsUser FindByID(int UserID)
        {
  
           int PersonID = -1;
           string UserName = "";
           string Password = "";
           bool IsActive = true;

            if(clsUserData.FindByID(UserID,ref PersonID,ref UserName,ref Password,ref IsActive))
            {
                return new clsUser(UserID,PersonID,UserName,Password,IsActive);
            }
            else
            {
                return null;
            }

        }

        public static clsUser FindByUserName(string UserName)
        {

            int PersonID = -1;
            int UserID = -1;
            string Password = "";
            bool IsActive = true;

            if (clsUserData.FindByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;




        }

        static  public bool Delete(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }

        static public bool ChangePassword(int UserID,string Password)
        {
            return clsUserData.ChangePassword(UserID,Password);
        }


    }
}
