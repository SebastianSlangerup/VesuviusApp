using VesuviusApp.Services;
using VesuviusApp.View;
using VesuviusApp.ViewModel;

namespace VesuviusApp;

public partial class App : Application
{
    public App(UserViewModel viewModel)
	{
		InitializeComponent();

<<<<<<< Updated upstream
		MainPage = new Login(viewModel);



=======
		MainPage = new AppShell();
>>>>>>> Stashed changes
	}
}

