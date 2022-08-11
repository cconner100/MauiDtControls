
namespace DtControls.Handlers;

using DtControls.UserControls;

using System.Collections.ObjectModel;
#if __IOS__ || MACCATALYST
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
public interface IDtWindowTabViewHandler : IViewHandler
{
    /// <summary>
    /// 
    /// </summary>
    new IDtWindowTabView VirtualView { get; }
    /// <summary>
    /// 
    /// </summary>
    new PlatformView PlatformView { get; }

    /// <summary>
    /// Collection for tabitems
    /// </summary>
    void GetItemsCollection();
}

