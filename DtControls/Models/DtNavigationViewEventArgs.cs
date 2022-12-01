namespace DtControls.Models;

using DtControls.Controls;

#if WINDOWS
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
#endif

public class DtNavigationBackRequestedEventArgs : object { }

public class DtNavigationItemCollapsedEventArgs
{
    public object CollapsedItem { get; protected set; }

#if WINDOWS
    NavigationViewItemBase CollapsedItemContainer { get; }

    public DtNavigationItemCollapsedEventArgs(NavigationViewItemCollapsedEventArgs args)
    {
        CollapsedItem = args.CollapsedItem;
        CollapsedItemContainer = args.CollapsedItemContainer;
    }

#else
    public DtNavigationItemCollapsedEventArgs(object args){}
#endif
}

public class DtNavigationDisplayModeChangedEventArgs
{
    public enum DtNavigationDisplayMode
    {
        Compact = 1,
        Expanded = 2,
        Minimal = 3
    }

    public DtNavigationDisplayMode DisplayMode { get; protected set; }
#if WINDOWS
    public DtNavigationDisplayModeChangedEventArgs(NavigationViewDisplayModeChangedEventArgs args)
    {
        switch (args.DisplayMode)
        {
            case NavigationViewDisplayMode.Compact:
                DisplayMode = DtNavigationDisplayMode.Compact;
                break;
            case NavigationViewDisplayMode.Expanded:
                DisplayMode = DtNavigationDisplayMode.Expanded;
                break;
            case NavigationViewDisplayMode.Minimal:
                DisplayMode = DtNavigationDisplayMode.Minimal;
                break;
        }
    }
#endif
}
public class DtNavigationItemExpandingEventArgs
{
    public object ExpandingItem { get; protected set; }
#if WINDOWS
    NavigationViewItemBase ExpandingItemContainer { get; set; }

    public DtNavigationItemExpandingEventArgs(NavigationViewItemExpandingEventArgs args)
    {
        ExpandingItem = args.ExpandingItem;
        ExpandingItemContainer = args.ExpandingItemContainer;
    }
#else
    public DtNavigationItemExpandingEventArgs(object args){}
#endif
}

public class DtNavigationItemInvokedEventArgs
{
    public DtMenuItem ItemInvoked { get; protected set; }
    public bool IsSettingsInvoked { get; protected set; }

#if WINDOWS
    NavigationViewItemBase InvokedItemContainer;
    NavigationTransitionInfo RecommendedNavigationTransitionInfo;

    public DtNavigationItemInvokedEventArgs(DtNavigation sender, NavigationViewItemInvokedEventArgs args)
    {
        var menu = DtMenuItem.ResolveDtMenuItemFromNative(sender, args.InvokedItemContainer);
        // change native to dtmenu
        if (menu != null)
        {
            ItemInvoked = menu;
        }

        InvokedItemContainer = args.InvokedItemContainer;
        IsSettingsInvoked = args.IsSettingsInvoked;
        RecommendedNavigationTransitionInfo = args.RecommendedNavigationTransitionInfo;
    }
#endif
}

public class DtNavigationPaneClosingEventArgs
{
#if WINDOWS
    readonly NavigationViewPaneClosingEventArgs orgArgs;

    public bool Cancel
    {
        get
        {
            return orgArgs.Cancel;
        }
        set
        {
            orgArgs.Cancel = value;
        }
    }
    public DtNavigationPaneClosingEventArgs(NavigationViewPaneClosingEventArgs args)
    {
        orgArgs = args;
    }
#else
    public bool Cancel {get;set;}
#endif
}

public class DtNavigationSelectionChangedEventArgs
{
    public DtMenuItem SelectedItem { get; protected set; }
#if WINDOWS
    readonly NavigationViewSelectionChangedEventArgs orgArgs;
    public bool IsSettingsSelected => orgArgs.IsSettingsSelected;

    public DtNavigationSelectionChangedEventArgs(DtNavigation sender, NavigationViewSelectionChangedEventArgs args)
    {
        var menu = DtMenuItem.ResolveDtMenuItemFromNative(sender, args.SelectedItem);
        // change native to dtmenu
        if (menu != null)
        {
            SelectedItem = menu;
        }
        orgArgs = args;
    }
#else
    public bool IsSettingsSelected {get;set;}
    public DtNavigationSelectionChangedEventArgs(object args) {}
#endif
}






