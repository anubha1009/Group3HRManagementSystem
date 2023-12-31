﻿using System;
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
        }//end add employee

       

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //added by vineela pendam
            AddProjectDetails addProjectDetails = AddProjectDetails.GetSTForm2();
            addProjectDetails.MdiParent = this;
            addProjectDetails.Show();
        }//end add project

        private void salaryCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Added by Anubha Vishwakarma
            SalaryCalculatorForm salaryCalculator = new SalaryCalculatorForm();
            salaryCalculator.MdiParent = this;
            salaryCalculator.Show();
        }//end salary calculator

        private void viewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Added by Anubha Vishwakarma
            Project_View projectView = new Project_View();
            projectView.MdiParent = this;
            projectView.Show();
        }//end view project

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Added by Anubha Vishwakarma
            ViewEmployees employeeView = new ViewEmployees();
            employeeView.MdiParent = this;
            employeeView.Show();
        }//end view employee
    }//end MainForm Class
}//end Namespace
