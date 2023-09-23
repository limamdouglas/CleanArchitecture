using MediatR;

namespace CleanArchitecture.Application.UseCases.User.Create;

public sealed record UserCreateRequest(string Email, string Name) : IRequest<UserCreateResponse>;
