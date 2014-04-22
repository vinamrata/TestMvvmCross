using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvvmCross.Core.ViewModels
{
   public class HomeViewModel:MvxViewModel
    {
       private string _userDetails;
       public string UserDetails
       {
           get { return _userDetails; }
           set { _userDetails = value; RaisePropertyChanged(() => UserDetails); }
       }

       public void Init(string user, string pwd)
       {
           UserDetails = string.Format("{0} {1}", user, pwd);
       }
       public HomeViewModel()
       {
           UserDetails = "hello";
       }
    }
}
