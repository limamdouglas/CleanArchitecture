using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.User.GetAll;

public sealed class UserGetAllMapper : Profile
{
    public UserGetAllMapper()
    {
        CreateMap<CleanArchitecture.Domain.Entities.User, UserGetAllResponse>();
    }
}
