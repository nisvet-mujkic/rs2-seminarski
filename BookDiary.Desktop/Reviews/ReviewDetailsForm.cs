using BookDiary.Model.Requests.Reviews;
using System.Windows.Forms;

namespace BookDiary.Desktop.Reviews
{
    public partial class ReviewDetailsForm : Form
    {
        private readonly ApiService _reviewService = new ApiService("Reviews");
        private int? _reviewId = null;
        public ReviewDetailsForm(int? reviewId = null)
        {
            InitializeComponent();
            _reviewId = reviewId;
        }

        private async void ReviewDetailsForm_Load(object sender, System.EventArgs e)
        {
            if (_reviewId.HasValue)
            {
                var review = await _reviewService.GetById<Model.Models.Review>(_reviewId);

                reviewerTxt.Text = review.User.ToString();
                reviewDateTxt.Text = review.CreatedAt.ToString("MM/dd/yyyy");
                ratingTxt.Text = review.Rating.ToString();
                reviewText.Text = review.Summary;
                approveReviewCheckbox.Checked = review.Approved == null ? false : review.Approved.Value;
            }
        }

        private async void FinishReviewForm_Click(object sender, System.EventArgs e)
        {
            var request = new ReviewsUpsertRequest()
            {
                Approved = approveReviewCheckbox.Checked
            };

            var entity = await _reviewService.Update<Model.Models.Review>(_reviewId.Value, request);

            if (entity != null)
            {
                MessageBox.Show("Operation successfull!");
                this.Close();
            }
        }
    }
}
