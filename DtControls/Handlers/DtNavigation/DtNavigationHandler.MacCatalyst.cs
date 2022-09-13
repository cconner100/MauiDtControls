#if MACCATALYST

namespace DtControls.Handlers;

using DtControls.Controls;
using DtControls.Models;

using Microsoft.Maui.Handlers;

using UIKit;

public partial class DtNavigationHandler : ViewHandler<IDtNavigation, UIView>, IElementHandler, IDtNavigationHandler
{
    IDtNavigation IDtNavigationHandler.VirtualView => VirtualView;

    UISplitViewController IDtNavigationHandler.splitView => splitView;
    UISplitViewController splitView;
    DtSidebarViewController dtSidebarViewController;
    Page contentView;


    public DtNavigationHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
    {
    }

    DtSidebarViewController IDtNavigationHandler.Controller => dtSidebarViewController;

    public override void SetMauiContext(IMauiContext mauiContext)
    {
        DtMauiContext.mauiContext = mauiContext;
        base.SetMauiContext(mauiContext);
    }

    protected override UIView CreatePlatformView()
    {
        splitView = new UISplitViewController(UISplitViewControllerStyle.DoubleColumn)
        {
            PrimaryBackgroundStyle = UISplitViewControllerBackgroundStyle.Sidebar,            
        };


        dtSidebarViewController = new DtSidebarViewController(VirtualView);

        splitView.ViewControllers = new UIViewController[] { new UINavigationController(dtSidebarViewController) };
        ViewController = dtSidebarViewController;
        
        return splitView?.View;
    }


    public static void MapContent(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.Content is UIView)
        {
            viewHandler.splitView.Add((UIView)virtualView.Content);
        }
    }

    #region Properties


    public static void MapHeader(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        viewHandler.Controller?.SetHeader(virtualView?.Header);
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
        viewHandler.Controller.ShowSettings(virtualView.IsSettingsVisible);
    }

    public static void MapIsTitleBarAutoPaddingEnabled(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {

    }

    public static void MapMenuItemContainerStyle(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
    }

    public static void MapMenuItems(IDtNavigationHandler viewHandler, IDtNavigation virtualView)
    {
        if (virtualView.MenuItems == null || !virtualView.MenuItems.Any())
        {
            return;
        }

        var menu = viewHandler.BuildPlatformMenus(virtualView.MenuItems, virtualView);
        if (menu != null)
        {
            // hack copy
            var x = new List<DtMenuItem>();
            foreach (var m in menu)
            {
                x.Add((DtMenuItem)m);
            }
            var list = viewHandler.Controller?.GetNavigationSnapshot(x);
            viewHandler.Controller?.SetupNavigationItems(list);
        }

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

    public List<DtMenuItem> BuildPlatformMenus(IList<DtMenuItem> menulist, IDtNavigation virtualView)
    {
        List<DtMenuItem> menu = new List<DtMenuItem>();

        foreach (var item in menulist)
        {
            if (item.menuType == DtMenuItem.MenuType.Header)
            {
                menu.Add(item);
                continue;
            }
            if (item.menuType == DtMenuItem.MenuType.ExpandableRow)
            {
                menu.Add(item);
                if (item.childrenItems.Any())
                {
                    AddChildren(menu, item.childrenItems, virtualView);
                    if (item.menuType == DtMenuItem.MenuType.Row)
                    {
                        virtualView.MenuNames.Add(item.title, item);
                    }
                    continue;
                }
            }
            // must be a row
            menu.Add(item);
            if (item.menuType == DtMenuItem.MenuType.Row)
            {
                virtualView.MenuNames.Add(item.title, item);
            }
        }
        return menu;
    }

    void AddChildren(List<DtMenuItem> menu, List<DtMenuItem> items, IDtNavigation virtualView)
    {
        foreach (var item in items)
        {
            menu.Add(item);
            if (item.menuType == DtMenuItem.MenuType.Row)
            {
                virtualView.MenuNames.Add(item.title, item);
            }
            if (item.childrenItems.Any())
            {
                AddChildren(menu, item.childrenItems, virtualView);
            }
        }
    }
}
#endif