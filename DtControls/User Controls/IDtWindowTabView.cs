
namespace DtControls.UserControls;

using System;
using System.Collections.ObjectModel;

using static DtControls.UserControls.DtWindowTabView;

/// <summary>
/// 
/// </summary>
public interface IDtWindowTabView : IView
{
    #region Events
    /// <summary>
    /// 
    /// </summary>
    event EventHandler AddTabButtonClick;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler SelectionChanged;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler TabCloseRequested;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler TabDragCompleted;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler TabDragStarting;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler TabDroppedOutSide;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler TabItemsChanged;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler TabStripDragOver;

    /// <summary>
    /// 
    /// </summary>
    event EventHandler TabStripDrop;


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinLoaded(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinAddTabButtonClick(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinSelectionChanged(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinTabCloseRequested(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinTabDragCompleted(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinTabDragStarting(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinTabDroppedOutSide(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinTabItemsChanged(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinTabStripDragOver(object sender, object args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinTabStripDrop(object sender, object args);

    /// <summary>
    /// 
    /// </summary>      
    object AddTabButtonCommand { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object AddTabButtonCommandParameter { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool AllowDropTabs { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool CanDragTabs { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool CanReorderTabs { get; set; }
    #endregion

    #region Properties

    /// <summary>
    /// 
    /// </summary>
    CloseButtonOverlayModeEnum CloseButtonOverlayMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool IsAddTabButtonVisible { get; set; }

    /// <summary>
    /// 
    /// </summary>
    int SelectedIndex { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object SelectedItem { get; set; }

    /// <summary>
    /// 
    /// </summary>
    ObservableCollection<DtWindowTabItem> TabItems { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object TabItemsSource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object TabStripFooter { get; set; }

    /// <summary>
    /// 
    /// </summary>
    TabWidthModeEnum TabWidthMode { get; set; }
    #endregion
}
