namespace MauiDtControlSample.Models;

using DtControls.Models;


using System.Collections.Generic;

public class DtMenuData : IDtMenu
{
    readonly List<DtMenuItem> dtmenudata = new List<DtMenuItem>();

    readonly List<DtMenuItem> dtmenufooterdata = new List<DtMenuItem>();
    public void InitMenuData()
    {
        dtmenudata.Clear();
        dtmenudata.Add(new DtMenuItem
        {
            id = new Guid(),
            title = "Fruits",
            subTitle = "What is a fruit",
            toolTip = "What are fruits",
            iconImage = "fruits.png",
            menuType = DtMenuItem.MenuType.ExpandableRow,
            childrenItems =
            {new DtMenuItem {id=new Guid(), title = "Peach", subTitle = "thats an easy one", toolTip ="thats an easy one",  menuType = DtMenuItem.MenuType.Row, iconImage = "peach.png", screen = typeof(TabPage1)},
            {new DtMenuItem { id = new Guid(), title = "Grapes", toolTip = "green or purple?", menuType = DtMenuItem.MenuType.Row, iconImage = "grapes.png", screen = typeof(TabPage1)}},
            {new DtMenuItem { id = new Guid(), title = "These are also fruits", toolTip = "Did you know this", menuType = DtMenuItem.MenuType.ExpandableRow, iconImage = "roundquestionmark.png", childrenItems =
                {new DtMenuItem { id = new Guid(), title = "Almonds", toolTip = "shell items", menuType = DtMenuItem.MenuType.Row, iconImage = "almond.png", screen = typeof(TabPage1)},
                {new DtMenuItem { id = new Guid(), title = "Acorns", toolTip = "shell items", menuType = DtMenuItem.MenuType.Row, iconImage = "acorn.png", screen = typeof(TabPage1)}}
            },
        } } }
        });

        // footer
        dtmenufooterdata.Add(new DtMenuItem
        {
            id = new Guid(),
            title = "Help",
            subTitle = "How to use this",
            menuType = DtMenuItem.MenuType.Row,
            iconImage = "help.png",
            screen = typeof(TabPage1)
        });

        //dtmenufooterdata.Add(new DtMenuItem
        //{
        //    id = new Guid(),
        //    title = "Settings",
        //    subTitle = "System Settings",
        //    menuType = DtMenuItem.MenuType.Row,
        //    iconImage = "settings.png",
        //    screen = typeof(TabPage1)
        //});

    }

    public List<DtMenuItem> GetMenu()
    {
        return dtmenudata;
    }

    public List<DtMenuItem> GetFooterMenu()
    {
        return dtmenufooterdata;
    }

}
