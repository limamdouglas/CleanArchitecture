using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.User.Delete;

public sealed class UserDeleteMapper : Profile
{
    public UserDeleteMapper()
    {
        CreateMap<UserDeleteRequest, CleanArchitecture.Domain.Entities.User>();
        CreateMap<CleanArchitecture.Domain.Entities.User, UserDeleteResponse>();
    }
}
