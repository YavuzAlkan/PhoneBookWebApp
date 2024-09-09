using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Contact 
    {
        private bool _isActive = true;

        [Key]      
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(13)]
        [Phone]
        public string PhoneNumber { get; set; }

        public bool IsActive { get => _isActive; set => _isActive = value; }
        

    }
}
