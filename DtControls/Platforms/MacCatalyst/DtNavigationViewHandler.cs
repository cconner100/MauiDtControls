

namespace DtControls.DtNavigationView
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using DtControls.Handlers;
    using DtControls.UserControls;

    using Microsoft.Maui.Controls.Platform;
    using Microsoft.Maui.Graphics;
    using Microsoft.Maui.Handlers;
    using Microsoft.Maui.Primitives;
    using UIKit;

    public class DtNavigationViewHandler : ViewHandler<IDtNavigationView, UIKit.UIView>, IElementHandler
    {
        public DtNavigationViewHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override UIKit.UIView CreatePlatformView()
        {
            return new UIKit.UIView();
        }

        #region Properties

        public static void MapContent(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapAlwaysShowHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsBackButtonVisable(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapBackButtonEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCompactModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapCompactPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapExpandedModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        //public static void MapFooterMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        //{
        //     virtualView.FooterMenuItems = ((NavigationView)(viewHandler?.PlatformView)).FooterMenuItems; = virtualView.FooterMenuItems;
        //}

        public static void MapFooterMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapHeaderTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsPaneOpen(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsPaneToggleButtonVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsSettingsVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemContainerStyle(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapMenuItemsTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapOpenPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapPaneDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public static void MapOverflowLabelMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        public static void MapSelectedItem(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }
        public void DisconnectHandler()
        {

        }
        #endregion
    }
}