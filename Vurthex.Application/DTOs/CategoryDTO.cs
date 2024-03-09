using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs.BaseModelDTOs;

namespace Vurthex.Application.DTOs
{
    public class CategoryDTO:BaseModelDTO
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryText { get; set; }
        public string CategoryPhoto { get; set; }
        public string CategoryMetaLink { get; set; }
        public string CategoryMetaTitle { get; set; }
        public string CategoryMetaDescription { get; set; }
        public string CategoryMetaKeyWords { get; set; }
    }
}
