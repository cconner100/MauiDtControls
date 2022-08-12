namespace MauiDtControlSample.ViewModels;

using DtControls.UserControls;

using MauiDtControlSample.Models;

using System;

public partial class MainPageViewModel
{
    DtNavigationView NavView;
    SearchBar SearchBar;
    DtMenuData menu = new DtMenuData();
    DtBuildMenuContext menucontext = new DtBuildMenuContext();


    public MainPageViewModel(DtNavigationView navView)
    {
        NavView = navView;
        menu.InitMenuData();
    }

    public void SearchBarOnLoad(SearchBar searchBar)
    {
        SearchBar = searchBar;
    }

    public void TextToSearch(string text, SearchBar sb)
    {
        throw new NotImplementedException();
    }

    public void OnLoadOfNavView()
    {
        throw new NotImplementedException();
    }

    #region TabView
    public void AddTabButtonClick(object sender, EventArgs e)
    {

    }

    public void TabCloseRequested(object sender, EventArgs e)
    {

    }
    #endregion

    #region TabViewItem
    #endregion
}
