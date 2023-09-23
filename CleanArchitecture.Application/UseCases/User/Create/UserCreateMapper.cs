using AutoMapper;

namespace CleanArchitecture.Application.UseCases.User.Create;

public sealed class UserCreateMapper : Profile
{
    public UserCreateMapper()
    {
        CreateMap<UserCreateRequest, CleanArchitecture.Domain.Entities.User>();
        CreateMap<CleanArchitecture.Domain.Entities.User, UserCreateResponse>();
    }
}
