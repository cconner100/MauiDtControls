#if ANDROID
namespace DtControls.Handlers
{
    using Android.Widget;

    using DtControls.Controls;
    using Microsoft.Maui.Handlers;
    using System;

    using static Google.Android.Material.Tabs.TabLayout;

    public partial class DtWindowTabsHandler : ViewHandler<DtWindowTabs, Android.Widget.ImageView>, IDtWindowTabsHandler
    {
        IDtWindowTabs IDtWindowTabsHandler.VirtualView { get; }

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

        public void GetItemsCollection()
        {
            throw new NotImplementedException();
        }

        protected override ImageView CreatePlatformView()
        {
            throw new NotImplementedException();
        }
    }

}
#endif
