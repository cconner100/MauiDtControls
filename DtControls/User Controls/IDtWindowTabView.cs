
namespace DtControls.UserControls
{
    using System;
    using System.Collections.Generic;

    using static DtControls.UserControls.DtWindowTabView;

    public interface IDtWindowTabView : IView
    {
        #region Events
        event EventHandler AddTabButtonClick;
        event EventHandler SelectionChanged;
        event EventHandler TabCloseRequested;
        event EventHandler TabDragCompleted;
        event EventHandler TabDragStarting;
        event EventHandler TabDroppedOutSide;
        event EventHandler TabItemsChanged;
        event EventHandler TabStripDragOver;
        event EventHandler TabStripDrop;


        void WinLoaded(object sender, object args);
        void WinAddTabButtonClick(object sender, object args);
        void WinSelectionChanged(object sender, object args);
        void WinTabCloseRequested(object sender, object args);
        void WinTabDragCompleted(object sender, object args);
        void WinTabDragStarting(object sender, object args);
        void WinTabDroppedOutSide(object sender, object args);
        void WinTabItemsChanged(object sender, object args);
        void WinTabStripDragOver(object sender, object args);
        void WinTabStripDrop(object sender, object args);
        
        object AddTabButtonCommand { get; set; }
        object AddTabButtonCommandParameter { get; set; }
        bool AllowDropTabs { get; set; }
        bool CanDragTabs { get; set; }
        bool CanReorderTabs { get; set; }
        #endregion

        #region Properties
        CloseButtonOverlayModeEnum CloseButtonOverlayMode { get; set; }
        bool IsAddTabButtonVisible { get; set; }
        int SelectedIndex { get; set; }
        object SelectedItem { get; set; }
        IList<object> TabItems { get; set; }
        object TabItemsSource { get; set; }
        object TabStripFooter { get; set; }
        TabWidthModeEnum TabWidthMode { get; set; }
        #endregion
    }
}
