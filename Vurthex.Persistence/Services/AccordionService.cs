using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;
using Vurthex.Application.IServices;
using Vurthex.Domain.Models;
using Vurthex.Persistence.Context;

namespace Vurthex.Persistence.Services
{
    public class AccordionService : IAccordionService
    {
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly VurthexPsqlDbContext context;
        public AccordionService(IMapper _mapper, IConfiguration _configuration, VurthexPsqlDbContext _context)
        {
            mapper = _mapper;
            configuration = _configuration;
            context = _context;
        }

        public Task<AccordionDTO> CreateAccordion(AccordionDTO Accordion)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAccordionId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AccordionDTO> GetAccordionById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AccordionDTO>> GetAccordions()
        {
            throw new NotImplementedException();
        }

        public Task<AccordionDTO> UpdateAccordion(AccordionDTO Accordion)
        {
            throw new NotImplementedException();
        }
    }
}
