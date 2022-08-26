#if MACCATALYST || IOS

namespace DtControls.Handlers;

using DtControls.Controls;

using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using UIKit;

public partial class DtNavigationHandler : ViewHandler<IDtNavigation, UIKit.UIView>, IElementHandler
{
    IDtNavigationView IDtNavigationViewHandler.VirtualView => VirtualView;
    DtSidebarViewController dtSidebarController;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mapper"></param>
    /// <param name="commandMapper"></param>
    public DtNavigationHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
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

#region Properties

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapContent(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
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
    public static void MapHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapAutoSuggestBox(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
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
    public static void MapAlwaysShowHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsBackButtonVisable(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapBackButtonEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapCompactModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapCompactPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapExpandedModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    public static void MapFooterMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapFooterMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapHeaderTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsPaneOpen(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsPaneToggleButtonVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsSettingsVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItemContainerStyle(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapMenuItemsTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapOpenPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapPaneDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void MapOverflowLabelMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="viewHandler"></param>
    /// <param name="virtualView"></param>
    /// <exception cref="NotImplementedException"></exception>

    public static void MapSelectedItem(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }
#endregion
}
#endif