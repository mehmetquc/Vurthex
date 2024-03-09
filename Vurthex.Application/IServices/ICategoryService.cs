using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface ICategoryService
    {
        public Task<List<CategoryDTO>> GetCategorys();
        public Task<CategoryDTO> CreateCategory(CategoryDTO Category);
        public Task<CategoryDTO> UpdateCategory(CategoryDTO Category);
        public Task<bool> DeleteCategoryId(Guid id);
        public Task<CategoryDTO> GetCategoryById(Guid id);
    }
}
