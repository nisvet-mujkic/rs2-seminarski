namespace BookDiary.Model.Requests.UserRoles
{
    public class UserRolesSearchRequest
    {
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public bool IsRolesLoadingEnabled { get; set; }
        public bool IsUsersLoadingEnabled { get; set; }
    }
}
