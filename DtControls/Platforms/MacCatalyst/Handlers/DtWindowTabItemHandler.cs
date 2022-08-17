#if MACCATALYST
namespace DtControls.Handlers;

using System;

using DtControls.UserControls;

using Microsoft.Maui.Handlers;

using UIKit;

public partial class DtWindowTabItemHandler : ViewHandler<DtWindowTabItem, UIView>, IDtWindowTabItemHandler
{

    IDtWindowTabItem IDtWindowTabItemHandler.VirtualView => VirtualView;
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    protected override UIView CreatePlatformView()
    {
        throw new NotImplementedException();
    }

#region Events
    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void ConnectHandler(UIKit.UIView platformView)
    {
        base.ConnectHandler(platformView);
        //platformView.CloseRequested += PlatformView_CloseRequested;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void DisconnectHandler(UIKit.UIView platformView)
    {
        base.DisconnectHandler(platformView);
        //platformView.CloseRequested -= PlatformView_CloseRequested;
    }
#endregion

#region PropertyMaps

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapHeader(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>

    public static void MapIconSource(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsClosable(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapContent(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapPlatformObject(IDtWindowTabItemHandler viewHandler, IDtWindowTabItem virtualView)
    {
        throw new NotImplementedException();
    }
#endregion
}
#endif
