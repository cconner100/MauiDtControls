namespace DtControls.Controls;

using System.Collections.Generic;

using DtControls.Models;

using Microsoft.Maui.Graphics;

[ContentProperty("Content")]
public partial class DtNavigation : View, IContentView, IDtNavigation
{

    public enum BackButtonVisable
    {
        Visible,
        Collapsed,
        Auto
    }


    public enum ViewDisplayMode
    {
        Compact,
        Expanded,
        Minimal
    }

    public enum ViewOverflowLabelMode
    {
        MoreLabel,
        NoLabel
    }

    public enum ViewPaneDisplayMode
    {
        Auto,
        Left,
        LeftCompact,
        LeftMinimal,
        Top
    }

    public enum MenuArea
    {
        /// <summary>
        /// header if available
        /// </summary>
        header,

        /// <summary>
        /// Main items
        /// </summary>
        main,

        /// <summary>
        /// Footer items
        /// </summary>
        footer
    }
    #region Events
    public event EventHandler OnLoaded;

    public event EventHandler BackRequested;

    public event EventHandler<DtNavigationItemCollapsedEventArgs> Collapsed;

    public event EventHandler DisplayModeChanged;

    public event EventHandler<DtNavigationItemExpandingEventArgs> Expanding;

    public event EventHandler<DtNavigationItemInvokedEventArgs> ItemInvoked;

    public event EventHandler PaneClosed;

    public event EventHandler PaneClosing;

    public event EventHandler PaneOpened;

    public event EventHandler PaneOpening;

    public event EventHandler<DtNavigationSelectionChangedEventArgs> SelectionChanged;
    #endregion

    public IMauiContext mauiContext
    {
        get
        {
            return DtMauiContext.mauiContext;
        }
    }

    public void HandleOnLoaded(object sender, object args)
    {
        OnLoaded?.Invoke(sender, null);
    }

    public void HandleBackRequested(object sender, object args)
    {
        BackRequested?.Invoke(sender, null);
    }

    public void HandleCollapsed(object sender, DtNavigationItemCollapsedEventArgs args)
    {
        Collapsed?.Invoke(sender, args);
    }

    public void HandleDisplayModeChanged(object sender, object args)
    {
        DisplayModeChanged?.Invoke(sender, (EventArgs)args);
    }

    public void HandleExpanding(object sender, DtNavigationItemExpandingEventArgs args)
    {
        Expanding?.Invoke(sender, args);
    }

    public void HandleItemInvoked(object sender, DtNavigationItemInvokedEventArgs args)
    {
        ItemInvoked?.Invoke(sender, args);
    }

    public void HandlePaneClosed(object sender, object args)
    {
        PaneClosed?.Invoke(sender, (EventArgs)args);
    }

    public void HandlePaneClosing(object sender, object args)
    {
        PaneClosing?.Invoke(sender, null);
    }

    public void HandlePaneOpened(object sender, object args)
    {
        PaneOpened?.Invoke(sender, (EventArgs)args);
    }

    public void HandlePaneOpening(object sender, object args)
    {
        PaneOpening?.Invoke(sender, (EventArgs)args);
    }

    public void HandleSelectionChanged(object sender, DtNavigationSelectionChangedEventArgs args)
    {
        SelectionChanged?.Invoke(sender, args);
    }

    public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }

    public Size CrossPlatformArrange(Rect bounds)
    {
        throw new NotImplementedException();
    }

    #region Properties

    public static readonly BindableProperty AlwaysShowHeaderProperty = BindableProperty.Create("AlwaysShowHeader", typeof(bool), typeof(DtNavigation), true);
    public bool AlwaysShowHeader
    {
        get { return (bool)GetValue(AlwaysShowHeaderProperty); }
        set { SetValue(AlwaysShowHeaderProperty, value); }
    }

    public static readonly BindableProperty AutoSuggestBoxProperty = BindableProperty.Create("AutoSuggestBox", typeof(SearchBar), typeof(DtNavigation));
    public SearchBar AutoSuggestBox
    {
        get { return (SearchBar)GetValue(AutoSuggestBoxProperty); }
        set { SetValue(AutoSuggestBoxProperty, value); }
    }

    public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(string), typeof(DtNavigation));
    public string Header
    {
        get { return (string)GetValue(HeaderProperty); }
        set { SetValue(HeaderProperty, value); }
    }


    public static readonly BindableProperty IsBackButtonVisableProperty = BindableProperty.Create("IsBackButtonVisable", typeof(BackButtonVisable), typeof(DtNavigation), BackButtonVisable.Auto);
    public BackButtonVisable IsBackButtonVisable
    {
        get
        {
            return (BackButtonVisable)GetValue(IsBackButtonVisableProperty);
        }
        set
        {
            SetValue(IsBackButtonVisableProperty, value);
        }
    }

    public static readonly BindableProperty IsBackButtonEnabledProperty = BindableProperty.Create("IsBackButtonEnabled", typeof(bool), typeof(DtNavigation), false);
    public bool IsBackButtonEnabled
    {
        get
        {
            return (bool)GetValue(IsBackButtonEnabledProperty);
        }
        set
        {
            SetValue(IsBackButtonEnabledProperty, value);
        }
    }

    public static readonly BindableProperty CompactModeThresholdWidthProperty = BindableProperty.Create("CompactModeThresholdWidth", typeof(double), typeof(DtNavigation), 641.0);
    public double CompactModeThresholdWidth
    {
        get
        {
            return (double)GetValue(CompactModeThresholdWidthProperty);
        }
        set
        {
            SetValue(CompactModeThresholdWidthProperty, value);
        }
    }

    public static readonly BindableProperty CompactPaneLengthProperty = BindableProperty.Create("CompactPaneLength", typeof(double), typeof(DtNavigation), 48.0);
    public double CompactPaneLength
    {
        get
        {
            return (double)GetValue(CompactPaneLengthProperty);
        }
        set
        {
            SetValue(CompactPaneLengthProperty, value);
        }
    }

    public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtNavigation));
    public object Content
    {
        get { return (View)GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }

    public static readonly BindableProperty DisplayModeProperty = BindableProperty.Create("DisplayMode", typeof(ViewDisplayMode), typeof(DtNavigation), ViewDisplayMode.Minimal);
    public ViewDisplayMode DisplayMode
    {
        get
        {
            return (ViewDisplayMode)GetValue(DisplayModeProperty);
        }
        set
        {
            SetValue(DisplayModeProperty, value);
        }
    }

    public static readonly BindableProperty ExpandedModeThresholdWidthProperty = BindableProperty.Create("ExpandedModeThresholdWidth", typeof(double), typeof(DtNavigation), 1008.0);
    public double ExpandedModeThresholdWidth
    {
        get
        {
            return (double)GetValue(ExpandedModeThresholdWidthProperty);
        }
        set
        {
            SetValue(ExpandedModeThresholdWidthProperty, value);
        }
    }

    public static readonly BindableProperty FooterMenuItemsProperty = BindableProperty.Create("FooterMenuItems", typeof(IList<DtMenuItem>), typeof(DtNavigation));
    public IList<DtMenuItem> FooterMenuItems
    {
        get
        {
            return (IList<DtMenuItem>)GetValue(FooterMenuItemsProperty);
        }
        set
        {
            SetValue(FooterMenuItemsProperty, value);
        }
    }

    public static readonly BindableProperty HeaderMenuItemsProperty = BindableProperty.Create("HeaderMenuItems", typeof(IList<object>), typeof(DtNavigation));
    public IList<object> HeaderMenuItems
    {
        get
        {
            return (IList<object>)GetValue(HeaderMenuItemsProperty);
        }
        set
        {
            SetValue(HeaderMenuItemsProperty, value);
        }
    }

    public static readonly BindableProperty FooterMenuItemsSourceProperty = BindableProperty.Create("FooterMenuItemsSource", typeof(object), typeof(DtNavigation));
    public object FooterMenuItemsSource
    {
        get
        {
            return (object)GetValue(FooterMenuItemsSourceProperty);
        }
        set
        {
            SetValue(FooterMenuItemsSourceProperty, value);
        }
    }

    public DataTemplate HeaderTemplate { get; set; }

    public static readonly BindableProperty IsPaneOpenProperty = BindableProperty.Create("IsPaneOpen", typeof(bool), typeof(DtNavigation), true);
    public bool IsPaneOpen
    {
        get
        {
            return (bool)GetValue(IsPaneOpenProperty);
        }
        set
        {
            SetValue(IsPaneOpenProperty, value);
        }
    }

    public static readonly BindableProperty IsPaneToggleButtonVisibleProperty = BindableProperty.Create("IsPaneToggleButtonVisible", typeof(bool), typeof(DtNavigation), true);
    public bool IsPaneToggleButtonVisible
    {
        get
        {
            return (bool)GetValue(IsPaneToggleButtonVisibleProperty);
        }
        set
        {
            SetValue(IsPaneToggleButtonVisibleProperty, value);
        }
    }

    public static readonly BindableProperty IsSettingsVisibleProperty = BindableProperty.Create("IsSettingsVisible", typeof(bool), typeof(DtNavigation), true);
    public bool IsSettingsVisible
    {
        get
        {
            return (bool)GetValue(IsSettingsVisibleProperty);
        }
        set
        {
            SetValue(IsSettingsVisibleProperty, value);
        }
    }


    public static readonly BindableProperty IsTitleBarAutoPaddingEnabledProperty = BindableProperty.Create("IsTitleBarAutoPaddingEnabled", typeof(bool), typeof(DtNavigation), false);
    public bool IsTitleBarAutoPaddingEnabled
    {
        get
        {
            return (bool)GetValue(IsTitleBarAutoPaddingEnabledProperty);
        }
        set
        {
            SetValue(IsTitleBarAutoPaddingEnabledProperty, value);
        }
    }

    public static readonly BindableProperty MenuItemContainerStyleProperty = BindableProperty.Create("MenuItemContainerStyle", typeof(Style), typeof(DtNavigation));
    public Style MenuItemContainerStyle
    {
        get
        {
            return (Style)GetValue(MenuItemContainerStyleProperty);
        }
        set
        {
            SetValue(MenuItemContainerStyleProperty, value);
        }
    }

    public static readonly BindableProperty MenuItemsProperty = BindableProperty.Create("MenuItems", typeof(IList<DtMenuItem>), typeof(DtNavigation), null, BindingMode.TwoWay);
    public IList<DtMenuItem> MenuItems
    {
        get
        {
            return (IList<DtMenuItem>)GetValue(MenuItemsProperty);
        }
        set
        {
            SetValue(MenuItemsProperty, value);
        }
    }

    public static readonly BindableProperty MenuItemsSourceProperty = BindableProperty.Create("MenuItemsSource", typeof(object), typeof(DtNavigation));
    public object MenuItemsSource
    {
        get
        {
            return (object)GetValue(MenuItemsSourceProperty);
        }
        set
        {
            SetValue(MenuItemsSourceProperty, value);
        }
    }

    public DataTemplate MenuItemsTemplate { get; set; }

    public static readonly BindableProperty OpenPaneLengthProperty = BindableProperty.Create("OpenPaneLength", typeof(double), typeof(DtNavigation), 320.0);
    public double OpenPaneLength
    {
        get
        {
            return (double)GetValue(OpenPaneLengthProperty);
        }
        set
        {
            SetValue(OpenPaneLengthProperty, value);
        }
    }



    public static readonly BindableProperty OverflowLabelModeProperty = BindableProperty.Create("OverflowLabelMode", typeof(ViewOverflowLabelMode), typeof(DtNavigation), ViewOverflowLabelMode.MoreLabel);
    public ViewOverflowLabelMode OverflowLabelMode
    {
        get
        {
            return (ViewOverflowLabelMode)GetValue(OverflowLabelModeProperty);
        }
        set
        {
            SetValue(OverflowLabelModeProperty, value);
        }
    }


    public static readonly BindableProperty PaneDisplayModeProperty = BindableProperty.Create("PaneDisplayMode", typeof(ViewPaneDisplayMode), typeof(DtNavigation), ViewPaneDisplayMode.Auto);
    public ViewPaneDisplayMode PaneDisplayMode
    {
        get
        {
            return (ViewPaneDisplayMode)GetValue(PaneDisplayModeProperty);
        }
        set
        {
            SetValue(PaneDisplayModeProperty, value);
        }
    }


    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(DtMenuItem), typeof(DtNavigation));
    public DtMenuItem SelectedItem
    {
        get
        {
            return (DtMenuItem)GetValue(SelectedItemProperty);
        }
        set
        {
            SetValue(SelectedItemProperty, value);
        }
    }

    public Thickness Padding
    {
        get;
        set;
    }

#nullable enable

    object? IContentView.Content => Content;

    IView? IContentView.PresentedContent => (View)Content;

    public Dictionary<string, DtMenuItem> MenuNames { get; } = new Dictionary<string, DtMenuItem>();

#nullable disable
    #endregion


    public Dictionary<string, DtMenuItem> SearchMenuItems(string name)
    {
        var ret = new Dictionary<string, DtMenuItem>();
        foreach (var item in MenuNames)
        {
            if (item.Key.Contains(name, StringComparison.OrdinalIgnoreCase))
            {
                ret.Add(item.Key, item.Value);
            }
        }
        return ret;
    }
    public void ClearMenus()
    {
        MenuNames.Clear();
    }
}

