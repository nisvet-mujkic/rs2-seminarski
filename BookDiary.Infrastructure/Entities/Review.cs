using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Infrastructure.Entities
{
    public class Review
    {
        [Key]
        public int UserBookId { get; set; }
        public UserBook UserBook { get; set; }
        public bool Archived { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int Rating { get; set; }
        
        public string Summary { get; set; }
        public string QuoteToRemember { get; set; }
        public bool? Approved { get; set; }
    }
}
