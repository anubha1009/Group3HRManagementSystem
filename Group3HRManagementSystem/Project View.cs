using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Created by Neha
namespace Group3HRManagementSystem
{
    public partial class Project_View: Form
    {
        public Project_View()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Project_View_Load(object sender, EventArgs e)
        {
            DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
            DataTable dataTable = dataIntermediaryClass.GetAllProjects();
            BindingSource projectbindingSource = new BindingSource();
            projectbindingSource.DataSource = dataTable;
            //Databinding for Project
            budgetLabel.DataBindings.Add("Text", projectbindingSource, "ProjectBudget", false, DataSourceUpdateMode.Never);
            descriptionLabel.DataBindings.Add("Text", projectbindingSource, "ProjectDescription", false, DataSourceUpdateMode.Never);
            durationLabel.DataBindings.Add("Text", projectbindingSource, "ProjectHourAllocated", false, DataSourceUpdateMode.Never);
            //Databinding in combobox
            projectComboBox.DataSource = projectbindingSource;
            projectComboBox.ValueMember = "ProjectId";
            projectComboBox.DisplayMember = "ProjectName";
            projectComboBox.DataBindings.Add("Text", projectbindingSource, "ProjectName", false, DataSourceUpdateMode.Never);
           
        }

        private void getEmployeesButton_Click(object sender, EventArgs e)
        {
            
            string projectId = projectComboBox.SelectedValue.ToString();
            DataIntermediaryClass intermediaryClass = new DataIntermediaryClass();
            employeeListDataGridView.DataSource = intermediaryClass.GetEmployeesForProject(projectId);
            employeeListDataGridView.AllowUserToAddRows = false;
            employeeListDataGridView.AllowUserToDeleteRows = false;
            if(intermediaryClass.DBError != null)
            {
                errorLabel.Text = intermediaryClass.DBError.ToString();
            }
            else
            {
                int rowCount = employeeListDataGridView.Rows.Count;
                errorLabel.Text = $"The {projectComboBox.Text} has {rowCount} employees working.";
            }
        }
    }//end class
}//end namespace
