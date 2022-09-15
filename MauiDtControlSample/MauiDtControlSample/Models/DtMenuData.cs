namespace MauiDtControlSample.Models;

using DtControls.Models;



using System.Collections.Generic;

#if WINDOWS
using Microsoft.UI.Xaml.Controls;
#endif

#if MACCATALYST
using UIKit;
#endif

public class DtMenuData : IDtMenu
{
    readonly List<DtMenuItem> dtmenudata = new();

    readonly List<DtMenuItem> dtmenufooterdata = new();
    public void InitMenuData()
    {
        dtmenudata.Clear();
        dtmenudata.Add(new DtMenuItem
        {
            id = Guid.NewGuid(),
            title = "Transportation",
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.People),
#endif

#if MACCATALYST
            platformImage = UIImage.GetSystemImage("car.2"),
#endif
            //mauiIconImage = "fruits.png",
            menuType = DtMenuItem.MenuType.Header,
        });

        dtmenudata.Add(new DtMenuItem
        {
            id = Guid.NewGuid(),
            title = "Ground",
            subTitle = "Traveling on the ground",
            toolTip = "Traveling on the ground",
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.World),
#endif
#if MACCATALYST
            platformImage = UIImage.GetSystemImage("figure.wave"),
#endif
            mauiIconImage = null,
            menuType = DtMenuItem.MenuType.ExpandableRow,
            childrenItems =
            {
                new DtMenuItem
                {id=Guid.NewGuid(),
                title = "Car",
                subTitle = null,
                toolTip ="Ford?",
                menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.Repair),
#endif
#if MACCATALYST
                platformImage = UIImage.GetSystemImage("car"),
#endif
                mauiIconImage = null,
                screen = typeof(TabPage1)
                },
                {
                new DtMenuItem {
                    id = Guid.NewGuid(),
                    title = "Bus",
                    toolTip = "Red or Blue Line",
                    menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.OtherUser),
#endif
#if MACCATALYST
                    platformImage = UIImage.GetSystemImage("bus"),
#endif
                    mauiIconImage = null,
                    screen = typeof(TabPage1)
                    }
                },
                {
                new DtMenuItem {
                    id = Guid.NewGuid(),
                    title = "Cable Car",
                    toolTip = "Southern Pacific",
                    menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
                    platformImage = new SymbolIcon(Symbol.Phone),
#endif
#if MACCATALYST
                    platformImage = UIImage.GetSystemImage("cablecar"),
#endif
                    mauiIconImage = null,
                    screen = typeof(TabPage1)
                }
            },
            {
            new DtMenuItem
            {
                id = Guid.NewGuid(),
                title = "Other",
                toolTip = "Water, Air",
                menuType = DtMenuItem.MenuType.ExpandableRow,
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.PhoneBook),
#endif
#if MACCATALYST
                platformImage = UIImage.GetSystemImage("fuelpump"),
#endif
                mauiIconImage = null,
                childrenItems =
                {
                    new DtMenuItem
                    {
                        id = Guid.NewGuid(),
                        title = "Airplane",
                        toolTip = null,
                        menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
                        platformImage = new SymbolIcon(Symbol.Pin),
#endif
#if MACCATALYST
                        platformImage = UIImage.GetSystemImage("airplane"),
#endif
                        mauiIconImage = null,
                        screen = typeof(TabPage1)
                    },
                    {
                    new DtMenuItem
                    {
                        id = Guid.NewGuid(),
                        title = "Ferry",
                        toolTip = "Maybe take your car",
                        menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
                        platformImage = new SymbolIcon(Symbol.Contact2),
#endif
#if MACCATALYST
                        platformImage = UIImage.GetSystemImage("ferry"),
#endif
                        mauiIconImage = null,
                        screen = typeof(TabPage1)}}
                    },
                }
            }
        }
        });

        // footer
        dtmenufooterdata.Add(new DtMenuItem
        {
            id = Guid.NewGuid(),
            title = "Help",
            subTitle = "How to use this",
            menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.Help),
#endif
#if MACCATALYST
            platformImage = UIImage.GetSystemImage("questionmark.circle"),
#endif
            //mauiIconImage = "help.png",
            screen = typeof(TabPage1)
        });

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
