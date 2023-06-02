using System.Net.Http.Headers;
using Xamarin.Google.Crypto.Tink.Jwt;

namespace VesuviusApp.Services;

public class Table : GenericService
{
    private List<Table> Tables = new List<Table>();
    private HttpClient httpClient;

    public Table()
    {
        
    }

    public Table selectFreeTables(int id)
    {
        this.httpClient = new HttpClient();
        return new Table();
    }
}