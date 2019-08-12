using BookDiary.Model.Requests.Books;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Books
{
    public partial class BooksForm : Form
    {
        private readonly ApiService _booksService = new ApiService("Books");
        private readonly ApiService _genresService = new ApiService("Genres");
        private readonly ApiService _authorsService = new ApiService("Authors");
        public BooksForm()
        {
            InitializeComponent();
        }

        private void AddBookBtn_Click(object sender, System.EventArgs e)
        {
            var addBookForm = new BookDetailsForm();
            addBookForm.Show();
        }

        private async void BooksForm_Load(object sender, System.EventArgs e)
        {
            await LoadAuthors();
            await LoadGenres();
            var searchRequest = new BooksSearchRequest()
            {
                IsGenresLoadingEnabled = true,
                IsAuthorsLoadingEnabled = true
            };

            await LoadBooks(searchRequest);
        }

        private async Task LoadBooks(BooksSearchRequest searchRequest = null)
        {
            var entities = await _booksService.Get<List<Model.Models.Book>>(searchRequest);
            booksDataGridView.AutoGenerateColumns = false;
            booksDataGridView.DataSource = entities;
        }

        private async void SearchBooksBtn_Click(object sender, System.EventArgs e)
        {
            var searchRequest = new BooksSearchRequest()
            {
                IsAuthorsLoadingEnabled = true,
                IsGenresLoadingEnabled = true,
                SearchTerm = bookSearchTermTextBox.Text.Trim()
            };

            var genreIdObj = bookGenresComboBox.SelectedValue;

            if (int.TryParse(genreIdObj.ToString(), out int genreId))
            {
                searchRequest.GenreId = genreId;
            }

            var authorIdObj = bookGenresComboBox.SelectedValue;

            if (int.TryParse(authorIdObj.ToString(), out int authorId))
            {
                searchRequest.AuthorId = authorId;
            }

            await LoadBooks(searchRequest);
        }

        private async Task LoadGenres()
        {
            var genreEntities = await _genresService.Get<List<Model.Models.Genre>>(null);
            genreEntities.Insert(0, new Model.Models.Genre());
            bookGenresComboBox.DisplayMember = "Name";
            bookGenresComboBox.ValueMember = "Id";
            bookGenresComboBox.DataSource = genreEntities;
        }

        private async Task LoadAuthors()
        {
            var authorEntities = await _authorsService.Get<List<Model.Models.Author>>(null);
            authorEntities.Insert(0, new Model.Models.Author());
            bookAuthorsComboBox.DisplayMember = "Name";
            bookAuthorsComboBox.ValueMember = "Id";
            bookAuthorsComboBox.DataSource = authorEntities;
        }

        private void BooksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var bookId = int.Parse(booksDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            var bookDetailsForm = new BookDetailsForm(bookId);
            bookDetailsForm.Show();
        }
    }
}
