using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3HRManagementSystem
{
    public partial class SalaryCalculatorForm : Form
    {
        public SalaryCalculatorForm()
        {
            InitializeComponent();
        }

        private void typeOfEmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeOfEmployeeComboBox.SelectedIndex == 0)
            {
                contractEmployeeGroupBox.Visible = true;
                contractEmployeeGroupBox.Enabled = true;
                // tempContractEmployeeGroupBox.Visible =false;
                tempContractEmployeeGroupBox.Enabled=false;
                fixedSalaryTextBox.Enabled = false;
                fixedSalaryLabel.Enabled = false;
            }
            else if(typeOfEmployeeComboBox.SelectedIndex == 1)
            {
                contractEmployeeGroupBox.Enabled = false;
                tempContractEmployeeGroupBox.Visible = true;
                tempContractEmployeeGroupBox.Enabled = true;
                fixedSalaryTextBox.Enabled = false;
                fixedSalaryLabel.Enabled = false;
            }
            else if (typeOfEmployeeComboBox.SelectedIndex == 2)
            {
                contractEmployeeGroupBox.Enabled = false;
                tempContractEmployeeGroupBox.Enabled = false;
                fixedSalaryTextBox.Visible = true;
                fixedSalaryLabel.Visible = true;
                fixedSalaryTextBox.Enabled = true;
                fixedSalaryLabel.Enabled = true;

            }
        }

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
       /* private bool validateEmployeeFields(string , string hoursWorked)
        {

        }*/
    }
}
