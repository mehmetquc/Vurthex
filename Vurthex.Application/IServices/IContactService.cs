using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;

namespace Vurthex.Application.IServices
{
    public interface IContactService
    {
        public Task<List<ContactDTO>> GetContacts();
        public Task<ContactDTO> CreateContact(ContactDTO Contact);
        public Task<ContactDTO> UpdateContact(ContactDTO Contact);
        public Task<bool> DeleteContactId(Guid id);
        public Task<ContactDTO> GetContactById(Guid id);
    }
}
