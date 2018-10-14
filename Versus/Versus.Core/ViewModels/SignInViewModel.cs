using Versus.Core.Contracts.Services.General;
using Versus.Core.ViewModels.Base;

namespace Versus.Core.ViewModels
{
    public class SignInViewModel : ViewModelBase
    {
        public SignInViewModel(IConnectionService connectionService,
            INavigationService navigationService, IDialogService dialogService)
            : base(connectionService, navigationService, dialogService)
        {
        }
    }
}
