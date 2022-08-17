using BuberDinner.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string Firstname,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;