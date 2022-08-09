namespace DtControls.Models
{
    internal class DtNavigationViewEventArgs
    {
    }

    /// <summary>
    /// Used to convert items invoked args
    /// </summary>
    public class DtNavigationViewItemInvokedEventArgs
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
}
