using System;

using System.Data;
using DAL;

namespace BAL
{
    public static class clsDataSource
    { 
        public static clsListEmployees GetEmployees()
        {
            clsListEmployees tmp = new clsListEmployees();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;

            tab = rmx.getEmployees();

            foreach (DataRow row in tab.Rows)
            {
                clsEmployee emp = new clsEmployee(Convert.ToInt32(row["id"].ToString()), row["code"].ToString(), row["fullname"].ToString(), 
                                        (enumGender)Enum.Parse(typeof(enumGender), row["gender"].ToString()),
                                        (enumCityzone)Enum.Parse(typeof(enumCityzone), row["cityzone"].ToString()),
                                        row["username"].ToString(), row["password"].ToString(),
                                        (enumEmployeeType)Enum.Parse(typeof(enumEmployeeType), row["type"].ToString()),
                                        (enumLang)Enum.Parse(typeof(enumLang), row["lang"].ToString()), row["pic"].ToString());
                tmp.Add(emp, emp.Code);
                emp = null;
            }
            tab = null;
            return tmp;
        }

        public static clsListHouses getHouses()
        {
            clsListHouses tmp = new clsListHouses();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;

            tab = rmx.getHouses();

            foreach (DataRow rowHouse in tab.Rows)
            {
                //Get client for house
                clsClient client = null;
                if (Convert.ToInt32(rowHouse["client"].ToString()) > 0)
                {
                    DataRow rowClient = rmx.getClient(Convert.ToInt32(rowHouse["client"].ToString()));

                    if (rowClient != null)
                        client = new clsClient(Convert.ToInt32(rowClient["ID"].ToString()), rowClient["fullname"].ToString(),
                            rowClient["phone"].ToString(), rowClient["email"].ToString(),
                            (enumClientType)Enum.Parse(typeof(enumClientType), rowClient["type"].ToString()), null);
                }
                clsHouse house = new clsHouse(Convert.ToInt32(rowHouse["id"].ToString()), rowHouse["code"].ToString(),
                    Convert.ToSingle(rowHouse["aria"].ToString()), Convert.ToByte(rowHouse["rooms"].ToString()),
                    Convert.ToByte(rowHouse["bathrooms"].ToString()), (enumCityzone)Enum.Parse(typeof(enumCityzone), rowHouse["cityzone"].ToString()),
                    rowHouse["address"].ToString(), Convert.ToSingle(rowHouse["price"].ToString()), rowHouse["description"].ToString(),
                    (enumHouseType)Enum.Parse(typeof(enumHouseType), rowHouse["type"].ToString()), rowHouse["pic"].ToString(),
                    (enumHouseStatus)Enum.Parse(typeof(enumHouseStatus), rowHouse["status"].ToString()), Convert.ToDateTime(rowHouse["datein"]), 
                    client, Convert.ToInt32(rowHouse["employee"].ToString()));

                tmp.Add(house, house.Code);
                house = null;
            }
            tab = null;
            return tmp;
        }

        public static clsListHouses getHouses(int agentID)
        {
            clsListHouses tmp = new clsListHouses();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;
            
            tab = rmx.getHouses(agentID);

            foreach (DataRow rowHouse in tab.Rows)
            {
                //Get client for house
                clsClient client = null;
                if (Convert.ToInt32(rowHouse["client"].ToString()) > 0)
                {
                    DataRow rowClient = rmx.getClient(Convert.ToInt32(rowHouse["client"].ToString()));

                    if (rowClient != null)
                        client = new clsClient(Convert.ToInt32(rowClient["ID"].ToString()), rowClient["fullname"].ToString(),
                            rowClient["phone"].ToString(), rowClient["email"].ToString(),
                            (enumClientType)Enum.Parse(typeof(enumClientType), rowClient["type"].ToString()), null);
                }
                clsHouse house = new clsHouse(Convert.ToInt32(rowHouse["id"].ToString()), rowHouse["code"].ToString(), 
                    Convert.ToSingle(rowHouse["aria"].ToString()), Convert.ToByte(rowHouse["rooms"].ToString()),
                    Convert.ToByte(rowHouse["bathrooms"].ToString()), (enumCityzone)Enum.Parse(typeof(enumCityzone), rowHouse["cityzone"].ToString()),
                    rowHouse["address"].ToString(), Convert.ToSingle(rowHouse["price"].ToString()), rowHouse["description"].ToString(),
                    (enumHouseType)Enum.Parse(typeof(enumHouseType), rowHouse["type"].ToString()), rowHouse["pic"].ToString(),
                    (enumHouseStatus)Enum.Parse(typeof(enumHouseStatus), rowHouse["status"].ToString()), Convert.ToDateTime(rowHouse["datein"]), client);

                tmp.Add(house, house.Code);
                house = null;
            }
            tab = null;
            return tmp;
        }

        public static int deleteHouse(int houseID)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.deleteHouse(houseID);
        }

        public static int updateHouse(int houseID, string houseToUpdate)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.updateHouse(houseID, houseToUpdate);
        }

        public static int insertHouse(int employeeID, string houseToInsert)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.insertHouse(houseToInsert + ", " + employeeID);
        }

        public static clsListClients GetCLients()
        {
            clsListClients tmp = new clsListClients();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;

            tab = rmx.getClients();

            foreach (DataRow rowClient in tab.Rows)
            {
                clsClient cl = new clsClient(Convert.ToInt32(rowClient["ID"].ToString()), rowClient["fullname"].ToString(),
                            rowClient["phone"].ToString(), rowClient["email"].ToString(),
                            (enumClientType)Enum.Parse(typeof(enumClientType), rowClient["type"].ToString()));

                tmp.Add(cl, cl.ID);
                cl = null;
            }
            tab = null;
            return tmp;
        }

        public static int deleteClient(int clientID)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.deleteClient(clientID);
        }

        public static int updateClient(int clientID, string clientToUpdate)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.updateClient(clientID, clientToUpdate);
        }

        public static int insertClient(string clientToInsert)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.insertClient(clientToInsert);
        }

        public static clsListClients getClientsNeedConnectToHouse()
        {
            clsListClients tmp = new clsListClients();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;

            tab = rmx.getClientsNeedConnectToHouse();

            foreach (DataRow rowClient in tab.Rows)
            {
                clsClient cl = new clsClient(Convert.ToInt32(rowClient["ID"].ToString()), rowClient["fullname"].ToString(),
                                            rowClient["phone"].ToString(), rowClient["email"].ToString(),
                                            (enumClientType)Enum.Parse(typeof(enumClientType), rowClient["type"].ToString()));
                tmp.Add(cl, cl.ID);
                cl = null;
            }
            tab = null;
            return tmp;
        }

        public static clsListHouses getHousesNeedConnectToClient(int? agentID = null)
        {
            clsListHouses tmp = new clsListHouses();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;

            tab = rmx.getHousesNeedConnectToClient(agentID);

            foreach (DataRow rowHouse in tab.Rows)
            {
                clsHouse house = new clsHouse(Convert.ToInt32(rowHouse["id"].ToString()), rowHouse["code"].ToString(),
                    Convert.ToSingle(rowHouse["aria"].ToString()), Convert.ToByte(rowHouse["rooms"].ToString()),
                    Convert.ToByte(rowHouse["bathrooms"].ToString()), (enumCityzone)Enum.Parse(typeof(enumCityzone), rowHouse["cityzone"].ToString()),
                    rowHouse["address"].ToString(), Convert.ToSingle(rowHouse["price"].ToString()), rowHouse["description"].ToString(),
                    (enumHouseType)Enum.Parse(typeof(enumHouseType), rowHouse["type"].ToString()), rowHouse["pic"].ToString(),
                    (enumHouseStatus)Enum.Parse(typeof(enumHouseStatus), rowHouse["status"].ToString()), Convert.ToDateTime(rowHouse["datein"]));

                tmp.Add(house, house.Code);
                house = null;
            }
            tab = null;
            return tmp;
        }

        public static int joinHouseToClient(int houseID, int clientID)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.joinHouseToClient(houseID, clientID);
        }

        public static clsListHouses getHousesForSales(int? agentID = null)
        {
            clsListHouses tmp = new clsListHouses();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;

            tab = rmx.getHousesForSales(agentID);

            foreach (DataRow rowHouse in tab.Rows)
            {
                clsHouse house = new clsHouse(Convert.ToInt32(rowHouse["id"].ToString()), rowHouse["code"].ToString(),
                    Convert.ToSingle(rowHouse["aria"].ToString()), Convert.ToByte(rowHouse["rooms"].ToString()),
                    Convert.ToByte(rowHouse["bathrooms"].ToString()), (enumCityzone)Enum.Parse(typeof(enumCityzone), rowHouse["cityzone"].ToString()),
                    rowHouse["address"].ToString(), Convert.ToSingle(rowHouse["price"].ToString()), rowHouse["description"].ToString(),
                    (enumHouseType)Enum.Parse(typeof(enumHouseType), rowHouse["type"].ToString()), rowHouse["pic"].ToString(),
                    (enumHouseStatus)Enum.Parse(typeof(enumHouseStatus), rowHouse["status"].ToString()), Convert.ToDateTime(rowHouse["datein"]));

                tmp.Add(house, house.Code);
                house = null;
            }
            tab = null;
            return tmp;
        }

        public static int insertSale(string saleToInsert)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.insertSale(saleToInsert);
        }

        public static int insertEmployee(string employeeToInsert)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.insertEmployee(employeeToInsert);
        }

        public static int updateEmployee(int employeeID, string employeeToUpdate)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.updateEmployee(employeeID, employeeToUpdate);
        }

        public static int deleteEmployee(int emploueeID)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.deleteEmployee(emploueeID);
        }

        public static clsListMessages getMessages(int employeeID)
        {
            clsListMessages tmp = new clsListMessages();

            IRemaxData rmx = new clsRemaxData();
            DataTable tab = null;

            tab = rmx.getMessages(employeeID);

            foreach (DataRow rowMessage in tab.Rows)
            {
                clsMessage msg = new clsMessage(Convert.ToInt32(rowMessage["ID"]), Convert.ToInt32(rowMessage["employee"]), rowMessage["message"].ToString(),
                                                Convert.ToByte(rowMessage["status"]), Convert.ToDateTime(rowMessage["messagedate"]));

                tmp.Add(msg, msg.ID);
                msg = null;
            }
            tab = null;
            return tmp;
        }

        public static int insertMessage(string messageToInsert)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.insertMessage(messageToInsert);
        }

        public static int deleteMessage(int messageID)
        {
            IRemaxData rmx = new clsRemaxData();
            return rmx.deleteMessage(messageID);
        }

    }
}
