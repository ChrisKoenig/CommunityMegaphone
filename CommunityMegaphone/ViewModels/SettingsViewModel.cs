using CommunityMegaphone.Helpers;
using CommunityMegaphone.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CommunityMegaphone.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public RelayCommand SaveSettingsCommand { get; private set; }

        public RelayCommand LoadSettingsCommand { get; private set; }

        public SettingsViewModel()
        {
            SaveSettingsCommand = new RelayCommand(() => SaveSettings());
            LoadSettingsCommand = new RelayCommand(() => LoadSettings());
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                LoadSettings();
            }
        }

        private void SaveSettings()
        {
            IsolatedStorageHelper.SaveObjectToIsolatedStorage<UserSettings>(this.UserSettings, "UserSettings");
        }

        private void LoadSettings()
        {
            UserSettings = IsolatedStorageHelper.LoadObjectFromIsolatedStorage<UserSettings>("UserSettings");
        }

        #region UserSettings

        public const string UserSettingsPropertyName = "UserSettings";

        private UserSettings _userSettings = new UserSettings();

        public UserSettings UserSettings
        {
            get
            {
                return _userSettings;
            }

            set
            {
                if (_userSettings == value)
                {
                    return;
                }

                var oldValue = _userSettings;
                _userSettings = value;
                RaisePropertyChanged(UserSettingsPropertyName);
            }
        }

        #endregion UserSettings
    }
}