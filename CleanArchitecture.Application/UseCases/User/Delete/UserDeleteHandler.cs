using AutoMapper;
using CleanArchitecture.Domain.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.UseCases.User.Delete;

public sealed class UserDeleteHandler :
                    IRequestHandler<UserDeleteRequest, UserDeleteResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserDeleteHandler(IUnitOfWork unitOfWork,
                             IUserRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserDeleteResponse> Handle(UserDeleteRequest request,
                                                 CancellationToken cancellationToken)
    {

        var user = await _userRepository.Get(request.Id, cancellationToken);

        if (user == null) return default;

        _userRepository.Delete(user);
        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UserDeleteResponse>(user);
    }
}
