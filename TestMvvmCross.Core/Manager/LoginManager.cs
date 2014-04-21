using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvvmCross.Core.Manager
{
    public class LoginManager:ILoginManager
    {
        public bool IsValidLogin(string username, string password)
        {
            if (username.Equals("hyd") && password.Equals("kol"))
                return true;
            else
                return false;

        }
    }
}
