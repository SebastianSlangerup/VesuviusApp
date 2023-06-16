using VesuviusApp.ViewModel;

namespace VesuviusApp.View;

public partial class Kitchen : ContentPage
{
	public Kitchen()
	{
		InitializeComponent();
		BindingContext = new KitchenViewModel();
	}
}
