

namespace DtControls.Control;

public interface IDtWindowTabItem : IContentView
{
    #region Events

    event EventHandler CloseRequested;

    void WinCloseRequested(object sender, object args);
    #endregion

    string Header { get; set; }

    object IconSource { get; set; }

    bool IsClosable { get; set; }

    object PlatformObject { get; set; }
}
