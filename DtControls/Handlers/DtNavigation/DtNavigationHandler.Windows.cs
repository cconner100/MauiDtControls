#if WINDOWS
namespace DtControls.Handlers;

using DtControls.Models;
using DtControls.Controls;

using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Controls;

using System.Diagnostics;

public partial class DtNavigationHandler : ViewHandler<DtNavigation, NavigationView>, IDtNavigationHandler
{
    private NavigationView _navigationView = new NavigationView();

    IDtNavigation IDtNavigationHandler.VirtualView => VirtualView;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override NavigationView CreatePlatformView()
    {
        return _navigationView;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void ConnectHandler(NavigationView platformView)
    {
        base.ConnectHandler(platformView);

        platformView.BackRequested += PlatformView_BackRequested;
        platformView.Collapsed += PlatformView_Collapsed;
        platformView.DisplayModeChanged += PlatformView_DisplayModeChanged;
        platformView.Expanding += PlatformView_Expanding;
        platformView.ItemInvoked += PlatformView_ItemInvoked;
        platformView.Loaded += PlatformView_Loaded;
        platformView.PaneClosed += PlatformView_PaneClosed;
        platformView.PaneClosing += PlatformView_PaneClosing;
        platformView.PaneOpened += PlatformView_PaneOpened;
        platformView.PaneOpening += PlatformView_PaneOpening;
        platformView.SelectionChanged += PlatformView_SelectionChanged;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void DisconnectHandler(NavigationView platformView)
    {
        base.DisconnectHandler(platformView);
        platformView.BackRequested -= PlatformView_BackRequested;
        platformView.Collapsed -= PlatformView_Collapsed;
        platformView.DisplayModeChanged -= PlatformView_DisplayModeChanged;
        platformView.Expanding -= PlatformView_Expanding;
        platformView.ItemInvoked -= PlatformView_ItemInvoked;
        platformView.Loaded -= PlatformView_Loaded;
        platformView.PaneClosed -= PlatformView_PaneClosed;
        platformView.PaneClosing -= PlatformView_PaneClosing;
        platformView.PaneOpened -= PlatformView_PaneOpened;
        platformView.PaneOpening -= PlatformView_PaneOpening;
        platformView.SelectionChanged -= PlatformView_SelectionChanged;
    }

    #region Events

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>

    private void PlatformView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
    {
        VirtualView?.WinBackRequested(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_Collapsed(NavigationView sender, NavigationViewItemCollapsedEventArgs args)
    {
        var nargs = new DtNavigationItemCollapsedEventArgs { InvokedItem = args.CollapsedItem.ToString() };
        VirtualView?.WinCollapsed(sender, nargs);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        var nargs = new DtNavigationSelectionChangedEventArgs { InvokedItem = args.SelectedItem.ToString(), IsSettingsInvoked = args.IsSettingsSelected };
        VirtualView?.WinSelectionChanged(sender, nargs);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PlatformView_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        Trace.WriteLine("OnLoaded");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_PaneOpening(NavigationView sender, object args)
    {
        VirtualView?.WinPaneOpening(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_PaneOpened(NavigationView sender, object args)
    {
        VirtualView?.WinPaneOpening(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_PaneClosing(NavigationView sender, NavigationViewPaneClosingEventArgs args)
    {
        VirtualView?.WinPaneClosing(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_PaneClosed(NavigationView sender, object args)
    {
        VirtualView?.WinPaneClosed(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_Expanding(NavigationView sender, NavigationViewItemExpandingEventArgs args)
    {
        var nargs = new DtNavigationItemExpandingEventArgs { InvokedItem = args.ExpandingItem.ToString() };
        VirtualView?.WinExpanding(sender, nargs);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_DisplayModeChanged(NavigationView sender, NavigationViewDisplayModeChangedEventArgs args)
    {
        VirtualView?.WinDisplayModeChanged(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        var narg = new DtNavigationItemInvokedEventArgs { InvokedItem = args.InvokedItem.ToString(), IsSettingsInvoked = args.IsSettingsInvoked };
        VirtualView?.WinItemInvoked(sender, narg);
    }
    #endregion

    #region Properties

    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public static void MapContent(IDtNavigationHandler handler, IDtNavigation virtualView)
    {
        _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
        _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
        _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

        if (handler.VirtualView.PresentedContent is IView view)
        {
            handler.PlatformView.Content = view.ToPlatform(handler.MauiContext);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mauiContext"></param>
    public override void SetMauiContext(IMauiContext mauiContext)
    {
        DtMauiContext.mauiContext = mauiContext;
        base.SetMauiContext(mauiContext);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).Header = virtualView.Header;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapAlwaysShowHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).AlwaysShowHeader = virtualView.AlwaysShowHeader;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapAutoSuggestBox(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.AutoSuggestBox != null)
        {
            ((NavigationView)(viewHandler?.PlatformView)).AutoSuggestBox = (AutoSuggestBox)virtualView.AutoSuggestBox.ToHandler(DtMauiContext.mauiContext).PlatformView;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapIsBackButtonVisable(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        NavigationViewBackButtonVisible vis = NavigationViewBackButtonVisible.Auto;
        switch (virtualView.IsBackButtonVisable)
        {
            case DtNavigation.BackButtonVisable.Visible:
                vis = NavigationViewBackButtonVisible.Visible;
                break;
            case DtNavigation.BackButtonVisable.Collapsed:
                vis = NavigationViewBackButtonVisible.Collapsed;
                break;
            case DtNavigation.BackButtonVisable.Auto:
                vis = NavigationViewBackButtonVisible.Auto;
                break;
        }
        ((NavigationView)(viewHandler?.PlatformView)).IsBackButtonVisible = vis;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapBackButtonEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).IsBackEnabled = virtualView.IsBackButtonEnabled;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapCompactModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).CompactModeThresholdWidth = virtualView.CompactModeThresholdWidth;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapCompactPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).CompactPaneLength = virtualView.CompactPaneLength;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        switch (((NavigationView)(viewHandler?.PlatformView)).DisplayMode)
        {
            case NavigationViewDisplayMode.Compact:
                virtualView.DisplayMode = DtNavigation.ViewDisplayMode.Compact;
                break;
            case NavigationViewDisplayMode.Expanded:
                virtualView.DisplayMode = DtNavigation.ViewDisplayMode.Expanded;
                break;
            case NavigationViewDisplayMode.Minimal:
                virtualView.DisplayMode = DtNavigation.ViewDisplayMode.Minimal;
                break;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapExpandedModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).ExpandedModeThresholdWidth = virtualView.ExpandedModeThresholdWidth;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapFooterMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        virtualView.FooterMenuItems = (IList<object>)((NavigationView)(viewHandler?.PlatformView)).FooterMenuItems;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapFooterMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).FooterMenuItemsSource = virtualView.FooterMenuItemsSource;
    }
    //public static void MapHeaderTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    //{
    //    ((NavigationView)(viewHandler?.PlatformView)).HeaderTemplate = virtualView.HeaderTemplate;
    //}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapIsPaneOpen(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).IsPaneOpen = virtualView.IsPaneOpen;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapIsPaneToggleButtonVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).IsPaneToggleButtonVisible = virtualView.IsPaneToggleButtonVisible;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapIsSettingsVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).IsSettingsVisible = virtualView.IsSettingsVisible;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).IsTitleBarAutoPaddingEnabled = virtualView.IsTitleBarAutoPaddingEnabled;
    }
    //public static void MapMenuItemContainerStyle(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    //{
    //    ((NavigationView)(viewHandler?.PlatformView)).MenuItemContainerStyle = virtualView.MenuItemContainerStyle;
    //}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        virtualView.MenuItems = (IList<object>)((NavigationView)(viewHandler?.PlatformView)).MenuItems;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).MenuItemsSource = virtualView.MenuItemsSource;
    }

    //public static void MapMenuItemsTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    //{
    //    ((NavigationView)(viewHandler?.PlatformView)).MenuItemTemplate = virtualView.MenuItemsTemplate;
    //}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapOpenPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler?.PlatformView)).OpenPaneLength = virtualView.OpenPaneLength;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapPaneDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        NavigationViewPaneDisplayMode mode = NavigationViewPaneDisplayMode.Auto;
        switch (virtualView.PaneDisplayMode)
        {
            case DtNavigation.ViewPaneDisplayMode.Left:
                mode = NavigationViewPaneDisplayMode.Left;
                break;
            case DtNavigation.ViewPaneDisplayMode.Auto:
                mode = NavigationViewPaneDisplayMode.Auto;
                break;
            case DtNavigation.ViewPaneDisplayMode.LeftCompact:
                mode = NavigationViewPaneDisplayMode.LeftCompact;
                break;
            case DtNavigation.ViewPaneDisplayMode.Top:
                mode = NavigationViewPaneDisplayMode.Top;
                break;
            case DtNavigation.ViewPaneDisplayMode.LeftMinimal:
                mode = NavigationViewPaneDisplayMode.LeftMinimal;
                break;
        }

        ((NavigationView)(viewHandler?.PlatformView)).PaneDisplayMode = mode;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapOverflowLabelMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        NavigationViewOverflowLabelMode mode = NavigationViewOverflowLabelMode.NoLabel;

        switch (virtualView.OverflowLabelMode)
        {
            case DtNavigation.ViewOverflowLabelMode.MoreLabel:
                mode = NavigationViewOverflowLabelMode.MoreLabel;
                break;
            case DtNavigation.ViewOverflowLabelMode.NoLabel:
                mode = NavigationViewOverflowLabelMode.NoLabel;
                break;
        }

        ((NavigationView)(viewHandler?.PlatformView)).OverflowLabelMode = mode;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapSelectedItem(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.SelectedItem != null)
        {
            ((NavigationView)(viewHandler?.PlatformView)).SelectedItem = virtualView.SelectedItem;
        }
    }
    #endregion
}
#endif
