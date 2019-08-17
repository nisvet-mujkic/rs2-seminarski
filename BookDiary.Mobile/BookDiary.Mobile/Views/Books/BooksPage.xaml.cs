using BookDiary.Mobile.ViewModels.Books;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Books
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksPage : ContentPage
    {
        private readonly BooksViewModel viewModel;
        public BooksPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new BooksViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Init();
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