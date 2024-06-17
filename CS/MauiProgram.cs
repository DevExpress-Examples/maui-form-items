using CommunityToolkit.Maui;
using DevExpress.Maui;
using Microsoft.Extensions.Logging;

namespace FormItemExample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseDevExpress()
			.UseDevExpressCollectionView()
			.UseDevExpressControls()
			.UseDevExpressEditors()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("roboto-regular.ttf", "Roboto");
				fonts.AddFont("roboto-bold.ttf", "Roboto-Bold");
				fonts.AddFont("roboto-medium.ttf", "Roboto-Medium");
			});

		return builder.Build();
	}
}
