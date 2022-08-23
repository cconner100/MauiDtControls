#if IOS
namespace MauiDtControlSample.ViewModels;

using DtControls.UserControls;

using MauiDtControlSample.Models;

using System;

public partial class MainPageViewModel
{

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
#endif