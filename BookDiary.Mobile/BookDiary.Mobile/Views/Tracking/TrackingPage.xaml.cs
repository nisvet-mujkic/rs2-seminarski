using BookDiary.Mobile.ViewModels.Review;
using BookDiary.Mobile.ViewModels.Tracking;
using BookDiary.Mobile.Views.History;
using BookDiary.Mobile.Views.ReadingList;
using BookDiary.Mobile.Views.Review;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Tracking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrackingPage : ContentPage
    {
        private readonly TrackingViewModel viewModel;
        public TrackingPage(TrackingViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.viewModel.Init();
            await TrackerProgressBar.ProgressTo(this.viewModel.Percentage, 900, Easing.Linear);
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await this.viewModel.AddPages();
            await this.viewModel.Init();
            await TrackerProgressBar.ProgressTo(this.viewModel.Percentage, 900, Easing.Linear);
        }

        private async void Button_Clicked_1(object sender, System.EventArgs e)
        {
            await this.viewModel.MarkAsCompleted();
            await Navigation.PushAsync(new HistoryPage());
        }

        private async void Button_Clicked_2(object sender, System.EventArgs e)
        {
            var userBookId = this.viewModel.UserBook.Id;
            var bookId = this.viewModel.Book.Id;
            await Navigation.PushAsync(new ReviewPage(new ReviewViewModel(userBookId, bookId)));
        }
    }
}