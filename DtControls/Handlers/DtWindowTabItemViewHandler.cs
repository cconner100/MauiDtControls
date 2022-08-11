namespace DtControls.Handlers;

using DtControls.UserControls;
/// <summary>
/// Desktop Window Tab Item
/// </summary>
public partial class DtWindowTabItemViewHandler 
{
    /// <summary>
    /// 
    /// </summary>
    public static IPropertyMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler> DtWindowTabItemViewPropertyMapper => new PropertyMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler>()
    {
        [nameof(DtWindowTabItemView.Header)] = MapHeader,
        [nameof(DtWindowTabItemView.IconSource)] = MapIconSource,
        [nameof(DtWindowTabItemView.IsClosable)] = MapIsClosable,
        [nameof(DtWindowTabItemView.PlatformObject)] = MapPlatformObject,
        [nameof(IContentView.Content)] = MapContent,
    };

    /// <summary>
    /// 
    /// </summary>
    public static CommandMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler> DtWindowTabItemViewCommandMapper => new CommandMapper<IDtWindowTabItemView, IDtWindowTabItemViewHandler>();
    /// <summary>
    /// 
    /// </summary>
    public DtWindowTabItemViewHandler() : base(DtWindowTabItemViewPropertyMapper, DtWindowTabItemViewCommandMapper)
    {

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="mapper"></param>
    public DtWindowTabItemViewHandler(IPropertyMapper mapper = null) : base(mapper ?? DtWindowTabItemViewPropertyMapper, DtWindowTabItemViewCommandMapper)
    {
    }
}
