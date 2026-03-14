using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplicationOld
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
            ListComboBoxes();
        }

        private void ListComboBoxes()
        {
            for (int i = 1; i <= 31; i++)
            {
                cbboxDay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                cbboxMonth.Items.Add(i);
            }

            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cbboxYear.Items.Add(i);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text == "" || tbFirstName.Text == "" || tbMiddleName.Text == "" || (!rdbtnMale.Checked && !rdbtnFemale.Checked) || cbboxDay.SelectedItem == null || cbboxMonth.SelectedItem == null || cbboxYear.SelectedItem == null )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            
            string name = tbFirstName.Text + " " + tbMiddleName.Text + " " + tbLastName.Text;


            string gender = "";

            if (rdbtnMale.Checked)
            {
                gender = "Male";
            }

            else if (rdbtnFemale.Checked)
            {
                gender = "Female";
            }

            MessageBox.Show("Student name: " + name +
                "\nGenderss: " + gender +
                "\nDate of birth: " + cbboxDay.SelectedItem + "/" + cbboxMonth.SelectedItem + "/" + cbboxYear.SelectedItem);
        }
    }
}
