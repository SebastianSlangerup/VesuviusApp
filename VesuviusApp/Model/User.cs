using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesuviusApp.Model;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public string Token { get; set; }
    public User()
    {
        
    }
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public User(string username, string password, bool isActive, string token = "")
    {
        Username = username;
        Password = password;
        IsActive = isActive;
        Token = token;
    }
}