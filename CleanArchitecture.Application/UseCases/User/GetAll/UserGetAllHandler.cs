using AutoMapper;
using CleanArchitecture.Domain.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.UseCases.User.GetAll;

public sealed class UserGetAllHandler : IRequestHandler<UserGetAllRequest, List<UserGetAllResponse>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserGetAllHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<List<UserGetAllResponse>> Handle(UserGetAllRequest request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAll(cancellationToken);
        return _mapper.Map<List<UserGetAllResponse>>(users);
    }
}
