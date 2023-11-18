using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3HRManagementSystem
{
    internal class ContractEmployee:EmployeeClass
    {
       

        public ContractEmployee(string firstName, string lastName, string jobTitle , double daysWorked) : base(firstName, lastName)
        {
            jobTitle = this.GetType().Name;
            this.DaysWorked = daysWorked;
        }

        public double DaysWorked { get; private set; }

        public override double CalculatePay()
        {
            return EmployeeSalary * DaysWorked;
        }
    }//end contract employee class
}//end namespace
