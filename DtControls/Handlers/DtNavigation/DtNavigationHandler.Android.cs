#if ANDROID
namespace DtControls.Handlers;

using System;

using DtControls.Models;
using DtControls.Controls;

using Google.Android.Material.Navigation;

using Microsoft.Maui.Handlers;
public partial class DtNavigationHandler : ViewHandler<IDtNavigation, Android.Views.View>, IElementHandler
{
    protected override Android.Views.View CreatePlatformView()
    {
        throw new NotImplementedException();
    }
    #region Events

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_ItemInvoked(NavigationView sender, DtNavigationSelectionChangedEventArgs args)
    {
        var narg = new DtNavigationItemInvokedEventArgs();
        VirtualView?.WinItemInvoked(sender, narg);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_SelectionChanged(NavigationView sender, DtNavigationSelectionChangedEventArgs args)
    {
        VirtualView?.WinSelectionChanged(sender, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void PlatformView_Expanding(NavigationView sender, DtNavigationItemExpandingEventArgs args)
    {
        VirtualView?.WinExpanding(sender, args);
    }
    #endregion

    #region Properties
    public static void MapContent(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapAutoSuggestBox(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapAlwaysShowHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapIsBackButtonVisable(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapBackButtonEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapCompactModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapCompactPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapExpandedModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapFooterMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapFooterMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapHeaderTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapIsPaneOpen(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapIsPaneToggleButtonVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapIsSettingsVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapMenuItemContainerStyle(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapMenuItemsTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapOpenPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapPaneDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapOverflowLabelMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapSelectedItem(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        throw new NotImplementedException();
    }
    #endregion
}
#endif
