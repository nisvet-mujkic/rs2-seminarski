using BookDiary.Mobile.Services;
using BookDiary.Model.Requests.UserBooks;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Books
{
    public class BookDetailsViewModel: BaseViewModel
    {
        private readonly ApiService _userBooksService = new ApiService("UserBooks");
        public Model.Models.Book Book { get; set; }
        public BookDetailsViewModel(Model.Models.Book book = null)
        {
            Title = book?.Name;
            Book = book;

            AddToReadingListCommand = new Command(async () => await AddToReadingList());
        }

        public ICommand AddToReadingListCommand { get; set; }

        public async Task AddToReadingList()
        {
            try
            {
                object currentUserId = 0;

                Application.Current.Properties.TryGetValue("id", out currentUserId);

                var request = new UserBooksUpsertRequest()
                {
                    BookId = Book.Id,
                    FinishedReadingOn = null,
                    StartedReadingOn = DateTime.Now,
                    UserId = (int)currentUserId
                };

                var userBookEntity = await _userBooksService.Insert<Model.Models.UserBook>(request);

                if(userBookEntity != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "Book has been added to reading list", "OK");
                    //Application.Current.MainPage = new ReadingListPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Something happened", "OK");
                }
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
