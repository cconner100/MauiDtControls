#if MACCATALYST
namespace DtControls.Handlers;

using DtControls.Controls;
using DtControls.Models;

using Foundation;

using UIKit;

public class DtSidebarViewController : UIViewController, IUICollectionViewDelegate
{
    IDtNavigation dtNavigationView;
    public event EventHandler OnSettingsSelect;
    UICollectionView collectionView;
    UICollectionViewDiffableDataSource<NSString, DtMenuItem> dataSource;

    public DtSidebarViewController(IDtNavigation dtview)
    {
        dtNavigationView = dtview;
    }


    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        if (View is null)
        {
            throw new NullReferenceException(nameof(View));
        }


        if (dtNavigationView?.IsSettingsVisible == true)
        {
            var settingsButton = new UIBarButtonItem(UIImage.GetSystemImage("gear"), UIBarButtonItemStyle.Plain, OpenSettings)
            {
                AccessibilityLabel = "Settings"
            };
            NavigationItem.RightBarButtonItem = settingsButton;
        }


        collectionView = new UICollectionView(View.Bounds, CreateLayout())
        {
            Delegate = this
        };
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

        ConfigureRowSources();

        if (dtNavigationView?.AutoSuggestBox != null)
        {

        }

        // triger control loaded
        dtNavigationView.HandleOnLoaded(dtNavigationView, null);
    }

    public void SetHeader(string header)
    {
        Title = header;
    }


    public void SetupNavigationItems(NSDiffableDataSourceSectionSnapshot<DtMenuItem> snapshot)
    {
        if (dataSource is null)
        {
            return;
        }

        // Add base sidebar items
        var sectionIdentifier = new NSString("base");
        dataSource.ApplySnapshot(snapshot, sectionIdentifier, false);
    }

    public NSDiffableDataSourceSectionSnapshot<DtMenuItem> GetNavigationSnapshot(IEnumerable<DtMenuItem> items)
    {

        var snapshot = new NSDiffableDataSourceSectionSnapshot<DtMenuItem>();

        var headers = items.Where(n => n.menuType == DtMenuItem.MenuType.Header);
        snapshot.AppendItems(headers.ToArray());
        snapshot.ExpandItems(headers.ToArray());

        var rows = items.Where(n => n.menuType == DtMenuItem.MenuType.Row || n.menuType == DtMenuItem.MenuType.ExpandableRow);
        snapshot.AppendItems(rows.ToArray());

        return snapshot;
    }



    void ConfigureRowSources()
    {
        var headerRegistration = UICollectionViewCellRegistration.GetRegistration(typeof(UICollectionViewListCell),
            new UICollectionViewCellRegistrationConfigurationHandler((cell, indexpath, item) =>
            {
                var sidebarItem = item as DtMenuItem;
                if (sidebarItem is null)
                {
                    return;
                }

                var cfg = UIListContentConfiguration.SidebarHeaderConfiguration;
                cfg.Text = sidebarItem.title;
                cell.ContentConfiguration = cfg;
            })
         );

        var expandableRegistration = UICollectionViewCellRegistration.GetRegistration(typeof(UICollectionViewListCell),
            new UICollectionViewCellRegistrationConfigurationHandler((cell, indexpath, item) =>
            {
                var sidebarItem = item as DtMenuItem;
                if (sidebarItem is null)
                {
                    return;
                }

                var cfg = UIListContentConfiguration.SidebarHeaderConfiguration;
                cfg.Text = sidebarItem.title;
                cfg.SecondaryText = sidebarItem.subTitle;
                //cfg.Image = (UIImage)sidebarItem.iconObject != null ? sidebarItem.iconObject : null;

                cell.ContentConfiguration = cfg;
                ((UICollectionViewListCell)cell).Accessories = new[] { new UICellAccessoryOutlineDisclosure() };
            })
         );

        var rowRegistration = UICollectionViewCellRegistration.GetRegistration(typeof(UICollectionViewListCell),
            new UICollectionViewCellRegistrationConfigurationHandler((cell, indexpath, item) =>
            {
                var sidebarItem = item as DtMenuItem;
                if (sidebarItem is null)
                {
                    return;
                }

                var cfg = UIListContentConfiguration.SidebarCellConfiguration;
                cfg.Text = sidebarItem.title;
                cfg.SecondaryText = sidebarItem.subTitle;
                //cfg.Image = (UIImage)sidebarItem.iconObject != null ? sidebarItem.iconObject : null;

                cell.ContentConfiguration = cfg;
            })
         );

        if (collectionView is null)
        {
            throw new NullReferenceException(nameof(this.collectionView));
        }

        dataSource = new UICollectionViewDiffableDataSource<NSString, DtMenuItem>(collectionView,
            new UICollectionViewDiffableDataSourceCellProvider((collectionView, indexPath, item) =>
            {
                var sidebarItem = item as DtMenuItem;
                if (sidebarItem is null || this.collectionView is null)
                {
                    throw new Exception();
                }

                switch (sidebarItem.menuType)
                {
                    case DtMenuItem.MenuType.Header:
                        return this.collectionView.DequeueConfiguredReusableCell(headerRegistration, indexPath, item);
                    case DtMenuItem.MenuType.ExpandableRow:
                        return this.collectionView.DequeueConfiguredReusableCell(expandableRegistration, indexPath, item);
                    default:
                        return this.collectionView.DequeueConfiguredReusableCell(rowRegistration, indexPath, item);
                }
            })
        );
    }
    UICollectionViewLayout CreateLayout()
    {
        var config = new UICollectionLayoutListConfiguration(UICollectionLayoutListAppearance.Sidebar)
        {
            HeaderMode = UICollectionLayoutListHeaderMode.FirstItemInSection,
            ShowsSeparators = true

        };

        return UICollectionViewCompositionalLayout.GetLayout(config);
    }

    void OpenSettings(object sender, EventArgs e)
    {
        OnSettingsSelect?.Invoke(this, EventArgs.Empty);
    }
}

#endif