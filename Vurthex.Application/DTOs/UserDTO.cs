using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class UserDTO:BaseModelDTO
    {
        public Guid RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPhoto { get; set; }
        public string? UserPhone { get; set; }
        public string UserDescription { get; set; }
        public string UserPassword { get; set; }

        public String FullName => $"{FirstName} {LastName}";
    }
}
