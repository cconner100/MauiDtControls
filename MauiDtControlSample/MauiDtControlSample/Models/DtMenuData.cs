namespace MauiDtControlSample.Models;

using DtControls.Models;

using System.Collections.Generic;
using MauiDtControlSample.Pages;

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
            ToolTip = "Traveling on the ground",
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.World),
#endif
#if MACCATALYST
            platformImage = UIImage.GetSystemImage("figure.wave"),
#endif
            MauiIconImage = null,
            menuType = DtMenuItem.MenuType.ExpandableRow,
            ChildrenItems =
            {
                new DtMenuItem
                {id=Guid.NewGuid(),
                title = "Car",
                subTitle = null,
                ToolTip ="Ford?",
                menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.Repair),
#endif
#if MACCATALYST
                platformImage = UIImage.GetSystemImage("car"),
#endif
                MauiIconImage = null,
                screen = typeof(CarPage)
                },
                new DtMenuItem {
                    id = Guid.NewGuid(),
                    title = "Bus",
                    ToolTip = "Red or Blue Line",
                    menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
                    platformImage = new SymbolIcon(Symbol.OtherUser),
#endif
#if MACCATALYST
                    platformImage = UIImage.GetSystemImage("bus"),
#endif
                    MauiIconImage = null,
                    screen = typeof(BusPage)
                },
                {
                new DtMenuItem {
                    id = Guid.NewGuid(),
                    title = "Cable Car",
                    ToolTip = "Southern Pacific",
                    menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
                    platformImage = new SymbolIcon(Symbol.Phone),
#endif
#if MACCATALYST
                    platformImage = UIImage.GetSystemImage("cablecar"),
#endif
                    MauiIconImage = null,
                    screen = typeof(CableCarPage)
                }
            },
            {
            new DtMenuItem
            {
                id = Guid.NewGuid(),
                title = "Other",
                ToolTip = "Water, Air",
                menuType = DtMenuItem.MenuType.ExpandableRow,
#if WINDOWS
            platformImage = new SymbolIcon(Symbol.PhoneBook),
#endif
#if MACCATALYST
                platformImage = UIImage.GetSystemImage("fuelpump"),
#endif
                MauiIconImage = null,
                ChildrenItems =
                {
                    new DtMenuItem
                    {
                        id = Guid.NewGuid(),
                        title = "Airplane",
                        ToolTip = null,
                        menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
                        platformImage = new SymbolIcon(Symbol.Pin),
#endif
#if MACCATALYST
                        platformImage = UIImage.GetSystemImage("airplane"),
#endif
                        MauiIconImage = null,
                        screen = typeof(AirPlanePage)
                    },
                    new DtMenuItem
                    {
                        id = Guid.NewGuid(),
                        title = "Ferry",
                        ToolTip = "Maybe take your car",
                        menuType = DtMenuItem.MenuType.Row,
#if WINDOWS
                        platformImage = new SymbolIcon(Symbol.Contact2),
#endif
#if MACCATALYST
                        platformImage = UIImage.GetSystemImage("ferry"),
#endif
                        MauiIconImage = null,
                        screen = typeof(FerryPage)}
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
            screen = typeof(HelpPage)
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
