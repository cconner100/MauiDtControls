namespace MauiDtControlSample.ViewModels;

using DtControls.Controls;

using System;

public interface IMainPageViewModel
{
    void SearchBarOnLoad(SearchBar searchBar);
    void TextToSearch(string text, SearchBar sb);
    void OnLoadOfNavView();
    void AddTabButtonClick(DtWindowTabs sender, EventArgs e);
    void TabCloseRequested(DtWindowTabs sender, EventArgs e);

}
