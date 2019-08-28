using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Infrastructure.Entities
{
    public class Book: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [Required]
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int PagesInTotal { get; set; }
        public int YearPublished { get; set; }
        public byte[] CoverImage { get; set; }
        public string Subject { get; set; }
    }
}
