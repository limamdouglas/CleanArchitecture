using MediatR;

namespace CleanArchitecture.Application.UseCases.User.GetAll;

public sealed record UserGetAllRequest :
                   IRequest<List<UserGetAllResponse>>;