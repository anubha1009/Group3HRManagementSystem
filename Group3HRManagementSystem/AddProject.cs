using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group3HRManagementSystem
{
    /*created  by vineela pendam Implemented by Anubha Vishwakarma */ 
    public partial class AddProjectDetails : Form
    {
        //step2 private static variable
        private static AddProjectDetails addProjectInstance;
        private AddProjectDetails()//making constructor as private
        {
            InitializeComponent();
        }
        //step 3 create public static method
        public static AddProjectDetails GetSTForm2()
        {
            //step 4:instantiate stInstance variable ,if null 
            if (addProjectInstance == null)
            {
                addProjectInstance = new AddProjectDetails();
            }
            return addProjectInstance;
        }//close method
         //step 5:making instance null on form closing
        private void AddProjectDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            addProjectInstance = null;
        }//forming closing

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            addProjectInstance = null;
        }//end closes the application

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
            addProjectDetailsErrorProvider.Clear();
            string projectName=projectNameTextBox.Text;
            decimal projectHourAllocated = hoursAllocatedNumericUpDown.Value;
            double estimatedBudget;
            string projectDescription=projectDescriptionRichTextBox.Text;
            double.TryParse(estimatedBudgetTextBox.Text, out estimatedBudget);
            if (ValidateAddProjectForm(projectName, projectHourAllocated, estimatedBudget, projectDescription))
            {
                try
                {
                    if ((dataIntermediaryClass.AddProject(projectName, (int)projectHourAllocated, estimatedBudget, projectDescription)) != -1)
                    {
                        resultLabel.Text = $"New Project with {projectName} added";
                        //clear controls
                        projectNameTextBox.Clear();
                        estimatedBudgetTextBox.Clear();
                        projectDescriptionRichTextBox.Clear();
                        hoursAllocatedNumericUpDown.Value = 0;
                        // update the datagrid
                      
                        allProjectDataGridView.DataSource = dataIntermediaryClass.GetAllProjects();
                        allProjectDataGridView.AllowUserToAddRows = false;
                        allProjectDataGridView.AllowUserToDeleteRows = false;
                        allProjectDataGridView.ScrollBars = ScrollBars.Both;
                    }//if successful
                    else
                    {
                       
                        MessageBox.Show("Insert Failed","Cannot Complete Operation",MessageBoxButtons.OK);
                    }//end else

                }catch(Exception)
                {
                    resultLabel.Text = dataIntermediaryClass.DBError;
                }//catch exception
            }
            else
            {
                MessageBox.Show("The Fields Cannot be Validated", "Field Error", MessageBoxButtons.OK);
            }//end field validation

        }//end add project

        private bool ValidateAddProjectForm(string projectName, decimal projectHoursAllocated, double estimatedBudget, string projectDescription)
        {
            bool isValid = true;

            // Validate Project Name
            if (string.IsNullOrWhiteSpace(projectName))
            {
                addProjectDetailsErrorProvider.SetError(projectNameTextBox, "Project name is required");
                isValid = false;
            }
            else
            {
                addProjectDetailsErrorProvider.SetError(projectNameTextBox, null);
            }

            // Validate Project Hours Allocated
            if (projectHoursAllocated <= 0)
            {
                addProjectDetailsErrorProvider.SetError(hoursAllocatedNumericUpDown, "Project hours allocated must be greater than 0");
                isValid = false;
            }
            else
            {
                addProjectDetailsErrorProvider.SetError(hoursAllocatedNumericUpDown, null);
            }

            // Validate Estimated Budget
            if (estimatedBudget <= 0)
            {
                addProjectDetailsErrorProvider.SetError(estimatedBudgetTextBox, "Estimated budget must be greater than 0");
                isValid = false;
            }
            else
            {
                addProjectDetailsErrorProvider.SetError(estimatedBudgetTextBox, null);
            }

            return isValid;
        }//end validate function

        private void AddProjectDetails_Load(object sender, EventArgs e)
        {
            DataIntermediaryClass intermediaryClass = new DataIntermediaryClass();
            allProjectDataGridView.DataSource = intermediaryClass.GetAllProjects();
            allProjectDataGridView.AllowUserToAddRows = false;
            allProjectDataGridView.AllowUserToDeleteRows = false;
            allProjectDataGridView.ScrollBars = ScrollBars.Both;
        }//populate all projects at load
    }//end class
}//end namespace
