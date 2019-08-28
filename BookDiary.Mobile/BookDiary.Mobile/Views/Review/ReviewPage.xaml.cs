using BookDiary.Mobile.ViewModels.Review;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Review
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewPage : ContentPage
    {
        private readonly ReviewViewModel viewModel;
        public ReviewPage(ReviewViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.viewModel.Init();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await this.viewModel.AddOrEditReview();
            await this.viewModel.Init();
        }

        private async void Button_Clicked_1(object sender, System.EventArgs e)
        {
            await this.viewModel.ShareContent();
        }
    }
}