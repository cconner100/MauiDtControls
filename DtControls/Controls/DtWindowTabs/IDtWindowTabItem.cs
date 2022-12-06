

namespace DtControls.Control;

using DtControls.Controls;
using DtControls.Models;
#if WINDOWS
using Windows.Foundation;
#endif

public interface IDtWindowTabItem : IContentView
{
    #region Events

    event EventHandler<DtWindowTabItemCloseRequestEventArgs> CloseRequested;

    void WinCloseRequested(DtWindowTabItem sender, DtWindowTabItemCloseRequestEventArgs args);
    #endregion

    bool CanGoBack();
    NavigationPage? NavigationPage { get; set; }

    string Header { get; set; }

    object IconSource { get; set; }

    bool IsClosable { get; set; }

    object PlatformObject { get; set; }
}
