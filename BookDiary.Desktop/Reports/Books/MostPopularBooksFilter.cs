using BookDiary.Desktop.Reports.Users;
using BookDiary.Infrastructure.Results;
using BookDiary.Model.Requests.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookDiary.Desktop.Reports.Books
{
    public partial class MostPopularBooksFilter : Form
    {
        private readonly ApiService _userReports = new ApiService("Reports/MostActiveUsers");
        public MostPopularBooksFilter()
        {
            InitializeComponent();
            fromDtp.Value = fromDtp.Value.AddYears(-1);
        }

        private async void ShowReportBtn_Click(object sender, EventArgs e)
        {
            var searchRequest = new MostActiveUsersRequest()
            {
                From = fromDtp.Value,
                To = toDtp.Value
            };

            var results = await _userReports.Get<List<MostActiveUsers>>(searchRequest);

            if (results.Any())
            {
                var activeUsersForm = new MostActiveUsersView();
                activeUsersForm.Users = results;
                activeUsersForm.Show();
            }

        }
    }
}
