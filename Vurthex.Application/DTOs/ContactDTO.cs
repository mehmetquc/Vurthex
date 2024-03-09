using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class ContactDTO:BaseModelDTO
    {
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactAdressLong { get; set; }
        public string ContactAdresShort { get; set; }
    }
}
