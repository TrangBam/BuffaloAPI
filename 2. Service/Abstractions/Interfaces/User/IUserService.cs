using DTOs.Buffalo.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abstractions.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();

        Task<UserDto> GetUserAsync(Guid id);

        Task CreateUserAsync(CreateUserDto dto);

        Task DeleteUserAsync(Guid id);

        Task UpdateUserAsync(UserDto dto);
    }
}
