namespace DtControls.Controls;

using DtControls.Models;

using System.Collections.Generic;

using static DtControls.Controls.DtNavigation;

/// <summary>
/// 
/// </summary>
public interface IDtNavigation : IContentView
{

    #region Events
    /// <summary>
    /// 
    /// </summary>
    event EventHandler BackRequested;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler<DtNavigationItemCollapsedEventArgs> Collapsed;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler DisplayModeChanged;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler<DtNavigationItemExpandingEventArgs> Expanding;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler<DtNavigationItemInvokedEventArgs> ItemInvoked;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler PaneClosed;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler PaneClosing;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler PaneOpened;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler PaneOpening;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler<DtNavigationSelectionChangedEventArgs> SelectionChanged;
    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinBackRequested(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinCollapsed(object sender, DtNavigationItemCollapsedEventArgs args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinDisplayModeChanged(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinExpanding(object sender, DtNavigationItemExpandingEventArgs args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinItemInvoked(object sender, DtNavigationItemInvokedEventArgs args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinPaneClosed(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinPaneClosing(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinPaneOpened(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinPaneOpening(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinSelectionChanged(object sender, DtNavigationSelectionChangedEventArgs args);

    #region Properties

    /// <summary>
    /// 
    /// </summary>
    string Header { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool AlwaysShowHeader { get; set; }

    /// <summary>
    /// Autosuggest box from maui
    /// </summary>
    public SearchBar AutoSuggestBox { get; set; }

    /// <summary>
    /// 
    /// </summary>
    BackButtonVisable IsBackButtonVisable { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool IsBackButtonEnabled { get; set; }

    /// <summary>
    /// 
    /// </summary>
    double CompactModeThresholdWidth { get; set; }

    /// <summary>
    /// 
    /// </summary>
    double CompactPaneLength { get; set; }

    /// <summary>
    /// 
    /// </summary>
    ViewDisplayMode DisplayMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    double ExpandedModeThresholdWidth { get; set; }

    /// <summary>
    /// 
    /// </summary>
    IList<object> FooterMenuItems { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object FooterMenuItemsSource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    DataTemplate HeaderTemplate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool IsPaneOpen { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool IsPaneToggleButtonVisible { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool IsSettingsVisible { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool IsTitleBarAutoPaddingEnabled { get; set; }

    /// <summary>
    /// 
    /// </summary>
    Style MenuItemContainerStyle { get; set; }

    /// <summary>
    /// 
    /// </summary>
    IList<object> MenuItems { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object MenuItemsSource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    DataTemplate MenuItemsTemplate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    double OpenPaneLength { get; set; }

    /// <summary>
    /// 
    /// </summary>
    ViewOverflowLabelMode OverflowLabelMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    ViewPaneDisplayMode PaneDisplayMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object SelectedItem { get; set; }
    #endregion
}

