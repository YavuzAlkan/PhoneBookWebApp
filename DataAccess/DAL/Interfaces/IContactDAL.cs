using DataAccess.DAL.Concrete;
using DTO.ContactDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Interfaces
{
    public interface IContactDAL
    {
        Task<ICollection<ContactDTO>> GetAllContactAsync();
        Task<ContactDTO> GetContactAsync(int id);
    }
}
