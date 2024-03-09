using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface ITechnologyService
    {
        public Task<List<TechnologyDTO>> GetTechnologys();
        public Task<TechnologyDTO> CreateTechnology(TechnologyDTO Technology);
        public Task<TechnologyDTO> UpdateTechnology(TechnologyDTO Technology);
        public Task<bool> DeleteTechnologyId(Guid id);
        public Task<TechnologyDTO> GetTechnologyById(Guid id);
    }
}
