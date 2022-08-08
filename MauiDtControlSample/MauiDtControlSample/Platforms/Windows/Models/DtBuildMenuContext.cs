namespace MauiDtControlSample.Models
{
    using DtControls.UserControls;

    using Microsoft.UI.Xaml.Controls;

    using System.Collections.Generic;
    using System.Linq;

    public partial class DtBuildMenuContext
    {
        public void BuildPlatformMenus(DtNavigationView nv, List<DtMenuItem> menulist)
        {

            var toplevel = menulist.Where(o => o.Id == o.ParentId).ToList();
            foreach (var rootMenu in toplevel)
            {
                var Level0Menu = MakeMenuItem(rootMenu);
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
                Content = item.ToolTipResource
            };
            var ret = new NavigationViewItem
            {
                Content = item.NameResource,
                Icon = new SymbolIcon() { Symbol = Symbol.Account },
                Tag = item.Screen
            };
            ToolTipService.SetToolTip(ret, tooltip);
            return ret;
        }
    }
}
