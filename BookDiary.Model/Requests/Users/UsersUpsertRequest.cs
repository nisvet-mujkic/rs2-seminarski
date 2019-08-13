using System.Collections.Generic;

namespace BookDiary.Model.Requests.Users
{
    public class UsersUpsertRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public bool Archived { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public List<int> Roles { get; set; } = new List<int>();
    }
}
