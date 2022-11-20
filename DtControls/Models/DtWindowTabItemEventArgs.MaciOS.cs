
namespace DtControls.Models;

using DtControls.Controls;

public class DtWindowTabItemCloseRequestEventArgs
{
    public DtWindowTabItem Tab { get; set; }
}

public class DtWindowTabsItemDragCompletedEventArgs
{

}

public class DtWindowTabsDragStartingEventArgs
{

}

public class DtWindowTabsDroppedOutsideEventArgs
{

}
public class DtWindowTabsItemsChangedEventArgs
{

}

public class DtWindowTabsSelectionChangedEventArgs
{
    public IList<DtWindowTabItem> AddedItems { get; protected set; }
    public object OrginalSource { get; protected set; }
    public IList<DtWindowTabItem> RemovedItems { get; protected set; }

}

public class DtWindowTabsDragEventArgs
{


}

public class DtWindowTabsStripDragOverEventArgs
{

}

public class DtWindowTabsStripDropEventArgs
{
}



