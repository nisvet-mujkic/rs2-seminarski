using System;

namespace BookDiary.Model.Requests.Reviews
{
    public class ReviewsSearchRequest
    {
        public int? BookId { get; set; }
        public bool ShowPendingReviews { get; set; }
        public bool ShowApprovedReviews { get; set; }
        public bool ShowRejectedReviews { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool IsUserBookLoadingEnabled { get; set; }
    }
}
