using DataAccess.Context;
using DataAccess.DAL.Interfaces;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Concrete
{
    public class LoginDAL : ILoginDAL
    {

        
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public LoginDAL(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager; 
        }
        public async Task<bool> LoginAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return false; // Kullanıcı bulunamadı
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

            return result.Succeeded;
        }
    }
}
