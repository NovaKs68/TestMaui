using Mopups.Pages;
using Mopups.Services;

namespace TestMopup;

public partial class TestDialog : PopupPage
{
	public TestDialog()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        MopupService.Instance.PopAsync(false);
    }
}