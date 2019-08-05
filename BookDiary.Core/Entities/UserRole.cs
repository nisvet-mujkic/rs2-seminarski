using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Core.Entities
{
    public class UserRole: BaseEntity
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
