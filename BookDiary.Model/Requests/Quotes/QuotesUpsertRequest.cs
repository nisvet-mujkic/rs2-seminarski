namespace BookDiary.Model.Requests.Quotes
{
    public class QuotesUpsertRequest
    {
        public string QuoteText { get; set; }
        public int? BookId { get; set; }
        public bool Archived { get; set; }
    }
}
