using System.Net;
using Microsoft.Extensions.Configuration;

namespace VesuviusApp.Services;

public class GenericService
{
    public HttpClient httpClient;
    public string token { get; set; }


    public GenericService()
    {
        httpClient = new HttpClient();
        token = string.Empty;

    }

    public string baseDBEndpoint
    {
        get => baseDBEndpoint;
        private set => baseDBEndpoint = Preferences.Default.Get<string>("DatabaseEndpoint", "localhost:44306");
    }

    public string SetToken(string username, string password)
    {
        var res = httpClient.GetAsync(baseDBEndpoint + "");
        if (res.Result.StatusCode == HttpStatusCode.OK)
        {
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers
                .AuthenticationHeaderValue("Bearer", res.Result.Content.ToString());
        }
        return "";
    }
    
}