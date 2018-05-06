using System;
using System.Text;

namespace BAL
{
    public class clsHouse
    {
        private int vID;
        private string vCode;
        private float vAria;
        private byte vRooms;
        private byte vBathrooms;
        private enumCityzone vCityZone;
        private string vAddress;
        private float vPrice;
        private string vDescription;
        private enumHouseType vType;
        private string vPic;
        private enumHouseStatus vStatus;
        private DateTime vDatein;
        private clsClient vClient;
        private int? vEmployeeID;

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

        public float Aria
        {
            get
            {
                return vAria;
            }

            set
            {
                vAria = value;
            }
        }

        public byte Rooms
        {
            get
            {
                return vRooms;
            }

            set
            {
                vRooms = value;
            }
        }

        public byte Bathrooms
        {
            get
            {
                return vBathrooms;
            }

            set
            {
                vBathrooms = value;
            }
        }

        public enumCityzone CityZone
        {
            get
            {
                return vCityZone;
            }

            set
            {
                vCityZone = value;
            }
        }

        public string Address
        {
            get
            {
                return vAddress;
            }

            set
            {
                vAddress = value;
            }
        }

        public float Price
        {
            get
            {
                return vPrice;
            }

            set
            {
                vPrice = value;
            }
        }

        public string Description
        {
            get
            {
                return vDescription;
            }

            set
            {
                vDescription = value;
            }
        }

        public enumHouseType Type
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

        public enumHouseStatus Status
        {
            get
            {
                return vStatus;
            }

            set
            {
                vStatus = value;
            }
        }

        public DateTime Datein
        {
            get
            {
                return vDatein;
            }

            set
            {
                vDatein = value;
            }
        }

        public clsClient Client
        {
            get
            {
                return vClient;
            }

            set
            {
                vClient = value;
            }
        }

        public int? EmployeeID
        {
            get
            {
                return vEmployeeID;
            }

            set
            {
                vEmployeeID = value;
            }
        }

        public clsHouse() { }
   
        public clsHouse(int vID, string vCode, float vAria, byte vRooms, byte vBathrooms, enumCityzone vCityZone, string vAddress, 
            float vPrice, string vDescription, enumHouseType vType, string vPic, enumHouseStatus vStatus, 
            DateTime vDatein = new DateTime(), clsClient vClient = null, int? employeeID = null)
        {
            this.ID = vID;
            this.Code = vCode;
            this.Aria = vAria;
            this.Rooms = vRooms;
            this.Bathrooms = vBathrooms;
            this.CityZone = vCityZone;
            this.Address = vAddress;
            this.Price = vPrice;
            this.Description = vDescription;
            this.Type = vType;
            this.Pic = vPic;
            this.Status = vStatus;
            this.Datein = vDatein;
            this.Client = vClient;
            this.EmployeeID = employeeID;
        }

        public string toUpdate()
        {
            StringBuilder list = new StringBuilder();
            list.Append("code = '" + Code + "',");
            list.Append("aria = " + Aria.ToString() + ",");
            list.Append("rooms = " + Rooms.ToString() + ",");
            list.Append("bathrooms = " + Bathrooms.ToString() + ",");
            list.Append("cityzone = " + ((int)CityZone).ToString() + ",");
            list.Append("address = '" + Address.ToString() + "',");
            list.Append("price = " + Price.ToString() + ",");
            list.Append("description = '" + Description.ToString() + "',");
            list.Append("type = " + ((int)Type).ToString() + ",");
            list.Append("pic = '" + Pic.ToString() + "',");
            list.Append("status = " + ((int)Status).ToString() + ",");
            list.Append("datein = '" + Datein.ToString() + "'");
            return list.ToString();
        }

        public string toInsert()
        {
            StringBuilder list = new StringBuilder();
            list.Append("'" + Code + "',");
            list.Append(Aria.ToString() + ",");
            list.Append(Rooms.ToString() + ",");
            list.Append(Bathrooms.ToString() + ",");
            list.Append(((int)CityZone).ToString() + ",");
            list.Append("'" + Address.ToString() + "',");
            list.Append(Price.ToString() + ",");
            list.Append("'" + Description.ToString() + "',");
            list.Append(((int)Type).ToString() + ",");
            list.Append("'" + Pic.ToString() + "',");
            list.Append(((int)Status).ToString() + ",");
            list.Append("'" + Datein.ToString() + "'");
            return list.ToString();
        }

    }
}
