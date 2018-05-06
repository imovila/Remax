using System.Data;

namespace DAL
{
    public class clsRemaxData : IRemaxData
    {
        public DataTable getEmployees()
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from employees");
        }

        public DataTable getHouses(int agentID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from houses where employee = " + agentID);
        }

        public DataTable getHouses()
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from houses ");
        }

        public DataTable getHousesForSales(int? agentID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from houses h where " + (agentID != null ? "employee = " + agentID + " and " : "") + 
                                " status = 3 and not exists (select * from sales where house = h.id)");
        }
        
        public DataTable getMessages()
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from messages");
        }

        public int deleteHouse(int houseID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("delete from houses where id = " + houseID);
        }
  
        public int updateHouse(int houseID, string houseToUpdate)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("update houses set " + houseToUpdate + " where id = " + houseID);
        }

        public int insertHouse(string houseToInsert)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("insert into houses (code, aria, rooms, bathrooms, cityzone, address, price, description, " +
                                   "type, pic, status, datein, employee) values (" + houseToInsert + ")");
        }

        public DataTable getClients()
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from clients where type <> 3");
        }
        
        public DataTable getHousesNeedConnectToClient(int? agentID = null)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from houses h where " + (agentID != null ? "employee = " + agentID + " and " : "") + 
                " not exists (select * from clients where type <> 3 and id = h.client)");
        }

        public DataTable getClientsNeedConnectToHouse()
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from clients c where type <> 3");
        }

        public int joinHouseToClient(int houseID, int clientID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("update houses set client = " + clientID + " where id = " + houseID);
        }

        public DataRow getClient(int clientID)
        {
            clsDBconnection db = new clsDBconnection();
            DataTable tmp = db.ExecReader("select * from clients where type <> 3 and id = " + clientID);

            if (tmp.Rows.Count != 0)
                return tmp.Rows[0];
            return null;
        }

        public int deleteClient(int clientID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("delete from clients where id = " + clientID);
        }

        public int updateClient(int clientID, string clientToUpdate)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("update clients set " + clientToUpdate + " where id = " + clientID);
        }

        public int insertClient(string clientToInsert)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("insert into clients (fullname, phone, email, type) values (" + clientToInsert + ")");
        }

        public int insertSale(string saleToInsert)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("insert into sales (empcommision, lastprice, saledate, house, employee) values (" + saleToInsert + ")");
        }

        public int insertEmployee(string employeeToInsert)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("insert into employees (code, fullname, gender, lang, cityzone, type, username, [password], pic) values (" + employeeToInsert + ")");
        }

        public int updateEmployee(int employeeID, string employeeToUpdate)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("update employees set " + employeeToUpdate + " where id = " + employeeID);
        }

        public int deleteEmployee(int employeeID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("delete from employees where id = " + employeeID);
        }

        public DataTable getMessages(int agentID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecReader("select * from messages where employee = " + agentID);
        }

        public int insertMessage(string messageToInsert)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("insert into messages (employee, message) values (" + messageToInsert + ")");
        }

        public int deleteMessage(int messageID)
        {
            clsDBconnection db = new clsDBconnection();
            return db.ExecNonQuery("delete from messages where id = " + messageID);
        }

    }
}
