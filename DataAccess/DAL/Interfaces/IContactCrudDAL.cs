using DTO.ContactDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Interfaces
{
    public interface IContactCrudDAL
    {
        Task<bool> AddContactAsync(ContactAddDTO contactAddDTO);
        Task<bool> UpdateContactAsync(ContactDTO contactDTO);
        Task<bool> DeleteContactAsync(int id);
    }
}
