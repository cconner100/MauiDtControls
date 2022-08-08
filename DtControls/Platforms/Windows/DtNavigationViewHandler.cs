#if WINDOWS
namespace DtControls.Handlers
{

    using DtControls.UserControls;

    using Microsoft.Maui;
    using Microsoft.Maui.Handlers;
    using Microsoft.Maui.Platform;
    using Microsoft.UI.Xaml.Controls;

    using System.Diagnostics;

    public partial class DtNavigationViewHandler : ViewHandler<DtNavigationView, NavigationView>, IDtNavigationViewHandler
    {
        private NavigationView _navigationView = new NavigationView();
         
        IDtNavigationView IDtNavigationViewHandler.VirtualView => VirtualView;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override NavigationView CreatePlatformView()
        {
            return _navigationView;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="platformView"></param>
        protected override void ConnectHandler(NavigationView platformView)
        {
            base.ConnectHandler(platformView);
            platformView.Loaded += PlatformView_Loaded;            
            platformView.BackRequested += PlatformView_BackRequested;
            platformView.DisplayModeChanged += PlatformView_DisplayModeChanged;
            platformView.Expanding += PlatformView_Expanding;
            platformView.ItemInvoked += PlatformView_ItemInvoked;
            platformView.PaneClosed += PlatformView_PaneClosed;
            platformView.PaneClosing += PlatformView_PaneClosing;
            platformView.PaneOpened += PlatformView_PaneOpened;
            platformView.PaneOpening += PlatformView_PaneOpening;
            platformView.SelectionChanged += PlatformView_SelectionChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="platformView"></param>
        protected override void DisconnectHandler(NavigationView platformView)
        {
            base.DisconnectHandler(platformView);
            platformView.Loaded -= PlatformView_Loaded;
            platformView.BackRequested -= PlatformView_BackRequested;
            platformView.DisplayModeChanged -= PlatformView_DisplayModeChanged;
            platformView.Expanding -= PlatformView_Expanding;
            platformView.ItemInvoked -= PlatformView_ItemInvoked;
            platformView.PaneClosed -= PlatformView_PaneClosed;
            platformView.PaneClosing -= PlatformView_PaneClosing;
            platformView.PaneOpened -= PlatformView_PaneOpened;
            platformView.PaneOpening -= PlatformView_PaneOpening;
            platformView.SelectionChanged -= PlatformView_SelectionChanged;
        }

#region Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            VirtualView?.WinItemInvoked(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>

        private void PlatformView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            VirtualView?.WinBackRequested(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            VirtualView?.WinSelectionChanged(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformView_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            Trace.WriteLine("OnLoaded");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_PaneOpening(NavigationView sender, object args)
        {
            VirtualView?.WinPaneOpening(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_PaneOpened(NavigationView sender, object args)
        {
            VirtualView?.WinPaneOpening(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_PaneClosing(NavigationView sender, NavigationViewPaneClosingEventArgs args)
        {
            VirtualView?.WinPaneClosing(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_PaneClosed(NavigationView sender, object args)
        {
            VirtualView?.WinPaneClosed(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_Expanding(NavigationView sender, NavigationViewItemExpandingEventArgs args)
        {
            VirtualView?.WinExpanding(sender, args);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PlatformView_DisplayModeChanged(NavigationView sender, NavigationViewDisplayModeChangedEventArgs args)
        {
            VirtualView?.WinDisplayModeChanged(sender, args);
        }
#endregion

#region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void MapContent(IDtNavigationViewHandler handler, IDtNavigationView virtualView)
        {
            //((NavigationView)(viewHandler?.PlatformView)).Content = virtualView.Content;
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
        /// <param name="mauiContext"></param>
        public override void SetMauiContext(IMauiContext mauiContext)
        {
            base.SetMauiContext(mauiContext);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).Header = virtualView.Header;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapAlwaysShowHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).AlwaysShowHeader = virtualView.AlwaysShowHeader;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapIsBackButtonVisable(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            NavigationViewBackButtonVisible vis = NavigationViewBackButtonVisible.Auto;
            switch (virtualView.IsBackButtonVisable)
            {
                case DtNavigationView.BackButtonVisable.Visible:
                    vis = NavigationViewBackButtonVisible.Visible;
                    break;
                case DtNavigationView.BackButtonVisable.Collapsed:
                    vis = NavigationViewBackButtonVisible.Collapsed;
                    break;
                case DtNavigationView.BackButtonVisable.Auto:
                    vis = NavigationViewBackButtonVisible.Auto;
                    break;
            }
            ((NavigationView)(viewHandler?.PlatformView)).IsBackButtonVisible = vis;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapBackButtonEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).IsBackEnabled = virtualView.IsBackButtonEnabled;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCompactModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).CompactModeThresholdWidth = virtualView.CompactModeThresholdWidth;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapCompactPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).CompactPaneLength = virtualView.CompactPaneLength;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            switch (((NavigationView)(viewHandler?.PlatformView)).DisplayMode)
            {
                case NavigationViewDisplayMode.Compact:
                    virtualView.DisplayMode = DtNavigationView.ViewDisplayMode.Compact;
                    break;
                case NavigationViewDisplayMode.Expanded:
                    virtualView.DisplayMode = DtNavigationView.ViewDisplayMode.Expanded;
                    break;
                case NavigationViewDisplayMode.Minimal:
                    virtualView.DisplayMode = DtNavigationView.ViewDisplayMode.Minimal;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapExpandedModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).ExpandedModeThresholdWidth = virtualView.ExpandedModeThresholdWidth;
        }

        //public static void MapFooterMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        //{
        //     virtualView.FooterMenuItems = ((NavigationView)(viewHandler?.PlatformView)).FooterMenuItems; = virtualView.FooterMenuItems;
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapFooterMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).FooterMenuItemsSource = virtualView.FooterMenuItemsSource;
        }
        //public static void MapHeaderTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        //{
        //    ((NavigationView)(viewHandler?.PlatformView)).HeaderTemplate = virtualView.HeaderTemplate;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapIsPaneOpen(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).IsPaneOpen = virtualView.IsPaneOpen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapIsPaneToggleButtonVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).IsPaneToggleButtonVisible = virtualView.IsPaneToggleButtonVisible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapIsSettingsVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).IsSettingsVisible = virtualView.IsSettingsVisible;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).IsTitleBarAutoPaddingEnabled = virtualView.IsTitleBarAutoPaddingEnabled;
        }
        //public static void MapMenuItemContainerStyle(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        //{
        //    ((NavigationView)(viewHandler?.PlatformView)).MenuItemContainerStyle = virtualView.MenuItemContainerStyle;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            var x = ((NavigationView)(viewHandler?.PlatformView)).MenuItems;

            virtualView.MenuItems = (IList<object>)((NavigationView)(viewHandler?.PlatformView)).MenuItems;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).MenuItemsSource = virtualView.MenuItemsSource;
        }

        //public static void MapMenuItemsTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        //{
        //    ((NavigationView)(viewHandler?.PlatformView)).MenuItemTemplate = virtualView.MenuItemsTemplate;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapOpenPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            ((NavigationView)(viewHandler?.PlatformView)).OpenPaneLength = virtualView.OpenPaneLength;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapPaneDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            NavigationViewPaneDisplayMode mode = NavigationViewPaneDisplayMode.Auto;
            switch (virtualView.PaneDisplayMode)
            {
                case DtNavigationView.ViewPaneDisplayMode.Left:
                    mode = NavigationViewPaneDisplayMode.Left;
                    break;
                case DtNavigationView.ViewPaneDisplayMode.Auto:
                    mode = NavigationViewPaneDisplayMode.Auto;
                    break;
                case DtNavigationView.ViewPaneDisplayMode.LeftCompact:
                    mode = NavigationViewPaneDisplayMode.LeftCompact;
                    break;
                case DtNavigationView.ViewPaneDisplayMode.Top:
                    mode = NavigationViewPaneDisplayMode.Top;
                    break;
                case DtNavigationView.ViewPaneDisplayMode.LeftMinimal:
                    mode = NavigationViewPaneDisplayMode.LeftMinimal;
                    break;
            }

            ((NavigationView)(viewHandler?.PlatformView)).PaneDisplayMode = mode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapOverflowLabelMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            NavigationViewOverflowLabelMode mode = NavigationViewOverflowLabelMode.NoLabel;

            switch (virtualView.OverflowLabelMode)
            {
                case DtNavigationView.ViewOverflowLabelMode.MoreLabel:
                    mode = NavigationViewOverflowLabelMode.MoreLabel;
                    break;
                case DtNavigationView.ViewOverflowLabelMode.NoLabel:
                    mode = NavigationViewOverflowLabelMode.NoLabel;
                    break;
            }

            ((NavigationView)(viewHandler?.PlatformView)).OverflowLabelMode = mode;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        public static void MapSelectedItem(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            if (virtualView.SelectedItem != null)
            {
                ((NavigationView)(viewHandler?.PlatformView)).SelectedItem = virtualView.SelectedItem;
            }
        }
#endregion
    }
}
#endif