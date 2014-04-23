using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMvvmCross.Core.Manager;
using TestMvvmCross.Core.Model;

namespace TestMvvmCross.Core.ViewModels
{
    public class ClientViewModel:MvxViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }
        private string _account;
        public string Account
        {
            get { return _account; }
            set { _account = value; RaisePropertyChanged(() => Account); }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; RaisePropertyChanged(() => Phone); }
        }
        private string imageUrl;
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; RaisePropertyChanged(() => ImageUrl); }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; RaisePropertyChanged(() => Address); }
         
        }
       public void Init(ClientDetails dtls)
       {
           Name = dtls.Name;
           Phone = dtls.Phone;
           Account = dtls.Account;
           Address = dtls.Address;
           ImageUrl = dtls.ImageUrl;

       }

    }
}
