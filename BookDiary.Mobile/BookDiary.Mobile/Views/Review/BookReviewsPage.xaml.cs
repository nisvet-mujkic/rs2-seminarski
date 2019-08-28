using BookDiary.Mobile.ViewModels.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Review
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookReviewsPage : ContentPage
    {
        private readonly BookReviewsViewModel viewModel;
        public BookReviewsPage(BookReviewsViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await this.viewModel.Init();
        }
    }
}