using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface ISocialMediaService
    {

        public Task<List<SocialMediaDTO>> GetSocialMedias();
        public Task<SocialMediaDTO> CreateSocialMedia(SocialMediaDTO SocialMedia);
        public Task<SocialMediaDTO> UpdateSocialMedia(SocialMediaDTO SocialMedia);
        public Task<bool> DeleteSocialMediaId(Guid id);
        public Task<SocialMediaDTO> GetSocialMediaById(Guid id);
    }
}
