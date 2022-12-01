
namespace DtControls.Controls;

using DtControls.Control;
using DtControls.Models;

#if WINDOWS
using Windows.Foundation;
#endif

using System;



[ContentProperty("Content")]
public partial class DtWindowTabItem : View, IContentView, IElement, IDtWindowTabItem, IDisposable
{
    public DtWindowTabItem()
    {
        Connect();
    }

    #region Properties
    public NavigationPage NavigationPage { get; set; }
    bool disposedValue;
    public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(string), typeof(DtWindowTabItem));
    public string Header
    {
        get { return (string)GetValue(HeaderProperty); }
        set
        {
            HeadingChanged(value);
            SetValue(HeaderProperty, value);
        }
    }


    public static readonly BindableProperty IconSourceProperty = BindableProperty.Create("IconSource", typeof(object), typeof(DtWindowTabItem));
    public object IconSource
    {
        get { return GetValue(IconSourceProperty); }
        set
        {
            IconSourceChanged(value);
            SetValue(IconSourceProperty, value);
        }
    }

    public static readonly BindableProperty IsClosableProperty = BindableProperty.Create("IsClosable", typeof(bool), typeof(DtWindowTabItem));
    public bool IsClosable
    {
        get { return (bool)GetValue(IsClosableProperty); }
        set
        {
            IsClosableChanged(value);
            SetValue(IsClosableProperty, value);
        }
    }

    public static readonly BindableProperty ContentProperty = BindableProperty.Create("Content", typeof(object), typeof(DtWindowTabItem));
    public object Content
    {
        get { return GetValue(ContentProperty); }
        set
        {
            ContentChanged(value);
            SetValue(ContentProperty, value);
        }
    }

    public static readonly BindableProperty PlatformObjectProperty = BindableProperty.Create("PlatformObject", typeof(object), typeof(DtWindowTabItem));
    public object PlatformObject
    {
        get { return GetValue(PlatformObjectProperty); }
        set { }
    }

    #endregion
    #region Events

    public event EventHandler<DtWindowTabItemCloseRequestEventArgs> CloseRequested;


    public void WinCloseRequested(DtWindowTabItem sender, DtWindowTabItemCloseRequestEventArgs args)
    {
        CloseRequested?.Invoke(sender, args);
    }
    #endregion


    object IContentView.Content => Content;
    IView IContentView.PresentedContent
    {
        get
        {
            return Content is NavigationPage np ? np.CurrentPage : (IView)Content;
        }
    }

    public Thickness Padding
    {
        get;
        set;
    }

    public Size CrossPlatformArrange(Rect bounds)
    {
        throw new NotImplementedException();
    }

    public Size CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                Disconnect();
            }

            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

#if WINDOWS
    public Microsoft.Maui.Graphics.Size CrossPlatformArrange(Microsoft.Maui.Graphics.Rect bounds)
    {
        throw new NotImplementedException();
    }
#endif
    Microsoft.Maui.Graphics.Size IContentView.CrossPlatformMeasure(double widthConstraint, double heightConstraint)
    {
        throw new NotImplementedException();
    }

#if !ANDROID && !MACCATALYST && !IOS && !WINDOWS
    #region Properties    
    public bool CanGoBack() 
    {
        throw new NotImplementedException();
    }
    void Connect()
    {
        throw new NotImplementedException();
    }
    void Disconnect()
    {
        throw new NotImplementedException();
    }
    void HeadingChanged(string value)
    {
        throw new NotImplementedException();
    }

    void IconSourceChanged(object value)
    {
        throw new NotImplementedException();
    }

    void IsClosableChanged(bool value)
    {
        throw new NotImplementedException();
    }

    void ContentChanged(object value)
    {
        throw new NotImplementedException();
    }
    void TabNavigate(ContentPage page)
    {
        throw new NotImplementedException();
    }
    #endregion
#endif
}

