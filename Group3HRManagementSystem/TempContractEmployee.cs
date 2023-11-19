using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3HRManagementSystem
{
    internal class TempContractEmployee: ContractEmployee
    {
        public TempContractEmployee(string firstName, string lastName, string jobTitle, double hoursWorked) : base(firstName, lastName, jobTitle, hoursWorked)
        {
            this.WorkedHours = hoursWorked;
        }
        public TempContractEmployee(double hoursWorked , double payRate)
        {
            this.PayRate = payRate;
            this.WorkedHours = hoursWorked;
        }

        public double PayRate { get; private set; }
        public double WorkedHours { get; private set; }
        public override double CalculatePay()
        {
            return PayRate * WorkedHours;
        }
    }//end TempContractEmployee
}//end namespace
