namespace BookDiary.Model.Requests.Authors
{
    public class AuthorsUpsertRequest
    {
        public string Name { get; set; }
        public bool Archived { get; set; }
    }
}
