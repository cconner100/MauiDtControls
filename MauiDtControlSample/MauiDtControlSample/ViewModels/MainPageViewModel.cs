namespace MauiDtControlSample.ViewModels;

using DtControls.Controls;
using DtControls.Models;

using MauiDtControlSample.Models;

#if WINDOWS

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
#endif

using System;

public partial class MainPageViewModel : IMainPageViewModel
{
    DtNavigation NavView;
    SearchBar SearchBar;
    DtMenuData menu = new DtMenuData();
    DtBuildMenuContext menucontext = new DtBuildMenuContext();
    MainPage page = null;

    private MainPageViewModel() { }
    public MainPageViewModel(MainPage thePage, DtNavigation navView)
    {
        page = thePage;
        NavView = navView;
        menu.InitMenuData();
    }

    #region NavigationView
    public void SearchBarOnLoad(SearchBar searchBar)
    {
 #if WINDOWS
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
#endif
    }

#if WINDOWS
    private void CtrlF_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
        SearchBar.Focus();
    }
#endif

    public void TextToSearch(string text, SearchBar sb)
    {
#if WINDOWS
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
#endif
    }

    public void OnLoadOfNavView()
    {
        NavView.MenuItems = menu.GetMenu();
        NavView.FooterMenuItems = menu.GetFooterMenu(); 
    }

    #endregion

    #region TabView
    public void AddTabButtonClick(DtWindowTabs sender, EventArgs e)
    {
        var newtab = new DtWindowTabItem();
        var page = new TabPage1();
#if WINDOWS
        newtab.IconSource = new SymbolIconSource() { Symbol = Symbol.Placeholder };
#endif
        newtab.Header = "New Item";
        newtab.Content = new NavigationPage(page);    // "New Page";

        sender.TabItems.Add(newtab);
    }

    public void TabCloseRequested(DtWindowTabs sender, EventArgs e)
    {
        //sender.TabItems.Remove(e.tab);
    }
#endregion


#region TabViewItem
#endregion


}
