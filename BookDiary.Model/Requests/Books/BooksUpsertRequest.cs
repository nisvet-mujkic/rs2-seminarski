namespace BookDiary.Model.Requests.Books
{
    public class BooksUpsertRequest
    {
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public byte[] CoverImage { get; set; }
        public int PagesInTotal { get; set; }
        public int YearPublished { get; set; }
    }
}
