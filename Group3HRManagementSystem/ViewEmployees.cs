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
    public partial class ViewEmployees : Form
    {
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
            
        }
    }
}
