using System.ComponentModel.DataAnnotations;

namespace BookDiary.Core.Entities
{
    public class Author: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
