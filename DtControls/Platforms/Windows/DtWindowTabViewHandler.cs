#if WINDOWS
namespace DtControls.Handlers
{

    using System.Windows.Input;

    using DtControls.UserControls;

    using Microsoft.Maui.Handlers;
    using Microsoft.UI.Xaml.Controls;

    public partial class DtWindowTabViewHandler : ViewHandler<DtWindowTabView, TabView>, IDtWindowTabViewHandler
    {
        private TabView _tabView = new TabView();

        IDtWindowTabView IDtWindowTabViewHandler.VirtualView => VirtualView;


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override TabView CreatePlatformView()
        {         
            return _tabView;
        }

        #region Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="platformView"></param>
        protected override void ConnectHandler(TabView platformView)
        {
            base.ConnectHandler(platformView);
            platformView.Loaded += PlatformView_Loaded;
            platformView.AddTabButtonClick += PlatformView_AddTabButtonClick;
            platformView.SelectionChanged += PlatformView_SelectionChanged;
            platformView.TabCloseRequested += PlatformView_TabCloseRequested;
            platformView.TabDragCompleted += PlatformView_TabDragCompleted;
            platformView.TabDragStarting += PlatformView_TabDragStarting;
            platformView.TabDroppedOutside += PlatformView_TabDroppedOutside;
            platformView.TabItemsChanged += PlatformView_TabItemsChanged;
            platformView.TabStripDragOver += PlatformView_TabStripDragOver;
            platformView.TabStripDrop += PlatformView_TabStripDrop;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="platformView"></param>
        protected override void DisconnectHandler(TabView platformView)
        {
            base.DisconnectHandler(platformView);
            platformView.Loaded -= PlatformView_Loaded;
            platformView.AddTabButtonClick += PlatformView_AddTabButtonClick;
            platformView.SelectionChanged += PlatformView_SelectionChanged;
            platformView.TabCloseRequested += PlatformView_TabCloseRequested;
            platformView.TabDragCompleted += PlatformView_TabDragCompleted;
            platformView.TabDragStarting += PlatformView_TabDragStarting;
            platformView.TabDroppedOutside += PlatformView_TabDroppedOutside;
            platformView.TabItemsChanged += PlatformView_TabItemsChanged;
            platformView.TabStripDragOver += PlatformView_TabStripDragOver;
            platformView.TabStripDrop += PlatformView_TabStripDrop;
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
        /// <param name="e"></param>
        private void PlatformView_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            VirtualView.WinLoaded(sender, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformView_TabStripDrop(object sender, Microsoft.UI.Xaml.DragEventArgs e)
        {
            VirtualView.WinTabStripDrop(sender, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformView_TabStripDragOver(object sender, Microsoft.UI.Xaml.DragEventArgs e)
        {
            VirtualView.WinTabStripDragOver(sender, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabItemsChanged(TabView sender, Windows.Foundation.Collections.IVectorChangedEventArgs args)
        {
            VirtualView.WinTabItemsChanged(sender, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabDroppedOutside(TabView sender, TabViewTabDroppedOutsideEventArgs args)
        {
            VirtualView.WinTabDroppedOutSide(sender, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabDragStarting(TabView sender, TabViewTabDragStartingEventArgs args)
        {
            VirtualView.WinTabDragStarting(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabDragCompleted(TabView sender, TabViewTabDragCompletedEventArgs args)
        {
            VirtualView.WinTabDragCompleted(sender, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            VirtualView.WinTabCloseRequested(sender, args);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VirtualView.WinSelectionChanged(sender, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_AddTabButtonClick(TabView sender, object args)
        {
            VirtualView.WinAddTabButtonClick(sender, args);
        }
        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapAddTabButtonCommand(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AddTabButtonCommand = (ICommand)virtualView.AddTabButtonCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapAddTabButtonCommandParameter(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AddTabButtonCommandParameter = virtualView.AddTabButtonCommandParameter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapAllowDropTabs(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AllowDropTabs = virtualView.AllowDropTabs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCanDragTabs(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).CanDragTabs = virtualView.CanDragTabs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCanReorderTabs(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).CanReorderTabs = virtualView.CanReorderTabs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCloseButtonOverlayMode(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            TabViewCloseButtonOverlayMode mode = TabViewCloseButtonOverlayMode.Always;
            switch (virtualView.CloseButtonOverlayMode)
            {
                case DtWindowTabView.CloseButtonOverlayModeEnum.Auto:
                    mode = TabViewCloseButtonOverlayMode.Auto;
                    break;
                case DtWindowTabView.CloseButtonOverlayModeEnum.Always:
                    mode = TabViewCloseButtonOverlayMode.Always;
                    break;
                case DtWindowTabView.CloseButtonOverlayModeEnum.OnPointerOver:
                    mode = TabViewCloseButtonOverlayMode.OnPointerOver;
                    break;
            }
            ((TabView)(viewHandler?.PlatformView)).CloseButtonOverlayMode = mode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapIsAddTabButtonVisible(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).IsAddTabButtonVisible = virtualView.IsAddTabButtonVisible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapSelectedIndex(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).SelectedIndex = virtualView.SelectedIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapSelectedItem(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).SelectedItem = virtualView.SelectedItem;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabItems(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
             virtualView.TabItems =((TabView)(viewHandler?.PlatformView)).TabItems;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabItemsSource(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).TabItemsSource = virtualView.TabItemsSource;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabStripFooter(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).TabStripFooter = virtualView.TabStripFooter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabWidthMode(IDtWindowTabViewHandler viewHandler, IDtWindowTabView virtualView)
        {
            TabViewWidthMode mode = TabViewWidthMode.Compact;
            switch(virtualView.TabWidthMode)
            {
                case DtWindowTabView.TabWidthModeEnum.Compact:
                    mode = TabViewWidthMode.Compact;
                    break;
                case DtWindowTabView.TabWidthModeEnum.SizeToContent:
                    mode = TabViewWidthMode.SizeToContent;
                    break;
                case DtWindowTabView.TabWidthModeEnum.Equal:
                    mode = TabViewWidthMode.Equal;
                    break;
            }
            ((TabView)(viewHandler?.PlatformView)).TabWidthMode = mode;
        }

    }
    #endregion
}
#endif