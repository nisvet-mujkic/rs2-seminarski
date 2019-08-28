using BookDiary.Mobile.ViewModels.Books;
using BookDiary.Mobile.ViewModels.Trending;
using BookDiary.Mobile.Views.Books;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Trending
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrendingPage : ContentPage
    {
        private readonly TrendingViewModel viewModel;
        public TrendingPage()
        {
            InitializeComponent();
            BindingContext = this.viewModel = new TrendingViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await this.viewModel.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBook = e.SelectedItem as Model.Models.Book;

            if (selectedBook == null)
                return;

            await Navigation.PushAsync(new BookDetailsPage(new BookDetailsViewModel(selectedBook)));
        }
    }
}