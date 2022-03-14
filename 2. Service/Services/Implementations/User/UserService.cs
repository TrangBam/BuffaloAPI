using Abstractions.Interfaces;
using AutoMapper;
using Common.Exceptions;
using Common.Resources;
using DTOs.Buffalo.User;
using Entities.Buffalo;
using EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            return await _unitOfWork.GetRepository<User>()
                .GetAll()
                .Select(x => _mapper.Map<UserDto>(x))
                .ToListAsync();
        }

        public async Task<UserDto> GetUserAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<User>()
                .GetAll()
                .Select(x => _mapper.Map<UserDto>(x))
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task CreateUserAsync(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            await _unitOfWork.GetRepository<User>().InsertAsync(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateUserAsync(UserDto dto)
        {
            var userFromDb = await _unitOfWork.GetRepository<User>()
                .GetAll()
                .FirstOrDefaultAsync(x => x.Id == dto.Id);

            var user = _mapper.Map(dto, userFromDb);
            await _unitOfWork.GetRepository<User>().UpdateAsync(user);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteUserAsync(Guid id)
        {
            await _unitOfWork.GetRepository<User>().DeleteAsync(id);
        }
    }
}
