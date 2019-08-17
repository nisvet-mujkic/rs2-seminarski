using BookDiary.Mobile.ViewModels.ReadingList;
using BookDiary.Mobile.ViewModels.Tracking;
using BookDiary.Mobile.Views.Tracking;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.ReadingList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReadingListPage : ContentPage
    {
        private readonly ReadingListViewModel viewModel;
        public ReadingListPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ReadingListViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.viewModel.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as Model.Models.UserBook;

            if (selectedItem == null)
                return;

            await Navigation.PushAsync(new TrackingPage(new TrackingViewModel(selectedItem)));
        }

    }
}