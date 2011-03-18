/*
  In App.xaml:
  <Application.Resources>
      <vm:GlobalViewModelLocator xmlns:vm="clr-namespace:CommunityMegaphone.ViewModels"
                                   x:Key="Locator" />
  </Application.Resources>

  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

namespace CommunityMegaphone.ViewModels
{
    public class GlobalViewModelLocator
    {
        public GlobalViewModelLocator()
        {
            CreateMainViewModel();
        }

        private static MainViewModel _main;

        /// <summary>
        /// Gets the MainViewModel property.
        /// </summary>
        public static MainViewModel MainViewModelStatic
        {
            get
            {
                if (_main == null)
                {
                    CreateMainViewModel();
                }

                return _main;
            }
        }

        /// <summary>
        /// Gets the MainViewModel property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel MainViewModel
        {
            get
            {
                return MainViewModelStatic;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MainViewModel property.
        /// </summary>
        public static void ClearMainViewModel()
        {
            _main.Cleanup();
            _main = null;
        }

        /// <summary>
        /// Provides a deterministic way to create the MainViewModel property.
        /// </summary>
        public static void CreateMainViewModel()
        {
            if (_main == null)
            {
                _main = new MainViewModel();
            }
        }

        private static SettingsViewModel _settings;

        /// <summary>
        /// Gets the SettingsViewModel property.
        /// </summary>
        public static SettingsViewModel SettingsViewModelStatic
        {
            get
            {
                if (_settings == null)
                {
                    CreateSettingsViewModel();
                }

                return _settings;
            }
        }

        /// <summary>
        /// Gets the SettingsViewModel property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public SettingsViewModel SettingsViewModel
        {
            get
            {
                return SettingsViewModelStatic;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the SettingsViewModel property.
        /// </summary>
        public static void ClearSettingsViewModel()
        {
            _settings.Cleanup();
            _settings = null;
        }

        /// <summary>
        /// Provides a deterministic way to create the SettingsViewModel property.
        /// </summary>
        public static void CreateSettingsViewModel()
        {
            if (_settings == null)
            {
                _settings = new SettingsViewModel();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
            ClearSettingsViewModel();
            ClearMainViewModel();
        }
    }
}