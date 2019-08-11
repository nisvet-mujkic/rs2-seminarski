using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Infrastructure.Entities
{
    public class ReadingActivity: BaseEntity
    {
        [Required]
        [ForeignKey(nameof(UserBook))]
        public int UserBookId { get; set; }
        public UserBook UserBook { get; set; }
        public int PagesRead { get; set; }
    }
}
