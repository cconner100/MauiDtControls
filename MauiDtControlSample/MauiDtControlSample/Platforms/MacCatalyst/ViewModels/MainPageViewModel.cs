#if MACCATALYST
namespace MauiDtControlSample.ViewModels;

using DtControls.UserControls;

using MauiDtControlSample.Models;

using System;

public partial class MainPageViewModel
{
    #region NavigationView
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
    #endregion

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
#endif