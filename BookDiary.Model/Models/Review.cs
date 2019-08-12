using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Model.Models
{
    public class Review: BaseEntity
    {
        public int Rating { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string Summary { get; set; }
        public string QuoteToRemember { get; set; }
        public bool? Approved { get; set; }
    }
}
