using VesuviusApp.ViewModel;

namespace VesuviusApp.View;

public partial class MainPage : ContentPage
{

	public MainPage(GenericViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

    }

}


