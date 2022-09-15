#if WINDOWS
namespace DtControls.Controls;

using DtControls.Models;

using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Controls;

using System;

public partial class DtWindowTabItem : View, IElement
{
    TabViewItem tabViewItem = new TabViewItem();
    

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
        var eventargs = new DtTabWindowItemCloseRequestEventArgs(this, args);
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
                np.ToHandler(DtMauiContext.mauiContext);
            }
            tabViewItem.Content = np.Handler.PlatformView;
        }
    }
   
    #endregion
}
#endif

