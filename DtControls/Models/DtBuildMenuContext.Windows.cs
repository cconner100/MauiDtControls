#if WINDOWS
namespace DtControls.Models;

using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Controls;

using System.Collections.Generic;

public class DtBuildMenuContext : IDtBuildMenuContext
{
    public Dictionary<string, DtMenuItem> menunames = new Dictionary<string, DtMenuItem>();

    public void Clear()
    {
        menunames.Clear(); 
    }
    public List<object> BuildPlatformMenus(List<DtMenuItem> menulist)
    {
        if(menulist == null)
        {
            return null;
        }
        List<object> items = new List<object>();
        foreach (var item in menulist)
        {
            items.Add(MakeMenuItem(item));
        }
        return items;
    }

    public Dictionary<string, DtMenuItem> SearchMenus(string name)
    {
        var ret = new Dictionary<string, DtMenuItem>();
        foreach (var item in menunames)
        {
            if (item.Key.Contains(name, StringComparison.OrdinalIgnoreCase))
            {
                ret.Add(item.Key, item.Value);
            }
        }
        return ret;
    }

    private NavigationViewItem MakeMenuItem(DtMenuItem item)
    {
        var tooltip = new ToolTip
        {
            Content = item.subTitle
        };
        var ret = new NavigationViewItem
        {
            Content = item.title,
            Icon = (IconElement)(item.iconImage != null ?  item.iconImage.ToIconSource(DtMauiContext.mauiContext)?.CreateIconElement()  : null),
            Tag = item.screen
        };

        
        ToolTipService.SetToolTip(ret, tooltip);
        if (item.childrenItems.Any())
        {
            foreach (var child in item.childrenItems)
            {
                ret.MenuItems.Add(MakeMenuItem(child));
            }
        }
        menunames?.Add(ret.Content.ToString(), item);
        return ret;
    }
}
#endif
