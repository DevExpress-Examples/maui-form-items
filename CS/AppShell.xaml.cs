namespace FormItemExample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("SettingsPage/BlacklistPage", typeof(BlacklistPage));
	}
}
