using VesuviusApp.ViewModel;

namespace VesuviusApp;

public partial class MainPage : ContentPage
{

	public MainPage(GenericViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

    }

}


