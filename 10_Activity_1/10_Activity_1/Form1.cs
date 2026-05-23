using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserNamespace;

namespace _10_Activity_1
{
    public partial class Form1 : Form
    {
        Admininistrator admin = new Admininistrator("Jester", "admin01", "12345");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (admin.verifyLogin(txtUserID.Text, txtPass.Text))
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            admin.updateAdminName(txtUpdateName.Text);

            MessageBox.Show("Admin Name Updated");
        }

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            admin.updatePassword(txtNewPass.Text);

            MessageBox.Show("Password Updated");
        }
    }
}
