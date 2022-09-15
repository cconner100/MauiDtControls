
namespace DtControls.Controls;

using System;
using System.Collections.ObjectModel;

using static DtControls.Controls.DtWindowTabs;


public interface IDtWindowTabs : IView
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

    void HandleLoaded(object sender, object args);

    void HandleAddTabButtonClick(object sender, object args);

    void HandleSelectionChanged(object sender, object args);

    void HandleTabCloseRequested(object sender, object args);

    void HandleTabDragCompleted(object sender, object args);

    void HandleTabDragStarting(object sender, object args);

    void HandleTabDroppedOutSide(object sender, object args);

    void HandleTabItemsChanged(object sender, object args);

    void HandleTabStripDragOver(object sender, object args);

    void HandleTabStripDrop(object sender, object args);
 
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

