using System.Collections.ObjectModel;
using System.Windows.Input;
using Versus.Core.Contracts.Services.General;
using Versus.Core.Enumerations;
using Versus.Core.Models;
using Versus.Core.ViewModels.Base;
using Xamarin.Forms;

namespace Versus.Core.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        private ObservableCollection<MainMenuItem> _menuItems;
        private readonly ISettingsService _settingsService;

        public MenuViewModel(IConnectionService connectionService,
            INavigationService navigationService, IDialogService dialogService,
            ISettingsService settingsService)
            : base(connectionService, navigationService, dialogService)
        {
            _settingsService = settingsService;
            MenuItems = new ObservableCollection<MainMenuItem>();
            LoadMenuItems();
        }

        public ICommand MenuItemTappedCommand => new Command(OnMenuItemTapped);

        public ObservableCollection<MainMenuItem> MenuItems
        {
            get => _menuItems;
            set
            {
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        private void OnMenuItemTapped(object menuItemTappedEventArgs)
        {
            var menuItem = ((menuItemTappedEventArgs as ItemTappedEventArgs)?.Item as MainMenuItem);

            if (menuItem != null && menuItem.MenuText == "Sign Out")
            {
                _settingsService.UserIdSetting = null;
                _settingsService.UserNameSetting = null;
                _navigationService.ClearBackStack();
            }

            var type = menuItem?.ViewModelToLoad;
            _navigationService.NavigateToAsync(type);
        }

        private void LoadMenuItems()
        {
            MenuItems.Add(new MainMenuItem
            {
                MenuText = "Matches",
                //ViewModelToLoad = typeof(MatchesViewModel),
                ViewModelToLoad = typeof(SignInViewModel),
                MenuItemType = MenuItemType.Matches
            });

            MenuItems.Add(new MainMenuItem
            {
                MenuText = "Competitions",
                //ViewModelToLoad = typeof(CompetitionsViewModel),
                ViewModelToLoad = typeof(SignInViewModel),
                MenuItemType = MenuItemType.Competitions
            });

            MenuItems.Add(new MainMenuItem
            {
                MenuText = "Teams",
                //ViewModelToLoad = typeof(TeamsViewModel),
                ViewModelToLoad = typeof(SignInViewModel),
                MenuItemType = MenuItemType.Teams
            });

            MenuItems.Add(new MainMenuItem
            {
                MenuText = "Sign Out",
                ViewModelToLoad = typeof(SignInViewModel),
                MenuItemType = MenuItemType.SignOut
            });

            MenuItems.Add(new MainMenuItem
            {
                MenuText = "Settings",
                //ViewModelToLoad = typeof(SettingsViewModel),
                ViewModelToLoad = typeof(SignInViewModel),
                MenuItemType = MenuItemType.Settings
            });
        }
    }
}
