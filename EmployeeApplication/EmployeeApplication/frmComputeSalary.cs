using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }
        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string dept = txtDepartment.Text;
            string job = txtJobTitle.Text;

            if (!double.TryParse(txtRatePerHour.Text, out double rate) || !int.TryParse(txtHoursWorked.Text, out int hours))
            {
                MessageBox.Show("Please enter valid numeric values for " + "Rate per Hour and Total Hours Worked.");
                return;
            }

            PartTimeEmployee emp = new PartTimeEmployee(fname, lname, dept, job);
            emp.computeSalary(hours, rate);

            lblFirstName.Text = emp.FirstName;
            lblLastName.Text = emp.LastName;
            lblBasicSalary.Text = emp.BasicSalary.ToString("F2");
        }
    }
}
