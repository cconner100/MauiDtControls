namespace DtControls.Models
{
    /// <summary>
    /// Base class for event arguments
    /// </summary>
    public class DtNavigationViewEventArgs
    {
        /// <summary>
        /// String name of item invoked
        /// </summary>
        public string InvokedItem { get; set; }

        /// <summary>
        /// If setting or not
        /// </summary>
        public bool IsSettingsInvoked { get; set; }
    }

    /// <summary>
    /// Used to convert items invoked args
    /// </summary>
    public class DtNavigationViewItemInvokedEventArgs : DtNavigationViewEventArgs { }

    /// <summary>
    /// Used to change selection
    /// </summary>
    public class DtNavigationViewSelectionChangedEventArgs : DtNavigationViewEventArgs { }

    /// <summary>
    /// Expanding arguments
    /// </summary>
    public class DtNavigationViewItemExpandingEventArgs : DtNavigationViewEventArgs { }

    /// <summary>
    /// Request back event for page stack
    /// </summary>
    public class DtNavigationViewBackRequestedEventArgs : DtNavigationViewEventArgs { }

    /// <summary>
    /// Menu items collapsed
    /// </summary>
    public class DtNavigationViewItemCollapsedEventArgs : DtNavigationViewEventArgs { }
}
