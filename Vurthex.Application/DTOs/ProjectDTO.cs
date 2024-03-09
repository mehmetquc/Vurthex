using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class ProjectDTO:BaseModelDTO
    {
        public Guid ServiceId { get; set; }
        public Guid userID { get; set; }
        public string ProjectText { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectPhoto { get; set; }
        public string ProjectMetaLink { get; set; }
        public string ProjectMetaTitle { get; set; }
        public string ProjectMetaKeyWords { get; set; }
        public string ProjectMetaDescription { get; set; }
    }
}
