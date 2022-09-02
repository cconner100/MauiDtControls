namespace DtControls.Handlers;

using DtControls.Controls;

#if MACCATALYST
using UIKit;
using PlatformView = UIKit.UIView;
#elif ANDROID
using PlatformView = Android.Widget.ImageView;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.NavigationView;
#elif NETSTANDARD || (NET6_0 && !IOS && !ANDROID && !WINDOWS)
using PlatformView = System.Object;
#endif

public interface IDtNavigationHandler : IViewHandler
{
#if MACCATALYST
    UISplitViewController splitView { get; }
    DtSidebarViewController Controller { get; }
#endif
    /// <summary>
    /// 
    /// </summary>
    new IDtNavigation VirtualView { get; }
    /// <summary>
    /// 
    /// </summary>
    new PlatformView PlatformView { get; }
}
