namespace BookDiary.Model.Requests.ReadingActivities
{
    public class ReadingActivitiesSearchRequest
    {
        public int? UserBookId { get; set; }
        public bool IsUserBooksLoadingEnabled { get; set; }
    }
}
