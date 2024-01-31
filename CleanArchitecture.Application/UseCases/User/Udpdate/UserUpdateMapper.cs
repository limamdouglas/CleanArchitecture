using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.User.Udpdate;

public sealed class UserUpdateMapper : Profile
{
    public UserUpdateMapper()
    {
        CreateMap<UserUpdateRequest, CleanArchitecture.Domain.Entities.User>();
        CreateMap<CleanArchitecture.Domain.Entities.User, UserUpdateResponse>();
    }
}
