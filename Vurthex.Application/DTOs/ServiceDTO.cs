using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class ServiceDTO:BaseModelDTO
    {
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ServicePhoto { get; set; }
        public string ServiceText { get; set; }
        public string ServiceMetaLink { get; set; }
        public string ServiceMetaTitle { get; set; }
        public string ServiceMetaKeyWords { get; set; }
        public string ServiceMetaDescription { get; set; }

    }
}
