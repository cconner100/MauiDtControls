namespace MauiDtControlSample;

using DtControls.UserControls;
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
				handlers.AddHandler<DtNavigationView, DtNavigationViewHandler>();
				handlers.AddHandler<DtWindowTabView, DtWindowTabViewHandler>();
				handlers.AddHandler<DtWindowTabItem, DtWindowTabItemHandler>();
			});
		builder.UseMauiEmbedding<Application>();
		var mauiapp = builder.Build();
        mauiContext = new MauiContext(mauiapp.Services);
		return mauiapp;

	}
}

