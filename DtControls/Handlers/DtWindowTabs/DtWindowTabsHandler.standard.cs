#if NET6_0 && !ANDROID && !IOS && !MACCATALYST && !WINDOWS
namespace DtControls.Handlers;

using System;

using DtControls.Controls;

using Microsoft.Maui.Handlers;

public partial class DtWindowTabsHandler : ViewHandler<IDtWindowTabs, object>, IElementHandler
{

    protected override object CreatePlatformView()
    {
        throw new NotImplementedException();
    }
#region Properties

    public static void MapAddTabButtonCommand(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapAddTabButtonCommandParameter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapAllowDropTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapCanDragTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }
 
    public static void MapCanReorderTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }
 
    public static void MapCloseButtonOverlayMode(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapIsAddTabButtonVisible(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapSelectedIndex(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapTabItems(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }
 
    public static void MapTabItemsSource(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapTabStripFooter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapTabWidthMode(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapSelectedItem(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        throw new NotImplementedException();
    }
}
#endregion
#endif
