namespace MauiDtControlSample;

public partial class TabPage1 : ContentPage
{
	public TabPage1()
	{
		InitializeComponent();
	}

	private void ContentPage_Appearing(object sender, EventArgs e)
	{
		Console.WriteLine("hello");
    }

	private void ContentPage_Loaded(object sender, EventArgs e)
	{
		Console.WriteLine("ContentPage_Loaded");
    }
}