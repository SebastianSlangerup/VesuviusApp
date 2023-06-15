using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
    public partial class OrderViewModel : GenericViewModel
    {
        [ObservableProperty]
        ObservableCollection<Order> orders;

        private OrderService OrderService;

        public OrderViewModel()
        {
            Title = "New Order";
           

        }

        public async Task CreateOrderAsync()
        {
            OrderService = new OrderService();
            var res = await OrderService.CreateOrder();
        }
    }

}
