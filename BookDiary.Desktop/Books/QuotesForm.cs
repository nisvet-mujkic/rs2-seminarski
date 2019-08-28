using BookDiary.Model.Requests.Quotes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Books
{
    public partial class QuotesForm : Form
    {
        private readonly ApiService _quotes = new ApiService("quotes");
        private readonly ApiService _booksService = new ApiService("Books");
        private readonly ApiService _authorsService = new ApiService("Authors");
        public QuotesForm()
        {
            InitializeComponent();
        }

        private void OpenQuoteFormBtn_Click(object sender, EventArgs e)
        {
            var quoteDetails = new QuoteDetailsForm();
            quoteDetails.Show();
            openQuoteFormBtn.Visible = Properties.Settings.Default.IsAdmin ? true : false;
        }

        private async void ShowQuotesBtn_Click(object sender, EventArgs e)
        {
            var searchRequest = new QuotesSearchRequest()
            {
                IsBooksLoadingEnabled = true
            };

            var bookIdObj = booksComboBox.SelectedValue ?? 0;

            if (int.TryParse(bookIdObj.ToString(), out int bookId))
            {
                searchRequest.BookId = bookId;
            }

            var authorIdObj = authorsComboBox.SelectedValue ?? 0;

            if (int.TryParse(authorIdObj.ToString(), out int authorId))
            {
                searchRequest.AuthorId = authorId;
            }

            var quotes = await _quotes.Get<List<Model.Models.Quote>>(searchRequest);
            quotesDataGrid.AutoGenerateColumns = false;
            quotesDataGrid.DataSource = quotes;
        }

        private void QuotesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var quoteId = int.Parse(quotesDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                var bookId = int.Parse(quotesDataGrid.SelectedRows[0].Cells[1].Value.ToString());

                var quotesDetails = new QuoteDetailsForm(quoteId, bookId);
                quotesDetails.Show();
            }
            catch (Exception)
            {

            }
        }

        private async void QuotesForm_Load(object sender, EventArgs e)
        {
            await LoadAuthors();
            await LoadBooks();
            var searchRequest = new QuotesSearchRequest()
            {
                IsBooksLoadingEnabled = true
            };
            var quotes = await _quotes.Get<List<Model.Models.Quote>>(searchRequest);
            quotesDataGrid.AutoGenerateColumns = false;
            quotesDataGrid.DataSource = quotes;
        }

        private async Task LoadBooks()
        {
            var books = await _booksService.Get<List<Model.Models.Book>>(null);
            books.Insert(0, new Model.Models.Book());
            booksComboBox.DisplayMember = "Name";
            booksComboBox.ValueMember = "Id";
            booksComboBox.DataSource = books;
        }

        private async Task LoadAuthors()
        {
            var authorEntities = await _authorsService.Get<List<Model.Models.Author>>(null);
            authorEntities.Insert(0, new Model.Models.Author());
            authorsComboBox.DisplayMember = "Name";
            authorsComboBox.ValueMember = "Id";
            authorsComboBox.DataSource = authorEntities;
        }
    }
}
