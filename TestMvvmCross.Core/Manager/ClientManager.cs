using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMvvmCross.Core.Model;

namespace TestMvvmCross.Core.Manager
{
   public class ClientManager:IClientManager
    {
        public List<ClientDetails> GetAllClients()
        {
            return GetAllClientDetails();
        }

        private List<ClientDetails> GetAllClientDetails()
        {
            var clientList = new List<ClientDetails>();
            clientList.Add(new ClientDetails() { Name = "John", Account = "1223234244", ImageUrl = "img10.png", Phone = "8981489359", Address = "DLF Cyber City, Gachibowli, Hyderabad, Andhra Pradesh" });
            clientList.Add(new ClientDetails() { Name = "Ted", Account = "33453645667", ImageUrl = "img14.png", Phone = "8981489359", Address = "Inorbit Mall Rd, D Block, Kavuri Hills, Hitech City, Hyderabad, AP" });
            clientList.Add(new ClientDetails() { Name = "Lilly", Account = "8989878778", ImageUrl = "img3.png", Phone = "8981489359", Address = "ISC-2, Plot no H0IA, survey no 30(P),Phoenix Sez Access Rd, Siddiq Nagar, Hitech City, Hyderabad, Andhra Pradesh" });
            clientList.Add(new ClientDetails() { Name = "Barney", Account = "458623467345", ImageUrl = "img2.png", Phone = "8981489359", Address = "#129-132,DLF Building, Block-1,APHB Colony, Gachibowli, Hyderabad, Andhra Prades" });
            clientList.Add(new ClientDetails() { Name = "Marvin", Account = "682342345448", ImageUrl = "img5.png", Phone = "8981489359", Address = "Plot.No: 129,130,131 & 132 APHB Colony, Gachibowli, Hyderabad, Andhra Pradesh" });
            clientList.Add(new ClientDetails() { Name = "Robin", Account = "343253454355", ImageUrl = "img3.png", Phone = "8981489359", Address = "Phoenix Sez Access Rd, Siddiq Nagar, Hitech City, Hyderabad, Andhra Pradesh" });
            clientList.Add(new ClientDetails() { Name = "Naruto", Account = "234456767545", ImageUrl = "img7.png", Phone = "8981489359", Address = "DLF Cyber City, Gachibowli, Hyderabad, Andhra Pradesh" });
            clientList.Add(new ClientDetails() { Name = "Saskey", Account = "9090897897889", ImageUrl = "img9.png", Phone = "8981489359", Address = "Inorbit Mall Rd, D Block, Kavuri Hills, Hitech City,Hyderabad, Andhra Pradesh" });

            return clientList;
        }

    }
}
