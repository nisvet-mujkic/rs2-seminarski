using System.ComponentModel.DataAnnotations;

namespace BookDiary.Infrastructure.Entities
{
    public class Author: BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
