using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Created By Anubha Vishwakarma
namespace Group3HRManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Exit from application

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Added by Vineela Pendam
            
            //1. instantiate the about form
            AboutBox aboutBox = new AboutBox();
            //2.make the about box child form to main form
            aboutBox.MdiParent = this;
            //3.show the about form
            aboutBox.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //added by vineela pendam
            AddEmployeeDetails addEmployeeDetails = AddEmployeeDetails.GetSTForm();
            addEmployeeDetails.MdiParent = this;
            addEmployeeDetails.Show();
        }

       

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //added by vineela pendam
            AddProjectDetails addProjectDetails = new AddProjectDetails();
            addProjectDetails.MdiParent = this;
            addProjectDetails.Show();
        }

        private void salaryCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryCalculatorForm salaryCalculator = new SalaryCalculatorForm();
            salaryCalculator.MdiParent = this;
            salaryCalculator.Show();
        }
    }//end MainForm Class
}//end Namespace
