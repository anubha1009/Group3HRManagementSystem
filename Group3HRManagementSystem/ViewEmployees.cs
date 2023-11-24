using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3HRManagementSystem
{
    //Created by Vineela Modified by Anubha
    public partial class ViewEmployees : Form
    {
        private TextBox lastFocusedTextBox;

        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//close the application.

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchByEmployeeNameTextBox.Text = string.Empty;
            searchByEmployeeIdTextBox.Text = string.Empty;
            employeeDescriptionLabel.Text = string.Empty;
            // Clear button clicked, enable all text boxes
            DataIntermediaryClass intermediaryClass = new DataIntermediaryClass();
            viewEmployeeDataGridView.DataSource = intermediaryClass.GetJoinTable();
           

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string employeeName;
            int employeeId;
            string employeeType;
            employeeName = searchByEmployeeNameTextBox.Text;
          
           
          
                employeeType=employeeTypeComboBox.SelectedItem.ToString();
            

            int.TryParse(searchByEmployeeIdTextBox.Text, out employeeId);
                DataIntermediaryClass intermediaryClass = new DataIntermediaryClass();
                viewEmployeeDataGridView.DataSource = intermediaryClass.SearchEmployee(employeeId, employeeName, employeeType);
                viewEmployeeDataGridView.AllowUserToAddRows= false;
                viewEmployeeDataGridView.AllowUserToDeleteRows= false;
            if (intermediaryClass.DBError != null)
            {
                errorLabel.Text = intermediaryClass.DBError.ToString();
            }
            

            
            
        }
        //Written by Anubha Vishwakarma
        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
            DataTable dataTable = dataIntermediaryClass.GetJoinTable();
            viewEmployeeDataGridView.DataSource = dataTable;
            viewEmployeeDataGridView.AutoResizeColumns();
            viewEmployeeDataGridView.ScrollBars= ScrollBars.Both;
            viewEmployeeDataGridView.AllowUserToDeleteRows= false;
            viewEmployeeDataGridView.AllowUserToAddRows= false;
            if(dataIntermediaryClass.DBError != null)
            {
                errorLabel.Text = dataIntermediaryClass.DBError.ToString();
            }
            else
            {
                errorLabel.Text = "Please select the Employee to view full details ";
            }
            //FOR EMPLOYEE TYPE COMBO BOX
            //lambda function to get all the classes that implement IEmployee interface
           
            List<string> employeeTypeNames = AppDomain.CurrentDomain.GetAssemblies()
                                               .SelectMany(s => s.GetTypes())
                                               .Where(p => typeof(IEmployee).IsAssignableFrom(p) && !p.IsInterface)
                                               .Select(t => t.Name)
                                               .ToList();
            employeeTypeNames.Add("- No Selection -");
            //Replacing the name for Employee class
            for (int i = 0; i < employeeTypeNames.Count; i++)
            {
                if (employeeTypeNames[i].Equals("EmployeeClass"))
                {
                    employeeTypeNames[i] = "SalariedEmployee";
                }
            }
            //assigning value of list to the combobox
            employeeTypeComboBox.DataSource = employeeTypeNames;


        }//end view employee
        //handeling selection change
        private void TextBoxSelectionCheck()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = (textBox == lastFocusedTextBox);
                }
            }
        }//end TextBox selection change
        //Created custom event
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextBox focusedTextBox)
            {
                lastFocusedTextBox = focusedTextBox;
                TextBoxSelectionCheck();
            }
        }//custom event 

        //to display data whenever a cell is selected
        private void viewEmployeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string employeeId="0"; object value = null; object firstName = null; object lastName = null; object projectName = null;
            // Check if a valid row is selected
            if (e.RowIndex >= 0 && e.RowIndex < viewEmployeeDataGridView.Rows.Count)
            {
                 value = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeeId"].Value;
                firstName = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeeFirstName"].Value;
                lastName = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeeLastName"].Value;
                projectName = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["ProjectName"].Value;
                // Check if the value is not null
                if (value != null)
                {
                    // Convert the value to a string
                     employeeId = value.ToString();
                }
            }
            DataIntermediaryClass intermediaryClass = new DataIntermediaryClass();
            employeeDescriptionLabel.Text = $"Employee Id:{value.ToString()} and {Environment.NewLine}Name:{firstName} {lastName} {Environment.NewLine}" +
                $"is assigned to the project {projectName}{Environment.NewLine}" +
                $"where the description is:{Environment.NewLine}";
            employeeDescriptionLabel.Text += intermediaryClass.GetProjectDescriptionFromEmployeeId(employeeId);
        }
    }//end class
}//end namespace
