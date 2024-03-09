using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class TechnologyDTO:BaseModelDTO
    {
        public string TechnologyLogo { get; set; }
        public string TechnologyName { get; set; }
        public string TechnologyDescription { get; set; }
    }
}
