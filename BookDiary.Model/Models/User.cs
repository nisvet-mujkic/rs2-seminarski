using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookDiary.Model.Models
{
    public class User: BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
