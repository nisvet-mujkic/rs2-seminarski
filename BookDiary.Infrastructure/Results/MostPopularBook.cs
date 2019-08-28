namespace BookDiary.Infrastructure.Results
{
    public class MostPopularBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int TotalTimesRead { get; set; }
    }
}
