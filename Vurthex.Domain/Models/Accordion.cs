using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Domain.Models
{
    public class Accordion:BaseModel
    {
        public int Id { get; set; }
        public string AccordionName { get; set; }
        public string AccordionPhoto { get; set; }
        public string AccordionDescription { get; set; }
        public string AccordionTitle { get; set; }
        public string AccordionUrl { get; set; }
    }
}
