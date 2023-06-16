using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
    [QueryProperty(nameof(CurrentTable), "Table")]
    public partial class OrderViewModel : GenericViewModel
    {
        [ObservableProperty]
        private Table currentTable;

        private OrderService OrderService;

        private string name = "Order";

        public string Name { get => name; set => setname(CurrentTable); }

        public string setname(Table table)
        {
            return table.ToString();
        }

        public OrderViewModel()
        {
           

        }

        public async Task CreateOrderAsync()
        {
            OrderService = new OrderService();
            var res = await OrderService.CreateOrder();
        }
    }

}
