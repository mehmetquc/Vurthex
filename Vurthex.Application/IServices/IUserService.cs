﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IUserService
    {

        public Task<List<UserDTO>> GetUsers();
        public Task<UserDTO> CreateUser(UserDTO User);
        public Task<UserDTO> UpdateUser(UserDTO User);
        public Task<bool> DeleteUserId(Guid id);
        public Task<UserDTO> GetUserById(Guid id);

    }
}
