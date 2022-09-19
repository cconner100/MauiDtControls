namespace MauiDtControlSample;

using DtControls.Models;
using DtControls.Controls;

using MauiDtControlSample.ViewModels;
using Microsoft.Extensions.Logging;

public partial class MainPage : ContentPage
{
    ILogger logger;

    public MainPage(ILogger Logger)
    {
        InitializeComponent();
        logger = Logger;
        BindingContext = new MainPageViewModel(this, NavView, logger);
    }

    private void WindowTabView_Loaded(object sender, EventArgs e)
    {
        logger.LogTrace("ContentPage_Appearing");
    }

    bool loaded;
    private void ContentPage_Loaded(object sender, EventArgs e)
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

        // Add first tab, not closeable
        ((MainPageViewModel)BindingContext)?.AddFirstTab(WindowTabView);
        logger.LogTrace("ContentPage_Loaded");
    }

    private void NavView_PaneOpening(object sender, EventArgs e)
    {
        logger.LogTrace("PaneOpening");
    }

    private void NavView_PaneOpened(object sender, EventArgs e)
    {
        logger.LogTrace("PaneOpened");
    }

    private void NavView_PaneClosing(object sender, EventArgs e)
    {
        logger.LogTrace("PaneClosing");
    }

    private void NavView_PaneClosed(object sender, EventArgs e)
    {
        logger.LogTrace("PaneClosed");
    }

    private void NavView_Expanding(object sender, DtNavigationItemExpandingEventArgs e)
    {
        logger.LogTrace("Expanding");
    }

    private void NavView_DisplayModeChanged(object sender, EventArgs e)
    {
        logger.LogTrace("DisplayModeChanged");
    }

    private void NavView_Collapsed(object sender, DtNavigationItemCollapsedEventArgs e)
    {
        logger.LogTrace("Collapsed");
    }

    private void NavView_BackRequested(object sender, EventArgs e)
    {
        logger.LogTrace("BackRequested");
    }

    private void NavView_SelectionChanged(object sender, DtNavigationSelectionChangedEventArgs e)
    {
        logger.LogTrace("SelectionChanged");
    }

    private void NavView_ItemInvoked(object sender, DtNavigationItemInvokedEventArgs e)
    {
        if(e.ItemInvoked != null && e.ItemInvoked.screen != null)
        {
            // call viewmodel to load the page
            if (BindingContext is MainPageViewModel viewModel)
            {
                viewModel.AddPage(e.ItemInvoked);
            }
        }
        logger.LogTrace("ItemInvoked");
    }

    private void AutoSuggest_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue == e.OldTextValue)
        {
            return;
        }

        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.TextToSearch(e.NewTextValue, AutoSuggest);
        }
    }

    private void WindowTabView_AddTabButtonClick(object sender, EventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.AddTabButtonClick((DtWindowTabs)sender, e);
        }
    }

    void NavView_OnLoaded(System.Object sender, System.EventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.OnLoadOfNavView();
            viewModel.SearchBarOnLoad(AutoSuggest);
        }
    }

    private void WindowTabView_TabCloseRequested(object sender, DtWindowTabItemCloseRequestEventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.TabCloseRequested((DtWindowTabs)sender, e);
        }
    }
}


