

namespace DtControls.Controls;

using DtControls.Models;

using Microsoft.Maui.Graphics;

using System.Collections.ObjectModel;


[ContentProperty("Content")]
public partial class DtWindowTabs : View, IContentView, IDtWindowTabs
{
    public enum CloseButtonOverlayModeEnum
    {
        Always,
        Auto,
        OnPointerOver
    };

    public enum TabWidthModeEnum
    {
        Compact,
        Equal,
        SizeToContent
    }


    public DtWindowTabs()
    {

    }

    #region Events

    public new event EventHandler Loaded;

    public event EventHandler AddTabButtonClick;

    public event EventHandler SelectionChanged;

    public event EventHandler<DtTabWindowItemCloseRequestEventArgs> TabCloseRequested;

    public event EventHandler TabDragCompleted;

    public event EventHandler TabDragStarting;

    public event EventHandler TabDroppedOutSide;

    public event EventHandler TabItemsChanged;

    public event EventHandler TabStripDragOver;

    public event EventHandler TabStripDrop;

    public void HandleLoaded(object sender, object args)
    {
        Loaded?.Invoke(sender, null);
    }

    public void HandleAddTabButtonClick(object sender, object args)
    {
        AddTabButtonClick?.Invoke(sender, null);
    }


    public void HandleSelectionChanged(object sender, object args)
    {
        SelectionChanged?.Invoke(sender, (EventArgs)args);
    }

    public void HandleTabCloseRequested(object sender, DtTabWindowItemCloseRequestEventArgs args)
    {
        TabCloseRequested?.Invoke(sender, args);
    }

    public void HandleTabDragCompleted(object sender, object args)
    {
        TabDragCompleted?.Invoke(sender, (EventArgs)args);
    }

    public void HandleTabDragStarting(object sender, object args)
    {
        TabDragStarting?.Invoke(sender, (EventArgs)args);
    }

    public void HandleTabDroppedOutSide(object sender, object args)
    {
        TabDroppedOutSide?.Invoke(sender, (EventArgs)args);
    }

    public void HandleTabItemsChanged(object sender, object args)
    {
        TabItemsChanged?.Invoke(sender, (EventArgs)args);
    }

    public void HandleTabStripDragOver(object sender, object args)
    {
        TabStripDragOver?.Invoke(sender, (EventArgs)args);
    }

    public void HandleTabStripDrop(object sender, object args)
    {
        TabStripDrop?.Invoke(sender, (EventArgs)args);
    }

    public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }

    public Size CrossPlatformArrange(Rect bounds)
    {
        throw new NotImplementedException();
    }
    #endregion


    #region Properties

    public static readonly BindableProperty AddTabButtonCommandProperty = BindableProperty.Create("AddTabButtonCommand", typeof(object), typeof(DtWindowTabs));

    public object AddTabButtonCommand { get; set; }

    public static readonly BindableProperty AddTabButtonCommandParameterProperty = BindableProperty.Create("AddTabButtonCommandParameter", typeof(object), typeof(DtWindowTabs));

    public object AddTabButtonCommandParameter { get; set; }

    public static readonly BindableProperty AllowDropTabsProperty = BindableProperty.Create("AllowDropTabs", typeof(bool), typeof(DtWindowTabs), true);

    public bool AllowDropTabs { get; set; } = true;

    public static readonly BindableProperty CanDragTabsProperty = BindableProperty.Create("CanDragTabs", typeof(bool), typeof(DtWindowTabs), false);

    public bool CanDragTabs { get; set; } = false;

    public static readonly BindableProperty CanReorderTabsProperty = BindableProperty.Create("CanReorderTabs", typeof(bool), typeof(DtWindowTabs), true);

    public bool CanReorderTabs { get; set; } = true;

    public static readonly BindableProperty CloseButtonOverlayModeProperty = BindableProperty.Create("CloseButtonOverlayMode", typeof(CloseButtonOverlayModeEnum), typeof(DtWindowTabs), CloseButtonOverlayModeEnum.Auto);

    public CloseButtonOverlayModeEnum CloseButtonOverlayMode { get; set; } = CloseButtonOverlayModeEnum.Auto;

    public static readonly BindableProperty IsAddTabButtonVisibleProperty = BindableProperty.Create("IsAddTabButtonVisible", typeof(bool), typeof(DtWindowTabs), true);

    public bool IsAddTabButtonVisible { get; set; } = true;

    public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create("SelectedIndex", typeof(int), typeof(DtWindowTabs));

    public int SelectedIndex { get; set; }

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(DtWindowTabs));

    public object SelectedItem { get; set; }

    public static readonly BindableProperty TabItemsProperty = BindableProperty.Create("TabItems", typeof(ObservableCollection<object>), typeof(DtWindowTabs));

    public ObservableCollection<DtWindowTabItem> TabItems { get; set; }

    public static readonly BindableProperty TabItemsSourceProperty = BindableProperty.Create("TabItemsSource", typeof(object), typeof(DtWindowTabs));

    public object TabItemsSource { get; set; }

    public static readonly BindableProperty TabStripFooterProperty = BindableProperty.Create("TabStripFooter", typeof(object), typeof(DtWindowTabs));

    public object TabStripFooter { get; set; }

    public static readonly BindableProperty TabWidthModeProperty = BindableProperty.Create("TabWidthModeEnum", typeof(object), typeof(DtWindowTabs), TabWidthModeEnum.Equal);

    public TabWidthModeEnum TabWidthMode { get; set; } = TabWidthModeEnum.Equal;

    public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtNavigation));

    public object Content
    {
        get { return (View)GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }
    #endregion

#nullable enable

    object? IContentView.Content => Content;

    IView? IContentView.PresentedContent => (View)Content;

    public Thickness Padding { get; }
#nullable disable
}
