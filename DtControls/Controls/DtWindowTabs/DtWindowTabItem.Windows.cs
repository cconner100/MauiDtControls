#if WINDOWS
namespace DtControls.Controls;

using DtControls.Models;

using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

public partial class DtWindowTabItem : View, IElement
{
    public bool CanGoBack()
    {
        return ContentFrame != null && ContentFrame.CanGoBack;
    }

    readonly TabViewItem tabViewItem = new();
    
    Frame? ContentFrame { get; set; }

    public IView PresentedContent { get; }

    void Connect()
    {
        tabViewItem.CloseRequested += TabViewItem_CloseRequested;
    }

    void Disconnect()
    {
        tabViewItem.CloseRequested -= TabViewItem_CloseRequested;
    }

    #region Events    
    private void TabViewItem_CloseRequested(TabViewItem sender, TabViewTabCloseRequestedEventArgs args)
    {
#if WINDOWS
        var eventargs = new DtWindowTabItemCloseRequestEventArgs(this, args);
#endif
        CloseRequested?.Invoke(this, eventargs);
    }

    #endregion

    #region Properties
    public TabViewItem GetTabViewItem()
    {
        return tabViewItem;
    }
    void HeadingChanged(string value)
    {
        tabViewItem.Header = value;
    }

    void IconSourceChanged(object value)
    {
        tabViewItem.IconSource = (IconSource)value;
    }

    void IsClosableChanged(bool value)
    {
        tabViewItem.IsClosable = value;
    }

    void ContentChanged(object value)
    {
        if(value is NavigationPage np)
        {
            if(np.Handler == null)
            {
                if (DtMauiContext.MauiContext is null)
                {
                    throw new Exception("Maui Context is null");
                }
                _ = np.ToHandler(DtMauiContext.MauiContext);
            }
            tabViewItem.Content = np.Handler?.PlatformView;
            if(np.Handler?.PlatformView is Frame frame)
            {
                ContentFrame = frame;
                ContentFrame.Focus(FocusState.Keyboard);
            }
        }
    }
   
    #endregion
}
#endif

