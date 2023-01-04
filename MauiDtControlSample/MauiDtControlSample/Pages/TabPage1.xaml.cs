namespace MauiDtControlSample;

public partial class TabPage1 : ContentPage
{
	public TabPage1()
	{
		InitializeComponent();
    }

	private void ContentPage_Appearing(object sender, EventArgs e)
	{
		Console.WriteLine("ContentPage_Appearing");
    }

	private void ContentPage_Loaded(object sender, EventArgs e)
	{
		var mp = ServiceProvider.Current?.GetService<MainPage>();
		if (mp != null)
		{
			var tab = mp.GetCurrentTab();
			if (tab != null)
			{
				tab.Header = Title;
			}
		}
		Console.WriteLine("ContentPage_Loaded");
    }

	private async void Next_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TabPage2()).ConfigureAwait(true);
	}
}