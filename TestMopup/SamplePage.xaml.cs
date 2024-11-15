using Mopups.Services;

namespace TestMopup;

public partial class SamplePage : ContentPage
{
	public SamplePage()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new TestDialog());
    }
}