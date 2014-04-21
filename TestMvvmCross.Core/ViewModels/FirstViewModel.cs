using Cirrious.MvvmCross.ViewModels;
using TestMvvmCross.Core.Manager;

namespace TestMvvmCross.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {

        private ILoginManager _loginManager;

        public FirstViewModel(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        private string _userName;
        public string UserName
		{
            get { return _userName; }
            set { _userName = value; RaisePropertyChanged(() => UserName); }
		}

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(() => Password); }
        }
    }
}
