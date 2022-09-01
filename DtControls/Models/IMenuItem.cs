namespace DtControls.Models;

public class DtMenuItem
#if MACCATALYST
    : Foundation.NSObject
#endif
{
    public Guid id { get; set; }
    public MenuType menuType { get; set; }
    public List<DtMenuItem> childrenItems { get; set; }
    public string title { get; set; }
    public string subTitle { get; set; }
    public ImageSource iconImage { get; set; }
    public string toolTip { get; set; }
    public Type screen { get; set; }

    public enum MenuType
    {
        Header,
        ExpandableRow,
        Row,
        Footer
    }
}

