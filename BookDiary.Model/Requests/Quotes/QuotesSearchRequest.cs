namespace BookDiary.Model.Requests.Quotes
{
    public class QuotesSearchRequest
    {
        public int? BookId { get; set; }
        public int? AuthorId { get; set; }
        public bool IsBooksLoadingEnabled { get; set; }
        public bool ShowArchived { get; set; }
    }
}
