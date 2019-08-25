using BookDiary.Desktop.Books;
using BookDiary.Desktop.Reports;
using BookDiary.Desktop.Reports.Books;
using BookDiary.Desktop.Reports.Users;
using BookDiary.Desktop.Reviews;
using BookDiary.Desktop.Users;
using BookDiary.Infrastructure.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookDiary.Desktop
{
    public partial class MainForm : Form
    {
        private readonly ApiService _genresReport = new ApiService("Reports/GenreComparison");
        public MainForm()
        {
            InitializeComponent();
        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            usersForm.Show();
        }

        private async void GenreComparisonReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = await _genresReport.Get<List<GenreComparison>>(null);

            if (results.Any())
            {
                var reportForm = new GenreComparisonViewReport();
                reportForm.GenreComparisonList = results;
                reportForm.Show();
            }
        }

        private void MostActiveUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usersFilterForm = new MostActiveUsersFilter();
            usersFilterForm.Show();
        }

        private void ReportsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booksFilterForm = new MostPopularBooksFilter();
            booksFilterForm.Show();
        }

        private void ReviewsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reviewsForm = new ReviewsForm();
            reviewsForm.Show();
        }

        private void BooksManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booksForm = new BooksForm();
            booksForm.Show();
        }

        private void QuotesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quotesForm = new QuotesForm();
            quotesForm.Show();
        }
    }
}
