﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IServiceService
    {

        public Task<List<ServiceDTO>> GetServices();
        public Task<ServiceDTO> CreateService(ServiceDTO Service);
        public Task<ServiceDTO> UpdateService(ServiceDTO Service);
        public Task<bool> DeleteServiceId(Guid id);
        public Task<ServiceDTO> GetServiceById(Guid id);
    }
}
