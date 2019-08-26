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
        private readonly ApiService _booksService = new ApiService("Books");
        private readonly int _userBookId = default;
        private readonly int _bookId = default;
        public ReviewViewModel(int userBookId, int bookId)
        {
            _userBookId = userBookId;
            _bookId = bookId;
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

        private Model.Models.Book _book = new Model.Models.Book();
        public Model.Models.Book Book
        {
            get { return _book; }
            set { SetProperty(ref _book, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand ShareCommand { get; set; }
        public async Task Init()
        {
            var entity = await _reviewService.GetById<Model.Models.Review>(_userBookId);
            var book = await _booksService.GetById<Model.Models.Book>(_bookId);
            Book = book;

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
                Text = $"Hello there, I have rated this book with a {Review.Rating}." +
                       $"\nThis is what I think about this book in short: >> {Review.Summary} <<." +
                       $"\nThis is the quote that I will remember from this book: >> {Review.QuoteToRemember} <<.",
                Title = $"Recommendation of the book titled {Book.Name} by {Book.Author.Name}"
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
