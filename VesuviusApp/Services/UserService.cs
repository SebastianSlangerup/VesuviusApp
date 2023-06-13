using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using VesuviusApp.Model;
using Newtonsoft.Json;

namespace VesuviusApp.Services
{
    public class UserService
    {
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

            if (login.StatusCode == HttpStatusCode.Unauthorized)
            {
                if (_users.Count < 0)
                {
                    return new User();
                }

            }


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

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            // Pass the handler to httpclient(from you are calling api)
            HttpClient client = new HttpClient(clientHandler);

            var Endpoint = "http://127.0.0.1:5118" + $"/security/createToken";

            var JsonData = JsonConvert.SerializeObject(new User(username, password, false));
            var RoleContent = new StringContent(JsonData, Encoding.UTF8, "application/json");


            var res = await client.PostAsync(Endpoint, RoleContent);

            if (res == null || res.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(res.StatusCode);
            }

            return res.Content.ToString();

        }
    }
}
