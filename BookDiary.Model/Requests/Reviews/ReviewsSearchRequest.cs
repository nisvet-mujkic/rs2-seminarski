using System;

namespace BookDiary.Model.Requests.Reviews
{
    public class ReviewsSearchRequest
    {
        public bool ShowPendingReviews { get; set; }
        public bool ShowApprovedReviews { get; set; }
        public bool ShowRejectedReviews { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool IsUsersLoadingEnabled { get; set; }
        public bool IsBooksLoadingEnabled { get; set; }
    }
}
