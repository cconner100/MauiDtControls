
namespace DtControls.UserControls;

using Microsoft.Maui.Graphics;

/// <summary>
/// 
/// </summary>
[ContentProperty("Content")]
public partial class DtWindowTabItemView : View, IContentView, IDtWindowTabItemView
{
    /// <summary>
    /// 
    /// </summary>
    public DtWindowTabItemView()
    {

    }

    #region Properties

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(string), typeof(DtWindowTabItemView));
    
    /// <summary>
    /// 
    /// </summary>
    public string Header 
    {
        get { return (string)GetValue(HeaderProperty); }
        set { SetValue(HeaderProperty, value); }
    }


    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IconSourceProperty = BindableProperty.Create("IconSource", typeof(object), typeof(DtWindowTabItemView));
    
    /// <summary>
    /// 
    /// </summary>
    public object IconSource
    {
        get { return GetValue(IconSourceProperty); }
        set { SetValue(IconSourceProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty IsClosableProperty = BindableProperty.Create("IsClosable", typeof(bool), typeof(DtWindowTabItemView));
    
    /// <summary>
    /// 
    /// </summary>
    public bool IsClosable
    {
        get { return (bool)GetValue(IsClosableProperty); }
        set { SetValue(IsClosableProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtWindowTabItemView));
    
    /// <summary>
    /// 
    /// </summary>
    public object Content
    {
        get { return GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly BindableProperty PlatformObjectProperty = BindableProperty.Create("PlatformObject", typeof(object), typeof(DtWindowTabItemView));
    
    /// <summary>
    /// 
    /// </summary>
    public object PlatformObject
    {
        get { return GetValue(PlatformObjectProperty); }
        set { }
    }

    #endregion

    #region Events

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler CloseRequested;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public void WinCloseRequested(object sender, object args)
    {
        CloseRequested?.Invoke(sender, (EventArgs)args);
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
#nullable disable
    /// <summary>
    /// 
    /// </summary>
    public Thickness Padding
    {
        get;
        set;
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
}
