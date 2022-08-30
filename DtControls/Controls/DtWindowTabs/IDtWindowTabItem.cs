

namespace DtControls.Control;

/// <summary>
/// 
/// </summary>
public interface IDtWindowTabItem : IContentView
{
    #region Events

    /// <summary>
    /// 
    /// </summary>
    event EventHandler CloseRequested;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void WinCloseRequested(object sender, object args);
    #endregion


    /// <summary>
    /// 
    /// </summary>
    string Header { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object IconSource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool IsClosable { get; set; }

    /// <summary>
    /// 
    /// </summary>
    object PlatformObject { get; set; }
}
