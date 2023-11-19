using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                tempContractEmployeeGroupBox.Enabled = false;
                contractEmployeeGroupBox.Enabled = true;
                hourlyEmployeeGroupBox.Enabled = false;
                fixedSalaryTextBox.Enabled = false;
                fixedSalaryLabel.Enabled = false;

                noteLabel.Text += $"{Environment.NewLine}The final pay is determined by subtracting 10% for income tax and adding 2% for contract incentives from the calculated pay";


            }
            else if (typeOfEmployeeComboBox.SelectedIndex == 1)
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
            noteLabel.Text = "Taxes are Calculated based on the Type of Employee.";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            typeOfEmployeeComboBox.SelectedIndex = -1;
            hourlyWagetextBox.Text = string.Empty;
            hoursWorkedtextBox.Text = string.Empty;
            resultLabel.Text = string.Empty;
            payRateTextBox.Text = string.Empty;
            durationTextBox.Text = string.Empty;
            fixedSalaryTextBox.Text = string.Empty;
            contractEmployeeGroupBox.Enabled = true;
            tempContractEmployeeGroupBox.Enabled = true;
            fixedSalaryTextBox.Enabled = true;
            fixedSalaryLabel.Enabled = true;
            hourlyEmployeeGroupBox.Enabled = true;
        }

        private void CalculateSalaryButton_Click(object sender, EventArgs e)
        {
            string employeeType;
            double hourlyWage;
            double hoursWorked;
            double duration;
            double payRate;
            double fixedSalary;

            salaryCalculatorErrorProvider.Clear();
            if (typeOfEmployeeComboBox.SelectedIndex != -1)
            {
                employeeType = typeOfEmployeeComboBox.SelectedItem.ToString();
                
                    switch(employeeType)
                    {
                        case "HourlyEmployee":
                            if (validateInput(hourlyWagetextBox, "Please enter a valid hourly wage.", out hourlyWage))
                            {
                                // Check hours worked textbox
                                if (validateInput(hoursWorkedtextBox, "Please enter a valid number of hours worked.", out hoursWorked))
                                {
                                    // Calculate hourly employee salary
                                }
                            }
                            break;
                        case "Salaried Employee":
                            if (validateInput(fixedSalaryTextBox, "Please enter a valid  salary.", out fixedSalary))
                            {
                                // Calculate salaried employee salary
                            }
                            break;
                        case "Temp Contract Employee":
                            if (validateInput(durationTextBox, "Please enter a valid  Duration Period.", out duration))
                            {
                                
                                if (validateInput(payRateTextBox, "Please enter a valid Pay Rate.", out payRate))
                                {
                                    // Calculate Temp employee salary
                                }
                            }
                            break;
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
        
        //Function created by Anubha
        private void Note(string employeeType)
        {
            string noteMessage = $"The Salary Calculation are based on the Type of Employee.{Environment.NewLine}" +
                $"For selected Employee: {employeeType}";
            noteLabel.Text = noteMessage;
        }
        //added by vineela
        private bool validateInput(TextBox textBox, string errorMessage, out double value)
        {
            if (double.TryParse(textBox.Text, out value) || value < 0)
            {
                return true;
            }
            else
            {
                salaryCalculatorErrorProvider.SetError(textBox, errorMessage);
                return false;
            }
        }
    }
}
