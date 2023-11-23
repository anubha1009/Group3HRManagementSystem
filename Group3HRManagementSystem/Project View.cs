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

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchProjectByNameTextBox.Text = string.Empty;
            searchProjectByIdTextBox.Text = string.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string projectName;
            int projectId;
            projectName = searchProjectByNameTextBox.Text;
            int.TryParse(searchProjectByIdTextBox.Text, out projectId);
            if (!(string.IsNullOrEmpty(projectName) && projectId == 0))
            {

                //write validate method in employee class

            }
            else
            {
                MessageBox.Show("Please Enter Either ProjectName or Project Id", "Invalid Input", MessageBoxButtons.OK);
            }
        }

        private void Project_View_Load(object sender, EventArgs e)
        {
            DataIntermediaryClass dataIntermediaryClass = new DataIntermediaryClass();
            DataTable dataTable = dataIntermediaryClass.GetAllProjects();

            projectViewDataGridView.DataSource = dataTable;
            projectViewDataGridView.AutoResizeColumns();
            projectViewDataGridView.ScrollBars = ScrollBars.Both;
            projectViewDataGridView.AllowUserToDeleteRows = false;
            projectViewDataGridView.AllowUserToAddRows = false;
            if (dataIntermediaryClass.DBError != null)
            {
                errorLabel.Text = dataIntermediaryClass.DBError.ToString();
            }
            else
            {
                errorLabel.Text = "No Errors are present";
            }
        }
    }
}
