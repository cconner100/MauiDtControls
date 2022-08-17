namespace MauiDtControlSample.ViewModels;

using DtControls.UserControls;

using MauiDtControlSample.Models;

using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;

public partial class MainPageViewModel
{
    DtNavigationView NavView;
    SearchBar SearchBar;
    DtMenuData menu = new DtMenuData();
    DtBuildMenuContext menucontext = new DtBuildMenuContext();


    public MainPageViewModel(DtNavigationView navView)
    {
        NavView = navView;
        menu.InitMenuData();
    }

    #region NavigationView
    public void SearchBarOnLoad(SearchBar searchBar)
    {
        SearchBar = searchBar;
        // need to setup callback for selected items

        if (searchBar.Handler.PlatformView is AutoSuggestBox asb)
        {
            // TODO: Not sure why i cant get the accelerator key to work, ctrl-F but it does not seem to fire the event

            var kba = new KeyboardAccelerator
            {
                Modifiers = Windows.System.VirtualKeyModifiers.Control,
                Key = Windows.System.VirtualKey.F,
                IsEnabled = true
            };
            kba.Invoked += CtrlF_Invoked;

            asb.VerticalAlignment = Microsoft.UI.Xaml.VerticalAlignment.Center;
            asb.MinWidth = 200;
            asb.KeyboardAcceleratorPlacementMode = KeyboardAcceleratorPlacementMode.Hidden;
            asb.KeyboardAccelerators.Add(kba);
        }
    }

    private void CtrlF_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
        SearchBar.Focus();
    }

    public void TextToSearch(string text, SearchBar sb)
    {
        if (sb.Handler.PlatformView is AutoSuggestBox asb)
        {
            // get the real control here and use it
            var ret = menucontext.SearchMenus(text);
            if (ret?.Count == 0)
            {
                asb.ItemsSource = new string[] { "No result found" };
            }
            else
            {
                asb.ItemsSource = ret;
            }
        }
    }

    public void OnLoadOfNavView()
    {
        menucontext.BuildPlatformMenus(NavView, menu.GetPlatformMenu(), DtNavigationView.MenuArea.main);
        menucontext.BuildPlatformMenus(NavView, menu.GetPlatformFooterMenu(), DtNavigationView.MenuArea.footer);
    }
    #endregion 

    #region TabView
    public async void AddTabButtonClick(DtWindowTabView sender, EventArgs e)
    {
        NavigationPage page = new NavigationPage();
        await page.PushAsync(new TabPage1()).ConfigureAwait(true);

        var newpage = new DtWindowTabItem();
        newpage.IconSource = new SymbolIconSource() { Symbol = Symbol.Placeholder };
        newpage.Header = "New Item";
        newpage.Content = page;

        sender.TabItems.Add(newpage);
    }

    public void TabCloseRequested(DtWindowTabView sender, EventArgs e)
    {
        //sender.TabItems.Remove(e.tab);
    }
    #endregion

    #region TabViewItem
    #endregion
}

