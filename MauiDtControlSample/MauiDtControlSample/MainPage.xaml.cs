namespace MauiDtControlSample;

using DtControls.Controls;
using DtControls.Models;

using MauiDtControlSample.ViewModels;

using Microsoft.Extensions.Logging;

using System.Diagnostics;

public partial class MainPage : ContentPage
{
    readonly ILogger logger;

    public MainPage(ILogger Logger)
    {
        InitializeComponent();
        logger = Logger;
        BindingContext = new MainPageViewModel(this, NavView, logger);
    }

    public DtWindowTabItem? GetCurrentTab()
    {
        return WindowTabView is null ? null : WindowTabView.SelectedItem as DtWindowTabItem;
    }

    void WindowTabView_Loaded(object sender, EventArgs e)
    {
        Debug.WriteLine("WindowTabView_Loaded");
    }

    bool loaded;
    void DtWindowTab_Loaded(object sender, EventArgs e)
    {
        // strange bug on loading content page called 2 times
        if (loaded)
        {
            return;
        }
        loaded = true;

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

        // Window Tab events
        WindowTabView.Focused += WindowTabView_Focused;
        WindowTabView.SelectionChanged += WindowTabView_SelectionChanged;

        // Add first tab, not closeable
        ((MainPageViewModel)BindingContext)?.AddFirstTab(WindowTabView);

        _ = WindowTabView.Focus();
        //WindowTabView.SelectedItem = 0;
        WindowTabView.SelectedIndex = 0;

        Debug.WriteLine("DtWindowTab_Loaded");
    }

    void WindowTabView_SelectionChanged(object? sender, DtWindowTabsSelectionChangedEventArgs e)
    {
        if (e.AddedItems.Any())
        {
            if (e.AddedItems[0] is DtWindowTabItem tab)
            {
                if (tab.CanGoBack())
                {
                    NavView.IsBackButtonEnabled = true;
                    NavView.IsBackButtonVisible = DtNavigation.BackButtonVisable.Auto;
                }
                else
                {
                    NavView.IsBackButtonEnabled = false;
                    NavView.IsBackButtonVisible = DtNavigation.BackButtonVisable.Auto;
                }
            }

        }
        Debug.WriteLine("WindowTabView_SelectionChanged");
    }

    void WindowTabView_Focused(object? sender, FocusEventArgs e)
    {
        if (e.IsFocused == true && e.VisualElement is DtWindowTabItem item)
        {
            if (item.CanGoBack())
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
        Debug.WriteLine("WindowTabView_Focused");

    }

    void NavView_PaneOpening(object? sender, EventArgs e)
    {
        Debug.WriteLine("NavView_PaneOpening");
    }

    void NavView_PaneOpened(object? sender, EventArgs e)
    {
        Debug.WriteLine("NavView_PaneOpened");
    }

    void NavView_PaneClosing(object? sender, EventArgs e)
    {
        Debug.WriteLine("NavView_PaneClosing");
    }

    private void NavView_PaneClosed(object? sender, EventArgs e)
    {
        Debug.WriteLine("NavView_PaneClosed");
    }

    void NavView_Expanding(object? sender, DtNavigationItemExpandingEventArgs e)
    {
        Debug.WriteLine("NavView_Expanding(");
    }

    void NavView_DisplayModeChanged(object? sender, EventArgs e)
    {
        Debug.WriteLine("NavView_DisplayModeChanged");
    }

    void NavView_Collapsed(object? sender, DtNavigationItemCollapsedEventArgs e)
    {
        Debug.WriteLine("NavView_Collapsed");
    }

    async void NavView_BackRequested(object? sender, EventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            await viewModel.PopPageInTab(WindowTabView);
        }

        Debug.WriteLine("NavView_BackRequested");
    }

    void NavView_SelectionChanged(object? sender, DtNavigationSelectionChangedEventArgs e)
    {
        Debug.WriteLine("NavView_SelectionChanged");
    }

    async void NavView_ItemInvoked(object? sender, DtNavigationItemInvokedEventArgs e)
    {
        if (e.ItemInvoked != null && e.ItemInvoked.screen != null)
        {
            // call viewmodel to load the page
            if (BindingContext is MainPageViewModel viewModel)
            {
                await viewModel.AddPage(WindowTabView, e.ItemInvoked).ConfigureAwait(true);
            }
        }
        Debug.WriteLine("NavView_ItemInvoked");
    }

    void AutoSuggest_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue == e.OldTextValue)
        {
            return;
        }

        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.TextToSearch(e.NewTextValue, AutoSuggest);
        }
        Debug.WriteLine("AutoSuggest_TextChanged");
    }

    void WindowTabView_AddTabButtonClick(object sender, EventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.AddTabButtonClick((DtWindowTabs)sender, e);
        }
        Debug.WriteLine("WindowTabView_AddTabButtonClick");
    }

    void NavView_OnLoaded(System.Object sender, System.EventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.OnLoadOfNavView();
            viewModel.SearchBarOnLoad(AutoSuggest);
        }
        Debug.WriteLine("NavView_OnLoaded");
    }

    void WindowTabView_TabCloseRequested(object sender, DtWindowTabItemCloseRequestEventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.TabCloseRequested((DtWindowTabs)sender, e);
        }
        Debug.WriteLine("WindowTabView_TabCloseRequested");
    }

    void ContentPage_Loaded(object sender, EventArgs e)
    {
        Debug.Write("ContentPage_Loaded");
    }
}


