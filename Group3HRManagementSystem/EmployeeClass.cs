using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3HRManagementSystem
{
    internal class EmployeeClass: IEmployee
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
        public DateTime EmployeeHireDate { get; set; }
        public double EmployeeSalary { get; set; }

        const double FIXED_HOURS = 160;
        const double FIXED_MONTHS = 12;
        public EmployeeClass()
        {

        }
        public EmployeeClass(string firstName , string lastName)
        {
            this.EmployeeFirstName = firstName;
            this.EmployeeLastName = lastName;
        }
        public EmployeeClass(string firstName, string lastName, string jobTitle)
        {
            this.EmployeeFirstName = firstName;
            this.EmployeeLastName = lastName;
            this.EmployeeJobTitle = jobTitle;
        }
        public virtual double  CalculatePay()
        {
            return EmployeeSalary * FIXED_HOURS * FIXED_MONTHS;
        }
        

    }//end EmployeeClass
}//end Namespace
