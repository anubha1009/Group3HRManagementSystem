using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3HRManagementSystem
{
    internal class ContractEmployee:EmployeeClass
    {
        public ContractEmployee(string firstName, string lastName, string jobTitle) : base(firstName, lastName)
        {
            jobTitle = this.GetType().Name;
        }

        public double HoursWorked { get; private set; }

        public override double CalculatePay()
        {
            return EmployeeSalary * HoursWorked;
        }
    }//end contract employee class
}//end namespace
