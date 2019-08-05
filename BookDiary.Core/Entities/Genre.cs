using System.ComponentModel.DataAnnotations;

namespace BookDiary.Core.Entities
{
    public class Genre: BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
