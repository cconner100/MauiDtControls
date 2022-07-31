namespace DtControls.Handlers
{
    using DtControls.UserControls;

    using Microsoft.Maui.Handlers;
#if __IOS__ || MACCATALYST
using PlatformView = UIKit.UIView;
#elif ANDROID
    using PlatformView = Android.Widget.ImageView;
#elif WINDOWS
    using PlatformView = Microsoft.UI.Xaml.Controls.NavigationView;
#elif NETSTANDARD || (NET6_0 && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

    public interface IDtNavigationViewHandler : IViewHandler
    {
        new IDtNavigationView VirtualView { get; }
        new PlatformView PlatformView { get; }
    }
}
