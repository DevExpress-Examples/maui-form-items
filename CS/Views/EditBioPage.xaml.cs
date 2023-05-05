using DevExpress.Maui.Editors;

namespace FormItemExample.Views;

[QueryProperty(nameof(Settings), "Settings")]
public partial class EditBioPage : ContentPage
{
    SettingsViewModel settings;
    public SettingsViewModel Settings {
        get => this.settings;
        set {
            this.settings = value;
            this.bioEditor.Text = value.Bio;
        }
    }
    public EditBioPage()
	{
		InitializeComponent();
	}

    private void OnAccept(object sender, EventArgs e) {
        Settings.Bio = this.bioEditor.Text;
        Shell.Current.GoToAsync("..");
    }

    private void bioEditor_Loaded(object sender, EventArgs e) {
        ((MultilineEdit)sender).Focus();
    }
}