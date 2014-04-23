using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestMvvmCross.Core.Manager;
using TestMvvmCross.Core.Model;

namespace TestMvvmCross.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private string _userDetails;
        public string UserDetails
        {
            get { return _userDetails; }
            set { _userDetails = value; RaisePropertyChanged(() => UserDetails); }
        }

        public void Init(string user, string pwd)
        {
            UserDetails = string.Format("Welcome {0}", user );
        }

        #region for showing the list of clients

         private IClientManager _clientManager;

        public HomeViewModel(IClientManager clientManager)
        {
            _clientManager = clientManager;
            GetClientsList();
        }

        private ClientDetails _clientDtls;
        public ClientDetails ClientDtls
        {
            get { return _clientDtls; }
            set { _clientDtls = value; RaisePropertyChanged(() => ClientDtls); }
        }

        private List<ClientDetails> _clients;
        public List<ClientDetails> Clients
        {
            get { return _clients; }
            set { _clients = value; RaisePropertyChanged(() => Clients);  }
        }

        private void GetClientsList()
        {
            Clients = _clientManager.GetAllClients();
        }


        private Cirrious.MvvmCross.ViewModels.IMvxCommand _viewDetailsCommand;
        public System.Windows.Input.ICommand ViewDetailsCommand
        {
            get
            {
                _viewDetailsCommand = _viewDetailsCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand<ClientDetails>(GoToDetails);
                return _viewDetailsCommand;
            }

        }

        private void GoToDetails(ClientDetails obj)
        {
            ShowViewModel<ClientViewModel>(obj);
        }
        #endregion

        //private Cirrious.MvvmCross.ViewModels.IMvxCommand _viewClientCommand;
        //public System.Windows.Input.ICommand ViewClientCommand
        //{
        //    get
        //    {
        //        _viewClientCommand = _viewClientCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(GoToViewClient);
        //        return _viewClientCommand;
        //    }

        //}

        //private void GoToViewClient()
        //{
        //    try
        //    {
        //        ShowViewModel<ClientViewModel>();
        //    }
        //    catch (Exception ex)
        //    {
        //        string s = ex.Message;
        //    }
        //}

      

        

    }
}
