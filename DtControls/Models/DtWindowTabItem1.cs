#if NET6_0 && !ANDROID && !IOS && !MACCATALYST && !WINDOWS
namespace DtControls.UserControls;


using System;

public partial class DtWindowTabItem1 
{
    void Connect()
    {
        throw new NotImplementedException(); 
    }
    void Disconnect()
    {
        throw new NotImplementedException();
    }

#region Events

#endregion

#region Properties
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
    async Task TabNavigate(ContentPage page)
    {
        throw new NotImplementedException();
    }
    #endregion
}
#endif

