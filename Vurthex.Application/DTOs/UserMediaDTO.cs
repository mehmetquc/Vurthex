using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class UserMediaDTO:BaseModelDTO
    {
        public Guid UserId { get; set; }
        public string UserMediaIcon { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
