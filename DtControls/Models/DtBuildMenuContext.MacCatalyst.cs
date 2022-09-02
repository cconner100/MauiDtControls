#if MACCATALYST
namespace DtControls.Models;

using DtControls.Controls;

using System.Collections.Generic;

public class DtBuildMenuContext : IDtBuildMenuContext
{
    public List<object> BuildPlatformMenus(List<DtMenuItem> menulist)
    {
        List<object> menu = new List<object>();

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
                    AddChildren(menu, item.childrenItems);
                    continue;
                }
            }
            // must be a row
            menu.Add(item);

        }
        return menu;
    }

    void AddChildren(List<object> menu, List<DtMenuItem> items)
    {
        foreach (var item in items)
        {
            menu.Add(item);
            if (item.childrenItems.Any())
            {
                AddChildren(menu, item.childrenItems);
            }
        }
    }

    void IDtBuildMenuContext.Clear()
    {
        throw new NotImplementedException();
    }
}
#endif

