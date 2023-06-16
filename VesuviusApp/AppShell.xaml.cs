using Microsoft.Maui;
using VesuviusApp.View;

namespace VesuviusApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));

    }
}

