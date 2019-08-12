namespace BookDiary.Model.Requests.Books
{
    public class BooksSearchRequest
    {
        public bool IsAuthorsLoadingEnabled { get; set; }
        public bool IsGenresLoadingEnabled { get; set; }
        public string SearchTerm { get; set; }
        public int? GenreId { get; set; }
        public int? AuthorId { get; set; }
    }
}
