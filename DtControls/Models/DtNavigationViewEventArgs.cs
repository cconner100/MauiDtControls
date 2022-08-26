namespace DtControls.Models;

/// <summary>
/// Base class for event arguments
/// </summary>
public class DtNavigationEventArgs
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
public class DtNavigationItemInvokedEventArgs : DtNavigationEventArgs { }

/// <summary>
/// Used to change selection
/// </summary>
public class DtNavigationSelectionChangedEventArgs : DtNavigationEventArgs { }

/// <summary>
/// Expanding arguments
/// </summary>
public class DtNavigationItemExpandingEventArgs : DtNavigationEventArgs { }

/// <summary>
/// Request back event for page stack
/// </summary>
public class DtNavigationBackRequestedEventArgs : DtNavigationEventArgs { }

/// <summary>
/// Menu items collapsed
/// </summary>
public class DtNavigationItemCollapsedEventArgs : DtNavigationEventArgs { }
