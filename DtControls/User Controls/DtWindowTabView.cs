

namespace DtControls.UserControls
{
    using Microsoft.Maui.Graphics;

    public partial class DtWindowTabView : View, IContentView, IDtWindowTabView
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

        public DtWindowTabView()
        {

        }

        #region Events
        public new event EventHandler Loaded;
        public event EventHandler AddTabButtonClick;
        public event EventHandler SelectionChanged;
        public event EventHandler TabCloseRequested;
        public event EventHandler TabDragCompleted;
        public event EventHandler TabDragStarting;
        public event EventHandler TabDroppedOutSide;
        public event EventHandler TabItemsChanged;
        public event EventHandler TabStripDragOver;
        public event EventHandler TabStripDrop;

        public void WinLoaded(object sender, object args)
        {
            Loaded?.Invoke(sender, null);
        }

        public void WinAddTabButtonClick(object sender, object args)
        {
            AddTabButtonClick?.Invoke(sender, (EventArgs)args);
        }
        public void WinSelectionChanged(object sender, object args)
        {
            SelectionChanged?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabCloseRequested(object sender, object args)
        {
            TabCloseRequested?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabDragCompleted(object sender, object args)
        {
            TabDragCompleted?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabDragStarting(object sender, object args)
        {
            TabDragStarting?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabDroppedOutSide(object sender, object args)
        {
            TabDroppedOutSide?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabItemsChanged(object sender, object args)
        {
            TabItemsChanged?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabStripDragOver(object sender, object args)
        {
            TabStripDragOver?.Invoke(sender, (EventArgs)args);
        }
        public void WinTabStripDrop(object sender, object args)
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

        public static readonly BindableProperty AddTabButtonCommandProperty = BindableProperty.Create("AddTabButtonCommand", typeof(object), typeof(DtWindowTabView));
        public object AddTabButtonCommand { get; set; }

        public static readonly BindableProperty AddTabButtonCommandParameterProperty = BindableProperty.Create("AddTabButtonCommandParameter", typeof(object), typeof(DtWindowTabView));
        public object AddTabButtonCommandParameter { get; set; }

        public static readonly BindableProperty AllowDropTabsProperty = BindableProperty.Create("AllowDropTabs", typeof(bool), typeof(DtWindowTabView), true);
        public bool AllowDropTabs { get; set; } = true;

        public static readonly BindableProperty CanDragTabsProperty = BindableProperty.Create("CanDragTabs", typeof(bool), typeof(DtWindowTabView), false);
        public bool CanDragTabs { get; set; } = false;

        public static readonly BindableProperty CanReorderTabsProperty = BindableProperty.Create("CanReorderTabs", typeof(bool), typeof(DtWindowTabView), true);
        public bool CanReorderTabs { get; set; } = true;

        public static readonly BindableProperty CloseButtonOverlayModeProperty = BindableProperty.Create("CloseButtonOverlayMode", typeof(CloseButtonOverlayModeEnum), typeof(DtWindowTabView), CloseButtonOverlayModeEnum.Auto);
        public CloseButtonOverlayModeEnum CloseButtonOverlayMode { get; set; } = CloseButtonOverlayModeEnum.Auto;

        public static readonly BindableProperty IsAddTabButtonVisibleProperty = BindableProperty.Create("IsAddTabButtonVisible", typeof(bool), typeof(DtWindowTabView), true);
        public bool IsAddTabButtonVisible { get; set; } = true;

        public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create("SelectedIndex", typeof(int), typeof(DtWindowTabView));
        public int SelectedIndex { get; set; }

        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(DtWindowTabView));
        public object SelectedItem { get; set; }

        public static readonly BindableProperty TabItemsProperty = BindableProperty.Create("TabItems", typeof(IList<object>), typeof(DtWindowTabView));
        public IList<object> TabItems { get; set; }

        public static readonly BindableProperty TabItemsSourceProperty = BindableProperty.Create("TabItemsSource", typeof(object), typeof(DtWindowTabView));
        public object TabItemsSource { get; set; }

        public static readonly BindableProperty TabStripFooterProperty = BindableProperty.Create("TabStripFooter", typeof(object), typeof(DtWindowTabView));
        public object TabStripFooter { get; set; }

        public static readonly BindableProperty TabWidthModeProperty = BindableProperty.Create("TabWidthModeEnum", typeof(object), typeof(DtWindowTabView), TabWidthModeEnum.Equal);
        public TabWidthModeEnum TabWidthMode { get; set; } = TabWidthModeEnum.Equal;

        public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtNavigationView));
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
}
