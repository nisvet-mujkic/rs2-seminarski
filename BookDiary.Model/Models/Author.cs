using System.ComponentModel.DataAnnotations;

namespace BookDiary.Model.Models
{
    public class Author: BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
