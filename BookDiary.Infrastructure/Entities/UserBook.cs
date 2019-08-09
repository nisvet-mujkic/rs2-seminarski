using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Infrastructure.Entities
{
    public class UserBook: BaseEntity
    {
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime StartedReadingOn { get; set; }
        public DateTime? FinishedReadingOn { get; set; }
    }
}
