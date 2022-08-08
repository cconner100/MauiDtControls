namespace MauiDtControlSample;

using MauiDtControlSample.Models;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void WindowTabView_Loaded(object sender, EventArgs e)
	{

	}

	private void ContentPage_Appearing(object sender, EventArgs e)
	{

	}

	private void ContentPage_Loaded(object sender, EventArgs e)
	{
		var menu = new DtMenuData();
		var menucontext = new DtBuildMenuContext();
		menucontext.BuildPlatformMenus(NavView, menu.GetPlatformMenu());
	}
}


