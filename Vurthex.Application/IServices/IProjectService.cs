using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IProjectService
    {

        public Task<List<ProjectDTO>> GetProjects();
        public Task<ProjectDTO> CreateProject(ProjectDTO Project);
        public Task<ProjectDTO> UpdateProject(ProjectDTO Project);
        public Task<bool> DeleteProjectId(Guid id);
        public Task<ProjectDTO> GetProjectById(Guid id);
    }
}
