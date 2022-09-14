namespace DtControls.Models;

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
}

