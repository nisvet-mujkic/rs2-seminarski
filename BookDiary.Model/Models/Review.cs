using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Model.Models
{
    public class Review
    {
        public int Id { get; set; }
        public bool Archived { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rating { get; set; }
        public int UserBookId { get; set; }
        public UserBook UserBook { get; set; }
        public string Summary { get; set; }
        public string QuoteToRemember { get; set; }
        public bool? Approved { get; set; }
    }
}
