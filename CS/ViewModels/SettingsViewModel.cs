using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace FormItemExample;

public class SettingsViewModel : INotifyPropertyChanged {
    string language;
    List<string> blackList = new();
    bool isPrivateChatEnabled = true;
    bool isGroupChatEnabled;
    bool isSoundEnabled = true;
    bool isVibrationEnabled = true;

    public SettingsViewModel() {
        Language = "English";
    }
    public string Language {
        get => this.language;
        set {
            this.language = value;
            OnPropertyChanged();
        }
    }
    public bool IsPrivateChatEnabled {
        get => this.isPrivateChatEnabled;
        set {
            this.isPrivateChatEnabled = value;
            OnPropertyChanged();
        }
    }
    public bool IsGroupChatEnabled {
        get => this.isGroupChatEnabled;
        set {
            this.isGroupChatEnabled = value;
            OnPropertyChanged();
        }
    }
    public bool IsSoundEnabled {
        get => this.isSoundEnabled;
        set {
            this.isSoundEnabled = value;
            OnPropertyChanged();
        }
    }
    public bool IsVibrationEnabled {
        get => this.isVibrationEnabled;
        set {
            this.isVibrationEnabled = value;
            OnPropertyChanged();
        }
    }
    public List<string> BlackList {
        get => this.blackList;
        set {
            this.blackList = value;
            OnPropertyChanged();
        }
    }
    public List<string> Languages { get; } = new() { "English", "German", "French", "Spanish", "Italian", "Russian", "Chinese", "Japanese" };
    public ICommand SelectLanguageCommand => new Command<string>(SelectLanguage);
    public ICommand SelectBlackListCommand => new Command<string>(SelectBlackList);

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    async void SelectLanguage(string obj) {
        Dictionary<string, object> parameters = new() {
            { "Settings", this }
        };
        await Shell.Current.GoToAsync("SelectLanguagePage", parameters);
    }
    async void SelectBlackList(string obj) {
        Dictionary<string, object> parameters = new() {
            { "Settings", this }
        };
        await Shell.Current.GoToAsync("BlackListPage", parameters);
    }
}