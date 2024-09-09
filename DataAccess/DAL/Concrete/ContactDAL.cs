using DataAccess.Context;
using DataAccess.DAL.Interfaces;
using DTO.ContactDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Concrete
{
    public class ContactDAL : IContactDAL
    {
        readonly PhoneBookAppDbContext _context;
        public ContactDAL(PhoneBookAppDbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<ContactDTO>> GetAllContactAsync()
        {
            return await _context.Contact.Where(a => a.IsActive == true).Select(a => new ContactDTO
            {
                ID =a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                PhoneNumber = a.PhoneNumber
            }).AsNoTracking().ToListAsync();
        }

        public async Task<ContactDTO> GetContactAsync(int id)
        {
          return  await _context.Contact.Where(a=>a.Id==id).Select(a=>new ContactDTO
          {
              FirstName = a.FirstName,
              LastName = a.LastName,
              PhoneNumber = a.PhoneNumber,
              ID=a.Id
              
          }).SingleOrDefaultAsync() ?? new ContactDTO();
        }
    }
}
