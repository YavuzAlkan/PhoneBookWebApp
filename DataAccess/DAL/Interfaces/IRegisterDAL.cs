using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Interfaces
{
    public interface IRegisterDAL
    {
        Task<IdentityResult> RegisterAsync(User user,string password);
        Task<User> GetUserByEmailAsync(string email);
    }
}
