#if IOS
namespace DtControls.Platforms.iOS.Handlers;

using UIKit;

public class DtSidebarViewController : UIViewController, IUICollectionViewDelegate
{
    UICollectionView collectionView;
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        //this.Title = this.options.Header;

        //this.NavigationItem.LargeTitleDisplayMode = this.macOptions.LargeTitleDisplayMode;

        //if (this.options.ShowSettingsItem)
        //{
        //    var settingsButton = new UIBarButtonItem(UIImage.GetSystemImage("gear"), UIBarButtonItemStyle.Plain, this.OpenSettings);
        //    settingsButton.AccessibilityLabel = this.options.SettingsTitle;
        //    this.NavigationItem.RightBarButtonItem = settingsButton;
        //}

        if (View is null)
        {
            throw new NullReferenceException(nameof(View));
        }

        collectionView = new UICollectionView(View.Bounds, CreateLayout());
        collectionView.Delegate = this;
        View.AddSubview(collectionView);

        collectionView.TranslatesAutoresizingMaskIntoConstraints = false;

        var constraints = new List<NSLayoutConstraint>
        {
            collectionView.BottomAnchor.ConstraintEqualTo(View.BottomAnchor),
            collectionView.LeftAnchor.ConstraintEqualTo(View.LeftAnchor),
            collectionView.RightAnchor.ConstraintEqualTo(View.RightAnchor),
            collectionView.HeightAnchor.ConstraintEqualTo(View.HeightAnchor)
        };

        NSLayoutConstraint.ActivateConstraints(constraints.ToArray());

        //ConfigureDataSource();

        //SetupNavigationItems(GetNavigationSnapshot(options.DefaultSidebarItems));

        //if (this.options.ShowSearchBar)
        //{

        //}
    }
    UICollectionViewLayout CreateLayout()
    {
        var config = new UICollectionLayoutListConfiguration(UICollectionLayoutListAppearance.Sidebar)
        {
            HeaderMode = UICollectionLayoutListHeaderMode.None,
            ShowsSeparators = false
        };

        return UICollectionViewCompositionalLayout.GetLayout(config);
    }
}

#endif