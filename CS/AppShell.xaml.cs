namespace FormItemExample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("SettingsPage/SelectLanguagePage", typeof(SelectLanguagePage));
		Routing.RegisterRoute("SettingsPage/BlackListPage", typeof(BlackListPage));
	}
}
