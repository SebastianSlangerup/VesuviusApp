using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VesuviusApp.ViewModel
{
	public partial class KitchenViewModel : ObservableObject
	{
		public KitchenViewModel()
		{
			Orders = new ObservableCollection<string>
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
		ObservableCollection<string> orders;
	}
}

