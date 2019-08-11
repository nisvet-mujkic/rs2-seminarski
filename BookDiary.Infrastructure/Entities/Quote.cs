using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Infrastructure.Entities
{
    public class Quote: BaseEntity
    {
        [Required]
        public string QuoteText { get; set; }
        [ForeignKey(nameof(Book))]
        public int? BookId { get; set; }
        public Book Book { get; set; }
    }
}
