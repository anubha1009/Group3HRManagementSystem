using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created By Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    internal class SalaryCalculationClass
    {
        //declaring constants
        private const double INCOME_TAX = 10.0;
        private const double GRATITUTY = 5.0;
        private const double INCENTIVE_CONTRACT = 2.0;
        private const double INCENTIVE_TEMPCONTRACT = 0.5;

        //calculate pay method 
        //GENERICS EXAMPLE
        public double CalculateEmployeeSalary<T>(T employeeType) where T: IEmployee
        {
           
            if(employeeType.GetType().Name.Equals("ContractEmployee"))
            {
                double incomeTax = employeeType.CalculatePay() * INCOME_TAX/100.0;
                double contractIncentive = employeeType.CalculatePay() * INCENTIVE_CONTRACT/100.0;
                return employeeType.CalculatePay() - incomeTax + contractIncentive;
            }//end contract employee salary calculation
            else if (employeeType.GetType().Name.Equals("TempContractEmployee"))
            {
              
                double tempContractIncentive = employeeType.CalculatePay() * INCENTIVE_TEMPCONTRACT / 100.0;
                return employeeType.CalculatePay()+ tempContractIncentive;
            }//end temp contract employee salary calculation
            else if (employeeType.GetType().Name.Equals("HourlyEmployee"))
            {
                return employeeType.CalculatePay();
            }//end hourly employee salary calculation
            else
            {
                double incomeTax = employeeType.CalculatePay() * INCOME_TAX / 100.0;
                double gratituty = employeeType.CalculatePay() * GRATITUTY / 100.0;
                return employeeType.CalculatePay()-incomeTax + gratituty;
            }//end salaried employee salary calculation
        }//end calculate pay
       
    }//end Salary Calculation Class
}//end namespace
