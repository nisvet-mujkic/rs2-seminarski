using BookDiary.Mobile.Services;
using BookDiary.Model.Requests.UserBooks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.History
{
    public class HistoryViewModel: BaseViewModel
    {
        private ApiService _readingListService = new ApiService("UserBooks");

        public HistoryViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Models.UserBook> PreviousReadings { get; set; } = new ObservableCollection<Model.Models.UserBook>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            try
            {
                object currentUserId = 0;

                Application.Current.Properties.TryGetValue("id", out currentUserId);

                var searchRequest = new UserBooksSearchRequest()
                {
                    UserId = (int)currentUserId,
                    FinishedOn = DateTime.Now,
                    IsBooksLoadingEnabled = true,
                    IsUsersLoadingEnabled = true
                };

                var entities = await _readingListService.Get<List<Model.Models.UserBook>>(searchRequest);

                PreviousReadings.Clear();
                entities.ForEach((entity) => PreviousReadings.Add(entity));
            }
            catch (System.Exception)
            {

            }
        }
    }
}
