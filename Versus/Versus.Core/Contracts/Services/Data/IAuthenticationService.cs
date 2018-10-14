using System.Threading.Tasks;
using Versus.Core.Models;

namespace Versus.Core.Contracts.Services.Data
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> Authenticate(string userName, string password);

        bool IsUserAuthenticated();
    }
}
