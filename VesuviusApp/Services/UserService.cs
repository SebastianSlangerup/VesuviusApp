using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using VesuviusApp.Model;
using Newtonsoft.Json;
using VesuviusApp.View;

namespace VesuviusApp.Services
{
    public class UserService
    {
        public UserService()
        {
            _users = new ObservableCollection<User>();
        }

        ObservableCollection<User> _users;
        public async Task<User> Login(string username = "TestUser", string password = "Admin2023")
        {
#if DEBUG
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                username = "TestUser";
                password = "Admin2023";
            }
#endif
            var login = await GenericService.client.GetAsync(GenericService.baseDBEndpoint + $"/login/{username}/{password}");

            if (login.StatusCode == HttpStatusCode.OK)
            {
                var Token = getToken(new User(username, password)).ToString();
                var user = new User(username, password, true, Token);
                _users.Add(user);
                return user;
            }
            return new User();
        }

        public async Task<string> getToken(User user)
        {

            var username = user.Username;
            var password = user.Password;

            var Endpoint = "http://127.0.0.1:5118" + $"/security/createToken";

            var JsonData = JsonConvert.SerializeObject(new User(username, password, false));
            var RoleContent = new StringContent(JsonData, Encoding.UTF8, "application/json");


            var res = await GenericService.client.PostAsync(Endpoint, RoleContent);

            if (res == null || res.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(res.StatusCode);
            }
            if (res.StatusCode == HttpStatusCode.Unauthorized)
            {
                Application.Current.MainPage = new Login(new ViewModel.UserViewModel());
            }

            return res.Content.ToString();

        }
    }
}
