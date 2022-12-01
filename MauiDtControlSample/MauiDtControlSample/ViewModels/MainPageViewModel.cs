namespace MauiDtControlSample.ViewModels;

using DtControls.Controls;
using DtControls.Models;

using MauiDtControlSample.Models;

using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls;

#if WINDOWS

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
#endif

using System;
using System.Linq;

using Page = Page;

public partial class MainPageViewModel : IMainPageViewModel
{
    readonly DtNavigation NavView;
    SearchBar SearchBar;
    readonly DtMenuData menu = new();
    readonly MainPage page;
    readonly ILogger logger;

    MainPageViewModel() { }

    public MainPageViewModel(MainPage thePage, DtNavigation navView, ILogger Logger)
    {
        page = thePage;
        NavView = navView;
        logger = Logger;
        menu.InitMenuData();
    }

    #region DtNavigation
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
    void CtrlF_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
        _= SearchBar.Focus();
    }
#endif

    public void TextToSearch(string text, SearchBar sb)
    {
#if WINDOWS
        if (sb.Handler.PlatformView is AutoSuggestBox asb)
        {
            // get the real control here and use it
            var ret = NavView.SearchMenuItems(text);
            asb.ItemsSource = ret?.Count == 0 ? (new[] { "No result found" }) : (object)(ret?.Keys.ToArray<string>());
        }
#endif
    }

    public void OnLoadOfNavView()
    {
        NavView.MenuItems = menu.GetMenu();
        NavView.FooterMenuItems = menu.GetFooterMenu();
    }

    public async Task AddPage(DtWindowTabs tabs, DtMenuItem menuItem)
    {
        var tabindex = (int)tabs.SelectedItem;
        var tabItem = tabs.TabItems[tabindex];
        await tabItem.NavigationPage.PushAsync((Page)Activator.CreateInstance(menuItem.screen)).ConfigureAwait(true);
        _= tabItem.Focus();
        UpdateBackButton(tabs);
    }

    public async Task PopPageInTab(DtWindowTabs tabs)
    {
        var tabindex = (int)tabs.SelectedItem;
        var tabItem = tabs.TabItems[tabindex];
        if (tabItem.CanGoBack())
        {
            _= await tabItem.NavigationPage.PopAsync().ConfigureAwait(true);
        }
        _= tabItem.Focus();
        UpdateBackButton(tabs);
    }

    void UpdateBackButton(DtWindowTabs tabs)
    {
        var tabindex = (int)tabs.SelectedItem;
        var tabItem = tabs.TabItems[tabindex];
        if (tabItem.CanGoBack())
        {
            NavView.IsBackButtonEnabled = true;
            NavView.IsBackButtonVisible = DtNavigation.BackButtonVisable.Visible;
        }
        else
        {
            NavView.IsBackButtonEnabled = false;
            NavView.IsBackButtonVisible = DtNavigation.BackButtonVisable.Collapsed;
        }
    }

    #endregion

    #region TabView
    public void AddTabButtonClick(DtWindowTabs sender, EventArgs e)
    {
        var newtab = new DtWindowTabItem();
        var page = new TabPage1();
        var navpage = new NavigationPage(page);
        navpage.Focused += Navpage_Focused;
        navpage.Pushed += Navpage_Pushed;
        navpage.Popped += Navpage_Popped;
#if WINDOWS
        newtab.IconSource = new SymbolIconSource() { Symbol = Symbol.Placeholder };
#endif
        newtab.Header = "New Item";
        newtab.Content = navpage;    // "New Page";
        newtab.Focused += Newtab_Focused;

        sender.TabItems.Add(newtab);
        sender.SelectedIndex = sender.TabItems.Count - 1;
        var tab = sender.TabItems[sender.SelectedIndex].Focus();
    }

    void Navpage_Popped(object sender, NavigationEventArgs e)
    {

    }

    void Navpage_Pushed(object sender, NavigationEventArgs e)
    {

    }

    void Navpage_Focused(object sender, FocusEventArgs e)
    {
        if (e.IsFocused && e.VisualElement is DtWindowTabItem tab)
        {
            UpdateTabBackButton(tab);
        }
    }

    private void Newtab_Focused(object sender, FocusEventArgs e)
    {
        if (e.IsFocused && e.VisualElement is DtWindowTabItem tab)
        {
            UpdateTabBackButton(tab);
        }
    }

    void UpdateTabBackButton(DtWindowTabItem tab)
    {
        if (tab.CanGoBack())
        {
            NavView.IsBackButtonEnabled = true;
            NavView.IsBackButtonVisible = DtNavigation.BackButtonVisable.Visible;
        }
        else
        {
            NavView.IsBackButtonEnabled = false;
            NavView.IsBackButtonVisible = DtNavigation.BackButtonVisable.Collapsed;
        }
    }
    public void AddFirstTab(DtWindowTabs tabView)
    {
        var newtab = new DtWindowTabItem();
        var page = new TabPage1();
#if WINDOWS
        newtab.IconSource = new SymbolIconSource() { Symbol = Symbol.Document };
#endif
        newtab.Header = "Home Page";
        newtab.Content = new NavigationPage(page);    // "New Page";
        newtab.IsClosable = false;
        newtab.Focused += Newtab_Focused;
        tabView.TabItems.Add(newtab);
        tabView.SelectedItem = 0;
    }
    public void TabCloseRequested(DtWindowTabs sender, DtWindowTabItemCloseRequestEventArgs e)
    {
        _ = sender.TabItems.Remove(e.Tab);
    }
    #endregion


    #region TabViewItem
    #endregion


}
