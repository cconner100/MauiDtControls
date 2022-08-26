#if MACCATALYST
namespace DtControls.Handlers;

using DtControls.UserControls;
using UIKit;

public class DtSidebarViewController : UIViewController, IUICollectionViewDelegate
{
    IDtNavigationView dtNavigationView;
    public DtSidebarViewController(IDtNavigationView dtview)
    {
        dtNavigationView = dtview;
    }

    public event EventHandler OnSettingsSelect;

    UICollectionView collectionView;
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();


        Title = "hello"; // dtNavigationView?.Header;

        //NavigationItem.LargeTitleDisplayMode = this.macOptions.LargeTitleDisplayMode;

        if (dtNavigationView?.IsSettingsVisible == true)
        {
            var settingsButton = new UIBarButtonItem(UIImage.GetSystemImage("gear"), UIBarButtonItemStyle.Plain, OpenSettings);
            settingsButton.AccessibilityLabel = "settings";
            this.NavigationItem.RightBarButtonItem = settingsButton;
        }

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

        if (dtNavigationView?.AutoSuggestBox != null)
        {

        }
    }

    public void SetHeader(string header)
    {
        Title = header;
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

    private void OpenSettings(object? sender, EventArgs e)
    {
        OnSettingsSelect?.Invoke(this, EventArgs.Empty);
    }
}

#endif