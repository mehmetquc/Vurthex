using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Domain.Models
{
    public class UserMedia:BaseModel
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string UserMediaIcon { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaUrl { get; set; }
        public bool IsActive { get; set; }

    }
}
