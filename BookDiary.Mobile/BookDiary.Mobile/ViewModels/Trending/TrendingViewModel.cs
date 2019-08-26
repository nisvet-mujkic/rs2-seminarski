using BookDiary.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Trending
{
    public class TrendingViewModel
    {
        private readonly ApiService _recommendationService = new ApiService("Recommendation");
        public TrendingViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Models.Book> RecommendedBooks { get; set; } = new ObservableCollection<Model.Models.Book>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            try
            {
                var recommendedBooks = await _recommendationService.GetById<List<Model.Models.Book>>(1);

                RecommendedBooks.Clear();
                recommendedBooks.ForEach(book => RecommendedBooks.Add(book));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
