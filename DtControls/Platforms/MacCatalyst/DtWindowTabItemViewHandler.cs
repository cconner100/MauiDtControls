#if MACCATALYST
namespace DtControls.Handlers;

using System;

using DtControls.UserControls;

using Microsoft.Maui.Handlers;

using UIKit;

public partial class DtWindowTabItemViewHandler : ViewHandler<DtWindowTabItemView, UIView>, IDtWindowTabItemViewHandler
{

    IDtWindowTabItemView IDtWindowTabItemViewHandler.VirtualView => VirtualView;
    
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
    public static void MapHeader(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>

    public static void MapIconSource(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsClosable(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapContent(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapPlatformObject(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
    {
        throw new NotImplementedException();
    }
#endregion
}
#endif
