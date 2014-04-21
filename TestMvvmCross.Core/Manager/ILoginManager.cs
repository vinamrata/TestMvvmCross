using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvvmCross.Core.Manager
{
   public interface ILoginManager
    {
       bool IsValidLogin(string username, string password);
    }
}
