using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : IdentityUser    
    {
        
        private bool _isActive = true;      
        public bool IsActive { get => _isActive; set => _isActive = value; }
    }
}
