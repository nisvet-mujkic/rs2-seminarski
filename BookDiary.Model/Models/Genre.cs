using System.ComponentModel.DataAnnotations;

namespace BookDiary.Model.Models
{
    public class Genre: BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
