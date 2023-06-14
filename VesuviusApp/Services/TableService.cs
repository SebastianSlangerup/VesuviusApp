using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;
using VesuviusApp.Model;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace VesuviusApp.Services;

public class TableService
{
    public async Task<ObservableCollection<Table>> SelectFreeTables()
    {
        ObservableCollection<Table> Tables = null;
        var res = await GenericService.client.GetAsync(GenericService.baseDBEndpoint + $"/api/Pos_table/GetAvailableTables?reservationBegin={DateTime.Now}&reservationEnd={DateTime.Now.AddDays(1)}");

        if (res.IsSuccessStatusCode)
        {
            Tables = await res.Content.ReadFromJsonAsync<ObservableCollection<Table>>();
        }
        else
        {
            Tables = null;
        }

#if DEBUG
        Tables = new ObservableCollection<Table>
            {
                new Table(1,2){},
                new Table(2,3){},
                new Table(3,4){},

            };
#endif
        return Tables;
    }
}