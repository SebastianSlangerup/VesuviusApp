using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VesuviusApp.Services;

public class Table : GenericService
{
    private List<Table> Tables = new List<Table>();
    

    public Table()
    {
        
    }

    public string selectFreeTables()
    {
        var res = httpClient.GetAsync(baseDBEndpoint + "/tables/available");

        if (res != null && res.Result.StatusCode.ToString() == "200")
        {
            //DEBUG
            Console.WriteLine(res.Result.StatusCode.ToString());
            return res.Result.Content.ToString();
        }
        return "";
    }
}