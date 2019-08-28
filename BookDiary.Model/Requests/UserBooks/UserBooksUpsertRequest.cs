using System;

namespace BookDiary.Model.Requests.UserBooks
{
    public class UserBooksUpsertRequest
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime StartedReadingOn { get; set; }
        public DateTime? FinishedReadingOn { get; set; }
    }
}
