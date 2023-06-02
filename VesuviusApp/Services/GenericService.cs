using System.Net;
using Microsoft.Extensions.Configuration;

namespace VesuviusApp.Services;

public class GenericService
{
    private HttpClient _httpClient;
    private IConfiguration _configuration { get; set; }

    public GenericService()
    {
        _httpClient = new HttpClient();
    }

    public string baseDBEndpoint
    {
        get => baseDBEndpoint;
        private set => baseDBEndpoint = _configuration["EndPoints:DatabaseEndpoint"];
    }

    public string SetToken(string username, string password)
    {
        var res = _httpClient.GetAsync(baseDBEndpoint + "");
        if (res.Result.StatusCode == HttpStatusCode.OK)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers
                .AuthenticationHeaderValue("Bearer", res.Result.Content.ToString());
        }
        return "";
    }
    
}