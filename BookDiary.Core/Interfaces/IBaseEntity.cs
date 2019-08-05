using System;

namespace BookDiary.Core.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        bool Archived { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
