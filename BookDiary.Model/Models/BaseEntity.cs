using System;

namespace BookDiary.Model.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Archived { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
