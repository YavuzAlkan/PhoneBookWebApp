using DataAccess.Context;
using DataAccess.DAL.Interfaces;
using DTO.ContactDTO;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Concrete
{
    public class ContactCrudDAL : IContactCrudDAL
    {
        readonly PhoneBookAppDbContext _context;
        public ContactCrudDAL(PhoneBookAppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddContactAsync(ContactAddDTO contactAddDTO)
        {
            var existingContact = await _context.Contact
            .FirstOrDefaultAsync(c => c.PhoneNumber == contactAddDTO.PhoneNumber);
            if (existingContact == null)
            {
                var contact = new Contact()
                {
                    FirstName = contactAddDTO.FirstName,
                    LastName = contactAddDTO.LastName,
                    PhoneNumber = contactAddDTO.PhoneNumber,
                };
                _context.Contact.Add(contact);
               return await _context.SaveChangesAsync()>0 ?true :false;
            }
            return false;

        }
        public async Task<bool> UpdateContactAsync(ContactDTO contactDTO)
        {
            var contactUpdate = await _context.Contact.Where(a => a.Id == contactDTO.ID).FirstOrDefaultAsync();
            if (contactUpdate == null)
            {
                throw new InvalidOperationException("Belirtilen ID'ye sahip bir Kişi bulunamadı!!");
            }
            contactUpdate.FirstName = contactDTO.FirstName;
            contactUpdate.LastName = contactDTO.LastName;
            contactUpdate.PhoneNumber = contactDTO.PhoneNumber;
           return await _context.SaveChangesAsync()>0 ?true : false;
        }
        public async Task<bool> DeleteContactAsync(int id)
        {
            var contactDelete = await _context.Contact.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (contactDelete == null)
            {
                throw new InvalidOperationException("Belirtilen ID'ye sahip bir Kişi bulunamamıştır!!");
            }
            contactDelete.IsActive = false;
            return await _context.SaveChangesAsync() > 0 ? true : false;
        }


    }
}
