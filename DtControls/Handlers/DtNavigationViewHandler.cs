namespace DtControls.Handlers
{
    using DtControls.UserControls;


    public partial class DtNavigationViewHandler //: IZtNavigationViewHandler
    {

        public static IPropertyMapper<IDtNavigationView, IDtNavigationViewHandler> DtNavigationViewMapper => new PropertyMapper<IDtNavigationView, IDtNavigationViewHandler>()
        {
            [nameof(DtNavigationView.Header)] = MapHeader,
            [nameof(DtNavigationView.AlwaysShowHeader)] = MapAlwaysShowHeader,
            [nameof(DtNavigationView.IsBackButtonVisable)] = MapIsBackButtonVisable,
            [nameof(DtNavigationView.IsBackButtonEnabled)] = MapBackButtonEnabled,
            [nameof(DtNavigationView.CompactModeThresholdWidth)] = MapCompactModeThresholdWidth,
            [nameof(DtNavigationView.CompactPaneLength)] = MapCompactPaneLength,
            [nameof(IContentView.Content)] = MapContent,
            [nameof(DtNavigationView.DisplayMode)] = MapDisplayMode,
            [nameof(DtNavigationView.ExpandedModeThresholdWidth)] = MapExpandedModeThresholdWidth,
            //[nameof(ZtNavigationView.FooterMenuItems)] = MapFooterMenuItems,
            [nameof(DtNavigationView.FooterMenuItemsSource)] = MapFooterMenuItemsSource,
            //[nameof(ZtNavigationView.HeaderTemplate)] = MapHeaderTemplate,
            [nameof(DtNavigationView.IsPaneOpen)] = MapIsPaneOpen,
            [nameof(DtNavigationView.IsPaneToggleButtonVisible)] = MapIsPaneToggleButtonVisible,
            [nameof(DtNavigationView.IsSettingsVisible)] = MapIsSettingsVisible,
            [nameof(DtNavigationView.IsTitleBarAutoPaddingEnabled)] = MapIsTitleBarAutoPaddingEnabled,
            //[nameof(ZtNavigationView.MenuItemContainerStyle)] = MapMenuItemContainerStyle,
            [nameof(DtNavigationView.MenuItems)] = MapMenuItems,
            [nameof(DtNavigationView.MenuItemsSource)] = MapMenuItemsSource,
            //[nameof(ZtNavigationView.MenuItemsTemplate)] = MapMenuItemsTemplate,
            [nameof(DtNavigationView.OpenPaneLength)] = MapOpenPaneLength,
            [nameof(DtNavigationView.OverflowLabelMode)] = MapOverflowLabelMode,
            [nameof(DtNavigationView.PaneDisplayMode)] = MapPaneDisplayMode,
            [nameof(DtNavigationView.SelectedItem)] = MapSelectedItem,
        };

        public static CommandMapper<IDtNavigationView, IDtNavigationViewHandler> DtNavigationViewCommandMapper => new CommandMapper<IDtNavigationView, IDtNavigationViewHandler>();

        public DtNavigationViewHandler() : base(DtNavigationViewMapper, DtNavigationViewCommandMapper)
        {

        }

        public DtNavigationViewHandler(IPropertyMapper mapper = null) : base(mapper ?? DtNavigationViewMapper, DtNavigationViewCommandMapper)
        {
        }
    }
}
