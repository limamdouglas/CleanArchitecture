using AutoMapper;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.User.Udpdate;

public class UserUpdateHandler : IRequestHandler<UserUpdateRequest, UserUpdateResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserUpdateHandler(IUnitOfWork unitOfWork,
                             IUserRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }
    public async Task<UserUpdateResponse> Handle(UserUpdateRequest command,
                                                 CancellationToken cancellationToken)
    {
        var user = await _userRepository.Get(command.Id, cancellationToken);

        if (user is null) return default;

        user.Name = command.Name;
        user.Email = command.Email;

        _userRepository.Update(user);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UserUpdateResponse>(user);
    }
}
