using BusinessDLVDLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers_and_Licenses_Vehicles_Department
{
    public class GLobal
    {

        public static ClsUsers CurrentUser;

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            return false;
        }
        
        public static bool GetStoredCredential(ref string username, ref string password)
        {

            return false;
        }
    }
}
