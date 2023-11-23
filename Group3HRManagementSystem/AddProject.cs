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
    /*created  by vineela pendam*/
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
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            addProjectDetailsErrorProvider.Clear();
            string projectName=projectNameTextBox.Text;
            decimal projectHoursAllocated = hoursAllocatedNumericUpDown.Value;
            double estimatedBudget;
            string projectDescription=projectDescriptionRichTextBox.Text;
            double.TryParse(estimatedBudgetTextBox.Text, out estimatedBudget);
            if (ValidateAddProjectForm(projectName, projectHoursAllocated, estimatedBudget, projectDescription))
            {

            }
            else
            {

            }

        }

        private bool ValidateAddProjectForm(string projectName, decimal projectHoursAllocated, double estimatedBudget, string projectDescription)
        {
            throw new NotImplementedException();
        }
    }
}
