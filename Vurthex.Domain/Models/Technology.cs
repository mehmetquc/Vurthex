using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Domain.Models
{
    public class Technology:BaseModel
    {
        public string TechnologyLogo { get; set; }
        public string TechnologyName { get; set; }
        public string TechnologyDescription { get; set; }
    }
}
