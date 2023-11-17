using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3HRManagementSystem
{
    internal class EmployeeClass: IEmployee
    {
        public string EmployeeFirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EmployeeLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EmployeeJobTitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EmployeeEmail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EmployeePhone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EmployeeHireDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double EmployeeSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            return EmployeeSalary;
        }
        

    }//end EmployeeClass
}//end Namespace
