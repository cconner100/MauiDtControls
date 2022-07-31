using static DtControls.UserControls.DtNavigationView;

namespace DtControls.UserControls
{
    using System.Collections.Generic;

    using Microsoft.Maui.Graphics;

    [ContentProperty("Content")]

    public partial class DtNavigationView : View, IContentView, IDtNavigationView
    {
        public DtNavigationView()
        {
        }
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

        #region Events
        public event EventHandler BackRequested;
        public event EventHandler Collapsed;
        public event EventHandler DisplayModeChanged;
        public event EventHandler Expanding;
        public event EventHandler ItemInvoked;
        public event EventHandler PaneClosed;
        public event EventHandler PaneClosing;
        public event EventHandler PaneOpened;
        public event EventHandler PaneOpening;
        public event EventHandler SelectionChanged;
        #endregion

        public void WinBackRequested(object sender, object args)
        {
            BackRequested?.Invoke(sender, (EventArgs)args);
        }

        public void WinCollapsed(object sender, object args)
        {
            Collapsed?.Invoke(sender, (EventArgs)args);
        }
        public void WinDisplayModeChanged(object sender, object args)
        {
            DisplayModeChanged?.Invoke(sender, (EventArgs)args);
        }
        public void WinExpanding(object sender, object args)
        {
            Expanding?.Invoke(sender, (EventArgs)args);
        }
        public void WinItemInvoked(object sender, object args)
        {
            ItemInvoked?.Invoke(sender, (EventArgs)args);
        }
        public void WinPaneClosed(object sender, object args)
        {
            PaneClosed?.Invoke(sender, (EventArgs)args);
        }
        public void WinPaneClosing(object sender, object args)
        {
            PaneClosing?.Invoke(sender, (EventArgs)args);
        }
        public void WinPaneOpened(object sender, object args)
        {
            PaneOpened?.Invoke(sender, (EventArgs)args);
        }
        public void WinPaneOpening(object sender, object args)
        {
            PaneOpening?.Invoke(sender, (EventArgs)args);
        }
        public void WinSelectionChanged(object sender, object args)
        {
            SelectionChanged?.Invoke(sender, (EventArgs)args);
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
        public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(string), typeof(DtNavigationView));
        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }
        public static readonly BindableProperty AlwaysShowHeaderProperty = BindableProperty.Create("AlwaysShowHeader", typeof(bool), typeof(DtNavigationView), true);
        public bool AlwaysShowHeader
        {
            get { return (bool)GetValue(AlwaysShowHeaderProperty); }
            set { SetValue(AlwaysShowHeaderProperty, value); }
        }
        public static readonly BindableProperty IsBackButtonVisableProperty = BindableProperty.Create("IsBackButtonVisable", typeof(BackButtonVisable), typeof(DtNavigationView), BackButtonVisable.Auto);
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
        public static readonly BindableProperty IsBackButtonEnabledProperty = BindableProperty.Create("IsBackButtonEnabled", typeof(bool), typeof(DtNavigationView), false);
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

        public static readonly BindableProperty CompactModeThresholdWidthProperty = BindableProperty.Create("CompactModeThresholdWidth", typeof(double), typeof(DtNavigationView), 641.0);
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
        public static readonly BindableProperty CompactPaneLengthProperty = BindableProperty.Create("CompactPaneLength", typeof(double), typeof(DtNavigationView), 48.0);
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

        public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtNavigationView));
        public object Content
        {
            get { return (View)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly BindableProperty DisplayModeProperty = BindableProperty.Create("DisplayMode", typeof(ViewDisplayMode), typeof(DtNavigationView), ViewDisplayMode.Minimal);
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
        public static readonly BindableProperty ExpandedModeThresholdWidthProperty = BindableProperty.Create("ExpandedModeThresholdWidth", typeof(double), typeof(DtNavigationView), 1008.0);
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
        public static readonly BindableProperty FooterMenuItemsProperty = BindableProperty.Create("FooterMenuItems", typeof(List<object>), typeof(DtNavigationView));
        public List<object> FooterMenuItems
        {
            get
            {
                return (List<object>)GetValue(FooterMenuItemsProperty);
            }
            set
            {

            }
        }

        public static readonly BindableProperty FooterMenuItemsSourceProperty = BindableProperty.Create("FooterMenuItemsSource", typeof(object), typeof(DtNavigationView));
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

        public static readonly BindableProperty IsPaneOpenProperty = BindableProperty.Create("IsPaneOpen", typeof(bool), typeof(DtNavigationView), true);
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
        public static readonly BindableProperty IsPaneToggleButtonVisibleProperty = BindableProperty.Create("IsPaneToggleButtonVisible", typeof(bool), typeof(DtNavigationView), true);
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

        public static readonly BindableProperty IsSettingsVisibleProperty = BindableProperty.Create("IsSettingsVisible", typeof(bool), typeof(DtNavigationView), true);
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
        public static readonly BindableProperty IsTitleBarAutoPaddingEnabledProperty = BindableProperty.Create("IsTitleBarAutoPaddingEnabled", typeof(bool), typeof(DtNavigationView), true);
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
        public static readonly BindableProperty MenuItemContainerStyleProperty = BindableProperty.Create("MenuItemContainerStyle", typeof(Style), typeof(DtNavigationView));
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

        public static readonly BindableProperty MenuItemsProperty = BindableProperty.Create("MenuItems", typeof(IList<object>), typeof(DtNavigationView),null,BindingMode.TwoWay);
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

        public static readonly BindableProperty MenuItemsSourceProperty = BindableProperty.Create("MenuItemsSource", typeof(object), typeof(DtNavigationView));
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

        public static readonly BindableProperty OpenPaneLengthProperty = BindableProperty.Create("OpenPaneLength", typeof(double), typeof(DtNavigationView), 320.0);
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

        public static readonly BindableProperty OverflowLabelModeProperty = BindableProperty.Create("OverflowLabelMode", typeof(ViewOverflowLabelMode), typeof(DtNavigationView), ViewOverflowLabelMode.MoreLabel);
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
        public static readonly BindableProperty PaneDisplayModeProperty = BindableProperty.Create("PaneDisplayMode", typeof(ViewPaneDisplayMode), typeof(DtNavigationView), ViewPaneDisplayMode.Auto);
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

        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(DtNavigationView));
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

        public Thickness Padding
        {
            get;
            set;
        }

#nullable enable
        object? IContentView.Content => Content;

        IView? IContentView.PresentedContent => (View)Content;
#nullable disable
        #endregion
    }
}
