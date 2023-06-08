using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http.Headers;
using VesuviusApp.Model;

namespace VesuviusApp.Services
{
    public class UserService : GenericService
    {
        public static ObservableCollection<User> ActiveUsers = new();
        
        public static async Task<string> Login(string username, string password)
        {
            var login = await httpClient.GetAsync(baseDBEndpoint + "");
            var Token = "";

            if (login.StatusCode == HttpStatusCode.Accepted)
            {
                 Token = SetToken(username, password).Result;
                 ActiveUsers.Add(new User(username,password,true,Token));
            }

            return Token;
        }

        public static void SignUp(string username, string password, string email, string phoneNumber)
        {
           var signup = httpClient.GetAsync(baseDBEndpoint+""); 
        }
        
        public static void lockout(User user)
        {
            ActiveUsers.Remove(user); 
        }
        
        private static async Task<string> SetToken(string username, string password)
        {
            var res = await httpClient.GetAsync(baseDBEndpoint + $"/{username}{password}");
            if (res.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", res.Content.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return "";
                }

                return res.Content.ToString();
            }
            return "";
        }
    }
}
