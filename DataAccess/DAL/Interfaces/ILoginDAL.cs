using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.Interfaces
{
    public interface ILoginDAL
    {
        Task<bool> LoginAsync(string email, string password);
        
    }
}
