using VesuviusApp.ViewModel;

namespace VesuviusApp.View;

public partial class Login : ContentPage
{
	public Login(UserViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}