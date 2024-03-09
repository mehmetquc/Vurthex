using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Domain.Models
{
    public class Service:BaseModel
    {
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ServicePhoto { get; set; }
        public string ServiceText { get; set; }
        public string ServiceMetaLink { get; set; }
        public string ServiceMetaTitle { get; set; }
        public string ServiceMetaKeyWords { get; set; }
        public string ServiceMetaDescription { get; set; }
        
       public ICollection<Project> Projects { get; set; }


    }
}
