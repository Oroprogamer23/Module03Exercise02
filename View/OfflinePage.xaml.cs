namespace Module0Exercise0.View;
using Module0Exercise0.Services;

public partial class OfflinePage : ContentPage
{
	public OfflinePage()
	{
		InitializeComponent();
	}

    private void OnExitButtonClicked(object sender, EventArgs e)
    {
        // Exit the application
        System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
    }
}