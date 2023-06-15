using VesuviusApp.ViewModel;

namespace VesuviusApp.View;

public partial class OrderPage : ContentPage
{
	public OrderPage(OrderViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

    }
}