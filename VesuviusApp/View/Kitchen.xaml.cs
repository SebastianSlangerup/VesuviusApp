using VesuviusApp.ViewModel;

namespace VesuviusApp.View;

public partial class Kitchen : ContentPage
{
	public Kitchen(KitchenViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
