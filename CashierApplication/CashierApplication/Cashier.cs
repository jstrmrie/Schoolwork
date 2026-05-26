using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string username, string password)
            : base(name, username, password)
        {
            this.department = department;
        }

        public override bool ValidateLogin(string username, string password)
        {
            return user_name.Equals(username) && user_password.Equals(password);
        }

        public string GetDepartment()
        {
            return department;
        }
    }
}
