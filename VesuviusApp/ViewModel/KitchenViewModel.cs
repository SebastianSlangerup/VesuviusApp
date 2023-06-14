using System;
using System.Collections.ObjectModel;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
	public partial class KitchenViewModel : ObservableObject
	{
		public KitchenViewModel()
		{
			Orders = new ObservableCollection<Order>(_listOrders);
		}

		private List<Order> _listOrders = new List<Order>();

		[ObservableProperty]
		private ObservableCollection<Order> _orders;

		[RelayCommand]
		private async void Refresh()
		{
			using HttpResponseMessage response = await GenericService.client.GetAsync("http://localhost:8080/api/Order/GetAll");
			string responseBody = await response.Content.ReadAsStringAsync();

			_listOrders = JsonSerializer.Deserialize<List<Order>>(responseBody);
		}
	}
}

