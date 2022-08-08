#if ANDROID
namespace DtControls.Handlers
{
    using System;
    using System.Windows.Input;

    using DtControls.UserControls;

    using Microsoft.Maui.Handlers;

    using static Google.Android.Material.Tabs.TabLayout;

    public partial class DtWindowTabViewHandler : ViewHandler<IDtWindowTabView, Android.Widget.ImageView>, IElementHandler
    {
        protected override Android.Widget.ImageView CreatePlatformView()
        {
            throw new NotImplementedException();
        }


#region Properties
        public static void MapAddTabButtonCommand(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapAddTabButtonCommandParameter(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapAllowDropTabs(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCanDragTabs(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCanReorderTabs(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCloseButtonOverlayMode(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsAddTabButtonVisible(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapSelectedIndex(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabItems(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabItemsSource(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabStripFooter(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapTabWidthMode(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapSelectedItem(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            throw new NotImplementedException();
        }

    }
#endregion
}
#endif

