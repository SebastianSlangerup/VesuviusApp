using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;
using VesuviusApp.Model;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Newtonsoft.Json;
using System.Text;

namespace VesuviusApp.Services;

public class OrderService
{
    public async Task<string> CreateOrder()
    {

        var Endpoint = GenericService.baseDBEndpoint + $"/api/OrderController/Create";

        var JsonData = JsonConvert.SerializeObject(new Order());
        var RoleContent = new StringContent(JsonData, Encoding.UTF8, "application/json");


        var res = await GenericService.client.PostAsync(Endpoint, RoleContent);

        return JsonConvert.SerializeObject(res);



    }
} 