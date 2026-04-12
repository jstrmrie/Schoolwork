using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
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

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string month in months)
            {
                cbboxMonth.Items.Add(month);
            }

            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cbboxYear.Items.Add(i);
            }

            ArrayList programs = new ArrayList();  
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in programs)
            {
                cbboxProgram.Items.Add(program);
            }

        }

        private void DisplayInfo(string name)
        {
            MessageBox.Show(
                "Student Info:" +
                "\nStudent name: " + name );
        }

        private void DisplayInfo(string name, string gender)
        {
            MessageBox.Show(
                "Student Info:" +
                "\nStudent name: " + name +
                "\nGender: " + gender);
        }

        private void DisplayInfo(string name, string gender, string dob, string program)
        {
            MessageBox.Show(
                "Student Info:" +
                "\nStudent name: " + name +
                "\nGender: " + gender +
                "\nDate of birth: " + dob +
                "\nProgram: " + program);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text == "" || tbFirstName.Text == "" || tbMiddleName.Text == "" || (!rdbtnMale.Checked && !rdbtnFemale.Checked) || cbboxDay.SelectedItem == null || cbboxMonth.SelectedItem == null || cbboxYear.SelectedItem == null || cbboxProgram.SelectedItem == null)
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

            string dob = cbboxDay.SelectedItem + "/" + cbboxMonth.SelectedItem + "/" + cbboxYear.SelectedItem;

            string program = Convert.ToString(cbboxProgram.SelectedItem);

            DisplayInfo(name);
            DisplayInfo(name, gender);
            DisplayInfo(name, gender, dob, program);


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Select a Photo";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture_profile.BackgroundImage = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }
    }
}
