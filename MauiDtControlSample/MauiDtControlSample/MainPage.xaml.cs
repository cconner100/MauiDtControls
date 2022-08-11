namespace MauiDtControlSample;

using DtControls.Models;
using DtControls.UserControls;

using MauiDtControlSample.ViewModels;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel(NavView);
    }

    private void WindowTabView_Loaded(object sender, EventArgs e)
    {
        Console.WriteLine("DEBUG -- ContentPage_Appearing");
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

        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.OnLoadOfNavView();
            viewModel.SearchBarOnLoad(AutoSuggest);
        }

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
        Console.WriteLine("DEBUG -- ContentPage_Loaded");
    }

    private void NavView_PaneOpening(object sender, EventArgs e)
    {
        Console.WriteLine("DEBUG -- PaneOpening");
    }

    private void NavView_PaneOpened(object sender, EventArgs e)
    {
        Console.WriteLine("DEBUG -- PaneOpened");
    }

    private void NavView_PaneClosing(object sender, EventArgs e)
    {
        Console.WriteLine("DEBUG -- PaneClosing");
    }

    private void NavView_PaneClosed(object sender, EventArgs e)
    {
        Console.WriteLine("DEBUG -- PaneClosed");
    }

    private void NavView_Expanding(object sender, DtNavigationViewItemExpandingEventArgs e)
    {
        Console.WriteLine("DEBUG -- Expanding");
    }

    private void NavView_DisplayModeChanged(object sender, EventArgs e)
    {
        Console.WriteLine("DEBUG -- DisplayModeChanged");
    }

    private void NavView_Collapsed(object sender, DtNavigationViewItemCollapsedEventArgs e)
    {
        Console.WriteLine("DEBUG -- Collapsed");
    }

    private void NavView_BackRequested(object sender, EventArgs e)
    {
        Console.WriteLine("DEBUG -- BackRequested");
    }

    private void NavView_SelectionChanged(object sender, DtNavigationViewSelectionChangedEventArgs e)
    {
        Console.WriteLine("DEBUG -- SelectionChanged");
    }

    private void NavView_ItemInvoked(object sender, DtNavigationViewItemInvokedEventArgs e)
    {
        Console.WriteLine("DEBUG -- ItemInvoked");
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
            viewModel.AddTabButtonClick((DtWindowTabView)sender, e);
        }
    }

    private void WindowTabView_TabCloseRequested(object sender, EventArgs e)
    {
        if (BindingContext is MainPageViewModel viewModel)
        {
            viewModel.TabCloseRequested((DtWindowTabView)sender, e);
        }
    }
}


