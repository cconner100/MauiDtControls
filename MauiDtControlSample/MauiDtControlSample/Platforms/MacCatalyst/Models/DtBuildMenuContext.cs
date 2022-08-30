namespace MauiDtControlSample.Models;

using DtControls.Controls;

using Foundation;

using System.Collections.Generic;

using UIKit;

public partial class DtBuildMenuContext
{
    public void BuildPlatformMenus(DtNavigation nv, List<DtMenuItem> menulist)
    {
        var headerRegistration = UICollectionViewCellRegistration.GetRegistration(typeof(UICollectionViewListCell),
            new UICollectionViewCellRegistrationConfigurationHandler((cell, indexpath, item) =>
            {
                var sidebarItem = item as NavigationSidebarItem;
                if (sidebarItem is null)
                {
                    return;
                }

                var cfg = UIListContentConfiguration.SidebarHeaderConfiguration;
                cfg.Text = sidebarItem.Title;
                cell.ContentConfiguration = cfg;
            })
         );

        var expandableRegistration = UICollectionViewCellRegistration.GetRegistration(typeof(UICollectionViewListCell),
            new UICollectionViewCellRegistrationConfigurationHandler((cell, indexpath, item) =>
            {
                var sidebarItem = item as NavigationSidebarItem;
                if (sidebarItem is null)
                {
                    return;
                }

                var cfg = UIListContentConfiguration.SidebarHeaderConfiguration;
                cfg.Text = sidebarItem.Title;
                cfg.SecondaryText = sidebarItem.Subtitle;
                cfg.Image = sidebarItem.Image;

                cell.ContentConfiguration = cfg;
                ((UICollectionViewListCell)cell).Accessories = new[] { new UICellAccessoryOutlineDisclosure() };
            })
         );

        var rowRegistration = UICollectionViewCellRegistration.GetRegistration(typeof(UICollectionViewListCell),
            new UICollectionViewCellRegistrationConfigurationHandler((cell, indexpath, item) =>
            {
                var sidebarItem = item as NavigationSidebarItem;
                if (sidebarItem is null)
                {
                    return;
                }

                var cfg = UIListContentConfiguration.SidebarCellConfiguration;
                cfg.Text = sidebarItem.Title;
                cfg.SecondaryText = sidebarItem.Subtitle;
                cfg.Image = sidebarItem.Image;

                cell.ContentConfiguration = cfg;
            })
         );

        if (this.collectionView is null)
        {
            throw new NullReferenceException(nameof(this.collectionView));
        }

        this.dataSource = new UICollectionViewDiffableDataSource<NSString, NavigationSidebarItem>(this.collectionView,
            new UICollectionViewDiffableDataSourceCellProvider((collectionView, indexPath, item) =>
            {
                var sidebarItem = item as NavigationSidebarItem;
                if (sidebarItem is null || this.collectionView is null)
                {
                    throw new Exception();
                }

                switch (sidebarItem.Type)
                {
                    case SidebarItemType.Header:
                        return this.collectionView.DequeueConfiguredReusableCell(headerRegistration, indexPath, item);
                    case SidebarItemType.ExpandableRow:
                        return this.collectionView.DequeueConfiguredReusableCell(expandableRegistration, indexPath, item);
                    default:
                        return this.collectionView.DequeueConfiguredReusableCell(rowRegistration, indexPath, item);
                }
            })
        );
    }
}
}
