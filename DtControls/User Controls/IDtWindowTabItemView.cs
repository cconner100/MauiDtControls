

namespace DtControls.UserControls
{

    public interface IDtWindowTabItemView : IContentView
    {
        #region Events
        event EventHandler CloseRequested;

        void WinCloseRequested(object sender, object args);
        #endregion

        string Header { get;set; } 
        object IconSource { get; set; }
        bool IsClosable { get; set; }
        object PlatformObject { get; set; }
    }
}
