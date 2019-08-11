namespace BookDiary.Model.Requests.Users
{
    public class UsersSearchRequest
    {
        public string SearchTerm { get; set; }
        public bool ShowDisabledUsers { get; set; }
    }
}
