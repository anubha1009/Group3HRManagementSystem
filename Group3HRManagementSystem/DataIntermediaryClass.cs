using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created by Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    internal class DataIntermediaryClass
    {
        public string DBError { get; set; }
        public DataTable GetAllEmployees()
        {
            DataAccess dataAccess = new DataAccess();
            string sqlQuery = "SELECT * FROM EMPLOYEE;";
            try
            {
                return dataAccess.GetAllEmployeesOrProject(sqlQuery);
            }catch(Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }//end get all employee method
        public DataTable GetAllProjects()
        {
            DataAccess dataAccess = new DataAccess();
            string sqlQuery = "SELECT * FROM PROJECT;";
            try
            {
                return dataAccess.GetAllEmployeesOrProject(sqlQuery);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }//end get all projects method

        public DataTable GetEmployeesForProject(string projectId)
        {
            DataAccess dataAccess = new DataAccess();
            
            string sqlQuery = $"SELECT * FROM EMPLOYEE WHERE ProjectAllocatedId = {projectId};";
            Console.WriteLine(sqlQuery);
            try
            {
                return dataAccess.GetAllEmployeesOrProject(sqlQuery);
            }catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }//end get employees or project

    }//end class
}//end namespace
