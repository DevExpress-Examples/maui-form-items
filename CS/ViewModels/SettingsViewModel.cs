using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FormItemExample.Views;

namespace FormItemExample;

public class SettingsViewModel : INotifyPropertyChanged {
    string language;
    List<string> blacklist = new();
    bool isPrivateChatEnabled = true;
    bool isGroupChatEnabled;
    bool isSoundEnabled = true;
    string vibrationMode;
    string bio;

    public SettingsViewModel() {
        Language = "English";
        VibrationMode = "Default";
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
    public string VibrationMode {
        get => this.vibrationMode;
        set {
            this.vibrationMode = value;
            OnPropertyChanged();
        }
    }
    public string Bio {
        get => this.bio;
        set {
            this.bio = value;
            OnPropertyChanged();
        }
    }
    public List<string> Blacklist {
        get => this.blacklist;
        set {
            this.blacklist = value;
            OnPropertyChanged();
        }
    }
    public List<string> VibrationModes { get; } = new() {
        "Disabled", "Default", "Short", "Long", "Only in Silent Mode"
    };
    public List<string> Contacts { get; } = new() {
        "Bruce Cambell", "Andrea Deville", "Anita Ryan", "George Bunkelman", "Anita Cardle", "Andrew Carter", "Almas Basinger", "Carolyn Baker", "Anthony Rounds"
    };
    public List<string> Languages { get; } = new() {
        "English", "German", "French", "Spanish", "Italian", "Russian", "Chinese", "Japanese"
    };
    public ICommand EditBioCommand => new Command(EditBio);

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    async void EditBio() {
        Dictionary<string, object> parameters = new() {
            { "Settings", this }
        };
        await Shell.Current.GoToAsync("EditBioPage", parameters);
    }
}