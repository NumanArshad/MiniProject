using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSytem
{
    class DataBaseConnection
    {
        private SqlConnection connection;
        public string conStr;
        private static DataBaseConnection instance = null;
        private DataBaseConnection()
        {

        }
        public static DataBaseConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DataBaseConnection();
            }
            return instance;
        }
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(conStr);
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }
        public int executeQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, getConnection());
            int rowsAffecetd = cmd.ExecuteNonQuery();
            return rowsAffecetd;
        }
        public int  getRowsCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, getConnection());
            int countRows = int.Parse(cmd.ExecuteScalar().ToString());
            return countRows;
        }
        public SqlDataAdapter getAllData(string query)
        {
            SqlDataAdapter data = new SqlDataAdapter(query, getConnection());
            return data;
        }
        public SqlDataReader readData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, getConnection());
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
        public void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

    }
}
