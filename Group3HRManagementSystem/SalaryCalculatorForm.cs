using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Created by Vineela , modified by Anubha 
namespace Group3HRManagementSystem
{
    public partial class SalaryCalculatorForm : Form
    {
        public SalaryCalculatorForm()
        {
            InitializeComponent();
        }
        //declaring delegate
        private delegate void NoteDelegate(string s);

        //Mofified by Anubha Vishwakarma
        private void typeOfEmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Calling delegates
            noteLabel.Text = "";
            NoteDelegate noteDelegate0 = new NoteDelegate(Note); // to display placeholder content
            noteDelegate0(typeOfEmployeeComboBox.Text);
            if (typeOfEmployeeComboBox.SelectedIndex == 0)
            { 
                //disabling all other boxes       
                tempContractEmployeeGroupBox.Enabled=false;
                hourlyEmployeeGroupBox.Enabled=false;
                fixedSalaryTextBox.Enabled = false;
                fixedSalaryLabel.Enabled = false;
                
                noteLabel.Text += $"{Environment.NewLine}The final pay is determined by subtracting 10% for income tax and adding 2% for contract incentives from the calculated pay";
         

            }
            else if(typeOfEmployeeComboBox.SelectedIndex == 1)
            {
                //disabling all other boxes    
                tempContractEmployeeGroupBox.Enabled = true;
                contractEmployeeGroupBox.Enabled = false;
                hourlyEmployeeGroupBox.Enabled = false;           
                fixedSalaryTextBox.Enabled = false;
                fixedSalaryLabel.Enabled = false;
                string message = $"{Environment.NewLine}The final pay includes the calculated pay plus a 0.5% temporary contract incentive";

                //Using Anonymous Method
                NoteDelegate noteDelegate1 = delegate (string s)
                {
                    noteLabel.Text += s;
                };
                noteDelegate1(message);
                

            }
            else if (typeOfEmployeeComboBox.SelectedIndex == 2)
            {
                //disabling all other boxes 
                contractEmployeeGroupBox.Enabled = false;
                tempContractEmployeeGroupBox.Enabled = false;
                hourlyEmployeeGroupBox.Enabled = false;           
                fixedSalaryTextBox.Enabled = true;
                fixedSalaryLabel.Enabled = true;
                string message = $"{Environment.NewLine}The final pay is calculated by applying a 10% income tax reduction and a 5% gratuity deduction to the calculated pay.";

                //Using Lambda Expressions
                NoteDelegate noteDelegate2 = (s) =>
                {
                    noteLabel.Text += s;
                };
                noteDelegate2(message);

            }
            else if (typeOfEmployeeComboBox.SelectedIndex == 3)
            {
                hourlyEmployeeGroupBox.Enabled = true;
                contractEmployeeGroupBox.Enabled = false;
                tempContractEmployeeGroupBox.Enabled = false;
                fixedSalaryTextBox.Enabled = false;
                fixedSalaryLabel.Enabled = false;

                //Directly Calling method
                this.Note(typeOfEmployeeComboBox.Text);
                NoteDelegate noteDelegate3 = new NoteDelegate(NoteForHourlyPay);
                noteDelegate3($"{Environment.NewLine}The final pay is determined by multiplying the hours worked by the pay rate.");

            }
            
        }
        private void NoteForHourlyPay(string s)
        {
            noteLabel.Text += s;
        }//end note for hourly pay method

        private void SalaryCalculatorForm_Load(object sender, EventArgs e)
        {
           /* contractEmployeeGroupBox.Visible = false;
            tempContractEmployeeGroupBox.Visible = false;
            fixedSalaryTextBox.Visible=false;
            label8.Visible=false;*/
            noteLabel.Text = "Taxes are Calculated based on the PayRate";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            typeOfEmployeeComboBox.SelectedIndex = -1;
            hourlyWagetextBox.Text = string.Empty;
            hoursWorkedtextBox.Text = string.Empty;
            resultLabel.Text = string.Empty;
            contractPeriodtextBox.Text = string.Empty;
            payRateTextBox.Text = string.Empty;
            fixedSalaryTextBox.Text = string.Empty;
            contractEmployeeGroupBox.Enabled = true;
            tempContractEmployeeGroupBox.Enabled=true;
            fixedSalaryTextBox.Enabled = true;
            fixedSalaryLabel.Enabled=true;
            hourlyEmployeeGroupBox.Enabled = true;
        }

        private void CalculateSalaryButton_Click(object sender, EventArgs e)
        {
            string employeeType;
            string hourlyWage;
            string hoursWorked;
            string contractPeriod;
            string payRate;
            string fixedSalary;

            salaryCalculatorErrorProvider.Clear();
            if(typeOfEmployeeComboBox.SelectedIndex!=-1)
            {
                employeeType=typeOfEmployeeComboBox.SelectedItem.ToString();
                if(employeeType.Equals("Contract Employee"))
                {
                    /*if(validateEmployeeFields(hourlyWage,hoursWorked))
                    {

                    }*/
                }

            }
            else
            {
                //set error provider
                salaryCalculatorErrorProvider.SetError(typeOfEmployeeComboBox, "Select Type of Employee");
            }//end validate typeEmployee
        }//end calculateButton

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /* private bool validateEmployeeFields(string , string hoursWorked)
{


        //Function created by Anubha
}*/
        private void Note(string employeeType)
        {
            string noteMessage = $"The Salary Calculation are based on the Type of Employee.{Environment.NewLine}" +
                $"For selected Employee: {employeeType}";
            noteLabel.Text = noteMessage;
        }
    }
}
