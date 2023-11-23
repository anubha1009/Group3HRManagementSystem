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
       
        public DataTable GetJoinTable()
        {
            DataAccess dataAccess=new DataAccess();
            string sqlQuery = "SELECT e.EmployeeId, e.EmployeeFirstName, e.EmployeeLastName, p.ProjectName \r\nFROM EMPLOYEE as e \r\nJOIN PROJECT as p ON e.ProjectAllocatedId = p.ProjectId;\r\n";
            try
            {
                return dataAccess.JoinQuery(sqlQuery, CommandType.Text);
            }
            catch(Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
            
        }//end join table

        public string GetProjectDescriptionFromEmployeeId(string employeeId)
        {
            DataAccess dataAccess = new DataAccess();
            string sqlQuery = "SELECT p.ProjectDescription " +
                     "FROM EMPLOYEE AS e " +
                     "JOIN PROJECT AS p ON e.ProjectAllocatedId = p.ProjectId " +
                     "WHERE e.EmployeeId = @EmployeeId";
            try
            {
                return dataAccess.GetProjectDescription(sqlQuery,CommandType.Text,employeeId);
            }catch(Exception ex)
            {
                DBError = ex.Message;

                return null;
            }
        }

    }//end class
}//end namespace
