namespace DtControls.Handlers;

using DtControls.UserControls;
/// <summary>
/// Desktop Window Tab Item
/// </summary>
public partial class DtWindowTabItemHandler 
{
    /// <summary>
    /// 
    /// </summary>
    public static IPropertyMapper<IDtWindowTabItem, IDtWindowTabItemHandler> DtWindowTabItemViewPropertyMapper => new PropertyMapper<IDtWindowTabItem, IDtWindowTabItemHandler>()
    {
        [nameof(DtWindowTabItem.Header)] = MapHeader,
        [nameof(DtWindowTabItem.IconSource)] = MapIconSource,
        [nameof(DtWindowTabItem.IsClosable)] = MapIsClosable,
        [nameof(DtWindowTabItem.PlatformObject)] = MapPlatformObject,
        [nameof(IContentView.Content)] = MapContent,
    };


    /// <summary>
    /// 
    /// </summary>
    public static CommandMapper<IDtWindowTabItem, IDtWindowTabItemHandler> DtWindowTabItemViewCommandMapper => new CommandMapper<IDtWindowTabItem, IDtWindowTabItemHandler>();
    /// <summary>
    /// 
    /// </summary>
    public DtWindowTabItemHandler() : base(DtWindowTabItemViewPropertyMapper, DtWindowTabItemViewCommandMapper)
    {

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="mapper"></param>
    public DtWindowTabItemHandler(IPropertyMapper mapper = null) : base(mapper ?? DtWindowTabItemViewPropertyMapper, DtWindowTabItemViewCommandMapper)
    {
    }
}
