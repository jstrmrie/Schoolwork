using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{

    public abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string username, string password)
        {
            this.full_name = name;
            this.user_name = username;
            this.user_password = password;
        }

        public abstract bool ValidateLogin(string username, string password);

        public string GetFullName()
        {
            return full_name;
        }
    }
}
