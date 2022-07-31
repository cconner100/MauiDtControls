namespace DtControls.UserControls
{

    using System.Collections.Generic;

    using static DtControls.UserControls.DtNavigationView;

    public interface IDtNavigationView : IContentView
    {

        #region Events
        event EventHandler BackRequested;
        event EventHandler Collapsed;
        event EventHandler DisplayModeChanged;
        event EventHandler Expanding;
        event EventHandler ItemInvoked;
        event EventHandler PaneClosed;
        event EventHandler PaneClosing;
        event EventHandler PaneOpened;
        event EventHandler PaneOpening;
        event EventHandler SelectionChanged;
        #endregion
        void WinBackRequested(object sender, object args);
        void WinCollapsed(object sender, object args);
        void WinDisplayModeChanged(object sender, object args);
        void WinExpanding(object sender, object args);
        void WinItemInvoked(object sender, object args);
        void WinPaneClosed(object sender, object args);
        void WinPaneClosing(object sender, object args);
        void WinPaneOpened(object sender, object args);
        void WinPaneOpening(object sender, object args);
        void WinSelectionChanged(object sender, object args);
        
        #region Properties

        string Header { get; set; }
        bool AlwaysShowHeader { get; set; }

        BackButtonVisable IsBackButtonVisable { get; set; }
        bool IsBackButtonEnabled { get; set; }
        double CompactModeThresholdWidth { get; set; }
        double CompactPaneLength { get; set; }
        ViewDisplayMode DisplayMode { get; set; }
        double ExpandedModeThresholdWidth { get; set; }
        List<object> FooterMenuItems { get; }
        object FooterMenuItemsSource { get; set; }
        DataTemplate HeaderTemplate { get; set; }
        bool IsPaneOpen { get; set; }
        bool IsPaneToggleButtonVisible { get; set; }
        bool IsSettingsVisible { get; set; }
        bool IsTitleBarAutoPaddingEnabled { get; set; }
        Style MenuItemContainerStyle { get; set; }
        IList<object> MenuItems { get; set; }
        object MenuItemsSource { get; set; }
        DataTemplate MenuItemsTemplate { get; set; }
        double OpenPaneLength { get; set; }
        ViewOverflowLabelMode OverflowLabelMode { get; set; }
        ViewPaneDisplayMode PaneDisplayMode { get; set; }
        object SelectedItem { get; set; }
        #endregion
    }
}
