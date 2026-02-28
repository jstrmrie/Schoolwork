using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void btn_average_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_english.Text == "" || tb_math.Text == "" || tb_science.Text == "" || tb_filipino.Text == "" || tb_history.Text == "" )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            double english = double.Parse(tb_english.Text);
            double math = double.Parse(tb_math.Text);
            double science = double.Parse(tb_science.Text);
            double filipino = double.Parse(tb_filipino.Text);
            double history = double.Parse(tb_history.Text);

            double average = (english + math + science + filipino + history) / 5;

            string status;

            if (average >= 75)
            {
                status = "passed";
            }
            else
            {
                status = "failed";
            }

            lbl_message.Text = "The student " + status + "."
                + "\nThe general average of student " + tb_name.Text + " is " + average + "." ;
        }
    }
}
