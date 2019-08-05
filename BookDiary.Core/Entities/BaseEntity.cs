using BookDiary.Core.Interfaces;
using System;

namespace BookDiary.Core.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public bool Archived { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
