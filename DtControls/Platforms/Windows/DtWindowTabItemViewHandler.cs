#if WINDOWS

namespace DtControls.Handlers
{
    using DtControls.UserControls;

    using Microsoft.Maui;
    using Microsoft.Maui.Handlers;
    using Microsoft.Maui.Platform;
    using Microsoft.UI.Xaml.Controls;

    public partial class DtWindowTabItemViewHandler : ViewHandler<DtWindowTabItemView, TabViewItem>, IDtWindowTabItemViewHandler
    {
        private TabViewItem _tabViewItem = new TabViewItem();

        /// <summary>
        /// 
        /// </summary>
        IDtWindowTabItemView IDtWindowTabItemViewHandler.VirtualView => VirtualView;


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
        public static void MapHeader(IDtWindowTabItemViewHandler handler, IDtWindowTabItemView virtualView)
        {
            ((TabViewItem)(handler?.PlatformView)).Header = virtualView.Header;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="virtualView"></param>
        public static void MapIconSource(IDtWindowTabItemViewHandler handler, IDtWindowTabItemView virtualView)
        {
            ((TabViewItem)(handler?.PlatformView)).IconSource = (IconSource)virtualView.IconSource;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="virtualView"></param>
        public static void MapIsClosable(IDtWindowTabItemViewHandler handler, IDtWindowTabItemView virtualView)
        {
            ((TabViewItem)(handler?.PlatformView)).IsClosable = virtualView.IsClosable;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void MapContent(IDtWindowTabItemViewHandler handler, IDtWindowTabItemView virtualView)
        {
            _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
            _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
            _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

#if WINDOWS
            if (handler.VirtualView.PresentedContent is IView view)
                handler.PlatformView.Content = view.ToPlatform(handler.MauiContext);
#endif
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void MapPlatformObject(IDtWindowTabItemViewHandler handler, IDtWindowTabItemView virtualView)
        {
            _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
            _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
            _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

#if WINDOWS
            if (handler.VirtualView.PresentedContent is IView view)
                virtualView.PlatformObject = view.ToPlatform(handler.MauiContext);
#endif
        }
#endregion
    }
}
#endif
