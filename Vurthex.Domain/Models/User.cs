using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models.BaseModels;

namespace Vurthex.Domain.Models
{
    public class User:BaseModel
    {
        public Guid RoleID { get; set; }
        public Role? Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPhoto { get; set; }
        public string? UserPhone { get; set; }
        public string UserDescription { get; set; }
        public string UserPassword { get; set; }
        
        public ICollection<UserMedia>?UserMedias { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
