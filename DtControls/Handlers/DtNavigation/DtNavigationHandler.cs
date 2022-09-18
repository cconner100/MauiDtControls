namespace DtControls.Handlers;

using DtControls.Controls;

public partial class DtNavigationHandler 
{

    public static IPropertyMapper<IDtNavigation, IDtNavigationHandler> DtNavigationMapper => new PropertyMapper<IDtNavigation, IDtNavigationHandler>()
    {
        [nameof(DtNavigation.Header)] = MapHeader,
        [nameof(DtNavigation.AlwaysShowHeader)] = MapAlwaysShowHeader,
        [nameof(DtNavigation.AutoSuggestBox)] = MapAutoSuggestBox,
        [nameof(DtNavigation.IsBackButtonVisible)] = MapIsBackButtonVisable,
        [nameof(DtNavigation.IsBackButtonEnabled)] = MapBackButtonEnabled,
        [nameof(DtNavigation.CompactModeThresholdWidth)] = MapCompactModeThresholdWidth,
        [nameof(DtNavigation.CompactPaneLength)] = MapCompactPaneLength,
        [nameof(IContentView.Content)] = MapContent,
        [nameof(DtNavigation.DisplayMode)] = MapDisplayMode,
        [nameof(DtNavigation.ExpandedModeThresholdWidth)] = MapExpandedModeThresholdWidth,
        [nameof(DtNavigation.FooterMenuItems)] = MapFooterMenuItems,
        [nameof(DtNavigation.FooterMenuItemsSource)] = MapFooterMenuItemsSource,
        //[nameof(ZtNavigationView.HeaderTemplate)] = MapHeaderTemplate,
        [nameof(DtNavigation.IsPaneOpen)] = MapIsPaneOpen,
        [nameof(DtNavigation.IsPaneToggleButtonVisible)] = MapIsPaneToggleButtonVisible,
        [nameof(DtNavigation.IsSettingsVisible)] = MapIsSettingsVisible,
        [nameof(DtNavigation.IsTitleBarAutoPaddingEnabled)] = MapIsTitleBarAutoPaddingEnabled,
        //[nameof(ZtNavigationView.MenuItemContainerStyle)] = MapMenuItemContainerStyle,
        [nameof(DtNavigation.MenuItems)] = MapMenuItems,
        [nameof(DtNavigation.MenuItemsSource)] = MapMenuItemsSource,
        //[nameof(ZtNavigationView.MenuItemsTemplate)] = MapMenuItemsTemplate,
        [nameof(DtNavigation.OpenPaneLength)] = MapOpenPaneLength,
        [nameof(DtNavigation.OverflowLabelMode)] = MapOverflowLabelMode,
        [nameof(DtNavigation.PaneDisplayMode)] = MapPaneDisplayMode,
        [nameof(DtNavigation.SelectedItem)] = MapSelectedItem,
    };

    public static CommandMapper<IDtNavigation, IDtNavigationHandler> DtNavigationCommandMapper => new CommandMapper<IDtNavigation, IDtNavigationHandler>();


    public DtNavigationHandler() : base(DtNavigationMapper, DtNavigationCommandMapper)
    {

    }

    public DtNavigationHandler(IPropertyMapper mapper = null) : base(mapper ?? DtNavigationMapper, DtNavigationCommandMapper)
    {
    }
}
