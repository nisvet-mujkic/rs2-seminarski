using System.ComponentModel.DataAnnotations;

namespace BookDiary.Core.Entities
{
    public class User: BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
