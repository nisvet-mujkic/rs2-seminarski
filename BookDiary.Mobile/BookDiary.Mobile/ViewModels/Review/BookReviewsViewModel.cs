using BookDiary.Mobile.Services;
using BookDiary.Model.Requests.Reviews;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Review
{
    public class BookReviewsViewModel
    {
        private readonly ApiService _reviews = new ApiService("Reviews");
        private int? _bookId = null;
        public BookReviewsViewModel(int? bookId = null)
        {
            _bookId = bookId;
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Models.Review> Reviews { get; set; } = new ObservableCollection<Model.Models.Review>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            try
            {
                var searchRequest = new ReviewsSearchRequest()
                {
                    BookId = _bookId,
                    IsUserBookLoadingEnabled = true,
                    ShowApprovedReviews = true
                };

                var bookReviews = await _reviews.Get<List<Model.Models.Review>>(searchRequest);

                Reviews.Clear();
                bookReviews.ForEach(review => Reviews.Add(review));
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
