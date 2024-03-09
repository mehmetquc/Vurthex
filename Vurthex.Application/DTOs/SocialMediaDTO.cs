using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class SocialMediaDTO:BaseModelDTO
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}
