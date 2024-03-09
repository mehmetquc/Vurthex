using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class BlogDTO:BaseModelDTO
    {
        public Guid CategoryId { get; set; }
         public Guid UserId { get; set; }
        public string BlogText { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public string BlogPhoto { get; set; }
        public string BlogMetaLink { get; set; }
        public string BlogMetaTitle { get; set; }
        public string BlogMetaDescription { get; set; }
        public string BlogMetaKeyWords { get; set; }
    }
}
