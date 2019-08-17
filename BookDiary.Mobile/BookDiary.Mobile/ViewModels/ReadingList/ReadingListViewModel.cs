using BookDiary.Mobile.Services;
using BookDiary.Model.Requests.UserBooks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.ReadingList
{
    public class ReadingListViewModel : BaseViewModel
    {
        private ApiService _readingListService = new ApiService("UserBooks");
        public ReadingListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Models.UserBook> CurrentlyReading { get; set; } = new ObservableCollection<Model.Models.UserBook>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            try
            {
                var searchRequest = new UserBooksSearchRequest()
                {
                    UserId = 1,
                    FinishedOn = null,
                    IsBooksLoadingEnabled = true,
                    IsUsersLoadingEnabled = true
                };

                var entities = await _readingListService.Get<List<Model.Models.UserBook>>(searchRequest);

                CurrentlyReading.Clear();
                entities.ForEach((entity) => CurrentlyReading.Add(entity));
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
