#if WINDOWS

namespace DtControls.Handlers;

using DtControls.Models;
using DtControls.UserControls;

using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Controls;

public partial class DtWindowTabItemHandler : ViewHandler<DtWindowTabItem, TabViewItem>, IDtWindowTabItemHandler
{
    private TabViewItem _tabViewItem = new TabViewItem();

    /// <summary>
    /// 
    /// </summary>
    IDtWindowTabItem IDtWindowTabItemHandler.VirtualView => VirtualView;


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override TabViewItem CreatePlatformView()
    {
        return _tabViewItem;
    }

#region Events

    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void ConnectHandler(TabViewItem platformView)
    {
        base.ConnectHandler(platformView);
        platformView.CloseRequested += PlatformView_CloseRequested;
        PlatformView.Loading += PlatformView_Loading;
    }

    private void PlatformView_Loading(Microsoft.UI.Xaml.FrameworkElement sender, object args)
    {
        
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="platformView"></param>
    protected override void DisconnectHandler(TabViewItem platformView)
    {
        base.DisconnectHandler(platformView);
        platformView.CloseRequested -= PlatformView_CloseRequested;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="mauiContext"></param>
    public override void SetMauiContext(IMauiContext mauiContext)
    {
        DtMauiContext.mauiContext = mauiContext;
        base.SetMauiContext(mauiContext);
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void PlatformView_CloseRequested(TabViewItem sender, TabViewTabCloseRequestedEventArgs args)
    {
        throw new NotImplementedException();
    }

#endregion

#region PropertyMaps

    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <param name="virtualView"></param>
    public static void MapHeader(IDtWindowTabItemHandler handler, IDtWindowTabItem virtualView)
    {
        ((TabViewItem)(handler?.PlatformView)).Header = virtualView.Header;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <param name="virtualView"></param>
    public static void MapIconSource(IDtWindowTabItemHandler handler, IDtWindowTabItem virtualView)
    {
        ((TabViewItem)(handler?.PlatformView)).IconSource = (IconSource)virtualView.IconSource;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <param name="virtualView"></param>
    public static void MapIsClosable(IDtWindowTabItemHandler handler, IDtWindowTabItem virtualView)
    {
        ((TabViewItem)(handler?.PlatformView)).IsClosable = virtualView.IsClosable;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public static void MapContent(IDtWindowTabItemHandler handler, IDtWindowTabItem virtualView)
    {
        _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
        _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
        _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");


        if (handler.VirtualView.PresentedContent is IView view)
        {
            handler.PlatformView.Content = view.ToPlatform(handler.MauiContext);
        }

    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public static void MapPlatformObject(IDtWindowTabItemHandler handler, IDtWindowTabItem virtualView)
    {
        _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
        _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
        _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");


        if (handler.VirtualView.PresentedContent is IView view)
        {
            var frame = new Frame();
            frame.Content = view.ToPlatform(handler.MauiContext);
            virtualView.PlatformObject = frame;
        }

    }
#endregion
}
#endif
