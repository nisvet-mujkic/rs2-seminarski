using BookDiary.Desktop.Properties;
using BookDiary.Model.Requests.Quotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Books
{
    public partial class QuoteDetailsForm : Form
    {
        private ApiService _quotesService = new ApiService("Quotes");
        private ApiService _booksService = new ApiService("Books");
        private int? _quoteId = null;
        private int? _bookId = null;
        public QuoteDetailsForm(int? quoteId = null, int? bookId = null)
        {
            InitializeComponent();
            _quoteId = quoteId;
            _bookId = bookId;
        }

        private async void QuoteDetailsForm_Load(object sender, EventArgs e)
        {
            await LoadBooks();
            if (_quoteId.HasValue)
            {
                var quoteEntity = await _quotesService.GetById<Model.Models.Quote>(_quoteId);
                quoteTextBox.Text = quoteEntity.QuoteText;
            }
            if (_bookId.HasValue)
            {
                booksComboBox.SelectedValue = _bookId;
            }
        }

        private async Task LoadBooks()
        {
            var books = await _booksService.Get<List<Model.Models.Book>>(null);
            books.Insert(0, new Model.Models.Book());
            booksComboBox.DisplayMember = "Name";
            booksComboBox.ValueMember = "Id";
            booksComboBox.DataSource = books;
        }

        private async void SubmitQuoteBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new QuotesUpsertRequest()
                {
                    Archived = archiveQuoteCheckBox.Checked,
                    BookId = int.Parse(booksComboBox.SelectedValue.ToString()),
                    QuoteText = quoteTextBox.Text
                };


                Model.Models.Quote entity = null;
                if (!_quoteId.HasValue)
                {
                    entity = await _quotesService.Insert<Model.Models.Quote>(request);
                }
                else
                {
                    entity = await _quotesService.Update<Model.Models.Quote>(_quoteId.Value, request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Operation successfull!");
                    this.Close();
                }
            }
        }

        private void QuoteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quoteTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(quoteTextBox, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(quoteTextBox, null);
            }
        }
    }
}
