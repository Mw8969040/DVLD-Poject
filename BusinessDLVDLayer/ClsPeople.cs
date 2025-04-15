using DataDLVDLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessDLVDLayer
{
    public class ClsPeople
    {
        enum Enmode { AddMode = 0, UpdateMode = 1 }
        Enmode enmode;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public int Gendor { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public string Phone { get; set; }
        public int CountryID { get; set; }
        public string NationalNo { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }

        private ClsPeople(int PersonID, string firstName, string secondName, string thirdName, string lastName, int gendor,
                          string email, string phone, int countryID, string nationalNo, string address, string imagePath, DateTime dateOfBirth)
        {
            this. PersonID = PersonID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Gendor = gendor;
            Email = email;
            Phone = phone;
            CountryID = countryID;
            NationalNo = nationalNo;
            Address = address;
            ImagePath = imagePath;
            DateOfBirth = dateOfBirth;
            enmode = Enmode.UpdateMode;
        }

        public ClsPeople()
        {
            enmode = Enmode.AddMode;
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Gendor = -1;
            Email = "";
            Phone = "";
            CountryID = -1;
            NationalNo = "";
            Address = "";
            ImagePath = "";
            DateOfBirth = DateTime.Now;
        }

        public static ClsPeople Find(int PersonID)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "", email = "", phone = "", nationalNo = "", address = "", imagePath = "";
            int gendor = -1, countryID = -1;
            DateTime dateOfBirth = DateTime.Now;

            if (ClsDataPeople.FindPerson(PersonID, ref firstName, ref secondName, ref thirdName, ref lastName, ref gendor, ref email, ref phone, ref countryID, ref nationalNo, ref address, ref imagePath, ref dateOfBirth))
            {
                return new ClsPeople(PersonID, firstName, secondName, thirdName, lastName, gendor, email, phone, countryID, nationalNo, address, imagePath, dateOfBirth);
            }

            return null;
        }

         public static ClsPeople Find(string NationalNo)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "", email = "", phone = "", address = "", imagePath = "";
            int gendor = -1, countryID = -1 , PersonID=-1;
            DateTime dateOfBirth = DateTime.Now;

            if (ClsDataPeople.FindPerson(ref PersonID, ref firstName, ref secondName, ref thirdName, ref lastName, ref gendor, ref email, ref phone, ref countryID, NationalNo, ref address, ref imagePath, ref dateOfBirth))
            {
                return new ClsPeople(PersonID, firstName, secondName, thirdName, lastName, gendor, email, phone, countryID, NationalNo, address, imagePath, dateOfBirth);
            }

            return null;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = ClsDataPeople.AddNewPerson( this.FirstName, this.SecondName, this.ThirdName, this.LastName,   this.Gendor, this.Email, this.Phone, this.CountryID,    this.NationalNo, this.Address, this.ImagePath, this.DateOfBirth);
            return this.PersonID!=-1;
        }

        private bool _UpdatePerson()
        {
            return ClsDataPeople.UpdatePerson(this.PersonID, this.FirstName, this.SecondName,this.ThirdName,this.LastName,this.Gendor, this.Email,this.Phone,this.CountryID, this.NationalNo, this.Address,this.ImagePath,this.DateOfBirth); 
        }
        public static bool DeletePerson(int ID)
        {
            ClsPeople person = Find(ID);

            if (person != null)
            {
                string ImagePath = person.ImagePath;

                if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
                {
                    File.Delete(ImagePath);
                }

                return ClsDataPeople.DeletePerson(ID);
            }

            return false; // في حال لم يتم العثور على الشخص
        }

        public static DataTable ListPeople()
        {
            return ClsDataPeople.ListPeople();
        }

        public static bool IsNationalNoExist(string NationalNo)
        {
            return ClsDataPeople.IsNationalNoExist(NationalNo);
        }


        public bool Save()
        {
            switch (enmode)
            {
                case Enmode.AddMode:

                    if (_AddNewPerson())
                    {
                        enmode = Enmode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case Enmode.UpdateMode:

                    if (_UpdatePerson())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

       
    }
}
