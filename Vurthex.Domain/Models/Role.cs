using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Domain.Models
{
    public class Role:BaseModel
    {
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public ICollection<User>? users { get; set; }

    }
}
