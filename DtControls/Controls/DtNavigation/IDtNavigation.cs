namespace DtControls.Controls;

using DtControls.Models;

using System.Collections.Generic;

using static DtControls.Controls.DtNavigation;

public interface IDtNavigation : IContentView
{

    #region Events

    event EventHandler BackRequested;

    event EventHandler<DtNavigationItemCollapsedEventArgs> Collapsed;

    event EventHandler DisplayModeChanged;

    event EventHandler<DtNavigationItemExpandingEventArgs> Expanding;

    event EventHandler<DtNavigationItemInvokedEventArgs> ItemInvoked;

    event EventHandler PaneClosed;

    event EventHandler PaneClosing;

    event EventHandler PaneOpened;

    event EventHandler PaneOpening;

    event EventHandler<DtNavigationSelectionChangedEventArgs> SelectionChanged;
    #endregion

    void HandleBackRequested(object sender, object args);

    void HandleCollapsed(object sender, DtNavigationItemCollapsedEventArgs args);

    void HandleDisplayModeChanged(object sender, object args);

    void HandleExpanding(object sender, DtNavigationItemExpandingEventArgs args);

    void HandleItemInvoked(object sender, DtNavigationItemInvokedEventArgs args);

    void HandlePaneClosed(object sender, object args);

    void HandlePaneClosing(object sender, object args);

    void HandlePaneOpened(object sender, object args);

    void WinPaneOpening(object sender, object args);

    void HandleSelectionChanged(object sender, DtNavigationSelectionChangedEventArgs args);

    #region Properties

    string Header { get; set; }

    bool AlwaysShowHeader { get; set; }

    public SearchBar AutoSuggestBox { get; set; }

    BackButtonVisable IsBackButtonVisable { get; set; }

    bool IsBackButtonEnabled { get; set; }

    double CompactModeThresholdWidth { get; set; }

    double CompactPaneLength { get; set; }

    ViewDisplayMode DisplayMode { get; set; }

    double ExpandedModeThresholdWidth { get; set; }

    IList<DtMenuItem> FooterMenuItems { get; set; }

    object FooterMenuItemsSource { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    bool IsPaneOpen { get; set; }

    bool IsPaneToggleButtonVisible { get; set; }

    bool IsSettingsVisible { get; set; }

    bool IsTitleBarAutoPaddingEnabled { get; set; }

    Style MenuItemContainerStyle { get; set; }

    IList<DtMenuItem> MenuItems { get; set; }

    object MenuItemsSource { get; set; }

    DataTemplate MenuItemsTemplate { get; set; }

    double OpenPaneLength { get; set; }

    ViewOverflowLabelMode OverflowLabelMode { get; set; }

    ViewPaneDisplayMode PaneDisplayMode { get; set; }

    DtMenuItem SelectedItem { get; set; }
    #endregion
}

