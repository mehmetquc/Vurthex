using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Domain.Models
{
    public class Contact:BaseModel
    {
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactAdressLong { get; set; }
        public string ContactAdresShort { get; set; }
    }
}
