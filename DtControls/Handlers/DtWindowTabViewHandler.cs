
namespace DtControls.Handlers
{
    using DtControls.UserControls;

    /// <summary>
    /// 
    /// </summary>
    public partial class DtWindowTabViewHandler
    {
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        public static CommandMapper<IDtWindowTabView, IDtWindowTabViewHandler> DtWindowTabViewCommandMapper => new CommandMapper<IDtWindowTabView, IDtWindowTabViewHandler>();
        /// <summary>
        /// 
        /// </summary>
        public DtWindowTabViewHandler() : base(DtWindowTabViewPropertyMapper, DtWindowTabViewCommandMapper)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        public DtWindowTabViewHandler(IPropertyMapper mapper = null) : base(mapper ?? DtWindowTabViewPropertyMapper, DtWindowTabViewCommandMapper)
        {
        }
    }
}

