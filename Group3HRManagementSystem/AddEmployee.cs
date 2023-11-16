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
    /*created by vineela pendam*/
    public partial class AddEmployeeDetails : Form
    {
        //step2 private static variable
        private static AddEmployeeDetails addEmployeeInstance;
        private AddEmployeeDetails()//making constructor as private
        {
            InitializeComponent();
        }
        //step 3 create public static method
        public static AddEmployeeDetails GetSTForm()
        {
            //step 4:instantiate stInstance variable ,if null 
            if (addEmployeeInstance == null)
            {
                addEmployeeInstance = new AddEmployeeDetails();
            }
            return addEmployeeInstance;
        }//close method
        //step 5:making instance null on form closing
        private void AddEmployeeDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            addEmployeeInstance = null;
        }//forming closing

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
        }
    }
}
