using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created By Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    internal class DataAccess
    {
        //declare connection
        private SqlConnection connection;
        //declare connection string 
        private string connectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;

        //setup connection
        private SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            return connection;
        }//end Getconnection

        private void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }//end open connection


        private void CloseConnection()
        {
            connection.Close();
        }//end close Connection




    }//end Data Access Class
}//end namespace
