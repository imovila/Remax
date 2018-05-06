using System.Data;

namespace DAL
{
    public interface IRemaxData
    {

        /// <summary>
        /// Get all houses or for specific agent
        /// </summary>
        /// <returns>DataTable</returns>
        DataTable getHouses();

        /// <summary>
        /// Get all houses for specific agent
        /// </summary>
        /// <returns>DataTable</returns>
        DataTable getHouses(int agentID);

        /// <summary>
        /// Delete specific House from Database
        /// </summary>
        /// <returns>int</returns>
        int deleteHouse(int houseID);

        /// <summary>
        /// Update specific House from Database
        /// </summary>
        /// <returns>int</returns>
        int updateHouse(int houseID, string houseToUpdate);

        /// <summary>
        /// Insert specific House to Database
        /// </summary>
        /// <returns>int</returns>
        int insertHouse(string houseToInsert);

        /// <summary>
        /// Get all Employees (type Admin, Agents, Users)
        /// </summary>
        /// <returns>DataTable</returns>
        DataTable getEmployees();

        /// <summary>
        /// Get all Clients
        /// </summary>
        /// <returns>DataTables</returns/>
        DataTable getClients();

        /// <summary>
        /// Get Client by client ID
        /// </summary>
        /// <returns>DataRow</returns/>
        DataRow getClient(int clientID);

        /// <summary>
        /// Get the clients to be connected to a house
        /// </summary>
        /// <returns>DataTable</returns/>
        DataTable getClientsNeedConnectToHouse();

        /// <summary>
        /// Get the houses to be connected to a client for specifiv agent or all
        /// </summary>
        /// <returns>DataTable</returns/>
        DataTable getHousesNeedConnectToClient(int? agentID = null);

        /// <summary>
        /// Join house to client
        /// </summary>
        /// <returns>int</returns/>
        int joinHouseToClient(int houseID, int clientID);
        
        /// <summary>
        /// Delete specific Client from Database
        /// </summary>
        /// <returns>int</returns>
        int deleteClient(int clientID);

        /// <summary>
        /// Update specific Client from Database
        /// </summary>
        /// <returns>int</returns>
        int updateClient(int clientID, string clientToUpdate);

        /// <summary>
        /// Insert specific Client to Database
        /// </summary>
        /// <returns>int</returns>
        int insertClient(string clientToInsert);

        /// <summary>
        /// Get all Messages
        /// </summary>
        /// <returns>DataTable</returns>
        DataTable getMessages();

        /// <summary>
        /// Get houses with sold status and include in sales (for specific agent or all)
        /// </summary>
        /// <returns>DataTable</returns>
        DataTable getHousesForSales(int? agentID);

        /// <summary>
        /// Insert sale to Database
        /// </summary>
        /// <returns>int</returns>
        int insertSale(string saleToInsert);

        /// <summary>
        /// Insert employee to Database
        /// </summary>
        /// <returns>int</returns>
        int insertEmployee(string employeeToInsert);

        /// <summary>
        /// Update specific Employee in Database
        /// </summary>
        /// <returns>int</returns>
        int updateEmployee(int employeeID, string employeeToUpdate);

        /// <summary>
        /// Delete specific Employee from Database
        /// </summary>
        /// <returns>int</returns>
        int deleteEmployee(int employeeID);

        /// <summary>
        /// Get all messages for specific agent
        /// </summary>
        /// <returns>DataTable</returns>
        DataTable getMessages(int agentID);

        /// <summary>
        /// Insert Message to Database
        /// </summary>
        /// <returns>int</returns>
        int insertMessage(string messageToInsert);

        /// <summary>
        /// Delete specific Message from Database
        /// </summary>
        /// <returns>int</returns>
        int deleteMessage(int messageID);
    }
}
