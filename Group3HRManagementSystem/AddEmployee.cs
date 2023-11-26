using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Group3HRManagementSystem
{
    /*Validated by vineela pendam Implemented by Anubha Vishwakarma*/
    public partial class AddEmployeeDetails : Form
    {
        //step2 private static variable
        private static AddEmployeeDetails addEmployeeInstance;
        private AddEmployeeDetails()//making constructor as private
        {
            InitializeComponent();
        }
        //step 3 create public static method
        public static AddEmployeeDetails GetSTForm()
        {
           
            //step 4:instantiate stInstance variable ,if null 
            if (addEmployeeInstance == null)
            {
                addEmployeeInstance = new AddEmployeeDetails();
            }
            return addEmployeeInstance;
        }//close method
        //step 5:making instance null on form closing
        private void AddEmployeeDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            addEmployeeInstance = null;
        }//forming closing

        //Implemented by Anubha Vishwakarma
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
            addEmployeeValidationErrorProvider.Clear();
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string emailId = emailTextBox.Text;
            string contactNumber = contactNumberTextBox.Text;
            string employeeType = employeeTypeComboBox.SelectedItem.ToString();
            int projectId = int.Parse(projectComboBox.SelectedValue.ToString());
            string payRate = payRateTextBox.Text;
            string grade = gradeComboBox.SelectedItem.ToString();
         
            DateTime employeeHireDate = employeeHireDateTimePicket.Value.Date;

            if (ValidateAddEmployeeForm(firstName,lastName,emailId,contactNumber,payRate))
            {
                //Query for insert 
                try
                {
                    if ((dataIntermediaryClass.AddEmployee(firstName, lastName, emailId, contactNumber, employeeHireDate, projectId, employeeType, payRate, grade)) != -1)
                    {
                        resultLabel.Text = $"1 Employee Inserted with name {firstName} {lastName}";
                        //clear controls
                        firstNameTextBox.Clear();
                        lastNameTextBox.Clear();
                        emailTextBox.Clear();
                        contactNumberTextBox.Clear();
                        payRateTextBox.Clear();

                        // update the datagrid

                        allEmployeeDataGridView.DataSource = dataIntermediaryClass.GetAllEmployees();
                        allEmployeeDataGridView.AllowUserToAddRows = false;
                        allEmployeeDataGridView.AllowUserToDeleteRows = false;
                        allEmployeeDataGridView.ScrollBars = ScrollBars.Both;
                    }
                    else
                    {
                        MessageBox.Show("Insert Failed", "Cannot Complete Operation", MessageBoxButtons.OK);
                       
                    }//if add unsuccessful

                }//end try
                catch (Exception)
                {
                    resultLabel.Text = dataIntermediaryClass.DBError;
                }//if add unsuccessfull
            }//end validate
           
            
        }//end add employee
        private bool ValidateAddEmployeeForm(string firstName, string lastName, string emailId,  string contactNumber, string payRate)
        {

            addEmployeeValidationErrorProvider.Clear();
            bool isFormValid = false;
            if (!string.IsNullOrEmpty(firstName))
            {
                if (!string.IsNullOrEmpty(lastName))
                {
                    if (!string.IsNullOrEmpty(emailId) && IsEmailValid(emailId))
                    {
                        //validate emailID
                        if (!string.IsNullOrEmpty(contactNumber) && IsPhoneValid(ref contactNumber))
                        {
                            //isFormValid = true;

                            // validate if pay rate is double
                            if (double.TryParse(payRate, out _)){
                                isFormValid = true;
                            }

                            else
                            {
                                isFormValid= false;
                                addEmployeeValidationErrorProvider.SetError(payRateTextBox, "Enter a valid number in Pay Rate");
                            }
                        }
                        else
                        {
                            isFormValid = false;
                            addEmployeeValidationErrorProvider.SetError(contactNumberTextBox, "Enter a valid Mobile Number");
                        }
                    }
                    else
                    {
                        isFormValid = false;
                        addEmployeeValidationErrorProvider.SetError(emailTextBox, "Enter a valid Email Id");
                    }
                }
                else
                {
                    isFormValid = false;
                    addEmployeeValidationErrorProvider.SetError(lastNameTextBox, "Enter Your Last Name");
                }
                
            }
            else
            {
                isFormValid = false;
                addEmployeeValidationErrorProvider.SetError(firstNameTextBox, "Enter Your First Name");
            }
            return isFormValid;
        }//End validate addEmployee form
        //Email Validation
        private bool IsEmailValid(string emailaddress)
        {
            return Regex.IsMatch(emailaddress, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }//end Email Validation
        //Phone number Validation
        private bool IsPhoneValid(ref string phoneNumber)
        {

            Regex phoneRegex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

            if (phoneRegex.IsMatch(phoneNumber))
            {
                phoneNumber = phoneRegex.Replace(phoneNumber, "($1) $2-$3");
                return true;
            }
            else
            {
                return false;
            }
        }//end Phone Number Validation

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            addEmployeeInstance = null;
        }//close form
        //Added by Anubha Vishwakarma
        private void AddEmployeeDetails_Load(object sender, EventArgs e)
        {
            //FOR EMPLOYEE TYPE COMBO BOX
            //lambda function to get all the classes that implement IEmployee interface
         List<string> employeeTypeNames = AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(s => s.GetTypes())
        .Where(p => typeof(IEmployee).IsAssignableFrom(p) && !p.IsInterface)
        .Select(t => t.Name)
        .ToList();
            //Replacing the name for Employee class
            for (int i = 0; i < employeeTypeNames.Count; i++)
            {
                if (employeeTypeNames[i].Equals("EmployeeClass"))
                {
                    employeeTypeNames[i] = "SalariedEmployee";
                }//end if
            }//end for
            //assigning value of list to the combobox
            employeeTypeComboBox.DataSource = employeeTypeNames;
            gradeComboBox.SelectedIndex = 0;

            //FOR PROJECT COMBOBOX
            DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
            DataTable dataTable = dataIntermediaryClass.GetAllProjects();
            BindingSource projectbindingSource = new BindingSource();
            projectbindingSource.DataSource = dataTable;
       
            //Databinding in combobox
            projectComboBox.DataSource = projectbindingSource;
            projectComboBox.ValueMember = "ProjectId";
            projectComboBox.DisplayMember = "ProjectName";
            projectComboBox.DataBindings.Add("Text", projectbindingSource, "ProjectName", false, DataSourceUpdateMode.Never);

            //display all employee details
            allEmployeeDataGridView.DataSource = dataIntermediaryClass.GetAllEmployees();
            allEmployeeDataGridView.AllowUserToAddRows = false;
            allEmployeeDataGridView.AllowUserToDeleteRows = false;
            allEmployeeDataGridView.ScrollBars = ScrollBars.Both;
        }//end form load
    }//end class
}//end namespoace
