namespace FormItemExample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("SettingsPage/BlackListPage", typeof(BlackListPage));
	}
}
