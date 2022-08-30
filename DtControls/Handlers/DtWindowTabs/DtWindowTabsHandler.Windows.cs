#if WINDOWS
namespace DtControls.Handlers
{
    using DtControls.Controls;
    using DtControls.Models;

    using Microsoft.Maui.Handlers;
    using Microsoft.UI.Xaml.Controls;

    using System.Collections.ObjectModel;
    using System.Windows.Input;


    public partial class DtWindowTabsHandler : ViewHandler<DtWindowTabs, TabView>, IDtWindowTabsHandler
    {
        TabView _tabView = new TabView();
        IDtWindowTabs IDtWindowTabsHandler.VirtualView => VirtualView;

        ObservableCollection<DtWindowTabItem> dtWindowTabItemViews { get; set; } = new ObservableCollection<DtWindowTabItem>();


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override TabView CreatePlatformView()
        {
            return _tabView;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="platformView"></param>
        protected override void ConnectHandler(TabView platformView)
        {
            _tabView.HorizontalAlignment = Microsoft.UI.Xaml.HorizontalAlignment.Stretch;
            _tabView.VerticalAlignment = Microsoft.UI.Xaml.VerticalAlignment.Stretch;
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

            dtWindowTabItemViews.CollectionChanged += DtWindowTabItemViews_CollectionChanged;
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

            dtWindowTabItemViews.CollectionChanged -= DtWindowTabItemViews_CollectionChanged;
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
        /// <param name="e"></param>
        private void PlatformView_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            VirtualView.WinLoaded(this.VirtualView, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformView_TabStripDrop(object sender, Microsoft.UI.Xaml.DragEventArgs e)
        {
            VirtualView.WinTabStripDrop(this.VirtualView, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformView_TabStripDragOver(object sender, Microsoft.UI.Xaml.DragEventArgs e)
        {
            VirtualView.WinTabStripDragOver(this.VirtualView, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabItemsChanged(TabView sender, Windows.Foundation.Collections.IVectorChangedEventArgs args)
        {
            VirtualView.WinTabItemsChanged(this.VirtualView, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabDroppedOutside(TabView sender, TabViewTabDroppedOutsideEventArgs args)
        {
            VirtualView.WinTabDroppedOutSide(this.VirtualView, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabDragStarting(TabView sender, TabViewTabDragStartingEventArgs args)
        {
            VirtualView.WinTabDragStarting(this.VirtualView, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabDragCompleted(TabView sender, TabViewTabDragCompletedEventArgs args)
        {
            VirtualView.WinTabDragCompleted(this.VirtualView, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            VirtualView.WinTabCloseRequested(this.VirtualView, args);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VirtualView.WinSelectionChanged(this.VirtualView, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_AddTabButtonClick(TabView sender, object args)
        {
            VirtualView.WinAddTabButtonClick(this.VirtualView, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapAddTabButtonCommand(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AddTabButtonCommand = (ICommand)virtualView.AddTabButtonCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapAddTabButtonCommandParameter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AddTabButtonCommandParameter = virtualView.AddTabButtonCommandParameter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapAllowDropTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AllowDropTabs = virtualView.AllowDropTabs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCanDragTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).CanDragTabs = virtualView.CanDragTabs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCanReorderTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).CanReorderTabs = virtualView.CanReorderTabs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCloseButtonOverlayMode(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            TabViewCloseButtonOverlayMode mode = TabViewCloseButtonOverlayMode.Always;
            switch (virtualView.CloseButtonOverlayMode)
            {
                case DtWindowTabs.CloseButtonOverlayModeEnum.Auto:
                    mode = TabViewCloseButtonOverlayMode.Auto;
                    break;
                case DtWindowTabs.CloseButtonOverlayModeEnum.Always:
                    mode = TabViewCloseButtonOverlayMode.Always;
                    break;
                case DtWindowTabs.CloseButtonOverlayModeEnum.OnPointerOver:
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
        public static void MapIsAddTabButtonVisible(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).IsAddTabButtonVisible = virtualView.IsAddTabButtonVisible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapSelectedIndex(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).SelectedIndex = virtualView.SelectedIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapSelectedItem(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).SelectedItem = virtualView.SelectedItem;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabItems(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            viewHandler.GetItemsCollection();
        }

        private void DtWindowTabItemViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                if (e.NewItems != null)
                {
                    foreach (var item in e.NewItems)
                    {
                        if (item is DtWindowTabItem tvi)
                        {

                            _tabView.TabItems.Add(tvi.GetTabViewItem());
                            _tabView.SelectedIndex = _tabView.TabItems.Count - 1;
                        }
                    }
                }
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                if (sender is DtWindowTabItem t)
                {
                    _tabView.TabItems.Remove(t);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabItemsSource(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).TabItemsSource = virtualView.TabItemsSource;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabStripFooter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).TabStripFooter = virtualView.TabStripFooter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapTabWidthMode(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            TabViewWidthMode mode = TabViewWidthMode.Compact;
            switch (virtualView.TabWidthMode)
            {
                case DtWindowTabs.TabWidthModeEnum.Compact:
                    mode = TabViewWidthMode.Compact;
                    break;
                case DtWindowTabs.TabWidthModeEnum.SizeToContent:
                    mode = TabViewWidthMode.SizeToContent;
                    break;
                case DtWindowTabs.TabWidthModeEnum.Equal:
                    mode = TabViewWidthMode.Equal;
                    break;
            }
            ((TabView)(viewHandler?.PlatformView)).TabWidthMode = mode;
        }

        void IDtWindowTabsHandler.GetItemsCollection()
        {
            VirtualView.TabItems = dtWindowTabItemViews;
        }
    }
}
#endif
