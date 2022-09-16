#if WINDOWS
namespace DtControls.Handlers
{
    using DtControls.Controls;
    using DtControls.Models;

    using Microsoft.Maui.Handlers;
    using Microsoft.UI.Xaml.Controls;

    using System.Collections.ObjectModel;
    using System.Windows.Input;

    using static DtControls.Models.DtWindowTabsDragEventArgs;

    public partial class DtWindowTabsHandler : ViewHandler<DtWindowTabs, TabView>, IDtWindowTabsHandler
    {
        TabView _tabView = new TabView();
        IDtWindowTabs IDtWindowTabsHandler.VirtualView => VirtualView;

        ObservableCollection<DtWindowTabItem> dtWindowTabItemViews { get; set; } = new ObservableCollection<DtWindowTabItem>();


        protected override TabView CreatePlatformView()
        {
            return _tabView;
        }

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

        public override void SetMauiContext(IMauiContext mauiContext)
        {
            DtMauiContext.mauiContext = mauiContext;
            base.SetMauiContext(mauiContext);
        }

        void PlatformView_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            VirtualView.HandleLoaded(this.VirtualView, e);
        }

        void PlatformView_TabStripDrop(object sender, Microsoft.UI.Xaml.DragEventArgs e)
        {
            VirtualView.HandleTabStripDrop(this.VirtualView, new DtWindowTabsStripDropEventArgs(e));
        }

        void PlatformView_TabStripDragOver(object sender, Microsoft.UI.Xaml.DragEventArgs e)
        {
            VirtualView.HandleTabStripDragOver(this.VirtualView, new DtWindowTabsStripDragOverEventArgs(e));

        }


        void PlatformView_TabItemsChanged(TabView sender, Windows.Foundation.Collections.IVectorChangedEventArgs args)
        {
            VirtualView.HandleTabItemsChanged(this.VirtualView, new DtWindowTabsItemsChangedEventArgs(args));
        }

        void PlatformView_TabDroppedOutside(TabView sender, TabViewTabDroppedOutsideEventArgs args)
        {
            var dtTabItem = FindTabItemFromView(args.Tab);
            if (dtTabItem != null)
            {
                VirtualView.HandleTabDroppedOutSide(this.VirtualView, new DtWindowTabsDroppedOutsideEventArgs(dtTabItem, args));
            }
        }

        void PlatformView_TabDragStarting(TabView sender, TabViewTabDragStartingEventArgs args)
        {
            var dtTabItem = FindTabItemFromView(args.Tab);
            if (dtTabItem != null)
            {
                VirtualView.HandleTabDragStarting(this.VirtualView, new DtWindowTabsDragStartingEventArgs(dtTabItem, args));
            }
        }

        void PlatformView_TabDragCompleted(TabView sender, TabViewTabDragCompletedEventArgs args)
        {
            var dtTabItem = FindTabItemFromView(args.Tab);
            if (dtTabItem != null)
            {
                VirtualView.HandleTabDragCompleted(this.VirtualView, new DtWindowTabsItemDragCompletedEventArgs(dtTabItem, args));
            }
        }

        void PlatformView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            var dtTabItem = FindTabItemFromView(args.Tab);
            if (dtTabItem != null)
            {
                VirtualView.HandleTabCloseRequested(this.VirtualView, new DtWindowTabItemCloseRequestEventArgs(dtTabItem, args));
                return;
            }
        }

        DtWindowTabItem FindTabItemFromView(TabViewItem tab)
        {
            foreach (var t in VirtualView.TabItems)
            {
                if (tab == t.GetTabViewItem())
                {
                    return t;
                }
            }
            return null;
        }

        void PlatformView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VirtualView.HandleSelectionChanged(this.VirtualView, new DtWindowTabsSelectionChangedEventArgs(this.VirtualView, e));
        }

        private void PlatformView_AddTabButtonClick(TabView sender, object args)
        {
            VirtualView.HandleAddTabButtonClick(this.VirtualView, args);
        }

        public static void MapAddTabButtonCommand(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AddTabButtonCommand = (ICommand)virtualView.AddTabButtonCommand;
        }


        public static void MapAddTabButtonCommandParameter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AddTabButtonCommandParameter = virtualView.AddTabButtonCommandParameter;
        }

        public static void MapAllowDropTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).AllowDropTabs = virtualView.AllowDropTabs;
        }

        public static void MapCanDragTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).CanDragTabs = virtualView.CanDragTabs;
        }

        public static void MapCanReorderTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).CanReorderTabs = virtualView.CanReorderTabs;
        }

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

        public static void MapIsAddTabButtonVisible(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).IsAddTabButtonVisible = virtualView.IsAddTabButtonVisible;
        }

        public static void MapSelectedIndex(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).SelectedIndex = virtualView.SelectedIndex;
        }

        public static void MapSelectedItem(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).SelectedItem = virtualView.SelectedItem;
        }

        public static void MapTabItems(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            viewHandler.GetItemsCollection();
        }

        void DtWindowTabItemViews_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
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
                if (e.OldItems != null)
                {
                    var b = _tabView.TabItems.Remove(_tabView.SelectedItem);
                    if (_tabView.TabItems.Count - 1 > 0)
                    {
                        _tabView.SelectedIndex = _tabView.TabItems.Count - 1;
                    }
                    else
                    {
                        _tabView.SelectedIndex = 0;
                    }
                }
            }
        }

        public static void MapTabItemsSource(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).TabItemsSource = virtualView.TabItemsSource;
        }


        public static void MapTabStripFooter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
        {
            ((TabView)(viewHandler?.PlatformView)).TabStripFooter = virtualView.TabStripFooter;
        }

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
