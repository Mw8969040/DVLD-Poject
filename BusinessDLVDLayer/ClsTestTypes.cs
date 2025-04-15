using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDLVDLayer
{
    public class ClsTestTypes
    {
        public int TestID
        {
            get;
            set;
        }

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        public ClsTestTypes()
        {
            TestID = -1;
            Title = "";
            Fees = 0;
        }

        private ClsTestTypes(int TestID, string Title,string Description, float Fees)
        {
            this.TestID = TestID;
            this.Description = Description;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static DataTable ListTestTypes()
        {
            return ClsDataTestType.ListTestTypes();
        }

        public static bool UpdateTestType(int ID, string Title,string Description, float Fees)
        {
            return ClsDataTestType.UpdateTestTypes(ID, Title,Description, Fees);
        }

        public static ClsTestTypes Find(enTestType TestID)
        {
            string Title = "" , Description="";
            float Fees = 0;

            if (ClsDataTestType.FindTestByID((int)TestID, ref Title,ref Description, ref Fees))
            {
                return new ClsTestTypes((int)TestID, Title,Description, Fees);
            }

            return null;
        }

        public static ClsTestTypes Find(int TestID)
        {
            string Title = "", Description = "";
            float Fees = 0;

            if (ClsDataTestType.FindTestByID(TestID, ref Title, ref Description, ref Fees))
            {
                return new ClsTestTypes(TestID, Title, Description, Fees);
            }

            return null;
        }
    }
}
