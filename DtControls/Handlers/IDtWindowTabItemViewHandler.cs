namespace DtControls.Handlers
{
    using DtControls.UserControls;

#if __IOS__ || MACCATALYST
    using PlatformView = UIKit.UIView;
#elif ANDROID
    using PlatformView = Android.Views.View;
#elif WINDOWS
    using PlatformView = Microsoft.UI.Xaml.Controls.TabViewItem;
#elif NETSTANDARD || (NET6_0 && !IOS && !ANDROID)
    using PlatformView = System.Object;
#endif

    /// <summary>
    /// 
    /// </summary>
    public interface IDtWindowTabItemViewHandler : IViewHandler
    {
        /// <summary>
        /// 
        /// </summary>
        new IDtWindowTabItemView VirtualView { get; }
        /// <summary>
        /// 
        /// </summary>
        new PlatformView PlatformView { get; }
    }
}
