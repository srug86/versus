using System.Threading.Tasks;
using Versus.Core.Contracts.Services.Data;
using Versus.Core.Models;

namespace Versus.Core.Services.Data
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService()
        {
        }

        public bool IsUserAuthenticated()
        {
            return true;
        }

        public async Task<AuthenticationResponse> Authenticate(string userName, string password)
        {
            return new AuthenticationResponse
            {
                IsAuthenticated = true,
                User = new User
                {
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "john.doe",
                    Email = "john.doe@company.com",
                    Id = "1"
                }
            };
        }
    }
}
