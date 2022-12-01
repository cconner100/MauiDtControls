namespace MauiDtControlSample;

public partial class TabPage1 : ContentPage
{
	public TabPage1()
	{
		InitializeComponent();
        _ = next.Focus();
    }

	private void ContentPage_Appearing(object sender, EventArgs e)
	{
		Console.WriteLine("hello");
    }

	private void ContentPage_Loaded(object sender, EventArgs e)
	{
		var mp = ServiceProvider.Current.GetService<MainPage>();
		var tab = mp.GetCurrentTab();
		tab.Header = Title; 
		Console.WriteLine("ContentPage_Loaded");
    }

	private async void next_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TabPage2()).ConfigureAwait(true);
	}
}