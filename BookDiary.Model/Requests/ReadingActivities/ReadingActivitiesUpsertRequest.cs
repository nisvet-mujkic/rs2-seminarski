namespace BookDiary.Model.Requests.ReadingActivities
{
    public class ReadingActivitiesUpsertRequest
    {
        public int UserBookId { get; set; }
        public int PagesRead { get; set; }
    }
}
