namespace MauiDtControlSample;

using DtControls.Controls;
using DtControls.Handlers;
using Microsoft.Maui.Embedding;

public static class MauiProgram
{
	public static IMauiContext mauiContext = null;
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
				handlers.AddHandler<DtNavigation, DtNavigationHandler>();
				handlers.AddHandler<DtWindowTabs, DtWindowTabsHandler>();
			});
		builder.UseMauiEmbedding<Application>();
		var mauiapp = builder.Build();
        mauiContext = new MauiContext(mauiapp.Services);
		return mauiapp;

	}
}

