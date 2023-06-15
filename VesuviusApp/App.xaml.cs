using VesuviusApp.Services;
using VesuviusApp.View;
using VesuviusApp.ViewModel;

namespace VesuviusApp;

public partial class App : Application
{
    public App(UserViewModel viewModel)
	{
		InitializeComponent();
		MainPage = new Login(viewModel);
	}
}

