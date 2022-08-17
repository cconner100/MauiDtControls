#if ANDROID
namespace DtControls.Handlers;

using System;

using DtControls.UserControls;

using Microsoft.Maui.Handlers;

public partial class DtWindowTabItemHandler : ViewHandler<DtWindowTabItem, Android.Views.View>, IDtWindowTabItemHandler
{

    IDtWindowTabItem IDtWindowTabItemHandler.VirtualView => VirtualView;
    protected override Android.Views.View CreatePlatformView()
    {
        throw new NotImplementedException();
    }

#region Events
    protected override void ConnectHandler(Android.Views.View platformView)
    {
        base.ConnectHandler(platformView);
        //platformView.CloseRequested += PlatformView_CloseRequested;
    }

    protected override void DisconnectHandler(Android.Views.View platformView)
    {
        base.DisconnectHandler(platformView);
        //platformView.CloseRequested -= PlatformView_CloseRequested;
    }


#endregion

#region PropertyMaps
    public static void MapHeader(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapIconSource(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapIsClosable(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }

    public static void MapContent(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
    public static void MapPlatformObject(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
#endregion
}
#endif