
namespace DtControls.Handlers;

using DtControls.Controls;

using System.Collections.ObjectModel;
#if MACCATALYST || IOS
using PlatformView = UIKit.UIView;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.TabView;
#elif NETSTANDARD || (NET7_0 && !ANDROID)
using PlatformView = System.Object;
#endif

public interface IDtWindowTabsHandler : IViewHandler
{

    new IDtWindowTabs VirtualView { get; }

    new PlatformView PlatformView { get; }

    void GetItemsCollection();
}

