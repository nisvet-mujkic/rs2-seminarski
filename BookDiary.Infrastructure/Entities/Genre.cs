using System.ComponentModel.DataAnnotations;

namespace BookDiary.Infrastructure.Entities
{
    public class Genre: BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
