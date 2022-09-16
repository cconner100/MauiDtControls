
namespace DtControls.Controls;

using DtControls.Models;

using System;
using System.Collections.ObjectModel;

using static DtControls.Controls.DtWindowTabs;
using static DtControls.Models.DtWindowTabsDragEventArgs;

public interface IDtWindowTabs : IView
{
    #region Events

    event EventHandler AddTabButtonClick;

 
    event EventHandler<DtWindowTabsSelectionChangedEventArgs> SelectionChanged;

    event EventHandler<DtWindowTabItemCloseRequestEventArgs> TabCloseRequested;

    event EventHandler<DtWindowTabsItemDragCompletedEventArgs> TabDragCompleted;

    event EventHandler<DtWindowTabsDragStartingEventArgs> TabDragStarting;

    event EventHandler<DtWindowTabsDroppedOutsideEventArgs> TabDroppedOutSide;

    event EventHandler<DtWindowTabsItemsChangedEventArgs> TabItemsChanged;

    event EventHandler<DtWindowTabsStripDragOverEventArgs> TabStripDragOver;

    event EventHandler<DtWindowTabsStripDropEventArgs> TabStripDrop;

    void HandleLoaded(object sender, object args);

    void HandleAddTabButtonClick(object sender, object args);

    void HandleSelectionChanged(object sender, DtWindowTabsSelectionChangedEventArgs args);

    void HandleTabCloseRequested(object sender, DtWindowTabItemCloseRequestEventArgs args);

    void HandleTabDragCompleted(object sender, DtWindowTabsItemDragCompletedEventArgs args);

    void HandleTabDragStarting(object sender, DtWindowTabsDragStartingEventArgs args);

    void HandleTabDroppedOutSide(object sender, DtWindowTabsDroppedOutsideEventArgs args);

    void HandleTabItemsChanged(object sender, DtWindowTabsItemsChangedEventArgs args);

    void HandleTabStripDragOver(object sender, DtWindowTabsStripDragOverEventArgs args);

    void HandleTabStripDrop(object sender, DtWindowTabsStripDropEventArgs args);
 
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

    ObservableCollection<DtWindowTabItem> TabItems { get; set; }

    object TabItemsSource { get; set; }

    object TabStripFooter { get; set; }

    TabWidthModeEnum TabWidthMode { get; set; }
    #endregion
}

