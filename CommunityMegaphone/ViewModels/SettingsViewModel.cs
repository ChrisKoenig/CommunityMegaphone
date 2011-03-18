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

        //#region Latitude property

        //public const string LatitudePropertyName = "Latitude";

        //private double _latitude = 0.0;

        //public double Latitude
        //{
        //    get
        //    {
        //        return _latitude;
        //    }

        //    set
        //    {
        //        if (_latitude == value)
        //        {
        //            return;
        //        }

        //        var oldValue = _latitude;
        //        _latitude = value;
        //        RaisePropertyChanged(LatitudePropertyName);
        //    }
        //}

        //#endregion Latitude property

        //#region Longitude property

        //public const string LongitudePropertyName = "Longitude";

        //private double _Longitude = 0.0;

        //public double Longitude
        //{
        //    get
        //    {
        //        return _Longitude;
        //    }

        //    set
        //    {
        //        if (_Longitude == value)
        //        {
        //            return;
        //        }

        //        var oldValue = _Longitude;
        //        _Longitude = value;
        //        RaisePropertyChanged(LongitudePropertyName);
        //    }
        //}

        //#endregion Longitude property
    }
}