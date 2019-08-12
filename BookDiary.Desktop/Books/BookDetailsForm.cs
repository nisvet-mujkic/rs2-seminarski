using BookDiary.Model.Requests.Books;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Books
{
    public partial class BookDetailsForm : Form
    {
        private readonly ApiService _bookService = new ApiService("Books");
        private readonly ApiService _genresService = new ApiService("Genres");
        private readonly ApiService _authorsService = new ApiService("Authors");
        private int? _bookId = null;
        BooksUpsertRequest request = new BooksUpsertRequest();
        public BookDetailsForm(int? bookId = null)
        {
            InitializeComponent();
            _bookId = bookId;
        }

        private async void BookDetailsForm_Load(object sender, System.EventArgs e)
        {
            await LoadAuthors();
            await LoadGenres();
            if (_bookId.HasValue)
            {
                var entity = await _bookService.GetById<Model.Models.Book>(_bookId);
                bookTitleTextBox.Text = entity.Name;
                totalPagesTextBox.Text = entity.PagesInTotal.ToString();
                yearPublishedTextBox.Text = entity.PagesInTotal.ToString();
                archivedCheckBox.Checked = entity.Archived;
                bookGenreComboBox.SelectedValue = entity.GenreId;
                bookAuthorComboBox.SelectedValue = entity.AuthorId;
                //bookPictureBox. = entity.CoverImage;
            }
        }

        private async Task LoadGenres()
        {
            var genreEntities = await _genresService.Get<List<Model.Models.Genre>>(null);
            genreEntities.Insert(0, new Model.Models.Genre());
            bookGenreComboBox.DisplayMember = "Name";
            bookGenreComboBox.ValueMember = "Id";
            bookGenreComboBox.DataSource = genreEntities;
        }

        private async Task LoadAuthors()
        {
            var authorEntities = await _authorsService.Get<List<Model.Models.Author>>(null);
            authorEntities.Insert(0, new Model.Models.Author());
            bookAuthorComboBox.DisplayMember = "Name";
            bookAuthorComboBox.ValueMember = "Id";
            bookAuthorComboBox.DataSource = authorEntities;
        }

        private void AddPictureBtn_Click(object sender, System.EventArgs e)
        {
            var result = selectPictureDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = selectPictureDialog.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Picture = file;
                pictureTextBox.Text = fileName;

                Image image = Image.FromFile(fileName);
                bookPictureBox.Image = image;
            }
        }
    }
}
