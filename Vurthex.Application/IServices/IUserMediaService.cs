using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IUserMediaMediaService
    {
        public Task<List<UserMediaDTO>> GetUserMedias();
        public Task<UserMediaDTO> CreateUserMedia(UserMediaDTO UserMedia);
        public Task<UserMediaDTO> UpdateUserMedia(UserMediaDTO UserMedia);
        public Task<bool> DeleteUserMediaId(Guid id);
        public Task<UserMediaDTO> GetUserMediaById(Guid id);
    }
}
