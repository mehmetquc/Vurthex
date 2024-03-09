using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IBlogService
    {
        public Task<List<BlogDTO>> GetBlogs();
        public Task<BlogDTO> CreateBlog(BlogDTO Blog);
        public Task<BlogDTO> UpdateBlog(BlogDTO Blog);
        public Task<bool> DeleteBlogId(Guid id);
        public Task<BlogDTO> GetBlogById(Guid id);
    }
}
