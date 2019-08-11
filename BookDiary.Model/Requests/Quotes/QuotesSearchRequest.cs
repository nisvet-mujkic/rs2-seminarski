namespace BookDiary.Model.Requests.Quotes
{
    public class QuotesSearchRequest
    {
        public int? BookId { get; set; }
        public bool IsBooksLoadingEnabled { get; set; }
    }
}
