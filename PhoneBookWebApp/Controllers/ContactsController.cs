using DataAccess.DAL.Interfaces;
using DTO.ContactDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBookWebApp.Models;

namespace PhoneBookWebApp.Controllers
{

    public class ContactsController : Controller
    {
        readonly IContactDAL _contactDAL;
        private readonly IContactCrudDAL _contactCrudDAL;

        public ContactsController(IContactDAL contactDAL, IContactCrudDAL contactCrudDAL)
        {
            _contactDAL = contactDAL;
            _contactCrudDAL = contactCrudDAL;
        }
        public async Task<IActionResult> Contact()
        {
            var contacts = await _contactDAL.GetAllContactAsync();

            var contactVm = contacts.Select(a => new ContactVM
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                PhoneNumber = a.PhoneNumber,
                Id = a.ID
            }).ToList();

            return View(contactVm);
        }
        [HttpGet]
        public IActionResult GetAllContacts(string firstName, string lastName)
        {
            return View();
        }


        public async Task<IActionResult> DeleteContact(string id)
        {
            var intId = int.Parse(id);

            var result = await _contactCrudDAL.DeleteContactAsync(intId);

            if (result)
            {
                TempData["Success"] = "Kişi silindi!";
                return RedirectToAction("Contact");
            }
            TempData["Error"] = "Kişi silinemedi!";
            return RedirectToAction("Contact");
        }
        public async Task<IActionResult> UpdateContact(string id)
        {
            var intId = int.Parse(id);
            var result = await _contactDAL.GetContactAsync(intId);
            if (result != null)
            {
                var contactVM = new ContactVM
                {
                    FirstName=result.FirstName,
                    LastName=result.LastName,
                    PhoneNumber=result.PhoneNumber,
                    Id = intId
                };
                return View(contactVM);
            }

            return RedirectToAction("UpdateContact");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContacts(ContactVM contactVm)
        {
            var dto = new ContactDTO
            {
                FirstName = contactVm.FirstName,
                LastName = contactVm.LastName,
                PhoneNumber = contactVm.PhoneNumber,
                ID = contactVm.Id
            };
            var result = await _contactCrudDAL.UpdateContactAsync(dto);
            if (result)
            {
                TempData["Success"] = "Kişi güncellendi!";
                return RedirectToAction("Contact");
            }
            TempData["Error"] = "Kişi güncellenemedi!";
            return RedirectToAction("Contact");
        }
        public async Task<IActionResult> CreateContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContacts(CreateContactVM createContactVM)
        {
            //if (!ModelState.IsValid)
            //{
            //    ModelState.AddModelError("PhoneNumber", "Bu telefon numarası zaten kayıtlı.");
            //    return View(createContactVM);
            //}
                var dto = new ContactAddDTO
            {
                FirstName = createContactVM.FirstName,
                LastName = createContactVM.LastName,
                PhoneNumber = createContactVM.PhoneNumber,
            };
          var result=  await _contactCrudDAL.AddContactAsync(dto);
                if (result)
                {
                    return RedirectToAction("Contact");                    
                }            
            TempData["Error"] = "Bu telefon numarası zaten kayıtlı.";
            return RedirectToAction("CreateContact");
            }
    }
}
