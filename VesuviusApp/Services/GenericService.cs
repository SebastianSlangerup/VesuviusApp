using System.Net;
using Microsoft.Extensions.Configuration;

namespace VesuviusApp.Services;

public static class GenericService
{
    public static HttpClientHandler clientHandler = new HttpClientHandler(); 
    public static HttpClient client = new(clientHandler);
    private static string _baseDBEndpoint = "http://10.0.2.2:8080";


    public static string baseDBEndpoint
    {
        get => _baseDBEndpoint;
    }

  
}