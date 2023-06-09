using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
    public partial class UserViewModel : GenericViewModel
    {
        public string username;
        public string password;
        public IAsyncRelayCommand login { get; }

        public UserViewModel()
        {
            Title = "login";
            login = new AsyncRelayCommand(Login);
        }

        public async Task Login( )
        {
            var Token = await UserService.Login(username,password);
            if (Token != "")
            {
                user = new User(username, password, true, Token);
            }
        }
        public bool signUp(string username, string password, string email, string phoneNumber)
        {
            return true;
        }
    }
}
