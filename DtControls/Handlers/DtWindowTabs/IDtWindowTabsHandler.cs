
namespace DtControls.Handlers;

using DtControls.Controls;

using System.Collections.ObjectModel;
#if MACCATALYST
using PlatformView = UIKit.UIView;
#elif ANDROID
using PlatformView = Android.Widget.ImageView;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.TabView;
#elif NETSTANDARD || (NET6_0 && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

/// <summary>
/// 
/// </summary>
public interface IDtWindowTabsHandler : IViewHandler
{
    /// <summary>
    /// 
    /// </summary>
    new IDtWindowTabs VirtualView { get; }
    /// <summary>
    /// 
    /// </summary>
    new PlatformView PlatformView { get; }

    /// <summary>
    /// Collection for tabitems
    /// </summary>
    void GetItemsCollection();
}

