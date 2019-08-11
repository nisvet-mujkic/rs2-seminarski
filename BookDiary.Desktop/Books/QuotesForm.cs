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
        public QuotesForm()
        {
            InitializeComponent();
        }

        private void OpenQuoteFormBtn_Click(object sender, EventArgs e)
        {
            var quoteDetails = new QuoteDetailsForm();
            quoteDetails.Show();
        }

        private void ShowQuotesBtn_Click(object sender, EventArgs e)
        {
            //await PopulateQuotesDataGridView();
        }

        private void PopulateQuotesDataGridView()
        {
            
        }

        private void QuotesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var quoteId = int.Parse(quotesDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            var bookId = int.Parse(quotesDataGrid.SelectedRows[0].Cells[1].Value.ToString());

            var quotesDetails = new QuoteDetailsForm(quoteId, bookId);
            quotesDetails.Show();
        }

        private async void QuotesForm_Load(object sender, EventArgs e)
        {
            var searchRequest = new QuotesSearchRequest()
            {
                IsBooksLoadingEnabled = true
            };
            var quotes = await _quotes.Get<List<Model.Models.Quote>>(searchRequest);
            quotesDataGrid.AutoGenerateColumns = false;
            quotesDataGrid.DataSource = quotes;
        }
    }
}
