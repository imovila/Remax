using System.Text;

namespace BAL
{
    public class clsEmployee
    {
        private int vID;
        private string vCode;
        private string vFullname;
        private enumGender vGender;
        private enumCityzone vCityzone;
        private enumLang vLang;
        private enumEmployeeType vEmployeetype;
        private string vUsername;
        private string vPassword;
        private string vPic;
        private clsListHouses vHouses;

        public int ID
        {
            get
            {
                return vID;
            }

            set
            {
                vID = value;
            }
        }

        public string Fullname
        {
            get
            {
                return vFullname;
            }

            set
            {
                vFullname = value;
            }
        }

        public enumGender Gender
        {
            get
            {
                return vGender;
            }

            set
            {
                vGender = value;
            }
        }

        public enumCityzone Cityzone
        {
            get
            {
                return vCityzone;
            }

            set
            {
                vCityzone = value;
            }
        }

        public string Code
        {
            get
            {
                return vCode;
            }

            set
            {
                vCode = value;
            }
        }

        public string Username
        {
            get
            {
                return vUsername;
            }

            set
            {
                vUsername = value;
            }
        }

        public string Password
        {
            get
            {
                return vPassword;
            }

            set
            {
                vPassword = value;
            }
        }

        public enumEmployeeType Employeetype
        {
            get
            {
                return vEmployeetype;
            }

            set
            {
                vEmployeetype = value;
            }
        }

        public enumLang Lang
        {
            get
            {
                return vLang;
            }

            set
            {
                vLang = value;
            }
        }

        public string Pic
        {
            get
            {
                return vPic;
            }

            set
            {
                vPic = value;
            }
        }

        public clsListHouses Houses
        {
            get
            {
                return vHouses;
            }

            set
            {
                vHouses = value;
            }
        }

        public clsEmployee() { }

        public clsEmployee(int ID, string Code, string Fullname, enumGender Gender, enumCityzone Cityzone, 
            string Username, string Password, enumEmployeeType Employeetype, enumLang Lang, 
            string Pic, clsListHouses Houses = null)
        {
            this.ID = ID;
            this.Fullname = Fullname;
            this.Gender = Gender;
            this.Cityzone = Cityzone;
            this.Code = Code;
            this.Username = Username;
            this.Password = Password;
            this.Employeetype = Employeetype;
            this.Lang = Lang;
            this.Pic = Pic;
            this.Houses = new clsListHouses();
        }

        public string toUpdate()
        {
            StringBuilder list = new StringBuilder();
            list.Append("code = '" + Code + "',");
            list.Append("fullname = '" + Fullname.ToString() + "', ");
            list.Append("gender = " + ((int)Gender).ToString() + ", ");
            list.Append("lang = " + ((int)Lang).ToString() + ", ");
            list.Append("cityzone = " + ((int)Cityzone).ToString() + ", ");
            list.Append("type = " + ((int)Employeetype).ToString() + ", ");
            list.Append("username = '" + Username.ToString() + "', ");
            list.Append("[password] = '" + Password.ToString() + "', ");
            list.Append("pic = '" + Pic.ToString() + "'");
            return list.ToString();
        }

        public string toInsert()
        {
            StringBuilder list = new StringBuilder();
            list.Append("'" + Code + "',");
            list.Append("'" + Fullname.ToString() + "',");
            list.Append(((int)Gender).ToString() + ",");
            list.Append(((int)Lang).ToString() + ",");
            list.Append(((int)Cityzone).ToString() + ",");
            list.Append(((int)Employeetype).ToString() + ",");
            list.Append("'" + Username.ToString() + "',");
            list.Append("'" + Password.ToString() + "',");
            list.Append("'" + Pic.ToString() + "'");
            return list.ToString();
        }

    }
}