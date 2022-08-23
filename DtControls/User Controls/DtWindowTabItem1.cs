namespace DtControls.UserControls;

using CommunityToolkit.Mvvm.ComponentModel;

using System;
[ContentProperty("Content")]
[INotifyPropertyChanged]
public partial class DtWindowTabItem1 : IDisposable
{
    public DtWindowTabItem1()
    {
        Connect();
    }

    [ObservableProperty]
    string heading;
    partial void OnHeadingChanged(string value)
    {
        HeadingChanged(value);
    }

    [ObservableProperty]
    object iconSource;
    partial void OnIconSourceChanged(object value)
    {
        IconSourceChanged(value);
    }

    [ObservableProperty]
    bool isClosable;
    partial void OnIsClosableChanged(bool value)
    {
        IsClosableChanged(value);
    }

    [ObservableProperty]
    object content;
    private bool disposedValue;

    partial void OnContentChanged(object value)
    {
        ContentChanged(value);
    }

    public async Task Navigate(ContentPage page)
    {
        await TabNavigate(page).ConfigureAwait(true);
    }

    public event EventHandler CloseRequested;

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
}
