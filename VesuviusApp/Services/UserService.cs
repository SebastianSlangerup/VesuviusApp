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
using System.Net.Http.Json;

namespace VesuviusApp.Services
{
    public class UserService
    {
        public UserService()
        {
            _users = new ObservableCollection<User>();
        }

        ObservableCollection<User> _users;
        public async Task<User> Login(User user)
        {
            var username = user.Username;
            var password = user.Password;

            var Endpoint = GenericService.baseDBEndpoint + $"/api/Authentication/login";

            var JsonData = JsonConvert.SerializeObject(new User(username, password, false));
            var RoleContent = new StringContent(JsonData, Encoding.UTF8, "application/json");


            var res = await GenericService.client.PostAsync(Endpoint, RoleContent);

            var responseBody = await res.Content.ReadFromJsonAsync<JsonTokenResponse>();

            if (res.StatusCode == HttpStatusCode.OK)
            {
                var Newuser = new User(username, password, true, responseBody.Token);
                GenericService.client.DefaultRequestHeaders.Add("Authorization", "Bearer " + responseBody.Token);
                _users.Add(Newuser);
                return Newuser;
            }
            return new User();
        }
    }
}
