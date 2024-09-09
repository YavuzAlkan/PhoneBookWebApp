using DataAccess.DAL.Interfaces;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhoneBookWebApp.Models;

namespace PhoneBookWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly ILoginDAL _login;
        private readonly IRegisterDAL _register;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IPasswordHasher<User> passwordHasher, ILoginDAL login,IRegisterDAL register)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _passwordHasher = passwordHasher;
            _login = login;
            _register = register;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn(LoginVm model) 
        {
            if (model is null)
            {
                TempData["Error"] = "Kullanıcı adı veya şifre yanlış!";
                return View(model);
            }
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Kullanıcı adı veya şifre yanlış!";
                return View(model);
            }
            var result = await _login.LoginAsync(model.Email,model.Password);
            if (result)
            {
                TempData["Success"] = "Giriş Başarılı.";
                return RedirectToAction("Contact", "Contacts");
            }
            TempData["Error"] = "Kullanıcı adı veya şifre yanlış!";
            return View(model);
        }
        [HttpPost]       
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            

            TempData["Success"] = "Çıkış başarılı!";
            return Redirect("https://localhost:44368/");
        }
        [HttpGet]   
        public  IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var existingUser = await _register.GetUserByEmailAsync(model.Email);
            if (existingUser != null)
            {
                TempData["Error"] = "Bu mail adresi kayıtlı!";
                return View(model);
            }

            var user = new User
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _register.RegisterAsync(user, model.Password);
            if (result.Succeeded)
            {
                TempData["Success"] = "Kayıt başarılı bir şekilde gerçekleşmiştir.";
                return Redirect("https://localhost:44368/");
            }
            else
            {
                // Hata mesajlarını al
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                // Hata mesajlarını tarayıcıda görmek için
                TempData["Error"] = "Kayıt sırasında bir hata oluştu. Detaylar: " + string.Join(", ", result.Errors.Select(e => e.Description));
            }

            return View(model);
        }
    }
}
