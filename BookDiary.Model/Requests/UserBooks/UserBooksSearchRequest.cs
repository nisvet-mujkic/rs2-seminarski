using System;

namespace BookDiary.Model.Requests.UserBooks
{
    public class UserBooksSearchRequest
    {
        public int UserId { get; set; }
        public bool IsUsersLoadingEnabled { get; set; }
        public bool IsBooksLoadingEnabled { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? FinishedOn { get; set; }
    }
}
