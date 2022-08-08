﻿#if MACCATALYST

namespace DtControls.Handlers
{
    using DtControls.UserControls;

    using Microsoft.Maui.Handlers;

    using System;

    public partial class DtNavigationViewHandler : ViewHandler<IDtNavigationView, UIKit.UIView>, IElementHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="commandMapper"></param>
        public DtNavigationViewHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override UIKit.UIView CreatePlatformView()
        {
            return new UIKit.UIView();
        }

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapContent(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapAlwaysShowHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapIsBackButtonVisable(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapBackButtonEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapCompactModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapCompactPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapExpandedModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
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
        /// <exception cref="NotImplementedException"></exception>
        public static void MapFooterMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapHeaderTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapIsPaneOpen(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapIsPaneToggleButtonVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapIsSettingsVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapMenuItemContainerStyle(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapMenuItemsTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapOpenPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapPaneDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void MapOverflowLabelMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewHandler"></param>
        /// <param name="virtualView"></param>
        /// <exception cref="NotImplementedException"></exception>

        public static void MapSelectedItem(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DisconnectHandler()
        {

        }
        #endregion
    }
}
#endif