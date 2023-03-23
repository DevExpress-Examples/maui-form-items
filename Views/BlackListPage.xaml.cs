using DevExpress.Maui.CollectionView;

namespace FormItemExample;

[QueryProperty(nameof(Settings), "Settings")]
public partial class BlackListPage : ContentPage {
    SettingsViewModel settings;

    public BlackListPage() {
        InitializeComponent();
        BindingContext = this;
    }

    public SettingsViewModel Settings {
        get => this.settings;
        set {
            this.settings = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(BlackList));
        }
    }
    public List<string> BlackList {
        get => Settings?.BlackList;
    }
    public List<string> Contacts { get; } = new() { "Bruce Cambell", "Andrea Deville", "Anita Ryan", "George Bunkelman", "Anita Cardle", "Andrew Carter", "Almas Basinger", "Carolyn Baker", "Anthony Rounds" };

    async void OnCollectionViewSelectionChanged(object sender, CollectionViewSelectionChangedEventArgs e) {
        await Shell.Current.GoToAsync("..");
    }
}