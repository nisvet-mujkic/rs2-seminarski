using System;

namespace BookDiary.Infrastructure.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Archived { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
