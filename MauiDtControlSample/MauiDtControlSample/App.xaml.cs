namespace MauiDtControlSample;

using Microsoft.Extensions.Logging;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage(MauiProgram.mauiLogger!);		
	}

}

