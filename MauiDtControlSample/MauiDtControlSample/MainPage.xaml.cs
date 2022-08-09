namespace MauiDtControlSample;

using DtControls.Models;

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
		menucontext.BuildPlatformMenus(NavView, menu.GetPlatformMenu(), DtBuildMenuContext.MenuArea.main);
        menucontext.BuildPlatformMenus(NavView, menu.GetPlatformFooterMenu(), DtBuildMenuContext.MenuArea.footer);

		// setup events for clicks
		NavView.ItemInvoked += NavView_ItemInvoked;
		NavView.SelectionChanged += NavView_SelectionChanged;
		NavView.BackRequested += NavView_BackRequested;
		NavView.Collapsed += NavView_Collapsed;
		NavView.DisplayModeChanged += NavView_DisplayModeChanged;
		NavView.Expanding += NavView_Expanding;
		NavView.PaneClosed += NavView_PaneClosed;
		NavView.PaneClosing += NavView_PaneClosing;
		NavView.PaneOpened += NavView_PaneOpened;
		NavView.PaneOpening += NavView_PaneOpening;

    }

	private async void NavView_PaneOpening(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "PaneOpening", "OK");
    }

	private async void NavView_PaneOpened(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "PaneOpened", "OK");
    }

	private async void NavView_PaneClosing(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "PaneClosing", "OK");
    }

	private async void NavView_PaneClosed(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "PaneClosed", "OK");
    }

	private async void NavView_Expanding(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "Expanding", "OK");
    }

	private async void NavView_DisplayModeChanged(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "DisplayModeChanged", "OK");
    }

	private async void NavView_Collapsed(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "Collasped", "OK");
    }

	private async void NavView_BackRequested(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "BackRequested", "OK");
    }

	private async void NavView_SelectionChanged(object sender, EventArgs e)
	{
        await DisplayAlert("Event Debug", "SelectionChanged", "OK");
    }

	private async void NavView_ItemInvoked(object sender, DtNavigationViewItemInvokedEventArgs e)
	{
        await DisplayAlert("Event Debug", "ItemInvoked", "OK");
    }
}


