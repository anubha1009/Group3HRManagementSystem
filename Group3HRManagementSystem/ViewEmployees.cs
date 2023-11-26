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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Group3HRManagementSystem
{
    //Validations by Vineela Implementation by Anubha
    public partial class ViewEmployees : Form
    {
        private TextBox lastFocusedTextBox;
        private List<Project> allProjects; //global variable for all projects
        private string employeeId;

        public ViewEmployees()
        {
            InitializeComponent();
            //Storing all the projects in a list
            DataTable allProjectsDataTable = this.getAllProjects();
            allProjects = new List<Project>();
            foreach(DataRow row in allProjectsDataTable.Rows)
            {
                Project project = new Project
                {
                    ProjectId = Convert.ToInt32(row["ProjectId"]),
                    Name = row["ProjectName"].ToString(),
                    Description = row["ProjectDescription"].ToString(),
                    HoursAllocated = Convert.ToInt32(row["ProjectHourAllocated"]),
                    Budget = Convert.ToDouble(row["ProjectBudget"])
                };
                allProjects.Add(project);
            }//end foreach 
            //disable update group box
           
            updateEmployeeDetailsGroupBox.Enabled = false;

        }//end ctor

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

            updateEmployeeDetailsGroupBox.Enabled = false;
        }//end clear button 

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
            }//end if     
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
            viewEmployeeDataGridView.Columns["EmployeeFirstName"].ReadOnly = true;
            // Adding another column with update button
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Update";
            editButtonColumn.Text = "Update";
            editButtonColumn.Name = "Update";
            editButtonColumn.UseColumnTextForButtonValue = true;
            viewEmployeeDataGridView.Columns.Add(editButtonColumn);
            //added button
            this.SetButtonColumnText();
            if (dataIntermediaryClass.DBError != null)
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
        private void SetButtonColumnText()
        {
            foreach (DataGridViewRow row in viewEmployeeDataGridView.Rows)
            {
                // Set the text of the Edit button column
                DataGridViewButtonCell editButtonCell = (DataGridViewButtonCell)row.Cells["Update"];
                editButtonCell.Value = "Update";
            }
        }//end set gbutton method

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
        
        private DataTable getAllProjects()
        {
            try
            {
                DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
                DataTable allProjects = dataIntermediaryClass.GetAllProjects();
                return allProjects;
            }catch (Exception e)
            {
                errorLabel.Text = e.Message;
                return null;
            }
        }//end get all projects
        private void PopulateUpdateGroupBox(string firstName , string lastName , string employeeType ,string projectAllocated, string employeeSalary, string employeePerformance)
        {
            int projectId = 0; ;
            employeeFirstNameTextBox.Text = firstName;
            employeeLastNameTextBox.Text = lastName;
            employeeTypeTextBox.Text = employeeType;
            projectAssignedComboBox.DataSource = allProjects;
            projectAssignedComboBox.DisplayMember = "Name";
            projectAssignedComboBox.ValueMember = "ProjectId";
            employeeSalaryTextBox.Text = employeeSalary;
            //Selecting radio button
            switch (employeePerformance)
            {
                case "A":
                    ARadioButton.Checked = true;
                    BRadioButton.Checked = false;
                    CRadioButton.Checked = false;
                    DRadioButton.Checked = false;
                    break;

                case "B":
                    ARadioButton.Checked= false;
                    BRadioButton.Checked = true;
                    CRadioButton.Checked = false;
                    DRadioButton.Checked = false;
                    break;

                case "C":
                    ARadioButton.Checked= false;
                    BRadioButton.Checked= false;
                    CRadioButton.Checked = true;
                    DRadioButton.Checked = false;
                    break;
                case "NULL":
                    ARadioButton.Checked= false;
                    BRadioButton.Checked= false;
                    CRadioButton.Checked = false;
                    DRadioButton.Checked = true;
                    break;

                default:
                    break;
            }

            //to find the allocated project and select it 
            foreach (Project project in  allProjects )
            {
                if (projectAllocated.Equals(project.Name))
                {
                    projectId = project.ProjectId; break;
                }
            }
            projectAssignedComboBox.SelectedValue = projectId;
        }//end populate method
        private void disableReadOnlyFieldsInUpdate()
        {
            employeeFirstNameTextBox.Enabled = false;
            employeeTypeTextBox.Enabled = false;
        }

        private void viewEmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = viewEmployeeDataGridView.Rows[e.RowIndex];
                if (e.ColumnIndex == viewEmployeeDataGridView.Columns["Update"].Index)
                {
                    updateEmployeeDetailsGroupBox.Enabled = true;
                    employeeFirstNameTextBox.Enabled = false;
                    employeeTypeTextBox.Enabled = false;
                }
                else
                {
                    updateEmployeeDetailsGroupBox.Enabled = false;
                }
                string employeeId = "0"; object value = null; object firstName = null; object lastName = null; object projectName = null; object employeeType = null;
                object employeeSalary = null; object employeePerformance = null;
                // Check if a valid row is selected
                if (e.RowIndex >= 0 && e.RowIndex < viewEmployeeDataGridView.Rows.Count)
                {
                    //assigning the selected row values
                    value = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeeId"].Value;
                    firstName = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeeFirstName"].Value;
                    lastName = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeeLastName"].Value;
                    projectName = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["ProjectName"].Value;
                    employeeType = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeeType"].Value;
                    employeeSalary = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeePayRate"].Value;
                    employeePerformance = viewEmployeeDataGridView.Rows[e.RowIndex].Cells["EmployeePerformance"].Value;
                    // Check if the value is not null
                    if (value != null)
                    {
                        // Convert the value to a string
                        employeeId = value.ToString();
                        this.employeeId = employeeId;
                    }//end if
                }
                //populating text box
                DataIntermediaryClass intermediaryClass = new DataIntermediaryClass();
                employeeDescriptionLabel.Text = $"Employee Id:{value.ToString()} and {Environment.NewLine}Name:{firstName} {lastName} {Environment.NewLine}" +
                    $"is assigned to the project {projectName}" +
                    $" where the description is:";
                employeeDescriptionLabel.Text += intermediaryClass.GetProjectDescriptionFromEmployeeId(employeeId);
                this.PopulateUpdateGroupBox(firstName.ToString(), lastName.ToString(), employeeType.ToString(), projectName.ToString(), employeeSalary.ToString(), employeePerformance.ToString());
            }//end row index if
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //validations for update group box
            string lastName =  employeeLastNameTextBox.Text;
            double salary;
            string performance = GetSelectedPerformance();
            object projectId = projectAssignedComboBox.SelectedValue;
           //validations for update group box
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a valid last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(employeeSalaryTextBox.Text, out salary) || salary <= 0)
            {
                MessageBox.Show("Please enter a valid positive salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(performance))
            {
                MessageBox.Show("Please select a performance level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
            try
            {
                if((dataIntermediaryClass.UpdateEmployeeDetailsInEmployee(lastName,projectId.ToString(),this.employeeId) != -1)&&
                    dataIntermediaryClass.UpdateEmployeeDetails(salary, performance,this.employeeId) !=-1)
                {
                    employeeSalaryTextBox.Text = string.Empty;
                    ARadioButton.Checked = false;
                    BRadioButton.Checked = false;
                    CRadioButton.Checked = false;
                   
                    MessageBox.Show("Employee details updated", "Successfully Updated!", MessageBoxButtons.OK);
                    viewEmployeeDataGridView.DataSource = dataIntermediaryClass.GetJoinTable();

                    updateEmployeeDetailsGroupBox.Enabled = false;

                }
                else
                {
                    MessageBox.Show(dataIntermediaryClass.DBError);
                }
            }catch(Exception ex)
            {
                errorLabel.Text = ex.Message;   
            }
        }//update button 
        private string GetSelectedPerformance()
        {
            if (ARadioButton.Checked)
            {
                return "A";
            }
            else if (BRadioButton.Checked)
            {
                return "B";
            }
            else if (CRadioButton.Checked)
            {
                return "C";
            }
            else if (DRadioButton.Checked)
            {
                return "NULL";
            }

            // Return an empty string if no performance level is selected.
            return string.Empty;
        }//end get seleted performance 
    }//end class
}//end namespace
