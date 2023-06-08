using System.Net;
using Microsoft.Extensions.Configuration;

namespace VesuviusApp.Services;

public class GenericService
{
    public static HttpClient httpClient;
    public string token { get; set; }


    public GenericService()
    {
        httpClient = new HttpClient();
        token = string.Empty;

    }

    public static string baseDBEndpoint
    {
        get => baseDBEndpoint;
        private set => baseDBEndpoint = Preferences.Default.Get<string>("DatabaseEndpoint", "localhost:44306");
    }

  
}