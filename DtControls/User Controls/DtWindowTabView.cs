

namespace DtControls.UserControls;

using Microsoft.Maui.Graphics;

using System.Collections.ObjectModel;

/// <summary>
/// 
/// </summary>
[ContentProperty("Content")]
public partial class DtWindowTabView : View, IContentView, IDtWindowTabView
{
    /// <summary>
    /// 
    /// </summary>
    public enum CloseButtonOverlayModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Always,

        /// <summary>
        /// 
        /// </summary>
        Auto,

        /// <summary>
        /// 
        /// </summary>
        OnPointerOver
    };

    /// <summary>
    /// 
    /// </summary>
    public enum TabWidthModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Compact,

        /// <summary>
        /// 
        /// </summary>
        Equal,

        /// <summary>
        /// 
        /// </summary>
        SizeToContent
    }


    /// <summary>
    /// 
    /// </summary>
    public DtWindowTabView()
    {

    }

    #region Events

    /// <summary>
    /// 
    /// </summary>
    public new event EventHandler Loaded;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler AddTabButtonClick;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler SelectionChanged;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler TabCloseRequested;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler TabDragCompleted;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler TabDragStarting;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler TabDroppedOutSide;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler TabItemsChanged;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler TabStripDragOver;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler TabStripDrop;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>

    public void WinLoaded(object sender, object args)
    {
        Loaded?.Invoke(sender, null);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinAddTabButtonClick(object sender, object args)
    {
        AddTabButtonClick?.Invoke(sender, null);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinSelectionChanged(object sender, object args)
    {
        SelectionChanged?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinTabCloseRequested(object sender, object args)
    {
        TabCloseRequested?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinTabDragCompleted(object sender, object args)
    {
        TabDragCompleted?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinTabDragStarting(object sender, object args)
    {
        TabDragStarting?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinTabDroppedOutSide(object sender, object args)
    {
        TabDroppedOutSide?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinTabItemsChanged(object sender, object args)
    {
        TabItemsChanged?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinTabStripDragOver(object sender, object args)
    {
        TabStripDragOver?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinTabStripDrop(object sender, object args)
    {
        TabStripDrop?.Invoke(sender, (EventArgs)args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="widthConstraint"></param>
    /// <param name="heightConstraint"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bounds"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Size CrossPlatformArrange(Rect bounds)
    {
        throw new NotImplementedException();
    }
    #endregion


    #region Properties

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty AddTabButtonCommandProperty = BindableProperty.Create("AddTabButtonCommand", typeof(object), typeof(DtWindowTabView));
    
    /// <summary>
    /// 
    /// </summary>
    public object AddTabButtonCommand { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty AddTabButtonCommandParameterProperty = BindableProperty.Create("AddTabButtonCommandParameter", typeof(object), typeof(DtWindowTabView));
    
    /// <summary>
    /// 
    /// </summary>
    public object AddTabButtonCommandParameter { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty AllowDropTabsProperty = BindableProperty.Create("AllowDropTabs", typeof(bool), typeof(DtWindowTabView), true);
    
    /// <summary>
    /// 
    /// </summary>
    public bool AllowDropTabs { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty CanDragTabsProperty = BindableProperty.Create("CanDragTabs", typeof(bool), typeof(DtWindowTabView), false);
    
    /// <summary>
    /// 
    /// </summary>
    public bool CanDragTabs { get; set; } = false;

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty CanReorderTabsProperty = BindableProperty.Create("CanReorderTabs", typeof(bool), typeof(DtWindowTabView), true);
    
    /// <summary>
    /// 
    /// </summary>
    public bool CanReorderTabs { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty CloseButtonOverlayModeProperty = BindableProperty.Create("CloseButtonOverlayMode", typeof(CloseButtonOverlayModeEnum), typeof(DtWindowTabView), CloseButtonOverlayModeEnum.Auto);
    
    /// <summary>
    /// 
    /// </summary>
    public CloseButtonOverlayModeEnum CloseButtonOverlayMode { get; set; } = CloseButtonOverlayModeEnum.Auto;

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsAddTabButtonVisibleProperty = BindableProperty.Create("IsAddTabButtonVisible", typeof(bool), typeof(DtWindowTabView), true);
    
    /// <summary>
    /// 
    /// </summary>
    public bool IsAddTabButtonVisible { get; set; } = true;

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create("SelectedIndex", typeof(int), typeof(DtWindowTabView));
    
    /// <summary>
    /// 
    /// </summary>
    public int SelectedIndex { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(DtWindowTabView));
    
    /// <summary>
    /// 
    /// </summary>
    public object SelectedItem { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty TabItemsProperty = BindableProperty.Create("TabItems", typeof(ObservableCollection<object>), typeof(DtWindowTabView));
    
    /// <summary>
    /// 
    /// </summary>
    public ObservableCollection<DtWindowTabItem1> TabItems { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty TabItemsSourceProperty = BindableProperty.Create("TabItemsSource", typeof(object), typeof(DtWindowTabView));
    
    /// <summary>
    /// 
    /// </summary>
    public object TabItemsSource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty TabStripFooterProperty = BindableProperty.Create("TabStripFooter", typeof(object), typeof(DtWindowTabView));
    
    /// <summary>
    /// 
    /// </summary>
    public object TabStripFooter { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty TabWidthModeProperty = BindableProperty.Create("TabWidthModeEnum", typeof(object), typeof(DtWindowTabView), TabWidthModeEnum.Equal);
    
    /// <summary>
    /// 
    /// </summary>
    public TabWidthModeEnum TabWidthMode { get; set; } = TabWidthModeEnum.Equal;

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtNavigationView));
    
    /// <summary>
    /// 
    /// </summary>
    public object Content
    {
        get { return (View)GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }
    #endregion

#nullable enable
    /// <summary>
    /// 
    /// </summary>
    object? IContentView.Content => Content;

    /// <summary>
    /// 
    /// </summary>
    IView? IContentView.PresentedContent => (View)Content;

    /// <summary>
    /// 
    /// </summary>
    public Thickness Padding { get; }
#nullable disable
}
