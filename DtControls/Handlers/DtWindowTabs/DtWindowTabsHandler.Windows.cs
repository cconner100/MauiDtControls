#if WINDOWS
namespace DtControls.Handlers;

using DtControls.Controls;
using DtControls.Models;

using Microsoft.Maui.Handlers;
using Microsoft.UI.Xaml.Controls;

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

using static DtControls.Models.DtWindowTabsDragEventArgs;

public partial class DtWindowTabsHandler : ViewHandler<DtWindowTabs, TabView>, IDtWindowTabsHandler
{
    readonly TabView _tabView = new();
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
        platformView.AddTabButtonClick -= PlatformView_AddTabButtonClick;
        platformView.SelectionChanged -= PlatformView_SelectionChanged;
        platformView.TabCloseRequested -= PlatformView_TabCloseRequested;
        platformView.TabDragCompleted -= PlatformView_TabDragCompleted;
        platformView.TabDragStarting -= PlatformView_TabDragStarting;
        platformView.TabDroppedOutside -= PlatformView_TabDroppedOutside;
        platformView.TabItemsChanged -= PlatformView_TabItemsChanged;
        platformView.TabStripDragOver -= PlatformView_TabStripDragOver;
        platformView.TabStripDrop -= PlatformView_TabStripDrop;

        dtWindowTabItemViews.CollectionChanged -= DtWindowTabItemViews_CollectionChanged;
    }

    public override void SetMauiContext(IMauiContext mauiContext)
    {
        DtMauiContext.MauiContext = mauiContext;
        base.SetMauiContext(mauiContext);
    }

    void PlatformView_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        VirtualView.HandleLoaded(VirtualView, e);
    }

    void PlatformView_TabStripDrop(object sender, Microsoft.UI.Xaml.DragEventArgs e)
    {
        VirtualView.HandleTabStripDrop(VirtualView, new DtWindowTabsStripDropEventArgs(e));
    }

    void PlatformView_TabStripDragOver(object sender, Microsoft.UI.Xaml.DragEventArgs e)
    {
        VirtualView.HandleTabStripDragOver(VirtualView, new DtWindowTabsStripDragOverEventArgs(e));
    }

    void PlatformView_TabItemsChanged(TabView sender, Windows.Foundation.Collections.IVectorChangedEventArgs args)
    {
        var virtualArgs = new DtWindowTabsItemsChangedEventArgs(args);
        VirtualView.HandleTabItemsChanged(VirtualView, virtualArgs);
        VirtualView.SelectedIndex = (int)virtualArgs.Index;
    }

    void PlatformView_TabDroppedOutside(TabView sender, TabViewTabDroppedOutsideEventArgs args)
    {
        var dtTabItem = FindTabItemFromView(args.Tab);
        if (dtTabItem != null)
        {
            VirtualView.HandleTabDroppedOutSide(VirtualView, new DtWindowTabsDroppedOutsideEventArgs(dtTabItem, args));
        }
    }

    void PlatformView_TabDragStarting(TabView sender, TabViewTabDragStartingEventArgs args)
    {
        var dtTabItem = FindTabItemFromView(args.Tab);
        if (dtTabItem != null)
        {
            VirtualView.HandleTabDragStarting(VirtualView, new DtWindowTabsDragStartingEventArgs(dtTabItem, args));
        }
    }

    void PlatformView_TabDragCompleted(TabView sender, TabViewTabDragCompletedEventArgs args)
    {
        var dtTabItem = FindTabItemFromView(args.Tab);
        if (dtTabItem != null)
        {
            VirtualView.HandleTabDragCompleted(VirtualView, new DtWindowTabsItemDragCompletedEventArgs(dtTabItem, args));
        }
    }

    void PlatformView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
    {
        var dtTabItem = FindTabItemFromView(args.Tab);
        if (dtTabItem != null)
        {
            VirtualView.HandleTabCloseRequested(VirtualView, new DtWindowTabItemCloseRequestEventArgs(dtTabItem, args));
            return;
        }
    }

    DtWindowTabItem? FindTabItemFromView(TabViewItem tab)
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
        VirtualView.SelectedIndex = ((TabView)sender).SelectedIndex;
        VirtualView.SelectedItem = ((TabView)sender).SelectedItem;
        VirtualView.HandleSelectionChanged(VirtualView, new DtWindowTabsSelectionChangedEventArgs(this.VirtualView, e));
    }

    private void PlatformView_AddTabButtonClick(TabView sender, object args)
    {
        VirtualView.HandleAddTabButtonClick(VirtualView, args);
    }

    public static void MapAddTabButtonCommand(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).AddTabButtonCommand = (ICommand)virtualView.AddTabButtonCommand;
    }


    public static void MapAddTabButtonCommandParameter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).AddTabButtonCommandParameter = virtualView.AddTabButtonCommandParameter;
    }

    public static void MapAllowDropTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).AllowDropTabs = virtualView.AllowDropTabs;
    }

    public static void MapCanDragTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).CanDragTabs = virtualView.CanDragTabs;
    }

    public static void MapCanReorderTabs(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).CanReorderTabs = virtualView.CanReorderTabs;
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
        (viewHandler.PlatformView).CloseButtonOverlayMode = mode;
    }

    public static void MapIsAddTabButtonVisible(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).IsAddTabButtonVisible = virtualView.IsAddTabButtonVisible;
    }

    public static void MapSelectedIndex(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        Debug.WriteLine("MapSelectedIndex");
        (viewHandler.PlatformView).SelectedIndex = virtualView.SelectedIndex;
    }

    public static void MapSelectedItem(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).SelectedItem = virtualView.SelectedItem;
    }

    public static void MapTabItems(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        viewHandler.GetItemsCollection();
    }

    void DtWindowTabItemViews_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs? e)
    {
        if(e is null)
        {
            return;
        }

        if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        {
            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is DtWindowTabItem tvi)
                    {
                        
                        if(tvi.Content is NavigationPage navpage)
                        {
                            tvi.NavigationPage = navpage;
                        }
                        _tabView.TabItems.Add(tvi.GetTabViewItem());
                        _tabView.SelectedItem = tvi.GetTabViewItem();
                        _tabView.Focus(Microsoft.UI.Xaml.FocusState.Keyboard);
                    }
                }
            }
        }

        if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
        {
            if (e.OldItems != null)
            {
                _ = _tabView.TabItems.Remove(_tabView.SelectedItem);
                _tabView.SelectedIndex = _tabView.TabItems.Count - 1 > 0 ? _tabView.TabItems.Count - 1 : 0;
                _tabView.Focus(Microsoft.UI.Xaml.FocusState.Keyboard);
            }
        }
    }

    public static void MapTabItemsSource(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).TabItemsSource = virtualView.TabItemsSource;
    }


    public static void MapTabStripFooter(IDtWindowTabsHandler viewHandler, IDtWindowTabs virtualView)
    {
        (viewHandler.PlatformView).TabStripFooter = virtualView.TabStripFooter;
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
        (viewHandler.PlatformView).TabWidthMode = mode;
    }

    void IDtWindowTabsHandler.GetItemsCollection()
    {
        VirtualView.TabItems = dtWindowTabItemViews;
    }
}
#endif
