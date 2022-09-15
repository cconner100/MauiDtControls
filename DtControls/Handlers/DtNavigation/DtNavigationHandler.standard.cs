#if NET6_0 && !ANDROID && !MACCATALYST && !WINDOWS
namespace DtControls.Handlers;

using DtControls.Controls;

using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

using System;

public partial class DtNavigationHandler : ViewHandler<IDtNavigation, object>
{
    protected override object CreatePlatformView()
    {
        throw new NotImplementedException();
    }

    #region Properties
    public static void MapContent(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
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

    public static void MapAutoSuggestBox(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.AutoSuggestBox != null)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
#endif

