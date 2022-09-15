namespace DtControls.Models;

public class DtNavigationEventArgs
{

    public string InvokedItem { get; set; }

    public bool IsSettingsInvoked { get; set; }
}


public class DtNavigationItemInvokedEventArgs : DtNavigationEventArgs { }


public class DtNavigationSelectionChangedEventArgs : DtNavigationEventArgs { }

public class DtNavigationItemExpandingEventArgs : DtNavigationEventArgs { }

public class DtNavigationBackRequestedEventArgs : DtNavigationEventArgs { }

public class DtNavigationItemCollapsedEventArgs : DtNavigationEventArgs { }
