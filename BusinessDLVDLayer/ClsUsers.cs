using DataDLVDLayer;
using System;
using System.Data;

namespace BusinessDLVDLayer
{
    public class ClsUsers
    {
        enum Enmode { AddMode = 0, UpdateMode = 1 }
        Enmode enmode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }

        public ClsUsers()
        {
            enmode = Enmode.AddMode;
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = 0;
        }

        private ClsUsers(int userID, int personID, string userName, string password, int isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            enmode = Enmode.UpdateMode;
        }

        public static ClsUsers Find(int userID)
        {
            int personID = -1, isActive = 0;
            string userName = "", password = "";

            if (ClsDataUsers.FindUser(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new ClsUsers(userID, personID, userName, password, isActive);
            }
            return null;
        }

        public static ClsUsers Find(string UserName)
        {
            int personID = -1 ,userID=-1, isActive = 0;
            string password = "";

            if (ClsDataUsers.FindUser( UserName,ref userID, ref personID, ref password, ref isActive))
            {
                return new ClsUsers(userID, personID, UserName, password, isActive);
            }
            return null;
        }

        public static bool IsUserNameExist(string userName)
        {
            return ClsDataUsers.IsUserNameExist(userName);
        }

        private bool _AddNewUser()
        {
            this.UserID = ClsDataUsers.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return this.UserID != -1;
        }

        private bool _UpdateUser()
        {
            return ClsDataUsers.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public static bool DeleteUser(int userID)
        {
            return ClsDataUsers.DeleteUser(userID);
        }

        public static DataTable ListUsers()
        {
            return ClsDataUsers.ListUsers();
        }

        public static bool IsPersonIDNotExist(int PersonID)
        {
            return ClsDataUsers.IsPersonIDNoExist(PersonID);
        }

        public bool Save()
        {
            switch (enmode)
            {
                case Enmode.AddMode:
                    if (_AddNewUser())
                    {
                        enmode = Enmode.UpdateMode;
                        return true;
                    }
                    break;
                case Enmode.UpdateMode:
                    return _UpdateUser();
            }
            return false;
        }
    }
}
