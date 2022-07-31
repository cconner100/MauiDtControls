
namespace DtControls.Handlers
{
    using DtControls.UserControls;
#if __IOS__ || MACCATALYST
    using PlatformView = UIKit.UIView;
#elif ANDROID
    using PlatformView = Android.Widget.ImageView;
#elif WINDOWS
    using PlatformView = Microsoft.UI.Xaml.Controls.TabView;
#elif NETSTANDARD || (NET6_0 && !IOS && !ANDROID)
    using PlatformView = System.Object;
#endif

    public interface IDtWindowTabViewHandler : IViewHandler
    {
        new IDtWindowTabView VirtualView { get; }
        new PlatformView PlatformView { get; }
    }

}
