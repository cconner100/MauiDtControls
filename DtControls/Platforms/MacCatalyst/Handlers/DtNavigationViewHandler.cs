#if MACCATALYST

namespace DtControls.Handlers;

using DtControls.Models;
using DtControls.UserControls;

using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using UIKit;

public partial class DtNavigationViewHandler : ViewHandler<IDtNavigationView, UIKit.UIView>, IElementHandler, IDtNavigationViewHandler
{
    IDtNavigationView IDtNavigationViewHandler.VirtualView => VirtualView;
    DtSidebarViewController dtSidebarController;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mapper"></param>
    /// <param name="commandMapper"></param>
    public DtNavigationViewHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
    {
    }

    public override void SetMauiContext(IMauiContext mauiContext)
    {
        DtMauiContext.mauiContext = mauiContext;
        base.SetMauiContext(mauiContext);
    }

    UISplitViewController splitView;
    DtSidebarViewController dtSidebarViewController;
    Page contentView;
    protected override UIKit.UIView CreatePlatformView()
    {
        //contentView = new Page();
        //contentView.ForceLayout();
        
        //var platformContentView = contentView.ToUIViewController(DtMauiContext.mauiContext);

        splitView = new UISplitViewController();
        splitView.PrimaryBackgroundStyle = UISplitViewControllerBackgroundStyle.Sidebar;
        dtSidebarViewController = new DtSidebarViewController(VirtualView);

        splitView.ViewControllers = new UIViewController[] { new UINavigationController(dtSidebarViewController) }; //, platformContentView };
        return splitView.View;
    }

    protected override void ConnectHandler(UIView platformView)
    {
        base.ConnectHandler(platformView);
    }

    protected override void DisconnectHandler(UIView platformView)
    {
        base.DisconnectHandler(platformView);
    }

    public static void MapContent(IDtNavigationViewHandler handler, IDtNavigationView virtualView)
    {
        _ = handler.PlatformView ?? throw new InvalidOperationException($"{nameof(PlatformView)} should have been set by base class.");
        _ = handler.VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
        _ = handler.MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

        if (handler.VirtualView.PresentedContent is IView view)
        {
            //handler.PlatformView.Content = view.ToPlatform(handler.MauiContext);
        }
    }

    DtSidebarViewController GetController()
    {
        return dtSidebarController;
    }

    #region Properties


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapAutoSuggestBox(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        if (virtualView.AutoSuggestBox != null)
        {
            
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapAlwaysShowHeader(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsBackButtonVisable(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapBackButtonEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapCompactModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapCompactPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapExpandedModeThresholdWidth(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapFooterMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapFooterMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapHeaderTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsPaneOpen(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsPaneToggleButtonVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsSettingsVisible(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItemContainerStyle(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItems(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItemsSource(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItemsTemplate(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapOpenPaneLength(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapPaneDisplayMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapOverflowLabelMode(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>

    public static void MapSelectedItem(IDtNavigationViewHandler viewHandler, IDtNavigationView virtualView)
    {
        
    }

    #endregion
}
#endif