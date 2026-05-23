using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public class Admininistrator : User
    {
        private string admin_name;

        public Admininistrator(string name, string id, string pass) : base(id, pass)
        {
            admin_name = name;
        }

        public void updatePassword(string newPassword)
        {
            user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            admin_name = name;
        }
    }
}
