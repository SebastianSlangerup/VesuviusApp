using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesuviusApp.Services
{
    internal class User : GenericService
    {

        private string Name { get; set; }
        private string Password { get; set; }
        private bool IsActive { get; set; }

        public User()
        {

        }

        public void Login(string username, string password)
        {
            var login = httpClient.GetAsync(baseDBEndpoint + "");

        }

        public void SignUp(string username, string password, string email, string phoneNumber)
        {
           var signup = httpClient.GetAsync(baseDBEndpoint+""); 
        }
    }
}
