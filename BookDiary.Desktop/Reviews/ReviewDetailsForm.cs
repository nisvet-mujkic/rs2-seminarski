using BookDiary.Model.Requests.Reviews;
using System.Windows.Forms;

namespace BookDiary.Desktop.Reviews
{
    public partial class ReviewDetailsForm : Form
    {
        private readonly ApiService _reviewService = new ApiService("Reviews");
        private int? _reviewId = null;
        private Model.Models.Review Review = new Model.Models.Review();
        public ReviewDetailsForm(int? reviewId = null)
        {
            InitializeComponent();
            _reviewId = reviewId;
        }

        private async void ReviewDetailsForm_Load(object sender, System.EventArgs e)
        {
            if (_reviewId.HasValue)
            {
                Review = await _reviewService.GetById<Model.Models.Review>(_reviewId);

                reviewerTxt.Text = Review.UserBook.User.ToString();
                reviewDateTxt.Text = Review.CreatedAt.ToString("MM/dd/yyyy");
                ratingTxt.Text = Review.Rating.ToString();
                reviewText.Text = Review.Summary;
                approveReviewCheckbox.Checked = Review.Approved == null ? false : Review.Approved.Value;
            }
        }

        private async void FinishReviewForm_Click(object sender, System.EventArgs e)
        {
            var request = new ReviewsUpsertRequest()
            {
                Approved = approveReviewCheckbox.Checked,
                QuoteToRemember = Review.QuoteToRemember,
                Archived = Review.Archived,
                Rating = Review.Rating,
                Summary = Review.Summary,
                UserBookId   = Review.UserBookId
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
