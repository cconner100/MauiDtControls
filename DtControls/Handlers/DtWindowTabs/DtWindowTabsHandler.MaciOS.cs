#if MACCATALYST || IOS
namespace DtControls.Handlers
{
    using DtControls.Controls;
    using Microsoft.Maui.Controls.PlatformConfiguration;
    using Microsoft.Maui.Handlers;

    using System;
    using UIKit;

    public partial class DtWindowTabsHandler : ViewHandler<DtWindowTabs, UIView>, IDtWindowTabsHandler
    {
        IDtWindowTabs IDtWindowTabsHandler.VirtualView { get; }

        protected override UIView CreatePlatformView()
        {
            throw new NotImplementedException();
        }

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
    }
}
#endif
