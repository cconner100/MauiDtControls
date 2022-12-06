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
		_= builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				_= fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				_ = fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
            .ConfigureMauiHandlers(handlers =>
			{
				_= handlers.AddHandler<DtNavigation, DtNavigationHandler>();
				_= handlers.AddHandler<DtWindowTabs, DtWindowTabsHandler>();
			});
        
        _= builder.UseMauiEmbedding<Application>();
		_= builder.Services.AddSingleton<MainPage>();
		_ = builder.Services.AddSingleton<MainPageViewModel>();

        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            _= builder.AddSimpleConsole(i => i.ColorBehavior = LoggerColorBehavior.Disabled);
        });

        var mauiapp = builder.Build();
        mauiContext = new MauiContext(mauiapp.Services);
		mauiLogger = loggerFactory.CreateLogger<MauiApp>();
		return mauiapp;

	}
}

