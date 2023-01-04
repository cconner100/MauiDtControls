

namespace DtControls.Controls;

using DtControls.Models;

using Microsoft.Maui.Graphics;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using static DtControls.Models.DtWindowTabsDragEventArgs;

[ContentProperty("Content")]
public partial class DtWindowTabs : View, IContentView, IDtWindowTabs
{
    public enum CloseButtonOverlayModeEnum
    {
        Always,
        Auto,
        OnPointerOver
    }

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

    public new event EventHandler? Loaded;

    public event EventHandler? AddTabButtonClick;

    public event EventHandler<DtWindowTabsSelectionChangedEventArgs>? SelectionChanged;

    public event EventHandler<DtWindowTabItemCloseRequestEventArgs>? TabCloseRequested;

    public event EventHandler<DtWindowTabsItemDragCompletedEventArgs>? TabDragCompleted;

    public event EventHandler<DtWindowTabsDragStartingEventArgs>? TabDragStarting;

    public event EventHandler<DtWindowTabsDroppedOutsideEventArgs>? TabDroppedOutSide;

    public event EventHandler<DtWindowTabsItemsChangedEventArgs>? TabItemsChanged;

    public event EventHandler<DtWindowTabsStripDragOverEventArgs>? TabStripDragOver;

    public event EventHandler<DtWindowTabsStripDropEventArgs>? TabStripDrop;

    public void HandleLoaded(object sender, object args)
    {
        Loaded?.Invoke(sender, null!);
    }

    public void HandleAddTabButtonClick(object sender, object args)
    {
        AddTabButtonClick?.Invoke(sender, null!);
    }


    public void HandleSelectionChanged(object sender, DtWindowTabsSelectionChangedEventArgs args)
    {
        SelectionChanged?.Invoke(sender, args);
    }

    public void HandleTabCloseRequested(object sender, DtWindowTabItemCloseRequestEventArgs args)
    {
        TabCloseRequested?.Invoke(sender, args);
    }

    public void HandleTabDragCompleted(object sender, DtWindowTabsItemDragCompletedEventArgs args)
    {
        TabDragCompleted?.Invoke(sender, args);
    }

    public void HandleTabDragStarting(object sender, DtWindowTabsDragStartingEventArgs args)
    {
        TabDragStarting?.Invoke(sender, args);
    }

    public void HandleTabDroppedOutSide(object sender, DtWindowTabsDroppedOutsideEventArgs args)
    {
        TabDroppedOutSide?.Invoke(sender, args);
    }

    public void HandleTabItemsChanged(object sender, DtWindowTabsItemsChangedEventArgs args)
    {
        TabItemsChanged?.Invoke(sender, args);
    }

    public void HandleTabStripDragOver(object sender, DtWindowTabsStripDragOverEventArgs args)
    {
        TabStripDragOver?.Invoke(sender, args);
    }

    public void HandleTabStripDrop(object sender, DtWindowTabsStripDropEventArgs args)
    {
        TabStripDrop?.Invoke(sender, args);
    }

    public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }

    public Size CrossPlatformArrange(Rect bounds)
    {
        throw new NotImplementedException();
    }

    public void InsertPageBefore(Page page, Page before)
    {
        Navigation.InsertPageBefore(page, before);
    }

    public async Task<Page> PopAsync()
    {
        return await PopAsync(false).ConfigureAwait(true);
    }

    public async Task<Page> PopAsync(bool animated)
    {
        return await Navigation.PopAsync(animated).ConfigureAwait(true);
    }

    public async Task<Page> PopModalAsync()
    {
        return await PopModalAsync(false).ConfigureAwait(true);
    }

    public async Task<Page> PopModalAsync(bool animated)
    {
        return await Navigation.PopModalAsync(animated).ConfigureAwait(true);
    }

    public async Task PopToRootAsync()
    {
        await PopToRootAsync(false).ConfigureAwait(true);
    }

    public async Task PopToRootAsync(bool animated)
    {
        await Navigation.PopToRootAsync(animated).ConfigureAwait(true);
    }

    public async Task PushAsync(Page page)
    {
        await PushAsync(page, false).ConfigureAwait(true);
    }

    public async Task PushAsync(Page page, bool animated)
    {
        await Navigation.PushAsync(page, animated).ConfigureAwait(true);
        // check to see if back button is enabled

    }

    public async Task PushModalAsync(Page page)
    {
        await PushModalAsync(page, false).ConfigureAwait(true);
    }

    public async Task PushModalAsync(Page page, bool animated)
    {
        await Navigation.PushModalAsync(page, animated).ConfigureAwait(true);
    }

    public void RemovePage(Page page)
    {
        Navigation.RemovePage(page);
    }
    #endregion


    #region Properties

    public static readonly BindableProperty AddTabButtonCommandProperty = BindableProperty.Create(nameof(AddTabButtonCommand), typeof(object), typeof(DtWindowTabs));

    public object AddTabButtonCommand
    {
        get
        {
            return GetValue(AddTabButtonCommandProperty);
        }
        set
        {
            SetValue(AddTabButtonCommandProperty, value);
        }
    }

    public static readonly BindableProperty AddTabButtonCommandParameterProperty = BindableProperty.Create(nameof(AddTabButtonCommandParameter), typeof(object), typeof(DtWindowTabs));

    public object AddTabButtonCommandParameter
    {
        get
        {
            return GetValue(AddTabButtonCommandParameterProperty);
        }
        set
        {
            SetValue(AddTabButtonCommandParameterProperty, value);
        }
    }

    public static readonly BindableProperty AllowDropTabsProperty = BindableProperty.Create(nameof(AllowDropTabs), typeof(bool), typeof(DtWindowTabs), true);

    public bool AllowDropTabs
    {
        get
        {
            return (bool)GetValue(AllowDropTabsProperty);
        }
        set
        {
            SetValue(AllowDropTabsProperty, value);
        }
    }

    public static readonly BindableProperty CanDragTabsProperty = BindableProperty.Create(nameof(CanDragTabs), typeof(bool), typeof(DtWindowTabs), false);

    public bool CanDragTabs
    {
        get
        {
            return (bool)GetValue(CanDragTabsProperty);
        }
        set
        {
            SetValue(CanDragTabsProperty, value);
        }
    }

    public static readonly BindableProperty CanReorderTabsProperty = BindableProperty.Create(nameof(CanReorderTabs), typeof(bool), typeof(DtWindowTabs), true);

    public bool CanReorderTabs
    {
        get
        {
            return (bool)GetValue(CanReorderTabsProperty);
        }
        set
        {
            SetValue(CanReorderTabsProperty, value);
        }
    }

    public static readonly BindableProperty CloseButtonOverlayModeProperty = BindableProperty.Create(nameof(CloseButtonOverlayMode), typeof(CloseButtonOverlayModeEnum), typeof(DtWindowTabs), CloseButtonOverlayModeEnum.Auto);

    public CloseButtonOverlayModeEnum CloseButtonOverlayMode
    {
        get
        {
            return (CloseButtonOverlayModeEnum)GetValue(CloseButtonOverlayModeProperty);
        }
        set
        {
            SetValue(CloseButtonOverlayModeProperty, value);
        }
    }

    public static readonly BindableProperty IsAddTabButtonVisibleProperty = BindableProperty.Create(nameof(IsAddTabButtonVisible), typeof(bool), typeof(DtWindowTabs), true);

    public bool IsAddTabButtonVisible
    {
        get
        {
            return (bool)GetValue(IsAddTabButtonVisibleProperty);
        }
        set
        {
            SetValue(IsAddTabButtonVisibleProperty, value);
        }
    }

    public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create(nameof(SelectedIndex), typeof(int), typeof(DtWindowTabs));

    public int SelectedIndex
    {
        get
        {
            return (int)GetValue(SelectedIndexProperty);
        }
        set
        {
            SetValue(SelectedIndexProperty, value);
        }
    }

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(nameof(SelectedItem), typeof(object), typeof(DtWindowTabs));

    public object SelectedItem
    {
        get
        {
            return GetValue(SelectedItemProperty);
        }
        set
        {
            SetValue(SelectedItemProperty, value);
        }
    }

    public static readonly BindableProperty TabItemsProperty = BindableProperty.Create(nameof(TabItems), typeof(ObservableCollection<DtWindowTabItem>), typeof(ObservableCollection<DtWindowTabItem>));

    public ObservableCollection<DtWindowTabItem> TabItems
    {
        get
        {
            return (ObservableCollection<DtWindowTabItem>)GetValue(TabItemsProperty);
        }
        set
        {
            SetValue(TabItemsProperty, value);
        }
    }

    public static readonly BindableProperty TabItemsSourceProperty = BindableProperty.Create(nameof(TabItemsSource), typeof(object), typeof(DtWindowTabs));

    public object TabItemsSource
    {
        get
        {
            return GetValue(TabItemsSourceProperty);
        }
        set
        {
            SetValue(TabItemsSourceProperty, value);
        }
    }

    public static readonly BindableProperty TabStripFooterProperty = BindableProperty.Create(nameof(TabStripFooter), typeof(object), typeof(DtWindowTabs));

    public object TabStripFooter
    {
        get
        {
            return GetValue(TabStripFooterProperty);
        }
        set
        {
            SetValue(TabStripFooterProperty, value);
        }
    }

    public static readonly BindableProperty TabWidthModeProperty = BindableProperty.Create("TabWidthModeEnum", typeof(object), typeof(DtWindowTabs), TabWidthModeEnum.Equal);

    public TabWidthModeEnum TabWidthMode
    {
        get
        {
            return (TabWidthModeEnum)GetValue(TabWidthModeProperty);
        }
        set
        {
            SetValue(TabWidthModeProperty, value);
        }
    }

    public static readonly BindableProperty ContentProperty = BindableProperty.Create(nameof(Content), typeof(object), typeof(DtNavigation));

    public object Content
    {
        get { return (View)GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }
    #endregion



    object? IContentView.Content => Content;

    IView? IContentView.PresentedContent => (View)Content;

    public Thickness Padding { get; }
    public IReadOnlyList<Page>? ModalStack { get; }
    public IReadOnlyList<Page>? NavigationStack { get; }

}
