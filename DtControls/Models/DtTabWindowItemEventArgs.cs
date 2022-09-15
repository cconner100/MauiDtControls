namespace DtControls.Models
{
    using DtControls.Controls;
#if WINDOWS
    using Microsoft.UI.Xaml.Controls;
#endif

    public class DtTabWindowItemEventArgs
    {
    }

    public class DtTabWindowItemCloseRequestEventArgs
    {
        public object item { get; set; }
        public DtWindowTabItem tab { get; set; }

#if WINDOWS
        public DtTabWindowItemCloseRequestEventArgs(DtWindowTabItem dtWindowTabItem, TabViewTabCloseRequestedEventArgs args)
        {
            item = args.Item;
            tab = dtWindowTabItem;
        }
#endif
    }

}
