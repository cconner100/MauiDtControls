
namespace DtControls.Handlers;

using DtControls.Controls;

/// <summary>
/// 
/// </summary>
public partial class DtWindowTabsHandler
{

    public static IPropertyMapper<IDtWindowTabs, IDtWindowTabsHandler> DtWindowTabViewPropertyMapper => new PropertyMapper<IDtWindowTabs, IDtWindowTabsHandler>()
    {
        [nameof(IDtWindowTabs.AddTabButtonCommand)] = MapAddTabButtonCommand,
        [nameof(IDtWindowTabs.AddTabButtonCommandParameter)] = MapAddTabButtonCommandParameter,
        [nameof(IDtWindowTabs.AllowDropTabs)] = MapAllowDropTabs,
        [nameof(IDtWindowTabs.CanDragTabs)] = MapCanDragTabs,
        [nameof(IDtWindowTabs.CanReorderTabs)] = MapCanReorderTabs,
        [nameof(IDtWindowTabs.CloseButtonOverlayMode)] = MapCloseButtonOverlayMode,
        [nameof(IDtWindowTabs.IsAddTabButtonVisible)] = MapIsAddTabButtonVisible,
        [nameof(IDtWindowTabs.SelectedIndex)] = MapSelectedIndex,
        [nameof(IDtWindowTabs.SelectedItem)] = MapSelectedItem,
        [nameof(IDtWindowTabs.TabItems)] = MapTabItems,
        [nameof(IDtWindowTabs.TabItemsSource)] = MapTabItemsSource,
        [nameof(IDtWindowTabs.TabStripFooter)] = MapTabStripFooter,
        [nameof(IDtWindowTabs.TabWidthMode)] = MapTabWidthMode,
    };

    public static CommandMapper<IDtWindowTabs, IDtWindowTabsHandler> DtWindowTabViewCommandMapper => new CommandMapper<IDtWindowTabs, IDtWindowTabsHandler>();

    public DtWindowTabsHandler() : base(DtWindowTabViewPropertyMapper, DtWindowTabViewCommandMapper)
    {

    }

    public DtWindowTabsHandler(IPropertyMapper mapper = null) : base(mapper ?? DtWindowTabViewPropertyMapper, DtWindowTabViewCommandMapper)
    {
    }
}

