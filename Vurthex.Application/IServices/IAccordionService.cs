using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IAccordionService
    {

        public Task<List<AccordionDTO>> GetAccordions();
        public Task<AccordionDTO> CreateAccordion(AccordionDTO Accordion);
        public Task<AccordionDTO> UpdateAccordion(AccordionDTO Accordion);
        public Task<bool> DeleteAccordionId(Guid id);
        public Task<AccordionDTO> GetAccordionById(Guid id);
    }
}
