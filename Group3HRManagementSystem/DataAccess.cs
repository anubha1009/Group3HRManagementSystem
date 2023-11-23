using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        private string connectionString = ConfigurationManager.ConnectionStrings["Group3HRManagementSystem.Properties.Settings.HRConnString"].ConnectionString;
        //for any DBError
        private string DBError { get; set; }
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

        public DataTable GetAllEmployeesOrProject(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, this.GetConnection());
                this.OpenConnection();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
            finally
            {
                this.CloseConnection();
            }
        }//end get all employees
        




    }//end Data Access Class
}//end namespace
