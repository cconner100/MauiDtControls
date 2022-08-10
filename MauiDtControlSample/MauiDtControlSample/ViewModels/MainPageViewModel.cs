namespace MauiDtControlSample.ViewModels
{
    using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;

    using DtControls.UserControls;

    using MauiDtControlSample.Models;

    public partial class MainPageViewModel : ObservableObject
    {
        DtNavigationView NavView;
        MainPageViewModel() { }

        public MainPageViewModel(DtNavigationView navView)
        {
            NavView = navView;
        }

        public void TextToSearch(string text)
        {

        }

        public void OnLoadOfNavView()
        {
            var menu = new DtMenuData();
            var menucontext = new DtBuildMenuContext();
            menucontext.BuildPlatformMenus(NavView, menu.GetPlatformMenu(), DtNavigationView.MenuArea.main);
            menucontext.BuildPlatformMenus(NavView, menu.GetPlatformFooterMenu(), DtNavigationView.MenuArea.footer);
        }
    }
}
