#if MACCATALYST
namespace MauiDtControlSample.ViewModels;

using DtControls.Controls;

using MauiDtControlSample.Models;

using System;

public partial class MainPageViewModel
{
    #region DtNavigation
    public void SearchBarOnLoad(SearchBar searchBar)
    {
        SearchBar = searchBar;
    }

    public void TextToSearch(string text, SearchBar sb)
    {
        
    }

    public void OnLoadOfNavView()
    {
       
    }
    #endregion

    #region DtWindowTabs
    public void AddTabButtonClick(object sender, EventArgs e)
    {

    }

    public void TabCloseRequested(object sender, EventArgs e)
    {

    }
    #endregion

    #region DtTabItems
    #endregion
}
#endif