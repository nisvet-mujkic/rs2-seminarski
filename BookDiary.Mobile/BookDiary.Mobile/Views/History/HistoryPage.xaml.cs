using BookDiary.Mobile.ViewModels.Books;
using BookDiary.Mobile.ViewModels.History;
using BookDiary.Mobile.ViewModels.Tracking;
using BookDiary.Mobile.Views.Books;
using BookDiary.Mobile.Views.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.History
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        private readonly HistoryViewModel viewModel;
        public HistoryPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new HistoryViewModel();
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