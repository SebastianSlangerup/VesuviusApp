using System.Net;
using Microsoft.Extensions.Configuration;

namespace VesuviusApp.Services;

public static class GenericService
{
    public static HttpClientHandler clientHandler = new HttpClientHandler(); 
    public static HttpClient client = new HttpClient(clientHandler);

    private static string _baseDBEndpoint = "http://127.0.0.1:5118";

    public static string baseDBEndpoint
    {
        get => _baseDBEndpoint;
    }

  
}