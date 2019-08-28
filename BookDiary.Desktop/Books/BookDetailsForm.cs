using BookDiary.Desktop.Properties;
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
                subjectsTextBox.Text = entity.Subject;
                totalPagesNumeric.Value = entity.PagesInTotal;
                publishedInNumeric.Value = entity.YearPublished;
                archivedCheckBox.Checked = entity.Archived;
                bookGenreComboBox.SelectedValue = entity.GenreId;
                bookAuthorComboBox.SelectedValue = entity.AuthorId;
            }
        }

        private async Task LoadGenres()
        {
            var genreEntities = await _genresService.Get<List<Model.Models.Genre>>(null);
            bookGenreComboBox.DisplayMember = "Name";
            bookGenreComboBox.ValueMember = "Id";
            bookGenreComboBox.DataSource = genreEntities;
        }

        private async Task LoadAuthors()
        {
            var authorEntities = await _authorsService.Get<List<Model.Models.Author>>(null);
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

                request.CoverImage = file;
                pictureTextBox.Text = fileName;

                Image image = Image.FromFile(fileName);
                bookPictureBox.Image = image;
            }
        }

        private void BookTitleTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookTitleTextBox.Text))
            {
                e.Cancel = true;
                bookDetailsErrorProvider.SetError(bookTitleTextBox, Resources.Validation_RequiredField);
            }
            else
            {
                bookDetailsErrorProvider.SetError(bookTitleTextBox, null);
            }
        }

        private void TotalPagesTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (totalPagesNumeric.Value == 0)
            {
                e.Cancel = true;
                bookDetailsErrorProvider.SetError(totalPagesNumeric, Resources.Validation_RequiredField);
            }
            else
            {
                bookDetailsErrorProvider.SetError(totalPagesNumeric, null);
            }
        }

        private async void FinishBookBtn_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            var searchRequest = new BooksUpsertRequest()
            {
                Name = bookTitleTextBox.Text,
                PagesInTotal = (int)totalPagesNumeric.Value,
                YearPublished = (int)publishedInNumeric.Value,
                Subject = subjectsTextBox.Text.ToLower().Trim(),
                CoverImage = request.CoverImage
            };

            var authorIdObj = bookAuthorComboBox.SelectedValue;

            if (int.TryParse(authorIdObj.ToString(), out int authorId))
            {
                searchRequest.AuthorId = authorId;
            }

            var genreIdObj = bookGenreComboBox.SelectedValue;

            if (int.TryParse(genreIdObj.ToString(), out int genreId))
            {
                searchRequest.GenreId = genreId;
            }

            Model.Models.Book bookEntity = null;

            if (!_bookId.HasValue)
                bookEntity = await _bookService.Insert<Model.Models.Book>(searchRequest);
            else
                bookEntity = await _bookService.Update<Model.Models.Book>(_bookId.Value, searchRequest);

            if (bookEntity != null)
            {
                MessageBox.Show("Operation successfull");
            }
        }

        private void SubjectsTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectsTextBox.Text))
            {
                e.Cancel = true;
                bookDetailsErrorProvider.SetError(subjectsTextBox, "You must enter at least one book subject");
            }
            else
            {
                bookDetailsErrorProvider.SetError(subjectsTextBox, null);
            }
        }
    }
}
