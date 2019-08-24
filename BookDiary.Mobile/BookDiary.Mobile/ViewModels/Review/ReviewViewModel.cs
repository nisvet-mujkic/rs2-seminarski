using BookDiary.Mobile.Services;
using BookDiary.Model.Requests.Reviews;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Review
{
    public class ReviewViewModel: BaseViewModel
    {
        private readonly ApiService _reviewService = new ApiService("Reviews");
        private readonly int _userBookId = default;
        public ReviewViewModel(int userBookId)
        {
            _userBookId = userBookId;
            InitCommand = new Command(async () => await Init());
            ShareCommand = new Command(async () => await ShareContent());
        }
        private bool _allowRecommend = false;
        public bool AllowRecommend
        {
            get { return _allowRecommend; }
            set { SetProperty(ref _allowRecommend, value); }
        }

        private Model.Models.Review _review = new Model.Models.Review();
        public Model.Models.Review Review
        {
            get { return _review; }
            set { SetProperty(ref _review, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand ShareCommand { get; set; }
        public async Task Init()
        {
            var entity = await _reviewService.GetById<Model.Models.Review>(_userBookId);

            if(entity != null)
            {
                Review = entity;
                AllowRecommend = true;
            }
        }
        public async Task ShareContent()
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = "Nisvet Mujkic",
                Title = "Share Text"
            });
        }

        public async Task AddOrEditReview()

        {
            var request = new ReviewsUpsertRequest()
            {
                QuoteToRemember = Review?.QuoteToRemember,
                Summary = Review?.Summary,
                Rating = Review.Rating,
                UserBookId = _userBookId
            };

            Model.Models.Review review = null;

            if (Review.UserBookId == 0)
            {
                review = await _reviewService.Insert<Model.Models.Review>(request);
            }
            else
            {
                review = await _reviewService.Update<Model.Models.Review>(_userBookId, request);
            }

            if(review != null)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Your review has been submited for review", "OK");
            }
        }
    }

}
