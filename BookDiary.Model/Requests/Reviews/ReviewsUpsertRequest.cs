using System;

namespace BookDiary.Model.Requests.Reviews
{
    public class ReviewsUpsertRequest
    {

        public int Rating { get; set; }
        public int UserBookId { get; set; }
        public string Summary { get; set; }
        public string QuoteToRemember { get; set; }
        public bool? Approved { get; set; }
        public bool Archived { get; set; }
    }
}
