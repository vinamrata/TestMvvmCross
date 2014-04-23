using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMvvmCross.Core.Model;

namespace TestMvvmCross.Core.Manager
{
   public interface IClientManager
    {
       List<ClientDetails> GetAllClients();
    }
}
