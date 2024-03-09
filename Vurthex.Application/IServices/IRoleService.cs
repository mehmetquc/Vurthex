using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IRoleService
    {

        public Task<List<RoleDTO>> GetRoles();
        public Task<RoleDTO> CreateRole(RoleDTO Role);
        public Task<RoleDTO> UpdateRole(RoleDTO Role);
        public Task<bool> DeleteRoleId(Guid id);
        public Task<RoleDTO> GetRoleById(Guid id);
    }
}
