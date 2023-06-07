﻿using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Xaml;

namespace VesuviusApp;

public static class MauiProgram
{
	public static void setDefaultDebugConfig()
	{
        Preferences.Set("DatabaseEndpoint", "localhost:44306");
    }

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
		setDefaultDebugConfig();
#endif

		return builder.Build();
	}
}