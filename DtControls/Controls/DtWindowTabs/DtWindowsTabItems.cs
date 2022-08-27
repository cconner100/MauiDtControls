
namespace DtControls.Controls;

using CommunityToolkit.Mvvm.ComponentModel;

using System;


[INotifyPropertyChanged]
public partial class DtWindowTabItems
{
    [ObservableProperty]
    string heading;

    [ObservableProperty]
    object iconSource;

    [ObservableProperty]
    object content;



    #region Events
    public event EventHandler CloseRequested;
    #endregion

    

#if !ANDROID && !MACCATALYST && !IOS && !WINDOWS
    #region Properties    
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

