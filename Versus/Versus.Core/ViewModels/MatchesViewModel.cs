using Versus.Core.Contracts.Services.General;
using Versus.Core.ViewModels.Base;

namespace Versus.Core.ViewModels
{
    public class MatchesViewModel : ViewModelBase
    {
        public MatchesViewModel(IConnectionService connectionService,
            INavigationService navigationService, IDialogService dialogService)
            : base(connectionService, navigationService, dialogService)
        {
        }
    }
}
