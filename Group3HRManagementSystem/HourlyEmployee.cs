using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created by Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    internal class HourlyEmployee:EmployeeClass
    {
        public HourlyEmployee(string firstName, string lastName, string jobTitle) : base(firstName, lastName)
        {
            jobTitle= this.GetType().Name; 
        }//ctor 


        public double HourlyWage { get; set; }
        public double HoursWorked { get; set; }

        public override double CalculatePay()
        {
            return HourlyWage * HoursWorked;
        }


    }//end Class
}//end namespace
