using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created by Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    internal class ContractEmployee:EmployeeClass
    {
        public ContractEmployee(string firstName, string lastName, string jobTitle , double daysWorked) : base(firstName, lastName)
        {
            jobTitle = this.GetType().Name;
            this.DaysWorked = daysWorked;
        }//ctor
        public ContractEmployee(double daysWorked , double salary)
        {
            this.DaysWorked = daysWorked;
            this.EmployeeSalary = salary;
        }//ctor overloading
        public ContractEmployee()
        {

        }//employ ctor

        public double DaysWorked { get;  set; }

        public override double CalculatePay()
        {
            return EmployeeSalary * DaysWorked;
        }//end calculate pay
    }//end contract employee class
}//end namespace
