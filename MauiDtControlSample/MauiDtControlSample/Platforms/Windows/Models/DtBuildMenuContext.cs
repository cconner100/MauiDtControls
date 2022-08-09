﻿namespace MauiDtControlSample.Models
{
    using DtControls.UserControls;

    using MauiDtControlSample.Helpers;

    using Microsoft.UI.Xaml.Controls;

    using System.Collections.Generic;
    using System.Linq;

    public partial class DtBuildMenuContext
    {
        public enum MenuArea
        {
            main,
            footer
        }
        public void BuildPlatformMenus(DtNavigationView nv, List<DtMenuItem> menulist, MenuArea area)
        {

            // if footer area then only list with no sublists
            if(area == MenuArea.footer)
            {
                foreach(var item in menulist)
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
            return ret;
        }
    }
}
