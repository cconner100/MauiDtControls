#if ANDROID
namespace DtControls.Handlers
{

    using System;

    using DtControls.UserControls;

    using Microsoft.Maui.Handlers;

    public partial class DtWindowTabItemViewHandler : ViewHandler<IDtWindowTabItemView, Android.Views.View>, IDtWindowTabItemViewHandler
    {

        IDtWindowTabItemView IDtWindowTabItemViewHandler.VirtualView => VirtualView;
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
        public static void MapHeader(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIconSource(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapIsClosable(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapContent(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapPlatformObject(IDtWindowTabItemViewHandler viewHandler, IDtWindowTabItemView virtualView)
        {
            throw new NotImplementedException();
        }
    #endregion
    }
}
#endif