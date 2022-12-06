#if WINDOWS
namespace DtControls.Handlers;

using DtControls.Models;
using DtControls.Controls;

using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Controls;


public partial class DtNavigationHandler : ViewHandler<DtNavigation, NavigationView>, IDtNavigationHandler
{
    readonly NavigationView _navigationView = new();

    IDtNavigation IDtNavigationHandler.VirtualView => VirtualView;

    protected override NavigationView CreatePlatformView()
    {
        return _navigationView;
    }

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


    void PlatformView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
    {
        VirtualView?.HandleBackRequested(sender, args);
    }

    void PlatformView_Collapsed(NavigationView sender, NavigationViewItemCollapsedEventArgs args)
    {
        VirtualView?.HandleCollapsed(sender, new DtNavigationItemCollapsedEventArgs(args));
    }

    void PlatformView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        VirtualView?.HandleSelectionChanged(sender, new DtNavigationSelectionChangedEventArgs(VirtualView, args));
    }

    void PlatformView_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        VirtualView?.HandleOnLoaded(this, null);
    }

    void PlatformView_PaneOpening(NavigationView sender, object args)
    {
        VirtualView?.HandlePaneOpening(sender, args);
    }

    void PlatformView_PaneOpened(NavigationView sender, object args)
    {
        VirtualView?.HandlePaneOpened(sender, args);
    }

    void PlatformView_PaneClosing(NavigationView sender, NavigationViewPaneClosingEventArgs args)
    {
        VirtualView?.HandlePaneClosing(sender, new DtNavigationPaneClosingEventArgs(args));
    }

    void PlatformView_PaneClosed(NavigationView sender, object args)
    {
        VirtualView?.HandlePaneClosed(sender, args);
    }

    void PlatformView_Expanding(NavigationView sender, NavigationViewItemExpandingEventArgs args)
    {
        VirtualView?.HandleExpanding(sender, new DtNavigationItemExpandingEventArgs(args));
    }

    void PlatformView_DisplayModeChanged(NavigationView sender, NavigationViewDisplayModeChangedEventArgs args)
    {
        VirtualView?.HandleDisplayModeChanged(sender, new DtNavigationDisplayModeChangedEventArgs(args));
    }

    void PlatformView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {        
        VirtualView?.HandleItemInvoked(sender, new DtNavigationItemInvokedEventArgs(VirtualView, args));
    }
    #endregion

    #region Properties

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


    public override void SetMauiContext(IMauiContext mauiContext)
    {
        DtMauiContext.MauiContext = mauiContext;
        base.SetMauiContext(mauiContext);
    }

    public static void MapHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).Header = virtualView.Header;
    }


    public static void MapAlwaysShowHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).AlwaysShowHeader = virtualView.AlwaysShowHeader;
    }


    public static void MapAutoSuggestBox(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.AutoSuggestBox != null)
        {
            if (DtMauiContext.MauiContext is null)
            {
                throw new Exception("Maui Context is null");
            }
            (viewHandler.PlatformView).AutoSuggestBox = (AutoSuggestBox)virtualView.AutoSuggestBox.ToHandler(DtMauiContext.MauiContext).PlatformView!;
        }
    }

    public static void MapIsBackButtonVisable(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        NavigationViewBackButtonVisible vis = NavigationViewBackButtonVisible.Auto;
        switch (virtualView.IsBackButtonVisible)
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
        (viewHandler.PlatformView).IsBackButtonVisible = vis;
    }

    public static void MapBackButtonEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).IsBackEnabled = virtualView.IsBackButtonEnabled;
    }

    public static void MapCompactModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).CompactModeThresholdWidth = virtualView.CompactModeThresholdWidth;
    }

    public static void MapCompactPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).CompactPaneLength = virtualView.CompactPaneLength;
    }

    public static void MapDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        switch ((viewHandler.PlatformView).DisplayMode)
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

    public static void MapExpandedModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).ExpandedModeThresholdWidth = virtualView.ExpandedModeThresholdWidth;
    }

    public static void MapFooterMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if(virtualView.FooterMenuItems == null || !virtualView.FooterMenuItems.Any())
        {
            return;
        }
        (viewHandler.PlatformView).FooterMenuItems.Clear();
        var menu = viewHandler.BuildPlatformMenus(virtualView.FooterMenuItems, virtualView);
        if (menu != null)
        {
            foreach (var menuItem in menu)
            {
                (viewHandler.PlatformView).FooterMenuItems.Add(menuItem);
            }

        }
    }


    public static void MapFooterMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).FooterMenuItemsSource = virtualView.FooterMenuItemsSource;
    }

    //public static void MapHeaderTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    //{
    //    ((NavigationView)(viewHandler?.PlatformView)).HeaderTemplate = virtualView.HeaderTemplate;
    //}

    public static void MapIsPaneOpen(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).IsPaneOpen = virtualView.IsPaneOpen;
    }

    public static void MapIsPaneToggleButtonVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).IsPaneToggleButtonVisible = virtualView.IsPaneToggleButtonVisible;
    }

    public static void MapIsSettingsVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler.PlatformView)).IsSettingsVisible = virtualView.IsSettingsVisible;
    }


    public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        ((NavigationView)(viewHandler.PlatformView)).IsTitleBarAutoPaddingEnabled = virtualView.IsTitleBarAutoPaddingEnabled;
    }

    //public static void MapMenuItemContainerStyle(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    //{
    //    ((NavigationView)(viewHandler?.PlatformView)).MenuItemContainerStyle = virtualView.MenuItemContainerStyle;
    //}

    public static void MapMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if(virtualView.MenuItems == null || !virtualView.MenuItems.Any())
        {
            return;
        }
        var menus = viewHandler.BuildPlatformMenus(virtualView.MenuItems, virtualView);

        if (menus != null)
        {
            foreach (var menuItem in menus)
            {
                (viewHandler.PlatformView).MenuItems.Add(menuItem);
            }

        }
    }

    public static void MapMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).MenuItemsSource = virtualView.MenuItemsSource;
    }

    //public static void MapMenuItemsTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    //{
    //    ((NavigationView)(viewHandler?.PlatformView)).MenuItemTemplate = virtualView.MenuItemsTemplate;
    //}

    public static void MapOpenPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        (viewHandler.PlatformView).OpenPaneLength = virtualView.OpenPaneLength;
    }


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

        (viewHandler.PlatformView).PaneDisplayMode = mode;
    }

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

        (viewHandler.PlatformView).OverflowLabelMode = mode;
    }

    public static void MapSelectedItem(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.SelectedItem != null)
        {
            (viewHandler.PlatformView).SelectedItem = virtualView.SelectedItem;
        }
    }
    #endregion

    public List<NavigationViewItem>? BuildPlatformMenus(IList<DtMenuItem> menulist, IDtNavigation virtualView)
    {
        if (menulist == null)
        {
            return null;
        }
        List<NavigationViewItem> items = new List<NavigationViewItem>();
        foreach (var item in menulist)
        {
            items.Add(MakeMenuItem(item, virtualView));
        }
        return items;
    }

   
    NavigationViewItem MakeMenuItem(DtMenuItem item, IDtNavigation virtualView)
    {
        //var tooltip = new Microsoft.UI.Xaml.Controls.ToolTip
        //{
        //    Content = item.toolTip
        //};
        var ret = new NavigationViewItem
        {
            Content = item.title,
            Tag = item.screen
        };
        if (item.platformImage != null)
        {
            ret.Icon = (IconElement)item.platformImage;
        }
        else
        {
            if (item.MauiIconImage != null)
            {
                var iconSource = item.MauiIconImage.ToIconSource(DtMauiContext.MauiContext!);
                if (iconSource != null)
                {
                    if (PlatformView.Resources.TryGetValue("NavigationViewItemForeground", out object nviForeground) &&
                                    nviForeground is Microsoft.UI.Xaml.Media.Brush brush)
                    {
                        iconSource.Foreground = brush;
                    }

                    ret.Icon = iconSource.CreateIconElement();
                }
            }
        }
        item.InternalObject = ret;

        //ToolTipService.SetToolTip(ret, tooltip);
        if (item.ChildrenItems.Any())
        {
            foreach (var child in item.ChildrenItems)
            {
                ret.MenuItems.Add(MakeMenuItem(child, virtualView));
            }
        }
        if (item.menuType == DtMenuItem.MenuType.Row)
        {
            if (ret.Content != null)
            {
                virtualView.MenuNames.Add(ret.Content.ToString()!, item);
            }
        }
        return ret;
    }
}
#endif
