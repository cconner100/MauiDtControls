namespace DtControls.Handlers;

using DtControls.Controls;
using DtControls.Models;

#if MACCATALYST
using UIKit;
using PlatformView = UIKit.UIView;
#elif ANDROID
using PlatformView = Android.Widget.ImageView;
#elif WINDOWS
using Microsoft.UI.Xaml.Controls;
using PlatformView = Microsoft.UI.Xaml.Controls.NavigationView;
#elif NETSTANDARD || (NET6_0 && !MACCATALYST && !ANDROID && !WINDOWS)
using PlatformView = System.Object;
#endif

public interface IDtNavigationHandler : IViewHandler
{
#if MACCATALYST
    UISplitViewController splitView { get; }
    DtSidebarViewController Controller { get; }
#endif

    new IDtNavigation VirtualView { get; }

    new PlatformView PlatformView { get; }

#if WINDOWS
    List<NavigationViewItem> BuildPlatformMenus(IList<DtMenuItem> menuList, IDtNavigation virtualView);
#endif

#if MACCATALYST
    IList<DtMenuItem> BuildPlatformMenus(IList<DtMenuItem> menulist, IDtNavigation virtualView);
#endif

#if NETSTANDARD || (NET6_0 && !MACCATALYST && !ANDROID && !WINDOWS)
    List<object> BuildPlatformMenus(IList<DtMenuItem> menuList, IDtNavigation virtualView);
#endif

}
