namespace MauiDtControlSample.Models;

using DtControls.Controls;

using MauiDtControlSample.Helpers;

using Microsoft.UI.Xaml.Controls;

using System.Collections.Generic;
using System.Linq;

public partial class DtBuildMenuContext
{
    public List<string> menunames = new List<string>();

    public void BuildPlatformMenus(DtNavigation nv, List<DtMenuItem> menulist, DtNavigation.MenuArea area)
    {

        // if footer area then only list with no sublists
        if (area == DtNavigation.MenuArea.footer)
        {
            foreach (var item in menulist)
            {
                nv?.FooterMenuItems.Add(MakeMenuItem(item));
            }
            return;
        }

        var toplevel = menulist.Where(o => o.Id == o.ParentId).ToList();
        NavigationViewItem Level0Menu = null;
        foreach (var rootMenu in toplevel)
        {
            Level0Menu = MakeMenuItem(rootMenu);
            var subitem = menulist.Where(o => o.ParentId == rootMenu.Id).ToList();

            foreach (var subsubitem in subitem)
            {
                if (subsubitem.Id == subsubitem.ParentId)
                {
                    continue;
                }

                var second = menulist.Where(o => o.ParentId == subsubitem.Id).ToList();

                if (!second.Any())
                {
                    Level0Menu.MenuItems.Add(MakeMenuItem(subsubitem));
                    continue;
                }

                var Level2Menu = MakeMenuItem(subsubitem);

                foreach (var smenu in second)
                {
                    Level2Menu.MenuItems.Add(MakeMenuItem(smenu));
                }
                Level0Menu.MenuItems.Add(Level2Menu);
            }
            nv?.MenuItems?.Add(Level0Menu);
        }
    }

    public List<string> SearchMenus(string name)
    {
        var ret = new List<string>();   
        foreach(var item in menunames)
        {
            if(item.Contains(name, StringComparison.OrdinalIgnoreCase))
            {
                ret.Add(item);
            }
        }
        return ret;
    }

    private NavigationViewItem MakeMenuItem(DtMenuItem item)
    {
        var tooltip = new ToolTip
        {
            Content = LanguageResourceHelper.GetDisplayText(item.ToolTipResource)
        };
        var ret = new NavigationViewItem
        {
            Content = LanguageResourceHelper.GetDisplayText(item.NameResource),
            Icon = new SymbolIcon() { Symbol = (Symbol)item.IconObject },
            Tag = item.Screen
        };
        ToolTipService.SetToolTip(ret, tooltip);

        menunames?.Add(ret.Content.ToString());
        return ret;
    }        
}
