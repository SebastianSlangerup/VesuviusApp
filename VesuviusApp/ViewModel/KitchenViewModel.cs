using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
	public partial class KitchenViewModel : ObservableObject
	{
		public KitchenViewModel()
		{
            orders = new ObservableCollection<string>
			{
				"Test Order 1",
				"Test Order 2",
				"Test Order 3",
				"Test Order 4",
				"Test Order 5",
				"Test Order 6"
			};

		}

		[ObservableProperty]
		private ObservableCollection<string> orders;

		[RelayCommand]
		private async void Refresh()
		{
			// TODO Call endpoint and fill `Orders`
			using HttpResponseMessage response = await GenericService.client.GetAsync("http://localhost:8080/api/Order/GetAll");
			string responseBody = await response.Content.ReadAsStringAsync();
			System.Diagnostics.Debug.WriteLine(responseBody);
		}
	}
}

