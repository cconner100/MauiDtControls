namespace DtControls.Controls;

using System.Collections.Generic;

using DtControls.Models;

using Microsoft.Maui.Graphics;

/// <summary>
/// 
/// </summary>
[ContentProperty("Content")]
public partial class DtNavigation : View, IContentView, IDtNavigation
{

    /// <summary>
    /// 
    /// </summary>
    public enum BackButtonVisable
    {
        /// <summary>
        /// 
        /// </summary>
        Visible,

        /// <summary>
        /// 
        /// </summary>
        Collapsed,

        /// <summary>
        /// 
        /// </summary>
        Auto
    }


    /// <summary>
    /// 
    /// </summary>
    public enum ViewDisplayMode
    {
        /// <summary>
        /// 
        /// </summary>
        Compact,

        /// <summary>
        /// 
        /// </summary>
        Expanded,

        /// <summary>
        /// 
        /// </summary>
        Minimal
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ViewOverflowLabelMode
    {
        /// <summary>
        /// 
        /// </summary>
        MoreLabel,

        /// <summary>
        /// 
        /// </summary>
        NoLabel
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ViewPaneDisplayMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,

        /// <summary>
        /// 
        /// </summary>
        Left,

        /// <summary>
        /// 
        /// </summary>
        LeftCompact,

        /// <summary>
        /// 
        /// </summary>
        LeftMinimal,

        /// <summary>
        /// 
        /// </summary>
        Top
    }

    /// <summary>
    /// Where to place menu items
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
    public event EventHandler BackRequested;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler<DtNavigationItemCollapsedEventArgs> Collapsed;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler DisplayModeChanged;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler<DtNavigationItemExpandingEventArgs> Expanding;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler<DtNavigationItemInvokedEventArgs> ItemInvoked;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler PaneClosed;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler PaneClosing;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler PaneOpened;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler PaneOpening;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler<DtNavigationSelectionChangedEventArgs> SelectionChanged;
    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinBackRequested(object sender, object args)
    {
        BackRequested?.Invoke(sender, null);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinCollapsed(object sender, DtNavigationItemCollapsedEventArgs args)
    {
        Collapsed?.Invoke(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinDisplayModeChanged(object sender, object args)
    {
        DisplayModeChanged?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinExpanding(object sender, DtNavigationItemExpandingEventArgs args)
    {
        Expanding?.Invoke(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinItemInvoked(object sender, DtNavigationItemInvokedEventArgs args)
    {
        ItemInvoked?.Invoke(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinPaneClosed(object sender, object args)
    {
        PaneClosed?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinPaneClosing(object sender, object args)
    {
        PaneClosing?.Invoke(sender, null);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinPaneOpened(object sender, object args)
    {
        PaneOpened?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinPaneOpening(object sender, object args)
    {
        PaneOpening?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinSelectionChanged(object sender, DtNavigationSelectionChangedEventArgs args)
    {
        SelectionChanged?.Invoke(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="widthConstraint"></param>
    /// <param name="heightConstraint"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bounds"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size CrossPlatformArrange(Rect bounds)
    {
        throw new NotImplementedException();
    }

    #region Properties

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty AlwaysShowHeaderProperty = BindableProperty.Create("AlwaysShowHeader", typeof(bool), typeof(DtNavigation), true);

    /// <summary>
    /// show the header?
    /// </summary>
    public bool AlwaysShowHeader
    {
        get { return (bool)GetValue(AlwaysShowHeaderProperty); }
        set { SetValue(AlwaysShowHeaderProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty AutoSuggestBoxProperty = BindableProperty.Create("AutoSuggestBox", typeof(SearchBar), typeof(DtNavigation));

    /// <summary>
    /// show the header?
    /// </summary>
    public SearchBar AutoSuggestBox
    {
        get { return (SearchBar)GetValue(AutoSuggestBoxProperty); }
        set { SetValue(AutoSuggestBoxProperty, value); }
    }
    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(string), typeof(DtNavigation));

    /// <summary>
    /// 
    /// </summary>
    public string Header
    {
        get { return (string)GetValue(HeaderProperty); }
        set { SetValue(HeaderProperty, value); }
    }



    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsBackButtonVisableProperty = BindableProperty.Create("IsBackButtonVisable", typeof(BackButtonVisable), typeof(DtNavigation), BackButtonVisable.Auto);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsBackButtonEnabledProperty = BindableProperty.Create("IsBackButtonEnabled", typeof(bool), typeof(DtNavigation), false);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty CompactModeThresholdWidthProperty = BindableProperty.Create("CompactModeThresholdWidth", typeof(double), typeof(DtNavigation), 641.0);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty CompactPaneLengthProperty = BindableProperty.Create("CompactPaneLength", typeof(double), typeof(DtNavigation), 48.0);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtNavigation));

    /// <summary>
    /// 
    /// </summary>
    public object Content
    {
        get { return (View)GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty DisplayModeProperty = BindableProperty.Create("DisplayMode", typeof(ViewDisplayMode), typeof(DtNavigation), ViewDisplayMode.Minimal);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty ExpandedModeThresholdWidthProperty = BindableProperty.Create("ExpandedModeThresholdWidth", typeof(double), typeof(DtNavigation), 1008.0);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty FooterMenuItemsProperty = BindableProperty.Create("FooterMenuItems", typeof(IList<object>), typeof(DtNavigation));

    /// <summary>
    /// 
    /// </summary>
    public IList<object> FooterMenuItems
    {
        get
        {
            return (IList<object>)GetValue(FooterMenuItemsProperty);
        }
        set
        {
            SetValue(FooterMenuItemsProperty, value);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty FooterMenuItemsSourceProperty = BindableProperty.Create("FooterMenuItemsSource", typeof(object), typeof(DtNavigation));

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public DataTemplate HeaderTemplate { get; set; }


    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsPaneOpenProperty = BindableProperty.Create("IsPaneOpen", typeof(bool), typeof(DtNavigation), true);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsPaneToggleButtonVisibleProperty = BindableProperty.Create("IsPaneToggleButtonVisible", typeof(bool), typeof(DtNavigation), true);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsSettingsVisibleProperty = BindableProperty.Create("IsSettingsVisible", typeof(bool), typeof(DtNavigation), true);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsTitleBarAutoPaddingEnabledProperty = BindableProperty.Create("IsTitleBarAutoPaddingEnabled", typeof(bool), typeof(DtNavigation), true);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty MenuItemContainerStyleProperty = BindableProperty.Create("MenuItemContainerStyle", typeof(Style), typeof(DtNavigation));

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty MenuItemsProperty = BindableProperty.Create("MenuItems", typeof(IList<object>), typeof(DtNavigation), null, BindingMode.TwoWay);

    /// <summary>
    /// 
    /// </summary>
    public IList<object> MenuItems
    {
        get
        {
            return (IList<object>)GetValue(MenuItemsProperty);
        }
        set
        {
            SetValue(MenuItemsProperty, value);
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty MenuItemsSourceProperty = BindableProperty.Create("MenuItemsSource", typeof(object), typeof(DtNavigation));

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public DataTemplate MenuItemsTemplate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty OpenPaneLengthProperty = BindableProperty.Create("OpenPaneLength", typeof(double), typeof(DtNavigation), 320.0);

    /// <summary>
    /// 
    /// </summary>
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


    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty OverflowLabelModeProperty = BindableProperty.Create("OverflowLabelMode", typeof(ViewOverflowLabelMode), typeof(DtNavigation), ViewOverflowLabelMode.MoreLabel);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty PaneDisplayModeProperty = BindableProperty.Create("PaneDisplayMode", typeof(ViewPaneDisplayMode), typeof(DtNavigation), ViewPaneDisplayMode.Auto);

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(DtNavigation));

    /// <summary>
    /// 
    /// </summary>
    public object SelectedItem
    {
        get
        {
            return (object)GetValue(SelectedItemProperty);
        }
        set
        {
            SetValue(SelectedItemProperty, value);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public Thickness Padding
    {
        get;
        set;
    }

#nullable enable
    /// <summary>
    /// 
    /// </summary>
    object? IContentView.Content => Content;

    /// <summary>
    /// 
    /// </summary>
    IView? IContentView.PresentedContent => (View)Content;
#nullable disable
    #endregion
}

