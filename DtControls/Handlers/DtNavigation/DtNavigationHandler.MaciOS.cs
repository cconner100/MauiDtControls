#if MACCATALYST || IOS

namespace DtControls.Handlers;

using DtControls.Controls;
using DtControls.Models;

using Microsoft.Maui.Handlers;

using UIKit;

public partial class DtNavigationHandler : ViewHandler<IDtNavigation, UIView>, IElementHandler, IDtNavigationHandler
{
    IDtNavigation IDtNavigationHandler.VirtualView => VirtualView;
    DtSidebarViewController dtSidebarController;

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
    protected override UIView CreatePlatformView()
    {
        //contentView = new Page();
        //contentView.ForceLayout();
        
        //var platformContentView = contentView.ToUIViewController(DtMauiContext.mauiContext);

        splitView = new UISplitViewController();
        splitView.PrimaryBackgroundStyle = UISplitViewControllerBackgroundStyle.Sidebar;
        dtSidebarViewController = new DtSidebarViewController(VirtualView);

        splitView.ViewControllers = new UIViewController[] { new UINavigationController(dtSidebarViewController) }; //, platformContentView };
        return splitView?.View;
    }


    public static void MapContent(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        //return dtSidebarController;
    }

    #region Properties


    public static void MapHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapAutoSuggestBox(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.AutoSuggestBox != null)
        {
            
        }
    }

    public static void MapAlwaysShowHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }


    public static void MapIsBackButtonVisable(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

 
    public static void MapBackButtonEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }


    public static void MapCompactModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }


    public static void MapCompactPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapExpandedModeThresholdWidth(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapFooterMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }


    public static void MapFooterMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapHeaderTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }


    public static void MapIsPaneOpen(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }


    public static void MapIsPaneToggleButtonVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }


    public static void MapIsSettingsVisible(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }

    public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapMenuItemContainerStyle(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
    }

    public static void MapMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapMenuItemsSource(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }

    public static void MapMenuItemsTemplate(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }


    public static void MapOpenPaneLength(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapPaneDisplayMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }

    public static void MapOverflowLabelMode(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
       
    }


    public static void MapSelectedItem(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        
    }
#endregion
}
#endif