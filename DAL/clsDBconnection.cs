using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class clsDBconnection
    {
        private OleDbConnection con;

        /* 
         * !!! Important !!!
         * It is necessary to change the connection to DB file
         */
        private string DBRemax = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{YOUR PATH HERE}\prjRealEstateRemax\DAL\App_Data\Remax.mdb'";

        public clsDBconnection()
        {
            con = new OleDbConnection(DBRemax);
        }

        private OleDbConnection getCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        private void closeCon()
        {
            con.Close();
        }

        public int ExecNonQuery(string nonQuery)
        {
            OleDbCommand cmd = new OleDbCommand(nonQuery);
            cmd.Connection = getCon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            closeCon();
            return rowsaffected;
        }

        public object ExecScalar(OleDbCommand cmd)
        {
            cmd.Connection = getCon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            closeCon();
            return obj;
        }

        public DataTable ExecReader(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query);
            cmd.Connection = getCon();
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            closeCon();
            return dt;            
        }

    }
}
