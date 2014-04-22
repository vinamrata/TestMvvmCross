using Cirrious.MvvmCross.ViewModels;
using System;
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


        private Cirrious.MvvmCross.ViewModels.IMvxCommand _loginCommand;

        /// <summary>
        /// Gets the go back to perivous view command.
        /// </summary>
        /// <value>The go back to perivous view command.</value>
        public System.Windows.Input.ICommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(IsValidLogin);
                return _loginCommand;
            }
        }

        void IsValidLogin()
        {
            try
            {
                var result = _loginManager.IsValidLogin(UserName, Password);
                if (result)
                    ShowViewModel<HomeViewModel>(new { user = UserName, pwd = Password });
            }
            catch (Exception ex)
            {
            }
        }
    }
}
