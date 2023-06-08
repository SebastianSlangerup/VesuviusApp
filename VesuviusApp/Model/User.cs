using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Proto;

namespace VesuviusApp.Model;

public class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public string Token { get; set; }
        
    public User(string name, string password, bool isActive, string token)
    {
        Name = name;
        Password = password;
        IsActive = isActive;
        Token = token;
    }
}