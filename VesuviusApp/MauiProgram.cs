﻿using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Xaml;
using VesuviusApp.Services;
using VesuviusApp.View;
using VesuviusApp.ViewModel;

namespace VesuviusApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
        builder.Logging.AddDebug();
#endif


		builder.Services.AddSingleton<TableService>();
        builder.Services.AddSingleton<UserService>();
        builder.Services.AddSingleton<GenericViewModel>();
        builder.Services.AddTransient<OrderViewModel>();
        builder.Services.AddSingleton<TableViewModel>();
        builder.Services.AddTransient<UserViewModel>();
        builder.Services.AddTransient<MainPage>();
		builder.Services.AddSingleton<Kitchen>();
		builder.Services.AddSingleton<KitchenViewModel>();

        return builder.Build();
	}
}
