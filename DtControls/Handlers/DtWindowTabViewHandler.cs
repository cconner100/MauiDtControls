
namespace DtControls.Handlers
{
    using DtControls.UserControls;


    public partial class DtWindowTabViewHandler
    {
        public static IPropertyMapper<IDtWindowTabView, IDtWindowTabViewHandler> DtWindowTabViewPropertyMapper => new PropertyMapper<IDtWindowTabView, IDtWindowTabViewHandler>()
        {
            [nameof(IDtWindowTabView.AddTabButtonCommand)] = MapAddTabButtonCommand,
            [nameof(IDtWindowTabView.AddTabButtonCommandParameter)] = MapAddTabButtonCommandParameter,
            [nameof(IDtWindowTabView.AllowDropTabs)] = MapAllowDropTabs,
            [nameof(IDtWindowTabView.CanDragTabs)] = MapCanDragTabs,
            [nameof(IDtWindowTabView.CanReorderTabs)] = MapCanReorderTabs,
            [nameof(IDtWindowTabView.CloseButtonOverlayMode)] = MapCloseButtonOverlayMode,
            [nameof(IDtWindowTabView.IsAddTabButtonVisible)] = MapIsAddTabButtonVisible,
            [nameof(IDtWindowTabView.SelectedIndex)] = MapSelectedIndex,
            [nameof(IDtWindowTabView.SelectedItem)] = MapSelectedItem,
            [nameof(IDtWindowTabView.TabItems)] = MapTabItems,
            [nameof(IDtWindowTabView.TabItemsSource)] = MapTabItemsSource,
            [nameof(IDtWindowTabView.TabStripFooter)] = MapTabStripFooter,
            [nameof(IDtWindowTabView.TabWidthMode)] = MapTabWidthMode,
        };

        public static CommandMapper<IDtWindowTabView, IDtWindowTabViewHandler> DtWindowTabViewCommandMapper => new CommandMapper<IDtWindowTabView, IDtWindowTabViewHandler>();

        public DtWindowTabViewHandler() : base(DtWindowTabViewPropertyMapper, DtWindowTabViewCommandMapper)
        {

        }

        public DtWindowTabViewHandler(IPropertyMapper mapper = null) : base(mapper ?? DtWindowTabViewPropertyMapper, DtWindowTabViewCommandMapper)
        {
        }
    }

}
