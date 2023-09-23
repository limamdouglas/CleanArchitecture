using AutoMapper;
using MediatR;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.UseCases.User.Create;

public sealed class UserCreateHandler : IRequestHandler<UserCreateRequest, UserCreateResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserCreateHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserCreateResponse> Handle(UserCreateRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<CleanArchitecture.Domain.Entities.User>(request);

        _userRepository.Create(user);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UserCreateResponse>(user);
    }

}
