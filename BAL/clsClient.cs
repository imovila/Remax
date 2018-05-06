using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class clsClient
    {
        private int vID;
        private string vFullname;
        private string vPhone;
        private string vEmail;
        private enumClientType vType;
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

        public string Phone
        {
            get
            {
                return vPhone;
            }

            set
            {
                vPhone = value;
            }
        }

        public string Email
        {
            get
            {
                return vEmail;
            }

            set
            {
                vEmail = value;
            }
        }

        public enumClientType Type
        {
            get
            {
                return vType;
            }

            set
            {
                vType = value;
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

        public clsClient() { ; }

        public clsClient(int ID, string fullname, string phone, string email, enumClientType type, clsListHouses houses = null)
        {
            this.ID = ID;
            this.Fullname = fullname;
            this.Phone = phone;
            this.Email = email;
            this.Type = type;
            this.Houses = houses;
        }

        public override string ToString()
        {
            return Fullname;
        }

        public string toUpdate()
        {
            StringBuilder list = new StringBuilder();
            list.Append("fullname = '" + Fullname + "',");
            list.Append("phone = '" + Phone + "',");
            list.Append("email = '" + Email + "',");
            list.Append("type = " + ((int)Type).ToString());
            return list.ToString();
        }

        public string toInsert()
        {
            StringBuilder list = new StringBuilder();
            list.Append("'" + Fullname + "',");
            list.Append("'" + Phone + "',");
            list.Append("'" + Email + "',");
            list.Append(((int)Type).ToString());
            return list.ToString();
        }


    }
}
