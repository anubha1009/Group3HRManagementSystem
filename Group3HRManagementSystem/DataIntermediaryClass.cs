 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string sqlQuery = "SELECT e.EmployeeId, e.EmployeeFirstName, e.EmployeeLastName, e.EmployeeType, p.ProjectName, ed.EmployeePayRate, ed.EmployeePerformance \r\nFROM EMPLOYEE as e \r\nJOIN PROJECT as p ON e.ProjectAllocatedId = p.ProjectId JOIN EMPLOYEEDETAILS as ed ON ed.EmployeeId = e.EmployeeId;";
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
            string sqlQuery = "GetProjectDescriptionFromEmployeeId";
            try
            {
                return dataAccess.GetProjectDescription(sqlQuery,CommandType.StoredProcedure, employeeId);
            }catch(Exception ex)
            {
                DBError = ex.Message;

                return null;
            }
        }//end function
        public DataTable SearchEmployee(int employeeId , string employeeName , string employeeType)
        {
            DataAccess dataAccess = new DataAccess();
            /* string sqlQuery = "SELECT e.EmployeeId, e.EmployeeFirstName, e.EmployeeLastName, e.EmployeeType, p.ProjectName " +
             "FROM EMPLOYEE as e " +
             "JOIN PROJECT as p ON e.ProjectAllocatedId = p.ProjectId " +
             "WHERE (@EmployeeId IS NULL OR e.EmployeeId = @EmployeeId) " +
             "OR (@EmployeeFirstName IS NULL OR e.EmployeeFirstName = @EmployeeFirstName) " +
             "OR (@EmployeeType IS NULL OR e.EmployeeType = @EmployeeType);";*/

            string sqlQuery = "SearchEmployee";

            SqlParameter param1 = new SqlParameter("@EmployeeId", SqlDbType.Int);
            param1.Value = employeeId;
            SqlParameter param2 = new SqlParameter("@EmployeeFirstName", SqlDbType.VarChar);
            param2.Value = employeeName;
            SqlParameter param3 = new SqlParameter("@EmployeeType",SqlDbType.VarChar);
            param3.Value = employeeType;
            try
            {
                return dataAccess.SearchQuery(sqlQuery,CommandType.StoredProcedure,param1,param2,param3);
            }catch(Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }//end method
        public int AddProject(string projectName, int projectHourAllocated, double projectBudget, string projectDescription)
        {
            DataAccess dataAccess=new DataAccess();
            // string sqlQuery = "INSERT INTO PROJECT VALUES (@ProjectName , @ProjectHourAllocated , @ProjectBudget,@ProjectDescription)";
            //using stored Procedure
            string sqlQuery = "AddProject";
            SqlParameter param1 = new SqlParameter("@ProjectName", SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@ProjectHourAllocated" , SqlDbType.Int);
            SqlParameter param3 = new SqlParameter("@ProjectBudget", SqlDbType.NVarChar);
            SqlParameter param4 = new SqlParameter("@ProjectDescription", SqlDbType.NVarChar);
            param1.Value = projectName;
            param2.Value = projectHourAllocated;
            param3.Value = projectBudget;
            param4.Value = projectDescription;
            try
            {
                return dataAccess.ExecuteNonQuery(sqlQuery, CommandType.StoredProcedure,param1,param2,param3,param4);
            }
            catch(Exception ex)
            {
                DBError = ex.Message;
                return -1;
            }
        }//end Add project
        public int AddEmployee(string employeeFirstName,string employeeLastName , string employeeEmail , string employeeContact , DateTime employeeHireDate , int projectAllocated, string employeeType, string payRate, string grade)
        {
            DataAccess dataAccess = new DataAccess();
            // string sqlQuery = "INSERT INTO EMPLOYEE VALUES (@EmployeeFirstName , @EmployeeLastName , @EmployeeEmail,@EmployeeContactNumber,@EmployeeHireDate,@ProjectAllocatedId,@EmployeeType)";
            string sqlQuery = "AddEmployee";
            
            SqlParameter param1 = new SqlParameter("@EmployeeFirstName", SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@EmployeeLastName", SqlDbType.VarChar);
            SqlParameter param3 = new SqlParameter("@EmployeeEmail", SqlDbType.VarChar);
            SqlParameter param4 = new SqlParameter("@EmployeeContactNumber", SqlDbType.VarChar);
            SqlParameter param5 = new SqlParameter("@EmployeeHireDate", SqlDbType.Date);
            SqlParameter param6 = new SqlParameter("@ProjectAllocatedId", SqlDbType.Int);
            SqlParameter param7 = new SqlParameter("@EmployeeType", SqlDbType.VarChar);
            SqlParameter param8 = new SqlParameter("@EmployeePayRate", SqlDbType.Money);
            SqlParameter param9 = new SqlParameter("@EmployeePerformance", SqlDbType.NVarChar);

            param1.Value = employeeFirstName;
            param2.Value = employeeLastName;
            param3.Value = employeeEmail;
            param4.Value = employeeContact;
            param5.Value = employeeHireDate;
            param6.Value = projectAllocated;
            param7.Value = employeeType;
            param8.Value = payRate;

            if(grade.Equals("Not Applicable"))
            {
                param9.Value = "NULL";
            }
            else
            {
                param9.Value = grade;
            }

            try
            {
                return dataAccess.ExecuteNonQuery(sqlQuery, CommandType.StoredProcedure, param1, param2, param3, param4,param5,param6,param7,param8,param9);
            }
            catch(Exception ex)
            {
                DBError = ex.Message;
                return -1;
            }

        }//end add employee

        public int UpdateEmployeeDetails(double employeeSalary ,  string employeePerformance ,  string employeeId)
        {
            //For Employee Details Table
            DataAccess dataAccess = new DataAccess();
            string sqlQuery = "UPDATE EmployeeDetails\r\nSET EmployeePayRate = @EmployeePayRate,\r\n    EmployeePerformance = @EmployeePerformance\r\nWHERE EmployeeId = @EmployeeId;";
            SqlParameter param1 = new SqlParameter("@EmployeePayRate", SqlDbType.Money);
            SqlParameter param2 = new SqlParameter("@EmployeePerformance", SqlDbType.NVarChar);
            SqlParameter param3 = new SqlParameter("@EmployeeId", SqlDbType.Int);
            param1.Value= employeeSalary;
            param2.Value= employeePerformance;
            param3.Value= employeeId;
            try
            {
                return dataAccess.UpdateEmployeeDetails(sqlQuery, CommandType.Text, param1, param2, param3);
            }catch(Exception ex)
            {
                DBError = ex.Message;
                return -1;
            }
        }//end update details 
        public int UpdateEmployeeDetailsInEmployee(string lastName , string projectId , string employeeId)
        {
            DataAccess dataAccess = new DataAccess();
            string sqlQuery = "UPDATE Employee SET EmployeeLastName = @EmployeeLastName, ProjectAllocatedId = @ProjectAllocatedId WHERE EmployeeId = @EmployeeId";
            SqlParameter param1 = new SqlParameter("@EmployeeLastName",SqlDbType.NVarChar);
            SqlParameter param2 = new SqlParameter("@ProjectAllocatedId", SqlDbType.Int);
            SqlParameter param3 = new SqlParameter("@EmployeeId", SqlDbType.Int);
            param1.Value = lastName;
            param2.Value= projectId;
            param3.Value= employeeId;
            try
            {
                return dataAccess.UpdateEmployeeDetails(sqlQuery, CommandType.Text, param1, param2,param3);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return -1;
            }
        }//end update employee details

        public DataTable GetEmployeeDetails(string employeeId)
        {
            
            DataAccess dataAccess = new DataAccess();
            string sqlQuery = "SELECT * FROM EMPLOYEEDETAILS WHERE EmployeeId = @EmployeeId;";
            SqlParameter param1 = new SqlParameter("@EmployeeId", SqlDbType.Int);
            param1.Value = employeeId;
            try
            {
                return dataAccess.GetEmployeeDetails(sqlQuery, param1, CommandType.Text) ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                DBError = e.Message;
                return null;

            }
        }

    }//end class
}//end namespace
