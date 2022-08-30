namespace MauiDtControlSample.Models;

public class DtMenuItem
#if MACCATALYST
    : Foundation.NSObject
#endif
{
    public int id { get; set; }
    public MenuType menuType { get; set; }
    public int parentId { get; set; }
    public string nameResource { get; set; }
    public object iconObject { get; set; }
    public string toolTipResource { get; set; }
    public Type screen { get; set; }

    public static DtMenuItem MakeMenuItem(int id, int parentid, string nameresource, object iconObject = null, Type screen = null, MenuType menuType = MenuType.Row)
    {
        var resname = nameresource;
        return new DtMenuItem() { id = id, parentId = parentid, nameResource = resname, iconObject = iconObject, toolTipResource = resname + "_TOOLTIP", screen = screen, menuType = menuType };
    }

    public enum MenuType
    {
        Header,
        ExpandableRow,
        Row,
        Footer
    }
}

