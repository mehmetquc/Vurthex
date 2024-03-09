using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class RoleDTO:BaseModelDTO
    {
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }
}
