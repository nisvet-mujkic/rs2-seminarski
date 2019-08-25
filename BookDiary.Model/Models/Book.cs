using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDiary.Model.Models
{
    public class Book: BaseEntity
    {
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int PagesInTotal { get; set; }
        public int YearPublished { get; set; }
        public byte[] CoverImage { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
