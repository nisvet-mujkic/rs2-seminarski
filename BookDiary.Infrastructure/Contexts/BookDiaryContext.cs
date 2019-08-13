using BookDiary.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookDiary.Infrastructure.Data
{
    public class BookDiaryContext: DbContext
    {
        public BookDiaryContext(DbContextOptions<BookDiaryContext> options): base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<ReadingActivity> ReadingActivities { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public object Korisnici { get; set; }
    }
}
