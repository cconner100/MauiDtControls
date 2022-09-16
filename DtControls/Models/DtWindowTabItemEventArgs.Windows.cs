#if WINDOWS
namespace DtControls.Models;

using DtControls.Controls;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using Windows.Foundation.Collections;

public class DtWindowTabItemCloseRequestEventArgs
{
    public object Item { get; protected set; }
    public DtWindowTabItem Tab { get; protected set; }


    public DtWindowTabItemCloseRequestEventArgs(DtWindowTabItem dtWindowTabItem, TabViewTabCloseRequestedEventArgs args)
    {
        Item = args.Item;
        Tab = dtWindowTabItem;
    }
}

public class DtWindowTabsItemDragCompletedEventArgs
{
    public enum DtDataPackageOption
    {
        Copy = 1,
        Link = 4,
        Move = 2,
        None = 0
    }

    public DtDataPackageOption DropResults { get; protected set; }
    public object Item { get; protected set; }
    public DtWindowTabItem Tab { get; protected set; }

    public DtWindowTabsItemDragCompletedEventArgs(DtWindowTabItem tab, TabViewTabDragCompletedEventArgs args)
    {
        switch (args.DropResult)
        {
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.None:
                DropResults = DtDataPackageOption.None;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move:
                DropResults = DtDataPackageOption.Move;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Copy:
                DropResults = DtDataPackageOption.Copy;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Link:
                DropResults = DtDataPackageOption.Link;
                break;
        }
        Item = args.Item;
        Tab = tab;
    }
}

public class DtWindowTabsDragStartingEventArgs
{
    public object Data { get; protected set; }
    public object Item { get; protected set; }
    public DtWindowTabItem Tab { get; protected set; }

    public bool Cancel { get { return savedargs.Cancel; } set { savedargs.Cancel = value; } }

    private TabViewTabDragStartingEventArgs savedargs { get; set; }
    public DtWindowTabsDragStartingEventArgs(DtWindowTabItem sender, TabViewTabDragStartingEventArgs args)
    {
        savedargs = args;
        Cancel = args.Cancel;
        Data = args.Data;
        Item = args.Item;
        Tab = sender;

    }

}

public class DtWindowTabsDroppedOutsideEventArgs
{
    public object Item { get; protected set; }
    public DtWindowTabItem Tab { get; protected set; }


    public DtWindowTabsDroppedOutsideEventArgs(DtWindowTabItem sender, TabViewTabDroppedOutsideEventArgs args)
    {
        Item = args.Item;
        Tab = sender;
    }

}
public class DtWindowTabsItemsChangedEventArgs
{
    public enum DtWindowTabCollectionChanged
    {
        ItemChanged = 1,
        ItemInserted = 2,
        ItemRemoved = 3,
        Reset = 0
    }

    public DtWindowTabCollectionChanged CollectionChange { get; protected set; }
    public uint Index { get; protected set; }

    public DtWindowTabsItemsChangedEventArgs(IVectorChangedEventArgs args)
    {
        switch (args.CollectionChange)
        {
            case Windows.Foundation.Collections.CollectionChange.Reset:
                CollectionChange = DtWindowTabCollectionChanged.Reset;
                break;
            case Windows.Foundation.Collections.CollectionChange.ItemChanged:
                CollectionChange = DtWindowTabCollectionChanged.ItemChanged;
                break;
            case Windows.Foundation.Collections.CollectionChange.ItemRemoved:
                CollectionChange = DtWindowTabCollectionChanged.ItemRemoved;
                break;
            case Windows.Foundation.Collections.CollectionChange.ItemInserted:
                CollectionChange = DtWindowTabCollectionChanged.ItemInserted;
                break;
        }

        Index = args.Index;
    }
}

public class DtWindowTabsSelectionChangedEventArgs
{
    public IList<object> AddedItems { get; protected set; }
    public object OrginalSource { get; protected set; }
    public IList<object> RemovedItems { get; protected set; }

    public DtWindowTabsSelectionChangedEventArgs(DtWindowTabs tabs, SelectionChangedEventArgs args)
    {
        AddedItems = args.AddedItems;
        RemovedItems = args.RemovedItems;
        OrginalSource = args.OriginalSource;
    }
}

public class DtWindowTabsDragEventArgs
{
    public enum DtWindowTabsDataPackageOperation
    {
        Copy = 1,
        Link = 4,
        Move = 2,
        None = 0
    }

    public enum DtWindowTabsDragDropModifiers
    {
        Alt = 4,
        Control = 2,
        LeftButton = 8,
        MiddleButton = 16,
        None = 0,
        RightButton = 32,
        Shift = 1
    }

    public DtWindowTabsDataPackageOperation AcceptOperations { get; set; }
    public DtWindowTabsDataPackageOperation AllowedOperations { get; protected set; }
    public object Data { get; set; }
    public object DataView { get; protected set; }
    public object DragUIOverride { get; protected set; }

    public bool Handled { get { return origargs.Handled; } set { origargs.Handled = value; } }

    public DtWindowTabsDragDropModifiers Modifiers { get; protected set; }
    public object OriginalSource { get; protected set; }

    Microsoft.UI.Xaml.DragEventArgs origargs;

    public DtWindowTabsDragEventArgs(Microsoft.UI.Xaml.DragEventArgs args)
    {
        origargs = args;
        switch (args.AllowedOperations)
        {
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Copy:
                AllowedOperations = DtWindowTabsDataPackageOperation.Copy;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.None:
                AllowedOperations = DtWindowTabsDataPackageOperation.None;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move:
                AllowedOperations = DtWindowTabsDataPackageOperation.Move;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Link:
                AllowedOperations = DtWindowTabsDataPackageOperation.Link;
                break;

        }

        switch (args.AcceptedOperation)
        {
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Copy:
                AcceptOperations = DtWindowTabsDataPackageOperation.Copy;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.None:
                AcceptOperations = DtWindowTabsDataPackageOperation.None;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move:
                AcceptOperations = DtWindowTabsDataPackageOperation.Move;
                break;
            case Windows.ApplicationModel.DataTransfer.DataPackageOperation.Link:
                AcceptOperations = DtWindowTabsDataPackageOperation.Link;
                break;

        }

        Data = args.Data;
        DragUIOverride = args.DragUIOverride;
        Handled = args.Handled;

        switch (args.Modifiers)
        {
            case Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers.Alt:
                Modifiers = DtWindowTabsDragDropModifiers.Alt;
                break;
            case Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers.RightButton:
                Modifiers = DtWindowTabsDragDropModifiers.RightButton;
                break;
            case Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers.Shift:
                Modifiers = DtWindowTabsDragDropModifiers.Shift;
                break;
            case Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers.LeftButton:
                Modifiers = DtWindowTabsDragDropModifiers.LeftButton;
                break;
            case Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers.MiddleButton:
                Modifiers = DtWindowTabsDragDropModifiers.MiddleButton;
                break;
            case Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers.Control:
                Modifiers = DtWindowTabsDragDropModifiers.Control;
                break;
        }

        OriginalSource = args.OriginalSource;
    }
    public DragOperationDeferral GetDeferral()
    {
        return origargs.GetDeferral();
    }
    public Windows.Foundation.Point GetPosition(UIElement relativeTo)
    {
        return origargs.GetPosition(relativeTo);
    }

    public class DtWindowTabsStripDragOverEventArgs : DtWindowTabsDragEventArgs
    {
        public DtWindowTabsStripDragOverEventArgs(DragEventArgs args) : base(args)
        {
        }
    }

    public class DtWindowTabsStripDropEventArgs : DtWindowTabsDragEventArgs
    {
        public DtWindowTabsStripDropEventArgs(DragEventArgs args) : base(args)
        {
        }
    }
}
#endif