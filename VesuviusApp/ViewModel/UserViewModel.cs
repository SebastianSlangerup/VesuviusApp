using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
    public class UserViewModel : GenericViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public UserViewModel()
        {
            Title = "login";
        }

        public async void login(string username, string password)
        {
            var Token = UserService.Login(username,password);
            if (Token.Result != "")
            {
                
                await Shell.Current.GoToAsync("/VesuviusApp/Mainpage");
            }
        }
        public bool signUp(string username, string password, string email, string phoneNumber)
        {
            return true;
        }
    }
}
