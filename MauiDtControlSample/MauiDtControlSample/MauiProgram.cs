﻿namespace MauiDtControlSample;

using DtControls.UserControls;
using DtControls.Handlers;

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
			})
            .ConfigureMauiHandlers(handlers =>
			{
				handlers.AddHandler<DtWindowTabItemView, DtWindowTabItemViewHandler>();
				handlers.AddHandler<DtNavigationView, DtNavigationViewHandler>();
				handlers.AddHandler<DtWindowTabView, DtWindowTabViewHandler>();
			});

		return builder.Build();
	}
}

