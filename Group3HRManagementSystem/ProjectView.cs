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
    public partial class ProjectView: Form
    {
        public ProjectView()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            viewProjectErrorProvider.Clear();
            string projectName;
            int projectId;
            projectName=searchProjectByNameTextBox.Text;
            int.TryParse(searchByIdTextBox.Text,out projectId);
            if(!string.IsNullOrEmpty(projectName) || projectId>0)
            {
                // create validate method
                // ValidateProjectViewDeatils(projectName, projectId)
            }
            else
            {
                MessageBox.Show("Please Enter Either Project Name or Project Id", "Invalid Input", MessageBoxButtons.OK);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchProjectByNameTextBox.Text = string.Empty;
            searchByIdTextBox.Text = string.Empty;  
        }
    }
}
