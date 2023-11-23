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

namespace Group3HRManagementSystem
{
    /*created by vineela pendam*/
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

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            addEmployeeValidationErrorProvider.Clear();
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string emailId = emailTextBox.Text;
            string contactNumber = contactNumberTextBox.Text;
            if (ValidateAddEmployeeForm(firstName,lastName,emailId,contactNumber))
            {

            }
            else {
                
            }
            
        }
        private bool ValidateAddEmployeeForm(string firstName, string lastName, string emailId,  string contactNumber)
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
                            isFormValid = true;
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
        }
    }
}
