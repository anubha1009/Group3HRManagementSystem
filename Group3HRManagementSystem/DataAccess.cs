using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing.Imaging;
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
        public DataTable JoinQuery(string sqlQuery , CommandType commandType)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery,this.GetConnection());
            sqlCommand.CommandType = commandType;
            try
            {
                this.OpenConnection();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }finally { this.CloseConnection(); }
        }
        public string GetProjectDescription(string sqlQuery, CommandType commandType, string selectedEmployeeIndex)
        {
            
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, this.GetConnection());
            sqlCommand.CommandType = commandType;
            sqlCommand.Parameters.AddWithValue("@EmployeeId", selectedEmployeeIndex);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    // Assuming "ProjectDescription" is the column name
                    string projectDescription = reader["ProjectDescription"].ToString();
                    return projectDescription;
                }
                else
                {
                    return "No project description found for the selected employee.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { this.CloseConnection(); }
        }//end getProjectDescription
        public DataTable SearchQuery(string sqlQuery,CommandType cmdType , SqlParameter param1=null , SqlParameter param2=null,SqlParameter param3=null)
        {
            SqlCommand sqlCommand = new SqlCommand (sqlQuery, this.GetConnection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sqlCommand.CommandType = cmdType;
             sqlCommand.Parameters.Add(param1);
           sqlCommand.Parameters.Add(param2);
           sqlCommand.Parameters.Add(param3);

            dataAdapter.SelectCommand = sqlCommand;
            try
            {
                this.OpenConnection();
                dataAdapter.Fill(ds);
                return ds.Tables[0];
            }catch (Exception ex) { throw ex; }
            finally { this.CloseConnection(); }

        }//end search query
        public int ExecuteNonQuery(string proc, CommandType cmdType, SqlParameter param1 = null,
            SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6=null , SqlParameter param7 =null,
            SqlParameter param8 = null, SqlParameter param9 = null)
        {
            SqlCommand sqlCommand = new SqlCommand(proc, this.GetConnection());
            sqlCommand.CommandType = cmdType;
            if (param1 != null) { sqlCommand.Parameters.Add(param1); }
            if (param2 != null) { sqlCommand.Parameters.Add(param2); }
            if (param3 != null) { sqlCommand.Parameters.Add(param3); }
            if (param4 != null) { sqlCommand.Parameters.Add(param4); }
            if (param5 != null) { sqlCommand.Parameters.Add(param5); }
            if (param6 != null) { sqlCommand.Parameters.Add(param6); }
            if (param7 != null) { sqlCommand.Parameters.Add(param7); }
            if (param7 != null) sqlCommand.Parameters.Add(param8);
            if (param7 != null) sqlCommand.Parameters.Add(param9);
            try
            {
                this.OpenConnection();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { this.CloseConnection(); sqlCommand.Dispose(); }
        }//end method

        public int UpdateEmployeeDetails(string sqlQuery , CommandType commandType , SqlParameter param1=null , SqlParameter param2=null, SqlParameter param3=null)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, this.GetConnection());
            sqlCommand.CommandType = commandType;
            if (param1 != null) { sqlCommand.Parameters.Add(param1); }
            if (param2 != null) { sqlCommand.Parameters.Add(param2); }
            if (param3 != null) { sqlCommand.Parameters.Add(param3); }
            try
            {
                this.OpenConnection();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { this.CloseConnection(); sqlCommand.Dispose(); };
        }//end up date emp details

        public DataTable GetEmployeeDetails(string sqlQuery, SqlParameter param1 ,CommandType cmdType)
        {
          DataSet ds = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, this.GetConnection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            sqlCommand.CommandType = cmdType;
            sqlCommand.Parameters.Add(param1);
            dataAdapter.SelectCommand = sqlCommand;

            try
            {
                

                this.OpenConnection();
                dataAdapter.Fill(ds);
                return ds.Tables[0];
            }catch(Exception ex) { throw ex; }
            finally { this.CloseConnection(); }
        }

    }//end Data Access Class
}//end namespace
