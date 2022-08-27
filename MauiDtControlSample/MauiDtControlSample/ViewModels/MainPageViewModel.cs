namespace MauiDtControlSample.ViewModels;

using DtControls.Controls;

using MauiDtControlSample.Models;

public partial class MainPageViewModel
{
    DtNavigation NavView;
    SearchBar SearchBar;
    DtMenuData menu = new DtMenuData();
    DtBuildMenuContext menucontext = new DtBuildMenuContext();
    Page page = null;

    private MainPageViewModel() { }
    public MainPageViewModel(Page thePage, DtNavigation navView)
    {
        page = thePage;
        NavView = navView;
        menu.InitMenuData();
    }
#if NET6_0 && !ANDROID && !IOS && !MACCATALYST && !WINDOWS
    public void SearchBarOnLoad(SearchBar searchBar)
    {
    }
    public void OnLoadOfNavView()
    {
    }
    public void TabCloseRequested(DtWindowTabs sender, EventArgs e)
    {
    }
    public void AddTabButtonClick(DtWindowTabs sender, EventArgs e)
    {
    }
    public void TextToSearch(string text, SearchBar sb)
    {
    }
#endif
}
