#if WINDOWS
namespace DtControls.Controls;

using DtControls.Models;

using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Controls;

using System;

public partial class DtWindowTabItems
{
    TabViewItem tabViewItem = new TabViewItem();
    NavigationPage navigationPage = new NavigationPage();
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
        CloseRequested?.Invoke(sender, null);
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
        tabViewItem.Content = navigationPage.ToPlatform(DtMauiContext.mauiContext);
    }

    async Task TabNavigate(ContentPage page)
    {
        await navigationPage.Navigation.PushAsync(page).ConfigureAwait(true);
    }
    #endregion
}
#endif

