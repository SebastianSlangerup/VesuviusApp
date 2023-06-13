using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using VesuviusApp.Model;
using VesuviusApp.Services;
using static System.Net.WebRequestMethods;

namespace VesuviusApp.ViewModel
{
    public partial class UserViewModel : GenericViewModel
    {
        [ObservableProperty]
        string username;
        [ObservableProperty]
        string password;
        [ObservableProperty]
        string errorMsg;

        public IAsyncRelayCommand login { get; }

        public UserViewModel()
        {
            Title = "login";
            errorMsg = string.Empty;
            login = new AsyncRelayCommand(Login);
        }

        public async Task Login()
        {
            var login = new UserService();
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMsg = "Username or Password not set";
                return;
            }
            var res = await login.Login(this.Username, Password);
            if (res.Token == null)
            {
                ErrorMsg = "User Not found";
                return;
            }
           

            myUser = new User(Username, Password, true, res.Token);
            Application.Current.MainPage = new AppShell();

        }

        public bool signUp(string username, string password, string email, string phoneNumber)
        {
            return true;
        }
    }
}
