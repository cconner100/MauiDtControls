namespace DtControls.Handlers
{
    using System;

    using DtControls.UserControls;

    using Microsoft.Maui.Handlers;

    public partial class DtWindowTabItemViewHandler : ViewHandler<DtWindowTabItemView, UIKit.UIView>, IDtWindowTabItemViewHandler
    {

        IDtWindowTabItemView IDtWindowTabItemViewHandler.VirtualView => VirtualView;
        protected override UIKit.UIView CreatePlatformView()
        {
            throw new NotImplementedException();
        }

        #region Events
        protected override void ConnectHandler(UIKit.UIView platformView)
        {
            base.ConnectHandler(platformView);
            //platformView.CloseRequested += PlatformView_CloseRequested;
        }

        protected override void DisconnectHandler(UIKit.UIView platformView)
        {
            base.DisconnectHandler(platformView);
            //platformView.CloseRequested -= PlatformView_CloseRequested;
        }
        #endregion

        #region PropertyMaps
        public static void MapHeader(IDtWindowTabItemViewHandler handler, IDtWindowTabItemViewHandler virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIconSource(IDtWindowTabItemViewHandler handler, IDtWindowTabItemViewHandler virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIsClosable(IDtWindowTabItemViewHandler handler, IDtWindowTabItemViewHandler virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapContent(IDtWindowTabItemViewHandler handler, IDtWindowTabItemViewHandler virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapPlatformObject(IDtWindowTabItemViewHandler handler, IDtWindowTabItemViewHandler virtualView)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

