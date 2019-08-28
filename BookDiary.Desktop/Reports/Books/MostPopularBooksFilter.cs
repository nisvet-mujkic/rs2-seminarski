using BookDiary.Desktop.Reports.Users;
using BookDiary.Infrastructure.Results;
using BookDiary.Model.Requests.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Reports.Books
{
    public partial class MostPopularBooksFilter : Form
    {
        private readonly ApiService _userReports = new ApiService("Reports/MostPopularBooks");
        private readonly ApiService _genresService = new ApiService("Genres");
        public MostPopularBooksFilter()
        {
            InitializeComponent();
            fromDtp.Value = fromDtp.Value.AddYears(-1);
        }

        private async void ShowReportBtn_Click(object sender, EventArgs e)
        {
            var searchRequest = new MostPopularBookRequest()
            {
                From = fromDtp.Value,
                To = toDtp.Value
            };

            var genreIdObj = genresComboBox.SelectedValue ?? 0;

            if (int.TryParse(genreIdObj.ToString(), out int genreId))
            {
                searchRequest.GenreId = genreId;
            }


            var results = await _userReports.Get<List<MostPopularBook>>(searchRequest);

            if (results.Any())
            {
                var activeUsersForm = new MostPopularBooksView();
                activeUsersForm.Books = results;
                activeUsersForm.Show();
            }

        }

        private async void MostPopularBooksFilter_Load(object sender, EventArgs e)
        {
            await LoadGenres();

        }

        private async Task LoadGenres()
        {
            var genreEntities = await _genresService.Get<List<Model.Models.Genre>>(null);
            genreEntities.Insert(0, new Model.Models.Genre());
            genresComboBox.DisplayMember = "Name";
            genresComboBox.ValueMember = "Id";
            genresComboBox.DataSource = genreEntities;
        }
    }
}
