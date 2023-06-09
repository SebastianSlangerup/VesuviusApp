using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;
using VesuviusApp.Model;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace VesuviusApp.Services;

public class TableService : GenericService
{
    public static async Task<ObservableCollection<Table>> SelectFreeTables()
    {
        ObservableCollection<Table> Tables = null;
        var res = await httpClient.GetAsync(baseDBEndpoint + "/tables/available");

        if (res.IsSuccessStatusCode)
        {
            Tables = await res.Content.ReadFromJsonAsync<ObservableCollection<Table>>();
        }
        return Tables;
    }
}