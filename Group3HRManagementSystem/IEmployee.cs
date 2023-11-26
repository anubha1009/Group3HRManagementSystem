using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created by Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    internal interface IEmployee
    {
         string EmployeeFirstName { get; set; }
         string EmployeeLastName { get; set; }
        string EmployeeJobTitle { get; set; }
        string EmployeeEmail { get; set; }
        string EmployeePhone { get; set; }
        DateTime EmployeeHireDate { get; set; }
        double EmployeeSalary { get; set; }

        double CalculatePay(); //OVERRIDDEN IN CLASSES
    }//end interface
}//end namespace
