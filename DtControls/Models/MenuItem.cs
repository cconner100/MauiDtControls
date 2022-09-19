

namespace DtControls.Models;

using DtControls.Controls;

#if WINDOWS
using Microsoft.UI.Xaml.Controls;
using PlatformObject = Microsoft.UI.Xaml.Controls.NavigationViewItem;
#else
using PlatformObject = System.Object;
#endif


public class DtMenuItem
#if MACCATALYST
    : Foundation.NSObject
#endif
{
    public Guid id { get; set; }
    public MenuType menuType { get; set; }
    public List<DtMenuItem> childrenItems { get; set; } = new List<DtMenuItem>();
    
    public string title { get; set; }
    /// <summary>
    /// Only on maccatalyst
    /// </summary>
    public string subTitle { get; set; }
    public ImageSource mauiIconImage { get; set; }
    public object platformImage { get; set; }
    /// <summary>
    /// only on winui
    /// </summary>
    public string toolTip { get; set; }
    public Type screen { get; set; }

    public enum MenuType
    {
        Header,
        ExpandableRow,
        Row,
        Footer, 
        Seperator
    }

    public static DtMenuItem ResolveDtMenuItemFromNative(DtNavigation navigation, object nativeMenuItem)
    {
        foreach (var menu in navigation.MenuItems)
        {
            if (menu.InternalObject == (PlatformObject)nativeMenuItem)
            {
                return menu;
            }
            if(menu.childrenItems.Any())
            {
                var retmenu = FindMenuFromChildren(menu.childrenItems, nativeMenuItem);
                if(retmenu != null)
                {
                    return retmenu;
                }
            }      
        }
        return null;
    }
    static DtMenuItem FindMenuFromChildren(List<DtMenuItem> children, object nativeMenuItem)
    {
        foreach (var menu in children)
        {
            if (menu.InternalObject == (PlatformObject)nativeMenuItem)
            {
                return menu;
            }
            if (menu.childrenItems.Any())
            {
                var childmenu = FindMenuFromChildren(menu.childrenItems, nativeMenuItem);
                if (childmenu != null)
                {
                    return childmenu;
                }
            }
        }
        return null;
    }
    public PlatformObject InternalObject { get; set; }
}

