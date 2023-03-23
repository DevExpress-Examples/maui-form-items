using DevExpress.Maui.CollectionView;

namespace FormItemExample;

[QueryProperty(nameof(Settings), "Settings")]
public partial class SelectLanguagePage : ContentPage {
    SettingsViewModel settings;

    public SelectLanguagePage() {
        InitializeComponent();
        BindingContext = this;
    }

    public SettingsViewModel Settings {
        get => this.settings;
        set {
            this.settings = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(Language));
        }
    }
    public string Language {
        get => Settings?.Language;
        set {
            Settings.Language = value;
            OnPropertyChanged();
        }
    }
    public List<string> Languages { get; } = new() { "English", "German", "French", "Spanish", "Italian", "Russian", "Chinese", "Japanese" };

    async void OnCollectionViewSelectionChanged(object sender, CollectionViewSelectionChangedEventArgs e) {
        DXCollectionView collectionView = (DXCollectionView)sender;
        if (e.SelectedItems.Count > 0 && (string)e.SelectedItems[0] == Language)
            return;

        if (e.SelectedItems.Count == 0 && e.DeselectedItems.Count > 0) {
            collectionView.SelectedItem = e.DeselectedItems[0];
        }
        Language = (string)collectionView.SelectedItem;
        await Shell.Current.GoToAsync("..");
    }
}