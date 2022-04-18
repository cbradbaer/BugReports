using PlatformTestWithRC1.SystemInfo;

namespace PlatformTestWithRC1;

public partial class MainPage : ContentPage
{
	int count = 0;
	TestClass test;

	public MainPage()
	{
		InitializeComponent();
		test = new	TestClass();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);

		title.Text = test.DevicePlatform;
	}
}

