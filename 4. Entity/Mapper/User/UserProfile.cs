using AutoMapper;
using Common.Helpers;
using DTOs.Buffalo.User;
using Mapper.Utils;

namespace Mapper.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.Buffalo.User, UserDto>()
                .IgnoreAllNonExisting();

            CreateMap<CreateUserDto, Entities.Buffalo.User>()
                .IgnoreAllNonExisting();

            CreateMap<UserDto, Entities.Buffalo.User>()
                .IgnoreAllNonExisting();
        }
    }
}
