using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsApplicationTypes
    {
        public int AppID
        {
            get;
            set;
        }

        public string Title { get; set; }

        public float Fees { get; set; }

        public ClsApplicationTypes()
        {
            AppID = -1;
            Title = "";
            Fees = 0;
        }

        private ClsApplicationTypes(int AppID , string Title, float Fees)
        {
            this.AppID = AppID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static DataTable ListAppTypes()
        {
            return ClsDataApplicationTypes.ListAppTypes();
        }

        public static bool UpdateApplicationType(int ID , string Title , float Fees)
        {
            return ClsDataApplicationTypes.UpdateAppTypes(ID , Title , Fees);
        }

        public static ClsApplicationTypes Find(int  AppID)
        {
            string Title = "";
            float Fees = 0;

            if(ClsDataApplicationTypes.FindAppByID(AppID,ref Title,ref Fees))
            {
                return new ClsApplicationTypes(AppID,Title,Fees);
            }

            return null;
        }
    }
}
