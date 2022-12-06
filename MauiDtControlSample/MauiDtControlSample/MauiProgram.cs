namespace MauiDtControlSample;

using DtControls.Controls;
using DtControls.Handlers;

using MauiDtControlSample.ViewModels;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Maui.Embedding;

public static class MauiProgram
{
	public static IMauiContext? mauiContext;
	public static ILogger? mauiLogger;	
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				_= fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				_ = fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
            .ConfigureMauiHandlers(handlers =>
			{
				handlers.AddHandler<DtNavigation, DtNavigationHandler>();
				handlers.AddHandler<DtWindowTabs, DtWindowTabsHandler>();
			});
        
        builder.UseMauiEmbedding<Application>();
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();

        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddSimpleConsole(i => i.ColorBehavior = LoggerColorBehavior.Disabled);
        });

        var mauiapp = builder.Build();
        mauiContext = new MauiContext(mauiapp.Services);
		mauiLogger = loggerFactory.CreateLogger<MauiApp>();
		return mauiapp;

	}
}

