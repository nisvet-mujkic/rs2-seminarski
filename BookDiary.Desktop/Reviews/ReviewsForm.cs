using BookDiary.Model.Requests.Reviews;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDiary.Desktop.Reviews
{
    public partial class ReviewsForm : Form
    {
        private readonly ApiService _reviews = new ApiService("Reviews");
        public ReviewsForm()
        {
            InitializeComponent();
            fromDatePicker.Value = fromDatePicker.Value.AddYears(-1);
        }

        private async void ShowReviewsButton_Click(object sender, EventArgs e)
        {
            var searchRequest = new ReviewsSearchRequest()
            {
                From = fromDatePicker.Value,
                To = toDatePicker.Value,
                ShowPendingReviews = pendingCheckBox.Checked,
                ShowApprovedReviews = approvedCheckBox.Checked,
                ShowRejectedReviews = rejectedReviewsCheckBox.Checked,
                IsUserBookLoadingEnabled = true
            };
            await LoadReviews(searchRequest);
        }

        private void ReviewsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var reviewId = int.Parse(reviewsDataGrid.SelectedRows[0].Cells[0].Value.ToString());

                var reviewDetailsForm = new ReviewDetailsForm(reviewId);
                reviewDetailsForm.Show();
            }
            catch (Exception)
            {

            }
        }

        private async Task LoadReviews(ReviewsSearchRequest searchRequest = null)
        {
            var reviews = await _reviews.Get<List<Model.Models.Review>>(searchRequest);
            reviewsDataGrid.AutoGenerateColumns = false;
            reviewsDataGrid.DataSource = reviews;
        }
    }
}
