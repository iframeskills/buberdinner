using ErrorOr;
using BuberDinner.Application.Services.Authentication.Common;

namespace BuberDinner.Application.Services.Authentication.Commands;

public interface IAuthenticationCommandService
{
    ErrorOr<AuthenticationResult> Register(string firstName, string LastName, string email, string password);
}