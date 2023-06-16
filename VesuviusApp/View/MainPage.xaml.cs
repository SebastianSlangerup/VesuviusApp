using VesuviusApp.ViewModel;

namespace VesuviusApp.View;

public partial class MainPage : ContentPage
{

	public MainPage(TableViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

}


