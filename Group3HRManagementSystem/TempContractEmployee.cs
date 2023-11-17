using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3HRManagementSystem
{
    internal class TempContractEmployee: ContractEmployee
    {
        public TempContractEmployee(string firstName, string lastName, string jobTitle) : base(firstName, lastName)
        {
            jobTitle=this.GetType().Name;
        }

        public double ContractPeriod { get; private set; }
        public double PayRate { get; private set; }

        public override double CalculatePay()
        {
            return PayRate * ContractPeriod;
        }
    }//end TempContractEmployee
}//end namespace
